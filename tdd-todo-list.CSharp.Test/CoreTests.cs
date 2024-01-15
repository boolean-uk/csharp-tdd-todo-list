using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void ShouldAddItem()
        {
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            Assert.That(todo.Tasks().Count > 0);
        }

        [Test]
        public void ShouldReturnTasks()
        {
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            Assert.That(todo.Tasks()[0] == "Do laundry");
            Assert.That(todo.Tasks()[1] == "Clean kitchen");
        }

        [Test]
        public void ShouldToggleTask()
        {
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            Assert.That(!todo.Items.GetValueOrDefault("Do laundry", true));
            Assert.That(todo.Items.GetValueOrDefault("Clean kitchen", false));
        }

        [Test]
        public void ShouldReturnCompleted()
        {
            TodoList todo = new TodoList();
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
            TodoList todo = new TodoList();
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
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Toggle("Clean kitchen");
            Assert.That(todo.Search("Do laundry"));
            Assert.That(!todo.Search("Eat cookies"));
        }

        [Test]
        public void ShouldRemove()
        {
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            todo.Remove("Do laundry");
            Assert.That(todo.Items.Count == 1);
            Assert.That(todo.Items.ContainsKey("Clean kitchen"));
        }

        [Test]
        public void ShouldReturnAscending()
        {
            TodoList todo = new TodoList();
            todo.Add("Do laundry");
            todo.Add("Clean kitchen");
            List<string> asc = todo.AscendingList();
            Assert.That(asc[0] == "Clean kitchen");
        }

        [Test]
        public void ShouldReturnDescending()
        {
            TodoList todo = new TodoList();
            todo.Add("Clean kitchen");
            todo.Add("Do laundry");
            List<string> asc = todo.DescendingList();
            Assert.That(asc[0] == "Do laundry");
        }
    }
}