namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region BaseCommand class
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