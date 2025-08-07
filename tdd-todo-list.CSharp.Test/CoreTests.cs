using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        [Test]
        public void AddTasks()
        {
            // Arrange
            TodoList list = new TodoList();

            // Act
            list.AddTask("Buy groceries");

            // Assert
            List<TaskItem> tasks = list.GetAllTasks();
            Assert.That(tasks.Count, Is.EqualTo(1));
            Assert.That(tasks[0].GetDescription(), Is.EqualTo("Buy groceries"));
            Assert.That(tasks[0].GetStatus(), Is.False); 
        }

        [Test]
        public void SeeAllTasks()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Walk the dog");

            // Act
            List<TaskItem> tasks = list.GetAllTasks();

            // Assert
            Assert.That(tasks.Any(t => t.GetDescription() == "Buy groceries"));
            Assert.That(tasks.Any(t => t.GetDescription() == "Walk the dog"));
        }

        [Test]
        public void ChangeStatus()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries");

            // Act
            list.ChangeStatus("Buy groceries");

            // Assert
            TaskItem task = list.GetAllTasks().First(t => t.GetDescription() == "Buy groceries");
            Assert.That(task.GetStatus(), Is.True); 
        }

        [Test]
        public void GetOnlyCompletedTasks()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Walk the dog");
            list.ChangeStatus("Walk the dog");

            // Act
            List<TaskItem> result = list.GetOnlyCompletedTasks();

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].GetDescription(), Is.EqualTo("Walk the dog"));
        }

        [Test]
        public void GetOnlyIncompleteTasks()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");
            list.AddTask("Walk the dog");
            list.ChangeStatus("Buy groceries"); 

            // Act
            List<TaskItem> result = list.GetOnlyIncompleteTasks();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Any(t => t.GetDescription() == "Clean room"));
            Assert.That(result.Any(t => t.GetDescription() == "Walk the dog"));
            Assert.That(result.Any(t => t.GetDescription() == "Buy groceries"), Is.False);
        }

        [Test]
        public void SearchForTask()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries");

            // Act
            string result = list.SearchForTask("Clean room");

            // Assert
            Assert.That(result, Is.EqualTo("Task not found"));
        }

        [Test]
        public void GetTasksSortedAscending()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Walk the dog");
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");

            // Act
            List<TaskItem> sorted = list.GetTasksSortedAscending();

            // Assert
            Assert.That(sorted[0].GetDescription(), Is.EqualTo("Buy groceries"));
            Assert.That(sorted[1].GetDescription(), Is.EqualTo("Clean room"));
            Assert.That(sorted[2].GetDescription(), Is.EqualTo("Walk the dog"));
        }

        [Test]
        public void GetTasksByPriority()
        {
            // Arrange
            TodoList list = new TodoList();
            list.AddTask("Buy groceries", 1); 
            list.AddTask("Clean room", 2);    
            list.AddTask("Walk the dog", 1); 

            // Act
            List<TaskItem> highPriority = list.GetTasksByPriority(1);

            // Assert
            Assert.That(highPriority.Count, Is.EqualTo(2));
            Assert.That(highPriority.Any(t => t.GetDescription() == "Buy groceries"));
            Assert.That(highPriority.Any(t => t.GetDescription() == "Walk the dog"));
        }
    }
}
