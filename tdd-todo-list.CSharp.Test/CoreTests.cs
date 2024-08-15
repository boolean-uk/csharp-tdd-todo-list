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
    }
}