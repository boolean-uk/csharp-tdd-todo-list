using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;


namespace tdd_todo_list.CSharp.Test
{

    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTaskTest()
        {
            // Arrange
            TodoList todoList = new TodoList();
            CustomTask task = new CustomTask("Grocery Shopping", false);

            // Act
            todoList.Add(task);

            // Assert
            Assert.Contains(task, todoList.TaskList);
        }



        [Test]
        public void DisplayAllTest()
        {   //Arrange
            TodoList todoList = new TodoList();
            CustomTask task1 = new CustomTask("Grocery Shopping", false);
            CustomTask task2 = new CustomTask("Cleaning", true);

            todoList.Add(task1);
            todoList.Add(task2);

            // Act
            string formattedTasks = todoList.DisplayAllTasks();

            // Assert
            Assert.IsNotNull(formattedTasks);
            StringAssert.Contains("Grocery Shopping", formattedTasks);
            StringAssert.Contains("Cleaning", formattedTasks);
        }


        [Test]
        public void ChangeStatusTest()
        {   //Arrange
            TodoList todoList = new TodoList();
            CustomTask task = new CustomTask("Test Task", false);
            todoList.Add(task);

            // Act
            todoList.ChangeStatus(task);

            // Assert
            Assert.IsTrue(task.IsComplete);

        }
        [Test]
        public void GetCompleteTest()
        {
            TodoList todoList = new TodoList();
            CustomTask completeTask = new CustomTask("Complete Task", true);
            CustomTask incompleteTask = new CustomTask("Incomplete Task", false);
            todoList.Add(completeTask);
            todoList.Add(incompleteTask);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.DisplayCompleteTasks();

              
                string result = sw.ToString();

                // Assert
                StringAssert.Contains("Complete Tasks:", result);
                StringAssert.Contains("Complete Task", result);
                StringAssert.DoesNotContain("Incomplete Task", result);
            }
        }

        [Test]

        public void GetIncompleteTest()
        {
            TodoList todoList = new TodoList();
            CustomTask completeTask = new CustomTask("Complete Task", true);
            CustomTask incompleteTask = new CustomTask("Incomplete Task", false);
            todoList.Add(completeTask);
            todoList.Add(incompleteTask);

            
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.DisplayIncompleteTasks();

                
                string result = sw.ToString();

                // Assert
                StringAssert.Contains("Not Completed Tasks:", result);
                StringAssert.Contains("Incomplete Task", result);
                StringAssert.DoesNotContain("Complete Task", result);
            }
        }
        [Test]
        public void RemoveTaskTest()
        {
            // Arrange
            TodoList todoList = new TodoList();
            CustomTask task = new CustomTask("Grocery Shopping", false);

            // Act
            todoList.Add(task);
            todoList.RemoveTask(task);
            // Assert
            Assert.IsEmpty(todoList.TaskList);

        }
        [Test]
        public void SearchTaskTest()
       {
            // Arrange
        TodoList todoList = new TodoList();
        CustomTask task1 = new CustomTask("Task A", false);
        CustomTask task2 = new CustomTask("Task B", true);
        todoList.Add(task1);
        todoList.Add(task2);

        // Act
        CustomTask resultTask = todoList.SearchTaskByName("Task B");

        // Assert
        Assert.IsNotNull(resultTask);
        Assert.AreEqual("Task B", resultTask.Name);
        Assert.AreEqual(true, resultTask.IsComplete);
       }

    [Test]
    public void SearchTaskNullTest()
    {
        // Arrange
        TodoList todoList = new TodoList();
        CustomTask task1 = new CustomTask("Task A", false);
        CustomTask task2 = new CustomTask("Task B", true);
        todoList.Add(task1);
        todoList.Add(task2);

        // Act
        CustomTask resultTask = todoList.SearchTaskByName("Task C");

        // Assert
        Assert.IsNull(resultTask);
    }

    [Test]
        public void OrderByAscendingTest()
        {
            TodoList todoList = new TodoList();
            CustomTask task1 = new CustomTask("Task C", false);
            CustomTask task2 = new CustomTask("Task A", true);
            CustomTask task3 = new CustomTask("Task B", false);
            todoList.Add(task1);
            todoList.Add(task2);
            todoList.Add(task3);

        
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.DisplayTasksAscending();

        
                string result = sw.ToString();

                // Assert
                StringAssert.Contains("Tasks Ordered Alphabetically:", result);
                StringAssert.Contains("Name: Task A, Status: True", result.Trim());
                StringAssert.Contains("Name: Task B, Status: False", result.Trim());
                StringAssert.Contains("Name: Task C, Status: False", result.Trim());
            }
        }
        [Test]
        public void OrderByDescendingTest()
        {
            // Arrange
            TodoList todoList = new TodoList();
            CustomTask task1 = new CustomTask("Task C", false);
            CustomTask task2 = new CustomTask("Task A", true);
            CustomTask task3 = new CustomTask("Task B", false);
            todoList.Add(task1);
            todoList.Add(task2);
            todoList.Add(task3);

        
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                todoList.DisplayTasksDescending();

                
                string result = sw.ToString();

                // Assert
                StringAssert.Contains("Tasks Ordered Reverse:", result);
                StringAssert.Contains("Name: Task C, Status: False", result.Trim());
                StringAssert.Contains("Name: Task B, Status: False", result.Trim());
                StringAssert.Contains("Name: Task A, Status: True", result.Trim());
            }
        }

    }
    


    

}
