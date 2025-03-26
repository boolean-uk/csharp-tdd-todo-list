using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Main;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Engine.TesthostProtocol;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [TestCase(1)]
        public void GetTodoByIdTest(int id)
        {
                  
            //arrang
            _extension.TodosList.Add(new Todo(1, "Clean kitchen", "Complete"));
            _extension.TodosList.Add(new Todo(2, "Work out", "Incomplete"));


            //act
            Todo result = _extension.GetTodoById(id);
            Todo expected = _extension.TodosList[0];

            //assert
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Description, result.Description);
            Assert.AreEqual(expected.Status, result.Status);

        }

        [TestCase(1, "Work out")]
        public void UpdateTodoDescriptionByIdTest(int id, string description)
        {
            //arrange
            _extension.TodosList.Add(new Todo(1, "Clean kitchen", "Complete"));

            //act
            _extension.UpdateTodoDescriptionById(id, description);

            //assert
            Assert.IsTrue(_extension.TodosList[0].Description == description );
        }

        [TestCase(1, "Complete")]
        public void UpdateTodoStatusByIdTest(int id, string status)
        {
            //arrange
            _extension.TodosList.Add(new Todo(1, "Clean kitchen", "Incomplete"));

            //act
            _extension.UpdateTodoStatusById(id, status);

            //assert
            Assert.IsTrue(_extension.TodosList[0].Status == status);
        }

        [Test]
        public void AllTodosDateAndTimeAddedTest()
        {

            using (StringWriter sw = new StringWriter())
            {
                //arrange
                Console.SetOut(sw);

                _extension.TodosList.Add(new Todo(1, "Clean kitchen", "Complete"));
                Thread.Sleep(2000);
                _extension.TodosList.Add(new Todo(2, "Work out", "Incomplete"));


                string expected = $"Id: 1, Description: Clean kitchen, Status: Complete, DateTime: {_extension.TodosList[0].DateTime}\r\n" +
                    $"Id: 2, Description: Work out, Status: Incomplete, DateTime: {_extension.TodosList[1].DateTime}\r\n";
                //act
                _extension.AllTodosDateAndTimeAdded();

                //assert
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}
