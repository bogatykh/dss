namespace Dss.Enumerations
{
    public static class RevocationOriginExtensions
    {
        public static bool IsInternalOrigin(this RevocationOrigin value)
        {
            return RevocationOrigin.EXTERNAL != value && RevocationOrigin.CACHED != value;
        }
    }
}
