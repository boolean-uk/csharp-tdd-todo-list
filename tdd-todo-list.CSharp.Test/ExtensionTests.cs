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

            TestGetTaskById();
            TestUpdateTaskName();
            TestChangeTaskStatusById();
            TestPrintTaskDetails();
           
        }
        [Test]
        public void TestGetTaskById()
        {
            _extension.AddTask("1", "Task1");

            TodoListExtension task = _extension.GetTaskById("1");

            Assert.NotNull(task);
            Assert.AreEqual("Task1", task.Name);
        }

        [Test]
        public void TestUpdateTaskName()
        {
            _extension.AddTask("5", "Task5");

            _extension.UpdateTaskName("6", "UpdatedTask");

            Assert.AreEqual("UpdatedTask", _extension.GetTaskById("6").Name);
        }

        [Test]
        public void TestChangeTaskStatusById()
        {
            _extension.AddTask("8", "Task3");

            _extension.ChangeTaskStatus("8", true);

            Assert.IsTrue(_extension.GetTaskById("8").IsComplete);
        }

        [Test]
        public void TestPrintTaskDetails()
        {
            _extension.AddTask("9", "Task9");

            _extension.PrintCreationTime("9");
            
        }
    }
}
