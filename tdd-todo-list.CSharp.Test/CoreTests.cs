using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void CreateTaskAndGetter()
        {
            // Setup and execute
            Main.Task t = new ("Feed the cat", false);

            // Verify
            StringAssert.Contains(t.description, "Feed the cat");
            Assert.IsFalse(t.completed);
        }
        [Test]
        public void ShouldSetTask()
        {
            Main.Task task = new("Feed the cat", false);
            // Setter
            task.completed = true;
            Assert.IsTrue(task.completed);
        }
        [Test]
        public void ShouldAddTaskToList() {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);

            todolist.addTaskToList(task);
            //Index might be wrong to use
            Assert.That(todolist.tasks != null && todolist.tasks[0].description == "Feed the cat");
        }
        [Test]
        public void ShouldRemoveTaskFromList()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            
            todolist.addTaskToList(task);
            todolist.removeTaskFromList(task);

            Assert.That(todolist.tasks.Count == 0);
        }
        [Test]
        public void ShouldReturnListWithCompletedTasks()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            Main.Task task2 = new("Feed the dog", true);

            todolist.addTaskToList(task);
            todolist.addTaskToList(task2);
            List<Main.Task> completed = todolist.completedTasks();

            Assert.AreEqual(1, completed.Count);
            // Check content in returned list
            Assert.That(completed.Contains(task2));
        }
        [Test]
        public void ShouldReturnListWithUncompletedTasks()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            Main.Task task2 = new("Feed the dog", true);
            Main.Task task3 = new("Feed the fish", false);

            todolist.addTaskToList(task);
            todolist.addTaskToList(task2);
            todolist.addTaskToList(task3);
            List<Main.Task> uncompleted = todolist.uncompletedTasks();
            
            Assert.AreEqual(2, uncompleted.Count);
            // Check content in returned list
            Assert.That(uncompleted.Contains(task));
        }
        [Test]
        public void ShouldReturnMessageWithTaskIfExist()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            todolist.addTaskToList(task);

            string response = todolist.search("Feed the cat");

            Assert.AreEqual(response, task.description);
        }
        [Test]
        public void ShouldReturnErrorIfTaskDoesNotExist()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            todolist.addTaskToList(task);

            string response = todolist.search("Feed the dog");

            Assert.AreEqual(response, "Task does not exist");
        }
        [Test]
        public void shouldReturnListInAscendingOrder()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the dog", false);
            Main.Task task2 = new("Feed the cat", false);
            todolist.addTaskToList(task);
            todolist.addTaskToList(task2);

            List<Main.Task> ascendingOrder = todolist.orderByAscending();

            Assert.AreEqual(ascendingOrder[0], task2);
        }
        [Test]
        public void shouldReturnListInDescendingOrder()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);
            Main.Task task2 = new("Feed the dog", false);
            Main.Task task3 = new("Feed the elephant", false);
            Main.Task task4 = new("Feed the fish", false);
            todolist.addTaskToList(task);
            todolist.addTaskToList(task2);
            todolist.addTaskToList(task3);
            todolist.addTaskToList(task4);

            List<Main.Task> ascendingOrder = todolist.orderByDescending();

            Assert.AreEqual(ascendingOrder[2], task2);
        }
        [Test]
        public void shouldChangeCompletedStatusFromCurrent()
        {
            TodoList todolist = new TodoList();
            Main.Task task = new("Feed the cat", false);

            todolist.changeCompleteStatus(task);

            Assert.IsTrue(task.completed);
        }
    }
}