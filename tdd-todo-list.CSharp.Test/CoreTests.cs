using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTest()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("Make a TodoList", false);
            TodoList core = new TodoList();
            core.AddTask("Make a TodoList", false);
            core.PrintList(core.GetList);
            Assert.AreEqual(core.GetList, correctList);

        }

        [Test]
        public void ChangeStatusTest()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("Make a TodoList", true);
            TodoList core = new TodoList();
            core.AddTask("Make a TodoList", false);
            core.ChangeStatus("Make a TodoList");
            Assert.AreEqual(core.GetList, correctList);
        }

        [Test]
        public void GetTaskStatusTest()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("Make a AddTest", true);
            correctList.Add("Make a ChangeStatusTest", true);
            correctList.Add("Make a SearchTest", true);
            correctList.Add("Make a GetTaskStatusList", true);
            correctList.Add("Make a TodoList", true);
            TodoList core = new TodoList();
            core.AddTask("Make a AddTest", true);
            core.AddTask("Make a ChangeStatusTest", true);
            core.AddTask("Make a SearchTest", true);
            core.AddTask("Make a GetTaskStatusList", true);
            core.AddTask("Make a TodoList", true);
            core.AddTask("Make a Remove Task test", false);
            core.AddTask("Make a AscSortTest", false);
            core.AddTask("Make a DescSortTest", false);
            Assert.AreEqual(core.GetTasks(true), correctList);

        }

        [Test]
        public void RemoveTest()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("Make a TodoList", true);
            correctList.Add("Make a ChangeStatusTest", true);
            TodoList core = new TodoList();
            core.AddTask("Make a RemoveTest", false);
            core.AddTask("Make a ChangeStatusTest", true);
            core.AddTask("Make a TodoList", true);

            core.RemoveTask("Make a RemoveTest");
            Assert.AreEqual(core.GetList, correctList);
        }

        [Test]
        public void DescSortList()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("z", true);
            correctList.Add("a", true);

            TodoList core = new TodoList();
            core.AddTask("a", true);
            core.AddTask("z", true);
            Assert.AreEqual(core.DescSortList(),correctList);
        }

        [Test]
        public void AscSortList()
        {
            Dictionary<string, bool> correctList = new Dictionary<string, bool>();
            correctList.Add("a", true);
            correctList.Add("z", true);

            TodoList core = new TodoList();
            core.AddTask("z", true);
            core.AddTask("a", true);
            Assert.AreEqual(core.AscSortList(), correctList);
        }



        [TestCase("Make a TodoList", false)]
        public void SearchTestFound(string task, bool status)
        {
            TodoList core = new TodoList();
            core.AddTask(task, status);
            Assert.IsTrue(core.Search(task));
        }

        [TestCase("Make a TodoList", false)]
        public void SearchTestNotFound(string task, bool status)
        {
            TodoList core = new TodoList();
            Assert.IsFalse(core.Search(task));
        }
    }
}