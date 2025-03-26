// Inside ./tdd-todo-list.CSharp.Test/ExtensionTests.cs
using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void Task_GetId_ShouldReturnHashCode()
        {
            // Arrange
            tdd_todo_list.CSharp.Main.Task task = new tdd_todo_list.CSharp.Main.Task("Task 1", "Do something");

            // Act
            int taskId = task.GetId();

            // Assert
            Assert.AreEqual(task.GetHashCode(), taskId);
        }

        [Test]
        public void Task_UpdateName_ShouldChangeName()
        {
            // Arrange
            tdd_todo_list.CSharp.Main.Task task = new tdd_todo_list.CSharp.Main.Task("Task 2", "Learn something");

            // Act
            task.UpdateName("Updated Task");

            // Assert
            Assert.AreEqual("Updated Task", task.Title);
        }

        [Test]
        public void Task_ChangeStatus_ShouldChangeStatus()
        {
            // Arrange
            tdd_todo_list.CSharp.Main.Task task = new tdd_todo_list.CSharp.Main.Task("Task 3", "Implement something");

            // Act
            task.ChangeStatus(true);

            // Assert
            Console.WriteLine($"Task Status: {task.IsComplete}");
            Assert.True(task.IsComplete);
        }

        [Test]
        public void Task_GetCreationDateTime_ShouldReturnCurrentDateTime()
        {
            // Arrange
            tdd_todo_list.CSharp.Main.Task task = new tdd_todo_list.CSharp.Main.Task("Task 4", "Read a book");

            // Act
            DateTime creationDateTime = task.GetCreationDateTime();

            // Assert
            Console.WriteLine($"Task was created at this time and date: {creationDateTime}");
            Assert.That(creationDateTime, Is.EqualTo(DateTime.Now).Within(1).Seconds);
        }
    }
}
