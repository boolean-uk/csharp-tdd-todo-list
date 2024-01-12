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
        public TodoListExtension _extension = new TodoListExtension();

        [SetUp]
        public void SetUp()
        {
            _extension.AddTask("Clean", false, 23, 16, 12);
            _extension.AddTask("Dust", false, 12, 13, 2);
            _extension.AddTask("Mop", true, 78, 5, 8);
            _extension.AddTask("Paint", true, 109, 7, 1);
        }

        [TestCase(23, "Clean")]
        [TestCase(78, "Mop")]
        [TestCase(10, "Do not exist")]
        public void GetNameByID(int ID, string expected)
        {
            string result = _extension.GetName(ID);
            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase(23, "Play", true)]
        [TestCase(78, "Gaming", true)]
        [TestCase(10, "Vaccum", false)]
        public void ChangedName(int ID, string newName, bool expected)
        {
            bool result = _extension.NewName(ID, newName);
            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase(23, true)]
        [TestCase(78, true)]
        [TestCase(10, false)]
        public void ChangedStatus(int ID, bool expected)
        {
            bool result = _extension.ChangeStatus(ID);
            Assert.That(expected, Is.EqualTo(result));
        }

        [TestCase(23, "16, 12")]
        [TestCase(78, "5, 8")]
        [TestCase(10, "Do not exist")]
        public void GottenDayTime(int ID, string expected)
        {
            string result = _extension.GetDayTime(ID);
            Assert.That(expected, Is.EqualTo(result));
        }
    }
}