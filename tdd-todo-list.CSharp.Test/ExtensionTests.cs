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
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoListExtension extension = new TodoListExtension();
            foreach (var task in tasks)
            {
                extension.Add(task);
            }
            var taskId = 3;
            var taskByID = extension.GetTaskById(taskId);
            Assert.That(tasks[2], Is.EqualTo(taskByID));
        }
        [Test]
        public void UpdateTaskByIdAndName()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoListExtension extension = new TodoListExtension();
            foreach (var task in tasks)
            {
                extension.Add(task);
            }

            int taskId = 3;
            string newTaskName = "watch a documentary";
            var updatedTask = extension.UpdateTaskById(taskId, newTaskName);

            Assert.That(updatedTask.task, Is.EqualTo(tasks[2].task));
            Assert.That(updatedTask.id, Is.EqualTo(tasks[2].id));
        }
        [Test]
        public void UpdateTaskStatusById()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoListExtension extension = new TodoListExtension();
            foreach (var task in tasks)
            {
                extension.Add(task);
            }

            int taskId = 3;
            var updatedTask = extension.ChangeStatusById(taskId);

            Assert.That(updatedTask.isCompleted , Is.False);
        }
        [Test]
        public void GetDateCreated()
        {
            var task1 = new Task("clean your room", false);
            var task2 = new Task("do the laundry", false);
            var task3 = new Task("buy groceries", true);
            var task4 = new Task("prepare dinner", false);
            var task5 = new Task("read a book", true);
            List<Task> tasks = new List<Task> { task1, task2, task3, task4, task5 };

            TodoListExtension extension = new TodoListExtension();
            foreach (var task in tasks)
            {
                extension.Add(task);
            }

            int taskId = 3;
            var taskWithDate = extension.GetDateCreated(taskId);
            Assert.That(taskWithDate, Is.InstanceOf<DateTime>());
            var timeDifference = DateTime.Now - taskWithDate;
            Assert.That(timeDifference.TotalMinutes, Is.LessThan(1));
        }
    }
}
