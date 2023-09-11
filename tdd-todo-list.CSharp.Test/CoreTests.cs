using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        public TodoList _todoList;

        [SetUp] // for isolation -> https://docs.nunit.org/articles/nunit/writing-tests/attributes/setup.html
        public void SetUp()
        {
            _todoList = new TodoList();
        }

        [Test]
        public void AddATaskAndAddTaskToList()
        {
            //setup
            var task = new Task("This is a test task");
            //execute
            _todoList.AddATask(task);
            //verify
            Assert.Contains(task, _todoList.GetTask());
        }

        [Test]
        public void GetCompleteTaskAndReturnCompleteTask()
        {
            //setup
            var task1 = new Task("Complete Task");
            task1.ChangeTask(true);
            var task2 = new Task("Incomplete task");
            _todoList.AddATask(task1);
            _todoList.AddATask(task2);
            //execute
            var result = _todoList.GetCompleteTask();
            //verify
            Assert.Contains(task1, result);
            Assert.IsFalse(result.Contains(task2));
        }

        [Test]
        public void FindATaskAndReturnCorrectTask()
        {
            //setup
            var task = new Task("Find the task");
            _todoList.AddATask(task);
            //execute
            var result = _todoList.FindATask("Find the task");
            //verify
            Assert.AreEqual(task, result);
        }

        [Test]
        public void FindATaskReturnNullIfNonExisting()
        {
            //setup
            var task = new Task("Dont you find me");
            //execute
            var result = _todoList.FindATask("Dont you find me");
            //verify
            Assert.IsNull(result);
        }

        [Test]
        public void RemoveATaskAndRemovesTaskFromList()
        {
            // Setup
            var task = new Task("This is the task to remove");
            _todoList.AddATask(task);
            // Execute
            _todoList.RemoveATask(task);
            // Verify
            Assert.IsFalse(_todoList.GetTask().Contains(task));
        }

        [Test]
        public void TaskAscendingOrderAndReturnsTasksInAscendingOrder()
        {
            // Setup
            var task1 = new Task("Second Task");
            var task2 = new Task("First Task");
            var task3 = new Task("Third Task");
            _todoList.AddATask(task1);
            _todoList.AddATask(task2);
            _todoList.AddATask(task3);
            // Execute
            var orderedTasks = _todoList.TaskAscendingOrder();
            // Verify
            Assert.AreEqual(task2, orderedTasks[0]);
            Assert.AreEqual(task1, orderedTasks[1]);
            Assert.AreEqual(task3, orderedTasks[2]);
        }

        [Test]
        public void TaskDescendingOrderAndReturnsTasksInDescendingOrder()
        {
            // Setup
            var task1 = new Task("Second Task");
            var task2 = new Task("First Task");
            var task3 = new Task("Third Task");
            _todoList.AddATask(task1);
            _todoList.AddATask(task2);
            _todoList.AddATask(task3);
            // Execute
            var orderedTasks = _todoList.TaskDescendingOrder();
            // Verify
            Assert.AreEqual(task3, orderedTasks[0]);
            Assert.AreEqual(task1, orderedTasks[1]);
            Assert.AreEqual(task2, orderedTasks[2]);
        }

        [Test]
        public void GetIncompleteTaskAndReturnsOnlyIncompleteTasks()
        {
            // Setup
            var task1 = new Task("The complete Task");
            task1.ChangeTask(true);
            var task2 = new Task("The incomplete Task");
            _todoList.AddATask(task1);
            _todoList.AddATask(task2);
            // Execute
            var result = _todoList.GetIncompleteTask();
            // Verify
            Assert.Contains(task2, result);
            Assert.IsFalse(result.Contains(task1));
        }
    }
}