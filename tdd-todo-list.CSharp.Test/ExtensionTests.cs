using NUnit.Framework;
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
                todoList.Add(new TaskItem(i, tasks[i], false, DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")));
            }

            return todoList;
        }

        [Test]
        public void GetTaskWithExistingIdTest()
        {
            TodoListExtension todoList = arrange();

            int taskId = 0;
            TaskItem task = todoList.GetTask(taskId);

            Assert.IsTrue(task.Name == tasks[taskId]);
        }

        [Test]
        public void GetTaskWithNonExistingIdTest()
        {
            TodoListExtension todoList = arrange();
            Assert.IsNull(todoList.GetTask(46));
        }

        [Test]
        public void UpdateTaskNameWithExistingIdTest()
        {
            TodoListExtension todoList = arrange();

            string taskName = "drink coffee";

            int taskId = 0;
            Assert.IsTrue(todoList.UpdateTaskName(taskId, taskName));

            TaskItem task = todoList.GetTask(taskId);
            Assert.IsTrue(task.Name == taskName);
        }

        [Test]
        public void UpdateTaskNameWithNonExistingIdTest()
        {
            TodoListExtension todoList = arrange();
            string taskName = "drink coffee";
            int taskId = 63;

            Assert.IsFalse(todoList.UpdateTaskName(taskId, taskName));
        }

        [Test]
        public void ChangeTaskStatusWithExistingIdTest()
        {
            TodoListExtension todoList = arrange();
            int taskId = 0;

            Assert.IsTrue(todoList.ChangeTaskStatus(taskId, true));
            
            TaskItem task = todoList.GetTask(taskId);
            Assert.IsTrue(task.IsComplete);
        }

        [Test]
        public void ChangeTaskStatusWithNonExistingIdTest()
        {
            TodoListExtension todoList = arrange();
            int taskId = 20;

            Assert.IsFalse(todoList.ChangeTaskStatus(taskId, true));
        }

        [Test]
        public void GetTaskDatesTest()
        {
            TodoListExtension todoList = arrange();
            
            string result = todoList.GetTaskDates();
            // Console.WriteLine(result);

            Assert.IsTrue(result.Length > 0);
        }
    }
}
