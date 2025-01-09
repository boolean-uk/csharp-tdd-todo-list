using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskEntry : IComparable<TaskEntry>
    {
        private string _name = "undefined";
        private bool _completed = false;
        private int _id = -1;
        public DateTime _date = DateTime.Now;
        public string Name { get => _name; set => _name = value; }
        public bool Completed { get => _completed; set => _completed = value; }
        public DateTime CreationDate { get => _date;}
        public int Id { get => _id; }

        
        public TaskEntry(string taskName, int assignedId)
        {
            this.Name = taskName;
            this._id = assignedId;
        }

        private class SortByDate : IComparer<TaskEntry>
        {
            public int Compare(TaskEntry? x, TaskEntry? y)
            {
                if ( x == null || y == null)
                    return 0;
                
                return x._date.CompareTo(y._date);
            }
        }
        private class SortByName_ascending : IComparer<TaskEntry>
        {
            public int Compare(TaskEntry? x, TaskEntry? y)
            {
                if (x == null || y == null)
                    return 0;
                return x._name.CompareTo(y._name);
            }
        }
        private class SortByName_descending : IComparer<TaskEntry>
        {
            public int Compare(TaskEntry? x, TaskEntry? y)
            {
                if (x == null || y == null)
                    return 0;
                return x._name.CompareTo(y._name) * -1;
            }
        }
        public static IComparer<TaskEntry> get_SortByDate()
        {
            return  new SortByDate();
        }
        public static IComparer<TaskEntry> get_SortByName_ascending()
        {
            return new SortByName_ascending();
        }
        public static IComparer<TaskEntry> get_SortByName_descending()
        {
            return  new SortByName_descending();
        }

        public int CompareTo(TaskEntry? other)
        {
            return get_SortByDate().Compare(this,other);
        }
    }
}
