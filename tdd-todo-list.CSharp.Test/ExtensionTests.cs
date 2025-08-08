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
            var taskContent = "aaa";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var taskContent2 = "bbb";
            var task2 = new TodoTask(1, taskContent2);
            todoList.AddTask(task2);

            var taskContent3 = "ccc";
            var task3 = new TodoTask(2, taskContent3);
            todoList.AddTask(task3);

            int idOfFirstTask = 0;

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TaskContent, Is.EqualTo(taskContent));
        }

        [Test]
        public void UpdateTaskContentByIdTest()
        {
            TodoList todoList = new TodoList();
            var taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

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

            var taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            int idOfFirstTask = 0;

            todoList.CompleteTaskById(idOfFirstTask);

            var task = todoList.GetTaskById(idOfFirstTask);

            bool expectedCompletionStatus = true;

            Assert.That(task.IsCompleted, Is.EqualTo(expectedCompletionStatus));
        }

        [Test]
        public void TaskCreationTimeTest()
        {
            TodoList todoList = new TodoList();

            var taskContent = "do the dishes";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            int idOfFirstTask = 0;

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TimeCreated, Is.Not.EqualTo(DateTime.MinValue));
        }

        [Test]
        public void TaskCompletionTimeTest()
        {
            TodoList todoList = new TodoList();

            var taskContent = "aaa";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            int idOfFirstTask = 0;

            todoList.CompleteTaskById(idOfFirstTask);

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.TimeCompleted, Is.Not.EqualTo(DateTime.MinValue));
        }

        [Test]
        public void GetTaskWithMaximalCompletionTimeTest()
        {
            TodoList todoList = new TodoList();

            var taskContent = "aaa";
            var task1 = new TodoTask(0, taskContent);
            todoList.AddTask(task1);

            var taskContent2 = "bbb";
            var task2 = new TodoTask(1, taskContent2);
            todoList.AddTask(task2);

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;

            todoList.CompleteTaskById(idOfSecondTask);
            todoList.CompleteTaskById(idOfFirstTask);

            var task = todoList.GetTaskLongestToComplete();

            Assert.That(task.Id, Is.EqualTo(idOfFirstTask));
        }

        [Test]
        public void GetTaskWithMinimumCompletionTimeTest()
        {
            TodoList todoList = new TodoList();

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;
            int idOfThirdTask = 2;

            var task1 = new MockTodoTask(
                id: idOfFirstTask,
                taskContent: "ccc",
                isCompleted: true,
                priority: TaskPriorityEnum.Medium,
                timeCompleted: DateTime.Parse("Jan 5, 2009"),
                timeCreated: DateTime.Parse("Jan 1, 2009"),
                timeToComplete: TimeSpan.MaxValue,
                category: TaskCategoryEnum.Study
            );
            todoList.AddTask(task1);

            var task2 = new MockTodoTask(
                id: idOfSecondTask,
                taskContent: "ccc",
                isCompleted: true,
                priority: TaskPriorityEnum.Medium,
                timeCompleted: DateTime.Parse("Jan 5, 2009"),
                timeCreated: DateTime.Parse("Jan 1, 2009"),
                timeToComplete: TimeSpan.FromSeconds(1),
                category: TaskCategoryEnum.Study
            );
            todoList.AddTask(task2);

            var task3 = new MockTodoTask(
                id: idOfThirdTask,
                taskContent: "ccc",
                isCompleted: true,
                priority: TaskPriorityEnum.Medium,
                timeCompleted: DateTime.Parse("Jan 5, 2009"),
                timeCreated: DateTime.Parse("Jan 1, 2009"),
                timeToComplete: TimeSpan.MaxValue,
                category: TaskCategoryEnum.Study
            );
            todoList.AddTask(task3);

            var task4 = new MockTodoTask(
                id: idOfThirdTask,
                taskContent: "ccc",
                isCompleted: false,
                priority: TaskPriorityEnum.Medium,
                timeCompleted: DateTime.Parse("Jan 5, 2009"),
                timeCreated: DateTime.Parse("Jan 1, 2009"),
                timeToComplete: TimeSpan.MinValue,
                category: TaskCategoryEnum.Study
            );
            todoList.AddTask(task4);

            var task = todoList.GetTaskShortestToComplete();

            Assert.That(task.Id, Is.EqualTo(idOfSecondTask));
        }

        [Test]
        public void GetTaskWithGivenCompletionTimeTest()
        {
            TodoList todoList = new TodoList();

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;
            int idOfThirdTask = 2;

            var taskContent = "aaa";
            var task1 = new TodoTask(idOfFirstTask, taskContent);
            todoList.AddTask(task1);

            var taskContent2 = "bbb";
            var task2 = new TodoTask(idOfSecondTask, taskContent2);
            todoList.AddTask(task2);

            var task3 = new MockTodoTask(
                id: idOfThirdTask,
                taskContent: "ccc",
                isCompleted: true,
                priority: TaskPriorityEnum.Medium,
                timeCompleted: DateTime.Parse("Jan 5, 2009"),
                timeCreated: DateTime.Parse("Jan 1, 2009"),
                timeToComplete: TimeSpan.MaxValue,
                category: TaskCategoryEnum.Study
            );
            todoList.AddTask(task3);

            todoList.CompleteTaskById(idOfSecondTask);
            todoList.CompleteTaskById(idOfFirstTask);

            int thresholdSeconds = 10;
            int expectedTasksNumber = 1;
            var tasks = todoList.GetTasksWhichTookLongerToCompleteThan(thresholdSeconds);

            Assert.That(tasks.Count, Is.EqualTo(expectedTasksNumber));
            Assert.That(tasks.FirstOrDefault().Id, Is.EqualTo(idOfThirdTask));
        }

        [Test]
        public void AssignCategoryToTaskTest()
        {
            TodoList todoList = new TodoList();

            int idOfFirstTask = 0;

            var taskContent = "aaa";
            var task1 = new TodoTask(idOfFirstTask, taskContent);
            todoList.AddTask(task1);

            todoList.AssignCategoryToTaskById(idOfFirstTask, TaskCategoryEnum.Admin);

            var task = todoList.GetTaskById(idOfFirstTask);

            Assert.That(task.Category, Is.EqualTo(TaskCategoryEnum.Admin));
        }

        [Test]
        public void GetTasksByCategoryTest()
        {
            TodoList todoList = new TodoList();

            int idOfFirstTask = 0;
            int idOfSecondTask = 1;
            int idOfThirdTask = 2;
            int idOfFourthTask = 3;

            var task1 = new TodoTask(idOfFirstTask, "aaa");
            todoList.AddTask(task1);

            var task2 = new TodoTask(idOfSecondTask, "bbb");
            todoList.AddTask(task2);

            var task3 = new TodoTask(idOfThirdTask, "ccc");
            todoList.AddTask(task3);

            var task4 = new TodoTask(idOfFourthTask, "ddd");
            todoList.AddTask(task4);

            todoList.AssignCategoryToTaskById(idOfSecondTask, TaskCategoryEnum.Admin);
            todoList.AssignCategoryToTaskById(idOfThirdTask, TaskCategoryEnum.Admin);

            var tasks = todoList.GetTasksByCategory(TaskCategoryEnum.Admin);

            int expectedTasks = 2;

            Assert.That(tasks.Count(), Is.EqualTo(expectedTasks));
            Assert.That(tasks.FirstOrDefault().Category, Is.EqualTo(TaskCategoryEnum.Admin));
        }
    }
}
