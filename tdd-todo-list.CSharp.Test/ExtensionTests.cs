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

    }
}
