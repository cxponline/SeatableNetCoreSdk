using JackieSoft.SeatableNetCoreSdk.Domain;
using System.Threading.Tasks;

namespace JackieSoft.SeatableNetCoreSdk.DTableWeb
{
    public interface IWorkSpaceService
    {
        Task<SeatableWorkSpaceModel> GetWorkSpacesAsync(string token);
        Task<SeatableWorkSpaceDetailModel> GetWorkSpacesDetailAsync(string token);
    }
}
