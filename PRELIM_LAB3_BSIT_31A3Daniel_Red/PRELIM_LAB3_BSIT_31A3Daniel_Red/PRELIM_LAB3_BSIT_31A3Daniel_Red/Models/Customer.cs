﻿namespace PRELIM_LAB3_BSIT_31A3Daniel_Red.Models;
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }

        public override string GetDescription()
        {
            return $"Regular Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
