using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        [Test]
        public void TestGetIds()
        {
            _extension = new TodoListExtension();
            TaskExtension t1 = _extension.Add("1", "");
            TaskExtension t2 = _extension.Add("2", "");
            TaskExtension t3 = _extension.Add("3", "");

            List<long> ids = _extension.GetIDs();

            Assert.Contains(t1.id, ids);
            Assert.Contains(t2.id, ids);
            Assert.Contains(t3.id, ids);

        }


        [TestCase("Task 1", "Do some work")]
        [TestCase("Task 2", "Take a break")]
        public void TestGetTaskById(string title, string description)
        {
            _extension = new TodoListExtension();
            TaskExtension t1 = _extension.Add(title, description);

            TaskExtension retrievedTask = _extension.GetTaskByID(t1.id);

            Assert.True(t1.Equals(retrievedTask));
        }


        [TestCase("akdnskd", "...", "ksdskdmks")]
        [TestCase("ajsndfouasbfd", "...", "saudasodhasjodhasjd")]
        public void UpdateTaskTitleByID(string title, string description, string new_title)
        {
            _extension = new TodoListExtension();
            TaskExtension t1 = _extension.Add(title, description);

            TaskExtension updated = _extension.UpdateTaskTitle(t1.id, new_title);

            Assert.NotNull(_extension.tasks.FirstOrDefault(x => x.title == new_title));
            Assert.Null(_extension.tasks.FirstOrDefault(x => x.title == title));
        }

        [TestCase("Task 1", "Do some work")]
        [TestCase("Task 2", "Take a break")]
        public void TestUpdateTaskStatusByID(string title, string description)
        {
            _extension = new TodoListExtension();
            TaskExtension t1 = _extension.Add(title, description);
            Assert.False(t1.status);
            TaskExtension updatedTask = _extension.UpdateTaskStatus(t1.id, true);

            Assert.True(updatedTask.status);
        }

        [TestCase("Task 1", "Do some work")]
        [TestCase("Task 2", "Take a break")]
        public void TestTaskListToStr(string title, string description)
        {
            _extension = new TodoListExtension();
            TaskExtension t1 = _extension.Add(title, description);
            string creationTime = _extension.GetCreationTime();
            string expectedOutput = t1.id + " " + t1.title + " " + t1.creationTime.ToString() + "\n";
            Assert.That(expectedOutput, Is.EqualTo(creationTime));

        }






    }
}
