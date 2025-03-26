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
        public void SearchId()
        {
            
            //Set Up
            TodoListExtension list = new TodoListExtension();

            //Execute
            list.add(1, "Finish Boolean Exercise", true);
            list.add(1, "Finish Boolean Exercise", false);
            list.add(2, "WAsH DisHeS", false);
            list.add(2, "Vaccum House", true);

            //Verify
            Assert.IsTrue(list.toDoListExtension.Count == 2);
            Assert.IsTrue(list.searchId(1) == "Finish Boolean Exercise");
        }
        [Test]
        public void UpdateTask()
        {

            //Set Up
            TodoListExtension list = new TodoListExtension();

            //Execute
            list.add(1, "Finish Boolean Exercise", true);
            list.add(1, "Finish Boolean Exercise", false);
            list.add(2, "WAsH DisHeS", false);
            list.add(2, "Vaccum House", true);
            list.updateTask(1, "Finish Extended Tests");

            //Verify
            Assert.IsTrue(list.toDoListExtension.Count == 2);
            Assert.IsTrue(list.searchId(1) == "Finish Extended Tests");
        }
        [Test]
        public void UpdateStatus()
        {

            //Set Up
            TodoListExtension list = new TodoListExtension();

            //Execute
            list.add(1, "Finish Boolean Exercise", true);
            list.add(1, "Finish Boolean Exercise", false);
            list.add(2, "WAsH DisHeS", false);
            list.add(2, "Vaccum House", true);
            list.updateStatus(1);

            //Verify
            Assert.IsTrue(list.toDoListExtension.Count == 2);
            Assert.That(list.toDoListExtension[1].Status == false);
        }

        [Test]
        public void SearchIdTime()
        {

            //Set Up
            TodoListExtension list = new TodoListExtension();

            //Execute
            list.add(1, "Finish Boolean Exercise", true);
            list.add(1, "Finish Boolean Exercise", false);
            list.add(2, "WAsH DisHeS", false);
            list.add(2, "Vaccum House", true);
            list.searchId(1);

            //Verify
            Assert.IsTrue(list.toDoListExtension.Count == 2);
            Assert.IsTrue(list.searchId(1) == "Finish Boolean Exercise");
            Assert.That(list.timeVar == list.extensionDateTime[1]);
        }
    }
}
