﻿using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("Feed Pet")]
        public void AddTaskTest(string task)
        {
            //arrange
            TodoList tasks = new TodoList();
            bool expectedSuccess = true;
            bool expectedFailure = false;

            //act
            bool resultInitialAdd = tasks.Add(task);
            bool resultDuplicateAdd = tasks.Add(task);

            //assert
            Assert.That(resultInitialAdd, Is.EqualTo(expectedSuccess));
            Assert.That(resultDuplicateAdd, Is.EqualTo(expectedFailure));
        }

        [TestCase("Feed Pet", "Go Shopping", "Eat Dinner")]
        public void ListAllTasksTest(string task1, string task2, string task3)
        {
            //arrange
            TodoList tasks = new TodoList();
            string expectedEmptyString = string.Empty;

            //act
            string result = tasks.List();

            //assert
            Assert.That(result, Is.EqualTo(expectedEmptyString));

            //arrange
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            string expectedString = "Feed Pet | Incomplete\nGo Shopping | Incomplete\nEat Dinner | Incomplete\n";

            //act
            result = tasks.List();

            //assert
            Assert.That(result , Is.EqualTo(expectedString));
        }

        [TestCase("Feed Pet")]
        public void ChangeStatusTest(string task)
        {
            //arrange
            TodoList tasks = new TodoList();
            bool expectedFailure = false;

            //act
            bool result = tasks.ChangeStatus(task, true);

            //assert
            Assert.That(result, Is.EqualTo(expectedFailure));

            //arrange
            bool expectedSuccess = true;
            tasks.Add(task);

            //act
            result = tasks.ChangeStatus(task, true);

            //assert
            Assert.That(result, Is.EqualTo(expectedSuccess));
        }

        [TestCase("Feed Pet", "Go Shopping", "Eat Dinner")]
        public void ListCompleteTasksTest(string task1, string task2, string task3)
        {
            //arrange
            TodoList tasks = new TodoList();
            tasks.Add(task1);
            tasks.Add(task2);
            tasks.Add(task3);
            string expectedEmptyString = string.Empty;

            //act
            string result = tasks.ListCompleteTasks();

            //assert
            Assert.That(result, Is.EqualTo(expectedEmptyString));

            //arrange
            tasks.ChangeStatus(task1, true);
            tasks.ChangeStatus(task3, true);
            string expectedString = "Feed Pet | Complete\nEat Dinner | Complete\n";

            //act
            result = tasks.ListCompleteTasks();

            //assert
            Assert.That(result, Is.EqualTo(expectedString));
        }
    }
}