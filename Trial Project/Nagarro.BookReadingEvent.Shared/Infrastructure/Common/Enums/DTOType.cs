namespace Nagarro.BookReadingEvent.Shared
{
    /// <summary>
    /// Data Transfer Objects
    /// </summary>
    public enum DTOType
    {
        /// <summary>
        /// Undefined DTO (Default)
        /// </summary>
        Undefined = 0,
        [QualifiedTypeName("Nagarro.BookReadingEvent.DTOModel.dll", "Nagarro.BookReadingEvent.DTOModel.EventDTO")]
        EventDTO = 1

       
    }
}
