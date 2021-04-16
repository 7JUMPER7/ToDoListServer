using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListServer.Classes
{
    class Group
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public List<Note> Notes { get; set; }
    }
}
