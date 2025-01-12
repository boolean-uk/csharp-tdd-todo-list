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
    public class ExtensionTest
    {

        [Test]
        public void GetTaskById()
        {
           
            

            TodoListExtension extension = new TodoListExtension();
            
            extension.AddTask("Clean up");
            Guid id = extension.getId("Clean up");
            string task = extension.RetrieveTaskByID(id);
            Assert.That(extension.RetrieveTaskByID(id), Is.EqualTo("Clean up"));
        }

        [Test]
        public void ChangeTaskName()
        {
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("A");
            Guid id = ext.getId("A");
            ext.ChangeTaskName(id, "Axel");
            Assert.That(ext.TaskExists("Axel"));
            Assert.That(!ext.TaskExists("A"));
        }

        [Test]
        public void ChangeTaskStatus()
        {
            TodoListExtension ext = new TodoListExtension();
            
            ext.AddTask("A");
            Guid guid = ext.getId("A");
            string currstatus = ext.GetStatus("A");  
            Assert.That(currstatus, Is.EqualTo("incomplete")); 
            ext.ChangeTaskStatusByID(guid, "complete");
            currstatus = ext.GetStatus("A");
            Assert.That(currstatus, Is.EqualTo("complete"));
        }


        [Test]
        public void DisplayDate()
        {
            TodoListExtension ext = new TodoListExtension();
            ext.AddTask("A");
            Guid guid = ext.getId("A");
            Console.WriteLine(ext.DisplayDate(guid));
        }

    }


}