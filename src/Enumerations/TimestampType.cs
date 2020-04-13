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
    /// Type of the timestamp
    /// </summary>
    public class TimestampType
    {
        // CAdES: id-aa-ets-contentTimestamp
        public static readonly TimestampType CONTENT_TIMESTAMP = new TimestampType(true, false, false, false);

        // XAdES: AllDataObjectsTimestamp
        public static readonly TimestampType ALL_DATA_OBJECTS_TIMESTAMP = new TimestampType(true, false, false, false);

        // XAdES: IndividualDataObjectsTimeStamp
        public static readonly TimestampType INDIVIDUAL_DATA_OBJECTS_TIMESTAMP = new TimestampType(true, false, false, false);

        // CAdES: id-aa-signatureTimeStampToken, XAdES: SignatureTimeStamp
        public static readonly TimestampType SIGNATURE_TIMESTAMP = new TimestampType(false, true, false, false);

        // CAdES: id-aa-ets-certCRLTimestamp, XAdES: RefsOnlyTimeStamp
        public static readonly TimestampType VALIDATION_DATA_REFSONLY_TIMESTAMP = new TimestampType(false, false, true, false);

        // CAdES: id-aa-ets-escTimeStamp, XAdES: SigAndRefsTimeStamp
        public static readonly TimestampType VALIDATION_DATA_TIMESTAMP = new TimestampType(false, true, true, false);

        // CAdES: id-aa-ets-archiveTimestamp, XAdES: ArchiveTimeStamp, PAdES-LTV, "document timestamp"
        public static readonly TimestampType ARCHIVE_TIMESTAMP = new TimestampType(false, true, true, true);

        private TimestampType(bool contentTimestamp, bool coversSignature, bool coversValidationData, bool archivalTimestamp)
        {
            IsContentTimestamp = contentTimestamp;
            CoversSignature = coversSignature;
            CoversValidationData = coversValidationData;
            IsArchivalTimestamp = archivalTimestamp;
        }

        /// <summary>
        /// TRUE if the timestamp is a Content timestamp
        /// </summary>
        public bool IsContentTimestamp { get; }

        /// <summary>
        /// TRUE if the timestamp covers a Signature
        /// </summary>
        public bool CoversSignature { get; }

        /// <summary>
        /// TRUE if the timestamp covers a ValidationData (certificates or revocation)
        /// </summary>
        public bool CoversValidationData { get; }

        /// <summary>
        /// TRUE if the timestamp is an Archival one
        /// </summary>
        public bool IsArchivalTimestamp { get; }

        /// <summary>
        /// Returns an array of all available content timestamps
        /// </summary>
        /// <returns>array of content <see cref="TimestampType"/></returns>
        public static IReadOnlyCollection<TimestampType> GetContentTimestampTypes()
        {
            List<TimestampType> contentTimestamps = new List<TimestampType>();
            foreach (var timestampType in Values)
            {
                if (timestampType.IsContentTimestamp)
                {
                    contentTimestamps.Add(timestampType);
                }
            }
            return contentTimestamps.AsReadOnly();
        }

        private static readonly IReadOnlyCollection<TimestampType> Values = new TimestampType[]
        {
            CONTENT_TIMESTAMP,
            ALL_DATA_OBJECTS_TIMESTAMP,
            INDIVIDUAL_DATA_OBJECTS_TIMESTAMP,
            SIGNATURE_TIMESTAMP,
            VALIDATION_DATA_REFSONLY_TIMESTAMP,
            VALIDATION_DATA_TIMESTAMP,
            ARCHIVE_TIMESTAMP
        };
    }
}