using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        [TestCase("Hoover")]
        [TestCase("Cook")]
        public void AddTask(String task)
        {
            TodoList todoList = new TodoList();

            todoList.AddTask(task);

            Assert.IsTrue(Tasks.Contains(task));
        }


    }
}