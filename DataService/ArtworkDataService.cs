using System.Collections.Generic;
using System.Linq;
using Contracts;
using DataService.Helpers;
using FarSolution.DataAccess;

namespace DataService
{
    public class ArtworkDataService
    {
        public IEnumerable<Artwork> GetAllArtworks()
        {
            List<Artwork> result;

            using (var context = new VeliDb())
            {
                result = context.Artworks.Select(item => Extensions.MapToContract(item)).ToList();
            }

            return result;
        }
    }
}
