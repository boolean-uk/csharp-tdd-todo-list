using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void GetTaskByIdReturnTaskIfExists()
        {
            // Arrange
            int taskId = 1;
            var task = new TodoListExtension(taskId, "Test Task", "Incomplete", DateTime.Now);

            // Act
            var result = _extension.GetTaskById(taskId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(taskId, task.id);
        }

        [Test]
        public void GetTaskByIdReturnNullIfTaskNotExist()
        {
            // Arrange
            int nonExistentId = 999;

            // Act
            var result = _extension.GetTaskById(nonExistentId);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void UpdateTaskNameReturnTrueIfTaskExists()
        {
            // Arrange
            int taskId = 1;
            string newName = "Updated Task Name";
            var task = new TodoListExtension(taskId, "Initial Task Name", "Incomplete", DateTime.Now);

            // Act
            bool isUpdated = _extension.UpdateTaskName(taskId, newName);
            var updatedTask = _extension.GetTaskById(taskId);

            // Assert
            Assert.IsTrue(isUpdated);
            Assert.AreEqual(newName, task.name);
        }

        [Test]
        public void UpdateTaskNameReturnFalseIfTaskNotExist()
        {
            // Arrange
            int nonExistentId = 999;
            string newName = "New Task Name";

            // Act
            bool isUpdated = _extension.UpdateTaskName(nonExistentId, newName);

            // Assert
            Assert.IsFalse(isUpdated);
        }

        [Test]
        public void UpdateTaskStatusReturnTrueIfTaskExists()
        {
            // Arrange
            int taskId = 1;
            string newStatus = "Complete";
            var task = new TodoListExtension(taskId, "Test Task", "Incomplete", DateTime.Now);

            // Act
            bool isUpdated = _extension.UpdateTaskStatus(taskId, newStatus);
            var updatedTask = _extension.GetTaskById(taskId);

            // Assert
            Assert.IsTrue(isUpdated);
            Assert.AreEqual(newStatus, task.status);
        }

        [Test]
        public void UpdateTaskStatusReturnFalseIfTaskNotExist()
        {
            // Arrange
            int nonExistentId = 999;
            string newStatus = "Complete";

            // Act
            bool isUpdated = _extension.UpdateTaskStatus(nonExistentId, newStatus);

            // Assert
            Assert.IsFalse(isUpdated);
        }

        [Test]
        public void GetTaskCreationReturnCreationDateIfTaskExists()
        {
            // Arrange
            int taskId = 1;
            DateTime creationDate = DateTime.Now;
            var task = new TodoListExtension(taskId, "Test Task", "Incomplete", creationDate);

            // Act
            DateTime? result = _extension.GetTaskCreationDateTime(taskId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(creationDate, result);
        }

        [Test]
        public void GetTaskCreationDateTimeReturnNullIfTaskNotExist()
        {
            // Arrange
            int nonExistentId = 999;

            // Act
            DateTime? result = _extension.GetTaskCreationDateTime(nonExistentId);

            // Assert
            Assert.IsNull(result);
        }
    }
}

