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
        public void Add()
        {
            // arrange
            TodoList core = new TodoList();
            string msg = "Pick up cake";
            Item item = new Item()
            {
                message = msg,
                completed = false
            };

            // act 
            core.Add(item);
            Item item1 = core.items.First();
            
            // assert
            Assert.AreEqual(item, item1);
            Assert.IsTrue(core.items.Count() == 1);
        }

        [Test]
        public void View()
        {
            // arrange
            TodoList core = new TodoList();
            string msg = "Pick up cake";
            Item item = new Item()
            {
                message = msg.ToLower(),
                completed = false
            };
            core.Add(item);
            List<Item> expected_result = new List<Item>() {item};

            // act 
            List<Item> result = core.View();            

            // assert
            Assert.AreEqual(expected_result, result);            
        }

        [Test]
        public void change()
        {
            // arrange
            TodoList core = new TodoList();
            string msg = "Pick up cake";
            Item item = new Item()
            {
                message = msg.ToLower(),
                completed = false
            };
            core.Add(item);            

            // act
            bool result = core.Change(msg, true);

            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void OnlyCompletedTasks()
        {
            // arrange
            TodoList core = new TodoList();

            Item item = new Item()
            {
                message = "Pick up cake".ToLower(),
                completed = true
            };
            Item item2 = new Item()
            {
                message = "Pick up shoes".ToLower(),
                completed = false
            };
            Item item3 = new Item()
            {
                message = "Send letter".ToLower(),
                completed = false
            };
            core.Add(item);
            core.Add(item2);
            core.Add(item3);

            // act
            List<Item> result = core.CompletedTasks();

            // assert
            Assert.IsTrue(result.All(x => x.completed == true));
        }

        [Test]
        public void OnlyIncompletedTasks()
        {
            // arrange
            TodoList core = new TodoList();

            Item item = new Item()
            {
                message = "Pick up cake".ToLower(),
                completed = true
            };
            Item item2 = new Item()
            {
                message = "Pick up shoes".ToLower(),
                completed = false
            };
            Item item3 = new Item()
            {
                message = "Send letter".ToLower(),
                completed = false
            };
            core.Add(item);
            core.Add(item2);
            core.Add(item3);

            // act
            List<Item> result = core.IncompletedTasks();

            // assert
            Assert.IsTrue(result.All(x => x.completed == false));
        }

        [Test]
        public void Search()
        {
            // arrange
            TodoList core = new TodoList();
            string result = "";
            string expected = "Item was not found";
            string search = "pick up cake";

            // act
            Item item = core.Search(search, out result);

            // assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Remove()
        {
            // arrange
            TodoList core = new TodoList();

            Item item = new Item()
            {
                message = "Pick up cake".ToLower(),
                completed = true
            };
            Item item2 = new Item()
            {
                message = "Pick up shoes".ToLower(),
                completed = false
            };
            
            core.Add(item);
            core.Add(item2);
            string taskName = "Pick up cake";

            // act
            bool result1 = core.Remove(taskName);
            List<Item> result2 = core.items;

            // assert
            Assert.IsTrue(result1);
            Assert.IsTrue(result2.Count() == 1);
        }

        [Test]
        public void OrderAscending()
        {
            // arrange
            TodoList core = new TodoList();

            Item item = new Item()
            {
                message = "Send letter".ToLower(),
                completed = true
            };
            Item item2 = new Item()
            {
                message = "Respond to email".ToLower(),
                completed = false
            };
            Item item3 = new Item()
            {
                message = "Pick up cake".ToLower(),
                completed = false
            };
            core.Add(item);
            core.Add(item2);
            core.Add(item3);
            List<Item> sorted = new List<Item>();
            
            // act 
            List<Item> result = core.orderAsc();
            sorted.AddRange(result.OrderBy(o => o.message));

            // assert
            Assert.IsTrue(result.SequenceEqual(sorted));
        }

        [Test]
        public void OrderDescending()
        {
            // arrange
            TodoList core = new TodoList();

            Item item = new Item()
            {
                message = "Send letter".ToLower(),
                completed = true
            };
            Item item2 = new Item()
            {
                message = "Respond to email".ToLower(),
                completed = false
            };
            Item item3 = new Item()
            {
                message = "Pick up cake".ToLower(),
                completed = false
            };
            core.Add(item);
            core.Add(item2);
            core.Add(item3);
            List<Item> sorted = new List<Item>();

            // act 
            List<Item> result = core.orderDesc();
            sorted.AddRange(result.OrderByDescending(o => o.message));

            // assert
            Assert.IsTrue(result.SequenceEqual(sorted));
        }
    }
}