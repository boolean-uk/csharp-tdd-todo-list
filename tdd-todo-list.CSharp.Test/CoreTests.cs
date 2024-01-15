using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList _todo;

        public CoreTests() {
            _todo = new TodoList();
        }

        [TestCase ("Clean")]
        [TestCase ("Lift Weight")]
        [TestCase ("Cook Food")]
        public void TestAddOneTask(string task) {

            Assert.That(_todo.AddTask(task), Is.EqualTo(true));
        }
        

        [Test]
        public void TestForEmpty() {

            Assert.That(_todo.AddTask(""), Is.EqualTo(true));
        }

        [Test]
        public void TestGetAllTasks()
        {
            _todo.AddTask("Cook Food");
            _todo.AddTask("Clean");
            _todo.AddTask("Lift Weight");

            Dictionary<string, int> tasks = _todo.GetTasks();

            Assert.IsInstanceOf<Dictionary<string, int>>(tasks);
            Assert.That(tasks.ContainsKey("Cook Food"), Is.EqualTo(true));
            Assert.That(tasks, Contains.Key("Clean"));
            Assert.That(tasks, Contains.Key("Lift Weight"));
            Assert.AreEqual(0, tasks["Cook Food"]);
            Assert.AreEqual(0, tasks["Clean"]);
            Assert.AreEqual(0, tasks["Lift Weight"]);
        }

        [TestCase ("Clean", true)]
        [TestCase ("Lift Weight", true)]
        [TestCase ("sdfasdas", false)]
        public void TestRemoveTask(string task, bool expected)
        {
            _todo.AddTask("Cook Food");
            _todo.AddTask("Clean");
            _todo.AddTask("Lift Weight");
            Assert.That(_todo.RemoveTask(task), Is.EqualTo(expected));
        }

        [TestCase ("Clean", true)]
        [TestCase ("Lift Weight", false)]
        [TestCase ("sdfasdas", false)]
        public void TestGetCompleted(string task, bool expectedCompletionStatus)
        {
            _todo.AddTask("Cook Food");
            _todo.AddTask("Clean");
            _todo.ChangeStatus("Clean", 1);
            _todo.AddTask("Lift Weight");

            List<string> completedTasks = _todo.GetTasksByStatus(1);

            Assert.AreEqual(expectedCompletionStatus, completedTasks.Contains(task));
        }

        [Test]
        public void OrderAlphabeticallyShouldReturnTasksInAlphabeticalOrder()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Do laundry");
            todoList.AddTask("Buy groceries");
            todoList.AddTask("Update Kernel");

            List<string> orderedTasks = todoList.OrderAlphabetically();
            Assert.AreEqual(3, orderedTasks.Count);
            Assert.IsTrue(orderedTasks[0] == "Buy groceries");
            Assert.IsTrue(orderedTasks[1] == "Do laundry");
            Assert.IsTrue(orderedTasks[2] == "Update Kernel");
        }

        [Test]
        public void OrderByDescendingShouldReturnTasksInDescendingOrder()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Do laundry");
            todoList.AddTask("Buy groceries");
            todoList.AddTask("Update Kernel");

            List<string> orderedTasks = todoList.OrderByDescending();
            Assert.AreEqual(3, orderedTasks.Count);
            Assert.Contains("Update Kernel", orderedTasks);
            Assert.Contains("Do laundry", orderedTasks);
            Assert.Contains("Buy groceries", orderedTasks);
            Assert.IsTrue(orderedTasks[0] == "Update Kernel");
            Assert.IsTrue(orderedTasks[1] == "Do laundry");
            Assert.IsTrue(orderedTasks[2] == "Buy groceries");
        }
    }
}