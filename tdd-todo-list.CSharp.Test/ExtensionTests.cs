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
            var tasks = list.GetTaskById(list.id);

            //assert
            Assert.That(tasks.Name, Is.EqualTo("Test"));
        }

        [Test]
        public void ChangeTaskNameById()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test", Priority.High, Category.Work);

            //act
            list.UpdateTaskName(list.id, "UpdatedTest");

            //assert
            Assert.That(tasks.Name, Is.EqualTo("UpdatedTest"));
        }

        [Test]
        public void TimeCreatedAtIsSet()
        {
            //arrange
            ToDoList list = new ToDoList();
            var currentTime = DateTime.Now;
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var createdAt = list.CreatedAt;

            //assert
            Assert.That(currentTime, Is.EqualTo(createdAt));
        }

        public void TimeCompletedAtIsSet()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            list.ChangeStatusById(list.id, true);
            var completedAt = list.CompletedAt;

            //assert
            Assert.That(completedAt, Is.EqualTo(null!));
        }
    }
}
