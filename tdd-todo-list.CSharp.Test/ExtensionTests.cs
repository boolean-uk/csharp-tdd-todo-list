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

        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [SetUp]
        public void SetUp()
        {
            Task.ResetCounter();
        }

        [Test]
        public void SearchByIdTest()
        {
            _extension.tasks.Add(new Task("Vacuum"));
            _extension.tasks.Add(new Task("Dishes"));
            _extension.tasks.Add(new Task("Jog"));   
            _extension.tasks.Add(new Task("Lunch")); 

            Task foundTask = _extension.SearchById(3);
            Assert.That(foundTask._name, Is.EqualTo("Jog"));
        }

        [Test]
        public void SetNameByIdTest()
        {
            _extension.tasks.Add(new Task("Vacuum"));
            _extension.tasks.Add(new Task("Dishes"));
            _extension.tasks.Add(new Task("Jog"));   
            _extension.tasks.Add(new Task("Lunch")); 

            Assert.True(_extension.setNameById(3, "Climb Mount Everest"));
            Task updatedTask = _extension.SearchById(3);
            Assert.That(updatedTask._name, Is.EqualTo("Climb Mount Everest"));
        }

        [Test]
        public void SetStatusByIdTest()
        {
            _extension.tasks.Add(new Task("Vacuum"));
            _extension.tasks.Add(new Task("Dishes"));
            _extension.tasks.Add(new Task("Jog"));   
            _extension.tasks.Add(new Task("Lunch")); 

            Assert.True(_extension.setStatusById(3, true));
            Task updatedTask = _extension.SearchById(3);
            Assert.That(updatedTask._status, Is.True);
        }

        [Test]
        public void CreatedTaskTest()
        {
            Task task = new Task("Vacuum");
            DateTime created = task._created;
            var timeDifference = DateTime.Now - created;
            Assert.That(timeDifference.TotalMinutes, Is.LessThan(1));
        }
    }

}
