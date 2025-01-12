using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Drawing;
using Newtonsoft.Json.Bson;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        [Test]
        public void AddTask() {
            TodoList todo = new TodoList();
            todo.AddTask("Make my bed");
            Assert.That(todo.getTodoCount , Is.EqualTo(1));
        }

        [Test]
        public void ChangeStatus()
        {
            TodoList core = new TodoList();
            core.AddTask("Wake up");
            core.ChangeStatus("Wake up", "complete");
            bool isTrue_ = core.ContainsTask("Wake up" , "complete");
            Assert.That(isTrue_, Is.True);
        }

        [Test]
        public void GetCompletedTask()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            core.ChangeStatus("A", "complete");
            int size = core.GetCompletedTask().Count;
            Assert.That(size > 0);
        }

        [Test]
        public void GetInCompletedTask()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            int size = core.GetInCompletedTask().Count;
            Assert.That(size > 0);
        }


        [Test]
        public void GetExistingTask()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            string task = core.RetrieveTask("A");
            Assert.That(task.Length > 0);
        }

        
        [Test]
        public void GetNonExistingTask()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            string task = core.RetrieveTask("B");
            Assert.That(task.Contains("not been created yet"));
        }

        [Test]
        public void RemoveTask()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            core.RemoveTask("A");
            Assert.That(core.getTodoCount() == 0);
        }

        [Test]
        public void DescendingSorting()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            core.AddTask("B");
            List<string>AllTask = core.DescendingOrder();
            Assert.That(AllTask[0] == "B");
        }

        [Test]
        public void AscendingSorting()
        {
            TodoList core = new TodoList();
            core.AddTask("A");
            core.AddTask("B");
            List<string> AllTask = core.AscendingOrder();
            Assert.That(AllTask[0] == "A");
        }
    }
}