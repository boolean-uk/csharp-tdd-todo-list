﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Core;
using Extension;
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

        [TestCase(2)]
        [TestCase(50)]
        [TestCase(235252)]
        public void GetTaskSuccess(int id)
        {
            _extension.AddTask("Cooking", id, "15.08.2024 12:00");

            TaskItemExtension task = _extension.GetTask(id);

            Assert.IsTrue(task.Id == id);
        }

        [Test]
        public void GetTaskFail()
        {
            TaskItemExtension? task = _extension.GetTask(22414);

            Assert.IsTrue(task == null);
        }

        [TestCase("Clean")]
        [TestCase("Sweep")]
        public void UpdateTaskName(String newName)
        {
            _extension.AddTask("Sleep", 50, "15.08.2024 12:00");

            _extension.UpdateTaskName(50, newName);
            TaskItemExtension? task = _extension.GetTask(50);

            Assert.IsTrue(task.Name == newName);
        }

        [Test]
        public void UpdateTaskStatusToTrue()
        {
            _extension.AddTask("Sweep", 20, "15.08.2024 12:00");
            TaskItemExtension task = _extension.GetTask(20);

            _extension.UpdateTaskStatus(20); 

            Assert.IsTrue(task.IsComplete);
        }

        [Test]
        public void UpdateTaskStatusToFalse()
        {
            _extension.AddTask("Sweep", 20, "15.08.2024 12:00");
            TaskItemExtension task = _extension.GetTask(20);
            task.IsComplete = true;

            _extension.UpdateTaskStatus(20);

            Assert.IsFalse(task.IsComplete);
        }

        [TestCase("01.04.2050 17:00")]
        public void GetTaskDateTime(String dateTime)
        {
            _extension.AddTask("Sweep", 20, dateTime);
            TaskItemExtension task = _extension.GetTask(20);

            Assert.IsTrue(String.Equals(task.DateTime, dateTime));
        }


    }
}
