using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ToDoListTests
    {

        [Test]
        public void AddTaskToTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            
            // 2. Execute
            string task = "Eat cream-cheese bagel";
            todoList.Add(task, false);

            // 3. Verify
            Assert.IsTrue(todoList.TaskList.ContainsKey(task));
        }
        
        [Test]
        public void GetTasksFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            
            // 2. Execute
            string task = "Run 500m";
            string task2 = "Eat avocado cream-cheese bagel with smoked salmon";
            todoList.Add(task, false);
            todoList.Add(task2, false);
            Dictionary<string, bool> taskList = todoList.GetList();

            // 3. Verify
            Assert.IsTrue(taskList.ContainsKey(task) & taskList.ContainsKey(task2));
        }
        
        [Test]
        public void ChangeTaskOfStatus()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            
            // 2. Execute
            string task = "Write tests";
            todoList.Add(task, false);
            todoList.ChangeStatus(task, true);

            // 3. Verify
            Assert.IsTrue(todoList.TaskList[task] == true);
        }
        
        [Test]
        public void GetCompletedTasksFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            
            // 2. Execute
            string completeTask = "This task is completed";
            string incompleteTask = "This task is incomplete";
            todoList.Add(completeTask, true);
            todoList.Add(incompleteTask, false);
            Dictionary<string, bool> taskList = todoList.GetCompleteTasks();

            // 3. Verify
            Assert.IsTrue(taskList.ContainsKey(completeTask) & !taskList.ContainsKey(incompleteTask));
        }
        
        [Test]
        public void GetIncompleteTasksFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
           
            // 2. Execute
            string completeTask = "This task is completed";
            string incompleteTask = "This task is incomplete";
            todoList.Add(completeTask, true);
            todoList.Add(incompleteTask, false);
            Dictionary<string, bool> taskList = todoList.GetIncompleteTasks();

            // 3. Verify
            Assert.IsTrue(taskList.ContainsKey(incompleteTask) & !taskList.ContainsKey(completeTask));
        }
        
        [Test]
        public void SearchForTaskInTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            
            // 2. Execute
            string task = "Write source code";
            string task2 = "Walk for 15m";
            todoList.Add(task, false);
            todoList.Add(task2, false);
            Dictionary<string, bool> taskList = todoList.SearchFor("Walk");

            // 3. Verify
            Assert.IsTrue(taskList.ContainsKey(task2) & !taskList.ContainsKey(task));
        }
        
        [Test]
        public void RemoveTaskFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();
            // 2. Execute
            string task = "Eat lunch";
            todoList.Add(task, false);
            todoList.Remove(task);

            // 3. Verify
            Assert.IsTrue(!todoList.TaskList.ContainsKey(task));
        }
        
        [Test]
        public void GetListInAscendingOrderFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();

            // 2. Execute
            Dictionary<string, bool> sortedList = new Dictionary<string, bool>();
            sortedList.Add("A - I am first", false);
            sortedList.Add("B - I am second", false);

            string task2 = "B - I am second";
            string task1 = "A - I am first";
            todoList.Add(task1, false);
            todoList.Add(task2, false);
            Dictionary<string, bool> sortedListFromTODOList = todoList.GetListInAscendingOrder();

            // 3. Verify
            Assert.IsTrue(sortedList == sortedListFromTODOList);
        }
        
        [Test]
        public void GetListInDescendingOrderFromTODOList()
        {
            // 1. Setup
            TodoList todoList = new TodoList();

            // 2. Execute
            Dictionary<string, bool> sortedList = new Dictionary<string, bool>();
            sortedList.Add("B - I am first", false);
            sortedList.Add("A - I am second", false);

            string task1 = "A - I am second";
            string task2 = "B - I am first";
            todoList.Add(task1, false);
            todoList.Add(task2, false);
            Dictionary<string, bool> sortedListFromTODOList = todoList.GetListInDescendingOrder();

            // 3. Verify
            Assert.IsTrue(sortedList == sortedListFromTODOList);
        }
    }
}