﻿using ApiContracts.Data;
using ApiDomain;
using ApiDomain.Common;

namespace ApiMapper
{
    public static class DtoToDomainMapper
    {
        public static Customer ToCustomer(this CustomerDto customerDto)
        {
            return new Customer
            {
                Id = CustomerId.From(Guid.Parse(customerDto.Id)),
                Email = EmailAddress.From(customerDto.Email),
                Username = Username.From(customerDto.Username),
                FullName = FullName.From(customerDto.FullName),
                DateOfBirth = DateOfBirth.From(DateOnly.FromDateTime(customerDto.DateOfBirth))
            };
        }
    }
}
