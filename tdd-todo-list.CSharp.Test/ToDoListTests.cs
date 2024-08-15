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
            string taskStatus = "Incomplete";
            string task2 = "shopping";
            Dictionary<string, string> expectedList = new Dictionary<string, string>
            {
                { task, taskStatus },
                { task2, taskStatus }
            };

            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.AddTask(task2);

            Dictionary<string, string> actualList = todoList.ViewToDoList;

            Assert.AreEqual(expectedList, actualList);

        }
    }
}