﻿using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpenseUseCase: IRegisterExpenseUseCase
    {
        private readonly IExpensesRepository _repository;
        private readonly IUnitOfWork _unitOfWorky;

        public RegisterExpenseUseCase(IExpensesRepository repository, IUnitOfWork unitOfWorky)
        {
            _repository = repository;
            _unitOfWorky = unitOfWorky;
        }

        public ResponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
        {
            Validate(request);

            var entity = new Expense
            {
                Amount = request.Amount,
                Date = request.Date,
                Description = request.Description,
                Title = request.Title,
                PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
            };

            _repository.Add(entity);

            _unitOfWorky.Commit();

            return new ResponseRegisteredExpenseJson();
        }

        private void Validate(RequestRegisterExpenseJson request)
        {
           
            var validator = new RegisterExpenseValidator();

            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorMessages);
            }
            
        }
    }
}
