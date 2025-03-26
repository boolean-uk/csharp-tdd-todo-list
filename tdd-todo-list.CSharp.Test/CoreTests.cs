using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Diagnostics;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddTaskTest()
        {
            TodoList todoList = new TodoList();
            PTask task1 = new PTask("Purchase an apple");
            PTask task2 = new PTask("Purchase a banana");
            PTask task3 = new PTask("Purchase a pack of peanuts");
            List<PTask> taskList = new List<PTask>();


            Assert.IsTrue(todoList.AddTask(task1));
            Assert.IsTrue(todoList.AddTask(task2));

            Assert.IsTrue(todoList.AddTask(taskList));
            taskList.Add(task3);
            Assert.IsTrue(todoList.AddTask(taskList));
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList todoList = new TodoList();
            PTask task1 = new PTask("Purchase an apple");
            PTask task2 = new PTask("Purchase a banana");
            PTask task3 = new PTask("Purchase a pack of peanuts");
            List<PTask> taskList = new List<PTask>();

            Assert.IsTrue(todoList.AddTask(task1));

            Assert.IsTrue(todoList.RemoveTask(task1));
            Assert.IsFalse(todoList.RemoveTask(task2));

            todoList.AddTask(task3);
            Assert.IsFalse(todoList.RemoveTask(5));
            Assert.IsTrue(todoList.RemoveTask(0));

            todoList.AddTask(task3);
            taskList.Add(task3);
            Assert.IsTrue(todoList.RemoveTask(taskList));
            Assert.IsFalse(todoList.RemoveTask(taskList));
        }

        [Test]
        public void PrintTaskTest()
        {
            TodoList todoList = new TodoList();
            List<PTask> taskList = new List<PTask>();
            taskList.Add(new PTask("Purchase an apple"));
            taskList.Add(new PTask("Purchase a banana"));
            taskList.Add(new PTask("Purchase a pack of peanuts"));
            todoList.AddTask(taskList);

            todoList.PrintTask();
            todoList.PrintTask();

            Assert.Pass();
        }

        [Test]
        public void SetAndGetTaskState()
        {
            TodoList todoList = new TodoList();
            List<PTask> taskList = new List<PTask>();
            taskList.Add(new PTask("Purchase an apple"));
            taskList.Add(new PTask("Purchase a banana", false));
            taskList.Add(new PTask("Purchase a pack of peanuts", true));
            todoList.AddTask(taskList);
            PTask task4 = new PTask("Gather herbs", true);
            todoList.AddTask(task4);

            Assert.IsTrue(todoList.GetTaskState(task4));
            todoList.SetTaskState(task4, false);
            Assert.IsFalse(todoList.GetTaskState(task4));


            Assert.IsFalse(todoList.GetTaskState(0));
            todoList.SetTaskState(0, true);
            Assert.IsTrue(todoList.GetTaskState(0));

            Assert.IsTrue(todoList.GetTaskState(2));
        }

        [Test]
        public void SetAndGetTasksState()
        {
            TodoList todoList = new TodoList();
            List<PTask> taskList = new List<PTask>();
            taskList.Add(new PTask("Purchase an apple"));
            taskList.Add(new PTask("Purchase a banana", false));
            taskList.Add(new PTask("Purchase a pack of peanuts", true));
            todoList.AddTask(taskList);

            List<bool> tasks = todoList.GetTaskState(taskList);
            List<bool> targetResult  = new List<bool>();
            targetResult.Add(false);
            targetResult.Add(false);
            targetResult.Add(true);

            Assert.AreEqual(tasks, targetResult);
        }
    }
}