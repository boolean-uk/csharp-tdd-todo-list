using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void createTodoList()
        {
            TodoList core = new TodoList();
            Assert.That(core.NrOfTasks, Is.EqualTo(0));
            Assert.Pass();
            
        }

        [Test]
        public void createTaskEntry()
        {
            TaskEntry task = new TaskEntry("my First Task", -1);
            Assert.Pass();
        }
        

        [TestCase("My First Task")]
        public void addTask(string taskName)
        {
            //Arrange
            TodoList core = new TodoList();
            int nrOfEntriesBeforeAdd = core.NrOfTasks;
            //Act
            int taskId = core.AddTask(taskName);
            //Assert
            Assert.IsTrue(nrOfEntriesBeforeAdd == (core.NrOfTasks - 1));
        }
        [TestCase("My First Task")]
        public void addTaskThenRetrieve(string taskName)
        {
            //Arrange
            TodoList core = new TodoList();
            int nrOfEntriesBeforeAdd = core.NrOfTasks;
            //Act
            int taskId = core.AddTask(taskName);
            TaskEntry? addedTask = core.GetTask(taskId);
            //Assert
            Assert.IsTrue(nrOfEntriesBeforeAdd == (core.NrOfTasks - 1));
            Assert.That(addedTask != null);
            Assert.That(taskName == addedTask?.Name);
        }

        //[TestCase(new string[]{"My First Task", "My second Task", "My third Task", "My fourth Task", "another", "yes, this is task"})]
        [TestCase(new object[]{"My First Task", "My second Task", "My third Task", "My fourth Task", "another", "yes, this is task"})]
        [TestCase(new object[] { "another", "another", "another", "another", "another" })]
        [TestCase(new object[] { "another", "another", "another", "another", "another", "yes, this is task" })]
        public void addTaskThenRetrieve_multiple(params string[] taskNames)
        {
            //Arrange
            TodoList core = new TodoList();
            int nrOfEntriesBeforeAdd = core.NrOfTasks;
            List< Tuple<TaskEntry, string>> retrievedTasks_names = new List< Tuple<TaskEntry,string>>();
            //Act
            foreach (string n in taskNames)
            {

                int taskId = core.AddTask(n);
                TaskEntry? addedTask = core.GetTask(taskId);
                if (addedTask != null)
                    retrievedTasks_names.Add(new (addedTask, n ));
                else 
                    Assert.Fail();
            }
            //Assert
            foreach(var rt in retrievedTasks_names)
            {
                TaskEntry task = rt.Item1;
                string taskName = rt.Item2;
                Assert.That(task != null);
                Assert.That(taskName == task?.Name);
            }
            Assert.IsTrue(nrOfEntriesBeforeAdd == (core.NrOfTasks - taskNames.Length));
        }

        [TestCase(new object[]{"My First Task", "My second Task", "My third Task", "My fourth Task", "another", "yes, this is task"})]
        [TestCase(new object[]{ "another", "another", "another", "another", "another"})]
        [TestCase(new object[]{ "another", "another", "another", "another", "another", "yes, this is task"})]
        public void taskList_validateAdded(params string[] taskNames)
        {
            //Arrange
            TodoList core = new TodoList();
            Dictionary<int, string> retrievedTasks_names = new Dictionary<int, string>();
            foreach (string n in taskNames)
            {

                int taskId = core.AddTask(n);
                retrievedTasks_names[taskId] = n; 
            }
            //Act
            List<TaskEntry> tasklist = core.GetTaskList_all();

            //Assert
            Assert.IsTrue(tasklist.Count != 0);
            Assert.IsTrue(tasklist.Count == taskNames.Count());
            foreach (var t in tasklist)
            {
                Assert.That(retrievedTasks_names.ContainsKey(t.Id));
                Assert.That(retrievedTasks_names[t.Id] == t.Name );                
            }
        }
        
        [Test]
        public void taskList_addThenCheckCompletionStatus()
        {
            //Arrange
            TodoList core = new TodoList();
            int testTaskId = core.AddTask("my Test Task");
            //Act
            TaskEntry? task = core.GetTask(testTaskId);

            //Assert
            Assert.IsNotNull(task);
            Assert.IsFalse(task?.Completed);
        }
        [Test]
        public void taskList_addThenMarkAsCompleted()
        {
            //Arrange
            TodoList core = new TodoList();
            int testTaskId = core.AddTask("my Test Task");
            //Act
            TaskEntry? task = core.GetTask(testTaskId);

            core.ToggleTaskCompletion(testTaskId); // Toggels to Complete
            task = core.GetTask(testTaskId);

            //Assert
            Assert.IsTrue(task?.Completed);
            Assert.IsNotNull(task);
        }
        [Test]
        public void taskList_addThenMarkAsCompletedThenMarkAsIncomplete()
        {
            //Arrange
            TodoList core = new TodoList();
            int testTaskId = core.AddTask("my Test Task");
            //Act
            TaskEntry? task = core.GetTask(testTaskId);

            core.ToggleTaskCompletion(testTaskId); // Toggels to Complete
            core.ToggleTaskCompletion(testTaskId); // Toggles to Incomplete
            task = core.GetTask(testTaskId);

            //Assert
            Assert.IsFalse(task?.Completed);
            Assert.IsNotNull(task);
        }
        [Test]
        public void taskList_accesssCreationDateTime()
        {
            //Arrange
            TodoList core = new TodoList();
            var timeBefore = DateTime.Now;
            int testTaskId = core.AddTask("my Test Task");
            var timeAfter = DateTime.Now;
            TaskEntry? task = core.GetTask(testTaskId);
            //Act


            var accessedCreationDate = task?.CreationDate;

            //Assert
            Assert.IsNotNull(task);
            Assert.IsInstanceOf(typeof(DateTime), accessedCreationDate);
            Assert.Less(timeBefore, accessedCreationDate);
            Assert.Greater(timeAfter, accessedCreationDate);
        }
        [Test]
        public void taskList_getCompleted()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_a = core.AddTask("my a Task");
            int task_id_b = core.AddTask("my b Task");
            int task_id_c = core.AddTask("my c Task");
            int task_id_d = core.AddTask("my d Task");
            int task_id_e = core.AddTask("my e Task");
            List<Tuple<int, bool>> taskId_completionStatus = new List<Tuple<int, bool>>
            {
                new (task_id_a, true ),
                new (task_id_b, false),
                new (task_id_c,  true),
                new (task_id_d,  true),
                new (task_id_e,  false),
            };
            List<int> completedTaskIds = taskId_completionStatus.Where(x => x.Item2).Select(x => x.Item1).ToList();
            foreach (var (taskId, status) in taskId_completionStatus)
            {
                if (status)
                    core.ToggleTaskCompletion(taskId);
            }

            // act 
            var completedTasks = core.GetTaskList_completed();

            //assert
            foreach (var task in completedTasks)
            {
                Assert.Contains(task.Id, completedTaskIds);
            }
            Assert.AreEqual(completedTasks.Count, completedTaskIds.Count);

        }
        [Test]
        public void taskList_getIncompleted()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_a = core.AddTask("my a Task");
            int task_id_b = core.AddTask("my b Task");
            int task_id_c = core.AddTask("my c Task");
            int task_id_d = core.AddTask("my d Task");
            int task_id_e = core.AddTask("my e Task");
            List<Tuple<int, bool>> taskId_completionStatus = new List<Tuple<int, bool>>
            {
                new (task_id_a, true ),
                new (task_id_b, false),
                new (task_id_c,  true),
                new (task_id_d,  true),
                new (task_id_e,  false),
            };
            List<int> incompletedTaskIds = taskId_completionStatus.Where(x => !x.Item2).Select(x => x.Item1).ToList();
            foreach (var (taskId, status) in taskId_completionStatus)
            {
                if (!status)
                    core.ToggleTaskCompletion(taskId);
            }

            //assert
            var completedTasks = core.GetTaskList_completed();

            //assert
            foreach (var task in completedTasks)
            {
                Assert.Contains(task.Id, incompletedTaskIds);
            }
            Assert.AreEqual(completedTasks.Count, incompletedTaskIds.Count);

        }
        [Test]
        public void taskList_search()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_a = core.AddTask("my a cool Task");
            int task_id_b = core.AddTask("my b coolest Task");
            int task_id_c = core.AddTask("my c very Task");
            int task_id_d = core.AddTask("my d fine Task");
            int task_id_e = core.AddTask("my e fine Task");
            int task_id_f = core.AddTask("ye its abc");
            List<Tuple<List<int>, string>> searchPhrase_ExpectedIdMatches_pairs = new List<Tuple<List<int>, string>>
            {
                new (new List<int>{task_id_a, task_id_b}, "cool" ),
                new (new List<int>{task_id_a,task_id_b,task_id_c,task_id_d,task_id_e,}, "my" ),
                new (new List<int>{task_id_d,task_id_e,}, "fine" ),
                new (new List<int>{task_id_b,task_id_c,task_id_d,task_id_e,}, "e" ),
                new (new List<int>{task_id_b,task_id_f,}, "b" ),
            };


            //assert
            foreach (var (expectedMatch_ids, searchText) in searchPhrase_ExpectedIdMatches_pairs)
            {
                var results = core.SearchTask(searchText);
                var resultIds = results.Select(x => x.Id).ToList();
                foreach (int expectedMatch in expectedMatch_ids)
                {
                    Assert.Contains(expectedMatch, resultIds);
                }
            }

        }
        [Test]
        public void taskList_removeTask()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_a = core.AddTask("my a cool Task");
            int task_id_b = core.AddTask("my b coolest Task");
            int task_id_c = core.AddTask("my c very Task");
            int task_id_d = core.AddTask("my d fine Task");
            int task_id_e = core.AddTask("my e fine Task");
            int task_id_f = core.AddTask("ye its abc");

            //act
            int pre_nr_tasks = core.NrOfTasks;
            core.RemoveTask(task_id_a);
            TaskEntry? entry = core.GetTask(task_id_a);

            //assert
            Assert.AreEqual(pre_nr_tasks, core.NrOfTasks+1);
            Assert.IsNull(entry);

        }
        [Test]
        public void taskList_getOrderAscending()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_b = core.AddTask("b");
            int task_id_d = core.AddTask("d");
            int task_id_a = core.AddTask("a");
            int task_id_e = core.AddTask("e");
            int task_id_f = core.AddTask("f");
            int task_id_c = core.AddTask("c");

            var expectedOrder = new List<string>
            {
                "a",
                "b",
                "c",
                "d",
                "e",
                "f",
            };

            //act
            core.SetTaskOrder_Ascending();
            var allTasks = core.GetTaskList_all();


            //assert
            for (int i = 0; i < allTasks.Count; i++)
            {
                var task = allTasks[i];
                var expected = expectedOrder[i];
                Assert.AreEqual(expected, task.Name); 
            }

        }
        [Test]
        public void taskList_getOrderDescending()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_b = core.AddTask("b");
            int task_id_d = core.AddTask("d");
            int task_id_a = core.AddTask("a");
            int task_id_e = core.AddTask("e");
            int task_id_f = core.AddTask("f");
            int task_id_c = core.AddTask("c");

            var expectedOrder = new List<string>
            {
                "f",
                "e",
                "d",
                "c",
                "b",
                "a",
            };

            //act
            core.SetTaskOrder_Descending();
            var allTasks = core.GetTaskList_all();


            //assert
            for (int i = 0; i < allTasks.Count; i++)
            {
                var task = allTasks[i];
                var expected = expectedOrder[i];
                Assert.AreEqual(expected, task.Name); 
            }

        }
        
        [Test]
        public void taskList_getOrderByAsAdded()
        {
            //Arrange
            TodoList core = new TodoList();
            int task_id_a = core.AddTask("first");
            int task_id_b = core.AddTask("second");
            int task_id_c = core.AddTask("third");
            int task_id_d = core.AddTask("fourth");
            int task_id_e = core.AddTask("fifth");
            int task_id_f = core.AddTask("sixth");

            var expectedOrder = new List<string>
            {
                "first",
                "second",
                "third",
                "fourth",
                "fifth",
                "sixth",
            };

            //act

            // Changing order, just because sortByAsAdded is default...
            core.SetTaskOrder_Descending();
            var dummy = core.GetTaskList_all();

            core.SetTaskOrder_asAdded();
            var allTasks = core.GetTaskList_all();


            //assert
            for (int i = 0; i < allTasks.Count; i++)
            {
                var task = allTasks[i];
                var expected = expectedOrder[i];
                Assert.AreEqual(expected, task.Name);
            }

        }
        
        [Test]
        public void taskList_editTaskname()
        {
            //Arrange
            TodoList core = new TodoList();
            string initName = "My initial task Name";
            string newName = "myNewName";
            int taskId = core.AddTask(initName);

            //act
            core.EditTaskName(taskId, newName);

            //assert
            TaskEntry? renamedTask = core.GetTask(taskId);
            if (renamedTask != null)
                Assert.AreEqual(renamedTask.Name, newName);
            else
                Assert.Fail();

        }
    }
}