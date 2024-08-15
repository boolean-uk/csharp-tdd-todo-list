using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            //arrange

            TodoList list = new TodoList();
            bool expected = true;

            //act
            bool result = list.Add("Grocery Shopping", 0);

            //assert
            Assert.That(expected == result);
        }
        
        [Test]
        public void GetTasksTest()
        {
            //arrange

            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 0);
            list.Add("Mow the lawn", 0);

            int expected = 3;

            //act
            List<string> taskList = list.GetTaskList();
            int result = taskList.Count;

            //assert
            Assert.That(expected == result);
        }

        [Test]
        public void ChangeStatusTest()
        {

            //arrange
            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 1 );
            list.Add("Mow the lawn", 0);

            bool expected = true;
            //act
            bool result = list.ChangeStatus("Grocery Shopping", 1);


            //assert
            Assert.That(expected == result);
        }

        [TestCase(3, false) ]
        [TestCase(2, true)]
        [TestCase(1, false)]
        [TestCase(4, false)]
        public void GetCompletedTest(int val, bool isExpected)
        {
            //arrange
            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 1);
            list.Add("task3", 0);
            list.Add("task4", 1);
            list.Add("task5", 0);

            int numCompleted = val;

            //act
            List<string> completedList = list.GetCompleted();

            int result = completedList.Count;

            bool isEqual = (numCompleted == result);

            //assert
            Assert.That(isExpected == isEqual);
        }

        [Test]
        public void GetIncompleteTest()
        {

            //arrange
            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 1);
            list.Add("task3", 0);
            list.Add("task4", 1);
            list.Add("task5", 0);

            int expected = 3;

            //act
            List<string> completedList = list.GetIncomplete();

            int result = completedList.Count;

            //assert
            Assert.That(expected == result);
        }

        [Test]
        public void SearchForTaskTest()
        {
            //arrange
            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 1);
            list.Add("task3", 0);
            list.Add("task4", 1);
            list.Add("task5", 0);

            bool expected = true;

            //act
            bool result = list.Search("Vacuum");


            //assert
            Assert.That(expected == result);
        }

        [Test]
        public void RemoveTest()
        {
            //arrange
            TodoList list = new TodoList();
            list.Add("Grocery Shopping", 0);
            list.Add("Vacuum", 1);
            list.Add("task3", 0);
            list.Add("task4", 1);
            list.Add("task5", 0);

            int expected = 4;

            //act
            list.Remove("Vacuum");

            int result = list.GetTaskList().Count;


            //assert
            Assert.That(expected == result);
        }

    }
}