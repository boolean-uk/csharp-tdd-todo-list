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
        
            extension.addTask("clean your room");
            extension.addTask("do dishes");
            extension.addTask("do homework");
            extension.addTask("do groceries");
            string expected = "do homework";

            String result = extension.getTaskById(2);
            Assert.That(result, Is.EqualTo(expected));





        }
    }
}
