using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        public TodoList _todoList;

        [SetUp] 
        public void SetUp()
        {
            _todoList = new TodoList();
        }

        [Test]
        public void AddTask()
        {
            var TodoItem = new TodoItem("This is a test item");
            _todoList.AddTask(TodoItem);

            Assert.Contains(TodoItem, _todoList.GetTask());
        }

        [Test]
        public void GetCompletedTasks()
        {
            var item1 = new TodoItem("Completed Task");
            item1.UpdateTask(true);
            var item2 = new TodoItem("Incomplete task");
            _todoList.AddTask(item1);
            _todoList.AddTask(item2);

            var result = _todoList.GetCompletedTasks();

            Assert.Contains(item1, result);
            Assert.IsFalse(result.Contains(item2));
        }

        [Test]
        public void GetIncompleteTasks()
        {
            var item1 = new TodoItem("The completed Task");
            item1.UpdateTask(true);
            var item2 = new TodoItem("The incomplete Task");
            _todoList.AddTask(item1);
            _todoList.AddTask(item2);

            var result = _todoList.GetIncompleteTasks();

            Assert.Contains(item2, result);
            Assert.IsFalse(result.Contains(item1));
        }

        [Test]
        public void SearchTask()
        {
            var item = new TodoItem("Search for the task");
            _todoList.AddTask(item);

            var result = _todoList.SearchTask("Search for the task");

            Assert.AreEqual(item, result);
        }

        [Test]
        public void RemoveTask()
        {
            var item = new TodoItem("This is the task to remove");
            _todoList.AddTask(item);
            _todoList.RemoveTask(item);

            Assert.IsFalse(_todoList.GetTask().Contains(item));
        }

        [Test]
        public void TasksAscendingOrder()
        {
            var item1 = new TodoItem("Second Task");
            var item2 = new TodoItem("First Task");
            var item3 = new TodoItem("Third Task");
            _todoList.AddTask(item1);
            _todoList.AddTask(item2);
            _todoList.AddTask(item3);

            var orderedTasks = _todoList.TasksAscendingOrder();

            Assert.AreEqual(item2, orderedTasks[0]);
            Assert.AreEqual(item1, orderedTasks[1]);
            Assert.AreEqual(item3, orderedTasks[2]);
        }

        [Test]
        public void TasksDescendingOrder()
        {
            var item1 = new TodoItem("Second Task");
            var item2 = new TodoItem("First Task");
            var item3 = new TodoItem("Third Task");
            _todoList.AddTask(item1);
            _todoList.AddTask(item2);
            _todoList.AddTask(item3);

            var orderedTasks = _todoList.TasksDescendingOrder();

            Assert.AreEqual(item3, orderedTasks[0]);
            Assert.AreEqual(item1, orderedTasks[1]);
            Assert.AreEqual(item2, orderedTasks[2]);
        }
    }

}