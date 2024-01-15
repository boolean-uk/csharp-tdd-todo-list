using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;

        public void AddElements()
        {
            _extension.Add("Code", false);
            _extension.Add("Commit", false);
            _extension.Add("Push", true);
            _extension.Add("Pull", true);
        }

        [Test]
        public void FirstTest()
        {
            _extension = new TodoListExtension();

            AddElements();

            Task getTask = _extension.GetTaskById(2);

            Assert.AreEqual(getTask.TaskName,"Push" );
        }

        [Test]
        public void SecondTest()
        {
            _extension = new TodoListExtension();

            AddElements();

            int tempId = _extension.ToDo[2].Id;
            Task getTask = _extension.UpdateNameById(tempId, "Save");

            Assert.AreEqual(getTask.TaskName, "Save");
        }

        [Test]
        public void ThirdTest()
        {
            _extension = new TodoListExtension();

            AddElements();

            int tempId = _extension.ToDo[2].Id;
            bool tempBool = !_extension.ToDo[2].bIsComplete;
            Task getTask = _extension.UpdateStatusById(tempId, tempBool);

            Assert.AreEqual(getTask.bIsComplete, tempBool);
        }

        [Test]
        public void FourthTest()
        {
            _extension = new TodoListExtension();

            AddElements();

            bool didPrint = _extension.PrintDateCreated();

            Assert.IsTrue(didPrint);
        }
    }
}
