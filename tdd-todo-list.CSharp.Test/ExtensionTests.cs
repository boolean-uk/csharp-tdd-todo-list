using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

/*
I want to be able to get a task by a unique ID.
I want to update the name of a task by providing its ID and a new name.
I want to be able to change the status of a task by providing its ID.
I want to be able to see the date and time that I created each task.
 */

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        [Test]
        public void IDTest()
        {
            TodoListExtension core = new TodoListExtension();
            core.addTask("name");
            int ID = core.getID("name");
            Assert.Pass();
        }

        [Test]
        public void getTaskByIDTest()
        {
            TodoListExtension core = new TodoListExtension();
            core.addTask("name");
            int ID = core.getID("name");
            Assert.IsTrue(core.getTaskByID(ID) == "name");
        }

        [Test]
        public void updateNameTest()
        {
            TodoListExtension core = new TodoListExtension();
            core.addTask("name");
            int ID = core.getID("name");
            core.updateName(ID, "newName");
            Assert.IsTrue(core.getTaskByID(ID) == "newName");
        }

        [Test]
        public void changeStatusByIDTest()
        {
            TodoListExtension core = new TodoListExtension();
            core.addTask("name");
            int ID = core.getID("name");
            core.updateStatus(ID, "complete");
            Assert.IsTrue(core.viewTasks("", "complete").SequenceEqual(
                new List<string>() { "name" })
                );
        }

        [Test]
        public void whenCreatedTest()
        {
            TodoListExtension core = new TodoListExtension();
            core.addTask("name");
            int ID = core.getID("name");
            DateTime time = DateTime.Now;
            Assert.IsTrue(time == core.whenCreated(ID));
        }
    }
}
