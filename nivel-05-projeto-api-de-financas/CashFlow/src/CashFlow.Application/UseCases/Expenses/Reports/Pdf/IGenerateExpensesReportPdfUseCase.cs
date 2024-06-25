﻿namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf
{
    public interface IGenerateExpensesReportPdfUseCase
    {
        Task<byte[]> Execute(string month);
    }
}
