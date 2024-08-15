using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using static tdd_todo_list.CSharp.Main.TodoList;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoTests
    {
         

        [TestCase("Write some code")]
        [TestCase("Write some more code")]
        [TestCase("Shop for groceries")]
        public void TestAddTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = name;

            todo.AddTask(name, false);

            Assert.That(todo.SeeIfTaskExists(expected));            
        }

        [TestCase("Write some code", false)]
        [TestCase("Write some more code", true)]
        [TestCase("Shop for groceries", false)]
        public void TestToogleTask(string name, bool startingStatus)
        {
            //arrange
            TodoList todo = new TodoList();
            todo.AddTask(name, startingStatus); 
            bool expected = !startingStatus;

            bool result = todo.ToogleTaskStatus(name);

            Assert.That(result == expected);
        }


        [TestCase(TodoTaskStatus.Complete)]
        [TestCase(TodoTaskStatus.InComplete)]
        [TestCase(TodoTaskStatus.All)]
        public void TestPrintingTasks(TodoTaskStatus status)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = string.Empty;
            string taskName = "Watch Netflix episode ";
            for(int i = 1; i < 11; i++)
            {
                bool stat = false;
                if(i % 3 == 0)
                {
                    stat = true;
                }
                todo.AddTask(taskName + i.ToString(), stat);

                if (status == TodoTaskStatus.InComplete && stat == false)
                {
                    expected += taskName + i.ToString() + "\n";
                }
                else if( status == TodoTaskStatus.Complete && stat == true)
                {
                    expected += taskName + i.ToString() + "\n";
                }
                else // all
                {
                    expected += taskName + i.ToString() + "\n";
                }
            }



            string result = todo.PrintTasks(status);

            Assert.That(result == expected);
        }
    }
}