using TeamCollaboration.Models.Financial;

namespace TeamCollaboration.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}