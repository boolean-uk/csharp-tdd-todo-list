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

            extend.addTask(111, "Cleaning", "July 07,13:00");

            Assert.IsTrue(extend.getByID(111).Name == "Cleaning");
            Assert.IsTrue(extend.getByID(111).DateTime == "July 07,13:00");
            Assert.IsTrue(extend.getByID(111).IsCompleted == false);
        }
        [Test]
        public void SecondTest()
        {
            TodoListExtension extend = new TodoListExtension();

            extend.addTask(111, "Cleaning", "July 07,13:00");

            Assert.IsTrue(extend.getByID(0).Name == "None");

        }
        [Test]
        public void ThirdTest()
        {
            TodoListExtension extend = new TodoListExtension();

            extend.addTask(111, "Cleaning", "July 07,13:00");
            bool updateTest = extend.updateName(111, "Cooking");

            Assert.IsTrue(updateTest);
            Assert.IsTrue(extend.getByID(111).Name == "Cooking");

        }
        [Test]
        public void FourthTest()
        {
            TodoListExtension extend = new TodoListExtension();
            extend.addTask(111, "Cleaning", "July 07,13:00");
            bool completeTest = extend.changeCompletion(111);

            Assert.IsTrue(completeTest);
            Assert.IsTrue(extend.getByID(111).IsCompleted == true);

        }
        [Test]
        public void FifthTest()
        {
            TodoListExtension extend = new TodoListExtension();
            extend.addTask(111, "Cleaning", "July 07,13:00");
            extend.addTask(112, "Cooking", "March 01,15:23");

            List<string> dateTimeTest = extend.dateTimeTasks();

            Assert.IsTrue(dateTimeTest[0] == "111 Created on the:July 07,13:00");
            Assert.IsTrue(dateTimeTest[1] == "112 Created on the:March 01,15:23");

        }


    }
}
