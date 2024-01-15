using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void TodoTaskCreationTest()
        {
            string myFirstTodoDescription = "Make the first test";
            TodoTask myFirstTodo = new TodoTask(myFirstTodoDescription);
            Assert.That(myFirstTodo.Description == myFirstTodoDescription);
            Assert.That(myFirstTodo.IsCompleted == false);
        }

        [Test]
        public void TodoTaskCompleteTest()
        {
            TodoTask myFirstTodo = new TodoTask("Test whether I can mark item as complete and incomplete");
            Assert.That(myFirstTodo.IsCompleted == false);
            myFirstTodo.Complete();
            Assert.That(myFirstTodo.IsCompleted == true);
            myFirstTodo.Incomplete();
            Assert.That(myFirstTodo.IsCompleted == false);
        }

        [Test]
        public void TodoListTaskCompleteTest()
        {
            TodoList myTodos = new TodoList();
            myTodos.AddTask("One");
            myTodos.AddTask("Two");
            myTodos.AddTask("Three");
            myTodos.AddTask("Four");
            myTodos.CompleteTask();
            Assert.That(myTodos.GetAllTasks().Count == 4);
            Assert.That(myTodos.GetCompletedTasks().Count == 1);
            Assert.That(myTodos.GetIncompleteTasks().Count == 3);
            Assert.That(myTodos.GetCompletedTasks().First().Description == "One");
            myTodos.IncompleteTask();
            Assert.That(myTodos.GetCompletedTasks().Count == 0);
            myTodos.CompleteTask(2);
            Assert.That(myTodos.GetCompletedTasks().First().Description == "Three");
            myTodos.CompleteTask();
            myTodos.CompleteTask();
            Assert.That(myTodos.GetCompletedTasks().All(item => item.IsCompleted == true));
            Assert.That(myTodos.GetIncompleteTasks().All(item => item.IsCompleted == false));
        }

        [Test]
        public void TodoListTaskSortTest()
        {
            TodoList myTodos = new TodoList();
            myTodos.AddTask("Aac");
            myTodos.AddTask("Aab");
            myTodos.AddTask("Aaa");
            myTodos.AddTask("Abb");
            myTodos.AddTask("Aad");
            myTodos.AddTask("Aba");
            myTodos.CompleteTask();
            myTodos.CompleteTask();
            myTodos.CompleteTask();
            List<TodoTask> allTasks = myTodos.GetAllTasks();
            List<TodoTask> allTasksDesc = myTodos.GetAllTasks(SortOrder.Descending);
            List<TodoTask> completedTasksUnsorted = myTodos.GetCompletedTasks(SortOrder.NotSorted);
            List<TodoTask> incompleteTasksAsc = myTodos.GetIncompleteTasks(SortOrder.Ascending);
            Assert.That(allTasks[0].Description == "Aac");
            Assert.That(allTasks[1].Description == "Aab");
            Assert.That(allTasks[4].Description == "Aad");
            Assert.That(allTasks[5].Description == "Aba");
            Assert.That(allTasksDesc[0].Description == "Abb");
            Assert.That(allTasksDesc[1].Description == "Aba");
            Assert.That(allTasksDesc[5].Description == "Aaa");
            Assert.That(allTasksDesc[4].Description == "Aab");
            Assert.That(completedTasksUnsorted.First().Description == "Aac");
            Assert.That(completedTasksUnsorted.Last().Description == "Aaa");
            Assert.That(incompleteTasksAsc.Last().Description == "Aad");
            Assert.That(incompleteTasksAsc[1].Description == "Aba");
            Assert.That(incompleteTasksAsc[2].Description == "Abb");
        }

        [Test]
        public void TodoListSearchTest()
        {
            TodoList myBakingTodoList = new TodoList();
            myBakingTodoList.AddTask("Bake cookies");
            myBakingTodoList.AddTask("Bake muffins");
            myBakingTodoList.AddTask("Bake pie");
            myBakingTodoList.AddTask("Bake choclolate cake");
            myBakingTodoList.AddTask("Bake carrot cake");
            myBakingTodoList.AddTask("Bake bread");
            myBakingTodoList.AddTask("Bake gingerbread");
            List<TodoTask> itemsWithCake = myBakingTodoList.GetTasksWithSubstring("cake");
            List<TodoTask> itemsWithBak = myBakingTodoList.GetTasksWithSubstring("bak");
            List<TodoTask> itemsWithBread = myBakingTodoList.GetTasksWithSubstring("bread");
            List<TodoTask> itemsWithNachos = myBakingTodoList.GetTasksWithSubstring("nachos");
            string resultsForNachos = myBakingTodoList.SearchTasks("nachos");
            Assert.That(itemsWithCake.Count == 2);
            Assert.That(itemsWithBak.Count == 7);
            Assert.That(itemsWithBread.Count == 2);
            Assert.That(itemsWithNachos.Count == 0);
            Assert.That(resultsForNachos.Contains("No results"));
        }
    }
}