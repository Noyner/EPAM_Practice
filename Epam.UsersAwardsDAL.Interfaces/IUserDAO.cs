using System;
using Epam.UsersAwards.Entities;
using System.Collections.Generic;

namespace Epam.UsersAwardsDAL.Interfaces
{
    public interface IUserDAO
    {
        User AddUser(User user);

        void DeleteUser(Guid id);

        void EditUser(Guid id, string newName, DateTime newDateTimeOfBirth, int newAge);

        IEnumerable<User> AllUsers(bool orderedById = true);
    }
}
