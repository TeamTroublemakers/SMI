using SMI.Common.Interfaces;
using SMI.Common.Util;
using SMI.DataAccess.Models;

namespace SMI.DataAccess.Services.Interfaces;

public interface IUserRepository : IRepository<User>
{
    Task<Result> RegisterAsync(User user);
    Task<Result> LoginAsync(string email, string password);
}