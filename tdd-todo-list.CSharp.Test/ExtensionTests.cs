using tdd_todo_list.CSharp.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        private TodoListExtension.TodoList todolist;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
            todolist = new TodoListExtension.TodoList();
        }

        [TestCase("Walk Dog", "Walk Dog", false)]
        public void TestCreation(string name, string expectedName, bool expectedStatus)
        {
            DateTime expectedTime = DateTime.Now;
            TimeSpan tolerance = TimeSpan.FromSeconds(1);

            TodoListExtension.TodoTask result = todolist.AddTask(name);
            for (int i = 0; i < 5; i++)
            {
                todolist.AddTask($"blah{i}");
            }

            int latestId = 0;
            //Test IDs
            foreach (TodoListExtension.TodoTask task in todolist.Tasks)
            {
                Assert.That(task.Id, Is.Not.EqualTo(latestId));
                latestId = task.Id;
            }

            //Test values correctly
            Assert.That(result.Name, Is.EqualTo(expectedName));
            Assert.That(result.IsCompleted, Is.EqualTo(expectedStatus));
            //Test date and time
            Assert.That(result.Time, Is.EqualTo(expectedTime).Within(tolerance));
            //Test List is updated
            Assert.That(todolist.Tasks.Count(), Is.EqualTo(6));
        }

        [Test]
        public void TestGetById()
        {
            TodoListExtension.TodoTask task = todolist.AddTask("Water plants");

            TodoListExtension.TodoTask? FetchedTask = todolist.GetTask(task.Id);

            TodoListExtension.TodoTask? FailedFetchedTask = todolist.GetTask(1);

            Assert.That(task.Id, Is.EqualTo(FetchedTask.Id));
            Assert.That(task.Name, Is.EqualTo(FetchedTask.Name));
            Assert.That(task.IsCompleted, Is.EqualTo(FetchedTask.IsCompleted));
            Assert.That(FailedFetchedTask, Is.EqualTo(null));
        }

        [TestCase("Walk dog", "Run with dog", "Run with dog", true)]
        public void TestUpdate(string initName, string newName, string expectedName, bool expectedStatus)
        {
            TodoListExtension.TodoTask task = todolist.AddTask(initName);
            todolist.UpdateTaskName(task.Id, newName);

            todolist.ToggleTaskStatus(task.Id);

            TodoListExtension.TodoTask? FailedUpdatedTaskName = todolist.UpdateTaskName(1, newName);

            TodoListExtension.TodoTask? FailedUpdatedTaskStatus = todolist.ToggleTaskStatus(1);

            Assert.That(task.Name, Is.EqualTo(expectedName));
            Assert.That(task.IsCompleted, Is.EqualTo(expectedStatus));
            Assert.That(FailedUpdatedTaskName, Is.EqualTo(null));
            Assert.That(FailedUpdatedTaskStatus, Is.EqualTo(null));
        }

    }
}
