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
        public void TestAdd()
        {
            TodoList core = new TodoList();

            Assert.IsTrue(core.addTask("run"));
        }
        [Test]
        public void TestSeeTask()
        {
            TodoList core = new TodoList();

            //Assert.That(core.seeAllTasks() , Is.EqualTo(Console.ReadLine("")));
            Assert.IsTrue(core.seeAllTasks());
        }

        [Test]
        public void TestRemove()
        {
            TodoList core = new TodoList();
            core.addTask("run");
            //Assert.That(core.seeAllTasks() , Is.EqualTo(Console.ReadLine("")));
            Assert.IsTrue(core.removeTask("run"));
        }
        [Test]
        public void TestSearchTask()
        {
            TodoList core = new TodoList();
            core.addTask("run");

            Assert.That(core.searchTask("run") , Is.EqualTo("Task found: run"));
            
        }

        [Test]
        public void TestInCompletedTask()
        {
            TodoList core = new TodoList();
            core.addTask("run");
            //Assert.That(core.seeAllTasks() , Is.EqualTo(Console.ReadLine("")));
            Assert.That(core.GetIncompleteTask(), Is.EqualTo("run"));
         }

        [Test]
        public void TestCompleteTask()
        {
            TodoList core = new TodoList();
            core.addTask("run");
            core.changeStatus("run");

            //Assert.That(core.seeAllTasks() , Is.EqualTo(Console.ReadLine("")));
            Assert.That(core.GetCompleteTask(), Is.EqualTo("run"));
        }

        [Test]
        public void TestChangeStatus()
        {
            TodoList core = new TodoList();
            core.addTask("walk");
            Assert.That(core.changeStatus("walk"), Is.EqualTo("complete"));
        }

        [Test]
        public void TestSort()
        {
            TodoList core = new TodoList();
            core.addTask("run");
            core.addTask("walk");
            core.addTask("step");
            core.addTask("sit");

            //Assert.That(core.seeAllTasks() , Is.EqualTo(Console.ReadLine("")));
            Assert.AreEqual("run", core.SortAsc().FirstOrDefault().Key);
            Assert.AreEqual("walk", core.SortAsc().LastOrDefault().Key);

        }
    }
}