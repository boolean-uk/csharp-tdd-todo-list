using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TestAdd()
        {
            TodoList core = new TodoList();

            core.Add("Test");

            Assert.That(core.Tasks.Count, Is.EqualTo(1));
            Assert.True(core.Tasks.ContainsKey("Test"));
        }

        [Test]
        public void TestChangeStatus()
        {
            TodoList core = new TodoList();

            core.Add("Test");

            Assert.False(core.Tasks["Test"]);

            core.ChangeStatus("Test");

            Assert.True(core.Tasks["Test"]);

            core.ChangeStatus("Test");

            Assert.False(core.Tasks["Test"]);

            Assert.Throws<Exception>(() => core.ChangeStatus("NonExistant"));
        }

        [Test]
        public void TestCompleted()
        {
            TodoList core = new TodoList();

            core.Add("Test");
            core.Add("AnotherTest");
            core.Add("FinalTest");
            core.ChangeStatus("Test");
            core.ChangeStatus("FinalTest");

            List<string> completed = core.GetTasks(true);

            Assert.True(completed.Contains("Test"));
            Assert.True(completed.Contains("FinalTest"));
            Assert.False(completed.Contains("AnotherTest"));
        }

        [Test]
        public void TestIncompleted()
        {
            TodoList core = new TodoList();

            core.Add("Test");
            core.Add("AnotherTest");
            core.Add("FinalTest");
            core.ChangeStatus("Test");
            core.ChangeStatus("FinalTest");

            List<string> completed = core.GetTasks(false);

            Assert.False(completed.Contains("Test"));
            Assert.False(completed.Contains("FinalTest"));
            Assert.True(completed.Contains("AnotherTest"));
        }

        [Test]
        public void TestSearch()
        {
            TodoList core = new TodoList();

            core.Add("Test");

            Assert.AreEqual("Test", core.Search("Test").Item1);
            Assert.AreEqual(core.Tasks["Test"], core.Search("Test").Item2);

            Assert.Throws<Exception>(() => core.Search("AnotherTest"));
        }

        [Test]
        public void TestRemove()
        {
            TodoList core = new TodoList();

            core.Add("Test");

            Assert.That(core.Tasks.Count, Is.EqualTo(1));

            core.Remove("Test");

            Assert.That(core.Tasks.Count, Is.EqualTo(0));

            Assert.Throws<Exception>(() => core.Remove("Test"));
        }

        [Test]
        public void TestOrderAscending()
        {
            TodoList core = new TodoList();
            core.Add("AFirst");
            core.Add("ZLast");
            core.Add("LMiddle");
            int counter = 0;
            List<string> names = new List<string>{"AFirst", "ZLast", "LMiddle"};

            foreach (var value in core.Tasks)
            {
                Assert.That(value.Key, Is.EqualTo(names[counter]));
                counter++;
            }

            names.Sort();
            counter = 0;
            foreach (var value in core.OrderAscending())
            {
                Assert.That(value.Key, Is.EqualTo(names[counter]));
                counter++;
            }
        }

        [Test]
        public void TestOrderDescending()
        {
            TodoList core = new TodoList();
            core.Add("AFirst");
            core.Add("ZLast");
            core.Add("LMiddle");
            int counter = 0;
            List<string> names = new List<string> { "AFirst", "ZLast", "LMiddle" };

            foreach (var value in core.Tasks)
            {
                Assert.That(value.Key, Is.EqualTo(names[counter]));
                counter++;
            }

            names = names.OrderByDescending(name => name).ToList();
            counter = 0;
            foreach (var value in core.OrderDescending())
            {
                Assert.That(value.Key, Is.EqualTo(names[counter]));
                counter++;
            }
        }
    }
}