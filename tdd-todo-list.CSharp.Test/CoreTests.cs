using NUnit.Framework;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        [Test]
        public void AddTask()
        {
            // Arrange
            var list = new TodoList();

            // Act
            list.AddTask("Buy groceries");

            // Assert
            var tasks = list.GetAllTasks();
            Assert.That(tasks.Count, Is.EqualTo(1));
            Assert.That(tasks[0].GetDescription(), Is.EqualTo("Buy groceries"));
        }

        [Test]
        public void SeeAllTasks()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Walk the dog");

            // Act
            var tasks = list.GetAllTasks();

            // Assert
            Assert.That(tasks.Any(t => t.GetDescription() == "Buy groceries"));
            Assert.That(tasks.Any(t => t.GetDescription() == "Walk the dog"));
        }

        [Test]
        public void ChangeStatus()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");

            // Act
            list.ChangeStatus("Buy groceries");

            // Assert
            var task = list.GetAllTasks().First();
            Assert.That(task.GetStatus(), Is.True);
        }

        [Test]
        public void OnlyCompletedTasks()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Walk the dog");
            list.ChangeStatus("Walk the dog");

            // Act
            var result = list.GetOnlyCompletedTasks();

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].GetDescription(), Is.EqualTo("Walk the dog"));
        }

        [Test]
        public void OnlyIncompleteTasks()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");
            list.AddTask("Walk the dog");
            list.ChangeStatus("Buy groceries");

            // Act
            var result = list.GetOnlyIncompleteTasks();

            // Assert
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result.Any(t => t.GetDescription() == "Clean room"));
            Assert.That(result.Any(t => t.GetDescription() == "Walk the dog"));
        }

        [Test]
        public void SearchNotFound()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");

            // Act
            var result = list.SearchForTask("Clean room");

            // Assert
            Assert.That(result, Is.EqualTo("Task not found"));
        }

        [Test]
        public void SearchFound()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");

            // Act
            var result = list.SearchForTask("Buy groceries");

            // Assert
            Assert.That(result, Is.EqualTo("Buy groceries"));
        }

        [Test]
        public void RemoveTask()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");

            // Act
            list.RemoveTask("Buy groceries");

            // Assert
            var tasks = list.GetAllTasks();
            Assert.That(tasks.Any(t => t.GetDescription() == "Buy groceries"), Is.False);
            Assert.That(tasks.Any(t => t.GetDescription() == "Clean room"), Is.True);
        }

        [Test]
        public void SortedAscending()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Walk the dog");
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");

            // Act
            var sorted = list.GetTasksSortedAscending();

            // Assert
            Assert.That(sorted.Select(t => t.GetDescription()),
                Is.EqualTo(new[] { "Buy groceries", "Clean room", "Walk the dog" }));
        }

        [Test]
        public void SortedDescending()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Walk the dog");
            list.AddTask("Buy groceries");
            list.AddTask("Clean room");

            // Act
            var sorted = list.GetTasksSortedDescending();

            // Assert
            Assert.That(sorted.Select(t => t.GetDescription()),
                Is.EqualTo(new[] { "Walk the dog", "Clean room", "Buy groceries" }));
        }

        [Test]
        public void GetTasksByPriority()
        {
            var list = new TodoList();
            list.AddTask("Buy groceries", Priority.High);
            list.AddTask("Clean room", Priority.Medium);
            list.AddTask("Walk the dog", Priority.High);
            list.AddTask("Do laundry", Priority.Medium);
            list.AddTask("Water plants", Priority.Low);

            var high = list.GetTasksByPriority(Priority.High);
            var medium = list.GetTasksByPriority(Priority.Medium);
            var low = list.GetTasksByPriority(Priority.Low);

            Assert.That(high.Select(t => t.GetDescription()),
                Is.EqualTo(new[] { "Buy groceries", "Walk the dog" }));

            Assert.That(medium.Select(t => t.GetDescription()),
                Is.EqualTo(new[] { "Clean room", "Do laundry" }));

            Assert.That(low.Select(t => t.GetDescription()),
                Is.EqualTo(new[] { "Water plants" }));
        }

        [Test]
        public void SortedByPriority()
        {
            // Arrange
            var list = new TodoList();
            list.AddTask("Clean room", Priority.Low);
            list.AddTask("Water plants", Priority.Medium);
            list.AddTask("Buy groceries", Priority.High);
            list.AddTask("Walk the dog", Priority.High);
            list.AddTask("Do laundry", Priority.Medium);

            // Act
            var sorted = list.GetAllTasksByPriority();

            // Assert
            Assert.That(sorted.Select(t => t.GetDescription()), Is.EqualTo(new[]
            {
                "Buy groceries", // High
                "Walk the dog",  // High
                "Water plants",  // Medium
                "Do laundry",    // Medium
                "Clean room"     // Low
            }));
        }
    }
}
