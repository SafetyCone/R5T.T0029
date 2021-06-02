using System;

using R5T.T0028;


namespace R5T.T0029
{
    public class CommandBuilder : StringBuilder, ICommandBuilder
    {
        #region Static

        public static new CommandBuilder New()
        {
            return new CommandBuilder();
        }

        #endregion
    }
}
