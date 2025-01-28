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
            Assert.That(core._list.Count, Is.EqualTo(0));
            core.AddTask("Clean");
            Assert.That(core._list.Count, Is.EqualTo(1));
            core.AddTask("Tidy");
            Assert.That(core._list.Count, Is.EqualTo(2));
        }

        [Test]
        public void TestShowAll()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            core.AddTask("Tidy");
            Assert.That(core.ShowAllTasks, Is.True);
        }


        [Test]
        public void TestUpdate()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            core.AddTask("Tidy");
            Assert.That(core._status[0], Is.False);
            Assert.That(core._status[1], Is.False);
            core.UpdateStatus("Clean");
            Assert.That(core._status[0], Is.True);
            Assert.That(core._status[1], Is.False);
        }

        [Test]
        public void TestUpdateOfTaskNotOnList()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            Assert.That(core._status[0], Is.False);
            core.UpdateStatus("clean");
            Assert.That(core._status[0], Is.False);
            Assert.That(core.UpdateStatus("shop"), Is.False);
        }

        [Test]
        public void TestShowOnly()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            core.AddTask("Tidy");
            core.UpdateStatus("Clean");
            Assert.That(core.ShowCompleteTasks(), Is.True);
            Assert.That(core.ShowInCompleteTasks(), Is.True);
        }

        [Test]
        public void TestSearch()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            core.AddTask("Tidy");
            Assert.That(core.SearchTask("Clean"), Is.EqualTo("The task, Clean, has been found at index 0"));
            Assert.That(core.SearchTask("clean"), Is.EqualTo("Task Not Found"));
        }


        [Test]
        public void TestRemove()
        {
            TodoList core = new TodoList();
            Assert.That(core._list.Count, Is.EqualTo(0));
            core.AddTask("Clean");
            Assert.That(core._list.Count, Is.EqualTo(1));
            core.AddTask("Tidy");
            Assert.That(core._list.Count, Is.EqualTo(2));

            Assert.That(core.RemoveTask("tidyclean"), Is.False);

            core.RemoveTask("Clean");
            Assert.That(core._list.Count, Is.EqualTo(1));
            core.RemoveTask("Tidy");
            Assert.That(core._list.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestSorting()
        {
            TodoList core = new TodoList();
            core.AddTask("Clean");
            core.AddTask("Tidy");
            Assert.That(core.ShowAllTasksAlphabeticallyAcending(), Is.True);
            Assert.That(core.ShowAllTasksAlphabeticallyDecending(), Is.True);
        }

    }
}