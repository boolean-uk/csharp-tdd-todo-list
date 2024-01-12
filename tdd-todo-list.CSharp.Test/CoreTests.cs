using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList taskList;

        [SetUp]
        public void SetUp()
        {
            taskList = new TodoList();
            taskList.AddTasks("Clean", 0);
            taskList.AddTasks("Vaccum", 0);
            taskList.AddTasks("Mop", 1);
            taskList.AddTasks("Dust", 1);
        }

        [Test]
        public void AddedTasks()
        {
            Assert.That(taskList.todo.Count() > 0);
        }

        [Test]
        public void PrintedList()
        {
            string todoList = taskList.PrintList();
            Assert.That(todoList, Is.EqualTo("Clean Vaccum Mop Dust "));
        }

        [TestCase("Vaccum", 1, true)]
        [TestCase("Paint", 0, false)]
        [TestCase("Mop", 1, true)]
        [TestCase("Clean", 5, false)]
        public void ChangeStatus(string taskName, int status, bool expected)
        {
            bool result = taskList.CompleteTask(taskName, status);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void CompleteTasks()
        {
            string completedTasks = taskList.CompleteTasks();
            Assert.That("Mop Dust ", Is.EqualTo(completedTasks));
        }

        [Test]
        public void IncompletedTasks()
        {
            string completedTasks = taskList.IncompleteTasks();
            Assert.That("Clean Vaccum ", Is.EqualTo(completedTasks));
        }

        [TestCase("Vaccum", "Exists")]
        [TestCase("Paint", "Do not exist")]
        [TestCase("Mop", "Exists")]
        public void ExistsTaskMessage(string taskName, string expectedMessage)
        {
            string message = taskList.TaskExists(taskName);
            Assert.That(expectedMessage, Is.EqualTo(message));
        }

        [TestCase("Vaccum", true)]
        [TestCase("Paint", false)]
        [TestCase("Mop", true)]
        public void RemoveTasks(string taskName, bool expected)
        {
            bool result = taskList.RemovedTask(taskName);
            Assert.That(expected, Is.EqualTo(result));
        }

        [Test]
        public void SortedAlfabetically()
        {
            string completedTasks = taskList.Alfabetically();
            Assert.That("Clean Dust Mop Vaccum ", Is.EqualTo(completedTasks));
        }

        [Test]
        public void SortedBackwards()
        {
            string completedTasks = taskList.BackwardsAlfabet();
            Assert.That("Vaccum Mop Dust Clean ", Is.EqualTo(completedTasks));
        }
    }
}