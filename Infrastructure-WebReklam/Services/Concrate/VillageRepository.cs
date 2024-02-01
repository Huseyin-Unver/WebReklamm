﻿using ApplicationCore_WebReklam.Entities.Concrete;
using Infrastructure_WebReklam.Context;
using Infrastructure_WebReklam.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_WebReklam.Services.Concrate
{
    public class VillageRepository : BaseRepository<Village>, IVillageRepository
    {
        public VillageRepository(AppDbContext context) : base(context)
        {
        }

        public void deneme()
        {
            throw new NotImplementedException();
        }
    }
}
