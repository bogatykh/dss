namespace Dss.Enumerations
{
    public static class SignatureLevelExtensions
    {
        public static string GetReadable(this SignatureLevel value)
        {
            return value.ToString().Replace('_', '-');
        }

        /// <returns>the <see cref="SignatureForm"/> depending on the <see cref="SignatureLevel"/></returns>
        public static SignatureForm? GetSignatureForm(this SignatureLevel value)
        {
            switch (value)
            {
                case SignatureLevel.XML_NOT_ETSI:
                case SignatureLevel.XAdES_C:
                case SignatureLevel.XAdES_X:
                case SignatureLevel.XAdES_XL:
                case SignatureLevel.XAdES_A:
                case SignatureLevel.XAdES_BASELINE_LTA:
                case SignatureLevel.XAdES_BASELINE_LT:
                case SignatureLevel.XAdES_BASELINE_T:
                case SignatureLevel.XAdES_BASELINE_B:
                    return SignatureForm.XAdES;
                case SignatureLevel.CMS_NOT_ETSI:
                case SignatureLevel.CAdES_BASELINE_LTA:
                case SignatureLevel.CAdES_BASELINE_LT:
                case SignatureLevel.CAdES_BASELINE_T:
                case SignatureLevel.CAdES_BASELINE_B:
                case SignatureLevel.CAdES_101733_A:
                case SignatureLevel.CAdES_101733_C:
                case SignatureLevel.CAdES_101733_X:
                    return SignatureForm.CAdES;
                case SignatureLevel.PDF_NOT_ETSI:
                case SignatureLevel.PAdES_BASELINE_B:
                case SignatureLevel.PAdES_BASELINE_T:
                case SignatureLevel.PAdES_BASELINE_LT:
                case SignatureLevel.PAdES_BASELINE_LTA:
                    return SignatureForm.PAdES;
                case SignatureLevel.PKCS7_B:
                case SignatureLevel.PKCS7_T:
                case SignatureLevel.PKCS7_LT:
                case SignatureLevel.PKCS7_LTA:
                    return SignatureForm.PKCS7;
                default:
                    return null;
            }
        }
    }
}
