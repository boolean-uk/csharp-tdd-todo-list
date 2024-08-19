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
        public void SearchByIDTest()
        {
            //init
            TodoList extension = new TodoList();
            string id = "2T";
            extension.Add("task 1");
            extension.Add("task 2");
            extension.Add("task 3");

            //run
            string result = extension.SearchById(id);

            //assert
            Assert.IsTrue(result == "task 2");
        }
        [Test]
        public void UpdateNameByIdTest()
        {
            //init
            TodoList extension = new TodoList();
            extension.Add("task 1");
            string id = "2T";
            string newName = "NAME!";
            extension.Add("task 2");
            extension.Add("task 3");

            //run
            string result = extension.UpdateNameByID(id,newName);

            //assert
            Assert.IsTrue(result == newName);
        }
        [TestCase("2T", true)]
        public void ChangeStatusByIDTest(string id, bool status)
        {
            //init
            TodoList core = new TodoList();
            core.Add("task");
            core.Add("task1");
            core.Add("task2");
            core.Add("task3");

            //run
            core.ChangeStatusByID(id);

            //assert
            Assert.IsTrue(core.ToDoDict["2T"].IsComplete == status);
        }
        [Test]
        public void getDateAndTime()
        {
            //init
            TodoList core = new TodoList();
            core.Add("task");
            Thread.Sleep(3000);
            core.Add("task1");

            //run
            string firstTaskDate = core.ToDoDict["1T"].DateAndTime.ToString();
            string secondTaskDate = core.ToDoDict["2T"].DateAndTime.ToString();

            //assert
            Assert.False(firstTaskDate.Equals(secondTaskDate));
        }

    }
}
