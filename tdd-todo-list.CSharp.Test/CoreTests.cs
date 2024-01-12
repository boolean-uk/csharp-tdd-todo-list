using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        
        TodoList todo;

        [SetUp]
        public void SetUp()
        {
            todo = new TodoList();

        }

        [Test]
        public void FirstTest()
        {
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 1);

            Assert.That(todo.todoList.Count, Is.EqualTo(1));
        }

        [Test]
        public void SecondTest()
        {
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 1);
            todo.AddTaskToList(new TodoList.Task("By food", false), 2);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 3);

            Assert.That(todo.todoList.Count, Is.EqualTo(3));
        }

        [Test]
        public void ThirdTest()
        {
            todo.AddTaskToList(new TodoList.Task("Call mother", false),1);
            todo.AddTaskToList(new TodoList.Task("By food", false), 2);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 3);

            List<string> list = new List<string>();

            list = todo.ShowList();

            Assert.That(list, Is.EqualTo(new List<string> { "Call mother", "By food", "Clean house" }));
        }

        [Test]
        public void FourthTest()
        {
            TodoList.Task task = new TodoList.Task("Call mother", false);
            todo.AddTaskToList(task, 1);
            bool isInThere = todo.ChangeStatus(1);

            Assert.That(isInThere, Is.EqualTo(true));
            Assert.That(todo.todoList[1].complete, Is.EqualTo(true));
        }

        [Test]
        public void FifthTest()
        {
            TodoList.Task task = new TodoList.Task("Call mother", false);

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            bool isInThere = todo.ChangeStatus(3);

            Assert.That(isInThere, Is.EqualTo(false));
        }

        [Test]
        public void SixthTest()
        {
            
        }


    }
}