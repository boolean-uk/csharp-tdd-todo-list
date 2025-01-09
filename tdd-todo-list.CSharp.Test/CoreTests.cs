
using tdd_todo_list.CSharp.Main;

using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void taskIsAdded()
        {
            TodoList todo = new TodoList();
            todo.addTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(1));
        }

        [Test]
        public void taskIsRemoved()
        {
            TodoList todo = new TodoList();
            todo.addTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(1));

            todo.removeTask("a task");
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(0));
        }

        [TestCase("a task")]
        public void findTaskByname(string name)
        {
           TodoList todo = new TodoList();
            todo.addTask(name);

            var foundTask = todo.findTaskByName(name);

            Assert.That(name, Is.EqualTo(foundTask.taskName));

        }

        [TestCase(true, "a task")]
        public void changeTaskStatus(bool isFinished, string taskName) {
            TodoList todo = new TodoList();
            todo.addTask(taskName);

            todo.setTaskStatus(taskName, isFinished);
            var changedTask = todo.findTaskByName(taskName);

            Assert.That(changedTask.isFinished, Is.EqualTo(isFinished));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllTasks(string t1, string t2, string t3)
        {
            TodoList todo = new TodoList();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoList.SortCriteria.Default).Count, Is.EqualTo(3));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllCompletedTasks(string t1, string t2, string t3)
        {
            TodoList todo = new TodoList();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(t1, true);

            Assert.That(todo.getAllTasksSorted(TodoList.SortCriteria.OnlyComplete).Count, Is.EqualTo(1));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllIncompletedTasks(string t1, string t2, string t3)
        {
            TodoList todo = new TodoList();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(t1, true);

            Assert.That(todo.getAllTasksSorted(TodoList.SortCriteria.OnlyIncomplete).Count, Is.EqualTo(2));
        }

        [TestCase("a", "b", "c")]
        public void getAllTasksAlphabeticalAsc(string t1, string t2, string t3)
        {
            TodoList todo = new TodoList();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoList.SortCriteria.AllTaskAlphabeticAsc)[0].taskName, Is.EqualTo(t1));
        }

        [TestCase("a", "b", "c")]
        public void getAllTasksAlphabeticalDesc(string t1, string t2, string t3)
        {
            TodoList todo = new TodoList();
            todo.addTask(t1);
            todo.addTask(t2);
            todo.addTask(t3);

            Assert.That(todo.getAllTasksSorted(TodoList.SortCriteria.AllTaskAlphabeticDesc)[0].taskName, Is.EqualTo(t3));
        }

        [Test]
        public void testExceptionFindInvalidName()
        {
            TodoList todo = new TodoList();

            Assert.Throws<KeyNotFoundException>(() => todo.findTaskByName("invalid name"));
        }

        [Test]
        public void testExceptionCouldNotRemove()
        {
            TodoList todo = new TodoList();

            Assert.Throws<KeyNotFoundException>(() => todo.removeTask("invalid"));
        }

        [Test]
        public void testExceptionCouldNotChangeStatus()
        {
            TodoList todo = new TodoList();

            Assert.Throws<KeyNotFoundException>(() => todo.setTaskStatus("invalid", false));
        }
    }
}