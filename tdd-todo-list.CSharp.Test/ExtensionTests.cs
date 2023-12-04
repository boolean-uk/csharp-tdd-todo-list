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
        public void GeneralTest()
        {
            //arrange
            //arrange
            TodoListExtension ext = new TodoListExtension();

            //act
            ext.AddTask("Get coffee");
            ext.AddTask("Build ID generator");

            //assert
            Assert.IsTrue(ext.ToDoListExt.Count > 0);

        }

        [Test]
        public void Ext_TestOne() //10: I want to be able to get a task by a unique ID.
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("Get coffee");
            ext.AddTask("Build ID generator");
            ext.AddTask("Set the date and time");

            //act
            string result = ext.FindTaskByID(2);

            //assert
            Assert.IsTrue(result.Contains("Build ID generator"));
        }

        [Test]
        public void Ext_TestTwo() //11: I want to update the name of a task by providing its ID and a new name.
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("Get coffee");
            ext.AddTask("Build ID generator");
            ext.AddTask("Set the date and time");

            //act
            ext.UpdateNameByID(3, "Reset timeline");

            //assert
            Assert.IsTrue(ext.FindTaskByID(3).Contains("Reset timeline"));
        }

        [Test]
        public void Ext_TestThree() //12: I want to be able to change the status of a task by providing its ID.
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("Get coffee");
            ext.AddTask("Build ID generator");
            ext.AddTask("Create a new timeline");

            //act
            ext.UpdateStatusByID(2, true);

            //assert
            Assert.IsTrue(ext.ToDoListExt[1].Complete);
        }

        [Test]
        public void Ext_TestFour_A() //13: I want to be able to see the date and time that I created each task  --> by ID
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("Get tea");
            ext.AddTask("Build timeline generator");
            ext.AddTask("Set the clock");

            //act
            string result = ext.ShowCreation(2);
            string expected = ext.ToDoListExt[1].Creation.ToString();

            //assert
            Assert.That(result.Equals(expected));
        }
        
        [Test]
        public void Ext_TestFour_B() //13: I want to be able to see the date and time that I created each task --> by Task name
        {
            //arrange
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("Get tea");
            ext.AddTask("Build timeline generator");
            ext.AddTask("Set the clock");

            //act
            string result = ext.ShowCreation("Set the clock");
            string expected = ext.ToDoListExt[2].Creation.ToString();

            //assert
            Assert.That(result.Equals(expected));
        }
    }
}
