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
    public class CoreTestsExtension
    {


        TodoListExtension core;
        TOTask TODOtask;

        [SetUp]
        public void SetUp()
        {

            core = new TodoListExtension();

        }
        [Test]
        public void AddTask()
        {

            core.Add("Task1");


            Assert.That(core.tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void SeeTasks()
        {

            core.Add("Task1");
            core.Add("Task2");
            core.Add("Task3");


            Assert.That(core.tasks.Count, Is.EqualTo(3));
            Assert.That(core.ShowTaskList(core.tasks), Is.EqualTo("Task1, Task2, Task3, "));
        }
        [Test]
        public void ToggleTaskStatus()
        {

            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");

            bool returnBool = core.UpdateStatus(task2.id);

            bool result = core.tasks[1].status;

            Assert.That(returnBool, Is.True);
            Assert.That(result, Is.True);

        }

        [Test]
        public void FilterCompleteTasks()
        {


            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");

            core.UpdateStatus(task2.id);
            core.UpdateStatus(task3.id);

            List<TOTask> correctFilter = new List<TOTask>();
            correctFilter.Add(task2);
            correctFilter.Add(task3);

            Assert.That(core.filterItems(true), Is.EqualTo(correctFilter));

        }
        [Test]
        public void FilterIncompleteTasks()
        {


            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");

            core.UpdateStatus(task2.id);
            core.UpdateStatus(task3.id);

            List<TOTask> correctFilter = new List<TOTask>();
            correctFilter.Add(task1);

            Assert.That(core.filterItems(false), Is.EqualTo(correctFilter));

        }

        [Test]
        public void SearchForTaskAndFail()
        {


            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");


            string response = core.Search("Task4");

            Assert.That(response, Is.EqualTo("There is no such task."));

        }

        [Test]
        public void SearchForTaskAndSucceed()
        {


            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");


            string response = core.Search("Task3");

            Assert.That(response, Is.EqualTo("Task3, "));

        }

        [Test]
        public void RemoveTaskFromList()
        {
            TOTask task1 = core.Add("Task1");
            TOTask task2 = core.Add("Task2");
            TOTask task3 = core.Add("Task3");

            Assert.That(core.tasks.Count, Is.EqualTo(3));


            bool result = core.deleteTask(task2.id);

            Assert.IsTrue(result);
            Assert.That(core.tasks.Count, Is.EqualTo(2));


        }
        [Test]
        public void sortTasksAscending()
        {
            TOTask task1 = core.Add("BTask1");
            TOTask task2 = core.Add("ATask2");
            TOTask task3 = core.Add("CTask3");

            core.sortTasksAscending();

            List<TOTask> correctSort = new List<TOTask>();
            correctSort.Add(task2);
            correctSort.Add(task1);
            correctSort.Add(task3);

            Assert.That(core.ShowTaskList(core.tasks), Is.EqualTo("ATask2, BTask1, CTask3, "));


        }
        [Test]
        public void sortTasksDescending()
        {
            TOTask task1 = core.Add("BTask1");
            TOTask task2 = core.Add("ATask2");
            TOTask task3 = core.Add("CTask3");

            core.sortTasksDescending();

            List<TOTask> correctSort = new List<TOTask>();
            correctSort.Add(task2);
            correctSort.Add(task1);
            correctSort.Add(task3);

            Assert.That(core.ShowTaskList(core.tasks), Is.EqualTo("CTask3, BTask1, ATask2, "));


        }

        [Test]
        public void getTaskById()
        {
            TOTask task1 = core.Add("BTask1");
            TOTask task2 = core.Add("ATask2");
            TOTask task3 = core.Add("CTask3");

            core.sortTasksDescending();

            TOTask taskById = core.getTaskById(1);

            Assert.That(taskById, Is.EqualTo(task2));


        }
        [Test]
        public void UpdateTaskName()
        {
            TOTask task1 = core.Add("BTask1");
            TOTask task2 = core.Add("ATask2");
            TOTask task3 = core.Add("CTask3");

   

            bool result = core.updateTaskName(2, "Name Changed");

            Assert.That(result, Is.True);
            Assert.That(core.tasks[2].name, Is.EqualTo(core.getTaskById(2).name));


        }

        [Test]

        public void giveTodoCreationTime() {
        
        DateTime timeNow = DateTime.Now;

            
        TOTask task = new  TOTask("test", 1, timeNow);
            
            
        Assert.That(timeNow, Is.EqualTo(task.creationTime));
        
        
        }





    }
}
