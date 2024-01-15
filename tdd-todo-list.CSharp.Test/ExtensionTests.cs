using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void ShouldAddItem()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            Assert.That(todo.Tasks().Count > 0);
        }

        [Test]
        public void ShouldReturnTasks()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            Assert.That(todo.Tasks()[0] == "Do laundry");
            Assert.That(todo.Tasks()[1] == "Clean kitchen");
        }

        [Test]
        public void ShouldToggleTask()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            Assert.That(!todo.Ids.GetValueOrDefault(1, null).Completed);
            Assert.That(todo.Ids.GetValueOrDefault(2, null).Completed);
        }

        [Test]
        public void ShouldReturnCompleted()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            List<string> completed = todo.GetCompleted();
            Assert.That(completed.Count == 1);
            Assert.That(completed.Contains("Clean kitchen"));
        }

        [Test]
        public void ShouldReturnUnompleted()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            List<string> completed = todo.GetUncompleted();
            Assert.That(completed.Count == 1);
            Assert.That(completed.Contains("Do laundry"));
        }

        [Test]
        public void ShouldSearch()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            Assert.That(todo.Search("Do laundry"));
            Assert.That(!todo.Search("Eat cookies"));
        }

        [Test]
        public void ShouldRemove()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Remove("Do laundry");
            Assert.That(todo.Items.Count == 1);
            Assert.That(todo.Items.ContainsKey("Clean kitchen"));
        }

        [Test]
        public void ShouldReturnAscending()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            List<string> asc = todo.AscendingList();
            Assert.That(asc[0] == "Clean kitchen");
        }

        [Test]
        public void ShouldReturnDescending()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Clean kitchen");
            todo.Add("Do laundry");
            List<string> asc = todo.DescendingList();
            Assert.That(asc[0] == "Do laundry");
        }

        [Test]
        public void ShouldReturnTask()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            string task = todo.Get(2);
            Assert.That(task == "Clean kitchen");
        }

        [Test]
        public void ShouldUpdateTask()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Update(2, "Eat cookies");
            Assert.That(todo.Ids[2].Name == "Eat cookies");
        }

        [Test]
        public void ShouldToggleTaskGivenId()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle(2);
            Assert.That(!todo.Items.GetValueOrDefault("Do laundry", null).Completed);
            Assert.That(todo.Items.GetValueOrDefault("Clean kitchen", null).Completed);
        }

        [Test]
        public void ShouldReturnOrigins()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            List<string> origins = todo.Origins();
            Assert.That(origins.Count == 2);
            Assert.That(origins[0].Length > 0);
        }
    }
}
