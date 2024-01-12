using NUnit.Framework;
using tdd_todo_list.CSharp.Main.tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList todoList;

        [SetUp]
        public void FirstTest()
        {
            TodoList todoList = new TodoList();
            Assert.Pass();
        }

        [Test]
        [TestCase("Task 1")]
        public void AddTaskTest(string taskName)
        {
            todoList.AddTask(taskName);
            Assert.AreEqual(1 , todoList.GetAllTasks().Count);
        }

        [Test]
        [TestCase("Task 1" , "Task 2")]
        public void GetAllTasksTest(string task1 , string task2)
        {
            todoList.AddTask(task1);
            todoList.AddTask(task2);
            Assert.AreEqual(2 , todoList.GetAllTasks().Count);
        }

        [Test]
        [TestCase("Task 1" , true)]
        public void ChangeTaskStatusTest(string taskName , bool status)
        {
            todoList.AddTask(taskName);
            todoList.ChangeTaskStatus(taskName , status);
            Assert.AreEqual(status , todoList.GetAllTasks()[0].IsComplete);
        }

        [Test]
        [TestCase("Task 1" , true)]
        public void GetCompleteTasksTest(string taskName , bool status)
        {
            todoList.AddTask(taskName);
            todoList.ChangeTaskStatus(taskName , status);
            Assert.AreEqual(1 , todoList.GetCompleteTasks().Count);
        }

        [Test]
        [TestCase("Task 1" , false)]
        public void GetIncompleteTasksTest(string taskName , bool status)
        {
            todoList.AddTask(taskName);
            todoList.ChangeTaskStatus(taskName , status);
            Assert.AreEqual(1 , todoList.GetIncompleteTasks().Count);
        }

        [Test]
        [TestCase("Task 1" , "Task not found")]
        [TestCase("Task 2" , "Task found: Task 2")]
        public void SearchTaskTest(string taskName , string expectedMessage)
        {
            todoList.AddTask("Task 2");
            Assert.AreEqual(expectedMessage , todoList.SearchTask(taskName));
        }

        [Test]
        [TestCase("Task 1")]
        public void RemoveTaskTest(string taskName)
        {
            todoList.AddTask(taskName);
            todoList.RemoveTask(taskName);
            Assert.AreEqual(0 , todoList.GetAllTasks().Count);
        }

        [Test]
        [TestCase("Task 1" , "Task 2")]
        public void GetTasksOrderedAscendingTest(string task1 , string task2)
        {
            todoList.AddTask(task2);
            todoList.AddTask(task1);
            Assert.AreEqual(task1 , todoList.GetTasksOrderedAscending()[0].Name);
        }

        [Test]
        [TestCase("Task 1" , "Task 2")]
        public void GetTasksOrderedDescendingTest(string task1 , string task2)
        {
            todoList.AddTask(task1);
            todoList.AddTask(task2);
            Assert.AreEqual(task2 , todoList.GetTasksOrderedDescending()[0].Name);
        }
    }
}