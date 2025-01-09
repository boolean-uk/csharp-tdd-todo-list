using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        [TestCase("Laundry", 2)]
        [TestCase("Bread", 3)]
        [TestCase("Cereal", 4)]
        public void GetTaskByIdTest(string name, int id)
        {
            TodoListExtension extension = _extension;
            TodoListExtension.Task task = new TodoListExtension.Task(name);

            extension.AddTask(id, task);

            var foundTask = extension.GetTaskById(id) as TodoListExtension.Task;
            Assert.IsNotNull(foundTask);
            Assert.That(foundTask.TaskName, Is.EqualTo(task.TaskName));

        }

        [Test]
        public void UpdateTaskTest()
        {

            TodoListExtension extension = _extension;
            TodoListExtension.Task task = new TodoListExtension.Task("Homework");

            extension.AddTask(1, task);
            extension.UpdateTaskName(1, "Play Videogames");

            var foundTask = extension.GetTaskById(1) as TodoListExtension.Task;
            Assert.IsNotNull(foundTask);
            Assert.That(foundTask.TaskName, Is.EqualTo("Play Videogames"));

        }

        [Test]
        public void UpdateStatusTest()
        {

            TodoListExtension extension = _extension;
            TodoListExtension.Task task = new TodoListExtension.Task("Homework");

            extension.AddTask(1, task);
            Assert.IsFalse(task.IsCompleted);
            extension.UpdateTaskStatus(1, true);

            var foundTask = extension.GetTaskById(1) as TodoListExtension.Task;
            Assert.IsNotNull(foundTask);
            Assert.IsTrue(foundTask.IsCompleted);

        }

        [Test]
        public void DateTimeCreated()
        {
            DateTime created = DateTime.Now;

            TodoListExtension extension = _extension;
            TodoListExtension.Task task = new TodoListExtension.Task("Homework", false, created);

            extension.AddTask(1, task);

            var foundTask = extension.GetTaskById(1) as TodoListExtension.Task;
            Assert.IsNotNull(foundTask);
            Assert.That(foundTask.Created, Is.EqualTo(created));
        }
    }
}
