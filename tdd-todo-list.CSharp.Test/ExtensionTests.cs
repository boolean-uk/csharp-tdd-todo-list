using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {


        TodoListExtension list;
        [SetUp]
        public void Setup()
        {
            list = new TodoListExtension();
            ToDoTask task1 = new ToDoTask("Clean");
            ToDoTask task2 = new ToDoTask("Laundry");
            ToDoTask task3 = new ToDoTask("Coffee");
            ToDoTask task4 = new ToDoTask("Break");

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);

        }
        [Test]
        public void TestGetTaskById()
        {
            List<ToDoTask> tasks = list.GetTasks();

            tasks.ForEach(task =>
            {
                string id = task.Id;
                string actualName = list.GetTaskById(id).Name;

                Assert.NotNull(actualName);
                Assert.AreEqual(actualName, task.Name);

            });
        }

        [Test]
        public void TestUpdateTaskName()
        {
            List<ToDoTask> tasks = list.GetTasks();
            var  taskToEdit = tasks[0];

            list.UpdateTaskName(taskToEdit.Id, "Procastinate");
            Assert.That(tasks[0].Name, Is.EqualTo("Procastinate"));
        }

        [Test]
        public void TestUpdateTaskStatus()
        {
            List<ToDoTask> incompleteTasks = list.GetIncompleteTasks();
            Assert.That(incompleteTasks.Count, Is.GreaterThan(0));

            list.GetIncompleteTasks().ForEach(task => {
                list.UpdateTaskStatus(task.Id, true);
            });
            Assert.That(list.GetIncompleteTasks().Count, Is.EqualTo(0));
           
        }
    }
}
