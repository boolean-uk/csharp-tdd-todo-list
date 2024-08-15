using NUnit.Framework;
using System.Threading.Tasks;
using Core;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            TodoList todoList = new TodoList();
            
            todoList.AddTask("Hoover");

            Assert.IsTrue(todoList.Tasks.Count() == 1);
        }

        [Test]
        public void CheckStatusFalse()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");

            Assert.IsFalse(todoList.Tasks[0].IsComplete);
        }

        [Test]
        public void CheckStatusTrue()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;

            Assert.IsTrue(todoList.Tasks[0].IsComplete);
        }

        [Test]
        public void GetCompleteTasksCount()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            Assert.IsTrue(todoList.GetCompleteTasks().Count == 1);
        }

        [Test]
        public void GetCompleteTasksCorrectTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            List<TaskItem> completeTasks = todoList.GetCompleteTasks();


            Assert.IsTrue(completeTasks[0].Name == "Hoover");
        }

        [Test]
        public void GetIncompleteTasksCount()
        {
            TodoList todoList = new TodoList();

            todoList.AddTask("Hoover");
            todoList.AddTask("Clean Kitchen");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            Assert.IsTrue(todoList.GetIncompleteTasks().Count == 2);
        }

        [Test]
        public void GetIncompleteTasksCorrectTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Hoover");
            todoList.Tasks[0].IsComplete = true;
            todoList.AddTask("Run");

            List<TaskItem> incompleteTasks = todoList.GetIncompleteTasks();

            Assert.IsTrue(incompleteTasks[0].Name == "Run");
        }

        [Test]
        public void SearchTaskSuccess()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");

            bool taskIsFound = todoList.SearchTask("Study");

            Assert.IsTrue(taskIsFound);
        }

        [Test]
        public void SearchTaskFail()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");

            bool taskIsFound = todoList.SearchTask("Run");

            Assert.IsFalse(taskIsFound);
        }

        [Test]
        public void RemoveTaskCount()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");
            todoList.AddTask("Run");
            todoList.AddTask("Sleep");
            todoList.RemoveTask("Study");

            Assert.IsTrue(todoList.Tasks.Count() == 2);
        }

        [Test]
        public void RemoveTask()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");
            todoList.RemoveTask("Study");

            bool taskIsFound = todoList.SearchTask("Run");

            Assert.IsFalse(taskIsFound);
        }

        [Test]
        public void OrderTasksAscending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");
            todoList.AddTask("Breakfast");
            todoList.AddTask("Walk dog");


            List<TaskItem> orderedList = todoList.OrderTasks(true);

            Assert.IsTrue(orderedList[0].Name == "Breakfast");
        }

        [Test]
        public void OrderTasksDescending()
        {
            TodoList todoList = new TodoList();
            todoList.AddTask("Study");
            todoList.AddTask("Breakfast");
            todoList.AddTask("Walk dog");


            List<TaskItem> orderedList = todoList.OrderTasks(false);

            Assert.IsTrue(orderedList[0].Name == "Walk dog");
        }
    }
}