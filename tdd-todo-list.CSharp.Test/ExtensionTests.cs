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
            int taskId = 3;
            var taskByID = extension.GetTaskById(taskId);
            Assert.That(taskByID, Is.EqualTo(task3));

        }
    }
}
