﻿using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Sucesso()
        {
            //Arrange
            var validator = new RegisterExpenseValidator();
            var request = new RequestRegisterExpenseJson
            {
                Amount = 100,
                Date = DateTime.Now,
                Description = "description",
                Title = "Apple",
                PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
            };

            //Act
            var result = validator.Validate(request);

            //Assert
            Assert.True(result.IsValid);
        }
    }
}
