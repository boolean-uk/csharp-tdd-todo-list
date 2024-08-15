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
    public class ExtentionTests
    {
        [TestCase("something", 2)]
        [TestCase("fly", 2)]
        [TestCase("climb", 2)]
        [TestCase("repeat", 2)]

        public void GetTaskById(string task, int id)
        {
            TodoListExtension todo = new TodoListExtension();
            string otherTask1 = "example";
            string otherTask2 = "dance";

            //Assumes the id is generated in the class
            todo.Add(otherTask1);
            todo.Add(otherTask2);
            todo.Add(task);

            string result = todo.GetTask(id);
            Assert.That(result, Is.EqualTo(task));
        }

        [TestCase("something", 0)]
        [TestCase("fly", 1)]
        [TestCase("climb", 0)]
        [TestCase("repeat", 1)]

        public void ChangeTaskNameById(string newTaskName, int id)
        {
            TodoListExtension todo = new TodoListExtension();
            string otherTask1 = "example";
            string otherTask2 = "dance";

            todo.Add(otherTask1);
            todo.Add(otherTask2);

            bool result = todo.ChangeTaskName(id, newTaskName);
            Assert.That(result, Is.True);
        }

        [TestCase("something", 3)]
        [TestCase("fly", 2)]
        [TestCase("climb", 5)]
        [TestCase("repeat", 2)]

        public void ChangeTaskNameByIdFailed(string newTaskName, int id)
        {
            TodoListExtension todo = new TodoListExtension();
            string otherTask1 = "example";
            string otherTask2 = "dance";

            todo.Add(otherTask1);
            todo.Add(otherTask2);

            bool result = todo.ChangeTaskName(id, newTaskName);
            Assert.That(result, Is.False);
        }


    }
}
