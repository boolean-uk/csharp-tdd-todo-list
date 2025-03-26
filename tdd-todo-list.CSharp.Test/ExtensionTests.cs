using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Diagnostics.Contracts;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        TaskExtension vliegen;

        
        public ExtensionTests()
        {
            vliegen = new TaskExtension("vliegen");
            _extension = new TodoListExtension(new List<TaskExtension>() { new TaskExtension("rennen"), new TaskExtension("springen"), vliegen, new TaskExtension("duiken"), new TaskExtension("vallen"), new TaskExtension("opstaan"), new TaskExtension("doorgaan") });
        }

        [Test]
        public void GetTaskByIDTest()
        {
            
            TaskExtension result = _extension.GetTask(1);
            Assert.That(result, Is.EqualTo(vliegen));
        }
        [Test]
        public void GetNoTaskByIDTest()
        {
            TaskExtension result = _extension.GetTask(700);
            Assert.IsNull(result);
        }

        [Test]
        public void UpdateNameTest()
        {
            bool result = _extension.UpdateName(2, "Miauw");
            Assert.IsTrue(result);
            Assert.That(_extension.GetTask(2).Name, Is.EqualTo("Miauw"));
        }
        [Test]
        public void UpdateNoNameTest()
        {
            bool result = _extension.UpdateName(700, "Miauw");
            Assert.IsFalse(result);
        }
        [Test]
        public void ChangeStatusTest()
        {
            bool result = _extension.ChangeStatus(2);
            Assert.IsTrue(result);
            Assert.IsTrue(_extension.GetTask(2).Status);
        }
        [Test]
        public void ChangeNoStatusTest()
        {
            bool result = _extension.ChangeStatus(63883);
            Assert.IsFalse(result);
        }
        [Test]
        public void SeeDates()
        {
            Assert.That(_extension.GetTimes(), Is.TypeOf(typeof(List<DateTime>)));
            Assert.That(_extension.GetTimes(), Is.Not.Empty);
        }

    }
}
