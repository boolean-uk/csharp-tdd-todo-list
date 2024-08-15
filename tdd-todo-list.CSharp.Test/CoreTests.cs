using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Globalization;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            TodoList toDo = new TodoList();

            toDo.addTask("complete challenge");

            Assert.That(toDo.tasks.ContainsKey("complete challenge"));
        }

        [Test]
        public void ChangeStatusTest()
        {
            TodoList toDo = new TodoList();
            toDo.addTask("complete challenge");
            toDo.addTask("dig up treasure");

            toDo.changeStatus("complete challenge");
            toDo.changeStatus("complete challenge");
            toDo.changeStatus("dig up treasure");

            Assert.That(!toDo.tasks["complete challenge"] && toDo.tasks["dig up treasure"]);
        }
    }
}