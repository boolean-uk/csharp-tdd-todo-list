using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void GetAll()
        {
            TodoList core = new TodoList();
            core.AddTask("task");
            Assert.That(core.GetAllTasks().Count, Is.EqualTo(1));   
        }
        [Test]
        public void AddTask()
        {
            TodoList core = new TodoList();
            core.AddTask("task");
            Assert.That(core.ListLength, Is.EqualTo(1));
        }
        [Test]
        public void Completed()
        {
            TodoList core = new TodoList();
            Task task = new Task();
            task.completed = false;
            core.Completed(task);
            Assert.That(task.completed, Is.EqualTo(true));
        }
        [Test]
        public void Uncompleted()
        {
            TodoList core = new TodoList();
            Task task = new Task();
            task.completed = true;
            core.Uncompleted(task);
            Assert.That(task.completed, Is.EqualTo(false));
        }
        [Test]
        public void GetCompletedTasks()
        {
            TodoList core = new TodoList();
            core.AddTask("add task");
            core.AddTask("remove task");
            core.Completed(core.GetAllTasks()[0]);
            Assert.That(core.GetCompletedTasks().Count, Is.EqualTo(1));

        }
        [Test]
        public void SearchTask()
        {
            TodoList core = new TodoList();
            core.AddTask("add task");
            core.AddTask("remove task");
            Task? result = core.SearchTask("add task");
            Task target = core.GetAllTasks()[0];
            Assert.That(result, Is.EqualTo(target));
        }
        [Test]
        public void RemoveTask()
        {
            TodoList core = new TodoList();
            core.AddTask("do tasks");
            core.AddTask("do more tasks");
            core.RemoveTask(core.GetAllTasks()[0]);
            Assert.That(core.GetAllTasks()[0].description, Is.EqualTo("do more tasks"));
        }
        [Test]
        public void GetAllTasksAscending()
        {
            TodoList core = new TodoList();
            core.AddTask("a");
            core.AddTask("b");
            core.AddTask("c");
            core.AddTask("d");
            List<Task> sorted = core.GetAllTasksAscending();
            Assert.That(sorted[0].description, Is.EqualTo("a"));
    }
        [Test]
        public void GetAllTasksDescending()
        {
            TodoList core = new TodoList();
            core.AddTask("a");
            core.AddTask("b");
            core.AddTask("c");
            core.AddTask("d");
            List<Task> sorted = core.GetAllTasksDescening();
            Assert.That(sorted[0].description, Is.EqualTo("d"));
        }
    }
}