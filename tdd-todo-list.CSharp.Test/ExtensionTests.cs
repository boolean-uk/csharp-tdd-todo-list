using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
        public void AddingNewTask()
        {
            _extension.AddTask("Task1"); 
            _extension.AddTask("Task2");
            _extension.AddTask("Task3");

            List<Task> tasks = _extension.GetTasks();

            Assert.AreEqual(3, tasks.Count);
            Assert.AreEqual("Task1", tasks[0].Name);
            Assert.AreEqual("Task2", tasks[1].Name);
            Assert.AreEqual("Task3", tasks[2].Name);
            Assert.IsFalse(tasks[0].Status);
            Assert.IsFalse(tasks[1].Status);
            Assert.IsFalse(tasks[2].Status);
        }

        [Test]
        public void GettingTaskById()
        {
            _extension.AddTask("Task1");
            _extension.AddTask("Task2");
            _extension.AddTask("Task3");

            Task task = _extension.GetTaskById(3);

            Assert.IsNotNull(task);
            Assert.AreEqual("Task3", task.Name);
            Assert.IsFalse(task.Status);
        }

        [Test]
        public void ChangingTaskName()
        {
            _extension.AddTask("Task1");
            _extension.AddTask("Task2");
            _extension.AddTask("Task3");

            _extension.UpdateTaskName("Task5!", 2);
            Task task = _extension.GetTaskById(2);

            Assert.AreEqual("Task5!", task.Name);
        }

        [Test]
        public void ChangingTaskStatus()
        {
            _extension.AddTask("Task1");
            _extension.AddTask("Task2");
            _extension.AddTask("Task3");

            _extension.UpdateTaskStatus(2);
            Task task = _extension.GetTaskById(2); 

            Assert.IsTrue(task.Status);
        }

        [Test]
        public void GetDateAndTimeOfTask()
        {
            _extension.AddTask("Task1");
            _extension.AddTask("Task2");
            _extension.AddTask("Task3");

            Task task = _extension.GetTaskById(2);

            Assert.IsNotNull(task.DateTime);
        }
    }
    
}
