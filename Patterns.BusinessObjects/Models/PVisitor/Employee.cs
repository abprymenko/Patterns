namespace Patterns.BusinessObjects.Models.PVisitor
{
    #region Usings
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    #endregion
    
    #region Employee
    internal abstract class Employee : IEmployee
    {
        #region Public : Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Position { get; set; }
        public DateTime HireDate { get; set; }
        public int EmployeeType { get; set; }
        public DateTime? TerminationDate { get; set; }
        public double? TotalSalary { get; set; }
        #endregion
    }
    #endregion
}