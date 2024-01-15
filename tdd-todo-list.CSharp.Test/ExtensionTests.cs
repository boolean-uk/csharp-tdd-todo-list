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
        
        [Test]
        public void getByID()
        {
            //Arrange
            TodoListExtension ext = new TodoListExtension();
            ext.addTask("t1");

            var task = ext.todoListEx.FirstOrDefault(item => item.ptask == "t1");

            //Act
            var result = ext.GetTask(task.taskID);
            var falseResult = ext.GetTask(Guid.NewGuid());
            

            //Assess
            Assert.IsNotNull(result);
            Assert.IsNull(falseResult);
            Assert.AreEqual(result.taskID, task.taskID);
        }
        [Test]
        public void editTaskName()
        {
            TodoListExtension ext = new TodoListExtension();
            ext.addTask("t1");
            ext.addTask("t2");
            var task = ext.todoListEx.FirstOrDefault(item => item.ptask == "t1");
            var task2 = ext.todoListEx.FirstOrDefault(item => item.ptask == "t2");

            //Act
            Assert.IsNotNull(ext.edit(task.taskID, "t10"));
            Assert.IsNull(ext.edit(Guid.NewGuid(),"test"));
            Assert.AreEqual(task.ptask, "t10");

            Assert.IsNull(ext.edit(task2.taskID, "t10"));

        }
        [Test]
        public void editTaskStatus()
        {
            TodoListExtension ext = new TodoListExtension();
            ext.addTask("t1");
            var task = ext.todoListEx.FirstOrDefault(item => item.ptask == "t1");

            //Act
            Assert.IsNotNull(ext.edit(task.taskID, true));
            Assert.IsNull(ext.edit(Guid.NewGuid(), true));
            Assert.AreEqual(task.isComplete, true);
        }
        [Test]
        public void getDate()
        {
            TodoListExtension ext = new TodoListExtension();
            ext.addTask("t1");
            ext.addTask("t2");
            ext.addTask("t3");
            ext.addTask("t4");

            var expectedDateList = ext.todoListEx.Select(task => task.dateTime).ToList();

            //Act
            var result = ext.GetDateTime();

            Assert.AreEqual(expectedDateList, result);
        }
    }
}
