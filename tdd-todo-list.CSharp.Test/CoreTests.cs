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
        public void AddTask()
        {
            TodoList toDoList = new TodoList();

            toDoList.AddTask("Buy groceries");
            var tasks = toDoList.ShowTasks();

            var expected = new List<string> { "1. Buy groceries - False" };
            CollectionAssert.AreEqual(expected, tasks);
        }

        [Test]
        public void FindTask()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");
            toDoList.AddTask("Call");

            var taskFound = toDoList.FindTask("Buy groceries");
            var taskNotFound = toDoList.FindTask("Non-existent task");

            Assert.AreEqual("Buy groceries - False", taskFound);
            Assert.AreEqual("no task named: Non-existent task", taskNotFound);
        }

        [Test]
        public void RemoveTask()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");

            var removeSuccess = toDoList.RemoveTask("Buy groceries");
            var removeFailure = toDoList.RemoveTask("tasks");
            var tasksAfterRemoval = toDoList.ShowTasks();

            Assert.AreEqual("removed Buy groceries", removeSuccess);
            Assert.AreEqual("could not find: 'tasks'", removeFailure);
            CollectionAssert.AreEqual(new List<string> { "no tasks" }, tasksAfterRemoval);
        }

        [Test]
        public void ToggleStatus()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");

            var toggleSuccess = toDoList.ToggleStatus("Buy groceries");
            var taskStatusAfterToggle = toDoList.FindTask("Buy groceries");
            var toggleFailure = toDoList.ToggleStatus("Non-existent task");

            Assert.IsTrue(toggleSuccess);
            Assert.AreEqual("Buy groceries - True", taskStatusAfterToggle);
            Assert.IsFalse(toggleFailure);
        }

        [Test]
        public void ShowComplete()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");
            toDoList.AddTask("run");
            toDoList.ToggleStatus("run");

            var completeTasks = toDoList.ShowComplete();

            var expected = new List<string> { "2. run - True" };
            CollectionAssert.AreEqual(expected, completeTasks);
        }

        [Test]
        public void ShowInComplete()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");
            toDoList.AddTask("run");
            toDoList.ToggleStatus("run");

            var incompleteTasks = toDoList.ShowInComplete();

            var expected = new List<string> { "1. Buy groceries - False" };
            CollectionAssert.AreEqual(expected, incompleteTasks);
        }

        [Test]
        public void ShowAscending()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");
            toDoList.AddTask("run");

            var ascendingTasks = toDoList.ShowAscending();

            var expected = new List<string> { "Buy groceries, False", "run, False" };
            CollectionAssert.AreEqual(expected, ascendingTasks);
        }

        [Test]
        public void ShowDescending()
        {
            TodoList toDoList = new TodoList();
            toDoList.AddTask("Buy groceries");
            toDoList.AddTask("run");

            var descendingTasks = toDoList.ShowDescending();

            var expected = new List<string> { "run, False", "Buy groceries, False" };
            CollectionAssert.AreEqual(expected, descendingTasks);
        }
    }
}
