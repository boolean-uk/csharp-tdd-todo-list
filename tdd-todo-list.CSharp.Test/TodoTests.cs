using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoTests
    {
         

        [TestCase("Write some code")]
        [TestCase("Write some more code")]
        [TestCase("Shop for groceries")]
        public void TestAddTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = name;

            todo.AddTask(name, false);

            Assert.That(todo.SeeIfTaskExists(expected));            
        }

        [TestCase("Write some code", false)]
        [TestCase("Write some more code", true)]
        [TestCase("Shop for groceries", false)]
        public void TestToogleTask(string name, bool startingStatus)
        {
            //arrange
            TodoList todo = new TodoList();
            todo.AddTask(name, startingStatus); 
            bool expected = !startingStatus;

            bool result = todo.ToogleTaskStatus(name);

            Assert.That(result == expected);
        }
    }
}