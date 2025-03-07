﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContracts.Data
{
    public class CustomerDto
    {
        public string Id { get; init; } = default!;

        public string Username { get; init; } = default!;

        public string FullName { get; init; } = default!;

        public string Email { get; init; } = default!;

        public DateTime DateOfBirth { get; init; }
    }
}
