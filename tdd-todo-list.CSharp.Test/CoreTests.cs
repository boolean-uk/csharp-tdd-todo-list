using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

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
        public void GetAndSetTaskStatusTest()
        {
            ToDoTask task = new("First Task", Status.Incomplete);
            Assert.That(task.Status, Is.EqualTo(Status.Incomplete));
            task.Status = Status.Complete;
            Assert.That(task.Status, Is.EqualTo(Status.Complete));
        }

        [Test]
        public void AddTaskToToDoListTest()
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            Assert.That(list.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            Assert.That(list.GetCompleteTasks().Any(t => t.Status == Status.Incomplete), Is.False);
        }

        [Test]
        public void GetIncompleteTasksTest()
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            Assert.That(list.GetIncompleteTasks().Any(t => t.Status == Status.Complete), Is.False);
        }

        [Test]
        public void SearchTaskByIdNoNullTest()
        {
            TodoList list = new();
            ToDoTask taskToFind = new ToDoTask("Find this task", Status.Incomplete);
            list.Add(taskToFind);
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            Assert.That(list.Search(taskToFind.Id), Is.EqualTo(taskToFind));
        }

        [Test]
        public void SearchTaskByIdWithNullTest()
        {
            TodoList list = new();
            ToDoTask taskToFind = new ToDoTask("Find this task", Status.Incomplete);
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            Assert.Throws<Exception>(() => list.Search(taskToFind.Id));
        }

        [Test]
        public void RemoveTaskByIdTest()
        {
            TodoList list = new();
            ToDoTask taskToRemove = new ToDoTask("Find this task", Status.Incomplete);
            list.Add(taskToRemove);
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            list.Remove(taskToRemove.Id);
            Assert.That(list.Count, Is.EqualTo(3));
        }

        [Test]
        public void RemoveTaskByIdThrowsExceptionTest()
        {
            TodoList list = new();
            ToDoTask taskToRemove = new ToDoTask("Find this task", Status.Incomplete);
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));

            Assert.Throws<Exception>(() => list.Remove(taskToRemove.Id));
        }

        [Test]
        public void RemoveTaskByIndexTest()
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            list.Remove(1);

            Assert.That(list.Count, Is.EqualTo(2));
        }

        [Test]
        public void ViewTasksAscendingTest()
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            List<ToDoTask> sortedList = list.View(Sorting.Ascending);
            Assert.That(sortedList[0].Name, Is.EqualTo("Another task"));
        }

        [Test]
        public void ViewTasksDescendingTest() 
        {
            TodoList list = new();
            list.Add(new ToDoTask("Some task", Status.Incomplete));
            list.Add(new ToDoTask("Another task", Status.Complete));
            list.Add(new ToDoTask("Last task", Status.Complete));
            List<ToDoTask> sortedList = list.View(Sorting.Descending);
            Assert.That(sortedList[0].Name, Is.EqualTo("Some task"));
        }
    }
}