﻿using Microsoft.EntityFrameworkCore;
using StandardsAUTest.Domain.Entities;

namespace StandardsAUTest.Infrastructure.Persistance
{
    public interface IDataContext
    {
        DbSet<Customer> Customers { get; set; }
    }
}