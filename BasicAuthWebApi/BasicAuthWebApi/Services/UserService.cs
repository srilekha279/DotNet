using BasicAuthWebApi.Models;

namespace BasicAuthWebApi
{
    public class UserService
    {
        UserDbContext context = null;

        public UserService(UserDbContext ctr)
        {
            context = ctr;
        }

        public List<User> GetUserList()
        {
            return context.Users.ToList();
        }

        public User? GetUserbyId(int id)
        {
            return context.Users.FirstOrDefault(u => u.Id == id);
        }
        public int AddUser(User user)
        {
            context.Users.Add(user);
            return context.SaveChanges();
        }
        public int UpdateUser(User user)
        {
            var existingUser = context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser == null) return 0;

            existingUser.FullName = user.FullName;
            existingUser.Email = user.Email;
            existingUser.PasswordHash = user.PasswordHash;
            existingUser.Role = user.Role;

            return context.SaveChanges();
        }
        public int DeleteUser(int id)
        {
            var user = context.Users.FirstOrDefault(u => u.Id == id);
            if (user == null) return 0;

            context.Users.Remove(user);
            return context.SaveChanges();
        }
    }
}
