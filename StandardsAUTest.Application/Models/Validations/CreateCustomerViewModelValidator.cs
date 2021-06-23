﻿using FluentValidation;
using StandardsAUTest.Application.Models.ViewModels;

namespace StandardsAUTest.Application.Models.Validations
{
    public class CreateCustomerViewModelValidator : AbstractValidator<CreateCustomerViewModel>
    {
        public CreateCustomerViewModelValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.DateOfBirth).NotEmpty();
            RuleFor(c => c.Age).NotEmpty();
        }
    }
}