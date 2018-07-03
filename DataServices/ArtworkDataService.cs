﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using FarSolution.DataAccess;
using FarSolution.DataServices.Helpers;

namespace FarSolution.DataServices
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
