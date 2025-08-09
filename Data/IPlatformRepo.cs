using PlatformService.Models;
namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        Task<IEnumerable<Platform>> GetAllPlatforms();
        Task<Platform?> GetPlatformById(int id);
        Task CreatePlatform(Platform platform);
        Task DeletePlatform(int id);
        Task<bool> SaveChanges();
    }
}
