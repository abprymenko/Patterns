namespace Patterns.BusinessObjects.Models.PVisitor
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    using Patterns.Contracts.Managers.Visitors;
    #endregion

    #region HourlyEmployee
    internal class HourlyEmployee : Employee, IHourlyEmployee
    {
        #region Public : Properties
        public double? HourlyRate { get; set; }
        public double? HoursWorked { get; set; }
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