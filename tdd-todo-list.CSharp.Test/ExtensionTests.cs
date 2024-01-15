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
        public void FirstTest()
        {
            TodoListExtension extend = new TodoListExtension();

            extend.addTask(111, "Cleaning", "July 07");

            Assert.IsTrue(extend.getByID(111).Name == "Cleaning");
            Assert.IsTrue(extend.getByID(111).Date == "July 07");
            Assert.IsTrue(extend.getByID(111).IsCompleted == false);
        }
        [Test]
        public void SecondTest()
        {
            TodoListExtension extend = new TodoListExtension();

            extend.addTask(111, "Cleaning", "July 07");

            Assert.IsTrue(extend.getByID(0).Name == "None");

        }
        [Test]
        public void ThirdTest()
        {
            TodoListExtension extend = new TodoListExtension();

            extend.addTask(111, "Cleaning", "July 07");
            extend.updateName(111, "Cooking");


            Assert.IsTrue(extend.getByID(111).Name == "Cooking");

        }



    }
}
