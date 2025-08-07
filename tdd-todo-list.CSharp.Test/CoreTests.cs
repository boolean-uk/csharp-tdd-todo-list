using NUnit.Framework;
using System.Collections.Generic;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddedTaskToList()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var tasks = list.GetAllTasks();

            //assert
            Assert.That(tasks[0].Name, Is.EqualTo("Test"));
        }

        [Test]
        public void ShowsAllTasksOnList()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);
            list.AddTask("Test3", Priority.Low, Category.Life);

            //act
            var allTasks = list.GetAllTasks();

            //assert
            Assert.That(allTasks.Count, Is.EqualTo(3));

        }

        [Test]
        public void ChangeTaskStatus()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var changed = list.ChangeTaskStatus(list[0].id, true);

            //assert
            Assert.That(changed[0].Status, Is.EqualTo(true));
        }

        [Test]
        public void GetOnlyCompletedTasks()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);

            //act
            list.ChangeTaskStatus(list[1].id, true);
            var completedTasks = list.GetCompletedTasks();

            //assert
            Assert.That(completedTasks[0].name, Is.EqualTo("Test2"));
        }

        [Test]
        public void GetOnlyInCompletedTasks()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);

            //act
            list.ChangeTaskStatus(list[1].id, false);
            var completedTasks = list.GetInCompletedTasks();

            //assert
            Assert.That(completedTasks[0].name, Is.EqualTo("Test2"));
        }

        [Test]
        public void ErrorMessageIfTaskNotFound()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.High, Category.Work);

            //act
            var search = list.SearchTask("Test32");

            //assert
            Assert.Null(search);
        }

        [Test]
        public void RemoveTaskById()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.High, Category.Work);

            //act
            list.RemoveTask(1);

            //assert
            Assert.Null(list);
        }

        [Test]
        public void GetTasksAscendingAZ()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Bread", Priority.High, Category.Work);
            list.AddTask("Ants", Priority.High, Category.Work);
            list.AddTask("Crab", Priority.High, Category.Work);

            //act
            var ascendingList = list.GetTasksAscendingAZ();

            //assert
            Assert.That(ascendingList[0].name, Is.EqualTo("Ants"));
            Assert.That(ascendingList[1].name, Is.EqualTo("Bread"));
            Assert.That(ascendingList[2].name, Is.EqualTo("Crab"));
        }

        [Test]
        public void GetTasksDescendingAZ()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Bread", Priority.High, Category.Work);
            list.AddTask("Ants", Priority.High, Category.Work);
            list.AddTask("Crab", Priority.High, Category.Work);

            //act
            var ascendingList = list.GetTasksAscendingAZ();

            //assert
            Assert.That(ascendingList[2].name, Is.EqualTo("Ants"));
            Assert.That(ascendingList[1].name, Is.EqualTo("Bread"));
            Assert.That(ascendingList[0].name, Is.EqualTo("Crab"));
        }

        [Test]
        public void ListTasksByPriority()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.Medium, Category.Work);
            list.AddTask("Test2", Priority.Low, Category.School);
            list.AddTask("Test3", Priority.High, Category.Life);

            //act
            var byPriority = list.GetTasksByPriority();

            //assert
            Assert.That(byPriority[0].name, Is.EqualTo("Test3"));
            Assert.That(byPriority[1].name, Is.EqualTo("Test1"));
            Assert.That(byPriority[2].name, Is.EqualTo("Test2"));
        }
    }
}