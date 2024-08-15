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


        [Test]
        public void GetTaskTest()
        {
            ExtendedToDoList _extension = new ExtendedToDoList();
            ExtendedTasks task = new ExtendedTasks(69, "Task1");
            _extension.Add(task);
            Assert.That(task, Is.EqualTo(_extension.GetTask(69)));
        }

        [TestCase(true, 69)]
        [TestCase(false, 420)]
        public void UpdateNameTest(bool expectedResult, int id)
        {
            ExtendedToDoList _extension = new ExtendedToDoList();
            ExtendedTasks task = new ExtendedTasks(69, "Task1");
            _extension.Add(task);
            bool result = _extension.UpdateName(id, "Task2");
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(true, 1)]
        [TestCase(false, 2)]
        public void ChangeStatusTest(bool expectedresult, int amountOfChanges)
        {
            ExtendedToDoList _extension = new ExtendedToDoList();
            ExtendedTasks task = new ExtendedTasks(69, "Task1");
            _extension.Add(task);
            for(int i = 0; i< amountOfChanges; i++)
            {
                _extension.ChangeStatus(69);
            }
            Assert.That(expectedresult, Is.EqualTo(_extension.GetTask(69).status));
        }

        [Test]
        public void GetDateTimeTest()
        {
            ExtendedToDoList _extension = new ExtendedToDoList();
            ExtendedTasks task = new ExtendedTasks(69, "Task1");
            DateTime dt = task.datetime;
            _extension.Add(task);
            Assert.That(dt, Is.EqualTo(_extension.GetDateTime(69)));
        }
    }
}
