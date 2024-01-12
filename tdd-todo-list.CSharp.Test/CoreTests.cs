﻿using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private TodoList _core;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        [SetUp]
        public void Setup() 
        {
            TodoList _core = new TodoList();
        }

        
        [Test]
        [TestCase("This should be on the todolist!")]
        [TestCase("Short")]
        [TestCase("THIS IS ALL CAPS, I AM SHOUTING RIGHT NOW.")]
        [TestCase("Hello World")]
        [TestCase("Hello, World")]
        public void AddTaskToList(string task)
        {
            // Arrange

            // Act
            bool res = _core.Add(task);

            // Assert
            Assert.That(res, Is.EqualTo(true));
        }

        [Test]
        public void RetrieveAllTasks()
        {
            // Arrange
            string string1 = "Hello world";
            string string2 = "Goodbye world";
            string string3 = "What to write there?";
            _core.Add(string1);
            _core.Add(string2);
            _core.Add(string3);

            // Act
            Dictionary<string, bool> res = _core.ListTasks();
            string[] res2 = res.Keys.ToArray();
            bool[] res3 = res.Values.ToArray();

            // Assert
            Assert.That(string1, Is.SubsetOf(res2));
            Assert.That(string2, Is.SubsetOf(res2));
            Assert.That(string3, Is.SubsetOf(res2));

            Assert.That(res3[0], Is.EqualTo(true));
            Assert.That(res3[1], Is.EqualTo(true));
            Assert.That(res3[2], Is.EqualTo(true));
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void SetTaskStatus(bool status) 
        {
            // Arrange
            string todoString = "Hello, this is a string";
            _core.Add(todoString);

            // Act
            bool res = _core.SetTaskStatus(0, status); // Should return true
            bool res2 = _core.SetTaskStatus(999, status); // Should return false

            // Assert
            Assert.That(res, Is.EqualTo(true));
            Assert.That(res2, Is.EqualTo(false));

        }

        [Test]
        public void RetrieveCorrectStatusLists() 
        {
            // Arrange
            string todoString = "This task is complete";
            string todoString2 = "This task is also complete";

            string todoString3 = "This task is not complete";
            string todoString4 = "This task is also not complete";

            _core.Add(todoString);
            _core.Add(todoString2);
            _core.Add(todoString3);
            _core.Add(todoString4);

            _core.SetTaskStatus(0, true);
            _core.SetTaskStatus(1, true);

            // Act
            Dictionary<string, bool> complete = _core.GetCompleteTasks();
            Dictionary<string, bool> incomplete = _core.GetIncompleteTasks();

            // Assert
            Assert.That(complete.All(t => t.Value == true));
            Assert.That(incomplete.All(t => t.Value == false));
        }

        [Test]
        public void FindTask() 
        {
            // Arrange
            string task1 = "What?";
            string task2 = "Why?";
            string task3 = "Find this";
            string task4 = "How?";
            string notAdded = "Not there";
            _core.Add(task1);
            _core.Add(task2);
            _core.Add(task3);
            _core.Add(task4);

            // Act
            int index1 = 2;
            string res1 = _core.FindTask(task3, out index1);

            int index2 = 0;
            string res2 = _core.FindTask(notAdded, out index2);

            // Assert
            Assert.That(task3, Is.EqualTo(res1));
            Assert.That(2, Is.EqualTo(index1));

            Assert.That(notAdded, Is.EqualTo(res2));
            Assert.That(0, Is.EqualTo(index2));

        }

        [Test]
        public void RemoveTask() 
        {
            // Arrange
            string string1 = "This should remain";
            string string2 = "This should be removed";
            string string3 = "Dont mind this string";
            _core.Add(string1);
            _core.Add(string2);
            _core.Add(string3);


            // Act
            bool res1 = _core.RemoveTask(string2);
            bool res2 = _core.RemoveTask("This string does not exist");

            // Assert
            Assert.That(res1, Is.EqualTo(true));
            Assert.That(res2, Is.EqualTo(false));

        }
    }
}