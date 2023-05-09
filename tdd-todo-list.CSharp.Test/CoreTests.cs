using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList _core;
        public CoreTests()
        {
            _core = new TodoList();
        }

        [Test]
        public void checkIfAdded()
        {
            _core.AddTask("New Task", true);
            Assert.IsTrue(_core._myList.ContainsKey("New Task"));
        }

        [Test]
        public void checkIfStatusChanged()
        {
            _core.changeStatus("New Task");
            Assert.IsTrue(_core._myList["New Task"] == false);
        }

        [Test]
        public void checkTheCompletedTasks()
        {
            Dictionary<string, bool> myList = _core.GetCompletedTasks();
            bool allGood = false;
            foreach (KeyValuePair<string, bool> item in myList)
            {
                if (item.Value == false)
                {
                    allGood = true;
                    break;
                }
            }
            Assert.IsTrue(allGood == false);
        }

        [Test]
        public void checkTheIncompletedTasks()
        {
            Dictionary<string, bool> myList = _core.GetIncompletedTasks();
            bool allGood = false;
            foreach (KeyValuePair<string, bool> item in myList)
            {
                if (item.Value == true)
                {
                    allGood = true;
                    break;
                }
            }
            Assert.IsTrue(allGood == false);
        }

        [Test]
        public void checkIfTaskExist()
        {
            Assert.AreEqual(_core.searchTask("New Task"), "The task you are looking for exist in the to do list");
        }

        [Test]
        public void checkIfTaskRemoved()
        {
            _core.removeTask("New Task");
            Assert.IsTrue(_core._myList.ContainsKey("New Task") == false);
        }

        [Test]
        public void checkIfAscending()
        {
            List<string> myListTask = _core._myList.Keys.ToList();
            myListTask.Sort();
            Assert.AreEqual(myListTask, _core.getAscending());
        }

        [Test]
        public void checkIfDescending()
        {
            List<string> myListTask = _core._myList.Keys.ToList();
            myListTask.Sort();
            myListTask.Reverse();
            Assert.AreEqual(myListTask, _core.getDescending());
        }
    }
}