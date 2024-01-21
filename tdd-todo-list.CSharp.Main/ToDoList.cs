using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public enum SortOrder
    {
        NotSorted,
        Ascending,
        Descending
    }
    public class TodoList
    {
        private List<TodoTask> _tasks;


        public TodoList()
        {
            _tasks = new List<TodoTask>();
        }

        public void AddTask(string description)
        {
            Tasks.Add(new TodoTask(description));
        }

        public void RemoveTask(int index = -1)
        {
            Tasks.RemoveAt(EnsureValidTaskIndex(index));
        }

        public void CompleteTask(int index = -1)
        {
            if (index <= -1) Tasks[FirstIncompleteTaskIndex()].MarkDone();
            else Tasks[EnsureValidTaskIndex(index)].MarkDone();
        }

        public void IncompleteTask(int index = -1)
        {
            if (index <= -1) Tasks[FirstCompleteTaskIndex()].MarkUndone();
            else Tasks[EnsureValidTaskIndex(index)].MarkUndone();
        }

        public List<TodoTask> GetAllTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            return SortTasksByDescription(Tasks, sortOrder);
        }

        public List<TodoTask> GetCompletedTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoTask> completedTasks = Tasks.Where(task => task.IsDone).ToList();
            return SortTasksByDescription(completedTasks, sortOrder);
        }

        public List<TodoTask> GetIncompleteTasks(SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoTask> incompleteTasks = Tasks.Where(task => !task.IsDone).ToList();
            return SortTasksByDescription(incompleteTasks, sortOrder);
        }

        public List<TodoTask> GetTasksWithSubstring(string substr, SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoTask> tasksWithSubstring = Tasks.Where(task => task.Description.ToLower().Contains(substr.ToLower())).ToList();
            return SortTasksByDescription(tasksWithSubstring, sortOrder);
        }

        public string SearchTasks(string substr, SortOrder sortOrder = SortOrder.NotSorted)
        {
            List<TodoTask> tasksWithSubstring = GetTasksWithSubstring(substr, sortOrder);
            if (tasksWithSubstring.Count > 0) return TaskListToString(tasksWithSubstring);
            return "No results.";
        }

        public string TaskListToString(List<TodoTask> tasks)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < tasks.Count; i++)
            {
                output.AppendLine(tasks[i].ToString());
            }
            return output.ToString();
        }

        public List<TodoTask> Tasks {  get { return _tasks; } }

        public override string ToString()
        {
            if (Tasks.Count == 0 )
            {
                return "No tasks found.";
            }
            return TaskListToString(Tasks);
        }

        private int EnsureValidTaskIndex(int index)
        {
            if (index <= -1)
            {
                return Tasks.Count - 1;
            }
            else if (index >= Tasks.Count) throw new IndexOutOfRangeException();
            else return index;
        }

        private int FirstIncompleteTaskIndex()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (!Tasks[i].IsDone) return i;
            }
            return 0;
        }

        private int FirstCompleteTaskIndex()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (Tasks[i].IsDone) return i;
            }
            return 0;
        }

        private List<TodoTask> SortTasksByDescription(List<TodoTask> tasks, SortOrder sortOrder)
        {
            switch (sortOrder)
            {
                case SortOrder.Ascending:
                    return tasks.OrderBy(t => t.Description, StringComparer.InvariantCultureIgnoreCase).ToList();
                case SortOrder.Descending:
                    return tasks.OrderByDescending(t => t.Description, StringComparer.InvariantCultureIgnoreCase).ToList();
                default:
                    return tasks;
            }
        }


    }
}
