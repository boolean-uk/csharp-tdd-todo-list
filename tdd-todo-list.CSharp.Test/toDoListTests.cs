using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class toDoListTests
    {

        [Test]
        public void checkIfTaskAdded() {

            //arrange
            TodoList todoList = new TodoList();
            toDoTask task1 = new toDoTask("laundry", true);
            //act
            todoList.addTask(task1);
            

            //assert
            Assert.IsTrue(todoList.taskList.Contains(task1));

        }


        [Test]

        public void printToDoList()
        {

            //arrange
            TodoList list = new TodoList();
            int numberOfTasks = list.taskList.Count;

            //act
            List<toDoTask> returnedList = list.getAll();

            //assert

            Assert.IsTrue(returnedList==list.taskList);


        }











       }
}
