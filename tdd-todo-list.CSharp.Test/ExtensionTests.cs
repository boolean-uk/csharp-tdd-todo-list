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
        public void ExtensionGetTest()
        {
            var correct = new Tuple<int, string, bool, DateTime>(24, "ExtensionExersice", false, DateTime.Now);

            TodoListExtension _extension = new TodoListExtension();
            _extension.AddTask(1, "Make a TodoList", false);
            _extension.AddTask(2, "Make a list", true);
            _extension.AddTask(24, "ExtensionExersice", false);
            Assert.AreEqual(_extension.GetTask(24).Item2, "ExtensionExersice");
        }

        [Test]
        public void ChangeNameTest()
        {
            var correct = new Tuple<int, string, bool, DateTime>(24, "ExtensionExersice", false, DateTime.Now);

            TodoListExtension _extension = new TodoListExtension();
            _extension.AddTask(1, "Make a TodoList", false);
            _extension.AddTask(2, "Make a list", true);
            _extension.AddTask(24, "Ext", false);
            _extension.ChangeName(24, "ExtensionExersice");
            Assert.AreEqual(_extension.GetTask(24).Item2, correct.Item2);
        }

        [Test]
        public void ChangeStatusTest()
        {
            var correct = new Tuple<int, string, bool, DateTime>(24, "ExtensionExersice", false, DateTime.Now);

            TodoListExtension _extension = new TodoListExtension();
            _extension.AddTask(1, "Make a TodoList", false);
            _extension.AddTask(2, "Make a list", true);
            _extension.AddTask(24, "ExtensionExersice", true);
            _extension.ChangeStatus(24);
            Assert.AreEqual(_extension.GetTask(24).Item3, correct.Item3);
        }

        [Test]
        public void TimeCreatedTest()
        {
            var correct = new Tuple<int, string, bool, DateTime>(24, "ExtensionExersice", false, DateTime.Now);

            TodoListExtension _extension = new TodoListExtension();
            _extension.AddTask(1, "Make a TodoList", false);
            _extension.AddTask(2, "Make a list", true);
            _extension.AddTask(24, "ExtensionExersice", false);
            Console.WriteLine(_extension.TimeCreated(24));
        }
    }
}
