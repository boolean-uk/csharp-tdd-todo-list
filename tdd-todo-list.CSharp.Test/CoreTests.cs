using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    public class CoreTests
    {
        private TodoList _core;

        public CoreTests()
        {
            _core = new TodoList();
        }

        // Check if a new todo is being added
        // Check if the dictionary count increases
        [TestCase("fishing", false)]
        public void InToDoList(string todo, bool status)
        {
            Assert.That(_core.todolist, Has.Exactly(4).Items);
            _core.addToDo(todo, status);
            Assert.That(_core.todolist, Has.Exactly(5).Items);
        }

        // Check if running is in todolist
        // Remove running from todolist
        // Check if there is one less item in todolist
        [TestCase("running")]
        public void RemoveToDo(string todo)
        {
            Assert.That(_core.todolist, Has.Exactly(5).Items);
            _core.removeToDo(todo);
            Assert.That(_core.todolist, Has.Exactly(4).Items);
        }

        // Change the status of the testcase to true
        // Check if the status has changed in the todolist
        [TestCase("coding", false)]
        public void StatusToTrue(string todo, bool status)
        {
            _core.changeStatus(todo, status);
            Assert.IsTrue(_core.todolist[todo]);
        }

        // For each todo in the todolisttrue, check if the item is true
        // For each todo in the todolistfalse, check if the item is false
        [Test]
        public void ReturnTrueList()
        {
            foreach (KeyValuePair<string, bool> item in _core.todolisttrue)
            {
                Assert.IsTrue(item.Value);
            }

            foreach (KeyValuePair<string, bool> item in _core.todolistfalse)
            {
                Assert.IsFalse(item.Value);
            }
        }

        // Return true if todo is in todolist
        [TestCase("coding")]
        public void SearchToDo(string todo) 
        {
            Assert.IsTrue(_core.searchToDo(todo));
        }

        // Check if the list is sorted by ascending order
        // If so, the first key should be coding
        [Test]
        public void SortByAscending()
        {
            Assert.IsTrue(_core.sortByAscending().First() == "coding");
        }

        // Check if the list is sorted by descending order
        // If so, the first key should be traveling
        [Test]
        public void SortByDescending()
        {
            Assert.IsTrue(_core.sortByDescending().First() == "traveling");
        }
    }
}