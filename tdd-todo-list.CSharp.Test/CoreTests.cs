using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("Feed Pet")]
        public void AddTaskTest(string task)
        {
            //arrange
            TodoList tasks = new TodoList();
            bool expectedSuccess = true;
            bool expectedFailure = false;

            //act
            bool resultInitialAdd = tasks.Add(task);
            bool resultDuplicateAdd = tasks.Add(task);

            //assert
            Assert.That(resultInitialAdd, Is.EqualTo(expectedSuccess));
            Assert.That(resultDuplicateAdd, Is.EqualTo(expectedFailure));
        }
    }
}