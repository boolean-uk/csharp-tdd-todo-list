using NUnit.Framework;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        [Test]
        public void TestGetTasks()
        {
            TodoList todo = new TodoList();
            Assert.NotNull(todo.getTasks());
        }

        [Test]
        public void TestAddTask()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");

            //execute
            todo.addTask(task);

            //verify
            Assert.AreEqual(todo.getTasks().Count, 1);
        }

        [Test]
        public void TestGetTasksValues()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");
            todo.addTask(task);

            //execute
            List<TodoTask> tasks = todo.getTasks();

            //verify
            Assert.NotNull(tasks);
            Assert.AreEqual(tasks.First().Name, "TaskName");
        }

        [Test]
        public void TestSetTaskStatus()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");
            todo.addTask(task);

            //execute
            bool changedTaskStatus = todo.toggleTaskStatus(task);

            //verify
            Assert.IsTrue(changedTaskStatus);
            Assert.IsTrue(todo.getTasks()[0].IsComplete);
        }

        [Test]
        public void TestGetCompleteTasks()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");
            TodoTask task2 = new("TaskName2");
            todo.addTask(task);
            todo.addTask(task2);
            todo.toggleTaskStatus(task2);

            //execute
            List<TodoTask> completeTasks = todo.getCompleteTasks();

            //verify
            Assert.That(!completeTasks.Contains(task));
            Assert.That(completeTasks.Contains(task2));
        }

        [Test]
        public void TestGetInCompleteTasks()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");
            TodoTask task2 = new("TaskName2");
            todo.addTask(task);
            todo.addTask(task2);
            todo.toggleTaskStatus(task2);

            //execute
            List<TodoTask> incompleteTasks = todo.getInCompleteTasks();

            //verify
            Assert.That(incompleteTasks.Contains(task));
            Assert.That(!incompleteTasks.Contains(task2));
        }

        [Test]
        public void TestSearchForTask()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("TaskName");
            TodoTask task2 = new("TaskName2");
            todo.addTask(task);

            //execute
            bool foundTask = todo.searchForTask(task);
            bool shouldNotBeFound = todo.searchForTask(task2);

            //verify
            Assert.IsTrue(foundTask);
            Assert.IsFalse(shouldNotBeFound);
        }

        [Test]
        public void TestGetTasksAscending()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("B");
            TodoTask task2 = new("A");
            TodoTask task3 = new("H");
            todo.addTask(task);
            todo.addTask(task2);
            todo.addTask(task3);

            //execute
            List<TodoTask> ascendingTasks = todo.getTasksAscending();

            //verify
            Assert.AreEqual(ascendingTasks[0], task2);
            Assert.AreEqual(ascendingTasks[1], task);
            Assert.AreEqual(ascendingTasks[2], task3);
        }

        [Test]
        public void TestGetTasksDescending()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("B");
            TodoTask task2 = new("A");
            TodoTask task3 = new("H");
            todo.addTask(task);
            todo.addTask(task2);
            todo.addTask(task3);

            //execute
            List<TodoTask> ascendingTasks = todo.getTasksDescending();

            //verify
            Assert.AreEqual(ascendingTasks[0], task3);
            Assert.AreEqual(ascendingTasks[1], task);
            Assert.AreEqual(ascendingTasks[2], task2);
        }

        [Test]
        public void TestClearTodo()
        {
            //setup
            TodoList todo = new TodoList();
            TodoTask task = new("B");
            TodoTask task2 = new("A");
            TodoTask task3 = new("H");
            todo.addTask(task);
            todo.addTask(task2);
            todo.addTask(task3);

            //execute
            todo.clearTodo();

            //verify
            Assert.AreEqual(todo.getTasks().Count, 0);
        }
    }
}