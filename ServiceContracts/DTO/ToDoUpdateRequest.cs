using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class ToDoUpdateRequest
    {
        public Guid ToDoID { get; set; }
        public DateTime? Created { get; set; }
        public string? ToDoMessage { get; set; }
        public Guid UserID { get; set; }

        public ToDo GetToDo()
        {
            return new ToDo
            {
                ToDoID = ToDoID,
                Created = Created,
                ToDoMessage = ToDoMessage,
                UserID = UserID
            };
        }
    }
}
