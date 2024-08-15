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
    }
}