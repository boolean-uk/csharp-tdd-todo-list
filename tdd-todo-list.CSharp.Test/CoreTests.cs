using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        private TodoList _toDoList;


        [Test]
        public void addTest()
        {
            // Arrange
            var todoList = new TodoList();

            // Act
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Get groceries", "incomplete");

            // Assert
            Assert.IsTrue(todoList.search("Clean kitchen"));
            Assert.IsTrue(todoList.search("Get groceries"));
            Assert.IsTrue(todoList.search("Vacuum")==false);
        }







        [Test]
        public void getListTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Get groceries", "incomplete");

            // Act
            var result = todoList.getList();

            // Assert
            Assert.Contains("Clean kitchen", result);
            Assert.Contains("Get groceries", result);
        }






        [Test]
        public void changeStatusTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");

            // Act
            todoList.changeStatus("Clean kitchen");


            string status = todoList.GetTaskStatus("Clean kitchen");

            // Assert
            Assert.IsTrue(status == "complete");
        }


        [Test]
        public void completedTasksTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Read a book", "complete");

            // Act
            todoList.completedTasks();

            // Assert
            foreach (string task in todoList.getList())
            {
                string status = todoList.GetTaskStatus(task);
                Assert.AreEqual("complete", status); // Compare the taskStatus directly
            }
        }




        [Test]
        public void incompletedTasksTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Read a book", "complete");

            // Act
            todoList.completedTasks();

            // Assert
            foreach (string task in todoList.getList())
            {
                string status = todoList.GetTaskStatus(task);
                Assert.AreEqual("complete", status); // Compare the taskStatus directly
            }
        }



        [Test]
        public void removeTaskTest()
        {
            // Arrange
            var todoList = new TodoList();

            // Act
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Get groceries", "incomplete");
            todoList.add("Laundry", "incomplete");

            todoList.removeTask("Get groceries");


            // Assert
            Assert.IsTrue(todoList.search("Clean kitchen"));
            Assert.IsTrue(todoList.search("Get groceries") == false);
            Assert.IsTrue(todoList.search("Vacuum") == false);
        }


        [Test]
        public void sortAscendingTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Read a book", "complete");

            // Act
            todoList.sortAscending();

            // Assert

            var sortedTasks = todoList.getList().ToList();
            var expectedOrder = sortedTasks.OrderBy(task => task);

            CollectionAssert.AreEqual(expectedOrder, sortedTasks);

        }



        [Test]
        public void sortDescendingTest()
        {
            // Arrange
            var todoList = new TodoList();
            todoList.add("Clean kitchen", "incomplete");
            todoList.add("Read a book", "complete");

            // Act
            todoList.sortDescending();

            // Assert

            var sortedTasks = todoList.getList().ToList();
            var expectedOrder = sortedTasks.OrderByDescending(task => task);

            CollectionAssert.AreEqual(expectedOrder, sortedTasks);

        }


    }
}