using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {


        TodoList core;

        [SetUp]
        public void SetUp() {
        
         core = new TodoList();

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
            Assert.That(core.ShowTaskList(core.tasks) , Is.EqualTo("Task1, Task2, Task3, "));
        }
        [Test]
        public void ToggleTaskStatus() {

            TODOItem task1 = core.Add("Task1");
            TODOItem task2  = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");

            bool returnBool = core.UpdateStatus(task2.id);

            bool result = core.tasks[1].status;

            Assert.That(returnBool, Is.True);
            Assert.That(result, Is.True);

        }

        [Test]
        public void FilterCompleteTasks()
        {
           

            TODOItem task1 = core.Add("Task1");
            TODOItem task2 = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");

            core.UpdateStatus(task2.id);
            core.UpdateStatus(task3.id);

            List<TODOItem> correctFilter = new List<TODOItem>();
            correctFilter.Add(task2);
            correctFilter.Add(task3);
            
            Assert.That(core.filterItems(true), Is.EqualTo(correctFilter));

        }
        [Test]
        public void FilterIncompleteTasks()
        {


            TODOItem task1 = core.Add("Task1");
            TODOItem task2 = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");

            core.UpdateStatus(task2.id);
            core.UpdateStatus(task3.id);

            List<TODOItem> correctFilter = new List<TODOItem>();
            correctFilter.Add(task1);

            Assert.That(core.filterItems(false), Is.EqualTo(correctFilter));

        }

        [Test]
        public void SearchForTaskAndFail()
        {


            TODOItem task1 = core.Add("Task1");
            TODOItem task2 = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");


            string response = core.Search("Task4");

            Assert.That(response, Is.EqualTo("There is no such task."));

        }

        [Test]
        public void SearchForTaskAndSucceed()
        {


            TODOItem task1 = core.Add("Task1");
            TODOItem task2 = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");


            string response = core.Search("Task3");

            Assert.That(response, Is.EqualTo("Task3, "));

        }

        [Test]
        public void RemoveTaskFromList()
        {
            TODOItem task1 = core.Add("Task1");
            TODOItem task2 = core.Add("Task2");
            TODOItem task3 = core.Add("Task3");

            Assert.That(core.tasks.Count, Is.EqualTo(3));


            bool result = core.deleteTask(task2.id);

            Assert.IsTrue(result);
            Assert.That(core.tasks.Count, Is.EqualTo(2));


        }
        [Test]
        public void sortTasksAscending()
        {
            TODOItem task1 = core.Add("BTask1");
            TODOItem task2 = core.Add("ATask2");
            TODOItem task3 = core.Add("CTask3");

            core.sortTasksAscending();

            List<TODOItem> correctSort = new List<TODOItem>();
            correctSort.Add(task2);
            correctSort.Add(task1);
            correctSort.Add(task3);

            Assert.That(core.ShowTaskList(core.tasks), Is.EqualTo("ATask2, BTask1, CTask3, "));


        }
        [Test]
        public void sortTasksDescending()
        {
            TODOItem task1 = core.Add("BTask1");
            TODOItem task2 = core.Add("ATask2");
            TODOItem task3 = core.Add("CTask3");

            core.sortTasksDescending();

            List<TODOItem> correctSort = new List<TODOItem>();
            correctSort.Add(task2);
            correctSort.Add(task1);
            correctSort.Add(task3);

            Assert.That(core.ShowTaskList(core.tasks), Is.EqualTo("CTask3, BTask1, ATask2, "));


        }





    }
}