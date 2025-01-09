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

        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void AddAndGet()
        {
            TodoListExtension todos = new TodoListExtension();
            ETask task1 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = DateTime.Now,
            };
            ETask task2 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = DateTime.Now,
            };

            Assert.That(todos.Add("1", task1), Is.True);
            Assert.That(todos.Add("1", task1), Is.False);
            Assert.That(todos.Add("2", task2), Is.True);
            Assert.That(todos.Get("1"), Is.EqualTo(task1));
            Assert.That(todos.Get("2"), Is.EqualTo(task2));
        }

        [Test]
        public void ChangeName()
        {
            TodoListExtension todos = new TodoListExtension();
            ETask task1 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = DateTime.Now,
            };
            todos.Add("1", task1);
            todos.ChangeName("1", "passed");
            Assert.That(task1.Title, Is.EqualTo("passed"));
        }

        [Test]
        public void ToggleComplete()
        {
            TodoListExtension todos = new TodoListExtension();
            ETask task1 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = DateTime.Now,
            };
            ETask task2 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = DateTime.Now,
            };
            todos.Add("1", task1);
            todos.Add("2", task1);
            Assert.That(task1.Completed, Is.False);
            Assert.That(task2.Completed, Is.False);
            todos.ToggleCompleted("1");
            Assert.That(task1.Completed, Is.True);
            Assert.That(task2.Completed, Is.False);
        }

        [Test]
        public void GetDate()
        {
            var time = DateTime.Now;
            var time2 = DateTime.MinValue;
            TodoListExtension todos = new TodoListExtension();
            ETask task1 = new()
            {
                Title = "test",
                Completed = false,
                CreatedDate = time,
            };
            ETask task2 = new()
            {
                Title = "test2",
                Completed = false,
                CreatedDate = time2,
            };
            todos.Add("1", task1);
            todos.Add("2", task2);
            Assert.That(todos.GetDate("1"), Is.EqualTo(time));
            Assert.That(todos.GetDate("2"), Is.EqualTo(time2));
        }
    }
}
