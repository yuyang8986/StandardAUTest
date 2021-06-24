﻿using System;
using StandardsAUTest.Domain.Types;

namespace StandardsAUTest.Domain.Entities.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public double SumOfValue { get; set; }
        public double MonthlyExpensesTotal { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }
    }
}