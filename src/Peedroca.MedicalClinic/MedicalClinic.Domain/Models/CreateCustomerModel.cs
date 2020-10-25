using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalClinic.Domain.Models
{
    /// <summary>
    /// Modelo de criação de paciênte
    /// </summary>
    public class CreateCustomerModel : Notifiable
    {
        /// <summary>
        /// Contrutor
        /// </summary>
        /// <param name="name">Nome</param>
        /// <param name="phone">Telefone</param>
        public CreateCustomerModel(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

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
