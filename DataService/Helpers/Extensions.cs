using Contracts;
using FarSolution.DataAccess.Entities;

namespace DataService.Helpers
{
    public class Extensions
    {
        public static Artwork MapToContract(ArtworkEntity entity)
        {
            return new Artwork()
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }
    }
}
