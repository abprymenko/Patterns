namespace Command.Client
{
    #region Usings
    using Command.Client.Managers;
    using Patterns.Extensions;
    using Patterns.Contracts.Managers.Invokers;
    using Castle.Windsor;
    #endregion

    #region Program
    internal class Program
    {
        #region Private : Fields
        private static readonly IWindsorContainer? _container;
        private static readonly IInvoker? _teamLeader;
        private static readonly bool _isInterwiev;
        #endregion

        #region Constructor
        static Program()
        {
            _isInterwiev = _isInterwiev.CheckAnswer("Is it interview?[Y/N]: ");
            if (_isInterwiev)
            {
                _container = IoC.Container;
                _teamLeader = _container?.Resolve<IInvoker>();
            }
        }
        #endregion

        #region Main
        static async Task Main()
        {
            try
            {
                if (_isInterwiev)
                {
                    await Sprint();
                }
                else
                {
                    Greeting();
                }
            }
            catch (Exception ex)
            {
                await Console.Out.WriteLineAsync(ex.Message);
            }
        }
        #endregion

        #region Private : Methods
        private static async Task Sprint()
        {
            try
            {
                Console.WriteLine("The sprint has started!");
                if (_teamLeader is null)
                    throw new ArgumentNullException(nameof(_teamLeader));
                await _teamLeader.AssignmentTask();
                await _teamLeader.ApproveTask();
                Console.WriteLine("The sprint has finished!");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void Greeting()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("We can talk about dependency injection in this project directly in the interview.");
            Console.WriteLine("Please contact me if you are interested.");
            Console.WriteLine("Regards, Andrii Prymenko");
        }
        #endregion
    }
    #endregion
}