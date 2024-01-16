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
        
        private TodoListExtension _extension;

        [SetUp]
        public void setup()
        {
            _extension = new TodoListExtension();

        }
        
        // Test getID method
        [Test]
        public void getTaskByIDTest() 
        {
            _extension.addTask("task1", "0");

            string ID = _extension.getID("task1");

            string[] expectedArray = {"task1", ID, "0"};

            string[] actualArray = _extension.getTaskByID(ID);

            Assert.AreEqual(expectedArray[0], actualArray[0]);
            Assert.AreEqual(expectedArray[1], actualArray[1]);
            Assert.AreEqual(expectedArray[2], actualArray[3]);

        }

        // Test updateTaskName method
        [Test]
        public void updateTaskNameTest() 
        {
            _extension.addTask("task1", "0");

            string ID = _extension.getID("task1");

            string[] expectedArray = { "newTask1", ID, "0" };

            _extension.updateTaskNameByID(ID, "newTask1");

            string[] actualArray = _extension.getTaskByID(ID);

            Assert.AreEqual(expectedArray[0], actualArray[0]);

        }
        
        // Test UpdateTaskStatus method
        [Test]
        public void updateTaskStatusByIDTest() 
        {
            _extension.addTask("task1", "0");

            string ID = _extension.getID("task1");

            string [] actualArray = _extension.getTaskByID(ID);

            Assert.AreEqual(actualArray[3], "0");

            _extension.updateTaskStatusByID(ID, "1");

            Assert.AreEqual(actualArray[3], "1");

            _extension.updateTaskStatusByID(ID, "0");

            Assert.AreEqual(actualArray[3], "0");
        }
        
        // Test ShowTimeStamp Function
        [Test]
        public void showTimeStampsTest()
        {
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            _extension.addTask("task1", "0");
            _extension.addTask("task2", "0");
            _extension.addTask("task3", "1");

            string [] expectedArray = 
                {
                "task1:" + currentTime, 
                "task2:" + currentTime,
                "task3:" + currentTime
                };

            Assert.AreEqual(expectedArray, _extension.showTimeStamps());
        }
        
    }
}