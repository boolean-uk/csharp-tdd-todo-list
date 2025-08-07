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
    }
}
