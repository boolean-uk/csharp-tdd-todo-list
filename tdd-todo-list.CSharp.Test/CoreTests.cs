using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("vacum")]
        [TestCase("clean")]
        [TestCase("make dinner")]
        [TestCase("sleep")]
        [TestCase("take out trash")]
        public void AddtoListTest(string task)
        {
            TodoList todoList = new TodoList();

            bool result = todoList.Add(task);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ChangeTaskTest()
        {

            TodoList todoList = new TodoList();
            string task = "brush teeth";
            todoList.Add(task);

            bool result = todoList.ChangeTask(task);

            Assert.That(result, Is.True);
        }

        [Test]
        public void ChangeNonExistingTaskTest()
        {
            TodoList todoList = new TodoList();
            string task = "go for walk";

            bool result = todoList.ChangeTask(task);

            Assert.That(result, Is.False);
        }

        [Test]
        public void showAllTasks()
        {
            TodoList todoList = new TodoList();
            string task1 = "a";
            string task2 = "b";
            int expectedCount = 2;

            todoList.Add(task1);
            todoList.Add(task2);
            Dictionary<string, bool> tasks = todoList.todoList;
            int result = tasks.Count;

            Assert.That(result, Is.EqualTo(expectedCount));

        }

        public void getAllCompletedTasks()
        {
            TodoList todoList = new TodoList();
            string task1 = "walk the dog";
            string task2 = "eat";
            string task3 = "run";
            int expectedCount = 2;

            todoList.Add(task1);
            todoList.Add(task2);
            todoList.Add(task3);
            todoList.ChangeTask(task1);
            todoList.ChangeTask(task2);

            List<string> tasks = todoList.completedTasks;
            int result = tasks.Count;

            Assert.That(result, Is.EqualTo(expectedCount));
        }

        [Test]
        public void getAllIncolompletedTasks()
        {
            TodoList todoList = new TodoList();
            string task1 = "a";
            string task2 = "b";
            string task3 = "c";

            int expectedCount = 1;

            todoList.Add(task1);
            todoList.Add(task2);
            todoList.Add(task3);

            todoList.ChangeTask(task1);
            todoList.ChangeTask(task2);

            List<string> tasks = todoList.inCompletedTasks;
        }

        [TestCase("get dressed")]
        [TestCase("pet dog")]
        [TestCase("pet cat")]
        [TestCase("feed family of 10")]
        [TestCase("work")]

        public void searchForTask(string task)
        {
            TodoList todo = new TodoList();
            todo.Add(task);

            bool result = todo.Search(task);

            Assert.That(result, Is.True);
        }

        [TestCase("get dressed")]
        [TestCase("pet dog")]
        [TestCase("pet cat")]
        [TestCase("feed family of 10")]
        [TestCase("work")]

        public void searchForNonExistingTask(string task)
        {

            TodoList todo = new TodoList();
            string otherTask = "boil potatoes";
            todo.Add(otherTask);

            bool result = todo.Search(task);

            Assert.That(result, Is.False);

        }

        [Test]
        public void removeTaskTest()
        {
            TodoList todo = new TodoList();
            string taskToBeRemoved = "code some nice code";
            todo.Add(taskToBeRemoved);

            bool result = todo.Remove(taskToBeRemoved);

            Assert.That(result, Is.True);
        }

        [Test]
        public void getAllTasksAscending()
        {
            TodoList todo = new TodoList();
            string task1 = "lay ball";
            string task2 = "walk the dog";
            string task3 = "eat";
            string task4 = "run";
            string expectedFirst = task3;

            todo.Add(task1);
            todo.Add(task2);
            todo.Add(task3);
            todo.Add(task4);

            Dictionary<string, bool> tasks = todo.tasksAscending;
            string result = tasks.First().Key;

            Assert.That(expectedFirst, Is.EqualTo(result));
        }

        [Test]
        public void getAllTasksDescending()
        {
            TodoList todo = new TodoList();
            string task1 = "lay ball";
            string task2 = "walk the dog";
            string task3 = "eat";
            string task4 = "run";
            string expectedFirst = task2;

            todo.Add(task1);
            todo.Add(task2);
            todo.Add(task3);
            todo.Add(task4);

            Dictionary<string, bool> tasks = todo.tasksDescending;
            string result = tasks.First().Key;

            Assert.That(expectedFirst, Is.EqualTo(result));
        }

    }
}