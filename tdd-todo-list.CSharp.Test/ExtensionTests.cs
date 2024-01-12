using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        TodoListExtension _extension = null;
        TaskExtension _task = null;
        
        [SetUp]
        public void Setup()
        {
            _extension = new TodoListExtension();
            _task = new TaskExtension();
        }

        [Test]

        public void gettingTaskById()
        {
            _task = _extension.GetTask(1);
            Assert.AreEqual(_task, null);
        }

        [Test]

        public void updatingTaskTitle()
        {
            _task = _extension.AddTask("Test1");
            _task = _extension.GetTask(1);
            Assert.AreEqual(_extension.UpdateTask(1, "Test"), true);
        }

        [Test]

        public void updatingTaskTitleWithInvalidId()
        {
            _task = _extension.GetTask(1);
            Assert.AreEqual(_extension.UpdateTask(2, "Test"), false);
        }

        [Test]
        
        public void settingTaskCompleted()
        {
            _task = _extension.GetTask(1);
            Assert.AreEqual(_extension.SetTaskCompleted(1, true), true);
        }

        [Test]

        public void settingTaskCompletedWithInvalidId()
        {
            _task = _extension.GetTask(1);
            Assert.AreEqual(_extension.SetTaskCompleted(2, true), false);
        }

        [Test]

        public void gettingTaskCreatedAt()
        {
            _task = _extension.GetTask(1);
            Assert.AreEqual(_extension.GetTaskCreatedAt(1), null);
        }
    }
}
