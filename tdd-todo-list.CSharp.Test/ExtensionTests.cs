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
        public void TestAdd()
        {
            TodoListExtension core = new TodoListExtension();

            core.AddEx("sleep", 1);
            core.AddEx("play", 2);
            Assert.That(core._todo[0]._id, Is.EqualTo(1));
            Assert.That(core._todo[1]._id, Is.EqualTo(2));
            core.AddEx("stay", 2);
            Assert.That(core._todo.Count, Is.EqualTo(2));
        }
        [Test]
        public void TestUpdate()
        {
            TodoListExtension core = new TodoListExtension();

            core.AddEx("sleep", 1);
            core.AddEx("play", 2);

            core.UpdateTask(1, "party");
            Assert.That(core._todo[0]._task, Is.EqualTo("party"));
            Assert.That(core._todo[0]._id, Is.EqualTo(1));
        }
        [Test]
        public void TestStatusChange()
        {
            TodoListExtension core = new TodoListExtension();

            core.AddEx("sleep", 1);
            core.AddEx("play", 2);

            Assert.That(core._todo[0]._completed, Is.EqualTo(false));

            core.ChangeStatusEx(1);
            Assert.That(core._todo[0]._completed, Is.EqualTo(true));
        }
        [Test]
        public void TestTime()
        {
            TodoListExtension core = new TodoListExtension();

            core.AddEx("sleep", 1);

            Assert.That(core.TimeOfTasks(1), Is.EqualTo(core._todo[0]._time));
        }
    }
}
