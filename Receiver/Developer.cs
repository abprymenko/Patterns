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
        public void StartTask()
        {
            Console.WriteLine("The programmer has started developing the program"); ;
        }

        public void StopTask()
        {
            Console.WriteLine("The programmer has finished developing the program"); ;
        }
    }
    #endregion
}