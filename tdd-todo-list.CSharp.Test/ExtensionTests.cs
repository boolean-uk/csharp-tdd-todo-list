using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension extension;
        private List<string> tasks = ["Go hiking", "Go hiking", "Buy a bike", "Care for cats", "Go skydiving", "Dont fall", "Run home", "Forget the alarm"];
        [SetUp]
        public void SetUp()
        {
            extension = new TodoListExtension();
        }

        [TestCase("Get milk", 0)]
        [TestCase("Get a goat", 1)]
        [TestCase("Swim at winter", 4)]
        public void TestAdd(string name, int toAddFirst)
        {
            for (int i = 0; i < toAddFirst; i++)
            {
                extension.Add(tasks[i]);
            }
            int recieved_id = extension.Add(name);
            Assert.That(recieved_id, Is.EqualTo(toAddFirst));
        }

        [Test]
        public void TestGet()
        {
            Dictionary<int, string> ids = [];
            tasks.ForEach(task => ids.Add(extension.Add(task), task));

            Assert.Throws<ArgumentException>(() => extension.Get(1222));

            // Checking get by id
            foreach (var item in ids)
            {
                TodoTask task = extension.Get(item.Key);
                Assert.That(task.Name, Is.EqualTo(item.Value));
                Assert.That(task.Id, Is.EqualTo(item.Key));
            }
        }

        [TestCase(1, "Some new task")]
        [TestCase(3, "Some new task")]
        public void TestUpdateName(int id, string name)
        {
            tasks.ForEach(task => extension.Add(task));
            Assert.That(extension.ContainsId(id), Is.True); // If this triggers, it is the test that is wrong. A test for the test.
            Assert.That(extension.Get(id).Name, Is.Not.EqualTo(name));
            extension.UpdateName(id, name);
            Assert.That(extension.Get(id).Name, Is.EqualTo(name));
        }

        [Test]
        public void TestToggleStatus()
        {
            int[] ids = [1, 2, 3]; // Ids must be within range of the tasks variable!

            tasks.ForEach(task => extension.Add(task));
            Assert.That(extension.TaskList.Select(task => task.Completed), Is.All.False);
            foreach (int id in ids)
            {
                Assert.That(extension.Get(id).Completed, Is.False);
                extension.ToggleStatus(id);
                Assert.That(extension.Get(id).Completed, Is.True);
            }
            extension.ToggleStatus(ids[0]);
            Assert.That(extension.Get(ids[0]).Completed, Is.False);
        }

        [TestCase("I will conquer time!")]
        [TestCase("I will conquer space!")]
        public void TestTaskCreatedDate(string task)
        {
            DateTime now = DateTime.Now;
            int id = extension.Add(task);
            Assert.That(extension.GetTaskCreatedDate(id), Is.EqualTo(now).Within(1).Minutes);
        }

        [TestCase(true)]
        [TestCase(false)]
        public void TestGetSortedTaskList(bool asc)
        {
            tasks.ForEach(task => extension.Add(task));
            Assert.That(extension.GetSortedTaskList(asc).Select(task => task.Name), asc ? Is.Ordered.Ascending : Is.Ordered.Descending);
        }

        [TestCase(1)]
        [TestCase(6)]
        [TestCase(5)]
        [TestCase(3)]
        public void TestRemoveTask(int id)
        {
            tasks.ForEach(task => extension.Add(task));
            TodoTask task = extension.Get(id);
            Assert.That(extension.TaskList.Count, Is.EqualTo(tasks.Count));
            extension.RemoveTask(id);
            Assert.That(extension.TaskList.Count, Is.EqualTo(tasks.Count - 1));
            Assert.That(extension.TaskList, Does.Not.Contain(task));
        }
    }
}
