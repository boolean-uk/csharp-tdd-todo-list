using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddingATask()
        {
            TodoList todoList = new TodoList();

            todoList.Add("Task1", true);

            Assert.IsTrue(todoList.GetTodoList().ContainsKey("Task1"));
            Assert.AreEqual(true, todoList.GetTodoList()["Task1"]);
        }

        [Test]
        public void ListingAllTasks()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", true);
            todoList.Add("Task2", true);
            todoList.Add("Task3", false);

            List<string> allTasks = todoList.ListAllTasks();

            Assert.AreEqual(3, allTasks.Count);
            Assert.Contains("Task1", allTasks);
            Assert.Contains("Task2", allTasks);
            Assert.Contains("Task3", allTasks);
        }

        [Test]
        public void ChangingStatus()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", true);

            todoList.ChangeStatus("Task1", false);

            Assert.AreEqual(false, todoList.GetTodoList()["Task1"]); 
        }

        [Test]
        public void GettingCompletedTasks()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", false); 
            todoList.Add("Task2", true); 
            todoList.Add("Task3", false);

            List<string> completedTasks = todoList.ListAllCompletedTasks(); 

            Assert.AreEqual(1, completedTasks.Count);
            Assert.Contains("Task2", completedTasks);
        }

        [Test]
        public void GettingIncompleteTasks()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", false); 
            todoList.Add("Task2", true); 
            todoList.Add("Task3", false);

            List<string> incompleteTasks = todoList.ListAllIncompleteTasks();  

            Assert.AreEqual(2, incompleteTasks.Count);
            Assert.Contains("Task1", incompleteTasks);
        }

        [Test]
        public void SearchingForATask()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", true); 
            todoList.Add("Task2", true); 
            todoList.Add("Task3", false);

            var result = todoList.SearchTask("Task2");

            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [Test]
        public void RemovingTask()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task1", true);
            todoList.Add("Task2", true);
            todoList.Add("Task3", false);

            todoList.RemoveTask("Task1");

            Assert.AreEqual(2, todoList.GetTodoList().Count()); 
        }

        [Test]
        public void ListAllTasksAscendingOrder()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task2", true);
            todoList.Add("Task3", true);
            todoList.Add("Task1", true);

            todoList.OrderTasksAscending();

            var expectedOrder = new List<string> { "Task1", "Task2", "Task3" };
            CollectionAssert.AreEqual(expectedOrder, todoList.ListAllTasks());
        }

        [Test]
        public void ListAllTasksDescendingOrder()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Task2", true);
            todoList.Add("Task3", true);
            todoList.Add("Task1", true);

            todoList.OrderTasksDescending();

            var expectedOrder = new List<string> { "Task3", "Task2", "Task1" };
            CollectionAssert.AreEqual(expectedOrder, todoList.ListAllTasks());
        }
    }
}