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

        // NOTE: These exists in the CoreTests.cs as well. They're just copied here in case you have some automates check 

        [TestCase("My First Task")]
        public void addTaskThenRetrieve(string taskName) 
        {
            // Requirement: I want to be able to get a task by a unique ID.

            //Arrange
            TodoList core = new TodoList();
            int nrOfEntriesBeforeAdd = core.NrOfTasks;
            //Act
            int taskId = core.AddTask(taskName);
            TaskEntry? addedTask = core.GetTask(taskId);
            //Assert
            Assert.IsTrue(nrOfEntriesBeforeAdd == (core.NrOfTasks - 1));
            Assert.That(addedTask != null);
            Assert.That(taskName == addedTask?.Name);
        }

        [Test]
        public void taskList_editTaskname()
        {
            // Requirement: I want to update the name of a task by providing its ID and a new name.

            //Arrange
            TodoList core = new TodoList();
            string initName = "My initial task Name";
            string newName = "myNewName";
            int taskId = core.AddTask(initName);

            //act
            core.EditTaskName(taskId, newName);

            //assert
            TaskEntry? renamedTask = core.GetTask(taskId);
            if (renamedTask != null)
                Assert.AreEqual(renamedTask.Name, newName);
            else
                Assert.Fail();

        }
        [Test]
        public void taskList_addThenMarkAsCompleted()
        {
            // Requirement: I want to be able to change the status of a task by providing its ID.

            //Arrange
            TodoList core = new TodoList();
            int testTaskId = core.AddTask("my Test Task");
            //Act
            TaskEntry? task = core.GetTask(testTaskId);

            core.ToggleTaskCompletion(testTaskId); // Toggels to Complete
            task = core.GetTask(testTaskId);

            //Assert
            Assert.IsTrue(task?.Completed);
            Assert.IsNotNull(task);
        }
        [Test]
        public void taskList_addThenMarkAsCompletedThenMarkAsIncomplete()
        {
            // Requirement: I want to be able to change the status of a task by providing its ID.

            //Arrange
            TodoList core = new TodoList();
            int testTaskId = core.AddTask("my Test Task");
            //Act
            TaskEntry? task = core.GetTask(testTaskId);

            core.ToggleTaskCompletion(testTaskId); // Toggels to Complete
            core.ToggleTaskCompletion(testTaskId); // Toggles to Incomplete
            task = core.GetTask(testTaskId);

            //Assert
            Assert.IsFalse(task?.Completed);
            Assert.IsNotNull(task);
        }

        [Test]
        public void taskList_accesssCreationDateTime()
        {
            // Requirement: I want to be able to see the date and time that I created each task.

            //Arrange
            TodoList core = new TodoList();
            var timeBefore = DateTime.Now;
            int testTaskId = core.AddTask("my Test Task");
            var timeAfter = DateTime.Now;
            TaskEntry? task = core.GetTask(testTaskId);
            //Act


            var accessedCreationDate = task?.CreationDate;

            //Assert
            Assert.IsNotNull(task);
            Assert.IsInstanceOf(typeof(DateTime), accessedCreationDate);
            Assert.Less(timeBefore, accessedCreationDate);
            Assert.Greater(timeAfter, accessedCreationDate);
        }

    }
}
