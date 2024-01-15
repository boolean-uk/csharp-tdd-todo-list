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
        [TestCase (1, true)]
        [TestCase (13, false)]
        [TestCase (10101, true)]
        public void Test1(int id, bool expected)
        {
            //  Arrange - set up test values


            //  Act - use the fucntion we want to test
            
            //  Assert - check the results
            Assert.IsTrue(_extension.idTask(id) == expected);
        }

        [Test]
        [TestCase(1, "Shopping",true)]
        [TestCase(13, "Shopping",false)]
        [TestCase(10101, "Shopping",true)]
        public void Test2(int id, string task, bool expected)
        {
            //  Arrange - set up test values


            //  Act - use the fucntion we want to test

            //  Assert - check the results
            Assert.That(_extension.updateNameByID(id, task) == expected);
        }

        [Test]
        [TestCase(1, false)]
        [TestCase(13, false)]
        [TestCase(10101, true)]
        public void Test3(int id, bool expected)
        {
            //  Arrange - set up test values


            //  Act - use the fucntion we want to test

            //  Assert - check the results
            Assert.That(_extension.updateStatusByID(id) == expected);
        }

        [Test]
        public void Test4()
        {
            //  Arrange - set up test values


            //  Act - use the fucntion we want to test

            //  Assert - check the results
            Assert.That(_extension.dates() == true);
        }
    }
}
