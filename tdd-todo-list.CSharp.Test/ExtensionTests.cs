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
        public void GetTaskById() 
        {
            // arrange
            TodoListExtension extension = new TodoListExtension();
            Task task1 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up cake".ToLower(),
                Completed = true
            };
            Task task2 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up shoes".ToLower(),
                Completed = true
            };
            Task task3 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "send letter".ToLower(),
                Completed = true
            };
           
            extension.tasks.Add(task1);
            extension.tasks.Add(task2);
            extension.tasks.Add(task3);

            // act
            Task? result = extension.Search(task1.Id);

            //
            Assert.AreEqual(task1, result);
        }

        [Test]
        public void UpdateTask()
        {
            // arrange
            TodoListExtension extension = new TodoListExtension();
            Task task1 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up cake".ToLower(),
                Completed = true
            };
            Task task2 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up shoes".ToLower(),
                Completed = true
            };            
            extension.tasks.Add(task1);
            extension.tasks.Add(task2);

            string newTask = "Send letter before 9 pm!";


            // act
            bool result = extension.Update(task2.Id, newTask);


            //assert
            Assert.IsTrue(result);            
        }

        [Test]
        public void UpdateTaskStatus()
        {
            // arrange
            TodoListExtension extension = new TodoListExtension();
            Task task1 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up cake".ToLower(),
                Completed = true
            };
            Task task2 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up shoes".ToLower(),
                Completed = false
            };
            extension.tasks.Add(task1);
            extension.tasks.Add(task2);
            
            // act
            bool result = extension.ChangeTaskStatus(task2.Id, true);


            //assert
            Assert.IsTrue(result);
        }

        [Test]
        public void DateCreated()
        {
            // arrange
            TodoListExtension extension = new TodoListExtension();
            Task task1 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up cake".ToLower(),
                Completed = true,
                date = DateTime.Now
            };
            Task task2 = new Task()
            {
                Id = Guid.NewGuid(),
                Message = "Pick up shoes".ToLower(),
                Completed = false,
                date = DateTime.Now
            };
            extension.tasks.Add(task1);
            extension.tasks.Add(task2);

            // act
            Task result = extension.GetTimeOfCreation(task2.Id);


            //assert
            Assert.AreEqual(task2.date, result.date);
        }
    }
}
