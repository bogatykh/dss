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
    public sealed class CertificateQualification
    {

        /// <summary>
        /// Qualified Certificate for Electronic Signatures with private key on QSCD
        /// </summary>
        public static readonly CertificateQualification QCERT_FOR_ESIG_QSCD = new CertificateQualification("QC for eSig with QSCD",
            "Qualified Certificate for Electronic Signatures with private key on QSCD", true, true, true);

        /// <summary>
        /// Qualified Certificate for Electronic Seals with private key on QSCD
        /// </summary>
        public static readonly CertificateQualification QCERT_FOR_ESEAL_QSCD = new CertificateQualification("QC for eSeal with QSCD",
            "Qualified Certificate for Electronic Seals with private key on QSCD", true, false, true);

        // QCERT_FOR_WSA_QSCD non sense

        // --------------------------------------------------------

        /// <summary>
        /// Qualified Certificate for Electronic Signatures
        /// </summary>
        public static readonly CertificateQualification QCERT_FOR_ESIG = new CertificateQualification("QC for eSig", "Qualified Certificate for Electronic Signatures", true, true, false);

        /// <summary>
        /// Qualified Certificate for Electronic Seals
        /// </summary>
        public static readonly CertificateQualification QCERT_FOR_ESEAL = new CertificateQualification("QC for eSeal", "Qualified Certificate for Electronic Seals", true, false, false);

        /// <summary>
        /// Qualified Certificate for Web Site Authentications
        /// </summary>
        public static readonly CertificateQualification QCERT_FOR_WSA = new CertificateQualification("QC for WSA", "Qualified Certificate for Web Site Authentications", true, false, false);

        // --------------------------------------------------------

        /// <summary>
        /// Certificate for Electronic Signatures
        /// </summary>
        public static readonly CertificateQualification CERT_FOR_ESIG = new CertificateQualification("Cert for eSig", "Certificate for Electronic Signatures", false, true, false);

        /// <summary>
        /// Certificate for Electronic Seals
        /// </summary>
        public static readonly CertificateQualification CERT_FOR_ESEAL = new CertificateQualification("Cert for eSeal", "Certificate for Electronic Seals", false, false, false);

        /// <summary>
        /// Certificate for Web Site Authentications
        /// </summary>
        public static readonly CertificateQualification CERT_FOR_WSA = new CertificateQualification("Cert for WSA", "Certificate for Web Site Authentications", false, false, false);

        /// <summary>
        /// Not Applicable
        /// </summary>
        public static readonly CertificateQualification NA = new CertificateQualification("N/A", "Not applicable", false, false, false);

        private static class Registry
        {
            public readonly static Dictionary<string, CertificateQualification> QUALIFS_BY_READABLE = RegisterByReadable();

            private static Dictionary<string, CertificateQualification> RegisterByReadable()
            {
                var map = new Dictionary<string, CertificateQualification>();
                foreach (var qualification in Values.Values)
                {
                    map.Add(qualification.Readable, qualification);
                }
                return map;
            }
        }

        private CertificateQualification(string readable, string label, bool qc, bool forEsig, bool qscd)
        {
            Readable = readable;
            Label = label;
            IsQc = qc;
            IsForEsig = forEsig;
            IsQscd = qscd;
        }

        public string Readable { get; }

        public string Label { get; }

        /// <summary>
        /// CertificateQualification can be null
        /// </summary>
        /// <param name="value">the qualification name to be converted to the enum</param>
        /// <returns>the linked CertificateQualification or null</returns>
        public static CertificateQualification ForName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return Values[value];
            }
            return null;
        }

        /// <summary>
        /// CertificateQualification can be null
        /// </summary>
        /// <param name="readable">the readable description of the qualification to be converted to the enum</param>
        /// <returns>the linked CertificateQualification or null</returns>
        public static CertificateQualification FromReadable(string readable)
        {
            if (!string.IsNullOrEmpty(readable))
            {
                return Registry.QUALIFS_BY_READABLE[readable];
            }
            return null;
        }

        public bool IsQc { get; }

        public bool IsForEsig { get; }

        public bool IsQscd { get; }

        private static readonly IReadOnlyDictionary<string, CertificateQualification> Values = new Dictionary<string, CertificateQualification>
        {
            { nameof(QCERT_FOR_ESIG_QSCD), QCERT_FOR_ESIG_QSCD },
            { nameof(QCERT_FOR_ESEAL_QSCD), QCERT_FOR_ESEAL_QSCD },
            { nameof(QCERT_FOR_ESIG), QCERT_FOR_ESIG },
            { nameof(QCERT_FOR_ESEAL), QCERT_FOR_ESEAL },
            { nameof(QCERT_FOR_WSA), QCERT_FOR_WSA },
            { nameof(CERT_FOR_ESIG), CERT_FOR_ESIG },
            { nameof(CERT_FOR_ESEAL), CERT_FOR_ESEAL },
            { nameof(CERT_FOR_WSA), CERT_FOR_WSA },
            { nameof(NA), NA }
        };
    }
}