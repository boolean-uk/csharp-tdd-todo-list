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
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }
        [Test]
        public void IdCheck()
        {
            TodoListExtension extension= new TodoListExtension();
        
            extension.AddTask("clean your room");

            extension.AddTask("do dishes");
            extension.AddTask("do homework");
            extension.AddTask("do groceries");
            string expected = "do homework";

            String result = extension.getTaskById(2);
            Assert.That(result, Is.EqualTo(expected));





        }

        [Test]
        public void NameCheck()
        {
            TodoListExtension extension = new TodoListExtension();
            String expected = "skip breakfast";
            extension.AddTask("wake up");
            extension.AddTask("brush teeth");
            extension.AddTask("eat breakfast");
            extension.UpdateName(2, "skip breakfast");
            String result=extension.getTaskById(2);

            Assert.That (result, Is.EqualTo(expected));

        }
        [Test]
        public void TestChangeStatusById()
        {
            TodoListExtension extension = new TodoListExtension();
            String expected = "complete";
            extension.AddTask("wake up");
            extension.AddTask("brush teeth");
            extension.AddTask("eat breakfast");
            String result = extension.UpdateStatusById(1);


            Assert.That(result == expected);
        }
    }
}
