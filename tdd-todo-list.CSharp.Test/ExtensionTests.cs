using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoList _todoList;
        public ExtensionTests()
        {
            _todoList = new TodoList();
        }

        [SetUp]
        public void SetUp()
        {
            _todoList =
            [
                new ToDoTask("A task", Status.Incomplete),
                new ToDoTask("B task", Status.Incomplete),
                new ToDoTask("C task", Status.Complete),
            ];
        }

        [Test]
        public void GetTaskByIdTest()
        {
            var testTask = new ToDoTask("D task", Status.Incomplete);
            _todoList.Add(testTask);
            Assert.That(_todoList.GetById(testTask.Id), Is.EqualTo(testTask));
        }

        [Test]
        public void UpdateTaskNameByIdTest()
        {
            var testTask = new ToDoTask("E task", Status.Incomplete);
            _todoList.Add(testTask);
            _todoList.UpdateTask(testTask.Id, "F task");
            Assert.That(_todoList.GetById(testTask.Id).Name, Is.EqualTo("F task"));
        }

        [Test]
        public void UpdateTaskStatusByIdTest()
        {
            var testTask = new ToDoTask("X task", Status.Incomplete);
            _todoList.Add(testTask);
            _todoList.UpdateTask(testTask.Id, Status.Complete);
            Assert.That(_todoList.GetById(testTask.Id).Status, Is.EqualTo(Status.Complete));
        }

        [Test]
        public void ViewTaskCreationDatesTest()
        {
            var testTask = new ToDoTask("Z task", Status.Complete);
            _todoList.Add(testTask);
            List<DateTime> dates = _todoList.ViewTaskCreationDates();
            Assert.That(dates.Contains(testTask.DateCreated));
        }
    }
}
