using RealEstateManager.Database.Models;
using System.Collections.Generic;

namespace RealEstateManager.DataAccess.Repositories.Contracts
{
    public interface IPaymentRepository
    {
        IEnumerable<Payment> GetAllForProperty(int propertyId);
        IEnumerable<Payment> GetAllForProperty(int propertyId, int lastAmount);
    }
}