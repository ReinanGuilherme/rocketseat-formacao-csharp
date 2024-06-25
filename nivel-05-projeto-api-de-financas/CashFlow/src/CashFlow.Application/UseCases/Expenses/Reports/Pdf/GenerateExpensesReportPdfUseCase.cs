using CashFlow.Domain.Repositories.Expenses;
using System.Globalization;

namespace CashFlow.Application.UseCases.Expenses.Reports.Pdf
{
    public class GenerateExpensesReportPdfUseCase : IGenerateExpensesReportPdfUseCase
    {
        private const string CURRENCY_SYMBOL = "€";
        private readonly IExpensesReadOnlyRepository _repository;

        public GenerateExpensesReportPdfUseCase(IExpensesReadOnlyRepository repository)
        {
            _repository = repository;
        }

        public async Task<byte[]> Execute(string month)
        {

            DateTime monthFormatter = DateTime.ParseExact(month, "yyyy-MM", CultureInfo.InvariantCulture);

            var expenses = await _repository.FilterByMonth(monthFormatter);
            if (expenses.Count == 0)
            {
                return [];
            }



            return [];
        }
    }
}
