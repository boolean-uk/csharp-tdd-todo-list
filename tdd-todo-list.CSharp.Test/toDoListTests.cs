using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
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
        public void checkIfTaskAdded()
        {

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
            Console.Write(returnedList);

            //assert

            Assert.IsTrue(returnedList == list.taskList);


        }


        [Test]
        public void checkIfTaskStatusChanged()
        {
            //arrange
            TodoList list = new TodoList();
            string taskToChange = "exercise";
            bool changeTo = false;
            bool statusChanged = false;


            //act

            list.changeStatus(taskToChange, changeTo);
            foreach (var item in list.taskList)
            {
                if (item.taskName == taskToChange)
                {
                    item.taskComplete = changeTo;
                    statusChanged = true;
                    break;

                }
            }


            //Assert
            Assert.IsTrue(statusChanged);
        }



        [Test]

        public void checkifFilteredComplete()
        {

            //arrange
            TodoList list = new TodoList();
            List<toDoTask> filteredList = list.getComplete(list.taskList);
            bool filterComplete = true;

            //act
            foreach (var item in filteredList)
            {
                if (item.taskComplete == false)
                {
                    filterComplete = false;
                }
            }

            //Assert

            Assert.IsTrue(filterComplete);

        }



        [Test]

        public void checkifFilteredInComplete()
        {

            //arrange
            TodoList list = new TodoList();
            List<toDoTask> filteredList = list.getInComplete(list.taskList);
            bool filterComplete = true;

            //act
            foreach (var item in filteredList)
            {
                if (item.taskComplete == true)
                {
                    filterComplete = false;
                }
            }

            //Assert

            Assert.IsTrue(filterComplete);

        }


        [Test]

        public void checkIfListAscending()
        {

            //arrange 
            TodoList list = new TodoList();
            List<toDoTask> ascendingList = list.getAscending(list.taskList);
            bool isAscending = true;

            //act
            for (int i = 0; i < ascendingList.Count - 1; i++)
            {
                string word1 = ascendingList[i].taskName;
                string word2 = ascendingList[i + 1].taskName;
                int result = String.Compare(word1, word2);
                if (result == 1)
                {
                    isAscending = false;
                }
            }

            //assert
            Assert.IsTrue(isAscending);
        }

        [Test]
        public void checkIfListDescending()
        {

            //arrange 
            TodoList list = new TodoList();
            List<toDoTask> descendingList = list.getDescending(list.taskList);
            bool isDescending = true;

            //act
            for (int i = 0; i < descendingList.Count - 1; i++)
            {
                string word1 = descendingList[i].taskName;
                string word2 = descendingList[i + 1].taskName;
                int result = String.Compare(word1, word2);
                if (result == -1)
                {
                    isDescending = false;
                }
            }

            //assert
            Assert.IsTrue(isDescending);
        }

        [Test]

        void checkIfCorrectId()
        {
            //arrange
            TodoList list = new TodoList();
            int id = 2;
            string expectedTaskName = "cook";

            //act
            string taskName = list.findById(id);


            //assert
            Assert.AreEqual(expectedTaskName, taskName);



        }


        [Test]
        public void checkUpdateNameById()
        {

            //arrange
            TodoList list = new TodoList();
            int testId = 2;
            string newName = "visitation";


            //act
            list.changeNameById(testId, newName);
            string actualName = list.findById(testId);

            //assert
            Assert.AreEqual(newName, actualName);


        }

        [Test]

        public void checkUpdateStatusById()
        {
            TodoList list = new TodoList();
            int testId = 3;
            bool newStatus = false;
            bool expectedStatus = false;

            //act
            list.changeStatusById(testId, newStatus);


            //Assert
            Assert.IsTrue(expectedStatus);
        }

        [Test]
        public void checkCreationTime()
        {
            //arrange
            TodoList list = new TodoList();
            toDoTask newTask = new toDoTask("setTime", true);
            string taskToCheck = "setTime";
            list.addTask(newTask);


            //act
            DateTime date = list.getDateTime(taskToCheck);

            //assert
            Assert.AreEqual((DateTime)date, DateTime.Now);

        }
    }
}
