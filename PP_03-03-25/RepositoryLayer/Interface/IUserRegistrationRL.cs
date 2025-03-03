using ModelLayer.DTO;
namespace RepositoryLayer.Interface
{
    public interface IUserRegistrationRL
    {
        public bool RegisterUserRL(RegistrationDTO newUser);
        public List<RegistrationDTO> GetAllUsers();
    }
}
