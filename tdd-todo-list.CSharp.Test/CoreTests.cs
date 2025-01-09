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
        public void TaskTitle()
        {
            TodoTask task = new TodoTask("test");
            Assert.That(task.title, Is.EqualTo("test"));
            TodoTask task2 = new TodoTask("testtest", true);
            Assert.That(task2.title, Is.EqualTo("testtest"));
        }

        [Test]
        public void AddAndGet()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("test");
            TodoTask task2 = new TodoTask("test2");
            todos.Add(task1);
            Assert.That(todos.GetTasks(), Has.Count.EqualTo(1));
            todos.Add(task2);
            Assert.That(todos.GetTasks(), Has.Count.EqualTo(2));
        }

        [Test]
        public void CantAddDuplicateTitle()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("test");
            Assert.That(todos.Add(task1), Is.True);
            Assert.That(todos.GetTasks(), Has.Count.EqualTo(1));
            Assert.That(todos.Add(task1), Is.False);
            Assert.That(todos.GetTasks(), Has.Count.EqualTo(1));
        }

        [Test]
        public void ToggleComplete()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("test", false);
            todos.Add(task1);
            Assert.That(task1.completed, Is.False);
            todos.ToggleComplete("test");
            Assert.That(task1.completed, Is.True);
        }

        [Test]
        public void GetCompleted()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("test");
            TodoTask task2 = new TodoTask("test2");
            TodoTask task3 = new TodoTask("test3");
            todos.Add(task1);
            todos.Add(task2);
            todos.Add(task3);
            todos.ToggleComplete("test");
            todos.ToggleComplete("test2");
            List<TodoTask> shouldBeCompleted = new List<TodoTask> { task1, task2 };
            Assert.That(
                todos.GetCompleted().OrderBy((a) => a.title),
                Is.EqualTo(shouldBeCompleted.OrderBy((a) => a.title))
            );
        }

        [Test]
        public void GetIncomplete()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("test");
            TodoTask task2 = new TodoTask("test2");
            TodoTask task3 = new TodoTask("test3");
            todos.Add(task1);
            todos.Add(task2);
            todos.Add(task3);
            todos.ToggleComplete("test2");
            List<TodoTask> shouldBeIncomplete = new List<TodoTask> { task1, task3 };
            Assert.That(
                todos.GetIncomplete().OrderBy((a) => a.title),
                Is.EqualTo(shouldBeIncomplete.OrderBy((a) => a.title))
            );
        }

        [Test]
        public void GetOrdered()
        {
            TodoList todos = new TodoList();
            TodoTask task1 = new TodoTask("a");
            TodoTask task2 = new TodoTask("b");
            TodoTask task3 = new TodoTask("c");
            TodoTask task4 = new TodoTask("d");
            todos.Add(task1);
            todos.Add(task2);
            todos.Add(task3);
            todos.Add(task4);
            List<string> expectedAscending = new List<String> { "a", "b", "c", "d" };
            List<string> expectedDescending = new List<String> { "d", "c", "b", "a" };
            Assert.That(
                todos.GetOrderedTasks(true).Select((el) => el.title),
                Is.EqualTo(expectedAscending)
            );
            Assert.That(
                todos.GetOrderedTasks(false).Select((el) => el.title),
                Is.EqualTo(expectedDescending)
            );
        }
    }
}
