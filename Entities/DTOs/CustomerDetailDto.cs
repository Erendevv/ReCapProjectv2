﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entitites;

namespace Entities.DTOs
{
    public class CustomerDetailDto : IDto
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
