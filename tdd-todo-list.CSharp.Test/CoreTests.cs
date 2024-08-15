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
            string task = "Walk the dog";
            bool status = false;
            core.add(task, status);
            int count = core.Count;
            Assert.That(count, Is.EqualTo(1));
        }

        [Test]
        public void SecondTest()
        {
            TodoList core = new TodoList();
            string task = "Walk the dog";
            bool status = false;
            core.add(task, status);
            var todo = core.Todo;
            Assert.That(todo.ContainsKey(task));
        }

        [Test]
        public void ThirdTest()
        {
            TodoList core = new TodoList();
            string task = "Walk the dog";
            bool status = false;
            core.add(task, status);
            core.changeStatus(task);
            Assert.That(core.Todo["Walk the dog"] == true);
        }

        [Test]
        public void FourthTest()
        {
            TodoList core = new TodoList();
            string task = "Walk the dog";
            bool status = false;
            core.add(task, status);
            string task2 = "Pet the dog";
            bool status2 = true;
            core.add(task2, status2);

            List<string> complete = core.getComplete();
            List<string> incomplete = core.getIncomplete();

            Assert.That(complete[0] == "Pet the dog");
            Assert.That(incomplete[0] == "Walk the dog");

        }
    }
}