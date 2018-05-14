using System.Collections.Generic;

namespace FitnessCenter.Shared
{
    public interface ILogic : IData
    {
        List<UserViewModel> GetUsersViewModel();
    }
}
