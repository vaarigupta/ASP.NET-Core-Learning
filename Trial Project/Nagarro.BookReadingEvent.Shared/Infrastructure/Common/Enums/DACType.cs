namespace Nagarro.BookReadingEvent.Shared
{
    /// <summary>
    /// Data Access Component Type
    /// </summary>
    public enum DACType
    {
        /// <summary>
        /// Undefined DAC (Default)
        /// </summary>
        Undefined = 0,
        [QualifiedTypeName("Nagarro.BookReadingEvent.Data.dll", "Nagarro.BookReadingEvent.Data.EventManagerDAC")]
        EventManagerDAC = 1,

       

    }
}
