using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            TodoList todoList = new TodoList();
            
            todoList.AddTask("Hoover");

            Assert.IsTrue(todoList.Tasks.Count() == 1);
        }

        [Test]
        public void CheckStatusFalse()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");

            Assert.IsFalse(todoList.Tasks[0].IsComplete);
        }

        [Test]
        public void CheckStatusTrue()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;

            Assert.IsTrue(todoList.Tasks[0].IsComplete);
        }


    }
}