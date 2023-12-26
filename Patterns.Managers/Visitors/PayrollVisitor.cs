namespace Patterns.Managers.Visitors
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    using Patterns.Contracts.Managers.Visitors;
    #endregion

    #region PayrollVisitor
    internal class PayrollVisitor : IPayrollVisitor
    {
        #region Public : Methods
        public double? VisitPayroll(IHourlyEmployee employee)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(employee.HourlyRate, nameof(employee.HourlyRate));
                ArgumentNullException.ThrowIfNull(employee.HoursWorked, nameof(employee.HoursWorked));
                return employee.HourlyRate * employee.HoursWorked;
            }
            catch (ArgumentNullException aex)
            {
                throw new Exception($"Id:{employee.Id},\tPosition:{employee.Position}\n{employee.Name} {employee.SurName}\nError: {aex.Message}");
            }
        }
        public double? VisitPayroll(ISalariedEmployee employee)
        {
            try
            {
                ArgumentNullException.ThrowIfNull(employee.FixedWage, nameof(employee.FixedWage));
                ArgumentNullException.ThrowIfNull(employee.Deductions, nameof(employee.Deductions));
                ArgumentNullException.ThrowIfNull(employee.Bonuses, nameof(employee.Bonuses));
                return employee.FixedWage - (employee.FixedWage * (employee.Deductions / 100)) + employee.Bonuses;
            }
            catch (ArgumentNullException aex)
            {
                throw new Exception($"Id:{employee.Id},\tPosition:{employee.Position}\n{employee.Name} {employee.SurName}\nError: {aex.Message}");
            }
        }
        #endregion
    }
    #endregion
}