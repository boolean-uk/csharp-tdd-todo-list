using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void FindATaskById()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var task = list.GetAllTasks().First();
            var found = list.GetTaskById(task.Id);

            //assert
            Assert.That(found?.Name, Is.EqualTo("Test"));
        }

        [Test]
        public void ChangeTaskNameById()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var task = list.GetAllTasks().First();
            list.UpdateTaskName(task.Id, "UpdatedTest");
            var updated = list.GetTaskById(task.Id);

            //assert
            Assert.That(updated?.Name, Is.EqualTo("UpdatedTest"));
        }

        [Test]
        public void TimeCreatedAtIsSet()
        {
            //arrange
            ToDoList list = new ToDoList();

            //act
            list.AddTask("Test", Priority.High, Category.Work);
            var task = list.GetAllTasks().First();

            //assert
            Assert.That((DateTime.Now - task.CreatedAt).TotalSeconds, Is.LessThan(2));
        }

        [Test]
        public void TimeCompletedAtIsSet()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);
            var task = list.GetAllTasks().First();

            //act
            list.ChangeStatusById(task.Id, true);

            //assert
            Assert.That(task.CompletedAt, Is.Not.EqualTo(default(DateTime)));
        }
    }
}
