using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskToList()

        {
            //arrange
            var todoList = new TodoList();

            //act
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");

   
            //assert
            var allTasks = todoList.GetAllTasks();
            Assert.AreEqual(2, allTasks.Count);
            Assert.IsTrue(allTasks.Contains("Task 1"));
            Assert.IsTrue(allTasks.Contains("Task 2"));
        }
        [Test]
        public void GetAllTasks()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");
            todoList.AddTask("Task 3");


            //act
            var allTasks = todoList.GetAllTasks();


            //assert
            Assert.AreEqual(3, allTasks.Count);
            Assert.That(allTasks.Contains("Task 1"));
            Assert.That(allTasks.Contains("Task 2"));
            Assert.That(allTasks.Contains("Task 3"));

        }
        [Test]
        public void ChangeTaskStatus()
        {

            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
          

            //act
            todoList.ChangeTaskStatus("Task 1");
            var TaskWhenComplete = todoList.GetTaskStatus("Task 1");

            todoList.ChangeTaskStatus("Task 1");
            var TaskWhenIncomplete = todoList.GetTaskStatus("Task 1");

            //assert
            Assert.That(TaskWhenComplete);
            Assert.IsFalse(TaskWhenIncomplete);

        }

        [Test]

        public void GetCompletedTasks()
        {

            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");
            todoList.AddTask("Task 3");

            //act
            todoList.ChangeTaskStatus("Task 1"); //Marking task 1 and 2 as complete. Task 3 stays incomplete.
            todoList.ChangeTaskStatus("Task 2");
            var completedTasks = todoList.GetCompletedTasks();

            //assert
            Assert.That(completedTasks.Contains("Task 1"));
            Assert.That(completedTasks.Contains("Task 2"));
            Assert.IsFalse(completedTasks.Contains("Task 3"));
        
        }
        [Test]
        public void GetInCompletedTasks()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");
            todoList.AddTask("Task 3");

            //act
            todoList.ChangeTaskStatus("Task 1"); //Marking task 1 and 2 as complete. Task 3 stays incomplete.
            todoList.ChangeTaskStatus("Task 2");
            var incompletedTasks = todoList.GetInCompletedTasks();

            //assert
            Assert.IsFalse(incompletedTasks.Contains("Task 1"));
            Assert.IsFalse(incompletedTasks.Contains("Task 2"));
            Assert.That(incompletedTasks.Contains("Task 3"));

        }

        [Test]
        public void SearchTask()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");

            //act
            var result = todoList.SearchTask("Task 3");

            //assert
            Assert.AreEqual("Task not found.", result);  
        }

        [Test]
        public void RemoveTaskFromToDoList()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");

            //act
            var result = todoList.RemoveTask("Task 1");

            //assert
            Assert.IsFalse(result.Contains("Task 1"));
        }


        [Test]
        public void TasksSortedAscending()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 3");
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");

            //act
            var allTasksSorted = todoList.GetAllTasksAscending();

            //assert
            Assert.AreEqual(3, allTasksSorted.Count);  
            Assert.AreEqual("Task 1", allTasksSorted[0]);  
            Assert.AreEqual("Task 2", allTasksSorted[1]);  
            Assert.AreEqual("Task 3", allTasksSorted[2]);  
        }

        [Test]
        public void TasksSortedDescending()
        {
            //arrange
            var todoList = new TodoList();
            todoList.AddTask("Task 3");
            todoList.AddTask("Task 1");
            todoList.AddTask("Task 2");

            //act
            var allTasksSorted = todoList.GetAllTasksDescending();

            //assert
            Assert.AreEqual(3, allTasksSorted.Count);  
            Assert.AreEqual("Task 1", allTasksSorted[2]);  
            Assert.AreEqual("Task 2", allTasksSorted[1]); 
            Assert.AreEqual("Task 3", allTasksSorted[0]);  
        }



    }
}