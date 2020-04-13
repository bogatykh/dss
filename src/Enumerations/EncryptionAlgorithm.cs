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
    /// Supported signature encryption algorithms.
    /// </summary>
    public sealed class EncryptionAlgorithm : OidBasedEnum
    {
        public static readonly EncryptionAlgorithm RSA = new EncryptionAlgorithm("RSA", "1.2.840.113549.1.1.1", "RSA/ECB/PKCS1Padding");

        public static readonly EncryptionAlgorithm DSA = new EncryptionAlgorithm("DSA", "1.2.840.10040.4.1", "DSA");

        public static readonly EncryptionAlgorithm ECDSA = new EncryptionAlgorithm("ECDSA", "1.2.840.10045.2.1", "ECDSA");

        public static readonly EncryptionAlgorithm PLAIN_ECDSA = new EncryptionAlgorithm("PLAIN-ECDSA", "0.4.0.127.0.7.1.1.4.1", "PLAIN-ECDSA");

        public static readonly EncryptionAlgorithm HMAC = new EncryptionAlgorithm("HMAC", "", "");

        private static class Registry
        {
            public static Dictionary<string, EncryptionAlgorithm> OID_ALGORITHMS = RegisterOIDAlgorithms();

            private static Dictionary<string, EncryptionAlgorithm> RegisterOIDAlgorithms()
            {
                var map = new Dictionary<string, EncryptionAlgorithm>();
                foreach (var encryptionAlgorithm in Values.Values)
                {
                    map.Add(encryptionAlgorithm.Oid, encryptionAlgorithm);
                }
                return map;
            }
        }

        /// <summary>
        /// Returns the encryption algorithm associated to the given OID.
        /// </summary>
        /// <param name="oid">ASN1 algorithm OID</param>
        /// <returns>the linked encryption algorithm</returns>
        public static EncryptionAlgorithm ForOID(string oid)
        {
            EncryptionAlgorithm algorithm = Registry.OID_ALGORITHMS[oid];
            if (algorithm == null)
            {
                throw new ArgumentException("Unsupported algorithm: " + oid, nameof(oid));
            }
            return algorithm;
        }

        /// <summary>
        /// Returns the encryption algorithm associated to the given key.
        /// </summary>
        /// <param name="key">the key</param>
        /// <returns>the linked encryption algorithm</returns>
        public static EncryptionAlgorithm ForKey(AsymmetricAlgorithm key)
        {
            return ForName(key.SignatureAlgorithm);
        }

        /// <summary>
        /// Returns the encryption algorithm associated to the given JCE name.
        /// </summary>
        /// <param name="name">the encryption algorithm name</param>
        /// <returns>the linked encryption algorithm</returns>
        public static EncryptionAlgorithm ForName(string name)
        {
            // To be checked if ECC exists also .
            if ("EC".Equals(name) || "ECC".Equals(name))
            {
                return ECDSA;
            }

            if (nameof(PLAIN_ECDSA).Equals(name))
            {
                return PLAIN_ECDSA;
            }

            try
            {
                return Values[name];
            }
            catch (Exception)
            {
                throw new ArgumentException("Unsupported algorithm: " + name, nameof(name));
            }
        }

        /// <summary>
        /// Returns the encryption algorithm associated to the given JCE name.
        /// </summary>
        /// <param name="name">the encryption algorithm name</param>
        /// <param name="defaultValue">The default value for the <seealso cref="EncryptionAlgorithm"/></param>
        /// <returns>the corresponding <seealso cref="EncryptionAlgorithm"/> or the default value</returns>
        public static EncryptionAlgorithm ForName(string name, EncryptionAlgorithm defaultValue)
        {
            try
            {
                return ForName(name);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        private EncryptionAlgorithm(string name, string oid, string padding)
        {
            Name = name;
            Oid = oid;
            Padding = padding;
        }

        /// <summary>
        /// Algorithm name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// ASN1 algorithm OID
        /// </summary>
        public string Oid { get; }

        /// <summary>
        /// Algorithm padding
        /// </summary>
        public string Padding { get; }

        private static readonly IReadOnlyDictionary<string, EncryptionAlgorithm> Values = new Dictionary<string, EncryptionAlgorithm>
        {
            { nameof(RSA), RSA },
            { nameof(DSA), DSA },
            { nameof(ECDSA), ECDSA },
            { nameof(PLAIN_ECDSA), PLAIN_ECDSA },
            { nameof(HMAC), HMAC }
        };
    }
}