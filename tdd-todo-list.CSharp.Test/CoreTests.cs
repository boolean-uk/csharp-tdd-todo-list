using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

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

            List<string> complete = core.Complete;
            List<string> incomplete = core.Incomplete;

            Assert.That(complete[0] == "Pet the dog");
            Assert.That(incomplete[0] == "Walk the dog");
        }

        [Test]
        public void FifthTest()
        {
            // Testing getting a task
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
            // Testing removing a task
            TodoList core = new TodoList();
            string task = "Pet the dog";
            bool status = true;
            core.add(task, status);

            string result = core.remove(task);
            string result2 = core.remove(task);

            Assert.That(result.Equals("Pet the dog"));
            Assert.That(result2.Equals("not found"));
        }

        [Test]
        public void SeventhTest()
        {
            // Testing getting tasks in ascending or descending order
            TodoList core = new TodoList();
            core.add("Pet the dog", true);
            core.add("Feed the dog", false);
            core.add("Walk the dog", false);
            core.add("Play with the dog", true);

            List<string> sortedTasks = new List<string>();
            sortedTasks.Add("Pet the dog");
            sortedTasks.Add("Feed the dog");
            sortedTasks.Add("Walk the dog");
            sortedTasks.Add("Play with the dog");
            sortedTasks.Sort();

            // Should be ascending by default
            int i = 0;
            foreach(var (key, value) in core.Todo)
            {
                Assert.That(key.Equals(sortedTasks[i]));
                i++;
            }

            // Reverse it
            core.descending();
            i = 3;
            foreach (var (key, value) in core.Todo)
            {
                Assert.That(key.Equals(sortedTasks[i]));
                i--;
            }

            // Another test to make sure
            core.ascending();
            i = 3;
            foreach (var (key, value) in core.Todo)
            {
                Assert.That(!key.Equals(sortedTasks[i]));
                i--;
            }



        }
    }
}