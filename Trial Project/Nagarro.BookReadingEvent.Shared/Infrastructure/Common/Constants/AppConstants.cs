using Microsoft.Extensions.Configuration;
using Nagarro.BookReadingEvent.Shared.Infrastructure.Common.Utilities;

namespace Nagarro.BookReadingEvent.Shared
{
    public static class AppConstants
    {
       
        public struct ConfigurationKeys
        {
            #region "Properties"
            /// <summary>
            /// Constant representing the assemblies' output bin folder name.
            /// </summary>
            public static readonly string OutputBinFolderName = ConfigUtility.AppSetting("OutputBinFolderName");

          //  public static object ConfigurationManager { get; private set; }

            #endregion
        }

        
    }
}
