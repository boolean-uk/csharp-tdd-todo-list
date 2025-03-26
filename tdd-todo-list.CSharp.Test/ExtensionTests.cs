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
        
        private TodoListExtension _todoList;

        [SetUp]
        public void SetUp()
        {
            _todoList = new TodoListExtension();
        }



        [Test]
        public void GetTaskByIdTest()
        {
            // Arrange
            //var todoList = new TodoListExtension();
            _todoList.addId("Task A", "incomplete");

            // Act
            var result = _todoList.getTaskById(1);

            // Assert
            Assert.AreEqual("Task A", result);
        }




        //testing with invalid ID
        [Test]
        public void GetTaskByIdTest2()
        {
            // Arrange
            //var todoList = new TodoListExtension();

            _todoList.addId("Task A", "incomplete");

            // Act
            var result = _todoList.getTaskById(2); // Using an ID that doesn't exist

            // Assert
            Assert.IsNull(result);

        }



        [Test]
        public void UpdateTaskNameTest()
        {
            // Arrange
            //var todoList = new TodoListExtension();
            _todoList.addId("Task A", "incomplete");

            // Act
            _todoList.updateTaskName(1, "New Task A");

            // Assert
            var result = _todoList.getTaskById(1);
            Assert.AreEqual("New Task A", result);
        }


        [Test]
        public void UpdateTaskNameTest2()
        {
            // Arrange
            //var todoList = new TodoListExtension();
            _todoList.addId("Task A", "incomplete");

            // Act
            _todoList.updateTaskName(2, "New Task A"); // Using an ID that doesn't exist

            // Assert
            var result = _todoList.getTaskById(1); // Ensure the original task name is unchanged
            Assert.AreEqual("Task A", result);
        }
    }
}
