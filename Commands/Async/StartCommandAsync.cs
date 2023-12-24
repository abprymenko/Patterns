namespace Commands.Async
{
    #region Usings
    using Contracts;
    using Contracts.Commands.Async;
    #endregion

    #region StartCommandAsync
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StartCommandAsync : BaseCommand, IStartCommandAsync
    {
        #region Public : Constructor
        public StartCommandAsync(IReceiver receiver) : base(receiver) { }
        #endregion

        #region Public : Methods
        public virtual async Task Execute()
        {
            try
            {
                await _receiver.DoTask();
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