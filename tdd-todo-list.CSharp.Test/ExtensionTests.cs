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
        //private TodoListExtension _extension;
        //public ExtensionTests()
        //{
        //    _extension = new TodoListExtension();

        //}

        [TestCase(24)]
        public void FindTaskByIdTest(int id)
        {
            //Arrange
            TodoListExtension list = new TodoListExtension();
            UserTask task1 = new UserTask(24);
            UserTask task2 = new UserTask(99);

            list.Add(task1);
            list.Add(task2);

            

            list.FindTaskById(id);

            string expected = "Task with ID: "+task1.id.ToString()+ " is found";

            string result = list.FindTaskById(id);

            //
            Assert.IsTrue(result == expected);
            
        }
    }
}
