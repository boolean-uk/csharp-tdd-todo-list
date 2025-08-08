using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void GetTaskByIDTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            string taskName3 = "Dishes";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);
            todoList.AddTask(taskName3);

            todoList.RemoveTask("Laundry");

            int task1ID = 0;
            int task2ID = 1;
            int task3ID = 2;

            Task? task1 = todoList.GetTaskByID(task1ID);
            Task? task3 = todoList.GetTaskByID(task3ID);

            Task? task2 = todoList.GetTaskByID(task2ID);

            Assert.That(task1.ID, Is.EqualTo(0));
            Assert.That(task3.ID, Is.EqualTo(2));
            Assert.That(task2, Is.Null);

        }

        [Test]
        public void UpdateTaskNameTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            todoList.AddTask(taskName1);

            string newName = "Dishes";
            int task1ID = 0;
            int notExistID = 1;

            bool success = todoList.UpdateTaskName(task1ID, newName);
            bool fail = todoList.UpdateTaskName(notExistID, newName);

            Assert.That(todoList.Tasks[0].Name, Is.EqualTo(newName));
            Assert.True(success);
            Assert.False(fail);
        }

        [Test]
        public void UpdateTaskStatusTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            int task1ID = 0;
            int task2ID = 1;
            int notExistID = 2;

            bool success = todoList.UpdateTaskStatus(task1ID);
            bool fail = todoList.UpdateTaskStatus(notExistID);

            Assert.True(todoList.Tasks[task1ID].IsCompleted);
            Assert.False(todoList.Tasks[task2ID].IsCompleted);
            Assert.True(success);
            Assert.False(fail);
        }

        [Test]
        public void GetAllTaskTimeCreatedTest()
        {
            // Simplifying to date, ignoring time of day
            DateTime today = DateTime.Today;

            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            List < (Task, DateTime) > timeCreatedList = todoList.GetAllTaskTimeCreated();

            Assert.That(todoList.Tasks[0].TimeCreated, Is.EqualTo(today));
            Assert.That(timeCreatedList[0].Item2, Is.EqualTo(today));
            Assert.That(timeCreatedList[1].Item2, Is.EqualTo(today));

        }

        [Test]
        public void GetAllTaskTimeCompletedTest()
        {
            DateTime createdTime = new DateTime(2025, 08, 05);
            DateTime completeTime = new DateTime(2025, 08, 06);

            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.ToggleComplete("Homework");
            todoList.AddTask(taskName2);
            todoList.ToggleComplete("Laundry");
            // Not completed task
            todoList.AddTask("Laundry2");

            Assert.That(todoList.Tasks[0].TimeCompleted, Is.Not.Null);

            // Override time created and completed
            todoList.Tasks[0].TimeCreated = createdTime;
            todoList.Tasks[1].TimeCreated = createdTime;
            todoList.Tasks[0].TimeCompleted = completeTime;
            todoList.Tasks[1].TimeCompleted = completeTime;

            List<(Task, DateTime)> timeCompletedList = todoList.GetAllTaskTimeCompleted();

            Assert.That(timeCompletedList[0].Item2, Is.EqualTo(completeTime));
            Assert.That(timeCompletedList[1].Item2, Is.EqualTo(completeTime));
            Assert.That(timeCompletedList.Count, Is.EqualTo(2));

        }

        [Test]
        public void GetTaskWithLongestCompletionTimeTest()
        {
            DateTime createdTime = new DateTime(2025, 08, 05);
            DateTime completeTime1 = new DateTime(2025, 08, 06);
            DateTime completeTime2 = new DateTime(2025, 08, 10);

            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.ToggleComplete("Homework");
            todoList.AddTask(taskName2);
            todoList.ToggleComplete("Laundry");

            // Override time created and completed
            todoList.Tasks[0].TimeCreated = createdTime;
            todoList.Tasks[1].TimeCreated = createdTime;
            todoList.Tasks[0].TimeCompleted = completeTime1;
            todoList.Tasks[1].TimeCompleted = completeTime2;

            Task longestCompletionTimeTask = todoList.GetTaskWithLongestCompletionTime();

            Assert.That(longestCompletionTimeTask.Name, Is.EqualTo(taskName2));
        }

        [Test]
        public void GetTaskWithShortestCompletionTimeTest()
        {
            DateTime createdTime = new DateTime(2025, 08, 05);
            DateTime completeTime1 = new DateTime(2025, 08, 06);
            DateTime completeTime2 = new DateTime(2025, 08, 10);

            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";
            todoList.AddTask(taskName1);
            todoList.ToggleComplete("Homework");
            todoList.AddTask(taskName2);
            todoList.ToggleComplete("Laundry");

            // Override time created and completed
            todoList.Tasks[0].TimeCreated = createdTime;
            todoList.Tasks[1].TimeCreated = createdTime;
            todoList.Tasks[0].TimeCompleted = completeTime1;
            todoList.Tasks[1].TimeCompleted = completeTime2;

            Task shortestCompletionTimeTask = todoList.GetTaskWithShortestCompletionTime();

            Assert.That(shortestCompletionTimeTask.Name, Is.EqualTo(taskName1));
        }
    }
}
