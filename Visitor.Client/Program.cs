namespace Visitor.Client
{
    #region Usings
    using Visitor.Client.Managers;
    using Patterns.Contracts.Services.Finances;
    using Patterns.Contracts.Enums;
    using Castle.Windsor;
    #endregion

    #region Program
    internal class Program
    {
        #region Private : Fields
        private static readonly IFinancial? _financial;
        private static readonly IWindsorContainer? _container;
        #endregion

        #region Public : Constructor
        static Program()
        {
            _container = IoC.Container;
            _financial = _container?.Resolve<IFinancial>();
        }
        #endregion

        #region Main : entry point
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("We can talk about dependency injection in this project directly in the interview.");
            Console.WriteLine("Please contact me if you are interested.");
            Console.WriteLine("Regards, Andrii Prymenko");
            try
            {
                if (_financial is null)
                    throw new ArgumentNullException(nameof(_financial));
                var employees = _financial.SetTotalSalary();
                Console.WriteLine("Id\t\t\t\t\tFull name\t\tPosition\t\tSalary(euro/month)\tHire Date\tType");
                foreach (var employee in employees)
                {
                    var hireDate = employee.HireDate.ToString("dd/MM/yyyy");
                    Console.WriteLine($"{employee.Id}\t{employee.Name} {employee.SurName}\t\t{employee.Position}\t{employee.TotalSalary}\t\t\t" +
                        $"{hireDate}\t{(EmployeeType)employee.EmployeeType}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
    #endregion
}
