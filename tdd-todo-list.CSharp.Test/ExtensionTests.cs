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
        [TestCase(0, "Test1", Status.INCOMPLETE)]
        [TestCase(1, "Test2", Status.COMPLETE)]
        public void FetchTaskByIDTest(int id, string taskName, Status status)
        {
            TodoListExtended tl = new TodoListExtended();
            tl.AddTask(taskName, status);
            TodoTaskExtended foundTask = tl.FetchTaskByID(id);

            if (tl.todoList.Count() > id)
            {
                Assert.That(foundTask.id, Is.EqualTo(id));
            }
            else
            {
                Assert.That(foundTask, Is.Null);
            }
        }

        [TestCase(0, true)]
        [TestCase(1, false)]
        public void UpdateTaskNameByIDTest(int id, bool expected)
        {
            TodoListExtended tl = new TodoListExtended();
            tl.AddTask("Task1", Status.INCOMPLETE);
            bool result = tl.UpdateTaskNameByID(id, "Task1");

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(0, true)]
        [TestCase(1, false)]
        public void UpdateTaskStatusByIDTest(int id, bool expected)
        {
            TodoListExtended tl = new TodoListExtended();
            tl.AddTask("Task1", Status.INCOMPLETE);
            bool result = tl.UpdateTaskStatusByID(id, Status.COMPLETE);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
