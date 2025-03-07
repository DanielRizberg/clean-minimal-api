﻿namespace ApiContracts.Requests
{
    public class UpdateCustomerRequest
    {
        public Guid Id { get; init; }

        public string Username { get; init; } = default!;

        public string FullName { get; init; } = default!;

        public string Email { get; init; } = default!;

        public DateTime DateOfBirth { get; init; }
    }
}
