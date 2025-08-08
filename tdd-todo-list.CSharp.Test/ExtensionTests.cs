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
        public void GetIDTest()
        {
            _extension.Add("test1");
            _extension.Add("test2");

            TodoObject getFirst = _extension.GetByID(0);
            TodoObject getSecond = _extension.GetByID(1);

            TodoObject expectedFirst = _extension.Todo[0];
            TodoObject expectedSecond = _extension.Todo[1];

            Assert.That(getFirst == expectedFirst && getSecond == expectedSecond);
        }

        [Test]
        public void UpdateNameTest() {
            

            string newName = "new name for task";
            _extension.UpdateName(1, newName);

            string actualName = _extension.GetByID(1).TaskStr;

            Assert.That(actualName == newName);

        }
        [Test]
        public void CompleteTaskTest() 
        {
            DateTime completeDate = DateTime.Now;
            TodoObject todoObject = _extension.Todo[0];
            _extension.CompleteTask(0, completeDate);

            Assert.That(todoObject.CompleteDate == completeDate && todoObject.Completed == true);
        }
        [Test]
        public void SeeCreatedDateTest()
        {
            DateTime createDate = DateTime.Today;
            _extension.Add("New task created now", createDate);

            DateTime createDateFromList = _extension.SeeCreatedDate(2);

            Assert.That(createDate == createDateFromList);
        }
        [Test]
        public void SeeCompletedDateTest()
        {
            DateTime completeDate = DateTime.Now;
            _extension.CompleteTask(2, completeDate);


            DateTime completedDateFromList = _extension.SeeCompletedDate(2);

            Assert.That(completeDate == completedDateFromList);
        }
        [Test]
        public void SeeCompletedLengthTest()
        {
            DateTime completeDate = DateTime.Now;
            _extension.CompleteTask(2, completeDate);


            DateTime completedDateFromList = _extension.SeeCompletedDate(2);

            Assert.That(completeDate == completedDateFromList);
        }
        [Test]
        public void GetLongestCompletedTaskTest()
        {

        }
        [Test]
        public void GetShortestCompletedTaskTest()
        {

        }
        [Test]
        public void Over5DaysTest()
        {

        }
        [Test]
        public void ListByCategoryTest()
        {

        }
    }
}
