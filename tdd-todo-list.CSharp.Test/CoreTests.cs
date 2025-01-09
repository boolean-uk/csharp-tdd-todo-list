using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void ListLengthAdd()
        {
            TodoList core = new TodoList();

            Assert.That(core.GetTasks().Count, Is.EqualTo(0));
            core.Add("shopping");

            Assert.That(core.GetTasks().Count, Is.EqualTo(1));
            Assert.That(core._todo[0]._task, Is.EqualTo("shopping"));
            Assert.That(core._todo[0]._completed, Is.EqualTo(false));
        }
        [Test]
        public void ListCheckComplete()
        {
            TodoList core = new TodoList();

            core.Add("shopping");
            Assert.That(core.CompletedTasks().Count, Is.EqualTo(0));
            Assert.That(core.IncompleteTasks().Count, Is.EqualTo(1));
            core._todo[0].ChangeStatus();
            Assert.That(core.CompletedTasks().Count, Is.EqualTo(1));
            Assert.That(core.IncompleteTasks().Count, Is.EqualTo(0));

            core.Add("dying");
            Assert.That(core.GetTasks().Count, Is.EqualTo(2));
            Assert.That(core.CompletedTasks().Count, Is.EqualTo(1));
            Assert.That(core.IncompleteTasks().Count, Is.EqualTo(1));
            core._todo[1].ChangeStatus();
            Assert.That(core.CompletedTasks().Count, Is.EqualTo(2));
            Assert.That(core.IncompleteTasks().Count, Is.EqualTo(0));
        }

        [Test]
        public void ListRemove()
        {
            TodoList core = new TodoList();

            Assert.That(core.GetTasks().Count, Is.EqualTo(0));

            core.Add("shopping");

            Assert.That(core.GetTasks().Count, Is.EqualTo(1));

            core.RemoveTask("shopping");

            Assert.That(core.GetTasks().Count, Is.EqualTo(0));
        }
        [Test] 
        public void ListSorting()
        {
            TodoList core = new TodoList();
            TodoList core2 = new TodoList();
            TodoList core3 = new TodoList();

            core.Add("shop");
            core.Add("shopping");
            core.Add("run");
            Assert.That(core.GetTasks().Count, Is.EqualTo(3));
            Assert.That(core._todo[0]._task, Is.EqualTo("shop"));


            Assert.That(core.SortAsc()[0]._task, Is.EqualTo("run"));
            Assert.That(core.SortDesc()[0]._task, Is.EqualTo("shopping"));

            Assert.That(core.SearchTask("shoffgp"), Is.Null);
            Assert.That(core.SearchTask("shop"), Is.EqualTo(core._todo[0]));
        }

    }
}