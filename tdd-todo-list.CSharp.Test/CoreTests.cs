using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        private TodoList _core;
        public CoreTests()
        {
            _core = new TodoList();
        }

        [TestCase("Workout", true, true)]
        [TestCase("See the doctor", false, true)]
        [TestCase("Make bed", true, true)]

        public void AddTaskTest(string text, bool completed, bool expected)
        {
            Assert.IsTrue(_core.AddTask(text, completed) == expected);
        }

        [TestCase(2, true, true)]
        public void UpdateStatusTest(int id, bool changeStatus, bool expected)
        {
            Assert.IsTrue(_core.UpdateStatus(id, changeStatus) == expected);
        }

        //[TestCase(2)]
        public void RemoveTaskTest(int id)
        {
            _core.RemoveTask(id);
            Assert.IsTrue(_core.tasks.Count() == 2);
        }
    }
}