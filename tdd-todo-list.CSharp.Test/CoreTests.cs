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


    }
}