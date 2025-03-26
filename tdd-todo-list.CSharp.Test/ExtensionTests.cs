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

        [Test]
        public void TestGetTaskById()
        {
            TodoListExtended td = new TodoListExtended();
            td.AddTask("Task1");
            td.AddTask("Task2");
            Assert.That(td.GetTaskById(0).Taskname, Is.EqualTo("Task1"));
        }

        [TestCase(Status.Incomplete)]
        [TestCase(Status.Complete)]
        public void TestChangeTaskStatus(Status s)
        {
            TodoListExtended td = new TodoListExtended();
            td.AddTask("Task 1");
            td.AddTask("Task 2");

            td.ChangeTaskStatus(0, s);
            TodoTaskExtended t1 = td.GetTaskById(0);
            
            Assert.That(t1.Status, Is.EqualTo(s));
        }

        [TestCase("Updated task 1")]
        [TestCase("Changed task 1")]
        [TestCase("New task 1")]
        public void TestUpdateTask(string newname)
        {
            TodoListExtended td = new TodoListExtended();
            td.AddTask("Task 1");
            td.AddTask("Task 2");

            td.UpdateTask(0, newname);
            TodoTaskExtended t1 = td.GetTaskById(0);

            Assert.That(t1.Taskname, Is.EqualTo(newname));
        }
    }
}
