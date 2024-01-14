using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void addTaskTest()
        {
            TodoList core = new TodoList();
            core.addTask("Help Grandma", 111);
            core.addTask("Cut firewood", 112);
            Assert.That(core.toDo.Count == 2);
        }
        [Test]
        public void seeTasksTest()
        {
            TodoList core = new TodoList();
            core.addTask("Get water", 111);
            core.addTask("Make soup", 112);
            core.addTask("Help Grandma", 113);
            core.addTask("Cut firewood", 114);

            Assert.That(core.SeeTasks().Contains(111));
            Assert.That(core.SeeTasks().Contains(112));
            Assert.That(core.SeeTasks().Contains(113));
            Assert.That(core.SeeTasks().Contains(114));
            Assert.False(core.SeeTasks().Contains(115));

        }
        [Test]
        public void completeTaskTest()
        {
            TodoList core = new TodoList();
            core.addTask("Get water", 111);
            core.completeTask(111);
            Assert.IsTrue(core.completeTask(111));
        }
        [Test]
        public void seeCompleteTasksTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.completeTask(112);
            Assert.That(core.SeeCompleteTasks().Contains(112));
            Assert.False(core.SeeCompleteTasks().Contains(111));
        }
        [Test]
        public void seeIncompleteTasksTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.completeTask(112);
            Assert.False(core.SeeIncompleteTasks().Contains(112));
            Assert.That(core.SeeIncompleteTasks().Contains(111));
        }
        [Test]
        public void searchTaskTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.addTask("Help grandma", 113);
            core.addTask("Fix hole in roof",114);
            Assert.True(core.searchTask("Help grandma"));
            Assert.True(core.searchTask(" hElp grANdma   "));
            Assert.True(core.searchTask("Go fishing"));
            Assert.False(core.searchTask("Return tools to idiot neighbour"));
            Assert.False(core.searchTask("Move to the city"));
        }
        [Test]
        public void removeTaskTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.addTask("Help grandma", 113);
            core.addTask("Fix hole in roof", 114);
            core.removeTaskById(112);
            Assert.False(core.SeeTasks().Contains(112));
        }
        [Test]
        public void alphabeticalTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.addTask("Help grandma", 113);
            core.addTask("Fix hole in roof", 114);
            List<string> expected = new List<string>();
            expected.Add("Cut firewood");
            expected.Add("Fix hole in roof");
            expected.Add("Go fishing");
            expected.Add("Help grandma");
            Assert.AreEqual(expected, core.printAlphabetical());
        }
        public void alphabeticalRevTest()
        {
            TodoList core = new TodoList();
            core.addTask("Cut firewood", 111);
            core.addTask("Go fishing", 112);
            core.addTask("Help grandma", 113);
            core.addTask("Fix hole in roof", 114);
            List<string> expected = new List<string>();
            expected.Add("Help grandma");
            expected.Add("Go fishing");
            expected.Add("Fix hole in roof");
            expected.Add("Cut firewood");
            Assert.AreEqual(expected, core.printAlphabeticalRev());
        }
    }
}