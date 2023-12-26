namespace Patterns.Contracts.BusinessObjects.Models.PVisitor
{
    public interface IHourlyEmployee : IEmployee, IPayrollAccrual
    {
        double? HourlyRate { get; set; }
        double? HoursWorked { get; set; }
    }
}