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
        public void getTaskByUniqueID()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task", false);
            int id = task.Id;
            core.AddTaskToList(task);
            Assert.That(core.getIndividualTasks(id).Equals(task));
        }

        [Test]
        public void uppdateTaskNameByUniqueID()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task", false);
            int id = task.Id;
            core.AddTaskToList(task);
            core.getIndividualTasks(id).ContentText = "Hej";
            Assert.That(core.getIndividualTasks(id).ContentText.Equals("Hej"));
        }

        [Test]
        public void uppdateTaskStatusByUniqueID()
        {
            TodoList core = new TodoList();
            TodoTaskObj task = new TodoTaskObj("First task", false);
            int id = task.Id;
            core.AddTaskToList(task);
            core.getIndividualTasks(id).ChangeStatus();
            Assert.True(core.getIndividualTasks(id).Complete);
        }



    }
}
