namespace Patterns.Managers.Commands.Async
{
    #region Usings
    using Patterns.Contracts.Managers.Commands.Async;
    using Patterns.Contracts.Managers.Receivers;
    #endregion

    #region StartCommandAsync
    /// <summary>
    /// Concrete implementation of the command, implements the Execute() method.
    /// </summary>
    internal class StartCommandAsync : BaseCommandAsync, IStartCommandAsync
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