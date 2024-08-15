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
            string taskStatus = "incomplete";
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

        [Test]
        public void ChangeTaskStatusTest()
        {
            string task = "clean";
            string taskStatus = "complete";
            string expected = "complete";
            TodoList todoList = new TodoList();
            todoList.AddTask(task);

            string actualStatus = todoList.ChangeTaskStatus(task, taskStatus);

            Assert.AreEqual(expected, actualStatus);
        }

        [Test]
        public void TaskDoesNotExistTest()
        {
            string noTask = "join zoom";
            string task = "clean";
            string task2 = "shopping";
            string expected = "Task does not exist";
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.AddTask(task2);

            string actualSearchMessage = todoList.SearchList(noTask);

            Assert.AreEqual(expected, actualSearchMessage);
        }
    }
}