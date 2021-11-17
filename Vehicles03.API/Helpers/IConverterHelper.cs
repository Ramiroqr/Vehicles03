using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicles03.API.Data.Entities;
using Vehicles03.API.Models;

namespace Vehicles03.API.Helpers
{
    public interface IConverterHelper
    {
        Task<User> ToUserAsync(UserViewModel model, Guid imageId, bool isNew);

        UserViewModel ToUserViewModel(User user);
    }
}
