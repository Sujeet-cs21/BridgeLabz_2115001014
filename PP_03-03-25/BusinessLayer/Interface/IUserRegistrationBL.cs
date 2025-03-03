using ModelLayer.DTO;

namespace BusinessLayer.Interface
{
    public interface IUserRegistrationBL
    {
        public bool RegisterUserBL(RegistrationDTO newUser);
        public List<RegistrationDTO> GetAllUsers();
    }
}
