using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void ShouldAddTask()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Shop groceries";


            //Execute
            bool result = todoList.AddTasks(task);

            
            //Verify
            Assert.IsTrue(result);
        }

        [Test]
        public void ShouldNotAddTask()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Shop groceries";


            //Execute
            todoList.AddTasks(task);
            bool result = todoList.AddTasks(task);
            
            //Verify
            Assert.IsFalse(result);
        }   
        
        [Test]
        public void ShouldShowList()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Go to work";
            string task2 = "Throw garbage";


            //Execute
            todoList.AddTasks(task);
            todoList.AddTasks(task2);
            Dictionary<string, Status> list = todoList.ShowList();


            //Verify
            Assert.IsTrue(list.ContainsKey(task) && list.ContainsKey(task2));
        }

        [Test]
        public void ShouldChangeStatusToComplete()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Throw garbage";
            todoList.AddTasks(task);


            //Execute
            Status result = todoList.ChangeStatus(task); 
            
            
            //Verify
            Assert.IsTrue(result == Status.INCOMPLETE);
        }

        [Test]
        public void ShouldgetInCompleteTask()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Throw garbage";
            todoList.AddTasks(task);


            //Execute
            todoList.ChangeStatus(task);
            Status result = todoList.ChangeStatus(task);
           
            
            //Verify
            Assert.IsTrue(result == Status.COMPLETE);
        }

        [Test]
        public void ShouldSearchForTask()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Go to work";
            string task2 = "Throw garbage";
            
            //Execute
            todoList.AddTasks(task);
            string result = todoList.SearchForTask(task2);
           
            //Verify
            Assert.Equals(result, "Task not found in list");
        }

        [Test]
        public void ShouldRemoveTask()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Go to work";
            string task2 = "Shop groceries";

            //Execute
            todoList.AddTasks(task);
            todoList.AddTasks(task2);
            bool result = todoList.RemoveTask(task);

            //Verify

            Assert.IsTrue(result);
        }
        [Test]
        public void ShouldRemoveTaskFalse()
        {
            //SetUp
            TodoList todoList = new TodoList();
            string task = "Go to work";
            string task2 = "Shop groceries";

            //Execute
            todoList.AddTasks(task);
            todoList.AddTasks(task2);
            bool result = todoList.RemoveTask("Throw garbage");

            //Verify

            Assert.IsFalse(result);
        }

        [Test]
        public void ShouldOrderAscending()
        {
            //SetUp
            TodoList todoList = new TodoList();
            
            string task = "Go to work";
            string task2 = "Shop groceries";

            //Execute
            todoList.AddTasks(task2);
            todoList.AddTasks(task);
            bool result = todoList.OrderDescending(todoList.List);

            //Verify

            Assert.That(todoList.List.First().Key == task);
        }

        [Test]
        public void ShouldOrderDescending()
        {
            //SetUp
            TodoList todoList = new TodoList();

            string task2 = "Go to work";
            string task = "Shop groceries";

            //Execute
            todoList.AddTasks(task2);
            todoList.AddTasks(task);
            bool result = todoList.OrderDescending(todoList.List);

            //Verify

            Assert.That(todoList.List.First().Key == task);
        }
    }
}