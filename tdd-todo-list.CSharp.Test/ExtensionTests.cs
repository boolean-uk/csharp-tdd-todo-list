using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    namespace tdd_todo_list.CSharp.Test
    {
        public class ExtensionTests
        {
            // I want to be able to get a task by a unique ID.
            [Test]
            public void TestGetTaskById()
            {
                // Arrange
                var todoList = new ExtendedTodoList();
                todoList.AddTask("Task1");

                var firstTask = todoList.GetTaskById(todoList.tasks.First().Key);

                // Act
                var task = todoList.GetTaskById(firstTask.Id);

                // Assert
                Assert.IsNotNull(task);
                Assert.AreEqual("Task1", task.Name);
            }

            // I want to update the name of a task by providing its ID and a new name.
            [Test]
            public void TestUpdateTaskName()
            {
                // Arrange
                var todoList = new ExtendedTodoList();
                todoList.AddTask("Task1");

                var firstTask = todoList.GetTaskById(todoList.tasks.First().Key);

                // Act
                todoList.UpdateTaskName(firstTask.Id, "NewTask1");
                var task = todoList.GetTaskById(firstTask.Id);

                // Assert
                Assert.IsNotNull(task);
                Assert.AreEqual("NewTask1", task.Name);
            }

            // I want to be able to change the status of a task by providing its ID
            [Test]
            public void TestChangeTheStatus()
            {
                // Arrange
                var todoList = new ExtendedTodoList();
                todoList.AddTask("Task1");
                var firstTask = todoList.GetTaskById(todoList.tasks.First().Key);

                // Act
                todoList.ChangeTaskStatus(firstTask.Id, false);
                var task = todoList.GetTaskById(firstTask.Id);

                //Assert
                Assert.IsNotNull(task);
                Assert.IsFalse(task.IsComplete);
            }


            // I want to be able to see the date and time that I created each task.
            [Test]
            public void TestCreationTimeTask()
            {
                //Arrange
                var todoList = new ExtendedTodoList();
                todoList.AddTask("Task1");
                var firstTask = todoList.GetTaskById(todoList.tasks.First().Key);

                //Act
                var task = todoList.GetTaskById(todoList.tasks.First().Key);

                //Assert
                Assert.IsNotNull (task);
                Assert.AreEqual(DateTime.Now.Date, task.Created.Date);

            }
        }
    }

}
