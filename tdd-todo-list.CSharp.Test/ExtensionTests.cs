using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test, Order(1)]
        [TestCase(1, "Achieving CHIM")]
        [TestCase(2, "Banana eating contest")]
        [TestCase(3, "Calculate all float values of pi")]
        [TestCase(4, "Destroy the universe")]
        public void getTaskByIDTest (int id, string name)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(id,name);

            //Act
            ToDoTask returnedTask = Extension.getTaskByID(id);

            //Assert
            Assert.That(returnedTask.TaskID, Is.EqualTo(id));

        }

        [Test, Order(2)]
        [TestCase(666)]
        [TestCase(0)]
        [TestCase(5)]
        public void getTaskByIDTestFail(int id)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(1, "Banana eating contest");
            Extension.Add(2, "Achieving CHIM");
            Extension.Add(3, "Destroy the universe");
            Extension.Add(4, "Calculate all float values of pi");

            //Act
            ToDoTask returnedTask = Extension.getTaskByID(id);

            //Assert
            Assert.That(returnedTask.TaskName, Is.EqualTo("not found"));
        }

        [Test, Order(3)]
        [TestCase(1, "Eat a lot of pizza")]
        [TestCase(2, "Forget how to ride a bike")]
        [TestCase(3, "Go home for the day")]
        [TestCase(4, "Heat up leftover pasta")]
        public void updateNameTest(int id, string name)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(1, "Banana eating contest");
            Extension.Add(2, "Achieving CHIM");
            Extension.Add(3, "Destroy the universe");
            Extension.Add(4, "Calculate all float values of pi");

            //Act
            string result = Extension.updateName(id, name);

            //Assert
            Assert.That(result, Is.EqualTo(name));
        }

        [Test, Order(4)]
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, true)]
        public void setStatusByIDTest(int id, bool isCompleted)
        {
            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(1, "Banana eating contest");
            Extension.Add(2, "Achieving CHIM");
            Extension.Add(3, "Destroy the universe");
            Extension.Add(4, "Calculate all float values of pi");
            //Act
            bool hasChanged = Extension.setStatusByID(id, isCompleted);

            //Assert
            Assert.That(hasChanged, Is.EqualTo(true));
        }

        [Test, Order(5)]
        [TestCase(666, true)]
        [TestCase(0, true)]
        [TestCase(5, true)]
        public void setStatusByIDTestFail(int id, bool isCompleted)
        {

            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(1, "Banana eating contest");
            Extension.Add(2, "Achieving CHIM");
            Extension.Add(3, "Destroy the universe");
            Extension.Add(4, "Calculate all float values of pi");
            //Act
            bool hasChanged = Extension.setStatusByID(id, isCompleted);

            //Assert
            Assert.That(hasChanged, Is.EqualTo(false));
        }

        [Test, Order(6)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void getCreationTimeTest(int id)
        {

            //Arrange
            TodoListExtension Extension = new TodoListExtension();
            Extension.Add(1, "Banana eating contest");
            Extension.Add(2, "Achieving CHIM");
            Extension.Add(3, "Destroy the universe");
            Extension.Add(4, "Calculate all float values of pi");

            //Act
            string thisSecondHopefully = DateTime.Now.ToString(); //Of course a chance to fail, but it's highly unlikely
            string returnedDate = Extension.getCreationTime(id);

            //Assert
            Assert.That(returnedDate, Is.EqualTo(thisSecondHopefully));
        }
    }
}
