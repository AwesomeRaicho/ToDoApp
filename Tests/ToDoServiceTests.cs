using ServiceContracts;
using ServiceContracts.DTO;
using Services;

namespace Tests
{
    public class ToDoServiceTests
    {
        private readonly IToDoService _toDoService;

        public ToDoServiceTests(IToDoService toDoService) 
        {
            _toDoService = toDoService;
        }

        [Fact]
        public async Task AddToDo_ProperAdd()
        {
            //Arrange
            ToDoAddRequest request = new ToDoAddRequest()
            {
                UserID = Guid.NewGuid(),
                ToDoMessage = "Somethinfg in the way",
            };


            //Act
            ToDoResponse? response = await _toDoService.AddToDo(request);
            //Assert

            Assert.True(response.Created != null);
            Assert.True(response.ToDoID != Guid.Empty);
            Assert.Equal(request.UserID, response.UserID);

        }
    }
}