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
        public void FirstTest()
        {
            TodoListExtension ext = new TodoListExtension();

            IdTask task = ext.Add("test");
            
            Assert.That(task, Is.EqualTo(ext.Get(task.Id)));
        }

        [Test]
        public void SecondTest()
        {
            TodoListExtension ext = new TodoListExtension();

            IdTask task = ext.Add("test");
            ext.Rename(task.Id, "anotherName");

            Assert.That("anotherName", Is.EqualTo(task.Name));
        }

        [Test]
        public void ThirdTest()
        {
            TodoListExtension ext = new TodoListExtension();

            IdTask task = ext.Add("test");

            ext.Complete(task.Id);

            Assert.That(task.Completed, Is.EqualTo(true));
        }

        [Test]
        public void FourthTest()
        {
            TodoListExtension ext = new TodoListExtension();

            IdTask task = ext.Add("test");

            string tasks = ext.PrintCreated();

            Assert.That(tasks, Is.Not.EqualTo(""));
        }

    }
}
