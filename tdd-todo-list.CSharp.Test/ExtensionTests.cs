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
        public void GetTaskById()
        {
            var item1 = new TodoItem("Task 1");
            var item2 = new TodoItem("Task 2");
            _todoList.AddTask(item1);
            _todoList.AddTask(item2);

            var result = _extension.GetTaskById(item2.Id);

            Assert.AreEqual(item2, result);
        }
        [Test]
        public void UpdateTaskName()
        {
            var item1 = new TodoItem("Task 1");
            _todoList.AddTask(item1);

            _extension.UpdateTaskName(item1.Id, "This is the new task name");

            Assert.AreEqual("This is the new task name", item1.Title);
        }
        [Test]
        public void UpdateTaskStatus()
        {
            var item1 = new TodoItem("Task 1");
            _todoList.AddTask(item1);

            _extension.UpdateTaskStatus(item1.Id, true);

            Assert.IsTrue(item1.IsCompleted);
        }
    }
}