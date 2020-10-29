using AutoMapper;
using MedicalClinic.Domain.Entities;
using MedicalClinic.Domain.Interfaces;
using MedicalClinic.Domain.Models;
using MedicalClinic.Infra.Data.Contexts;
using MedicalClinic.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Service
{
    /// <summary>
    /// Serviço Paciênte
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _repository;
        private IMapper _mapper;

        public CustomerService(MedicalClinicDbContext context, IMapper mapper)
        {
            _repository = new CustomerRepository(context);
            _mapper = mapper;
        }

        public CustomerModel Create(CreateCustomerModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var customerEntity = _mapper.Map<CustomerEntity>(model);
                _repository.SaveCustomer(customerEntity);

                return _mapper.Map<CustomerModel>(customerEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            _repository = null;
        }

        public CustomerModel GetCustomerById(long id)
        {
            try
            {
                var customer = _repository.GetCustomerById(id);
                return _mapper.Map<CustomerModel>(customer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            try
            {
                var customers = _repository.GetCustomers();
                return _mapper.Map<IEnumerable<CustomerModel>>(customers);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CustomerModel Update(UpdateCustomerModel model)
        {
            try
            {
                if (model.Invalid)
                    return default;

                var CustomerEntity = _mapper.Map<CustomerEntity>(model);
                _repository.SaveCustomer(CustomerEntity);

                return _mapper.Map<CustomerModel>(CustomerEntity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
