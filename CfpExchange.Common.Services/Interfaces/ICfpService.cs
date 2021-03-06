﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CfpExchange.Common.Models;

namespace CfpExchange.Common.Services.Interfaces
{
    public interface ICfpService
    {
        Cfp GetCfpById(Guid id);

        Cfp GetCfpBySlug(string slug);

        List<Cfp> GetAllActiveCfps();

        List<Cfp> GetAllActiveCfps(string lowercaseSearchTerm, DateTime startDateTime, DateTime endDateTime, int pageToShow);

        List<Cfp> GetNewestActiveCfps(int pageToShow);

        List<Cfp> IsAlreadyInDatabase(Uri parsedUri);

        bool CfpWithIdenticalSlugExists(string cfpToAddSlug);

        void AddCfp(Cfp cfpToAdd);

        Task AddCfpAsync(Cfp cfpToAdd);

        Task SaveChangesAsync();
    }
}
