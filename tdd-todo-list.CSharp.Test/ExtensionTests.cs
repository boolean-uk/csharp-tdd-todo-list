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
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();

        }
        [Test]
        public void TestGet()
        {
            TodoListExtension core = new TodoListExtension();

            TodoTaskExstension todo1 = new TodoTaskExstension("Brap", "Skibidi");

            core.AddTask(todo1);

            var id = todo1.Id;

            TodoTaskExstension query = core.GetTaskByID(id);

            Assert.AreEqual(core.GetTaskByID(id), todo1);
        }


        [Test]
        public void TestUpdateName()
        {
            TodoListExtension core = new TodoListExtension();

            TodoTaskExstension todo1 = new TodoTaskExstension("Brap", "Skibidi");

            core.AddTask(todo1);

            core.ChangeNameByID(todo1.Id, "Ohio");

            Assert.AreEqual(core.Tasks[0].Name, "Ohio");

        }

        [Test]
        public void TestChangeStatus()
        {
            TodoListExtension core = new TodoListExtension();

            TodoTaskExstension todo1 = new TodoTaskExstension("Brap", "Skibidi");

            core.AddTask(todo1);

            core.ChangeStatusByID(todo1.Id);

            Assert.IsTrue(core.Tasks[0].Status);
        }

        [Test]
        public void TestDateFunctionality()
        {
            TodoListExtension core = new TodoListExtension();

            TodoTaskExstension todo1 = new TodoTaskExstension("Brap", "Skibidi");

            core.AddTask(todo1);

            DateTime date = todo1.Created;

            Assert.AreEqual(date.Minute, DateTime.Now.Minute);

        }
    }
}
