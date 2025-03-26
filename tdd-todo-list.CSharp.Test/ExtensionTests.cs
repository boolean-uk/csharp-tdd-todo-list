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
        public void TestAdd()
        {
            TodoListExtension extension = new TodoListExtension();
            extension.Add("Test");

            Assert.That(extension.Tasks.Count, Is.EqualTo(1));
            Assert.That(extension.Tasks[0].ID, Is.EqualTo(0));
            Assert.That(extension.Tasks[0].Name, Is.EqualTo("Test"));
        }

        [Test]
        public void TestGetByID()
        {
            TodoListExtension extension = new TodoListExtension();
            extension.Add("Test");

            Assert.That(extension.Tasks.Count, Is.EqualTo(1));
            Assert.That(extension.Tasks[0], Is.EqualTo(extension.GetByID(0)));
        }

        [Test]
        public void TestUpdate()
        {
            TodoListExtension extension = new TodoListExtension();
            extension.Add("Test");

            Assert.That(extension.Tasks[0].Name, Is.EqualTo("Test"));
            Assert.That(extension.Tasks[0].ID, Is.EqualTo(0));

            extension.Update(0, "RenamedTest");

            Assert.That(extension.Tasks[0].Name, Is.EqualTo("RenamedTest"));
            Assert.That(extension.Tasks[0].ID, Is.EqualTo(0));
        }


        [Test]
        public void TestChangeStatus()
        {
            TodoListExtension extension = new TodoListExtension();
            extension.Add("Test");

            extension.ChangeStatus(extension.Tasks[0].ID);

            Assert.That(extension.Tasks[0].Completed, Is.True);
        }

        [Test]
        public void TestTimeCreated()
        {
            TodoListExtension extension = new TodoListExtension();
            extension.Add("Test");

            // Could also check for seconds/minute/hour but could fail depending on when test is run..
            Assert.That(extension.Tasks[0].Created.Day, Is.EqualTo(DateTime.Now.Day));
            Assert.That(extension.Tasks[0].Created.Year, Is.EqualTo(DateTime.Now.Year));
        }
    }
}
