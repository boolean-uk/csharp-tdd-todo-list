using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;
using System.Drawing;
using System.Numerics;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddingTaskToTodoList()
        {
            //arrange
            TodoList todo = new TodoList();

            //act
            todo.Items.Add("mow the lawn", false);

            //assert
            Assert.IsTrue(1 == todo.Items.Count);
        }

        [Test]
        public void UpdateTaskCompleted()
        {
            //arrange
            TodoList todo = new TodoList();
            string task = "mow the lawn";
            todo.Items.Add(task, false);

            //act
            bool hasUpdatedTaskStatus = todo.UpdateTask(task);

            //assert
            Assert.IsTrue(hasUpdatedTaskStatus);
        }

        [Test]
        public void SeeTasks()
        {
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("mow the lawn", false);

            //assert
            Assert.IsTrue(todo.Items.Count > 0);
        }

        [Test]
        public void OnlyCompletedTasks()
        {
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("mow lawn", true);
            todo.Items.Add("brush teeth", false);

            //act
            Dictionary<string, bool> completedItems = todo.Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value);

            //assert
            Assert.IsTrue(completedItems.Count == 1);
        }

        [Test]
        public void InCompletedTasks()
        {
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("mow lawn", true);
            todo.Items.Add("brush teeth", false);

            //act
            Dictionary<string, bool> incompletedItems = todo.Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value);

            //assert
            Assert.IsTrue(incompletedItems.Count == 1);
        }

        [Test]
        public void SearchTasks()
        {
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("mow the lawn", true);
            todo.Items.Add("brush teeth", false);
            string task = "mow the lawn";

            //act
            string isFound = todo.SearchTask(task);

            //assert
            Assert.IsTrue(isFound == "false" || isFound == "Task wasn't found");
        }

        [Test]
        public void RemoveTask()
        {
            //arrange
            TodoList todo = new TodoList();

            //act
            todo.Items.Remove("mow the lawn");

            //assert
            Assert.IsFalse(todo.Items.ContainsKey("mow the lawn"));
        }

        [Test]
        public void TasksOrder()
        {
            //arrange
            TodoList todo = new TodoList();
            todo.Items.Add("Assist brother in school", false);
            todo.Items.Add("Bench press 220kg", true);
            todo.Items.Add("Complete Cohort", false);

            //act
            todo.DescendingItems();
            var element = todo.Items.ElementAt(0);

            //assert
            Assert.IsFalse(element.ToString().StartsWith("A"));
        }

    }
}