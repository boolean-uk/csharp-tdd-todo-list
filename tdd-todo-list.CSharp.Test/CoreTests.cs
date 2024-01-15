using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Authentication;


namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList? core;
        
        [SetUp] 
        public void SetUp() {
            core = new TodoList();
            core.tasks.Add(new TodoList.Task(1, "task1", false));
            core.tasks.Add(new TodoList.Task(2, "task2", false));
            core.tasks.Add(new TodoList.Task(3, "task3", true));
            core.tasks.Add(new TodoList.Task(4, "task4", false));
        }

        [Test]
        public void TesstAddTask() {
            bool isAdded = core.AddTask("task5");

            Assert.IsTrue(isAdded);
            Assert.IsTrue(core.tasks.Any(t => t._id == 5));
            Assert.AreEqual(5, core.tasks.Count);
        }

        [Test]
        public void TestRemoveTask() {
            bool isRemoved = core.RemoveTask(2);

            Assert.IsTrue(isRemoved);
            Assert.IsFalse(core.tasks.Any(t => t._id == 2));
            Assert.AreEqual(3, core.tasks.Count);
        }

        [Test]
        public void TestDisplayTasks() {
            List<string> tasks = core.DisplayTasks();

            Assert.That(tasks, Is.EqualTo(new List<string> { "task1 is completed: False", "task2 is completed: False", "task3 is completed: True", "task4 is completed: False" }));
        }

        [Test]
        public void TestChangeStatus() {
            bool isStateChanged = core.ChangeStatus(2, true);

            Assert.IsTrue(isStateChanged);
            
        }

        [Test]
        public void TestChangeStatusFail() {
            bool isStateChanged = core.ChangeStatus(6, false); //! _id is outside the range

            Assert.IsFalse(isStateChanged);
            
        }

        [Test]
        public void TestGetCompletedTasks() {
            List<string> tasks = core.GetCompletedTasks();

            Assert.That(tasks, Is.EqualTo(new List<string> { "task3" }));
        }
        [Test]
        public void TestGetIncompletedTasks() {
            List<string> tasks = core.GetIncompletedTaska();

            Assert.That(tasks, Is.EqualTo(new List<string> { "task1", "task2", "task4" }));
        }
        [Test]
        public void TestSearchTask() {
            TodoList.Task foundTask = core.SearchTask(4);

            Assert.IsNotNull(foundTask);
            Assert.AreEqual("task4", foundTask.task);
            Assert.AreEqual(false, foundTask.isCompleted);
        }

        [Test]
        public void TestSearchTaskFail() {
             Assert.Throws<InvalidDataException>(() => core.SearchTask(6));
        }
        [Test]
        public void TestGetOrderedList() {
            core = new TodoList();
            core.tasks.Add(new TodoList.Task(1, "A", false));
            core.tasks.Add(new TodoList.Task(2, "D", false));
            core.tasks.Add(new TodoList.Task(3, "C", true));
            core.tasks.Add(new TodoList.Task(4, "B", false));

            List<string> orderedListAsc = core.GetOrderedList('a');
            List<string> orderedListDesc = core.GetOrderedList('d');
            

            Assert.That(orderedListAsc, Is.EqualTo(new List<string> { "A", "B", "C", "D" }));
            Assert.That(orderedListDesc, Is.EqualTo(new List<string> { "D", "C", "B", "A" }));
        }
        
    }
}