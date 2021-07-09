using Epam.UsersAwardsDAL.Interfaces;
using Epam.UsersAwards.SqlDAL;
using Epam.UsersAwards.BLL.Interfaces;
using Epam.UsersAwards.BLL;

namespace Epam.UsersAwards.Dependences
{
    public class DependencyResolver
    {
        private static DependencyResolver _instance;

        public static DependencyResolver Instance()
        {
            if (_instance == null)
            {
                _instance = new DependencyResolver();
            }
            return _instance;
        }
        public IUserDAO UserDAO => new UserSqlDAO();

        public IUserLogic UserLogic => new UserLogic(UserDAO);

        public IAwardDAO AwardDAO => new AwardSqlDAO();

        public IAwardLogic AwardLogic => new AwardLogic(AwardDAO);
    }
}
