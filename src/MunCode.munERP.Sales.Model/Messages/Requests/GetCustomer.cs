﻿namespace MunCode.munERP.Sales.Model.Messages.Requests
{
    using MunCode.Core.Design.Domain;
    using MunCode.Core.Messaging.Endpoints.Filters.Caching;
    using MunCode.Core.Messaging.Messages;
    using MunCode.munERP.Sales.Model.Read;

    [Cached]
    public class GetCustomer : ValueObject<GetCustomer>, IRequest<Customer>
    {
        public GetCustomer(int customerId)
        {
            this.CustomerId = customerId;
        }

        public int CustomerId { get; }
    }
}