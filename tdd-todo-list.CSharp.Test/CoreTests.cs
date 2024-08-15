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

        [Test]
        public void GetAllTasksTest()
        {
            TodoList toDo = new TodoList();
            toDo.addTask("complete challenge");
            toDo.addTask("dig up treasure");
            toDo.addTask("make apple jam");

            List<string> taskList = toDo.getList();

            Assert.That(taskList.Count == 3);
        }

        [Test]
        public void GetCompleteOrIncompleteTasksTest()
        {
            TodoList toDo = new TodoList();
            toDo.addTask("complete challenge");
            toDo.addTask("dig up treasure");
            toDo.addTask("make apple jam");
            toDo.changeStatus("dig up treasure");
            toDo.changeStatus("make apple jam");

            List<string> completedList = toDo.getList('c');
            List<string> incompleteList = toDo.getList('i');

            Assert.That(completedList.Count == 2 && incompleteList.Count == 1);
        }
    }
}