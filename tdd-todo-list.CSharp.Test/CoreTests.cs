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
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id = todoList.Add("oppvask");

            // Assert
            Assert.That(todoList.Tasks.Count, Is.EqualTo(1));
        }

        [Test]
        public void RemoveTaskTest()
        {
            // Arrange
            TodoList todoList = new TodoList();

            // Act
            int id = todoList.Add("oppvask");
            todoList.Remove(id);

            // Assert
            Assert.That(todoList.Tasks.Count, Is.EqualTo(0));
        }

        [Test]
        public void GetAllTasksTest()
        {
            TodoList todoList = new TodoList();
            int id1 = todoList.Add("oppvask");
            int id2 = todoList.Add("oppvask2");

            List<TodoList.Task> allTasks = todoList.GetAll();

            Assert.That(allTasks.Count, Is.EqualTo(2));
        }
    }
}