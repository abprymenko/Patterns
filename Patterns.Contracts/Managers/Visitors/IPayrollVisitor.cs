namespace Patterns.Contracts.Managers.Visitors
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    #endregion
    public interface IPayrollVisitor
    {
        double? VisitPayroll(IHourlyEmployee employee);
        double? VisitPayroll(ISalariedEmployee employee);
    }
}