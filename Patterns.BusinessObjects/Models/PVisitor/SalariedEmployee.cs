namespace Patterns.BusinessObjects.Models.PVisitor
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    using Patterns.Contracts.Managers.Visitors;
    #endregion

    #region SalariedEmployee
    internal class SalariedEmployee : Employee, ISalariedEmployee
    {
        #region Public : Properties
        public double? FixedWage { get; set; }
        public double? Deductions { get; set; }
        public double? Bonuses { get; set; }
        #endregion

        #region Public : Methods
        public double? ExecutePayrollAccrual(IPayrollVisitor visitor)
        {
            try
            {
                return visitor.VisitPayroll(this);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
    #endregion
}