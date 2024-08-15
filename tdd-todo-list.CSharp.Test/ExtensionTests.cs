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
        public void ETest1()
        {
            var extension = new TodoListExtension();
            int id = 0;
            string task = "Walk the dog";
            bool status = false;
            DateTime dateTime = DateTime.Now;
            extension.add(id, task, status, dateTime);
            (string, bool, DateTime) result = extension.getTask(id);
            Assert.That(result.Item1.Equals(task));
        }

        [Test]
        public void ETest2()
        {
            var extension = new TodoListExtension();
            int id = 0;
            string task = "Walk the dog";
            bool status = false;
            DateTime dateTime = DateTime.Now;
            extension.add(id, task, status, dateTime);
            extension.updateTask(id, "Pet the dog");

            Assert.That(extension.getTask(id).Item1.Equals("Pet the dog"));

        }
    }
}
