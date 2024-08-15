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
    }
}
