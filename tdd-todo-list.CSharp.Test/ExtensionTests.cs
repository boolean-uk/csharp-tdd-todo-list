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
            int expectedEmptyDictionary = 0;
            int ID = 0;

            //act
            Dictionary<string, TodoListExtension.StatusAndID> result = tasks.Get(ID);

            //assert
            Assert.That(result.Count, Is.EqualTo(expectedEmptyDictionary));

            //arrange
            tasks.Add(task);
            int expectedSingleDictionaryElement = 1;

            //act
            result = tasks.Get(ID);

            //assert
            Assert.That(result.Count, Is.EqualTo(expectedSingleDictionaryElement));
        }
    }
}
