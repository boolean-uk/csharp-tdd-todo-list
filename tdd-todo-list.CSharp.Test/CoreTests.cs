using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        // I want to add tasks to my todo list.
        [Test]
        public void TestTaskToList()
        {
            //Arrange

             var todoList = new TodoList();

            // Act
             todoList.AddTask("Task1");


            // Assert
            Assert.AreEqual(1, todoList.Count);
            Assert.AreEqual("Task1", todoList.GetTask(0).Name);

        }

        // I want to see all the tasks in my todo list.

        [Test]
        public void TestAllTheTasks()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Task1");
            todoList.AddTask("Task2");

            // Act

            var tasks = todoList.GetAllTasks();

            // Assert

            Assert.AreEqual(new List<string> { "Task1", "Task2" }, tasks.ConvertAll(task => task.Name));

        }


        //  I want to change the status of a task between incomplete and complete.

        [Test]
        public void TestTaskStatus()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Task 1");

            // Act

            todoList.ChangeTaskStatus("Task 1", true);
            var task = todoList.GetTask("Task 1");

            // Assert
            Assert.IsTrue(todoList.GetTask("Task 1").IsComplete);

        }

        // I want to be able to get only the complete tasks

        [Test]
        public void CompletedTasks()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Clean");
            todoList.AddTask("Breathe");



           

            // Assert
            Assert.IsFalse(todoList.GetTask("Clean").IsComplete );
            Assert.IsFalse(todoList.GetTask("Breathe").IsComplete );



            // Act

            todoList.ChangeTaskStatus("Clean", true);
            var tasks = todoList.GetCompletedTasks();


           Assert.AreEqual(new List<string> { "Clean" }, tasks.ConvertAll(task => task.Name));
        }

        // I want to be able to get only the incomplete tasks

        [Test]
        public void TestIncompletedTasks()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Buy");
            todoList.AddTask("Cry");

            //Assert

            Assert.IsFalse(todoList.GetTask("Buy").IsComplete);
            Assert.IsFalse(todoList.GetTask("Cry").IsComplete);


            // Act

            todoList.ChangeTaskStatus("Buy", true);
            var tasks = todoList.GetCompletedTasks();

            //Assert

            Assert.AreEqual(new List<string> {"Buy"}, tasks.ConvertAll(task => task.Name));
        }

        // I want to search for a task and receive a message that says it wasn't found if it doesn't exist.

        [Test]
        public void TestSearchTask()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Smile");

            // Act

            string message1 = todoList.SearchTask("Smile");
            string message2 = todoList.SearchTask("Laugh");


            // Assert

            Assert.AreEqual("Task is found!", message1);
            Assert.AreEqual("Task is not found!", message2);

        }

    }
}