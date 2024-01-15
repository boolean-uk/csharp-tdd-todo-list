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

        [Test]
        public void Test3()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            int result = 0;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.PrintComplete();
            //  Assert - check the results
            Assert.IsTrue(result == 1);
        }

        [Test]
        public void Test4()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            int result = 0;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.PrintInomplete();
            //  Assert - check the results
            Assert.IsTrue(result == 2);
        }

        [Test]
        public void Test5A()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            bool result = false;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.SearchTask("Shopping");

            //  Assert - check the results
            Assert.IsFalse(result);
        }

        [Test]
        public void Test5B()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            bool result = false;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.SearchTask("Hoover");

            //  Assert - check the results
            Assert.IsTrue(result);
        }

        [Test]
        public void Test6A()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            bool result = false;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.RemoveTask("Shopping");

            //  Assert - check the results
            Assert.IsFalse(result);
        }

        [Test]
        public void Test6B()
        {
            //  Arrange - set up test values
            TodoList core = new TodoList();
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>()
            {
                {"Laundry", false },
                {"Do dishes", true },
                {"Hoover", false }
            };

            bool result = false;

            //  Act - use the fucntion we want to test
            foreach (var kv in keyValuePairs)
            {
                core.Add(kv.Key, kv.Value);
            }

            result = core.RemoveTask("Hoover");

            //  Assert - check the results
            Assert.IsTrue(result);
        }
    }
}