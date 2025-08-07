using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            TodoList todoList = new TodoList();
            string taskName = "Homework";

            todoList.AddTask(taskName);

            Assert.That(todoList.Tasks[0].Name, Is.EqualTo(taskName));
            Assert.That(todoList.Tasks[0].ID, Is.EqualTo(0));
            Assert.That(todoList.TaskCount, Is.EqualTo(1));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";

            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            Assert.That(todoList.Tasks.Count, Is.EqualTo(2));
        }

        [Test]
        public void ToggleCompleteTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            todoList.ToggleComplete(0);

            Assert.That(todoList.Tasks[0].IsCompleted, Is.True);
            Assert.That(todoList.Tasks[1].IsCompleted, Is.False);
        }

        [Test]
        public void GetCompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            string taskName3 = "Dishes";
            string taskName4 = "Run";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);
            todoList.AddTask(taskName3);
            todoList.AddTask(taskName4);

            todoList.ToggleComplete(0);
            todoList.ToggleComplete(3);

            List<Task> completeTaskList = todoList.GetCompleteTasks();

            Assert.That(completeTaskList.All(task => task.IsCompleted), Is.True);
            Assert.That(completeTaskList.Count == 2);
        }

        [Test]
        public void GetIncompleteTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            string taskName3 = "Dishes";
            string taskName4 = "Run";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);
            todoList.AddTask(taskName3);
            todoList.AddTask(taskName4);

            todoList.ToggleComplete(0);
            todoList.ToggleComplete(3);

            List<Task> incompleteTaskList = todoList.GetIncompleteTasks();

            Assert.That(incompleteTaskList.All(task => task.IsCompleted), Is.False);
            Assert.That(incompleteTaskList.Count == 2);
        }

        [Test]
        public void GetTaskByNameTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            string taskName3 = "Dishes";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);
            todoList.AddTask(taskName3);

            string nonExistingTaskName = "Run";

            Task? existingTask = todoList.GetTaskByName(taskName1);
            Task? nonExistingTask = todoList.GetTaskByName(nonExistingTaskName);

            Assert.That(existingTask.Name, Is.EqualTo(taskName1));
            Assert.That(nonExistingTask, Is.Null);
        }

        [Test]
        public void RemoveTaskName()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            string nonExistingTaskName = "Run";

            bool wasRemoved1 = todoList.RemoveTask(taskName1);
            bool wasRemoved2 = todoList.RemoveTask(nonExistingTaskName);

            Assert.That(wasRemoved1, Is.True);
            Assert.That(wasRemoved2, Is.False);

        }

    }
}