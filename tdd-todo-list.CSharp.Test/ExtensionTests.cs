using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;
using Type = tdd_todo_list.CSharp.Main.Type;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void TestgetById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoTask givenTask = ToDoList.getById(1);

            Assert.That(givenTask.Name == "wash");
            Assert.IsTrue(ToDoList.getById(4) == null);
        }

        [Test]
        public void TestUpdateById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoList.UpdateById(1, "car wash");

            Assert.That(ToDoList.Todo[1].Name == "car wash");

        }

        [Test]
        public void TestUpdateStatusById()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            ToDoList.Add("trash");
            ToDoList.Add("clean");

            ToDoList.UpdateStatusById(1, true);

            Assert.IsTrue(ToDoList.Todo[1].Status);
        }

        [Test]
        public void TestTimeCreated()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");
            DateTime now = DateTime.Now;

            Assert.That(ToDoList.getById(1).TimeCreated != default(DateTime));
        }

        [Test]
        public void TestTimeFinished()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");

            Assert.That(ToDoList.getById(1).TimeFinished == default(DateTime));

            ToDoList.getById(1).markAsFinished();

            Assert.That(ToDoList.getById(1).TimeFinished != default(DateTime));
        }

        [Test]
        public void TestTypeOfTask()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash");

            Assert.That(ToDoList.getById(1).TypeOfTask == Main.Type.Standard);
        }

        [Test]
        public void TestListByCategory()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("wash", Type.Admin);
            ToDoList.Add("wash", Type.Admin);
            ToDoList.Add("wash", Type.Study);
            ToDoList.Add("wash", Type.Work);
            ToDoList.Add("wash", Type.Study);
            ToDoList.Add("wash", Type.Work);

            List<ToDoTask> test = ToDoList.ListAllByCategory();

            Assert.That(test[0].TypeOfTask == test[1].TypeOfTask);
            Assert.That(test[2].TypeOfTask == test[3].TypeOfTask);
            Assert.That(test[4].TypeOfTask == test[5].TypeOfTask);
        }

        [Test]
        public void TestLongestBeforeFinished()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("1", Type.Admin);
            ToDoList.Add("2", Type.Admin);
            ToDoList.Add("3", Type.Study);
            ToDoList.Add("4", Type.Work);
            ToDoList.getById(1).TimeCreated = DateTime.Now.AddMinutes(-4);
            ToDoList.getById(2).TimeCreated = DateTime.Now.AddMinutes(-5);
            ToDoList.getById(3).TimeCreated = DateTime.Now.AddMinutes(-6);
            ToDoList.getById(4).TimeCreated = DateTime.Now.AddMinutes(-7);

            ToDoList.getById(1).markAsFinished();
            ToDoList.getById(2).markAsFinished();
            ToDoList.getById(3).markAsFinished();
            ToDoList.getById(4).markAsFinished();
            ToDoTask longestOpen = ToDoList.LongestBeforeFinished();
            Assert.That(longestOpen.Name == "4");
            ToDoList.Add("5", Type.Work);
            ToDoList.getById(5).TimeCreated = DateTime.Now.AddMinutes(-10);

            longestOpen = ToDoList.LongestBeforeFinished();

            Assert.That(longestOpen.Name == "5");
        }

        [Test]
        public void TestShortestBeforeFinished()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("1", Type.Admin);
            ToDoList.Add("2", Type.Admin);
            ToDoList.Add("3", Type.Study);
            ToDoList.Add("4", Type.Work);
            ToDoList.getById(1).TimeCreated = DateTime.Now.AddMinutes(-4);
            ToDoList.getById(2).TimeCreated = DateTime.Now.AddMinutes(-5);
            ToDoList.getById(3).TimeCreated = DateTime.Now.AddMinutes(-6);
            ToDoList.getById(4).TimeCreated = DateTime.Now.AddMinutes(-7);

            ToDoList.getById(1).markAsFinished();
            ToDoList.getById(2).markAsFinished();
            ToDoList.getById(3).markAsFinished();
            ToDoList.getById(4).markAsFinished();
            ToDoTask longestOpen = ToDoList.ShortestBeforeFinished();
            Assert.That(longestOpen.Name == "1");
            ToDoList.Add("5", Type.Work);
            ToDoList.getById(5).TimeCreated = DateTime.Now.AddMinutes(-10);

            longestOpen = ToDoList.ShortestBeforeFinished();

            Assert.That(longestOpen.Name == "1");
        }

        [Test]
        public void TestListAllActiveFor5PlussDays()
        {
            TodoList ToDoList = new TodoList();

            ToDoList.Add("1", Type.Admin);
            ToDoList.Add("2", Type.Admin);
            ToDoList.Add("3", Type.Study);

            ToDoList.getById(1).TimeCreated = DateTime.Now.AddDays(-5);
            ToDoList.getById(3).TimeCreated = DateTime.Now.AddDays(-5);

            List<ToDoTask> list = ToDoList.ListAllActiveFor5PlussDays();

            Assert.That(list.Count == 2);


        }
    }
}
