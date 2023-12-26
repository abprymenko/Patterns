namespace Patterns.Managers.Receivers
{
    #region Usings
    using Patterns.Contracts.Managers.Receivers;
    #endregion

    #region Developer class
    /// <summary>
    /// Command recipient. Defines the actions to be taken as a result of the request.
    /// </summary>
    internal class Developer : IReceiver
    {
        #region Public : Methods
        public virtual Task DoTask()
        {
            try
            {
                Console.WriteLine("The programmer has started to do task");
                Console.WriteLine("Completing the task...");
                Thread.Sleep(TimeSpan.FromSeconds(30));
                Console.WriteLine("The programmer has finished to do task");
                return Task.CompletedTask;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public virtual Task FixBug()
        {
            try
            {
                Console.WriteLine("The programmer has started to fix bug");
                Console.WriteLine("Fixing bug...");
                Thread.Sleep(TimeSpan.FromSeconds(30));
                Console.WriteLine("The programmer has finished to fix bug");
                return Task.CompletedTask;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
    #endregion
}