using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class ToDoAddRequest
    {
        public Guid UserID { get; set; }
        public string? ToDoMessage { get; set; }

        public ToDo ToToDo()
        {
            return new ToDo()
            {
                UserID = UserID,
                ToDoMessage = ToDoMessage,
                Created = DateTime.Now,
                ToDoID = Guid.NewGuid(),
            };
        }
    }
}
