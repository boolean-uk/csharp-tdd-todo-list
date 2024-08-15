using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        [TestCase("Feed Pet")]
        public void GetTest(string task)
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            KeyValuePair<string, TodoListExtension.StatusAndID> expectedEmptyKeyValuePair = new KeyValuePair<string, TodoListExtension.StatusAndID>();
            int ID = 0;

            //act
            KeyValuePair<string, TodoListExtension.StatusAndID> result = tasks.Get(ID);

            //assert
            Assert.That(result.Key, Is.EqualTo(expectedEmptyKeyValuePair.Key));

            //arrange
            tasks.Add(task);

            //act
            result = tasks.Get(ID);

            //assert
            Assert.That(result.Key, Is.EqualTo(task));
        }

        [TestCase("Feed Pet", "Go Shopping")]
        public void ChangeNameTest(string task1, string task2)
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            bool expectedFailure = false;
            int ID = 0;

            //act
            bool result = tasks.ChangeName(ID, task2);

            //assert
            Assert.That(result, Is.EqualTo(expectedFailure));

            //arrange
            tasks.Add(task1);
            bool expectedSuccess = true;

            //act
            result = tasks.ChangeName(ID, task2);

            //assert
            Assert.That(result, Is.EqualTo(expectedSuccess));
        }

        [TestCase("Feed Pet")]
        public void ChangeStatus(string task)
        {
            //arrange
            TodoListExtension tasks = new TodoListExtension();
            bool expectedFailure = false;
            int ID = 0;

            //act
            bool result = tasks.ChangeStatus(ID, true);

            //assert
            Assert.That(result, Is.EqualTo(expectedFailure));

            //arrange
            tasks.Add(task);
            bool expectedSuccess = true;

            //act
            result = tasks.ChangeStatus(ID, true);

            //assert
            Assert.That(result, Is.EqualTo(expectedSuccess));
        }
    }
}
