﻿using Epam.UsersAwards.Entities;
using System.Collections.Generic;
using System;

namespace Epam.UsersAwardsDAL.Interfaces
{
    public interface IAwardDAO
    {
        void AddAward(Award award);

        IList<Award> AllAwards();

        void GiveAward(Guid userId, Guid awardId);

        void DeleteAward(Guid id);

        void EditAward(Guid id, string newTitle);
    }
}
