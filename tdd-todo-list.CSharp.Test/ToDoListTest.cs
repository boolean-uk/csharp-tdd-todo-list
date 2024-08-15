using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

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

            Dictionary<string,bool> dictionary1 = todoList.viewAllTasks();



            //assert
            Assert.IsTrue(dictionary1.ContainsKey(task1) & dictionary1.ContainsKey(task2));

        }
        
    }
}