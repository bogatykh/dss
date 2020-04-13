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
using System.Security.Cryptography;

namespace Dss.Enumerations
{
    /// <summary>
    /// Supported Algorithms
    /// </summary>
    public sealed class DigestAlgorithm : UriBasedEnum, OidBasedEnum
    {

        // see DEPRECATED http://www.w3.org/TR/2012/WD-xmlsec-algorithms-20120105/
        // see http://www.w3.org/TR/2013/NOTE-xmlsec-algorithms-20130411/
        public static readonly DigestAlgorithm SHA1 = new DigestAlgorithm("SHA1", "1.3.14.3.2.26", "http://www.w3.org/2000/09/xmldsig#sha1", 20);

        public static readonly DigestAlgorithm SHA224 = new DigestAlgorithm("SHA224", "2.16.840.1.101.3.4.2.4", "http://www.w3.org/2001/04/xmldsig-more#sha224", 28);

        public static readonly DigestAlgorithm SHA256 = new DigestAlgorithm("SHA256", "2.16.840.1.101.3.4.2.1", "http://www.w3.org/2001/04/xmlenc#sha256", 32);

        public static readonly DigestAlgorithm SHA384 = new DigestAlgorithm("SHA384", "2.16.840.1.101.3.4.2.2", "http://www.w3.org/2001/04/xmldsig-more#sha384", 48);

        public static readonly DigestAlgorithm SHA512 = new DigestAlgorithm("SHA512", "2.16.840.1.101.3.4.2.3", "http://www.w3.org/2001/04/xmlenc#sha512", 64);

        // see https://tools.ietf.org/html/rfc6931
        public static readonly DigestAlgorithm SHA3_224 = new DigestAlgorithm("SHA3-224", "2.16.840.1.101.3.4.2.7", "http://www.w3.org/2007/05/xmldsig-more#sha3-224", 28);

        public static readonly DigestAlgorithm SHA3_256 = new DigestAlgorithm("SHA3-256", "2.16.840.1.101.3.4.2.8", "http://www.w3.org/2007/05/xmldsig-more#sha3-256", 32);

        public static readonly DigestAlgorithm SHA3_384 = new DigestAlgorithm("SHA3-384", "2.16.840.1.101.3.4.2.9", "http://www.w3.org/2007/05/xmldsig-more#sha3-384", 48);

        public static readonly DigestAlgorithm SHA3_512 = new DigestAlgorithm("SHA3-512", "2.16.840.1.101.3.4.2.10", "http://www.w3.org/2007/05/xmldsig-more#sha3-512", 64);

        public static readonly DigestAlgorithm RIPEMD160 = new DigestAlgorithm("RIPEMD160", "1.3.36.3.2.1", "http://www.w3.org/2001/04/xmlenc#ripemd160");

        public static readonly DigestAlgorithm MD2 = new DigestAlgorithm("MD2", "1.2.840.113549.2.2", "http://www.w3.org/2001/04/xmldsig-more#md2");

        public static readonly DigestAlgorithm MD5 = new DigestAlgorithm("MD5", "1.2.840.113549.2.5", "http://www.w3.org/2001/04/xmldsig-more#md5");

        public static readonly DigestAlgorithm WHIRLPOOL = new DigestAlgorithm("WHIRLPOOL", "1.0.10118.3.0.55", "http://www.w3.org/2007/05/xmldsig-more#whirlpool");

        /**
         * RFC 2313
         * "MD2", "1.2.840.113549.2.2"
         * "MD4", "1.2.840.113549.2.4"
         * "MD5", "1.2.840.113549.2.5"
         */

        private readonly string name;
        private readonly string oid;
        private readonly string xmlId;
        /* In case of MGF usage */
        private readonly int saltLength;

        private static class Registry
        {
            public static readonly Dictionary<string, DigestAlgorithm> OID_ALGORITHMS = registerOIDAlgorithms();
            public static readonly Dictionary<string, DigestAlgorithm> XML_ALGORITHMS = registerXMLAlgorithms();
            public static readonly Dictionary<string, DigestAlgorithm> ALGORITHMS = registerAlgorithms();

            private static Dictionary<string, DigestAlgorithm> registerOIDAlgorithms()
            {
                var map = new Dictionary<string, DigestAlgorithm>();
                foreach (var digestAlgorithm in values)
                {
                    map.Add(digestAlgorithm.oid, digestAlgorithm);
                }
                return map;
            }

            private static Dictionary<string, DigestAlgorithm> registerXMLAlgorithms()
            {
                var map = new Dictionary<string, DigestAlgorithm>();
                foreach (var digestAlgorithm in values)
                {
                    map.Add(digestAlgorithm.xmlId, digestAlgorithm);
                }
                return map;
            }

            private static Dictionary<string, DigestAlgorithm> registerAlgorithms()
            {
                var map = new Dictionary<string, DigestAlgorithm>();
                foreach (var digestAlgorithm in values)
                {
                    map.Add(digestAlgorithm.name, digestAlgorithm);
                }
                return map;
            }

