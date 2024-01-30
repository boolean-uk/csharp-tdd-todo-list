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
        public void TestTaskIsAdded()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            Assert.IsTrue(todoList.tasks.Contains(task));
        }

        [Test]
        public void TestShowTask()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            Assert.AreEqual("Do groceries - Incomplete", task.ToString());
        }

        [Test]
        public void TestStatusDefaultIsFalse()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            Assert.IsFalse(task.isComplete);
        }

        [Test]
        public void TestChangeStatus()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.ChangeStatus(task);
            Assert.IsTrue(task.isComplete);
        }

        [Test]
        public void TestFilterCompleted()
        {
            TodoList todoList = new TodoList();
            Task task = new Task("Do groceries", true);
            Task task2 = new Task("Clean", false);
            todoList.AddTask(task);
            todoList.AddTask(task2);
            Assert.IsTrue(todoList.GetComplete().Contains(task) && !todoList.GetComplete().Contains(task2));
        }

        [Test]
        public void TestFilterIncomplete()
        {
            TodoList todoList = new TodoList();
            Task task = new Task("Do groceries", true);
            Task task2 = new Task("Clean", false);
            todoList.AddTask(task);
            todoList.AddTask(task2);
            Assert.IsTrue(todoList.GetIncomplete().Contains(task2) && !todoList.GetIncomplete().Contains(task));
        }

        [Test]
        public void TestSearchTask()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            Assert.AreEqual("Do groceries", todoList.SearchTask(task));
        }

        [Test]
        public void TestSearchFail()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            Assert.AreEqual("The task was not found", todoList.SearchTask(task));
        }

        [Test]
        public void TestRemoveTask()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.RemoveTask(task);
            Assert.IsFalse(todoList.tasks.Contains(task));
        }

        [Test]
        public void TestRemoveFail()
        {
            Task task = new Task("Do groceries");
            TodoList todoList = new TodoList();
            todoList.RemoveTask(task);
            Assert.AreEqual("The task was not found", todoList.RemoveTask(task));
        }

        [Test]
        public void TestSortAsc()
        {
            TodoList todoList = new TodoList();
            Task task = new Task("Z");
            Task task2 = new Task("A");
            todoList.AddTask(task);
            todoList.AddTask(task2);
            Assert.AreEqual("A", todoList.SortAsc()[0].name);
        }

        [Test]
        public void TestSortDesc()
        {
            TodoList todoList = new TodoList();
            Task task = new Task("A");
            Task task2 = new Task("Z");
            todoList.AddTask(task);
            todoList.AddTask(task2);
            Assert.AreEqual("Z", todoList.SortDesc()[0].name);
        }
    }
}