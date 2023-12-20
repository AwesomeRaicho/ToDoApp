using ServiceContracts;
using ServiceContracts.DTO;
using Entities;

namespace Services
{
    public class ToDoService : IToDoService
    {
        private readonly List<ToDo> _toDos;

        public ToDoService()
        {
            _toDos = new List<ToDo>();
        }

        public Task<ToDoResponse> AddToDo(ToDoAddRequest request)
        {
            throw new NotImplementedException();
        }
        public Task<ToDoResponse> GetToDoTask(Guid? toDoID)
        {
            throw new NotImplementedException();
        }

        public Task<IList<ToDoResponse>> GetAllToDos(Guid? userID)
        {
            throw new NotImplementedException();
        }


        public Task<bool> RemoveToDo(Guid? toDoID)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoResponse> UpdateToDo(Guid? toDoID)
        {
            throw new NotImplementedException();
        }
    }
}