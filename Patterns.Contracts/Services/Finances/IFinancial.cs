namespace Patterns.Contracts.Services.Finances
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    #endregion
    public interface IFinancial
    {
        IEnumerable<IEmployee> SetTotalSalary();
    }
}