using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id = todoList.Add("oppvask");

            // Assert
            Assert.That(todoList.Tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();
            int id1 = todoList.Add("oppvask");
            int id2 = todoList.Add("oppvask2");

            List<TodoList.Task> allTasks = todoList.GetAll();

            Assert.That(allTasks.Count, Is.EqualTo(2));
        }

        [Test]
        public void ChangeStatus()
        {
            TodoList todoList = new TodoList();
            int id1 = todoList.Add("oppvask", false);
            bool result = todoList.ChangeStatus(id1);

            bool after_status = todoList.Tasks.First().Value.Complete;

            Assert.That(after_status, Is.True);
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList todoList = new TodoList();

            int id1 = todoList.Add("oppvask", true); // completed task
            int id2 = todoList.Add("oppvask2", false); // incomplete task

            List<TodoList.Task> completed_tasks = todoList.GetAll(complete: true);

            Assert.That(completed_tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetInCompleteTasksTest()
        {
            TodoList todoList = new TodoList();

            int id1 = todoList.Add("oppvask", true); // completed task
            int id2 = todoList.Add("oppvask2", false); // incomplete task

            List<TodoList.Task> incomplete_tasks = todoList.GetAll(incomplete: true);

            Assert.That(incomplete_tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void SearchTaskTest()
        {
            TodoList todoList = new TodoList();

            int id1 = todoList.Add("oppvask", true);
            TodoList.Task task = todoList.GetTask("oppvasken");

            Assert.That(task, Is.Null);
        }

        [Test]
        public void RemoveTaskTest()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id = todoList.Add("oppvask");
            todoList.Remove(id);

            // Assert
            Assert.That(todoList.Tasks.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetAscendingTasksTest()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id3 = todoList.Add("christoffer");
            int id = todoList.Add("alibaba");
            int id2 = todoList.Add("berit");

            List<TodoList.Task> tasks = todoList.GetSortedTasks(ascending: true);

            // Assert
            Assert.That(tasks[0].Name[0], Is.EqualTo('a'));
        }

        [Test]
        public void GetDescendingTasksTest()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id3 = todoList.Add("christoffer");
            int id = todoList.Add("alibaba");
            int id2 = todoList.Add("berit");

            List<TodoList.Task> tasks = todoList.GetSortedTasks(ascending: false);

            // Assert
            Assert.That(tasks[0].Name[0], Is.EqualTo('c'));
        }

        [Test]
        public void SetTaskPriorityTest()
        {
            TodoList todoList = new TodoList();

            int id = todoList.Add("oppvask");
            todoList.Tasks.First().Value.Priority = TodoList.Priority.High;

            Assert.That(todoList.Tasks.First().Value.Priority, Is.EqualTo(TodoList.Priority.High));
        }

        [Test]
        public void GetTasksByPriority()
        {
            TodoList todoList = new TodoList();

            int id = todoList.Add("ja", priority: TodoList.Priority.Medium);
            int id2 = todoList.Add("nei");
            int id3 = todoList.Add("hallo");

            List<TodoList.Task> tasks = todoList.GetTasksByPriority(priority: TodoList.Priority.Medium);

            Assert.That(tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void GetSortedPriorityTasks()
        {
            TodoList todoList = new TodoList();
            int id = todoList.Add("ja", priority: TodoList.Priority.Medium);
            int id3 = todoList.Add("yessir", priority: TodoList.Priority.High);
            int id2 = todoList.Add("nei", priority: TodoList.Priority.Low);

            Assert.That(todoList.TasksByPriority[0].Priority == TodoList.Priority.High);
        }
    }
}