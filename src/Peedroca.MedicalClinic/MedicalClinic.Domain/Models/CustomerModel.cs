using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Models
{
    /// <summary>
    /// Modelo de paciênte
    /// </summary>
    public class CustomerModel
    {
        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="id">Identificação</param>
        /// <param name="name">Nome</param>
        /// <param name="phone">Telefone</param>
        public CustomerModel(long id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Phone { get; }
    }
}
