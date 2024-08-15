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
            // Testing adding of new task
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
            // Testing retrieval of todo list
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
            // Testing changing of status on task
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
            // Testing getting complete and incomplete tasks
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

        [Test]
        public void FifthTest()
        {
            // testing getting a task
            TodoList core = new TodoList();
            string task = "Pet the dog";
            bool status = true;
            core.add(task, status);

            string result = core.getTask(task);
            string result2 = core.getTask("Feed the dog");

            Assert.That(result.Equals("Pet the dog"));
            Assert.That(result2.Equals("not found"));
        }

        [Test]
        public void SixthTest()
        {
            // testing removing a task
            TodoList core = new TodoList();
            string task = "Pet the dog";
            bool status = true;
            core.add(task, status);

            string result = core.remove(task);
            string result2 = core.remove(task);

            Assert.That(result.Equals("Pet the dog"));
            Assert.That(result2.Equals("not found"));
        }
    }
}