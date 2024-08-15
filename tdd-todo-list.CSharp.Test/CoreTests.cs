using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            TodoList toDo = new TodoList();

            toDo.addTask("complete challenge");

            Assert.That(toDo.tasks.ContainsKey("complete challenge"));
        }
    }
}