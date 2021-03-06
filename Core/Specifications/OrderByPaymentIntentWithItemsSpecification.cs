using System;
using System.Linq.Expressions;
using Core.Entities.OrderAggregate;

namespace Core.Specifications
{
    public class OrderByPaymentIntentIdSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentIdSpecification(string paymentIntentId) : base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}

// namespace Core.Specifications
// {
//     public class OrderByPaymentIntentWithItemsSpecification : BaseSpecifcation<Order>
//     {
//         public OrderByPaymentIntentWithItemsSpecification(string paymentIntentId) 
//             : base(o => o.PaymentIntentId == paymentIntentId)
//         {
//         }
//     }   
// }