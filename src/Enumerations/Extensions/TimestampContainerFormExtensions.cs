namespace Dss.Enumerations
{
    public static class TimestampContainerFormExtensions
    {
        public static string GetReadable(this TimestampContainerForm value)
        {
            return value.ToString().Replace('_', '-');
        }
    }
}
