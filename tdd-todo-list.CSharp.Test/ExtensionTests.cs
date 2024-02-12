using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

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
        public void FirstTest()
        {
            TodoListExtension ext = new TodoListExtension();
            Assert.Pass();
        }

        [Test]
        public void FindByIdTest()
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            var task1 = new Task { Id = 1, Name = "Buy groceries", Complete = true, CreatedAt = DateTime.UtcNow };
            var task2 = new Task { Id = 2, Name = "Wash the car", Complete = false, CreatedAt = DateTime.UtcNow };
            ext.tasks.Add(task1);
            ext.tasks.Add(task2);
            //act
            var boolfound = ext.FindById(2);
            //assert
            Assert.True(boolfound);
        }

        [Test]
        public void UpdateTaskNameTest()
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            var task1 = new Task { Id = 1, Name = "Buy groceries", Complete = true, CreatedAt = DateTime.UtcNow };
            var task2 = new Task { Id = 2, Name = "Wash the car", Complete = false, CreatedAt = DateTime.UtcNow };
            ext.tasks.Add(task1);
            ext.tasks.Add(task2);
            //act
            ext.updateTaskName(2, "Clean the kitchen");
            //assert
            Assert.AreEqual("Clean the kitchen", task2.Name);
        }

        [Test]
        public void ChangeStatusTest()
        {
            //assert
            TodoListExtension ext = new TodoListExtension();
            var task1 = new Task { Id = 1, Name = "Buy groceries", Complete = true, CreatedAt = DateTime.UtcNow };
            var task2 = new Task { Id = 2, Name = "Wash the car", Complete = false, CreatedAt = DateTime.UtcNow };
            ext.tasks.Add(task1);
            ext.tasks.Add(task2);
            //act
            ext.changeStatus(task2.Id);
            //assert
            Assert.IsTrue(task2.Complete);
        }

        [Test]
        public void CreatedTimeTest()
        {
            //assert
            TodoListExtension ext = new TodoListExtension();
            var task1 = new Task { Id = 1, Name = "Buy groceries", Complete = true, CreatedAt = DateTime.UtcNow };
            var task2 = new Task { Id = 2, Name = "Wash the car", Complete = false, CreatedAt = DateTime.UtcNow };
            ext.tasks.Add(task1);
            ext.tasks.Add(task2);
            //act
            var time = ext.Created(task1);
            //assert
            Assert.IsNotNull(time);
        }


    }
}
