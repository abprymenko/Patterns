namespace Patterns.Contracts.BusinessObjects.Models.PVisitor
{
    #region Usings
    using Patterns.Contracts.Managers.Visitors;
    #endregion
    public interface IPayrollAccrual
    {
        double? ExecutePayrollAccrual(IPayrollVisitor visitor);
    }
}