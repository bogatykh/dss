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

using System.Collections.Generic;

namespace Dss.Enumerations
{
    /// <summary>
    /// Sub indication values
    /// 
    /// Source ETSI EN 319 102-1
    /// </summary>
    public sealed class SubIndication : UriBasedEnum
    {
        public static readonly SubIndication FORMAT_FAILURE = new SubIndication("urn:etsi:019102:subindication:FORMAT_FAILURE");

        public static readonly SubIndication HASH_FAILURE = new SubIndication("urn:etsi:019102:subindication:HASH_FAILURE");

        public static readonly SubIndication SIG_CRYPTO_FAILURE = new SubIndication("urn:etsi:019102:subindication:SIG_CRYPTO_FAILURE");

        public static readonly SubIndication REVOKED = new SubIndication("urn:etsi:019102:subindication:REVOKED");

        public static readonly SubIndication SIG_CONSTRAINTS_FAILURE = new SubIndication("urn:etsi:019102:subindication:SIG_CONSTRAINTS_FAILURE");

        public static readonly SubIndication CHAIN_CONSTRAINTS_FAILURE = new SubIndication("urn:etsi:019102:subindication:CHAIN_CONSTRAINTS_FAILURE");

        public static readonly SubIndication CERTIFICATE_CHAIN_GENERAL_FAILURE = new SubIndication("urn:etsi:019102:subindication:CERTIFICATE_CHAIN_GENERAL_FAILURE");

        public static readonly SubIndication CRYPTO_CONSTRAINTS_FAILURE = new SubIndication("urn:etsi:019102:subindication:CRYPTO_CONSTRAINTS_FAILURE");

        public static readonly SubIndication EXPIRED = new SubIndication("urn:etsi:019102:subindication:EXPIRED");

        public static readonly SubIndication NOT_YET_VALID = new SubIndication("urn:etsi:019102:subindication:NOT_YET_VALID");

        public static readonly SubIndication POLICY_PROCESSING_ERROR = new SubIndication("urn:etsi:019102:subindication:POLICY_PROCESSING_ERROR");

        public static readonly SubIndication SIGNATURE_POLICY_NOT_AVAILABLE = new SubIndication("urn:etsi:019102:subindication:SIGNATURE_POLICY_NOT_AVAILABLE");

        public static readonly SubIndication TIMESTAMP_ORDER_FAILURE = new SubIndication("urn:etsi:019102:subindication:TIMESTAMP_ORDER_FAILURE");

        public static readonly SubIndication NO_SIGNING_CERTIFICATE_FOUND = new SubIndication("urn:etsi:019102:subindication:NO_SIGNING_CERTIFICATE_FOUND");

        public static readonly SubIndication NO_CERTIFICATE_CHAIN_FOUND = new SubIndication("urn:etsi:019102:subindication:NO_CERTIFICATE_CHAIN_FOUND");

        public static readonly SubIndication REVOKED_NO_POE = new SubIndication("urn:etsi:019102:subindication:REVOKED_NO_POE");

        public static readonly SubIndication REVOKED_CA_NO_POE = new SubIndication("urn:etsi:019102:subindication:REVOKED_CA_NO_POE");

        public static readonly SubIndication OUT_OF_BOUNDS_NO_POE = new SubIndication("urn:etsi:019102:subindication:OUT_OF_BOUNDS_NO_POE");

        public static readonly SubIndication OUT_OF_BOUNDS_NOT_REVOKED = new SubIndication("urn:etsi:019102:subindication:OUT_OF_BOUNDS_NOT_REVOKED");

        public static readonly SubIndication CRYPTO_CONSTRAINTS_FAILURE_NO_POE = new SubIndication("urn:etsi:019102:subindication:CRYPTO_CONSTRAINTS_FAILURE_NO_POE");

        public static readonly SubIndication NO_POE = new SubIndication("urn:etsi:019102:subindication:NO_POE");

        public static readonly SubIndication TRY_LATER = new SubIndication("urn:etsi:019102:subindication:TRY_LATER");

        public static readonly SubIndication SIGNED_DATA_NOT_FOUND = new SubIndication("urn:etsi:019102:subindication:SIGNED_DATA_NOT_FOUND");

        private SubIndication(string uri)
        {
            Uri = uri;
        }

        public string Uri { get; }

        /// <summary>
        /// SubIndication can be null
        /// </summary>
        /// <param name="value">the string value to be converted</param>
        /// <returns>the related SubIndication</returns>
        public static SubIndication ForName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return Values[value];
            }
            return null;
        }

        private static readonly IReadOnlyDictionary<string, SubIndication> Values = new Dictionary<string, SubIndication>
        {
            { nameof(FORMAT_FAILURE), FORMAT_FAILURE },
            { nameof(HASH_FAILURE), HASH_FAILURE },
            { nameof(SIG_CRYPTO_FAILURE), SIG_CRYPTO_FAILURE },
            { nameof(REVOKED), REVOKED },
            { nameof(SIG_CONSTRAINTS_FAILURE), SIG_CONSTRAINTS_FAILURE },
            { nameof(CHAIN_CONSTRAINTS_FAILURE), CHAIN_CONSTRAINTS_FAILURE },
            { nameof(CERTIFICATE_CHAIN_GENERAL_FAILURE), CERTIFICATE_CHAIN_GENERAL_FAILURE },
            { nameof(CRYPTO_CONSTRAINTS_FAILURE), CRYPTO_CONSTRAINTS_FAILURE },
            { nameof(EXPIRED), EXPIRED },
            { nameof(NOT_YET_VALID), NOT_YET_VALID },
            { nameof(POLICY_PROCESSING_ERROR), POLICY_PROCESSING_ERROR },
            { nameof(SIGNATURE_POLICY_NOT_AVAILABLE), SIGNATURE_POLICY_NOT_AVAILABLE },
            { nameof(TIMESTAMP_ORDER_FAILURE), TIMESTAMP_ORDER_FAILURE },
            { nameof(NO_SIGNING_CERTIFICATE_FOUND), NO_SIGNING_CERTIFICATE_FOUND },
            { nameof(NO_CERTIFICATE_CHAIN_FOUND), NO_CERTIFICATE_CHAIN_FOUND },
            { nameof(REVOKED_NO_POE), REVOKED_NO_POE },
            { nameof(REVOKED_CA_NO_POE), REVOKED_CA_NO_POE },
            { nameof(OUT_OF_BOUNDS_NO_POE), OUT_OF_BOUNDS_NO_POE },
            { nameof(OUT_OF_BOUNDS_NOT_REVOKED), OUT_OF_BOUNDS_NOT_REVOKED },
            { nameof(CRYPTO_CONSTRAINTS_FAILURE_NO_POE), CRYPTO_CONSTRAINTS_FAILURE_NO_POE },
            { nameof(NO_POE), NO_POE },
            { nameof(TRY_LATER), TRY_LATER },
            { nameof(SIGNED_DATA_NOT_FOUND), SIGNED_DATA_NOT_FOUND }
        };
    }
}