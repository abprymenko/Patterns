namespace Command
{
    #region Usings
    using BuisnessObjects.Enums;
    using Castle.Windsor;
    using Command.Managers;
    using Contracts;
    #endregion

    #region Program class
    internal class Program
    {
        #region Private : Fields
        private static IWindsorContainer? _container = ContainerManager.Container;
        private static IInvoker? _invoker;
        #endregion

        #region Main
        static void Main(string[] args)
        {
            _invoker = _container?.Resolve<IInvoker>();
            bool isState = false;
            ProcessState state = default;
            while (!isState)
            {
                Console.WriteLine("Enter the command\n[Stop - 0]\n[Start - 1]:");
                isState = Enum.TryParse(Console.ReadLine(), out state);
            }
            switch (state)
            {
                case ProcessState.Start:
                    _invoker?.AssignmentTask();
                    break;
                default:
                case ProcessState.Stop:
                    _invoker?.ApproveTask();
                    break;
            }
            Console.WriteLine("Hello, World!");
            Console.WriteLine("We can talk about dependency injection in this project directly in the interview.");
            Console.WriteLine("Please contact me if you are interested.");
            Console.WriteLine("Regards, Andrii Prymenko");
        }
        #endregion
    }
    #endregion
}