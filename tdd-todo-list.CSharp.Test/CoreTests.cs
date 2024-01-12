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
    }
}