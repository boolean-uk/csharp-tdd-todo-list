namespace tdd_todo_list.CSharp.Main
{
    using System;
    using System.Collections.Generic;

    namespace tdd_todo_list.CSharp.Main
    {
        public class TaskExtension
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public bool IsComplete { get; set; }
            public DateTime CreatedAt { get; set; }

            public TaskExtension(string name)
            {
                Id = Guid.NewGuid();
                Name = name;
                IsComplete = false;
                CreatedAt = DateTime.Now;
            }
        }

        public class TodoListExtension
        {
            public List<TaskExtension> tasks;

            public TodoListExtension()
            {
                tasks = new List<TaskExtension>();
            }

            public void AddTask(string name)
            {
                tasks.Add(new TaskExtension(name));
            }

            public TaskExtension GetTaskById(Guid id)
            {
                return tasks.Find(t => t.Id == id);
            }

            public void UpdateTaskName(Guid id , string newName)
            {
                var task = tasks.Find(t => t.Id == id);
                if(task != null)
                {
                    task.Name = newName;
                }
            }

            public void ChangeTaskStatus(Guid id , bool isComplete)
            {
                var task = tasks.Find(t => t.Id == id);
                if(task != null)
                {
                    task.IsComplete = isComplete;
                }
            }

            public DateTime GetTaskCreationTime(Guid id)
            {
                var task = tasks.Find(t => t.Id == id);
                return task?.CreatedAt ?? default;
            }
        }
    }

}
