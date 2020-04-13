namespace Dss.Enumerations
{
    public static class ASiCContainerTypeExtensions
    {
        public static string GetReadable(this ASiCContainerType value)
        {
            return value.ToString().Replace('_', '-');
        }
    }
}
