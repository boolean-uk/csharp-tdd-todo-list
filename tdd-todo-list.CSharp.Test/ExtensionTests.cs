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
        TodoListExtension listExtension;

        [SetUp]
        public void SetUp()
        {
            listExtension = new TodoListExtension();

        }

        [Test]
        public void FirstTest()
        {
            // task 1

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean house", false), 2);
            listExtension.AddTaskToList(new TodoListExtension.Task("Call mother", false), 3);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean car", false), 4);

            string task = listExtension.SearchForTask(2);

            Assert.That(task, Is.EqualTo(new string("Task: Clean house, Status: incomplete")));



        }

        [Test]
        public void SecondTest()
        {
            // task 1

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean house", false), 2);
            listExtension.AddTaskToList(new TodoListExtension.Task("Call mother", false), 3);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean car", false), 4);

            string task = listExtension.SearchForTask(5);

            Assert.That(task, Is.EqualTo(new string("TaskID not found in todolist")));



        }


        [Test]
        public void ThirdTest()
        {
            // task 1

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean house", true), 2);
            listExtension.AddTaskToList(new TodoListExtension.Task("Call mother", false), 3);
            listExtension.AddTaskToList(new TodoListExtension.Task("Clean car", false), 4);

            string task = listExtension.SearchForTask(2);

            Assert.That(task, Is.EqualTo(new string("Task: Clean house, Status: complete")));



        }

        [Test]
        public void FourthTest()
        {
            //Task 2

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.EditTaskName(1, "Do stuff");

            Assert.That(testText, Is.EqualTo(new string("Task: By food was changed to: Do stuff")));
        }

        [Test]
        public void FifthTest()
        {
            //Task 2

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.EditTaskName(2, "Do stuff");

            Assert.That(testText, Is.EqualTo(new string("TaskID not found in todolist")));
        }

        [Test]  

        public void SixthTest()
        {
            //Task 3

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.ChangeStatus(1);

            Assert.That(testText, Is.EqualTo(new string("Task: By food Changed from incomplete to complete")));

            
        }

        [Test]
        public void SeventhTest()
        {
            //Task 3

            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.ChangeStatus(2);

            Assert.That(testText, Is.EqualTo(new string("TaskID not found in todolist")));

        }

        [Test]
        public void EighthTest()
        {
            //Task 4
            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.GetTimeCreated(1);
            string compareDate = DateTime.Now.ToString();

            Assert.That(testText, Is.EqualTo($"Task: By food was created: {compareDate}"));
        }

        [Test]
        public void NinthTest()
        {
            //Task 4
            listExtension.AddTaskToList(new TodoListExtension.Task("By food", false), 1);

            string testText = listExtension.GetTimeCreated(2);
            //string compareDate = DateTime.Now.ToString();

            Assert.That(testText, Is.EqualTo("TaskID not found in todolist"));
        }
    }
}
