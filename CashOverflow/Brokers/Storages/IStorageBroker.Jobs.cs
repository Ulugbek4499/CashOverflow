﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System.Linq;
using CashOverflow.Models.Jobs;

namespace CashOverflow.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        IQueryable<Job> SelectAllJobs();
    }
}