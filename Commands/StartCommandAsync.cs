namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region StartCommand class
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StartCommandAsync : BaseCommandAsync, IStartCommand
    {
        #region Public : Constructor
        public StartCommandAsync(IReceiver receiver) : base(receiver){}
        #endregion

        #region Public : Methods
        public virtual async Task Execute()
        {
            try
            {
                await _receiver.StartTask();
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