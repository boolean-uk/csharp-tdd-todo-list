using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoTests
    {

        [TestCase("Write some code")]
        public void TestAddTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = name;

            todo.AddTask(name);

            Assert.That(todo.SeeIfTaskExists(expected));            
        }
    }
}