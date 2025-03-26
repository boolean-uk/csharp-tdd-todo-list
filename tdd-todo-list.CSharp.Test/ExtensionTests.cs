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
        public TodoList _todoList;
        public TodoListExtension _extension;

        [SetUp]
        public void Setup()
        {
            _todoList = new TodoList();
            _extension = new TodoListExtension(_todoList);
        }

        [Test]
        public void GetTaskById_ReturnTask()
        {
            var task1 = new TodoTask("Task 1");
            var task2 = new TodoTask("Task 2");
            _todoList.AddATask(task1);
            _todoList.AddATask(task2);
            var result = _extension.GetTaskById(task2.Id);
            Assert.AreEqual(task2, result);
        }
        [Test]
        public void UpdateNameOfTask()
        {
            var task1 = new TodoTask("Task 1");
            _todoList.AddATask(task1);
            _extension.UpdateTaskName(task1.Id, "This is the new task name");
            Assert.AreEqual("This is the new task name", task1.Title);
        }
        [Test]
        public void ChangeTaskState()
        {
            var task1 = new TodoTask("Task 1");
            _todoList.AddATask(task1);
            _extension.ChangeTaskState(task1.Id, true);
            Assert.IsTrue(task1.IsCompleted);
        }
    }
}
