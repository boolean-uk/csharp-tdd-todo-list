using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoListTests
    {

        [Test]
        public void AddTaskTest()
        {
            string task = "clean";
            bool expected = true;
            TodoList todoList = new TodoList();

            bool taskAdded = todoList.AddTask(task);

            Assert.AreEqual(expected, taskAdded);
        }

        [Test]
        public void ViewToDoListTest()
        {

            string task = "clean";
            string expected = "clean";
            TodoList todoList = new TodoList();

            string actualList = todoList.ViewTodoList();

            Assert.AreEqual(expected, actualList);

        }
    }
}