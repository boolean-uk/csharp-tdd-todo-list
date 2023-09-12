﻿using NUnit.Framework;
using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private string[] tasks = {"write code", "git commit", "git push", "create a pull request"};

        private TodoListExtension arrange()
        {
            TodoListExtension todoList = new TodoListExtension();

            for (int i = 0; i < tasks.Length; ++i)
            {
                todoList.Add(new TaskItem(i, tasks[i], false));
            }

            return todoList;
        }

        [Test]
        public void GetTaskWithExistingIdTest()
        {
            TodoListExtension todoList = arrange();

            int index = 0;
            TaskItem task = todoList.GetTask(index);

            Assert.IsTrue(task.Name == tasks[index]);
        }
    }
}
