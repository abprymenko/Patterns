namespace Receivers
{
    #region Usings
    using Contracts;
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
                Console.WriteLine("Do anything else...");
                Thread.Sleep(TimeSpan.FromMinutes(1));
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
                Console.WriteLine("Do anything else...");
                Thread.Sleep(TimeSpan.FromMinutes(1));
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