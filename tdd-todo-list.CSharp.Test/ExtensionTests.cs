﻿using tdd_todo_list.CSharp.Main;
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
        [Test]
        public void FindTaskByIDTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            int taskID = toDo.AddTask("complete extension");

            TaskItem taskItem = toDo.FindTask(taskID);

            Assert.That(taskItem.Description.Equals("complete extension"));
        }

        [Test]
        public void UpdateTaskTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            int taskID = toDo.AddTask("complete extension");

            toDo.UpdateTask(taskID, "complete extension with very good professional code");

            Assert.That(toDo.FindTask(taskID).Description.Equals("complete extension with very good professional code"));
        }

        [Test]
        public void ChangeStatusTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            int taskID = toDo.AddTask("complete extension");

            toDo.ChangeStatus(taskID);

            Assert.That(toDo.FindTask(taskID).IsCompleted);
        }

        [Test]
        public void TimeAndDateTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            int taskID = toDo.AddTask("complete extension");
            string dateAndTime = DateTime.Now.ToString("dddd MMM yy, HH:mm");

            string taskCreated = toDo.TaskTimeAndDate(taskID);

            Assert.That(dateAndTime.Equals(taskCreated));
        }

        [Test]
        public void SortedAcsendingTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            toDo.AddTask("complete challenge");
            toDo.AddTask("make apple jam");
            toDo.AddTask("dig up treasure");
            List<string> expected = new List<string>() { "complete challenge", "dig up treasure", "make apple jam" };

            List<TaskItem> result = toDo.GetList(sorted: 'a');
            List<string> stringResult = result.Select(x => x.Description).ToList();

            Assert.That(stringResult.SequenceEqual(expected));
        }

        [Test]
        public void SortedDecsendingTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            toDo.AddTask("complete challenge");
            toDo.AddTask("make apple jam");
            toDo.AddTask("dig up treasure");
            List<string> expected = new List<string>() { "make apple jam", "dig up treasure", "complete challenge" };

            List<TaskItem> result = toDo.GetList(sorted: 'd');
            List<string> stringResult = result.Select(x => x.Description).ToList();
            

            Assert.That(stringResult.SequenceEqual(expected));
        }
    }
}
