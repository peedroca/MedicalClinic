using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MedicalClinic.Infra.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private MedicalClinicDbContext _context;

        public CustomerRepository(MedicalClinicDbContext context)
        {
            _context = context;
        }

        public CustomerEntity GetCustomerById(long id)
        {
            return _context.Customers
                .AsNoTracking()
                .Where(w => w.Id == id)
                .SingleOrDefault();
        }

        public IEnumerable<CustomerEntity> GetCustomers()
        {
            return _context.Customers
                .AsNoTracking()
                .ToList();
        }

        public void SaveCustomer(CustomerEntity entity)
        {
            if (entity.Id == 0)
                _context.Add(entity);
            else
                _context.Update(entity);

            _context.SaveChanges();
        }
    }
}
