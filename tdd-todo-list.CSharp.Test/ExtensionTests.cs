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
            task1.taskname = "correct one";
            UserTask task2 = new UserTask(99);
            task2.taskname = "not this one mate";

            list.Add(task1);
            list.Add(task2);

            //act
            list.FindTaskById(id);

            string expected = task1.taskname+" with ID: "+task1.id.ToString()+" found!";

            string result = list.FindTaskById(id);

            //assert
            Assert.IsTrue(result == expected);
            
        }

        [TestCase(1, "Supertest")]
        public void ChangeTaskNameTest(int id, string taskname)
        {
            TodoListExtension list = new TodoListExtension();
            UserTask task1 = new UserTask(24);
            task1.taskname = "correct one";
            UserTask task2 = new UserTask(99);
            task2.taskname = "not this one mate";

            list.Add(task1);
            list.Add(task2);

            //act
            string expected = "Test ID: "+id.ToString() + " is now called: " + taskname;

            string result = list.ChangeTaskName(id, taskname);

            Assert.IsTrue(result == expected);
        }
    }
}
