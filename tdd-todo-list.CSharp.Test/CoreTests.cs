using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        [Test]
        public void AddTaskAndGetAllTasks()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");
            todoList.AddTask("Task2");

            List<string> allTasks = todoList.GetAllTasks();

            Assert.AreEqual(2, allTasks.Count);
            Assert.Contains("Task1", allTasks);
            Assert.Contains("Task2", allTasks);
        }

       

      
        [Test]
        public void ChangeTaskStatus()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");

            todoList.ChangeTaskStatus("Task1", true);

            List<string> completeTasks = todoList.GetCompleteTasks();
            Assert.AreEqual(1, completeTasks.Count);
            Assert.Contains("Task1", completeTasks);
        }

        [Test]
        public void GetIncompleteTasks()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");
            todoList.AddTask("Task2");
            todoList.ChangeTaskStatus("Task1", true);

            List<string> incompleteTasks = todoList.GetIncompleteTasks();

            Assert.AreEqual(1, incompleteTasks.Count);
            Assert.Contains("Task2", incompleteTasks);
        }

        [Test]
        public void SearchTaskNotFound()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");

            bool found = todoList.SearchTask("Task2");

            Assert.IsFalse(found);
        }

        [Test]
        public void SearchTaskFound()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");

            bool found = todoList.SearchTask("Task1");

            Assert.IsTrue(found);
        }

        [Test]
        public void RemoveTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task1");

            todoList.RemoveTask("Task1");

            List<string> allTasks = todoList.GetAllTasks();
            Assert.AreEqual(0, allTasks.Count);
        }

        [Test]
        public void GetAllTasksOrderedAscending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task2");
            todoList.AddTask("Task1");

            List<string> orderedTasks = todoList.GetAllTasksOrderedAscending();

            Assert.AreEqual(2, orderedTasks.Count);
            Assert.AreEqual("Task1", orderedTasks[0]);
            Assert.AreEqual("Task2", orderedTasks[1]);
        }

        [Test]
        public void GetAllTasksOrderedDescending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Task2");
            todoList.AddTask("Task1");

            List<string> orderedTasks = todoList.GetAllTasksOrderedDescending();

            Assert.AreEqual(2, orderedTasks.Count);
            Assert.AreEqual("Task2", orderedTasks[0]);
            Assert.AreEqual("Task1", orderedTasks[1]);
        }


    }
}