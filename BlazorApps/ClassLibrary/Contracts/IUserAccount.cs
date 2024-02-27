using ClassLibrary.DTOs;
using static ClassLibrary.DTOs.ServiceResponses;
namespace ClassLibrary.Contracts
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}
