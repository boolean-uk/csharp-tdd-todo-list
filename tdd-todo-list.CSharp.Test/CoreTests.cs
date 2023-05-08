using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        private TodoList _core;
        public CoreTests()
        {
            _core = new TodoList();
        }

        [TestCase("walking", false,false)]
        [TestCase("testing", true, true)]
        [TestCase("swimming", true,true)]
        [TestCase("testing", false,false)]


        public void canAddNewToDo(string todo, bool completed, bool expected) {
            
           
                    
           

              
                    Assert.IsTrue(_core.add(todo, completed) == expected);

               


            }
            
           



        }
    }
