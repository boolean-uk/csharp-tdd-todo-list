
using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();

        }

        [Test]
        public void TestGetTaskById()
        {
            var date = DateTime.Now;

            TodoListExtension tle = new TodoListExtension();
            tle.AddTask(new TodoTaskExtension { Id = 1, Name = "Banana", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 2, Name = "Apple", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 3, Name = "Pear", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 4, Name = "Kiwi", Iscomplete = false });


            var task = tle.GetTaskByID(1);

            Assert.AreEqual("Banana", tle.GetTaskByID(1).Name);
            Assert.AreEqual("Apple", tle.GetTaskByID(2).Name);
            Assert.AreEqual("Pear", tle.GetTaskByID(3).Name);
            Assert.AreEqual("Kiwi", tle.GetTaskByID(4).Name);

        }

        [Test]

        public void UpdateNameOfaTask()
        {
            TodoListExtension tle = new TodoListExtension();
            tle.AddTask(new TodoTaskExtension { Id = 1, Name = "Banana", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 2, Name = "Apple", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 3, Name = "Pear", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 4, Name = "Kiwi", Iscomplete = false });

            var updatedTask = tle.UpdateTask(1, "Pear");

            Assert.AreEqual("Pear", updatedTask.Name);
        }


        [Test]

        public void UpdateStatusOfaTask()
        {
            TodoListExtension tle = new TodoListExtension();
            tle.AddTask(new TodoTaskExtension { Id = 1, Name = "Banana", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 2, Name = "Apple", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 3, Name = "Pear", Iscomplete = false });
            tle.AddTask(new TodoTaskExtension { Id = 4, Name = "Kiwi", Iscomplete = false });

            var updatedStatus = tle.UpdateStaus(1, true);

            Assert.IsTrue(updatedStatus.Iscomplete);
        }


        [Test]
        public void TestDateCreated()
        {

            TodoListExtension tle = new TodoListExtension();
            var creationDate = new DateTime(2020,08,12);
            tle.AddTask(new TodoTaskExtension { Id = 1, Name = "Banana", Iscomplete = false, Date = creationDate});

            var createdTime = tle.CreatedTime(1);

            Assert.AreEqual("12,08,2020", createdTime);

        }


    }
}
