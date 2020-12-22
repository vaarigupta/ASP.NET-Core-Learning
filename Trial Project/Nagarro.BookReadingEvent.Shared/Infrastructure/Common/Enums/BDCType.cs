namespace Nagarro.BookReadingEvent.Shared
{
    /// <summary>
    /// Business Domain Component Type
    /// </summary>
    public enum BDCType
    {
        /// <summary>
        /// Undefined BDC (Default)
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Notice Manager
        /// </summary>
        [QualifiedTypeName("Nagarro.BookReadingEvent.Business.dll", "Nagarro.BookReadingEvent.Business.EventManagerBDC")]
        EventManagerBDC = 1,

       

    }
}
