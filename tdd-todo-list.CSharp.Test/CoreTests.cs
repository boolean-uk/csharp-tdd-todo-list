using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Numerics;
using System.Collections.Generic;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        //I want to add tasks to my todo list.
        [Test]
        public void AddingTaskToTodoList()
        {
            // arrange
            TodoList todo = new TodoList();


            // act

            todo.Items.Add("mow the lawn", false);


            // assert
            Assert.IsTrue(1 == todo.Items.Count);
        }


        //    I want to change the status of a task between incomplete and complete.
        [Test]
        public void UpdateTaskCompleted()
        {
            // arrange
            TodoList todo = new TodoList();
            string task = "go to barber";
            todo.Items.Add("mow the lawn", false);

            // act

            bool hasUpdatedTaskStatus = todo.UpdateTask(task);
            //var item = todo.Items.Where(x => x.Key == "mow the lawn").FirstOrDefault();
            //item.Value = true;


            // assert

            Assert.IsTrue(!hasUpdatedTaskStatus);

        }

        //    I want to see all the tasks in my todo list.
        [Test]
        public void CompleteTasklist()
        {
            // arrange
            TodoList todo = new TodoList();


            // act
            todo.SeeTasks();

            // assert

            Assert.IsNotNull(todo.Items);
        }

        //    I want to be able to get only the complete tasks.
        [Test]
        public void CompletedTasksOnly()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's excersises", true);
            todo.Items.Add("finish React course material", false);

            // act
            Dictionary<string, bool> CompletedItems = todo.Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value);

            // assert
            Assert.IsTrue(CompletedItems.Count == 1);

        }
        //    I want to be able to get only the incomplete tasks.
        [Test]
        public void IncompletedTasksOnly()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's excersises", true);
            todo.Items.Add("finish React course material", false);
            todo.Items.Add("play video games", false);

            // act
            Dictionary<string, bool> IncompletedItems = todo.Items.Where(x => x.Value == false).ToDictionary(x => x.Key, x => x.Value);

            // assert
            Assert.IsTrue(IncompletedItems.Count == 2);
        }
        //    I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [Test]
        public void SearchTasks()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's excersises", true);
            todo.Items.Add("finish React course material", false);
            todo.Items.Add("play video games", false);

            // act
            //List<string> searchTasks = todo.SearchTaskByName("Cook");
            string result = todo.SearchTaskByName("Cook");

            // assert
            Assert.AreEqual(result, "not found");
        }

        // I want to remove tasks from my list.
        [Test]
        public void RemoveTask()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's excersises", true);
            todo.Items.Add("finish React course material", false);
            todo.Items.Add("play video games", false);

            // act

            //bool removed = todo.RemoveItem("finish React course material");
            todo.Items.Remove("finish React course material");


            // assert
            Assert.AreEqual(2, todo.Items.Count);
        }

        [Test]
        public void AscendingOrderTasks()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's exercises", true);
            todo.Items.Add("do React course material", false);
            todo.Items.Add("play video games", false);

            // act
            //todo.Items.ToString();
            //todo.Items.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // assert

            Assert.AreEqual("d", todo.AscendingTasks().ElementAt(0).Key.ToString().Substring(0,1));
        }

        [Test]
        public void DescendingOrderTasks()
        {
            // arrange
            TodoList todo = new TodoList();
            todo.Items.Add("finish today's exercises", true);
            todo.Items.Add("do React course material", false);
            todo.Items.Add("play video games", false);

            // act
            //todo.Items.ToString();
            //todo.Items.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // assert

            Assert.AreEqual("p", todo.DescendingTasks().ElementAt(0).Key.ToString().Substring(0, 1));
        }
    }
    }









//    
//    I want to see all the tasks in my list ordered alphabetically in ascending order.
//    I want to see all the tasks in my list ordered alphabetically in descending order.
