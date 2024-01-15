using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;
using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        public void AddElements(TodoList list)
        {
            Dictionary<string, bool> newList = new Dictionary<string, bool>()
            {
                { "Laundry", false },
                { "Clean", false },
                { "Build", true }
            };

            foreach (var task in newList)
            {
                list.Add(task.Key, task.Value);
            }
        }

        [Test]
        public void FirstFirstTest()
        {
            TodoList core = new TodoList();
            bool result = false;

            Dictionary<string, bool> newList = new Dictionary<string, bool>()
            {
                { "Laundry", false },
                { "Clean", false },
                { "Build", false }
            };

            foreach (var task in newList)
            {
                result = core.Add(task.Key, task.Value);
                if (!result) { break; }
            }


            Assert.IsTrue(result);
        }

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();

            AddElements(core);

            int result = core.PrintAll();

            Assert.AreEqual(result, 3);
        }

        [Test]
        public void SecondTest()
        {
            TodoList core = new TodoList();

            core.Add("Laundry", false);
            bool result = core.ChangeStatus("Laundry", true);

            Assert.IsTrue(result);
        }

        [Test]
        public void ThirdTest()
        {
            TodoList core = new TodoList();
            AddElements(core);

            int result = core.PrintAllCompleteTasks();

            Assert.AreEqual(result, 1);
        }

        [Test]
        public void FourthTest()
        {
            TodoList core = new TodoList();
            AddElements(core);

            int result = core.PrintAllIncompleteTasks();

            Assert.AreEqual(result, 2);
        }

        [Test]
        public void FifthTest()
        {
            TodoList core = new TodoList();

            core.Add("Laundry", false);
            bool result = core.Search("laundry");

            Assert.IsTrue(result);
        }

        [Test]
        public void SixthTest()
        {
            TodoList core = new TodoList();

            core.Add("Clean", false);
            bool result = core.Remove("clean");

            Assert.IsTrue(result);
        }

        [Test]
        public void SeventhTest()
        {
            TodoList core = new TodoList();

            core.Add("Laundry", false);
            core.Add("Wash Clothes", true);
            core.Add("xyz", false);
            core.Add("Dinner", false);
            core.Add("Call Mom", false);
            core.Add("abc", true);

            string result = core.PrintAllAlphabeticAsc();

            Assert.AreEqual(result, "abc");
        }

        [Test]
        public void EigthTest()
        {
            TodoList core = new TodoList();

            core.Add("Laundry", false);
            core.Add("Wash Clothes", true);
            core.Add("xyz", false);
            core.Add("Dinner", false);
            core.Add("Call Mom", false);
            core.Add("abc", true);

            string result = core.PrintAllAlphabeticDesc();

            Assert.AreEqual(result, "xyz");
        }
    }
}