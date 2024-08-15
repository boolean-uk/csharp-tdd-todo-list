using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test

    
{
    [TestFixture]
    public class ToDoListTest
    {

        [Test]
        public void TestAddingTasktoList()
        {
            //arrange
            TodoList todoList = new TodoList();


            //act
            string task = "Washing dishes";
            todoList.addTask(task, false);

            //assert
            Assert.IsTrue(todoList.List.ContainsKey(task));
        }
        [Test]
        public void TestViewingAllTasks()
        {

            //arrange
            TodoList todoList = new TodoList();



            //act
            string task1 = "doing gym";
            string task2 = "helping in the kitchen";
            todoList.addTask(task1, false);
            todoList.addTask(task2, false);

            Dictionary<string, bool> dictionary1 = todoList.viewAllTasks();



            //assert
            Assert.IsTrue(dictionary1.ContainsKey(task1) & dictionary1.ContainsKey(task2));

        }
        [Test]
        public void TestCompleteOrNot()
        {
            //arrange
            TodoList todoList = new TodoList();

            string task1 = "making food";
            string task2 = "washing clothes";

            todoList.addTask(task1, false);
            todoList.changeStatus(task1, true);


            //assert
            Assert.IsTrue(todoList.List[task1]);

        }
        [Test]

        public void TestOnlyComplete()
        {
            //arrange
            TodoList todoList = new TodoList();

            string task1 = "washing dishes";
            string task2 = "taking clothes";

            todoList.addTask(task1, true);
            todoList.addTask(task2, false);

            Dictionary<string, bool> completedtasks = todoList.takeCompleteTask();

            //assert
            Assert.IsTrue(completedtasks.ContainsKey(task1) & !completedtasks.ContainsKey(task2));


        }
        [Test]
        public void TestNotComplete()
        {
            //arrange
            TodoList todoList = new TodoList();

            string task1 = "washing dishes";
            string task2 = "making food";

            todoList.addTask(task1, false);
            todoList.addTask(task2, true);

            Dictionary<string, bool> uncompletedtasks = todoList.takeNotCompleteTask();

            //assert
            Assert.IsTrue(uncompletedtasks.ContainsKey(task1) & !uncompletedtasks.ContainsKey(task2));
        }



        [Test]

        public void TestNotExisting()
        {
            //arrange
            TodoList todoList = new TodoList();

            //act

            string notexisting = "random_string";
            string existing = "washing dishes";
            string expectedResult = "Did not find string";

            todoList.addTask(existing, true);

            bool currentResult = todoList.searchTask(expectedResult);

            //assert
            Assert.IsFalse(currentResult);
        }

        [Test]
        // I want to remove tasks from my list.
        public void TestRemovingTasks()
        {
            //arrange
            TodoList todoList = new TodoList();

            //act

            string firsttask = "firstoneremoving";


            todoList.addTask(firsttask, true);


            todoList.removeTask(firsttask);

            //assert
            Assert.IsFalse(todoList.List.ContainsKey(firsttask));

        }
        [Test]
        //I want to see all the tasks in my list ordered alphabetically in ascending order.
        public void TestAscOrder()
        {
            //arrange
            TodoList todoList = new TodoList();

            string taskname1 = "Ali";
            string taskname2 = "Bjørn";

            todoList.addTask(taskname2, true);
            todoList.addTask(taskname1, true);

            Dictionary<string, bool> sortedasc = todoList.viewTasksAsc();

            //assert
            Assert.IsTrue(sortedasc.First().Key.Equals(taskname1));


        }
        [Test]
        public void TestDescOrder()
        {

            //arrange
            TodoList todoList = new TodoList();

            string taskname1 = "Bjørn";
            string taskname2 = "Ali";

            todoList.addTask(taskname1, true);
            todoList.addTask(taskname2, true);

            Dictionary<string, bool> sorteddesc = todoList.viewTasksDesc();

            //assert
            Assert.IsTrue(sorteddesc.First().Key.Equals(taskname1));




        }
    }
}