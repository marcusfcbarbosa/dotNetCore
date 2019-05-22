using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using ProAgil.Shared.ValueObjects;
using FluentValidator;
using FluentValidator.Validation;

namespace ProAgil.Domain.ValueObjects
{
    public class Email : Notifiable
    {
       public Email(string address)
        {
            Address = address;
            AddNotifications(new ValidationContract()
            .Requires()
            .IsEmail(Address, "Email.Address", "E-mail inválido")
            );
        }
        public String Address { get; private set; }
    }
}