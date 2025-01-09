using NUnit.Framework;
using NUnit.Framework.Interfaces;
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
            TodoTaskExtension todoTask = new TodoTaskExtension("a task");

            todo.addTaskByTask(todoTask);
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(1));

            todo.removeTask(todoTask.taskId);
            Assert.That(todo.todoTaskDict.Count, Is.EqualTo(0));
        }

        [TestCase("a task")]
        public void findTaskById(string name)
        {
            TodoListExtension todo = new TodoListExtension();
            TodoTaskExtension todoTask = new TodoTaskExtension("a task");

            todo.addTaskByTask(todoTask);

            var foundTask = todo.findTaskById(todoTask.taskId);

            Assert.That(todoTask.taskId, Is.EqualTo(foundTask.taskId));

        }

        [TestCase(true, "a task")]
        public void changeTaskStatus(bool isFinished, string taskName)
        {
            TodoListExtension todo = new TodoListExtension();
            TodoTaskExtension todoTask = new TodoTaskExtension("a task");

            todo.addTaskByTask(todoTask);

            todo.setTaskStatus(todoTask.taskId, isFinished);
            var changedTask = todo.findTaskById(todoTask.taskId);

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

            TodoTaskExtension todoTask = new TodoTaskExtension(t1);
            todo.addTaskByTask(todoTask);

            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(todoTask.taskId, true);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.OnlyComplete).Count, Is.EqualTo(1));
        }

        [TestCase("task1", "task2", "task3")]
        public void getAllIncompletedTasks(string t1, string t2, string t3)
        {
            TodoListExtension todo = new TodoListExtension();

            TodoTaskExtension todoTask = new TodoTaskExtension(t1);
            todo.addTaskByTask(todoTask);

            todo.addTask(t2);
            todo.addTask(t3);

            todo.setTaskStatus(todoTask.taskId, true);

            Assert.That(todo.getAllTasksSorted(TodoListExtension.SortCriteria.OnlyIncomplete).Count, Is.EqualTo(2));
        }

        [TestCase("a", "b", "c")]
        [TestCase("der", "ert", "fee")]
        [TestCase("agh", "gh", "i")]
        [TestCase("j", "k", "l")]
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

        [TestCase("a new task", "a task")]
        public void changeTaskName(string newTaskName, string taskName)
        {
            TodoListExtension todo = new TodoListExtension();
            TodoTaskExtension todoTask = new TodoTaskExtension("a task");

            todo.addTaskByTask(todoTask);

            todo.setTaskNameById(todoTask.taskId, newTaskName);
            var changedTask = todo.findTaskById(todoTask.taskId);

            Assert.That(changedTask.taskName, Is.Not.EqualTo(taskName));
        }

        [Test]
        public void testExceptionFindInvalidId()
        {
            TodoListExtension todo = new TodoListExtension();

            Assert.Throws<KeyNotFoundException>(() => todo.findTaskById(new Guid()));
        }

        [Test]
        public void testExceptionCouldNotRemove()
        {
            TodoListExtension todo = new TodoListExtension();

            Assert.Throws<KeyNotFoundException>(() => todo.removeTask(new Guid()));
        }

        [Test]
        public void testExceptionCouldNotChangeStatus()
        {
            TodoListExtension todo = new TodoListExtension();

            Assert.Throws<KeyNotFoundException>(() => todo.setTaskStatus(new Guid(), false));
        }
    }
}