            private static readonly IEnumerable<DigestAlgorithm> values = new DigestAlgorithm[]
            {
                SHA1,
                SHA224,
                SHA256,
                SHA384,
                SHA512,
                SHA3_224,
                SHA3_256,
                SHA3_384,
                SHA3_512,
                RIPEMD160,
                MD2,
                MD5,
                WHIRLPOOL
            };
        }

        /**
         * Returns the digest algorithm associated to the given name.
         *
         * @param name
         *             the algorithm name
         * @return the digest algorithm linked to the given name
         * @throws IllegalArgumentException
         *                                  if the given name doesn't match any
         *                                  algorithm
         */
        public static DigestAlgorithm ForName(string name)
        {
            DigestAlgorithm algorithm = Registry.ALGORITHMS[name];
            if (algorithm == null)
            {
                throw new ArgumentException("Unsupported algorithm: " + name, nameof(name));
            }
            return algorithm;
        }

        /**
         * Returns the digest algorithm associated to the given name.
         *
         * @param name
         *                     the algorithm name
         * @param defaultValue
         *                     The default value for the {@code DigestAlgorithm}
         * @return the corresponding {@code DigestAlgorithm} or the default value
         */
        public static DigestAlgorithm ForName(string name, DigestAlgorithm defaultValue)
        {
            DigestAlgorithm algorithm = Registry.ALGORITHMS[name];
            if (algorithm == null)
            {
                return defaultValue;
            }
            return algorithm;
        }

        /**
         * Returns indication if the algorithm with given {@code name} is supported
         * 
         * @param name
         *             {@link string} target algorithm's name
         * @return TRUE if the algorithm is supported, FALSE otherwise
         */
        public static bool IsSupportedAlgorithm(string name)
        {
            return Registry.ALGORITHMS[name] != null;
        }

        /**
         * Returns the digest algorithm associated to the given OID.
         *
         * @param oid
         *            the algorithm oid
         * @return the digest algorithm linked to the oid
         * @throws IllegalArgumentException
         *                                  if the oid doesn't match any digest
         *                                  algorithm
         */
        public static DigestAlgorithm ForOID(string oid)
        {
            DigestAlgorithm algorithm = Registry.OID_ALGORITHMS[oid];
            if (algorithm == null)
            {
                throw new ArgumentException("Unsupported algorithm: " + oid, nameof(oid));
            }
            return algorithm;
        }

        /**
         * Returns the digest algorithm associated to the given XML url.
         *
         * @param xmlName
         *                the algorithm uri
         * @return the digest algorithm linked to the given uri
         * @throws IllegalArgumentException
         *                                  if the uri doesn't match any digest
         *                                  algorithm
         */
        public static DigestAlgorithm ForXML(string xmlName)
        {
            DigestAlgorithm algorithm = Registry.XML_ALGORITHMS[xmlName];
            if (algorithm == null)
            {
                throw new ArgumentException("Unsupported algorithm: " + xmlName, nameof(xmlName));
            }
            return algorithm;
        }

        /**
         * Returns the digest algorithm associated to the given XML url or the default
         * one if the algorithm does not exist.
         *
         * @param xmlName
         *                     The XML representation of the digest algorithm
         * @param defaultValue
         *                     The default value for the {@code DigestAlgorithm}
         * @return the corresponding {@code DigestAlgorithm} or the default value
         */
        public static DigestAlgorithm ForXML(string xmlName, DigestAlgorithm defaultValue)
        {
            DigestAlgorithm algorithm = Registry.XML_ALGORITHMS[xmlName];
            if (algorithm == null)
            {
                return defaultValue;
            }
            return algorithm;
        }

        private DigestAlgorithm(string name, string oid, string xmlId)
            : this(name, oid, xmlId, 0)
        {
        }

        private DigestAlgorithm(string name, string oid, string xmlId, int saltLength)
        {
            this.name = name;
            this.oid = oid;
            this.xmlId = xmlId;
            this.saltLength = saltLength;
        }

        /// <summary>
        /// Algorithm name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// ASN1 algorithm OID
        /// </summary>
        public string Oid
        {
            get
            {
                return oid;
            }
        }

        /// <summary>
        /// Algorithm uri
        /// </summary>
        public string Uri
        {
            get
            {
                return xmlId;
            }
        }

        /// <summary>
        /// Salt length (PSS)
        /// </summary>
        public int SaltLength
        {
            get
            {
                return saltLength;
            }
        }

        /// <summary>
        /// Get a new instance of <see cref="MessageDigest"/> for the current digestAlgorithm
        /// </summary>
        /// <returns>an instance of <see cref="MessageDigest"/></returns>
        public HashAlgorithm GetMessageDigest()
        {
            return HashAlgorithm.Create(name);
        }
    }
}