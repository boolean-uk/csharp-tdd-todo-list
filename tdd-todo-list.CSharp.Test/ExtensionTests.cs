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
        public void searchByIDTest()
        {
           Tuple<string, bool, int> task1 = new Tuple<string, bool, int>("Eat", false, 1);

            _extension.Add("Eat");
            _extension.Add("Sleep");
            _extension.Add("C#");
            _extension.Add("Repeat");

            _extension.FindTaskByID(1);

            Assert.That(_extension.FindTaskByID(1).Equals(task1));

        }



        [Test]
        public void updateNameTest()
        {
            Tuple<string, bool, int> task1 = new Tuple<string, bool, int>("Eat", false, 1);

            _extension.Add("Eat");
            _extension.Add("Sleep");
            _extension.Add("C#");
            _extension.Add("Repeat");

            _extension.UpdateName(1, "Work out");

            Assert.That(_extension.FindTaskByID(1).Item1, Is.EqualTo("Work out"));
        }


        [Test]
        public void updateStatusTest()
        {
            Tuple<string, bool, int> task1 = new Tuple<string, bool, int>("Eat", false, 1);

            _extension.Add("Eat");
            _extension.Add("Sleep");
            _extension.Add("C#");
            _extension.Add("Repeat");

            _extension.UpdateStatus(2, true);

            Assert.That(_extension.FindTaskByID(2).Item2, Is.EqualTo(true));
        }



        [Test]
        public void dateTimeTest()
        {
            Tuple<string, bool, int> task1 = new Tuple<string, bool, int>("Eat", false, 1);

            _extension.Add("Eat");
            _extension.Add("Sleep");
            _extension.Add("C#");
            _extension.Add("Repeat");
            DateTime dt = DateTime.MinValue;

            _extension.UpdateStatus(2, true);

            Assert.That(!_extension.findDate(3).Equals(dt));
        }


    }
}
