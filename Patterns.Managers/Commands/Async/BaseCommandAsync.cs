namespace Patterns.Managers.Commands.Async
{
    #region Usings
    using Patterns.Contracts.Managers.Receivers;
    #endregion

    #region BaseCommandAsync
    internal abstract class BaseCommandAsync
    {
        #region Private : Fields
        protected readonly IReceiver _receiver;
        #endregion

        #region Protected : Constructor
        protected BaseCommandAsync(IReceiver receiver)
        {
            _receiver = receiver;
        }
        #endregion
    }
    #endregion
}