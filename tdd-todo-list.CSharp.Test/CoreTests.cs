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

            Assert.AreEqual(core.SeeTasks().ElementAt(0), 111);
            Assert.AreEqual(core.SeeTasks().ElementAt(1), 112);
            Assert.AreEqual(core.SeeTasks().ElementAt(2), 113);
            Assert.AreEqual(core.SeeTasks().ElementAt(3), 114);
            Assert.AreNotEqual(core.SeeTasks().ElementAt(0), 112);

        }
        [Test]
        public void completeTaskTest()
        {
            TodoList core = new TodoList();
            core.addTask("Get water", 111);
            core.completeTask(111);
            Assert.IsTrue(core.completeTask(111));
        }
    }
}