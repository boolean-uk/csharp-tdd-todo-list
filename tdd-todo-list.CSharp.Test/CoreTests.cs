using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTest()
        {
            TodoList core = new TodoList();

            Guid uId = core.Add("Sometask");

            Assert.That(core.GetList().Count, Is.EqualTo(1));
        }


        [Test]
        public void GetBasicListTest()
        {
            TodoList core = new TodoList();
            core.Add("Sometask1");
            core.Add("Sometask2");
            core.Add("Sometask3");

            Assert.That(core.GetList().Count, Is.EqualTo(3));
        }

        [Test]
        public void GetCompleteListTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");
            Guid id3 = core.Add("Sometask3");

            core.ChangeTaskCompletion(id1);
            core.ChangeTaskCompletion(id2);
            Assert.That(core.GetList(true).Count, Is.EqualTo(2));
        }

        [Test]
        public void GetIncompleteListTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");
            Guid id3 = core.Add("Sometask3");

            core.ChangeTaskCompletion(id1);
            core.ChangeTaskCompletion(id2);
            Assert.That(core.GetList(false).Count, Is.EqualTo(1));
        }

        [Test]
        public void ChangeStatusByTextTest() {
            TodoList core = new TodoList();
            Guid id = core.Add("Sometask1");

            //change to text
            core.ChangeTaskCompletion("Sometask1");
            Assert.That(core.GetTaskCompletion(id), Is.EqualTo(true));
        }

        [TestCase("Do the dishes", true, 1)]
        [TestCase("Water", true, 1)]
        [TestCase("Walk", true, 1)]
        [TestCase("Chalk", false, 0)]
        [TestCase("dog", true, 2)]
        [TestCase("ate a 100x cake", false, 0)]
        public void SearchTaskTest(string text, bool success, int hits)
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Do the dishes.");
            Guid id2 = core.Add("Talk to the dog.");
            Guid id3 = core.Add("Walk the dog.");
            Guid id4 = core.Add("Eat ten potatoes.");
            Guid id5 = core.Add("Water the plants.");


            List<Main.Task> retrievedTasks = core.SearchTaskText(text);

            Assert.That(retrievedTasks.Count, Is.EqualTo(hits));
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1");
            Guid id2 = core.Add("Sometask2");

            bool success = core.RemoveTask(id2);
            Assert.IsTrue(success);
            Assert.That(core.GetList().Count, Is.EqualTo(1));
        }

        [Test]
        public void GetAllBasicAscendingAlphabeticallyTest()
        {
            List<string> expectedTasks = new List<string> { "c", "b", "a", "d" };

            TodoList core = new TodoList();

            var sortedList = expectedTasks.OrderBy(pair => pair).ToList();

            foreach (var task in expectedTasks) { core.Add(task); }

            List<Main.Task> retrievedTasks = core.GetList(null, false, true);
            for (int i = 0; i < expectedTasks.Count; i++) Assert.That(retrievedTasks[i].GetTaskText(), Is.EqualTo(sortedList[i]));
        }

        [Test]
        public void GetAllBasicDescendingAlphabeticallyTest()
        {
            List<string> expectedTasks = new List<string> { "c", "b", "a", "d" };

            TodoList core = new TodoList();

            var sortedList = expectedTasks.OrderByDescending(pair => pair).ToList();

            foreach (var task in expectedTasks) { core.Add(task); }

            List<Main.Task> retrievedTasks = core.GetList(null, true, true);
            for (int i = 0; i < expectedTasks.Count; i++) Assert.That(retrievedTasks[i].GetTaskText(), Is.EqualTo(sortedList[i]));
        }

        // priority stuff

        [Test]
        public void GetAllByPriority()
        {
            TodoList core = new TodoList();
            Guid id1 = core.Add("Sometask1", Priority.low);
            Guid id2 = core.Add("Sometask2", Priority.high);
            Guid id3 = core.Add("Sometask3", Priority.medium);

            List<Main.Task> retrievedTasks = core.GetPriorityList();
            Assert.That(retrievedTasks[0].GetPriority(), Is.EqualTo(Priority.high));
            Assert.That(retrievedTasks[1].GetPriority(), Is.EqualTo(Priority.medium));
            Assert.That(retrievedTasks[2].GetPriority(), Is.EqualTo(Priority.low));
        }

    }
}