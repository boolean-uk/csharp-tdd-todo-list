using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        [Test]
        public void TestExtension()
        {
            TodoListExtension extension = new TodoListExtension();
            Assert.Pass();
        }

        [Test]
        public void TestAddTask()
        {
            TodoListExtension extension = new TodoListExtension();
            ExtensionTask task = new ExtensionTask("Make extensions");
            extension.AddTask(task);
            Assert.IsTrue(extension.tasks.Contains(task));
        }

        [Test]
        public void TestFindTaskById()
        {
            TodoListExtension extension = new TodoListExtension();
            ExtensionTask task = new ExtensionTask("Make extensions");
            extension.AddTask(task);
            Assert.AreEqual(task, extension.getTaskById(0));
        }

        [Test]
        public void TestUpdateNameById()
        {
            TodoListExtension extension = new TodoListExtension();
            ExtensionTask task = new ExtensionTask("Make extensions");
            extension.AddTask(task);
            extension.updateNameById(0, "Changed the name");
            Assert.AreEqual("Changed the name", task.name);
        }

        [Test]
        public void TestChangeStatusById()
        {
            TodoListExtension extension = new TodoListExtension();
            ExtensionTask task = new ExtensionTask("Make extensions");
            extension.AddTask(task);
            extension.changeStatusById(0);
            Assert.IsTrue(task.isComplete);
        }
    }
}
