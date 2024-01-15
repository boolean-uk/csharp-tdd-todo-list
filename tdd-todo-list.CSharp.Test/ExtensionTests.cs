using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
{
    [Test]
    public void addingTask()
        {
            TodoListExtension extended = new TodoListExtension();
           
            extended.addTask("dog");

            string task = "Feed the Fishes";
            Dictionary<int, string> listOfTasks = extended.addTask(task);

            Assert.IsTrue(listOfTasks.ContainsValue(task));
            Assert.That(listOfTasks.Count > 0);
        }

        [Test]
        public void getTaskById()
        {
            TodoListExtension extended = new TodoListExtension();
            
            string task = "Fishes";
            string task2 = "Horses";
            extended.addTask(task);
            extended.addTask(task2);

            string[] taskFromId = extended.getTaskById(0);

            Assert.IsTrue(taskFromId[1].ToUpper() == "FISHES");
            Assert.IsTrue(taskFromId[0] == "0");
           Assert.IsTrue(taskFromId[3].ToUpper() == "FALSE");

            taskFromId = extended.getTaskById(1);

            Assert.AreEqual(task2, taskFromId[1]);
        }

        [Test]
        public void changeTaskName()
        {
            TodoListExtension extended = new TodoListExtension();

            extended.addTask("Fishes"); //id = 0
            extended.addTask("Horses"); //id = 1
            extended.addTask("draw smileys");

            extended.changeName(1, "Happy horses");   //id, new name         

            string[] taskFromId = extended.getTaskById(1);

            Assert.IsTrue(taskFromId[1].ToUpper() == "HAPPY HORSES");
            Assert.IsTrue(taskFromId[0] == "1");
           
        }
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        
        public void changeTaskStatus(int id)
        {
            TodoListExtension extended = new TodoListExtension();

            extended.addTask("Fishes"); //id = 0
            extended.addTask("Horses"); //id = 1
            extended.addTask("draw smileys",true);

            //id, new name         
            string[] currentStatus = extended.getTaskById(id);
            string[] taskFromId = extended.changeTaskStatus(id);


            Assert.IsTrue(taskFromId[0] == id.ToString());
            if (currentStatus[3].ToString().ToUpper() == "TRUE")
            {
                Assert.IsTrue(taskFromId[3].ToString().ToUpper() == "FALSE");

            }
            else { Assert.IsTrue(taskFromId[3].ToString().ToUpper() == "TRUE"); }

        }
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void getCreationStamp(int id) {

            TodoListExtension extended = new TodoListExtension();

            extended.addTask("Fishes"); //id = 0
            extended.addTask("Horses"); //id = 1
            extended.addTask("draw smileys", true);

            //id, new name         
            string Result = extended.getTimeStamp(id);
            string day = DateTime.Now.ToLocalTime().ToString().Substring(0,10);
            string hrs = DateTime.Now.ToLocalTime().ToString().Substring(11, 2);

            Assert.That(Result.Substring(0,13),Is.EqualTo($"{day} {hrs}"));


        }

    }

}
