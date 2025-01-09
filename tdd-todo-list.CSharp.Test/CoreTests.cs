using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        TodoList list;
        [SetUp]
        public void Setup()
        {
            list = new TodoList();
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
        public void TestGetTasks()
        {
            List<ToDoTask> tasks = list.GetTasks();
            Assert.That(tasks.Count, Is.EqualTo(4));
            Assert.That(tasks.First().Name, Is.EqualTo("Clean"));
            Assert.That(tasks.Last().Name, Is.EqualTo("Break"));
        }

        public void TestCompleteTask()
        {
            List<ToDoTask> tasks = list.GetTasks();
            ToDoTask t1 = tasks.Where(x => x.Name == "Coffee").First();
            ToDoTask t2 = tasks.Where(x => x.Name == "Laundry").First();
            t1.CompleteTask(); 
            t2.CompleteTask();
            Assert.That(t1.IsComplete, Is.EqualTo(true));
            Assert.That(t2.IsComplete, Is.EqualTo(true));

        }

        [Test]
        public void TestGetCompletedTasks()
        {
            List<ToDoTask> tasks = list.GetTasks();
            ToDoTask t1 = tasks.Where(x => x.Name == "Coffee").First();
            ToDoTask t2 = tasks.Where(x => x.Name == "Laundry").First();
            t1.CompleteTask();
            t2.CompleteTask();
            List<ToDoTask> completedTasks = list.GetCompletedTasks();

            Assert.That(completedTasks.Count, Is.EqualTo(2));
            Assert.That(completedTasks.Contains(t1), Is.True);
            Assert.That(completedTasks.Contains(t2), Is.True);
        }

        [Test]
        public void TestGetIncompleteTasks()
        {
            List<ToDoTask> tasks = list.GetTasks();
            ToDoTask t1 = tasks.Where(x => x.Name == "Coffee").First();
            ToDoTask t2 = tasks.Where(x => x.Name == "Break").First();
            t1.CompleteTask();
            t2.CompleteTask();
            List<ToDoTask> incompleteTasks = list.GetIncompleteTasks();

            Assert.That(incompleteTasks.Count, Is.EqualTo(2));
            Assert.That(incompleteTasks.First().Name, Is.EqualTo("Clean"));
            Assert.That(incompleteTasks.Last().Name, Is.EqualTo("Laundry"));
        }

        [Test]
        public void TestAddRemoveTask()
        {
            ToDoTask newTask = new ToDoTask("Bathroom");
            list.Add(newTask);
            List<ToDoTask> tasks = list.GetTasks();

            Assert.That(tasks.Count, Is.EqualTo(5));
            Assert.That(tasks.Last().Name, Is.EqualTo("Bathroom"));

            list.Remove("Bathroom");
            Assert.That(tasks.Count, Is.EqualTo(4));
            Assert.That(tasks.Last().Name, Is.EqualTo("Break"));
        }

        
        [Test]
        public void TestSearchTasks()
        {

            ToDoTask breakTask = list.SearchTask("Break");
            Assert.IsTrue(breakTask != null);
        }
        [Test]
        public void TestSearchFail()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => list.SearchTask("Loaf"));
            Assert.That(ex.Message, Is.EqualTo("Sequence contains no elements"));
        }

        [Test]
        public void TestGetTasksAscending()
        {
            List<ToDoTask> ascendingTasks = list.GetTasksAscending();
            Assert.That(ascendingTasks.First().Name, Is.EqualTo("Break"));
            Assert.That(ascendingTasks.Last().Name, Is.EqualTo("Laundry"));

        }

        [Test]
        public void TestGetTasksDescending()
        {
            List<ToDoTask> descendingTasks = list.GetTasksDescending();
            Assert.That(descendingTasks.First().Name, Is.EqualTo("Laundry"));
            Assert.That(descendingTasks.Last().Name, Is.EqualTo("Break"));

        }
    }
}