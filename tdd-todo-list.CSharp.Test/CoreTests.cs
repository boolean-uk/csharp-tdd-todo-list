using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        TodoList core = null;
        Main.Task task = null;

        [SetUp]

        public void Setup()
        {
            this.core = new TodoList();
            this.task = new Main.Task();
        }

        [Test]
        public void addingItemToTodoList()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(task.title, "Test");
        }

        [Test]
        public void addingEmptyItemToTodoList()
        {
            task = core.AddTask("");
            Assert.AreEqual(task, null);
        }

        [Test]
        public void gettingListOfTasks()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.Tasks().Count, 1);
        }

        [Test]

        public void settingTaskCompleted()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.SetTaskCompleted(task.id, true), true);
        }

        [Test]

        public void settingTaskCompletedWithInvalidId()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.SetTaskCompleted(2, true), false);
        }

        [Test]

        public void gettingCompletedTasks()
        {
            task = core.AddTask("Test");
            core.SetTaskCompleted(task.id, true);
            Assert.AreEqual(core.GetCompletedTasks().Count, 1);
        }

        [Test]

        public void gettingIncompleteTasks()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.GetIncompleteTasks().Count, 1);
        }

        [Test]

        public void gettingTask()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.GetTask(task.id), task);
        }

        [Test]

        public void gettingTaskWithInvalidId()
        {
            task = core.AddTask("Test");
            Assert.AreEqual(core.GetTask(2), null);
        }

    }
}