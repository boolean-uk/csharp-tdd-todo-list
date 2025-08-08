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
            DateTime currentDate = DateTime.Now;
            DateTime oneYearAgo = currentDate.AddYears(-1);
            _extension.Add("Task one year ago", oneYearAgo);

            TodoObject expected = _extension.GetByID(3);
            TodoObject? longest = _extension.GetLongestCompletedTask();
            Assert.That(longest == expected);
        }
        [Test]
        public void GetShortestCompletedTaskTest()
        {
            TodoObject expected = _extension.GetByID(2);
            TodoObject? shortest = _extension.GetShortestCompletedTask();
            Assert.That(shortest == expected);
        }

        private bool EquivalentLists(List<TodoObject> list1, List<TodoObject> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] != list2[i]) { return false; }
            }
            return true;
        }

        [Test]
        public void Over5DaysTest()
        {
            DateTime complete = DateTime.Now;
            DateTime created = complete.AddDays(-7);
            _extension.Add("Task one week ago", created);
            TodoObject thistask = _extension.GetByID(4);
            TodoObject oneyeartask = _extension.GetByID(3);
            List<TodoObject> expectedTasks = new List<TodoObject>();
            expectedTasks.Add(thistask);
            expectedTasks.Add(oneyeartask);
            List<TodoObject> over5Days = _extension.GetTasksOver5Days();

            Assert.IsTrue(EquivalentLists(over5Days, expectedTasks));
        }
        [Test]
        public void ListByCategoryTest()
        {
            TodoObject task0 = _extension.GetByID(0);
            TodoObject task1 = _extension.GetByID(1);
            TodoObject task2 = _extension.GetByID(2);
            task0.Category = "first category";
            task1.Category = "first category";
            task2.Category = "second category";
            List<TodoObject> expected1Category = new List<TodoObject>();
            List<TodoObject> expected2Category = new List<TodoObject>();
            expected1Category.Add(task0);
            expected1Category.Add(task1);
            expected2Category.Add(task2);
            List<TodoObject> actual1 = _extension.ListByCategory("first category");
            List<TodoObject> actual2 = _extension.ListByCategory("second category");
            Assert.IsTrue(EquivalentLists(actual1, expected1Category) && EquivalentLists(actual2, expected2Category));

        }
    }
}
