﻿namespace ApiContracts.Responses
{
    public class GetAllCustomersResponse
    {
        public IEnumerable<CustomerResponse> Customers { get; init; } = Enumerable.Empty<CustomerResponse>();
    }
}
