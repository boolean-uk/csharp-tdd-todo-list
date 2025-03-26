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
      
        [Test]
        public void testExtensionAdd()
        {
            //Arrange:
            TodoListExtension extension = new TodoListExtension();


            // Act:
            extension.Add(0,"Help me");
            extension.Add(1, "Help me2");
            extension.Add(2, "Help me3");
            extension.Add(3, "Help me4");
            extension.Add(4, "Help me5");
            Dictionary<int,string> testList = new Dictionary<int, string>{
                {0,"Help me"},
                {1, "Help me2"},
                {2, "Help me3"},
                {3, "Help me4" },
                {4, "Help me5" },

            };

            int result = extension.toDoList.Count;

            //Assert:
            Assert.IsTrue(result == testList.Count);
            
        }

        [Test]
        public void testExtensionGetTask()
        {
            //Arrange:
            TodoListExtension extension = new TodoListExtension();


            // Act:
            extension.Add(0, "Help me");
            extension.Add(1, "Help me2");
            extension.Add(2, "Help me3");
            extension.Add(3, "Help me4");
            extension.Add(4, "Help me5");
            Dictionary<int, string> testList = new Dictionary<int, string>{
                {0,"Help me"},
                {1, "Help me2"},
                {2, "Help me3"},
                {3, "Help me4" },
                {4, "Help me5" },

            };

            string result = extension.getTask(0);

            //Assert:
            Assert.IsTrue(result == testList[0]);
            
        }

        [Test]
        public void testExtensionUpdateName()
        {
            //Arrange:
            TodoListExtension extension = new TodoListExtension();


            // Act:
            extension.Add(0, "Help me");
            extension.Add(1, "Help me2");
            extension.Add(2, "Help me3");
            extension.Add(3, "Help me4");
            extension.Add(4, "Help me5");
            Dictionary<int, string> testList = new Dictionary<int, string>{
                {0,"Help me"},
                {1, "Help me2"},
                {2, "Help me3"},
                {3, "Help me4" },
                {4, "Help me5" },

            };

            extension.upDateName(0, "HELP ME NOW");

            //Assert:
            Assert.IsTrue(extension.getTask(0) == "HELP ME NOW");
            
        }

        [Test]
        public void testExtensionUpdateStatus()
        {
            //Arrange:
            TodoListExtension extension = new TodoListExtension();


            // Act:
            extension.Add(0, "Help me");
            extension.Add(1, "Help me2");
            extension.Add(2, "Help me3");
            extension.Add(3, "Help me4");
            extension.Add(4, "Help me5");
            Dictionary<int, string> testList = new Dictionary<int, string>{
                {0,"Help me"},
                {1, "Help me2"},
                {2, "Help me3"},
                {3, "Help me4" },
                {4, "Help me5" },

            };

            extension.upDateStatus(0, true);

            //Assert:
            Assert.IsTrue(extension.getStatus(0) == true);

        }

        [Test]
        public void testExtensionGetDatesInfo()
        {
            //Arrange:
            TodoListExtension extension = new TodoListExtension();


            // Act:
            extension.Add(0, "Help me");
            extension.Add(1, "Help me2");
            extension.Add(2, "Help me3");
            extension.Add(3, "Help me4");
            extension.Add(4, "Help me5");
            Dictionary<int, string> testList = new Dictionary<int, string>{
                {0,"Help me"},
                {1, "Help me2"},
                {2, "Help me3"},
                {3, "Help me4" },
                {4, "Help me5" },

            };

            //extension.toDoList.Values.Contains()
            Dictionary<string,DateTime> result = extension.getDatesInfo();

            //Assert:
            Assert.IsTrue(result.Values.Contains(extension.getDates(0)));

        }

    }
}
