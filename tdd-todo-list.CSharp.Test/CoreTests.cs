using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        TodoList core;

        [SetUp]
        public void SetUp()
        {
            core = new TodoList();
        }
        [Test]
        public void AddTest()
        {
            core.Add("Clean");
            Assert.That(core.ToDoList.Count, Is.EqualTo(1));
            Assert.IsTrue(core.ToDoList.ContainsKey("Clean"));
        }
        [Test]
        public void ShowTest()
        {
            core.Add("Finish exercise");
            List<string> result = core.Show();
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.IsTrue(result.Contains("Finish exercise   NOT COMPLETED"));
        }
        [Test]
        public void ToggleCompletionTest()
        {
            core.Add("Make card");
            bool result = core.ToggleCompletion("Make card");
            Assert.IsTrue(result);
            Assert.IsTrue(core.ToDoList["Make card"]);
        }
        [Test]
        public void ToggleCompletionTest1()
        {
            core.Add("Make card");
            bool result = core.ToggleCompletion("Play guitar");
            Assert.IsFalse(result);
            Assert.IsFalse(core.ToDoList["Make card"]);
        }
        [Test]
        public void ToggleCompletionTest2()
        {
            core.Add("Make card", true);
            bool result = core.ToggleCompletion("Make card");
            Assert.IsTrue(result);
            Assert.IsFalse(core.ToDoList["Make card"]);
        }

        [Test] 
        public void CompleteTasksTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            Dictionary<string, bool> result = core.CompletedTasks();
            Assert.That(result, Is.EquivalentTo(new Dictionary<string, bool>() { { "Eat", true }, { "Game", true } }));
        }
        [Test]
        public void IncompleteTasksTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            Dictionary<string, bool> result = core.IncompleteTasks();
            Assert.That(result, Is.EquivalentTo(new Dictionary<string, bool>() { { "Sleep", false}, { "Repeat", false} }));
        }

        [Test]
        public void SearchTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            bool complete;
            string result = core.Search("Game", out complete) ;
            Assert.IsTrue(complete);
            Assert.That(result, Is.EqualTo("Game"));
        }
        [Test]
        public void SearchDoesntExistTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            bool complete;
            string result = core.Search("Work", out complete);
            Assert.IsFalse(complete);
            Assert.That(result, Is.EqualTo("Work doesn't exist"));
        }
        [Test]
        public void RemoveTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            core.Remove("Repeat");
            Assert.That(core.ToDoList, Is.EquivalentTo(new Dictionary<string, bool>() { { "Eat", true }, { "Sleep", false }, { "Game", true } }));
        }
        [Test]
        public void OrderAscendingTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            core.OrderAscending();
            Assert.That(core.ToDoList, Is.EqualTo(new Dictionary<string, bool>() { { "Eat", true }, { "Game", true}, { "Repeat", false} , { "Sleep" , false} }));
        }
        [Test]
        public void OrderDescendingTest()
        {
            core.Add("Eat", true);
            core.Add("Sleep", false);
            core.Add("Game", true);
            core.Add("Repeat", false);
            core.OrderDescending();
            Assert.That(core.ToDoList, Is.EqualTo(new Dictionary<string, bool>() {  { "Sleep", false }, { "Repeat", false }  ,  { "Game", true },{ "Eat", true } }));
        }

    }
}