using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("vacum")]
        [TestCase("clean")]
        [TestCase("make dinner")]
        [TestCase("sleep")]
        [TestCase("take out trash")]
        public void AddtoListTest(string task)
        {
            TodoList todoList = new TodoList();
            bool expectedResult = true;

            todoList.Add(task);
            Assert.Pass();
        }
    }
}