﻿using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            TodoList todoList = new TodoList();
            
            todoList.AddTask("Hoover");

            Assert.IsTrue(todoList.Tasks.Count() == 1);
        }

        [Test]
        public void CheckStatusFalse()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");

            Assert.IsFalse(todoList.Tasks[0].IsComplete);
        }

        [Test]
        public void CheckStatusTrue()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;

            Assert.IsTrue(todoList.Tasks[0].IsComplete);
        }

        [Test]
        public void GetCompleteTasksCount()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            Assert.IsTrue(todoList.GetCompleteTasks().Count == 1);
        }

        [Test]
        public void GetCompleteTasksCorrectTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            List<TaskItem> completeTasks = todoList.GetCompleteTasks();


            Assert.IsTrue(completeTasks[0].Name == "Hoover");
        }

        [Test]
        public void GetIncompleteTasksCount()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.AddTask("Clean Kitchen");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            Assert.IsTrue(todoList.GetIncompleteTasks().Count == 2);
        }

        [Test]
        public void GetIncompleteTasksCorrectTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            List<TaskItem> incompleteTasks = todoList.GetIncompleteTasks();


            Assert.IsTrue(incompleteTasks[0].Name == "Run");
        }
    }
}