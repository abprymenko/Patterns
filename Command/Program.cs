namespace Command
{
    #region Usings
    using Castle.Windsor;
    using Command.Managers;
    using Contracts;
    #endregion

    #region Program class
    internal class Program
    {
        #region Private : Fields
        private static readonly IWindsorContainer? _container;
        private static readonly IInvoker? _teamLeader;
        #endregion

        #region Constructor
        static Program()
        {
            var isInterwiev = false;
            if (isInterwiev)
            {
                _container = ContainerManager.Container;
                _teamLeader = _container?.Resolve<IInvoker>();
            }
            else
            {
                Greeting();
            }
        }
        #endregion

        #region Main
        static async Task Main(string[] args)
        {
            try
            {
                await Sprint();
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
                await Console.Out.WriteLineAsync("Do anything else...");
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