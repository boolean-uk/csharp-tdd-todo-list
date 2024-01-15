using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Todo
{
        private int _id;
        private string _description;
        private string _status;
        private DateTime _dateTime;

        public Todo (int id, string description, string status)
        {
            _id = id;
            _description = description;
            _status = status;
            _dateTime = DateTime.Now;
        }

        public Todo()
        {

        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Status { get { return _status; } set { _status = value; } }
        public DateTime DateTime { get { return _dateTime; } set { _dateTime = value; } }
}
}
