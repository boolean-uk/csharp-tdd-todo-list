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
        public void GetTask(int id)
        {

            _extension.AddTask(String taskName, int id);

            TaskItemExtension task = _extension.GetTask(int id);
       

            Assert.IsTrue(task.Id == id);
        }

    }
}
