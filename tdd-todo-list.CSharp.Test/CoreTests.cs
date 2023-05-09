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
            Assert.AreEqual("Task1", todoList.GetTask(0));

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

            Assert.AreEqual(new List<string> { "Task1", "Task2" }, tasks);

        }


        //  I want to change the status of a task between incomplete and complete.

        [Test]
        public void TestTaskStatus()
        {
            // Arrange

            var todoList = new TodoList();
            todoList.AddTask("Task 1");

            // Act

            todoList.TaskStatus("Task 1", true);
            var task = todoList.GetTask("Task 1");

            // Assert
            Assert.IsTrue(task.IsComplete);

        }
    }
}