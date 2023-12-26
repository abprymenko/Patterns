namespace Patterns.Services.Finances
{
    #region Usings
    using Castle.Windsor;
    using Patterns.Contracts.BusinessObjects.Models.PVisitor;
    using Patterns.Contracts.Enums;
    using Patterns.Contracts.Managers.Visitors;
    using Patterns.Contracts.Services.Finances;
    #endregion
    
    #region Financial
    internal class Financial : IFinancial
    {
        #region Private : Fields
        protected readonly IPayrollVisitor _visitor;
        protected readonly IWindsorContainer? _container;
        #endregion

        #region Public : Constructor
        public Financial(IPayrollVisitor visitor, IWindsorContainer container)
        {
            _visitor = visitor;
            _container = container;
        }
        #endregion

        #region Public : Methods
        public virtual IEnumerable<IEmployee> SetTotalSalary()
        {
            try
            {
                var employees = GetEmployees();
                foreach (var employee in employees)
                {
                    if (employee is IPayrollAccrual payrollAccrual)
                        employee.TotalSalary = payrollAccrual.ExecutePayrollAccrual(_visitor);
                }
                return employees;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Private : Methods
        /// <summary>
        /// Simulates reading data from a database.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<IEmployee> GetEmployees()
        {
            var employees = new List<IEmployee>();
            var salariedEmployee = _container?.Resolve<ISalariedEmployee>();
            if (salariedEmployee is not null)
            {
                salariedEmployee.Name = "Test1";
                salariedEmployee.SurName = "SurTest1";
                salariedEmployee.Position = "Software engineer";
                salariedEmployee.HireDate = DateTime.UtcNow.AddDays(-250);
                salariedEmployee.EmployeeType = (int)EmployeeType.MonthlySalary;
                salariedEmployee.FixedWage = 6000d;
                salariedEmployee.Deductions = 39d;
                salariedEmployee.Bonuses = 0d;
                employees.Add(salariedEmployee);
            }
            var salariedEmployee2 = _container?.Resolve<ISalariedEmployee>();
            if (salariedEmployee2 is not null)
            {
                salariedEmployee2.Name = "Test2";
                salariedEmployee2.SurName = "SurTest2";
                salariedEmployee2.Position = "Software engineer";
                salariedEmployee2.HireDate = DateTime.UtcNow.AddDays(-50);
                salariedEmployee2.EmployeeType = (int)EmployeeType.MonthlySalary;
                salariedEmployee2.FixedWage = 2500d;
                salariedEmployee2.Deductions = 39d;
                salariedEmployee2.Bonuses = 500d;
                employees.Add(salariedEmployee2);
            }
            var hourlyEmployee = _container?.Resolve<IHourlyEmployee>();
            if (hourlyEmployee is not null)
            {
                hourlyEmployee.Name = "Test3";
                hourlyEmployee.SurName = "SurTest3";
                hourlyEmployee.Position = "Software engineer";
                hourlyEmployee.HireDate = DateTime.UtcNow.AddDays(-750);
                hourlyEmployee.EmployeeType = (int)EmployeeType.HourlyRate;
                hourlyEmployee.HourlyRate = 40d;
                hourlyEmployee.HoursWorked = 70d;
                employees.Add(hourlyEmployee);
            }
            return employees;
        }
        #endregion
    }
    #endregion
}