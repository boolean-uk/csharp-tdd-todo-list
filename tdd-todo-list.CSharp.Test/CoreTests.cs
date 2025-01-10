using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [SetUp]
        public void SetUp()
        {
            Task.ResetCounter();
        }

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }
        [TestCase("Vacuum")]
        public void AddTaskTest(string name)
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(name);
            Assert.That(todoList.tasks.Count, Is.EqualTo(1));
        }

        [TestCase("Vacuum", "Dishes")]
        public void ShowTasksTest(string todo1, string todo2)
        {
            TodoList todoList = new TodoList();
            todoList.AddTask(todo1);
            todoList.AddTask(todo2);
            string returnedString = todoList.showTasks();
            Assert.That(returnedString.Contains(todoList.tasks[0]._name));
            Assert.That(returnedString.Contains(todoList.tasks[1]._name));
        }

        [Test]
        public void showCompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");
            todoList.AddTask("Jog");
            todoList.AddTask("Lunch");
            todoList.AddTask("Work");
            todoList.AddTask("Chill");
            todoList.tasks[2]._status = true;
            todoList.tasks[4]._status = true;
            todoList.tasks[5]._status = true;

            string completedTasksString = todoList.showCompleteTasks();
            Assert.That(completedTasksString.Contains("Jog"));
            Assert.That(completedTasksString.Contains("Work"));
            Assert.That(completedTasksString.Contains("Chill"));
            Assert.That(completedTasksString.Contains("True"));
            Assert.That(!completedTasksString.Contains("False"));
        }

        [Test]
        public void showIncompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");
            todoList.AddTask("Jog");
            todoList.AddTask("Lunch");
            todoList.AddTask("Work");
            todoList.AddTask("Chill");
            todoList.tasks[2]._status = true;
            todoList.tasks[4]._status = true;
            todoList.tasks[5]._status = true;

            string completedTasksString = todoList.showIncompleteTasks();
            Assert.That(completedTasksString.Contains("Vacuum"));
            Assert.That(completedTasksString.Contains("Dishes"));
            Assert.That(completedTasksString.Contains("Lunch"));
            Assert.That(completedTasksString.Contains("False"));
            Assert.That(!completedTasksString.Contains("True"));
        }

        [Test]
        public void searchTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");
            todoList.AddTask("Jog");
            todoList.AddTask("Lunch");
            todoList.AddTask("Work");
            todoList.AddTask("Chill");

            string searchString = todoList.search("Dishes");
            Assert.That(searchString.Contains("Found"));

            searchString = todoList.search("Vacation");
            Assert.That(searchString.Contains("NotFound"));
        }

        [Test]
        public void deleteTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");

            Assert.That(todoList.tasks.Count, Is.EqualTo(2));

            todoList.delete("Dishes");

            Assert.That(todoList.tasks.Count, Is.EqualTo(1));
            Assert.True(todoList.tasks.Exists(x => x._name == "Vacuum"));
            Assert.False(todoList.tasks.Exists(x => x._name == "Dishes"));
        }

        [Test]
        public void OrderTasksAscTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");
            todoList.AddTask("Jog");
            todoList.AddTask("Lunch");
            todoList.AddTask("Work");
            todoList.AddTask("Chill");

            todoList.OrderTasksAsc();

            Assert.That(todoList.tasks[0]._name == "Chill");
            Assert.That(todoList.tasks[4]._name == "Vacuum");
            Assert.That(todoList.tasks[5]._name == "Work");
        }


        [Test]
        public void OrderTasksDscTest()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Vacuum");
            todoList.AddTask("Dishes");
            todoList.AddTask("Jog");
            todoList.AddTask("Lunch");
            todoList.AddTask("Work");
            todoList.AddTask("Chill");

            todoList.OrderTasksDsc();

            Assert.That(todoList.tasks[5]._name == "Chill");
            Assert.That(todoList.tasks[1]._name == "Vacuum");
            Assert.That(todoList.tasks[0]._name == "Work");
        }

    }
}