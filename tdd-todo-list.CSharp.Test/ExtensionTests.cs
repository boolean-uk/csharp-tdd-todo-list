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
        
        private ExtensionList _extension;
        public ExtensionTests()
        {
            _extension = new ExtensionList();
        }

        [Test]
        public void FindTaskByIDTest() 
        { 
            //arrange
            ExtensionTask taskA = new ExtensionTask("A", "Finish the todolist");
            ExtensionList list = new ExtensionList();
            list.AddTask(taskA);
            //act
            ExtensionTask task = list.FindTAskByID("A");

            //assert
            Assert.That(task.ID(), Is.EqualTo("A"));
        }
        
        [Test]
        public void UpdateTaskNameByIDTest()
        { 
            //arrange
            ExtensionTask taskA = new ExtensionTask("A", "Finish the todolist");
            ExtensionList list = new ExtensionList();
            list.AddTask(taskA);
            //act
            list.UpdateTaskNameByID("A", "Don't finish the todolist");
            ExtensionTask task = list.FindTAskByID("A");

            //assert
            Assert.That(task.Name(), Is.EqualTo("Don't finish the todolist"));
        }
        
        [Test]
        public void GetCreationTimeTest()
        {
            //arrange
            ExtensionList list = new ExtensionList();
            ExtensionTask taskA = new ExtensionTask("A", "Finish the todolist");
            DateTime datetimefirst = taskA.GetDateTime();

            //act
            
            list.AddTask(taskA);
            ExtensionTask task = list.FindTAskByID("A");
            DateTime datetimesecond = task.GetDateTime();

            //assert
            Assert.That(datetimefirst, Is.EqualTo(datetimesecond));
        }
        [Test]
        public void UpdateCompletedByIDTest()
        { 
            //arrange
            ExtensionTask taskA = new ExtensionTask("A", "Finish the todolist");
            ExtensionList list = new ExtensionList();
            list.AddTask(taskA);
            //act
            list.UpdateCompletedByID("A");
            ExtensionTask task = list.FindTAskByID("A");

            //assert
            Assert.That(task.IsComplete(), Is.EqualTo(true));
        }
        
    }
}
