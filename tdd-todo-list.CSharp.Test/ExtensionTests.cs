using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using System.ComponentModel;
using static tdd_todo_list.CSharp.Main.TodoListExtension;
using System.Security.Cryptography;

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
        public void GetTask()
        {
            _extension.AddTask("do something");
            _extension.AddTask("buy food");
            ExtensionTask task = _extension.GetTask(1);
            Assert.That(task.description, Is.EqualTo("buy food"));


        }
        [Test]
        public void UpdateTask()
        {
            _extension.AddTask("do something");
            _extension.AddTask("buy food");

            _extension.UpdateTask(1, "find a new task");
            ExtensionTask task = _extension.GetTask(1);
            Assert.That(task.description, Is.EqualTo("find a new task"));
        }
        [Test]
        public void UpdateCompleted()
        {
            _extension.AddTask("do something");
            _extension.AddTask("buy food");
            _extension.UpdateCompleted(1, true);
            ExtensionTask? task = _extension.GetTask(1);
            Assert.That(task.completed, Is.EqualTo(true));
        }
        [Test]
        public void TimeCreated()
        {
            DateTime startTime = DateTime.Now;
            _extension.AddTask("do something");
            _extension.AddTask("buy food");
            Thread.Sleep(100);
            Assert.That(_extension.GetTask(0).time, Is.Not.EqualTo(startTime) ) ;
        }
    }
}
