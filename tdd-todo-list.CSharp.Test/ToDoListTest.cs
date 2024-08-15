using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ToDoListTest
    {

        [Test]
        public void TestaddTask()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }
    }
}