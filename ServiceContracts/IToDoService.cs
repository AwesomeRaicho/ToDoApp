using Entities;
using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface IToDoService
    {

        //Add Todo
        Task<ToDoResponse> AddToDo(ToDoAddRequest request);

        //Get Todo
        Task<ToDoResponse> GetToDoTask(Guid? toDoID);

        //delete todo
        Task<bool> RemoveToDo(Guid? toDoID);

        //update todo
        Task<ToDoResponse> UpdateToDo(Guid? toDoID);
        
        //Get All Todos
        Task<IList<ToDoResponse>> GetAllToDos(Guid? userID);
    }
}