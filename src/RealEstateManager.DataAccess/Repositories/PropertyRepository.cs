using RealEstateManager.DataAccess.Repositories.Contracts;
using RealEstateManager.Database;
using RealEstateManager.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateManager.DataAccess.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly RealEstateContext _dbContext;

        public PropertyRepository(RealEstateContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Property> GetAll()
        {
            return _dbContext.Properties;
        }

        public Property GetById(int id)
        {
            return _dbContext.Properties.SingleOrDefault(x => x.Id == id);
        }

        public Property Add(Property property)
        {
            _dbContext.Properties.Add(property);
            _dbContext.SaveChanges();
            return property;
        }
    }
}