using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;

        [SetUp]
        public void SetUp()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void GetTaskByIDTest()
        {
            _extension.Add("Make a todolist");

            Guid TaskID = _extension._extensionTasks[0]._ID;

            ExtensionTodoTask test1 = _extension.getTaskWithID(TaskID);

            Assert.AreEqual(test1._description, "Make a todolist");
            Assert.IsFalse(test1._done);
        }

        [Test]
        public void UpdateItemTest()
        {
            _extension.Add("Make a todolist");

            Guid TaskID = _extension._extensionTasks[0]._ID;

            _extension.UpdateItem(TaskID, "Make a cake");

            Assert.AreEqual(1, _extension._extensionTasks.Count);
            Assert.AreEqual(_extension._extensionTasks[0]._description, "Make a cake");
          
        }

        [Test]
        public void UpdateTaskStatusTest()
        {
            _extension.Add("Make a todolist");

            Guid TaskID = _extension._extensionTasks[0]._ID;

            _extension.UpdateTaskStatus(TaskID, true);

            Assert.IsTrue(_extension._extensionTasks[0]._done);

            _extension.UpdateTaskStatus(TaskID, false);

            Assert.IsFalse(_extension._extensionTasks[0]._done);

        }

        [Test]
        public void DateTimeListTest()
        {
            DateTime testDateTime = DateTime.Now;

            _extension.Add("Make a todolist");
            _extension.Add("Make a cake");

            Dictionary<string, DateTime> result = _extension.GetDateTimeDict();

            DateTime dt1 = result["Make a todolist"];
            DateTime dt2 = result["Make a cake"];

            Assert.AreEqual(dt1.GetType(), testDateTime.GetType());
            Assert.AreEqual(dt2.GetType(), testDateTime.GetType());

        }

        [Test]
        public void GetTaskDateTimeTest()
        {
            DateTime testDateTime = DateTime.Now;

            _extension.Add("Make a todolist");

            Guid TaskID = _extension._extensionTasks[0]._ID;

            var res = _extension.GetTaskDateTimeByID(TaskID);

            Assert.AreEqual(res.GetType(), testDateTime.GetType());

            ExtensionTodoTask res2 = _extension._extensionTasks[0];

            DateTime secondTest = res2.DateTime;

            Assert.AreEqual(res, secondTest);

        }
    }
}
