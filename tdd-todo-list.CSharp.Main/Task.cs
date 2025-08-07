using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task(string id, string desc, int priority, bool completed, string category)
    {
        private string _id = id;
        private string _desc = desc;
        private int _priority = priority;
        private bool _completed = completed;
        private string _category = category;
        private DateTime _created = DateTime.Now;
        private DateTime _finished;
        private TimeSpan _duration;

        public string Id { get => _id; set => _id = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public int Priority { get => _priority; set => _priority = value; }
        public bool Completed { get => _completed; set => _completed = value; }
        public string Category { get => _category; set => _category = value; }
        public DateTime Created { get => _created; }
        public DateTime Finished { get => _finished; set => _finished = value; }
        public TimeSpan Duration { get => _duration; set => _duration = value; }


        public TimeSpan calculateDuration()
        {
            TimeSpan duration = this._created.Subtract(this._finished);
            this._duration = duration;
            return duration;
        }

    }


}
