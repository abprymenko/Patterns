namespace Patterns.Contracts.BusinessObjects.Models.PVisitor
{
    public interface ISalariedEmployee : IEmployee, IPayrollAccrual
    {
        double? FixedWage { get; set; }
        double? Deductions { get; set; }
        double? Bonuses { get; set; }
    }
}