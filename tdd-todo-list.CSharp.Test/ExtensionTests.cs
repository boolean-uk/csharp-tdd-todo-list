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
        //User story 1 and 3
        /* This test case verifies that the task status can be changed by providing its ID,*/
        [Test]
        public void GetTaskById_ShouldReturnTaskWithGivenId()
        {
            // Arrange
            ToDoListExtension todoList = new ToDoListExtension();
            ToDoTask task = new ToDoTask(1, "study", false);

            // Act
            todoList.AddTask(task);
            int taskId = 1; // assuming it's the ID of the task "Study" in the list
            bool initialStatus = todoList.GetTaskById(taskId).IsComplete;


            bool result = todoList.ChangeTaskStatus(taskId);
            bool updatedStatus = todoList.GetTaskById(taskId).IsComplete;

            // Assert
            Assert.AreNotEqual(initialStatus, updatedStatus);
            Assert.AreEqual(updatedStatus, result);
        }

        //User story 2
        /*The test ensures that the task name can be successfully updated when the UpdateTaskName method is called with the task ID and a new name.*/
        [Test]
        public void UpdateTaskName_ShouldChangeTaskName()
        {
            // Arrange
            ToDoListExtension todoList = new ToDoListExtension();
            ToDoTask task = new ToDoTask(1, "Dance class", false);

            // Act
            todoList.AddTask(task);
            int taskId = 1; // assuming it's the ID of the task "Study" in the list
            string newName = "read";

            // Act
            bool result = todoList.UpdateTaskName(taskId, newName);
            string updatedName = todoList.GetTaskById(taskId).Name;

            // Assert
            Assert.IsTrue(result);
            Assert.AreEqual(newName, updatedName);
        }


        // user story 4

        [Test]
        public void GetTaskById_ShouldReturnTaskWithGivenIdAndCreationDateTime()
        {
            // Arrange
            ToDoListExtension todoList = new ToDoListExtension();
            ToDoTask task = new ToDoTask(1, "study", false);

            // Act
            todoList.AddTask(task);
            int taskId = 1;
            ToDoTask retrievedTask = todoList.GetTaskById(taskId);
            DateTime dt = DateTime.Now;

            // Assert
            Assert.NotNull(retrievedTask);
            Assert.AreEqual(task.Name, retrievedTask.Name);
            Assert.AreEqual(task.dateTime.Minute, dt.Minute);
            Assert.AreEqual(task.dateTime.Hour, dt.Hour);
            Assert.AreEqual(task.dateTime.Date, dt.Date);
        }
    }
}
