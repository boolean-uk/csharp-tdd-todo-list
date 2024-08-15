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
            Assert.That(core.todoList.Count, Is.EqualTo(1));
        }
    }
}