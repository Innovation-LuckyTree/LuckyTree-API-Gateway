using LuckyThree.Common.Interfaces;
using LuckyThree.Infrastructure.Game.Models.Response;

namespace LuckyThree.Infrastructure.Interfaces;

public interface IGameApi
{
    #region CompanyGame
        Task<ApiResponse<CompanyGameListResponse>> GetCompanyGameListAsync(string companyId, CancellationToken cancellationToken = default);
    #endregion
}