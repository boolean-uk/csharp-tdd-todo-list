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
        

    }
}