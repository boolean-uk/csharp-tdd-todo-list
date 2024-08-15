using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

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
            todoList.addTask(task);

            //assert
            Assert.IsTrue(todoList.List.ContainsKey(task));

            //hello


        }
    }
}