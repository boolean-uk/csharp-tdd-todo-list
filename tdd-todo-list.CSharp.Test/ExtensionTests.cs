using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void GetTaskByIdTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            string taskContent3 = "do the dishes3";
            todoList.AddTask(taskContent3);

            int idOfFirstTask = 0;

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TaskContent, Is.EqualTo(taskContent));
        }

        [Test]
        public void UpdateTaskContentByIdTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            int idOfFirstTask = 0;
            string updatedTaskContent = "do not do the dishes";

            todoList.UpdateTaskNameById(idOfFirstTask, updatedTaskContent);

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TaskContent, Is.EqualTo(updatedTaskContent));
        }

        [Test]
        public void UpdateTaskStatusByIdTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            int idOfFirstTask = 0;

            todoList.UpdateTaskStatusById(idOfFirstTask);

            var task = todoList.GetTaskById(idOfFirstTask);

            bool expectedCompletionStatus = true;

            Assert.That(task.IsCompleted, Is.EqualTo(expectedCompletionStatus));
        }

        [Test]
        public void TaskCreationTimeTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            int idOfFirstTask = 0;

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TimeCreated, Is.Not.EqualTo(DateTime.MinValue));
        }

        [Test]
        public void TaskCompletionTimeTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            int idOfFirstTask = 0;

            todoList.UpdateTaskStatusById(idOfFirstTask);

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TimeCompleted, Is.Not.EqualTo(DateTime.MinValue));
        }

        [Test]
        public void GetTaskWithMaximalCompletionTimeTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;

            todoList.UpdateTaskStatusById(idOfSecondTask);
            todoList.UpdateTaskStatusById(idOfFirstTask);

            var task = todoList.GetTaskLongestToComplete();

            Assert.That(task.Id, Is.EqualTo(idOfFirstTask));
        }

        [Test]
        public void GetTaskWithMinimumCompletionTimeTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;

            Thread.Sleep(1000);
            todoList.UpdateTaskStatusById(idOfSecondTask);
            Thread.Sleep(1000);
            todoList.UpdateTaskStatusById(idOfFirstTask);

            var task = todoList.GetTaskShortestToComplete();

            Assert.That(task.Id, Is.EqualTo(idOfSecondTask));
        }

        [Test]
        public void GetTaskWithGivenCompletionTimeTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;

            todoList.UpdateTaskStatusById(idOfSecondTask);
            Thread.Sleep(1000);
            todoList.UpdateTaskStatusById(idOfFirstTask);

            int thresholdSeconds = 1;
            int expectedTasksNumber = 1;
            var tasks = todoList.GetTasksWhichTookLongerToCompleteThan(thresholdSeconds);

            Assert.That(tasks.Count, Is.EqualTo(expectedTasksNumber));
            Assert.That(tasks.FirstOrDefault().Id, Is.EqualTo(idOfFirstTask));
        }

        [Test]
        public void ChangeTaskPriorityTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;

            todoList.ChangeTaskPriorityById(idOfFirstTask, TaskPriorityEnum.High);

            TaskPriorityEnum expectedTaskPriorityValue = TaskPriorityEnum.High;

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.Priority, Is.EqualTo(expectedTaskPriorityValue));
        }

        [Test]
        public void GetTasksByPriorityTest()
        {
            TodoList todoList = new TodoList();
            string taskContent = "do the dishes";
            todoList.AddTask(taskContent);

            string taskContent2 = "do the dishes2";
            todoList.AddTask(taskContent2);

            string taskContent3 = "do the dishes3";
            todoList.AddTask(taskContent3);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;
            int idOfThirdTask = 2;

            todoList.ChangeTaskPriorityById(idOfFirstTask, TaskPriorityEnum.High);
            todoList.ChangeTaskPriorityById(idOfThirdTask, TaskPriorityEnum.High);

            TaskPriorityEnum expectedTaskPriorityValue = TaskPriorityEnum.High;
            int expectedTasks = 2;

            var tasks = todoList.GetAllTasksByPriority(TaskPriorityEnum.High);

            Assert.That(tasks.Count(), Is.EqualTo(expectedTasks));

            Assert.That(tasks.FirstOrDefault().Priority, Is.EqualTo(expectedTaskPriorityValue));
        }
    }
}
