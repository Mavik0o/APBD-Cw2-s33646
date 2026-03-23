using UczelnianaWypozyczalniaSprzetuProjekt.Exceptions;
using UczelnianaWypozyczalniaSprzetuProjekt.Models;

namespace UczelnianaWypozyczalniaSprzetuProjekt.Services.Users;

public class UsersService
{
    private readonly List<Uzytkownik> _users = [];

    public void AddUser(Uzytkownik user)
    {
        _users.Add(user);
    }

    public Uzytkownik GetById(int id)
    {
        return _users.FirstOrDefault(u => u.Id == id)
               ?? throw new UserNotFoundException(id);
    }

    public List<Uzytkownik> GetAll()
    {
        return _users;
    }
}