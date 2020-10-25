using MedicalClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Interfaces
{
    /// <summary>
    /// Interface do Repositório Paciênte
    /// </summary>
    public interface ICustomerRepository
    {
        void SaveCustomer(CustomerEntity entity);

        IEnumerable<CustomerEntity> GetCustomers();

        CustomerEntity GetCustomerById(long id);
    }
}
