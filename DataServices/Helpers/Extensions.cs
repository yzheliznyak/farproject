using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using FarSolution.DataAccess.Entities;

namespace FarSolution.DataServices.Helpers
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
