using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;
using TaskStatus = tdd_todo_list.CSharp.Main.TaskStatus;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddTasks_AddsWithFieldsAndAutoIds()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.High, TaskCategory.Work);

            List<Task> all = list.getAllTasks();
            Assert.That(all.Count, Is.EqualTo(2));

            Assert.That(all[0].uid, Is.EqualTo(0));
            Assert.That(all[0].name, Is.EqualTo("Task 1"));
            Assert.That(all[0].description, Is.EqualTo("Desc 1"));
            Assert.That(all[0].priority, Is.EqualTo(TaskPriority.Low));
            Assert.That(all[0].category, Is.EqualTo(TaskCategory.Study));

            Assert.That(all[1].uid, Is.EqualTo(1));
            Assert.That(all[1].name, Is.EqualTo("Task 2"));
            Assert.That(all[1].description, Is.EqualTo("Desc 2"));
            Assert.That(all[1].priority, Is.EqualTo(TaskPriority.High));
            Assert.That(all[1].category, Is.EqualTo(TaskCategory.Work));
        }

        [Test]
        public void GetAllTasks_ReturnsAll()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            List<Task> all = list.getAllTasks();
            Assert.That(all[0].name, Is.EqualTo("Task 1"));
            Assert.That(all[1].name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void ChangeStatus_IncompleteToCompleteAndBack()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Medium, TaskCategory.Admin);

            bool changedToComplete = list.setStatus(0, TaskStatus.Complete);
            Assert.That(changedToComplete, Is.True);

            List<Task> completes = list.getAllTasks(TaskStatus.Complete);
            Assert.That(completes.Count, Is.EqualTo(1));
            Assert.That(completes[0].name, Is.EqualTo("Task 1"));

            bool changedToIncomplete = list.setStatus(0, TaskStatus.Incomplete);
            Assert.That(changedToIncomplete, Is.True);

            List<Task> incompletes = list.getAllTasks(TaskStatus.Incomplete);
            Assert.That(incompletes.Count, Is.EqualTo(1));
            Assert.That(incompletes[0].name, Is.EqualTo("Task 1"));
        }

        [Test]
        public void GetOnlyCompleteTasks()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            list.setStatus(1, TaskStatus.Complete);

            List<Task> completes = list.getAllTasks(TaskStatus.Complete);
            Assert.That(completes.Count, Is.EqualTo(1));
            Assert.That(completes[0].name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void GetOnlyIncompleteTasks()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            list.setStatus(1, TaskStatus.Complete);

            List<Task> incompletes = list.getAllTasks(TaskStatus.Incomplete);
            Assert.That(incompletes.Count, Is.EqualTo(1));
            Assert.That(incompletes[0].name, Is.EqualTo("Task 1"));
        }

        [Test]
        public void SearchByName_ThrowsWhenNotFound()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);

            KeyNotFoundException? ex = Assert.Throws<KeyNotFoundException>(() => list.findTask("Missing"));
            StringAssert.Contains("No task with name \"Missing\"", ex?.Message);
        }

        [Test]
        public void RemoveTask_RemovesById()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            bool removed = list.removeTask(0);
            Assert.That(removed, Is.True);

            List<Task> remaining = list.getAllTasks();
            Assert.That(remaining.Count, Is.EqualTo(1));
            Assert.That(remaining[0].name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void OrderAscending_ByName()
        {
            TodoList list = new TodoList();
            list.addTask("Task 3", "Desc 3", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            List<Task> asc = list.getAllTasks(true);
            Assert.That(asc[0].name, Is.EqualTo("Task 1"));
            Assert.That(asc[1].name, Is.EqualTo("Task 2"));
            Assert.That(asc[2].name, Is.EqualTo("Task 3"));
        }

        [Test]
        public void OrderDescending_ByName()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 3", "Desc 3", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);

            List<Task> desc = list.getAllTasks(false);
            Assert.That(desc[0].name, Is.EqualTo("Task 3"));
            Assert.That(desc[1].name, Is.EqualTo("Task 2"));
            Assert.That(desc[2].name, Is.EqualTo("Task 1"));
        }

        [Test]
        public void PrioritiseTasks_PriorityIsStored()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Medium, TaskCategory.Study);
            list.addTask("Task 3", "Desc 3", TaskPriority.High, TaskCategory.Study);

            List<Task> all = list.getAllTasks();
            Assert.That(all[0].priority, Is.EqualTo(TaskPriority.Low));
            Assert.That(all[1].priority, Is.EqualTo(TaskPriority.Medium));
            Assert.That(all[2].priority, Is.EqualTo(TaskPriority.High));
        }

        [Test]
        public void ListAllTasksByPriority_FilterByPriority()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.High, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 3", "Desc 3", TaskPriority.High, TaskCategory.Study);

            List<Task> highPriority = list.getAllTasks().Where(t => t.priority == TaskPriority.High).ToList();
            Assert.That(highPriority.Count, Is.EqualTo(2));
        }

        [Test]
        public void GetTaskById_ReturnsTask()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Work);

            Task? t = list.getTask(1);
            Assert.That(t?.name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void UpdateNameById_ChangesName()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);
            list.addTask("Task 2", "Desc 2", TaskPriority.Medium, TaskCategory.Work);

            bool ok = list.setName(1, "Task X");
            Assert.That(ok, Is.True);

            Assert.That(list.getTask(1)?.name, Is.EqualTo("Task X"));
            Assert.That(list.getTask(0)?.name, Is.EqualTo("Task 1"));
        }
        [Test]
        public void ChangeStatusById_SetsStatus()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);

            list.setStatus(0, TaskStatus.Complete);
            Assert.That(list.getTask(0)?.status, Is.EqualTo(TaskStatus.Complete));
        }

        [Test]
        public void CreatedDate_IsSetWhenCreated()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);

            Assert.That(list.getTask(0)?.created, Is.Not.EqualTo(default(DateTime)));
        }

        [Test]
        public void CompletedDate_IsSetWhenMarkedComplete()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);

            list.setStatus(0, TaskStatus.Complete);
            Assert.That(list.getTask(0)?.completed, Is.Not.Null);
        }

        [Test]
        public void LongestTimeToComplete_ReturnsMaxDelta()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Admin);

            Task t1 = list.getAllTasks()[0];
            t1.status = TaskStatus.Complete;
            t1.created = new DateTime(2024, 01, 01);
            t1.completed = new DateTime(2024, 01, 03);

            Task t2 = list.getAllTasks()[1];
            t2.status = TaskStatus.Complete;
            t2.created = new DateTime(2024, 02, 01);
            t2.completed = new DateTime(2024, 02, 10);

            Assert.That(list.getLargestTimeDelta(), Is.EqualTo(TimeSpan.FromDays(9)));
        }

        [Test]
        public void CategoriseTasks_CategoryIsStored()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Work);

            List<Task> work = list.getAllTasks(TaskCategory.Work);
            Assert.That(work.Count, Is.EqualTo(1));
            Assert.That(work[0].name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void ListAllTasksByCategory_UsesFilter()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 2", "Desc 2", TaskPriority.Low, TaskCategory.Study);
            list.addTask("Task 3", "Desc 3", TaskPriority.Low, TaskCategory.Admin);

            List<Task> study = list.getAllTasks(TaskCategory.Study);
            Assert.That(study.Count, Is.EqualTo(2));
            Assert.That(study[0].name, Is.EqualTo("Task 1"));
            Assert.That(study[1].name, Is.EqualTo("Task 2"));
        }

        [Test]
        public void TasksCompletedLongerThanFiveDays_FiltersByDuration()
        {
            TodoList list = new TodoList();
            list.addTask("Task 1", "Desc 1", TaskPriority.Low, TaskCategory.Admin);
            list.addTask("Task 2", "Desc 2", TaskPriority.Medium, TaskCategory.Work);
            list.addTask("Task 3", "Desc 3", TaskPriority.High, TaskCategory.Study);

            Task t1 = list.getAllTasks()[0]; // 3 days
            t1.status = TaskStatus.Complete;
            t1.created = new DateTime(2024, 01, 01);
            t1.completed = new DateTime(2024, 01, 04);

            Task t2 = list.getAllTasks()[1]; // 7 days
            t2.status = TaskStatus.Complete;
            t2.created = new DateTime(2024, 02, 01);
            t2.completed = new DateTime(2024, 02, 08);

            Task t3 = list.getAllTasks()[2]; // exactly 5 days
            t3.status = TaskStatus.Complete;
            t3.created = new DateTime(2024, 03, 01);
            t3.completed = new DateTime(2024, 03, 06);

            List<Task> over5 = list.getTasksLongerThan(TimeSpan.FromDays(5));

            Assert.That(over5.Count, Is.EqualTo(1));
            Assert.That(over5[0].name, Is.EqualTo("Task 2"));
        }
    }
}