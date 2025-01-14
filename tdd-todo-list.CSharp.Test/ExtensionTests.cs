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
        public void FindByID()
        {
            TodoListExtension toDoList = new TodoListExtension();
            toDoList.AddTask("Buy groceries");

            var taskFound = toDoList.FindTaskByID(1);
            var taskNotFound = toDoList.FindTaskByID(100);

            Assert.AreEqual("Buy groceries - False", taskFound);
            Assert.AreEqual("no task with id: 100", taskNotFound);
        }
        [Test]
        public void UpdateName()
        {
            TodoListExtension toDoList = new TodoListExtension();
            toDoList.AddTask("Buy groceries");

            var taskupdated = toDoList.UpdateName();
            var taskNotFound = toDoList.FindTaskByID(100);

            Assert.AreEqual("Buy update - False", taskupdated);
            Assert.AreEqual("no task with id: 100", taskNotFound);
        }


    }
}
