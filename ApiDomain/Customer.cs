using ApiDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDomain
{
    public class Customer
    {
        public CustomerId Id { get; init; } = CustomerId.From(Guid.NewGuid());

        public Username Username { get; init; } = default!;

        public FullName FullName { get; init; } = default!;

        public EmailAddress Email { get; init; } = default!;

        public DateOfBirth DateOfBirth { get; init; } = default!;
    }

}
