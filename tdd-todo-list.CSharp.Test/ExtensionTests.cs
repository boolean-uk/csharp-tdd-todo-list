using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Newtonsoft.Json.Bson;
using System.Security.Cryptography.X509Certificates;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoListExtensionTests
    {
        [Test]
        public void AddTask()
        {
            TodoListExtension todoList = new TodoListExtension();
            CustomTaskExtension task1 = new CustomTaskExtension("Cleaning", false);
            todoList.AddTask(1, task1);

            Assert.Contains(1, todoList.TaskDictionary.Keys);
            Assert.AreSame(task1, todoList.TaskDictionary[1]);
        }

        [Test]
        public void DisplayAllTasksExtension()
        {
            // Arrange
            TodoListExtension todoList = new TodoListExtension();
            CustomTaskExtension task1 = new CustomTaskExtension("Cleaning", false);
            CustomTaskExtension task2 = new CustomTaskExtension("Grocery Shopping", true);
            todoList.AddTask(1, task1);
            todoList.AddTask(2, task2);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.DisplayAllTasksExtension();

                
                string result = sw.ToString();

                // Assert
                StringAssert.Contains("Tasks:", result);
                StringAssert.Contains("ID: 1, Name: Cleaning, Status: Not Complete, Created At:", result);
                StringAssert.Contains("ID: 2, Name: Grocery Shopping, Status: Complete, Created At:", result);
            }
         

        }
        [Test]
        public void UpdateTaskNametest()
        {
            TodoListExtension todoList = new TodoListExtension();
            CustomTaskExtension task1 = new CustomTaskExtension("Clening", false);
            todoList.AddTask(1, task1);
            todoList.UpdateTaskName(1, "Cleaning");

            CustomTaskExtension updatedTask = todoList.GetTaskById(1);
            Assert.AreEqual("Cleaning", updatedTask.Name);
        }
        [Test]
        public void UpdateTaskStatusTest()
        {
            TodoListExtension todoList = new TodoListExtension();
            CustomTaskExtension task1 = new CustomTaskExtension("Cleaning", false);
            todoList.AddTask(1, task1);

            // Act
            todoList.UpdateTaskStatus(1, true);

            // Assert
            Assert.IsTrue(task1.IsComplete);

        }



    }
}
