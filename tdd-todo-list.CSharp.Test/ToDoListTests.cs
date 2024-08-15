using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoListTests
    {
        //1. I want to add tasks to my todo list.
        [Test]
        public void AddTaskTest()
        {
            string task = "clean";
            bool expected = true;
            TodoList todoList = new TodoList();

            bool taskAdded = todoList.AddTask(task);

            Assert.AreEqual(expected, taskAdded);
        }

        //7. I want to remove tasks from my list.
        [Test]
        public void RemoveTaskTest()
        {
            string task = "shopping";
            string task2 = "join zoom";
            bool expected = true;
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.AddTask(task2);

            bool taskRemoved = todoList.RemoveTask(task);

            Assert.AreEqual(expected, taskRemoved);
        }

        //2. I want to see all the tasks in my todo list.
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

        //3. I want to change the status of a task between incomplete and complete.
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

        //4. I want to be able to get only the complete tasks.
        [Test]
        public void GetCompleteTasksTest()
        {
            string task1 = "blabla";
            string taskStatus1 = "complete";
            string task2 = "helloworld";
            string taskStatus2 = "complete";
            Dictionary<string, string> expectedList = new Dictionary<string, string>
            {
                { task1, taskStatus1 },
                { task2, taskStatus2 }
            };

            TodoList todoList = new TodoList();
            todoList.AddTask(task1);
            todoList.AddTask(task2);

            Dictionary<string, string> actualList = todoList.ViewCompleteTasksList;

            Assert.AreEqual(expectedList, actualList);

        }

        //6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [Test]
        public void SearchListTest()
        {
            string task = "clean";
            string task2 = "shopping";
            string expected = "shopping";
            TodoList todoList = new TodoList();
            todoList.AddTask(task);
            todoList.AddTask(task2);

            string actualSearchMessage = todoList.SearchList(task2);

            Assert.AreEqual(expected, actualSearchMessage);
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