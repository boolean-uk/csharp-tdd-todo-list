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
        private TodoListExtension _extension;
        private string[] taskIDs;
        private string[] tasks;
        DateTime time;

        public ExtensionTests()
        {
            _extension = new TodoListExtension();
            time = new DateTime();
            taskIDs = new string[] { };
            tasks = new string[] { };
        }

        [SetUp]
        public void SetUp()
        {
            _extension = new TodoListExtension();

            string task1 = "Hello, this is a task";
            string ID1;

            string task2 = "Some other task";
            string ID2;

            string task3 = "Another task";
            string ID3;

            string task4 = "Help, im stuck in a Dictionary";
            string ID4;

            string task5 = "How many more do I need?";
            string ID5;

            _extension.Add(task1, out ID1);
            _extension.Add(task2, out ID2);
            _extension.Add(task3, out ID3);
            _extension.Add(task4, out ID4);
            _extension.Add(task5, out ID5);

            tasks = new string[] { task1, task2, task3, task4, task5 };
            taskIDs = new string[] { ID1, ID2, ID3, ID4, ID5 };

        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void getTaskByID(int index)
        {
            // Arrange
            string ID = taskIDs[index];
            string task = tasks[index];

            // Act
            ToDoItem res = _extension.RetrieveTask(ID);

            // Assert
            Assert.That(task, Is.EqualTo(res.Name));
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void changeTaskName(int IDindex, string newName)
        {
            // Arrange
            string ID = taskIDs[IDindex];
            string oldName = _extension.RetrieveTask(ID).Name;

            // Act
            bool res = _extension.UpdateTaskName(ID, newName);
            string updatedName = _extension.RetrieveTask(ID).Name;

            // Assert
            Assert.That(res, Is.EqualTo(true));
            Assert.That(oldName, Is.Not.EqualTo(updatedName));
            Assert.That(newName, Is.EqualTo(updatedName));
        }

        [Test]
        public void changeTaskID()
        {
            // Arrange
            string ID1 = taskIDs[0];
            string ID2 = taskIDs[3];
            string ID3 = "NotAValidID";

            // Act
            bool res1 = _extension.ChangeTaskStatus(ID1);
            bool res2 = _extension.ChangeTaskStatus(ID2);
            bool res3 = _extension.ChangeTaskStatus(ID3);

            // Assert
            Assert.That(res1, Is.True);
            Assert.That(res2, Is.True);
            Assert.That(res3, Is.False);

        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void retrieveDateTime(int index) 
        {
            // Arrange
            string ID = taskIDs[index];

            // Act
            string res = _extension.RetrieveTask(ID).RetrieveDateTime();
            int resYear = int.Parse(res.Substring(0, 4));
            int resMonth = int.Parse(res.Substring(5, 2));
            int resDay = int.Parse(res.Substring(8, 2));

            int resHour = int.Parse(res.Substring(11, 2));
            int resMinute = int.Parse(res.Substring(14, 2));

            // Assert
            Assert.That(res, Is.TypeOf<string>());
            Assert.That(time.Year, Is.EqualTo(resYear));
            Assert.That(time.Month, Is.EqualTo(resMonth));
            Assert.That(time.Day, Is.EqualTo(resDay));
            // Adding optional +1 for hour/minute incase test is ran right around a change
            Assert.That(time.Hour, Is.EqualTo(resHour).Or.EqualTo(resHour + 1));
            Assert.That(time.Minute, Is.EqualTo(resMinute).Or.EqualTo(resMinute + 1));
        }

        [Test]
        public void retrieveTaskDates() 
        {
            
        }
    }
}
