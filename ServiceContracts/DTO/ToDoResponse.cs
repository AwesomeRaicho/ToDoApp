using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public class ToDoResponse
    {
        public Guid ToDoID { get; set; }
        public DateTime? Created { get; set; }
        public string? ToDoMessage { get; set; }
        public Guid UserID { get; set; }

        public ToDoUpdateRequest GetUpdateRequest()
        {
            return new ToDoUpdateRequest
            {
                ToDoID = ToDoID,
                Created = Created,
                ToDoMessage = ToDoMessage,
                UserID = UserID
            };
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(ToDoResponse)) return false;

            ToDo other = (ToDo)obj;

            return
                ToDoID == other.ToDoID &&
                Created == other.Created &&
                ToDoMessage == other.ToDoMessage &&
                UserID == other.UserID;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }


    }

    public static class ToDoExtension
    {
        public static ToDoResponse ToToDoResponse(this ToDo toDo)
        {
            return new ToDoResponse()
            {
                ToDoID = toDo.ToDoID,
                Created = toDo.Created,
                ToDoMessage = toDo.ToDoMessage,
                UserID = toDo.UserID
            };
        }
    }
}
