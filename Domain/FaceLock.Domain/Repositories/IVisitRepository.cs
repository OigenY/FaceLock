﻿using FaceLock.Domain.Entities.PlaceAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceLock.Domain.Repositories
{
    public interface IVisitRepository : IRepository<Visit>
    {
        Task<List<Visit>> GetVisitsByUserIdAsync(string userId);
        Task<List<Visit>> GetVisitsByPlaceIdAsync(int roomId);
    }
}
