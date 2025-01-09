using NUnit.Framework;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        [Test]
        public void taskIsAdded()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(1));
        }

        [Test]
        public void taskIsRemoved()
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(1));

            todo.removeTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(0));
        }

        [TestCase("a task")]
        public void findTaskByname(string name)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(name);

            var foundTask = todo.findTaskByName(name);

            Assert.That(name, Is.EqualTo(foundTask.taskName));

        }

        [TestCase(true, "a task")]
        public void changeTaskStatus(bool isFinished, string taskName)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(taskName);

            todo.setTaskStatus(taskName, isFinished);
            var changedTask = todo.findTaskByName(taskName);

            Assert.That(changedTask.isFinished, Is.EqualTo(isFinished));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllTasks(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.Default).Count, Is.EqualTo(3));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllCompletedTasks(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(t1, true);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.OnlyComplete).Count, Is.EqualTo(1));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllIncompletedTasks(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(t1, true);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.OnlyIncomplete).Count, Is.EqualTo(2));
        }

        [TestCase("a", "b", "c")]
        public void getAllTasksAlphabeticalAsc(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.AllTaskAlphabeticAsc)[0].taskName, Is.EqualTo(t1));
        }

        [TestCase("a", "b", "c")]
        public void getAllTasksAlphabeticalDesc(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.AllTaskAlphabeticDesc)[0].taskName, Is.EqualTo(t3));
        }
    }
}