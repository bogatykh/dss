/**
* DSS - Digital Signature Services
* Copyright (C) 2015 European Commission, provided under the CEF programme
* 
* This file is part of the "DSS - Digital Signature Services" project.
* 
* This library is free software; you can redistribute it and/or
* modify it under the terms of the GNU Lesser General Public
* License as published by the Free Software Foundation; either
* version 2.1 of the License, or (at your option) any later version.
* 
* This library is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
* Lesser General Public License for more details.
* 
* You should have received a copy of the GNU Lesser General Public
* License along with this library; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace Dss.Enumerations
{
    /**
     * Supported signature algorithms.
     *
     */
    public sealed class SignatureAlgorithm : UriBasedEnum, OidBasedEnum
    {

        public static readonly SignatureAlgorithm RSA_RAW = new SignatureAlgorithm(EncryptionAlgorithm.RSA, null);

        public static readonly SignatureAlgorithm RSA_SHA1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA1);

        public static readonly SignatureAlgorithm RSA_SHA224 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA224);

        public static readonly SignatureAlgorithm RSA_SHA256 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA256);

        public static readonly SignatureAlgorithm RSA_SHA384 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA384);

        public static readonly SignatureAlgorithm RSA_SHA512 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA512);

        public static readonly SignatureAlgorithm RSA_SHA3_224 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_224);

        public static readonly SignatureAlgorithm RSA_SHA3_256 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_256);

        public static readonly SignatureAlgorithm RSA_SHA3_384 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_384);

        public static readonly SignatureAlgorithm RSA_SHA3_512 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_512);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_RAW_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, null, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA1_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA1, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA224_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA224, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA256_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA256, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA384_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA384, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA512_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA512, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA3_224_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_224, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA3_256_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_256, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA3_384_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_384, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_SSA_PSS_SHA3_512_MGF1 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.SHA3_512, Enumerations.MaskGenerationFunction.MGF1);

        public static readonly SignatureAlgorithm RSA_RIPEMD160 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.RIPEMD160);

        public static readonly SignatureAlgorithm RSA_MD5 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.MD5);

        public static readonly SignatureAlgorithm RSA_MD2 = new SignatureAlgorithm(EncryptionAlgorithm.RSA, DigestAlgorithm.MD2);

        public static readonly SignatureAlgorithm ECDSA_RAW = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, null);

        public static readonly SignatureAlgorithm ECDSA_SHA1 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA1);

        public static readonly SignatureAlgorithm ECDSA_SHA224 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA224);

        public static readonly SignatureAlgorithm ECDSA_SHA256 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA256);

        public static readonly SignatureAlgorithm ECDSA_SHA384 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA384);

        public static readonly SignatureAlgorithm ECDSA_SHA512 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA512);

        public static readonly SignatureAlgorithm ECDSA_SHA3_224 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA3_224);

        public static readonly SignatureAlgorithm ECDSA_SHA3_256 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA3_256);

        public static readonly SignatureAlgorithm ECDSA_SHA3_384 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA3_384);

        public static readonly SignatureAlgorithm ECDSA_SHA3_512 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.SHA3_512);

        public static readonly SignatureAlgorithm ECDSA_RIPEMD160 = new SignatureAlgorithm(EncryptionAlgorithm.ECDSA, DigestAlgorithm.RIPEMD160);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_SHA1 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.SHA1);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_SHA224 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.SHA224);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_SHA256 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.SHA256);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_SHA384 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.SHA384);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_SHA512 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.SHA512);

        public static readonly SignatureAlgorithm PLAIN_ECDSA_RIPEMD160 = new SignatureAlgorithm(EncryptionAlgorithm.PLAIN_ECDSA, DigestAlgorithm.RIPEMD160);

        public static readonly SignatureAlgorithm DSA_RAW = new SignatureAlgorithm(EncryptionAlgorithm.DSA, null);

        public static readonly SignatureAlgorithm DSA_SHA1 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA1);

        public static readonly SignatureAlgorithm DSA_SHA224 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA224);

        public static readonly SignatureAlgorithm DSA_SHA256 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA256);

        public static readonly SignatureAlgorithm DSA_SHA384 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA384);

        public static readonly SignatureAlgorithm DSA_SHA512 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA512);

        public static readonly SignatureAlgorithm DSA_SHA3_224 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA3_224);

        public static readonly SignatureAlgorithm DSA_SHA3_256 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA3_256);

        public static readonly SignatureAlgorithm DSA_SHA3_384 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA3_384);

        public static readonly SignatureAlgorithm DSA_SHA3_512 = new SignatureAlgorithm(EncryptionAlgorithm.DSA, DigestAlgorithm.SHA3_512);

        public static readonly SignatureAlgorithm HMAC_SHA1 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA1);

        public static readonly SignatureAlgorithm HMAC_SHA224 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA224);

        public static readonly SignatureAlgorithm HMAC_SHA256 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA256);

        public static readonly SignatureAlgorithm HMAC_SHA384 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA384);

        public static readonly SignatureAlgorithm HMAC_SHA512 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA512);

        public static readonly SignatureAlgorithm HMAC_SHA3_224 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA3_224);

        public static readonly SignatureAlgorithm HMAC_SHA3_256 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA3_256);

        public static readonly SignatureAlgorithm HMAC_SHA3_384 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA3_384);

        public static readonly SignatureAlgorithm HMAC_SHA3_512 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.SHA3_512);

        public static readonly SignatureAlgorithm HMAC_RIPEMD160 = new SignatureAlgorithm(EncryptionAlgorithm.HMAC, DigestAlgorithm.RIPEMD160);

        /* RFC 3061 */
        private static readonly string OID_NAMESPACE_PREFIX = "urn:oid:";

        private static readonly string UNSUPPORTED_ALGO_MSG = "Unsupported algorithm: %s";

        // http://www.w3.org/TR/2013/NOTE-xmlsec-algorithms-20130411/
        private static readonly Dictionary<string, SignatureAlgorithm> XML_ALGORITHMS = registerXmlAlgorithms();

        private static readonly Dictionary<SignatureAlgorithm, string> XML_ALGORITHMS_FOR_KEY = registerXmlAlgorithmsForKey();

        private static Dictionary<string, SignatureAlgorithm> registerXmlAlgorithms()
        {

            Dictionary<string, SignatureAlgorithm> xmlAlgorithms = new Dictionary<string, SignatureAlgorithm>();
            xmlAlgorithms.Add("http://www.w3.org/2000/09/xmldsig#rsa-sha1", RSA_SHA1);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha224", RSA_SHA224);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha256", RSA_SHA256);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha384", RSA_SHA384);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-sha512", RSA_SHA512);

            // https://tools.ietf.org/html/rfc6931#section-2.3.10
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha1-rsa-MGF1", RSA_SSA_PSS_SHA1_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha224-rsa-MGF1", RSA_SSA_PSS_SHA224_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha256-rsa-MGF1", RSA_SSA_PSS_SHA256_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha384-rsa-MGF1", RSA_SSA_PSS_SHA384_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha512-rsa-MGF1", RSA_SSA_PSS_SHA512_MGF1);

            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha3-224-rsa-MGF1", RSA_SSA_PSS_SHA3_224_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha3-256-rsa-MGF1", RSA_SSA_PSS_SHA3_256_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha3-384-rsa-MGF1", RSA_SSA_PSS_SHA3_384_MGF1);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#sha3-512-rsa-MGF1", RSA_SSA_PSS_SHA3_512_MGF1);

            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-ripemd160", RSA_RIPEMD160);
            // Support of not standard AT algorithm name
            // http://www.rfc-editor.org/rfc/rfc4051.txt --> http://www.rfc-editor.org/errata_search.php?rfc=4051
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more/rsa-ripemd160", RSA_RIPEMD160);

            // Following algorithms are not in ETSI TS 102 176-1 V2.0.0:
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-md5", RSA_MD5);
            //		xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#rsa-md2", RSA_MD2);
            // Following end.
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha1", ECDSA_SHA1);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha224", ECDSA_SHA224);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha256", ECDSA_SHA256);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha384", ECDSA_SHA384);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#ecdsa-sha512", ECDSA_SHA512);
            xmlAlgorithms.Add("http://www.w3.org/2007/05/xmldsig-more#ecdsa-ripemd160", ECDSA_RIPEMD160);

            xmlAlgorithms.Add("http://www.w3.org/2000/09/xmldsig#dsa-sha1", DSA_SHA1);
            xmlAlgorithms.Add("http://www.w3.org/2009/xmldsig11#dsa-sha256", DSA_SHA256);
            // Following algorithms are not in ETSI TS 102 176-1 V2.0.0:
            xmlAlgorithms.Add("http://www.w3.org/2000/09/xmldsig#hmac-sha1", HMAC_SHA1);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha224", HMAC_SHA224);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha256", HMAC_SHA256);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha384", HMAC_SHA384);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-sha512", HMAC_SHA512);
            xmlAlgorithms.Add("http://www.w3.org/2001/04/xmldsig-more#hmac-ripemd160", HMAC_RIPEMD160);
            // Following end.
            return xmlAlgorithms;
        }

        private static Dictionary<SignatureAlgorithm, string> registerXmlAlgorithmsForKey()
        {
            Dictionary<SignatureAlgorithm, string> xmlAlgorithms = new Dictionary<SignatureAlgorithm, string>();
            foreach (var entry in XML_ALGORITHMS)
            {
                xmlAlgorithms.Add(entry.Value, entry.Key);
            }
            return xmlAlgorithms;
        }

        private static readonly Dictionary<string, SignatureAlgorithm> OID_ALGORITHMS = registerOIDAlgorithms();

        private static readonly Dictionary<SignatureAlgorithm, string> OID_ALGORITHMS_FOR_KEY = registerOidAlgorithmsForKey();

        private static Dictionary<string, SignatureAlgorithm> registerOIDAlgorithms()
        {
            Dictionary<string, SignatureAlgorithm> oidAlgorithms = new Dictionary<string, SignatureAlgorithm>();

            oidAlgorithms.Add("1.2.840.113549.1.1.5", RSA_SHA1);
            oidAlgorithms.Add("1.3.14.3.2.29", RSA_SHA1);
            oidAlgorithms.Add("1.2.840.113549.1.1.14", RSA_SHA224);
            oidAlgorithms.Add("1.2.840.113549.1.1.11", RSA_SHA256);
            oidAlgorithms.Add("1.2.840.113549.1.1.12", RSA_SHA384);
            oidAlgorithms.Add("1.2.840.113549.1.1.13", RSA_SHA512);
            oidAlgorithms.Add("1.3.36.3.3.1.2", RSA_RIPEMD160);

            oidAlgorithms.Add("2.16.840.1.101.3.4.3.13", RSA_SHA3_224);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.14", RSA_SHA3_256);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.15", RSA_SHA3_384);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.16", RSA_SHA3_512);

            oidAlgorithms.Add("1.2.840.113549.1.1.4", RSA_MD5);
            oidAlgorithms.Add("1.2.840.113549.1.1.2", RSA_MD2);
            /**
             * RFC 2313:<br>
             * "md2WithRSAEncryption", 1.2.840.113549.1.1.2<br>
             * "md4WithRSAEncryption", 1.2.840.113549.1.1.3<br>
             * "md5WithRSAEncryption", 1.2.840.113549.1.1.4<br>
             */

            oidAlgorithms.Add("1.2.840.10045.4.1", ECDSA_SHA1);
            oidAlgorithms.Add("1.2.840.10045.4.3.1", ECDSA_SHA224);
            oidAlgorithms.Add("1.2.840.10045.4.3.2", ECDSA_SHA256);
            oidAlgorithms.Add("1.2.840.10045.4.3.3", ECDSA_SHA384);
            oidAlgorithms.Add("1.2.840.10045.4.3.4", ECDSA_SHA512);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.6", ECDSA_RIPEMD160);

            /*
             * id-ecdsa-with-sha3-256 {joint-iso-itu-t(2) country(16) us(840) organization(1) gov(101) csor(3)
             * nistAlgorithm(4) sigAlgs(3) 10}
             * NIST CSOR [18]
             * id-ecdsa-with-sha3-384 {joint-iso-itu-t(2) country(16) us(840) organization(1) gov(101) csor(3)
             * nistAlgorithm(4) sigAlgs(3) 11}
             * NIST CSOR [18]
             * id-ecdsa-with-sha3-512 {joint-iso-itu-t(2) country(16) us(840) organization(1) gov(101) csor(3)
             * nistAlgorithm(4) sigAlgs(3) 12}
             */
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.9", ECDSA_SHA3_224);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.10", ECDSA_SHA3_256);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.11", ECDSA_SHA3_384);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.12", ECDSA_SHA3_512);

            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.1", PLAIN_ECDSA_SHA1);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.2", PLAIN_ECDSA_SHA224);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.3", PLAIN_ECDSA_SHA256);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.4", PLAIN_ECDSA_SHA384);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.5", PLAIN_ECDSA_SHA512);
            oidAlgorithms.Add("0.4.0.127.0.7.1.1.4.1.6", PLAIN_ECDSA_RIPEMD160);

            oidAlgorithms.Add("1.2.840.10040.4.3", DSA_SHA1);
            oidAlgorithms.Add("1.2.14888.3.0.1", DSA_SHA1);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.1", DSA_SHA224);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.2", DSA_SHA256);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.3", DSA_SHA384);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.4", DSA_SHA512);

            oidAlgorithms.Add("2.16.840.1.101.3.4.3.5", DSA_SHA3_224);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.6", DSA_SHA3_256);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.7", DSA_SHA3_384);
            oidAlgorithms.Add("2.16.840.1.101.3.4.3.8", DSA_SHA3_512);

            oidAlgorithms.Add("1.2.840.113549.2.7", HMAC_SHA1);
            oidAlgorithms.Add("1.2.840.113549.2.8", HMAC_SHA224);
            oidAlgorithms.Add("1.2.840.113549.2.9", HMAC_SHA256);
            oidAlgorithms.Add("1.2.840.113549.2.10", HMAC_SHA384);
            oidAlgorithms.Add("1.2.840.113549.2.11", HMAC_SHA512);
            oidAlgorithms.Add("1.3.6.1.5.5.8.1.4", HMAC_RIPEMD160);

            oidAlgorithms.Add("2.16.840.1.101.3.4.2.13", HMAC_SHA3_224);
            oidAlgorithms.Add("2.16.840.1.101.3.4.2.14", HMAC_SHA3_256);
            oidAlgorithms.Add("2.16.840.1.101.3.4.2.15", HMAC_SHA3_384);
            oidAlgorithms.Add("2.16.840.1.101.3.4.2.16", HMAC_SHA3_512);

            oidAlgorithms.Add("1.2.840.113549.1.1.10", RSA_SSA_PSS_SHA1_MGF1);

            return oidAlgorithms;
        }

        private static Dictionary<SignatureAlgorithm, string> registerOidAlgorithmsForKey()
        {
            Dictionary<SignatureAlgorithm, string> oidAlgorithms = new Dictionary<SignatureAlgorithm, string>();
            foreach (var entry in OID_ALGORITHMS)
            {
                oidAlgorithms.Add(entry.Value, entry.Key);
            }
            return oidAlgorithms;
        }

        private static readonly Dictionary<string, SignatureAlgorithm> JAVA_ALGORITHMS = RegisterJavaAlgorithms();

        private static readonly Dictionary<SignatureAlgorithm, string> JAVA_ALGORITHMS_FOR_KEY = RegisterJavaAlgorithmsForKey();

        private static Dictionary<string, SignatureAlgorithm> RegisterJavaAlgorithms()
        {

            Dictionary<string, SignatureAlgorithm> javaAlgorithms = new Dictionary<string, SignatureAlgorithm>();

            javaAlgorithms.Add("NONEwithRSA", RSA_RAW);

            javaAlgorithms.Add("SHA1withRSA", RSA_SHA1);
            javaAlgorithms.Add("SHA224withRSA", RSA_SHA224);
            javaAlgorithms.Add("SHA256withRSA", RSA_SHA256);
            javaAlgorithms.Add("SHA384withRSA", RSA_SHA384);
            javaAlgorithms.Add("SHA512withRSA", RSA_SHA512);

            javaAlgorithms.Add("SHA3-224withRSA", RSA_SHA3_224);
            javaAlgorithms.Add("SHA3-256withRSA", RSA_SHA3_256);
            javaAlgorithms.Add("SHA3-384withRSA", RSA_SHA3_384);
            javaAlgorithms.Add("SHA3-512withRSA", RSA_SHA3_512);

            javaAlgorithms.Add("NONEwithRSAandMGF1", RSA_SSA_PSS_RAW_MGF1);

            javaAlgorithms.Add("SHA1withRSAandMGF1", RSA_SSA_PSS_SHA1_MGF1);
            javaAlgorithms.Add("SHA224withRSAandMGF1", RSA_SSA_PSS_SHA224_MGF1);
            javaAlgorithms.Add("SHA256withRSAandMGF1", RSA_SSA_PSS_SHA256_MGF1);
            javaAlgorithms.Add("SHA384withRSAandMGF1", RSA_SSA_PSS_SHA384_MGF1);
            javaAlgorithms.Add("SHA512withRSAandMGF1", RSA_SSA_PSS_SHA512_MGF1);

            javaAlgorithms.Add("SHA3-224withRSAandMGF1", RSA_SSA_PSS_SHA3_224_MGF1);
            javaAlgorithms.Add("SHA3-256withRSAandMGF1", RSA_SSA_PSS_SHA3_256_MGF1);
            javaAlgorithms.Add("SHA3-384withRSAandMGF1", RSA_SSA_PSS_SHA3_384_MGF1);
            javaAlgorithms.Add("SHA3-512withRSAandMGF1", RSA_SSA_PSS_SHA3_512_MGF1);

            javaAlgorithms.Add("RIPEMD160withRSA", RSA_RIPEMD160);

            javaAlgorithms.Add("MD5withRSA", RSA_MD5);
            javaAlgorithms.Add("MD2withRSA", RSA_MD2);

            javaAlgorithms.Add("NONEwithECDSA", ECDSA_RAW);

            javaAlgorithms.Add("SHA1withECDSA", ECDSA_SHA1);
            javaAlgorithms.Add("SHA224withECDSA", ECDSA_SHA224);
            javaAlgorithms.Add("SHA256withECDSA", ECDSA_SHA256);
            javaAlgorithms.Add("SHA384withECDSA", ECDSA_SHA384);
            javaAlgorithms.Add("SHA512withECDSA", ECDSA_SHA512);
            javaAlgorithms.Add("RIPEMD160withECDSA", ECDSA_RIPEMD160);

            javaAlgorithms.Add("SHA1withPLAIN-ECDSA", PLAIN_ECDSA_SHA1);
            javaAlgorithms.Add("SHA224withPLAIN-ECDSA", PLAIN_ECDSA_SHA224);
            javaAlgorithms.Add("SHA256withPLAIN-ECDSA", PLAIN_ECDSA_SHA256);
            javaAlgorithms.Add("SHA384withPLAIN-ECDSA", PLAIN_ECDSA_SHA384);
            javaAlgorithms.Add("SHA512withPLAIN-ECDSA", PLAIN_ECDSA_SHA512);
            javaAlgorithms.Add("RIPEMD160withPLAIN-ECDSA", PLAIN_ECDSA_RIPEMD160);

            javaAlgorithms.Add("SHA3-224withECDSA", ECDSA_SHA3_224);
            javaAlgorithms.Add("SHA3-256withECDSA", ECDSA_SHA3_256);
            javaAlgorithms.Add("SHA3-384withECDSA", ECDSA_SHA3_384);
            javaAlgorithms.Add("SHA3-512withECDSA", ECDSA_SHA3_512);

            javaAlgorithms.Add("NONEwithDSA", DSA_RAW);

            javaAlgorithms.Add("SHA1withDSA", DSA_SHA1);
            javaAlgorithms.Add("SHA224withDSA", DSA_SHA224);
            javaAlgorithms.Add("SHA256withDSA", DSA_SHA256);
            javaAlgorithms.Add("SHA384withDSA", DSA_SHA384);
            javaAlgorithms.Add("SHA512withDSA", DSA_SHA512);

            javaAlgorithms.Add("SHA3-224withDSA", DSA_SHA3_224);
            javaAlgorithms.Add("SHA3-256withDSA", DSA_SHA3_256);
            javaAlgorithms.Add("SHA3-384withDSA", DSA_SHA3_384);
            javaAlgorithms.Add("SHA3-512withDSA", DSA_SHA3_512);

            javaAlgorithms.Add("SHA1withHMAC", HMAC_SHA1);
            javaAlgorithms.Add("SHA224withHMAC", HMAC_SHA224);
            javaAlgorithms.Add("SHA256withHMAC", HMAC_SHA256);
            javaAlgorithms.Add("SHA384withHMAC", HMAC_SHA384);
            javaAlgorithms.Add("SHA512withHMAC", HMAC_SHA512);

            javaAlgorithms.Add("SHA3-224withHMAC", HMAC_SHA3_224);
            javaAlgorithms.Add("SHA3-256withHMAC", HMAC_SHA3_256);
            javaAlgorithms.Add("SHA3-384withHMAC", HMAC_SHA3_384);
            javaAlgorithms.Add("SHA3-512withHMAC", HMAC_SHA3_512);

            javaAlgorithms.Add("RIPEMD160withHMAC", HMAC_RIPEMD160);
            return javaAlgorithms;
        }

        private static Dictionary<SignatureAlgorithm, string> RegisterJavaAlgorithmsForKey()
        {
            Dictionary<SignatureAlgorithm, string> javaAlgorithms = new Dictionary<SignatureAlgorithm, string>();
            foreach (var entry in JAVA_ALGORITHMS)
            {
                javaAlgorithms.Add(entry.Value, entry.Key);
            }
            return javaAlgorithms;
        }

        public static SignatureAlgorithm forXML(string xmlName)
        {
            SignatureAlgorithm algorithm = XML_ALGORITHMS[xmlName];
            if (algorithm == null)
            {
                throw new ArgumentException(string.Format(UNSUPPORTED_ALGO_MSG, xmlName), nameof(xmlName));
            }
            return algorithm;
        }

        /**
         * This method return the {@code SignatureAlgorithm} or the default value if the algorithm is unknown.
         *
         * @param xmlName
         *            XML URI of the given algorithm
         * @param defaultValue
         *            the default value to be returned if not found
         * @return {@code SignatureAlgorithm} or default value
         */
        public static SignatureAlgorithm forXML(string xmlName, SignatureAlgorithm defaultValue)
        {
            SignatureAlgorithm algorithm = XML_ALGORITHMS[xmlName];
            if (algorithm == null)
            {
                return defaultValue;
            }
            return algorithm;
        }

        public static SignatureAlgorithm ForOID(string oid)
        {
            return ForOidAndParams(oid, null);
        }

        public static SignatureAlgorithm ForOidAndParams(string oid, byte[] sigAlgParams)
        {
            SignatureAlgorithm algorithm = OID_ALGORITHMS[oid];
            if (algorithm == null)
            {
                throw new ArgumentException(string.Format(UNSUPPORTED_ALGO_MSG, oid), nameof(oid));
            }

            // TODO: Implement
            //if (sigAlgParams != null && algorithm.getMaskGenerationFunction() != null)
            //{
            //    try
            //    {
            //        AlgorithmParameters algoParams = AlgorithmParameters.getInstance("PSS");
            //        algoParams.init(sigAlgParams);
            //        PSSParameterSpec pssParam = algoParams.getParameterSpec("PSSParameterSpec.class");
            //        DigestAlgorithm digestAlgorithm = DigestAlgorithm.forJavaName(pssParam.getDigestAlgorithm());
            //        algorithm = getAlgorithm(algorithm.getEncryptionAlgorithm(), digestAlgorithm, algorithm.getMaskGenerationFunction());
            //    }
            //    catch (GeneralSecurityException | IOException e) {
            //        throw new IllegalArgumentException("Unable to initialize PSS", e);
            //    }
            //}

            return algorithm;
        }

        /**
         * For given encryption algorithm and digest algorithm this function returns the signature algorithm.
         *
         * @param encryptionAlgorithm
         *            the encryption algorithm
         * @param digestAlgorithm
         *            the digest algorithm
         * @return the corresponding combination of both algorithms
         */
        public static SignatureAlgorithm GetAlgorithm(EncryptionAlgorithm encryptionAlgorithm, DigestAlgorithm digestAlgorithm)
        {
            return GetAlgorithm(encryptionAlgorithm, digestAlgorithm, null);
        }

        /**
         * For given encryption algorithm and digest algorithm this function returns the signature algorithm.
         *
         * @param encryptionAlgorithm
         *            the encryption algorithm
         * @param digestAlgorithm
         *            the digest algorithm
         * @param mgf
         *            the mask generation function
         * @return the corresponding combination of both algorithms
         */
        public static SignatureAlgorithm GetAlgorithm(EncryptionAlgorithm encryptionAlgorithm, DigestAlgorithm digestAlgorithm,
                MaskGenerationFunction? mgf)
        {

            StringBuilder sb = new StringBuilder();
            if (digestAlgorithm != null)
            {
                sb.Append(digestAlgorithm.Name);
            }
            else
            {
                sb.Append("NONE");
            }
            sb.Append("with");
            sb.Append(encryptionAlgorithm.Name);
            if (mgf != null)
            {
                sb.Append("andMGF1");
            }
            return JAVA_ALGORITHMS[sb.ToString()];
        }

        /**
         * The default constructor.
         *
         * @param encryptionAlgorithm
         *            the encryption algorithm
         * @param digestAlgorithm
         *            the digest algorithm
         */
        private SignatureAlgorithm(EncryptionAlgorithm encryptionAlgorithm, DigestAlgorithm digestAlgorithm)
        {
            this.EncryptionAlgorithm = encryptionAlgorithm;
            this.DigestAlgorithm = digestAlgorithm;
            this.MaskGenerationFunction = null;
        }

        /**
         * The default constructor.
         *
         * @param encryptionAlgorithm
         *            the encryption algorithm
         * @param digestAlgorithm
         *            the digest algorithm
         * @param mgf
         *            the mask generation function
         */
        SignatureAlgorithm(EncryptionAlgorithm encryptionAlgorithm, DigestAlgorithm digestAlgorithm,
                MaskGenerationFunction maskGenerationFunction)
        {
            this.EncryptionAlgorithm = encryptionAlgorithm;
            this.DigestAlgorithm = digestAlgorithm;
            this.MaskGenerationFunction = maskGenerationFunction;
        }

        /**
         * This method returns the encryption algorithm.
         *
         * @return the encryption algorithm
         */
        public EncryptionAlgorithm EncryptionAlgorithm { get; }

        /**
         * This method returns the digest algorithm.
         *
         * @return the digest algorithm
         */
        public DigestAlgorithm DigestAlgorithm { get; }

        /**
         * This method returns the mask generation function.
         *
         * @return the mask generation function
         */
        public MaskGenerationFunction? MaskGenerationFunction { get; }

        /**
         * Returns the XML ID of the signature algorithm.
         *
         * @return the XML URI for the current signature algorithm.
         */
        public string Uri
        {
            get
            {
                return XML_ALGORITHMS_FOR_KEY[this];
            }
        }

        /**
         * Returns the OID of the signature algorithm.
         *
         * @return the OID for the current signature algorithm.
         */
        public string Oid
        {
            get
            {
                return OID_ALGORITHMS_FOR_KEY[this];
            }
        }

        /**
         * Returns the URI of the signature algorithm generated from its OID:
         * 
         * Ex.: OID = 1.2.4.5.6.8 becomes URI = urn:oid:1.2.4.5.6.8
         * 
         * Note: see RFC 3061 "A URN Namespace of Object Identifiers"
         *
         * @return URI based on the algorithm's OID
         */
        public string URIBasedOnOID
        {
            get
            {
                return OID_NAMESPACE_PREFIX + Oid;
            }
        }

        /// <summary>
        /// Algorithm identifier corresponding to JAVA JCE class names.
        /// </summary>
        public string JCEId
        {
            get
            {
                return JAVA_ALGORITHMS_FOR_KEY[this];
            }
        }
    }
}