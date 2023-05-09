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
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void checkIfAdded()
        {
            _extension.addTask(4,"task4", "true");
            Assert.IsTrue(_extension._myList.ContainsKey(4));
        }

        [Test]
        public void checkIfNameChange()
        {
            _extension.updateTaskName(4, "new task");
            Assert.IsTrue(_extension._myList[4][0].Equals("new task"));
        }

        [Test]
        public void checkIfStatusChange()
        {
            _extension.updateTaskStatus(4, "false");
            Assert.IsTrue(_extension._myList[4][1].Equals("false"));
        }

        [Test]
        public void checkCreationTime()
        {
            Assert.AreEqual(_extension._myListTime, _extension.getCreationTime());
        }
    }
}
