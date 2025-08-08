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
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void GetIDTest()
        {
            _extension.Add("test1");
            _extension.Add("test2");

            TodoObject getFirst = _extension.GetByID(0);
            TodoObject getSecond = _extension.GetByID(1);

            TodoObject expectedFirst = _extension.Todo[0];
            TodoObject expectedSecond = _extension.Todo[1];

            Assert.That(getFirst == expectedFirst && getSecond == expectedSecond);
        }

        [Test]
        public void UpdateNameTest() {
            

            string newName = "new name for task";
            _extension.UpdateName(1, newName);

            string actualName = _extension.GetByID(1).TaskStr;

            Assert.That(actualName == newName);

        }
    }
}
