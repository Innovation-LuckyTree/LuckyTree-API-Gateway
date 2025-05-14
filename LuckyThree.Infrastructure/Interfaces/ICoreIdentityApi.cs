using LuckyThree.Common.Interfaces;
using LuckyThree.Infrastructure.Identity.Models.Requests;
using LuckyThree.Infrastructure.Identity.Models.Responses;

namespace LuckyThree.Infrastructure.Interfaces;

public interface ICoreIdentityApi
{
    Task<ApiResponse<LoginUserResponse>> LoginUser(string userName, string password, string ipAddress, CancellationToken cancellationToken);
    Task<object> GenerateRefreshToken(RefreshTokenRequest request, CancellationToken cancellationToken);
    Task<object> UnLockedUser(Guid UserAccountId, CancellationToken cancellationToken);
}
