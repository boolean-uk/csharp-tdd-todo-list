﻿using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {


        [Test]
        public void Test1A()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            bool result = false;
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", false },
                {"Hoover", false }
            };

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                result = core.Add(kv.Key, kv.Value);
                if(!result) 
                {
                    break;
                }
            }
            //  Assert - check the results
            Assert.True(result);
        }

        [Test]
        public void Test1B()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            bool result = false;
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", false },
                {"Hoover", false }
            };

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                result = core.Add(kv.Key, kv.Value);
            }
            result = core.Add("Laundry", false);

            //  Assert - check the results
            Assert.True(!result);
        }

        [Test]
        public void Test2()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", false },
                {"Hoover", false }
            };

            int result = 0;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.PrintTasks();
            //  Assert - check the results
            Assert.IsTrue(result == 3);
        }
    }
}