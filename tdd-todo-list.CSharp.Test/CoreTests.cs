using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            TodoList todoList = new TodoList();
            string taskName = "Homework";

            todoList.AddTask(taskName);

            Assert.That(todoList.Tasks[0].Name, Is.EqualTo(taskName));
            Assert.That(todoList.Tasks[0].ID, Is.EqualTo(0));
            Assert.That(todoList.TaskCount, Is.EqualTo(1));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();
            string taskName1 = "Homework";
            string taskName2 = "Laundry";

            todoList.AddTask(taskName1);
            todoList.AddTask(taskName2);

            Assert.That(todoList.Tasks.Count, Is.EqualTo(2));
        }
    }
}