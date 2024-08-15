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
            ToDoList todoList = new ToDoList();
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
            ToDoList todoList = new ToDoList();
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
            ToDoList todoList = new ToDoList();
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
        public void ShouldChangeStatusToInComplete()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
            string task = "Throw garbage";
            todoList.AddTasks(task);


            //Execute
            todoList.ChangeStatus(task);
            Status result = todoList.ChangeStatus(task); 
            
            
            //Verify
            Assert.IsTrue(result == Status.INCOMPLETE);
        }

        [Test]
        public void ShouldChangeStatusToComplete()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
            string task = "Throw garbage";
            todoList.AddTasks(task);


            //Execute
            Status result = todoList.ChangeStatus(task);
           
            
            //Verify
            Assert.IsTrue(result == Status.COMPLETE);
        }

        [Test]
        public void ShouldGetCompleteTask()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
            string task = "Throw garbage";
            string task2 = "Go to work";
            todoList.List.Add(task, Status.COMPLETE);
            todoList.List.Add(task2, Status.INCOMPLETE);



            //Execute

            Dictionary<string, Status> list = todoList.GetCompletedTask();

            //Verify
            Assert.IsTrue(list.ContainsKey(task) && !list.ContainsKey(task2));
        }

            [Test]
        public void ShouldGetIncompletedTask()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
            string task = "Throw garbage";
            string task2 = "Go to work";
            todoList.List.Add(task,Status.COMPLETE);
            todoList.List.Add(task2, Status.INCOMPLETE);
            


            //Execute
            
            Dictionary<string,Status> list = todoList.GetInCompletedTask();
            
            //Verify
            Assert.IsTrue(list.ContainsKey(task2) && !list.ContainsKey(task));
        }

        [Test]
        public void ShouldSearchForTask()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
            string task = "Go to work";
            string task2 = "Throw garbage";
            
            //Execute
            todoList.AddTasks(task);
            string result = todoList.SearchForTask(task2);
           
            //Verify
            Assert.That(result == "Task not found in list");
        }

        [Test]
        public void ShouldRemoveTask()
        {
            //SetUp
            ToDoList todoList = new ToDoList();
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
            ToDoList todoList = new ToDoList();
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
            ToDoList todoList = new ToDoList();
            
            string task = "A Go to work";
            string task2 = "B Shop groceries";

            //Execute
            todoList.AddTasks(task2);
            todoList.AddTasks(task);
            Dictionary<string,Status> result = todoList.OrderAscending();

            //Verify

            Assert.That(result.First().Key == task);
        }

        [Test]
        public void ShouldOrderDescending()
        {
            //SetUp
            ToDoList todoList = new ToDoList();

            string task2 = "A Go to work";
            string task = "B Shop groceries";

            //Execute
            todoList.AddTasks(task2);
            todoList.AddTasks(task);
            Dictionary<string,Status> result = todoList.OrderDescending();

            //Verify

            Assert.That(result.First().Key == task);
        }
    }
}