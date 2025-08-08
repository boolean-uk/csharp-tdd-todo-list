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
    [TestFixture]
    public class ExtensionTests
    {
        [Test]
        public void UpdatedNameIsUpdated()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task = new(id, desc, priority, completed, "");

            list.AddTask(id, task);
            
            Task result = list.RenameTaskbyId(id, "Water flowers");

            Assert.That(result.Desc, Is.EqualTo("Water flowers"));

        }

        [Test]
        public void ChangedStatusIsChanged()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task = new(id, desc, priority, completed, "");

            list.AddTask(id, task);
            Task result = list.ChangeTaskStatus(id, true);

            Assert.True(result.Completed);
        }

        [Test]
        public void GotTasksByCategory()
        {
            TodoList list = new TodoList();
            string id = "1";
            string desc = "Water plants";
            int priority = 3;
            bool completed = false;
            Task task1 = new(id, desc, priority, completed, "work");

            id = "2";
            desc = "Paint wall";
            priority = 3;
            completed = false;
            Task task2 = new(id, desc, priority, completed, "work");

            id = "3";
            desc = "Walk dog";
            priority = 3;
            completed = true;
            Task task3 = new(id, desc, priority, completed, "study");

            list.AddTask(task1.Id, task1);
            list.AddTask(task2.Id, task2);
            list.AddTask(task3.Id, task3);

            List<Task> resultList = list.GetTasksByCategory("work");
            int work = 0;
            int study = 0;

            foreach (var item in resultList)
            {
                if (item.Category.Equals("work")) { work++; }
                else if (item.Category.Equals("study")) { study++; }
            }
            Assert.That(study, Is.EqualTo(0));
            Assert.That(work, Is.EqualTo(2));
        }

        [Test]
        public void CorrectTaskCompletedTime()
        {
            DateTime now = DateTime.Now;
            Task task = new Task("1", "", 1, false, "");
            task.Finished = now;

            Assert.That(task.Finished, Is.EqualTo(now));
        }

        [Test]
        public void CorrectTaskDuration()
        {
            DateTime now = DateTime.Now;
            DateTime future = DateTime.Now.AddDays(1);
            TodoList list = new TodoList();

            Task task = new Task("1", "", 1, false, "");
            list.AddTask("1", task);

            task.Finished = future;

            task.calculateDuration();

            TimeSpan result = list.getTeskDuration("1");
            

            Assert.That((int)result.TotalMinutes , Is.InRange(1439, 1440));
        }

        [Test]
        public void CorrectLongestTaskDuration()
        {
            DateTime now = DateTime.Now;
            DateTime day= DateTime.Now.AddDays(1);
            DateTime day2 = DateTime.Now.AddDays(2);
            TodoList list = new TodoList();

            Task taskShort = new Task("1", "", 1, false, "");
            Task taskLong = new Task("2", "", 1, false, "");
            list.AddTask("1", taskShort);
            list.AddTask("2", taskLong);

            taskShort.Finished = day;
            taskLong.Finished = day2;

            taskLong.calculateDuration();
            taskShort.calculateDuration();

            TimeSpan resultShort = list.getTeskDuration("1");

            Task longest = list.findLongestDurationTask();


            Assert.That(taskShort.Duration.TotalHours.CompareTo(longest.Duration.TotalHours), Is.Negative);
        }

        [Test]
        public void CorrectShortestTaskDuration()
        {
            DateTime now = DateTime.Now;
            DateTime day = DateTime.Now.AddDays(1);
            DateTime day2 = DateTime.Now.AddDays(2);
            TodoList list = new TodoList();

            Task taskShort = new Task("1", "", 1, false, "");
            Task taskLong = new Task("2", "", 1, false, "");
            list.AddTask("1", taskShort);
            list.AddTask("2", taskLong);

            taskShort.Finished = day;
            taskLong.Finished = day2;

            taskLong.calculateDuration();
            taskShort.calculateDuration();

            TimeSpan resultLong = list.getTeskDuration("2");

            Task shortest = list.findShortestDurationTask();


            Assert.That(taskLong.Duration.TotalHours.CompareTo(shortest.Duration.TotalHours), Is.Positive);
        }
        [Test]
        public void TestTasksLongerThan5Days()
        {

            TimeSpan day4 = TimeSpan.FromDays(4);
            TimeSpan day6 = TimeSpan.FromDays(6);
            TimeSpan day10 = TimeSpan.FromDays(6);
            TodoList list = new TodoList();

            Task task4days = new Task("1", "", 1, false, "");
            Task task6days = new Task("2", "", 1, false, "");
            Task task10days = new Task("3", "", 1, false, "");

            task4days.Duration = day4;
            task6days.Duration = day6;
            task10days.Duration = day10;

            list.AddTask("1", task4days);
            list.AddTask("2", task6days);
            list.AddTask("3", task10days);

            List<Task> tasks = list.findTasksLongerThan5Days();

            TimeSpan min = tasks.Min(task => task.Duration);
            int count = tasks.Count();

            Assert.That(min.CompareTo(day4), Is.Positive);
            Assert.That(count, Is.EqualTo(2));
        }


    }
}
