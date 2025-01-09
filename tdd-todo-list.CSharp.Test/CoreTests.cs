using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList todoList;
        private readonly List<string> tasks = ["Get one milk", "Sell too many cats", "Toss all coins"];

        [SetUp]
        public void Setup()
        {
            todoList = new TodoList();
        }

        [TestCase("Get milk")]
        [TestCase("Clean house")]
        [TestCase("Play games")]
        [TestCase("Dont fall of the bridge")]
        public void TestAdd(string task)
        {
            todoList.Add(task);
            Assert.That(todoList.TaskList, Has.Exactly(1).EqualTo($"{task} - not completed"));
        }

        [Test]
        public void TestTaskList()
        {
            AddTasks();
            tasks.ForEach(task =>
            {
                Assert.That(todoList.TaskList, Has.Exactly(1).Contains(task));
            });
        }

        [Test]
        public void TestTaskStatus()
        {
            AddTasks();
            Assert.That(tasks.Select(task => todoList.IsComplete(task)), Is.All.False);
            string task = "Fetch a stick";
            todoList.Add(task);
            Assert.That(todoList.IsComplete(task), Is.False);
            todoList.ToggleTask(task);
            Assert.That(todoList.IsComplete(task), Is.True);
            Assert.That(tasks.Select(task => todoList.IsComplete(task)), Is.All.False);
        }

        [Test]
        public void TestGetCompleted()
        {
            AddTasks();
            Assert.That(todoList.GetCompleted(), Is.Empty);
            tasks.ForEach(task => todoList.ToggleTask(task));
            tasks.ForEach(task =>
            {
                Assert.That(todoList.GetCompleted(), Has.Exactly(1).Contains(task));
            });
        }

        [Test]
        public void TestGetIncomplete()
        {
            AddTasks();
            tasks.ForEach(task =>
            {
                Assert.That(todoList.GetIncomplete(), Has.Exactly(1).Contains(task));
            });
            tasks.ForEach(task => todoList.ToggleTask(task));
            Assert.That(todoList.GetIncomplete(), Is.Empty);
        }


        [TestCase("Get milk", true)]
        [TestCase("Clean house", true)]
        [TestCase("Play games", false)]
        [TestCase("Dont fall of the bridge", false)]
        public void TestGet(string task, bool doAdd)
        {
            if (doAdd)
            {
                todoList.Add(task);
            }
            Assert.That(todoList.Get(task), Does.Contain(doAdd ? task : "Task not found"));
        }

        [TestCase("Get milk")]
        [TestCase("Clean house")]
        [TestCase("Play games")]
        [TestCase("Dont fall of the bridge")]
        public void TestRemoveTask(string task)
        {
            AddTasks();
            todoList.Add(task);
            Assert.That(todoList.TaskList.Count, Is.EqualTo(tasks.Count + 1));
            Assert.That(todoList.RemoveTask(task), Is.True);
            Assert.That(todoList.TaskList.Count, Is.EqualTo(tasks.Count));
            Assert.That(todoList.TaskList, Does.Not.Contain(task));
        }   

        [TestCase(true)]
        [TestCase(false)]
        public void TestGetSortedTaskList(bool asc)
        {
            AddTasks();
            Assert.That(todoList.GetSortedTaskList(asc), asc ? Is.Ordered.Ascending : Is.Ordered.Descending);
        }

        private void AddTasks()
        {
            tasks.ForEach(todoList.Add);
        }
    }
}