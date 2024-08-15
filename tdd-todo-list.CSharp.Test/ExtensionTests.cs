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
        public void FindTaskByIDTest()
        {
            TodoListExtension toDo = new TodoListExtension();
            int taskID = toDo.AddTask("complete extension");

            TaskItem taskItem = toDo.FindTask(taskID);

            Assert.That(taskItem.Description.Equals("complete challenge"));
        }
    }
}
