using NUnit.Framework;
using tdd_todo_list.CSharp.Main;

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

        [TestCase("walking", 2, false, false)]
        [TestCase("testing", 3, true, true)]
        [TestCase("swimming", 4, true, true)]
        [TestCase("testing", 5, false, false)]

        public void canAddNewToDo(string todo, int id, bool completed, bool expected)
        {
            //arrange


            //act
            bool result = _core.add(todo, id, completed);

            //assert
            Assert.IsTrue(result == expected);
        }
        [Test]
        public void CheckMyTasks()
        {
            //arrange
            TodoList todoList = new TodoList();
            todoList.add("make my bed", 1, true);
            todoList.add("walking", 2, false);
            todoList.add("shopping", 3, false);


            //act
            int count = todoList.count() + 1;

            //assert
            Assert.AreEqual(3, count);

        }

        [Test]
        public void ChangeStatusTest()
        {


            TodoList todolist = new TodoList();


            todolist.add("make my bed", 1, true);
            todolist.add("walking", 2, false);
            todolist.add("shopping", 3, false);

            Assert.IsTrue(todolist.changedStatus(2) == true); // returns true when the cvhange of status is success
            Assert.IsTrue(todolist.changedStatus(4) == false); // returns false cause the id doesnt exist


        }
        [Test]
        public void CheckCompletedTasksTest()
        {

            _core.add("lamda", 5, true);
            //bool[] bools = new bool[todo.count()];
            List<Tuple<string, int, bool>> result = _core.GetCompletedTasks();

            if (result.Count == 0)
            {
                //Console.WriteLine("if");

                Assert.Zero(result.Count); // if there is no completed task returns a zero List 

            }
            else
            {
                foreach (var k in result)
                {
                    Console.WriteLine($"{k.Item1}");
                    Assert.IsTrue(k.Item3 == true); // if all tasks are completed its true 
                }
            }



        }
        [Test]
        public void CheckInCompletedTasksTest()
        {

            _core.add("lamda", 5, true);
            //bool[] bools = new bool[todo.count()];
            List<Tuple<string, int, bool>> result = _core.GetInCompletedTasks();

            if (result.Count == 0)
            {
                //Console.WriteLine("if");

                Assert.Zero(result.Count); // if there is no completed task returns a zero List 

            }
            else
            {
                foreach (var k in result)
                {
                    Console.WriteLine($"{k.Item1}");
                    Assert.IsTrue(k.Item3 == false); // if all tasks are completed its false 
                }
            }

        }

        [Test]
        public void ifTasksExists()
        {

            Assert.AreSame("Found", _core.SearchTask(2)); // if the tasks is found
            Assert.AreSame("it wasn't found", _core.SearchTask(7)); //if the task wasnt found
        }

        [Test]
        public void CheckIfDeleted()
        {
            Assert.IsTrue(_core.RemoveTask(1)); // its true if the id exists in the task and the tasks gets deleted
        }
        [Test]
        public void CheckAscendingOrder()
        {
            TodoList ascending = new TodoList();
            ascending.add("arrange", 3, false);
            List<Tuple<string, int, bool>> ascendingorder = ascending.GetTasksAscending();


            for (int i = 0; i < ascendingorder.Count-1; i++)
            {

                
                Assert.IsTrue(ascendingorder[i].Item1[0] <= ascendingorder[i + 1].Item1[0]);




            }

        }
        [Test]
        public void CheckDescendingOrder()
        {
            TodoList ascending = new TodoList();
            ascending.add("arrange", 3, false);
            List<Tuple<string, int, bool>> ascendingorder = ascending.GetTasksDescending();


            for (int i = 0; i < ascendingorder.Count - 1; i++)
            {


                Assert.IsTrue(ascendingorder[i].Item1[0] >= ascendingorder[i + 1].Item1[0]);




            }

        }




    }
}
