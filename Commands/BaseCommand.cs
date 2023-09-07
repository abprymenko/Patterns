namespace Commands
{
    #region Usings
    using Contracts;
    #endregion

    #region BaseCommand class
    internal abstract class BaseCommand
    {
        #region Private : Fields
        protected readonly IReceiver _receiver;
        #endregion

        #region Protected : Constructor
        protected BaseCommand(IReceiver receiver)
        {
            _receiver = receiver;
        }
        #endregion
    }
    #endregion
}