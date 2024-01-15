using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Linq;

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
        public void AddTest()
        {
            //arrange
            TodoList core = new TodoList();
            //act
            
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            
            //assert
            Assert.IsTrue(core.myList.ContainsKey("Buy groceries"));
        }

        [Test]
        public void AllTasksTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            var tasks = core.myList.Select(t => t.Key).ToList();
            //assert
            Assert.AreEqual(3, tasks.Count);
        }

        [Test]
        public void IsCompleteTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            core.changeStatus("Paint the walls", true);
            //assert
            Assert.IsTrue(core.myList["Paint the walls"]);
        }
        [Test]
        public void GetCompleteTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            List<string> result = core.GetComplete();
            //assert
            Assert.AreEqual(1, result.Count);
        }
        [Test]
        public void GetIncompleteTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            List<string> result = core.GetIncomplete();
            //assert
            Assert.AreEqual (2, result.Count);
        }
        [Test]
        public void FindTaskTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            string newTask = "Mow the lawn";
            bool found = core.Find(newTask);
            //assert
            Assert.IsFalse(found);
        }
        [Test]
        public void RemoveTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            core.myList.Remove("Paint the walls");
            core.myList.Remove("Buy groceries");
            //assert
            Assert.AreEqual(1, core.myList.Count);
        }

        [Test]
        public void AscendingTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            core.myList.Add("Assemble the table", true);
            Dictionary<string, bool> sorted = core.Ascending(core.myList);
            int index = Array.IndexOf(sorted.Keys.ToArray(), "Assemble the table");
            //assert
            Assert.AreEqual(0, index);
        }
        [Test]
        public void DescendingTest()
        {
            //arrange
            TodoList core = new TodoList();
            core.myList.Add("Buy groceries", false);
            core.myList.Add("Paint the walls", false);
            core.myList.Add("Feed the cats", true);
            //act
            core.myList.Add("Assemble the table", true);
            Dictionary<string, bool> sorted = core.Descending(core.myList);
            int index = Array.IndexOf(sorted.Keys.ToArray(), "Assemble the table");
            //assert
            Assert.AreEqual(3, index);
        }
    }
}