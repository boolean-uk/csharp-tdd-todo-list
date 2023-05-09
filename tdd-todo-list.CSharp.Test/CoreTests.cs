using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        public CoreTests()
        {
        }

        [TestCase("Workout", true, true)]
        [TestCase("See the doctor", false, true)]
        [TestCase("Make bed", true, true)]
        public void AddTaskTest(string text, bool completed, bool expected)
        {
            TodoList _core = new TodoList();
            Assert.IsTrue(_core.AddTask(text, completed) == expected);
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.AreEqual(_core.GetAllTasks(), 2);
        }

        [TestCase(2, true, true)]
        [TestCase(7, true, false)]
        public void UpdateStatusTest(int id, bool changeStatus, bool expected)
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.IsTrue(_core.UpdateStatus(id, changeStatus) == expected);
        }

        [TestCase(2, true)]
        [TestCase(5, false)]
        public void RemoveTaskTest(int id, bool expected)
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.IsTrue(_core.RemoveTask(id) == expected);
        }

        [TestCase(1, "Task found")]
        [TestCase(5, "Task not found")]
        public void SearchForATaskTest(int id, string expectedString)
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.AreEqual(_core.SearchForATask(id), expectedString);
        }

        [Test]
        public void GetCompletedTasksTest()
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.AreEqual(_core.GetCompletedTasks(), 1);
        }

        [Test]
        public void GetIncompletedTasksTest()
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            _core.AddTask("Make bed", false);
            Assert.AreEqual(_core.GetIncompletedTasks(), 2);
        }

        [TestCase(1, true)]
        [TestCase(4, false)]
        public void GetATaskTest(int id, bool expected)
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            List<Tuple<int, string, bool>> list = _core.GetATask(id);
            Tuple<int, string, bool> tuple = list.FirstOrDefault(x => x.Item1 == id);
            if (expected == true)
            {
                Assert.AreEqual(tuple.Item1, id);
            } else
            {
                Assert.IsNull(tuple);
            }
        
        }

        [TestCase(1, "Swimming", true)]
        [TestCase(4, "Whatever", false)]
        public void UpdateNameTest(int id, string name, bool expected)
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            Assert.AreEqual(_core.UpdateName(id, name), expected);
        }

        [Test]
        public void OrderedAlphabeticallyInAscendingTest()
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            _core.AddTask("Make bed", false);
            Assert.IsTrue(_core.OrderedAlphabeticallyInAscending()[0].Item2 == "Make bed");
        }

        [Test]
        public void OrderedAlphabeticallyInDecendingTest()
        {
            TodoList _core = new TodoList();
            _core.AddTask("Workout", true);
            _core.AddTask("See the doctor", false);
            _core.AddTask("Make bed", false);
            Assert.IsTrue(_core.OrderedAlphabeticallyInDecending()[0].Item2 == "Workout");
        }
    }
}