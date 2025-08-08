using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        
        [Test]
        public void UpdatingName()
        {
            TodoList todoList = new TodoList();
            TaskItem taskItem1 = new TaskItem("vaske", "vaske kjeller", 1, "vasking");
            TaskItem taskItem2 = new TaskItem("rydde", "rydde kjøkken", 2, "rydding");

            todoList.AddTask(taskItem1);
            todoList.AddTask(taskItem2);

            todoList.UpdateNameById(taskItem1.Id, "nyttNavnForTest");

          

            Assert.That(taskItem1.Name.Equals("nyttNavnForTest"));
        }


    }
}
