using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            TodoList todolist = new TodoList();

            Assert.IsTrue(todolist.AddTask("Shower"));
            
        }

        [Test]
        public void AddExistingTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            Assert.IsFalse(todolist.AddTask("Shower"));


        }

        [Test]
        public void RemoveTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");

            Assert.IsTrue(todolist.RemoveTask("Shower"));
        }

        [Test]
        public void RemoveNoTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");

            Assert.IsFalse(todolist.RemoveTask("Play"));
        }
        [Test]
        public void ViewTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");

            Assert.That(todolist.viewTasks().Contains("Shower"));
            Assert.That(todolist.viewTasks().Contains("Eat"));


        }

        [Test]
        public void ViewCompletedTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");
            todolist.UpdateTask("Shower");

            Assert.That(todolist.viewCompletedTasks().Contains("Shower"));

        }

        [Test]
        public void ViewIncompletedTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");
            todolist.UpdateTask("Shower");

            Assert.That(todolist.viewIncompletedTasks().Contains("Eat"));
        }

        [Test]
        public void UpdateTask()
        {
            TodoList todolist = new TodoList();

            todolist.AddTask("Shower");
            todolist.AddTask("Eat");

            Assert.IsTrue(todolist.UpdateTask("Shower"));
        }

        [Test]
        public void SearchTask()
        {
            TodoList todolist = new TodoList();
            todolist.AddTask("Eat");
            string result = todolist.SearchTask("Eat");

            Assert.That(result, Is.EqualTo("Eat - Incomplete"));

        }
        [Test]
        public void SearchWrongTask()
        {
            TodoList todolist = new TodoList();
            todolist.AddTask("Eat");
            string result = todolist.SearchTask("Sleep");

            Assert.That(result, Is.EqualTo(""));

        }

        [Test]
        public void SortAscTask()
        {
            TodoList todolist = new TodoList();

            List<KeyValuePair<string, string>> sortedTasks = todolist.SortAscTask();

            Assert.AreEqual("AA", sortedTasks[0].Key);
        }
        [Test]
        public void SortDescTask()
        {
            TodoList todolist = new TodoList();

            List<KeyValuePair<string, string>> sortedTasks = todolist.SortDescTask();


            Assert.AreEqual("Smile", sortedTasks[0].Key);


        }

    }
}