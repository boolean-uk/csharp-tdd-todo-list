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

        [Test]
        public void GetTaskByIdTest()
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            Task newTask = new Task("Task1");
            //act
            tasks.AddTask(newTask);
            Task task = tasks.GetTaskById(1);

            //assert
            Assert.That(task, Is.Not.Null);
            Assert.That(task, Is.EqualTo(newTask));
        }

        [Test]
        public void UpdateTaskNameTest()
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            Task newTask = new Task("Task1");
            //act
            tasks.AddTask(newTask);
            tasks.UpdateTaskNameById(1, "Task2");

            //assert
            Assert.That(newTask.TaskName, Is.EqualTo("Task2"));
        }

        [Test]
        public void UpdateTaskStatusTest()
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            Task newTask = new Task("Task1");
            //act
            tasks.AddTask(newTask);
            tasks.UpdateTaskStatusById(1, "Complete");

            //assert
            Assert.That(newTask.Status, Is.EqualTo("Complete"));
        }

        [Test]
        public void GetTimeCreatedFromTask()
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            Task newTask = new Task("Task1");
            //act
            DateTime created = newTask.GetDateTime;

            //assert
            Assert.That(created, Is.TypeOf<DateTime>());
        }
    }
}
