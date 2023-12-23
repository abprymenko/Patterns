namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region StopCommand
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StopCommandAsync : BaseCommandAsync, IStopCommand
    {
        #region Constructor : Public
        public StopCommandAsync(IReceiver receiver) : base(receiver) {}
        #endregion

        #region Methods : Public
        public Task Execute()
        {
            try
            {
                _receiver.StopTask();
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