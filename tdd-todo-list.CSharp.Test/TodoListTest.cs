using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoListTest
    {

        [TestCase("Clean", true)]
        [TestCase("Make bed", true)]
        public void AddTaskTest(string name, bool expected)
        {
            TodoTask task = new TodoTask(name);
            List<TodoTask> tasks = new List<TodoTask>();
            TodoList todoList = new TodoList(tasks);

            bool actual = todoList.AddTask(task);  

            Assert.That(actual == expected);
        }

        [Test]
        public void RemoveTaskTest()
        {

            
            List<TodoTask> tasks = new List<TodoTask>();
            TodoList todoList = new TodoList(tasks);

            TodoTask todoTask1 = new TodoTask("Clean", false);
            TodoTask todoTask2 = new TodoTask("Make bed", true);
            TodoTask todoTask3 = new TodoTask("Brush Teeth", true);

            todoList.AddTask(todoTask1);
            todoList.AddTask(todoTask2);

            bool actual1 = todoList.RemoveTask(todoTask1);
            bool actual2 = todoList.RemoveTask(todoTask2);
            bool actual3 = todoList.RemoveTask(todoTask3);

            Assert.That(actual1, Is.EqualTo(true));
            Assert.That(actual2, Is.EqualTo(true));
            Assert.That(actual3, Is.EqualTo(false));

        }

        [TestCase("Clean", true, false)]
        [TestCase("Make bed",false, true)]
        public void ChangeStatus(string name, bool completed, bool newStatus)
        {
            TodoTask task = new TodoTask(name, completed);

            List<TodoTask> tasks = new List<TodoTask>();
            TodoList todoList = new TodoList(tasks);

            todoList.ChangeStatus(task, newStatus);

            Assert.That(task.Completed, Is.EqualTo(newStatus));
        }

        [Test]
        public void SearchTaskTest()
        {
            TodoTask task1 = new TodoTask("Clean");
            TodoTask task2 = new TodoTask("Brush");
            TodoTask task3 = new TodoTask("Wash");

            List<TodoTask> tasks = new List<TodoTask>();
            TodoList todoList = new TodoList(tasks);
            todoList.AddTask(task1);
            todoList.AddTask(task2);

            string acutalTask1 = todoList.SearchTask(task1);
            string acutalTask2 = todoList.SearchTask(task2);
            string acutalTask3 = todoList.SearchTask(task3);

            Assert.That("Success", Is.EqualTo(acutalTask1));
            Assert.That("Success", Is.EqualTo(acutalTask2));
            Assert.That("Not found", Is.EqualTo(acutalTask3));
        }





    }
}