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
        public Task StartTask()
        {
            try
            {
                Console.WriteLine("The programmer has started to do task");
                Console.WriteLine("Completing the task...");
                Thread.Sleep(TimeSpan.FromMinutes(1));
                return Task.CompletedTask;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void StopTask()
        {
            Console.WriteLine("The programmer has finished to do task");
        }
    }
    #endregion
}