namespace Patterns.Contracts.BusinessObjects.Models.PVisitor
{
    public interface IEmployee
    {
        Guid Id { get; set; }
        string? Name { get; set; }
        string? SurName { get; set; }
        string? Position { get; set; }
        DateTime HireDate { get; set; }
        int EmployeeType { get; set; }
        DateTime? TerminationDate { get; set; }
        double? TotalSalary { get; set; }
    }
}