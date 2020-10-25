using MedicalClinic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Interfaces
{
    public interface ICustomerService : IDisposable
    {
        CustomerModel Create(CreateCustomerModel model);

        CustomerModel Update(UpdateCustomerModel model);

        IEnumerable<CustomerModel> GetCustomers();

        CustomerModel GetCustomerById(long id);
    }
}
