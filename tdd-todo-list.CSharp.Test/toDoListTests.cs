using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            Assert.IsTrue(returnedList == list.taskList);


        }


        [Test]
        public void checkIfTaskStatusChanged(toDoTask task1,bool status)
        {
            //arrange
            TodoList list = new TodoList();
            bool statusChanged = false;

            //act
            foreach (var item in list.taskList)
            {
                if (item == task1)
                {
                    if (item.taskComplete == status)
                    {
                        statusChanged = true;
                    }
                  
                }
            }


            //Assert
            Assert.IsTrue(statusChanged);
        }








       }
}
