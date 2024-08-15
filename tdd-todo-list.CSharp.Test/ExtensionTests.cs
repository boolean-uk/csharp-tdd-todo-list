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
        public void schouldGetTask()
        {
            //SetUp
            TodoListExtension todolist = new TodoListExtension();
            TaskItem task = new TaskItem("Go to work", Status.INCOMPLETE);
            todolist.AddTask(1, task);
           
            //Execution
            TaskItem result = todolist.GetTask(1);
            //Verify

            Assert.IsTrue(result == task);
        }        
        
        [Test]
        public void schouldUpdateName()
        {

            //SetUp
            TodoListExtension todolist = new TodoListExtension();
            TaskItem task = new TaskItem("Go to work", Status.INCOMPLETE);
            todolist.List.Add(1, task);

            //Execution
            todolist.UpdateName(1, "Throw garbage");

            //Verify

            Assert.IsTrue(todolist.GetTask(1) == task);
        }        
        
        [Test]
        public void schouldChangeStatustoComplete()
        {
            //SetUp
            TodoListExtension todolist = new TodoListExtension();
            TaskItem task = new TaskItem("Go to work", Status.INCOMPLETE);
            todolist.List.Add(1, task);

            //Execution
            Status result = todolist.ChangeStatus(1);

            //Verify

            Assert.IsTrue(result == Status.COMPLETE);
        }        
        
        [Test]
        public void schouldChangeStatustoInComplete()
        {
            //SetUp
            TodoListExtension todolist = new TodoListExtension();
            TaskItem task = new TaskItem("Go to work", Status.COMPLETE);
            todolist.List.Add(1, task);

            //Execution
            Status result = todolist.ChangeStatus(1);

            //Verify

            Assert.IsTrue(result == Status.INCOMPLETE);
        }        
        
       // [Test]
        //public void schouldSeeDateAndTime()
        //{
            //SetUp
          //  TodoListExtension todolist = new TodoListExtension();

            //Execution
            //Verify

            //Assert.Fail();
        //}        
        
  
    }
}
