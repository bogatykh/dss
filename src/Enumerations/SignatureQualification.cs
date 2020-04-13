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
    public sealed class SignatureQualification : UriBasedEnum
    {
        /**
         * Qualified Electronic Signature
         */
        public static readonly SignatureQualification QESIG = new SignatureQualification("QESig", "Qualified Electronic Signature", "urn:cef:dss:signatureQualification:QESig");

        /**
         * Qualified Electronic Seal
         */
        public static readonly SignatureQualification QESEAL = new SignatureQualification("QESeal", "Qualified Electronic Seal", "urn:cef:dss:signatureQualification:QESeal");

        /**
         * Qualified Electronic Signature or Seal
         */
        public static readonly SignatureQualification QES = new SignatureQualification("QES?", "Qualified Electronic Signature or Seal", "urn:cef:dss:signatureQualification:QES");

        /**
         * Advanced Electronic Signature supported by a Qualified Certificate
         */
        public static readonly SignatureQualification ADESIG_QC = new SignatureQualification("AdESig-QC", "Advanced Electronic Signature supported by a Qualified Certificate", "urn:cef:dss:signatureQualification:AdESigQC");

        /**
         * Advanced Electronic Seal supported by a Qualified Certificate
         */
        public static readonly SignatureQualification ADESEAL_QC = new SignatureQualification("AdESeal-QC", "Advanced Electronic Seal supported by a Qualified Certificate", "urn:cef:dss:signatureQualification:AdESealQC");

        /**
         * Advanced Electronic Signature or Seal supported by a Qualified Certificate
         */
        public static readonly SignatureQualification ADES_QC = new SignatureQualification("AdES?-QC", "Advanced Electronic Signature or Seal supported by a Qualified Certificate", "urn:cef:dss:signatureQualification:AdESQC");

        /**
         * Advanced Electronic Signature
         */
        public static readonly SignatureQualification ADESIG = new SignatureQualification("AdESig", "Advanced Electronic Signature", "urn:cef:dss:signatureQualification:AdESig");

        /**
         * Advanced Electronic Seal
         */
        public static readonly SignatureQualification ADESEAL = new SignatureQualification("AdESeal", "Advanced Electronic Seal", "urn:cef:dss:signatureQualification:AdESeal");

        /**
         * Advanced Electronic Signature or Seal
         */
        public static readonly SignatureQualification ADES = new SignatureQualification("AdES?", "Advanced Electronic Signature or Seal", "urn:cef:dss:signatureQualification:AdES");

        /**
         * Indeterminate Qualified Electronic Signature
         */
        public static readonly SignatureQualification INDETERMINATE_QESIG = new SignatureQualification("Indeterminate QESig", "Indeterminate Qualified Electronic Signature", "urn:cef:dss:signatureQualification:indeterminateQESig");

        /**
         * Indeterminate Qualified Electronic Seal
         */
        public static readonly SignatureQualification INDETERMINATE_QESEAL = new SignatureQualification("Indeterminate QESeal", "Indeterminate Qualified Electronic Seal", "urn:cef:dss:signatureQualification:indeterminateQESeal");

        /**
         * Indeterminate Qualified Electronic Signature or Seal
         */
        public static readonly SignatureQualification INDETERMINATE_QES = new SignatureQualification("Indeterminate QES?", "Indeterminate Qualified Electronic Signature or Seal", "urn:cef:dss:signatureQualification:indeterminateQES");

        /**
         * Indeterminate Advanced Electronic Signature supported by a Qualified Certificate
         */
        public static readonly SignatureQualification INDETERMINATE_ADESIG_QC = new SignatureQualification("Indeterminate AdESig-QC", "Indeterminate Advanced Electronic Signature supported by a Qualified Certificate",
            "urn:cef:dss:signatureQualification:indeterminateAdESigQC");

        /**
         * Indeterminate Advanced Electronic Seal supported by a Qualified Certificate
         */
        public static readonly SignatureQualification INDETERMINATE_ADESEAL_QC = new SignatureQualification("Indeterminate AdESeal-QC", "Indeterminate Advanced Electronic Seal supported by a Qualified Certificate",
            "urn:cef:dss:signatureQualification:indeterminateAdESealQC");

        /**
         * Indeterminate Advanced Electronic Signature or Seal supported by a Qualified Certificate
         */
        public static readonly SignatureQualification INDETERMINATE_ADES_QC = new SignatureQualification("Indeterminate AdES?-QC", "Indeterminate Advanced Electronic Signature or Seal supported by a Qualified Certificate",
            "urn:cef:dss:signatureQualification:indeterminateAdESQC");

        /**
         * Indeterminate Advanced Electronic Signature
         */
        public static readonly SignatureQualification INDETERMINATE_ADESIG = new SignatureQualification("Indeterminate AdESig", "Indeterminate Advanced Electronic Signature",
            "urn:cef:dss:signatureQualification:indeterminateAdESig");

        /**
         * Indeterminate Advanced Electronic Seal
         */
        public static readonly SignatureQualification INDETERMINATE_ADESEAL = new SignatureQualification("Indeterminate AdESeal", "Indeterminate Advanced Electronic Seal",
            "urn:cef:dss:signatureQualification:indeterminateAdESeal");

        /**
         * Indeterminate Advanced Electronic Signature or Seal
         */
        public static readonly SignatureQualification INDETERMINATE_ADES = new SignatureQualification("Indeterminate AdES?", "Indeterminate Advanced Electronic Signature or Seal",
            "urn:cef:dss:signatureQualification:indeterminateAdES");

        /**
         * Not Advanced Electronic Signature but supported by a Qualified Certificate
         */
        public static readonly SignatureQualification NOT_ADES_QC_QSCD = new SignatureQualification("Not AdES but QC with QSCD", "Not Advanced Electronic Signature but supported by a Qualified Certificate",
            "urn:cef:dss:signatureQualification:notAdESbutQCwithQSCD");

        /**
         * Not Advanced Electronic Signature but supported by a Qualified Certificate
         */
        public static readonly SignatureQualification NOT_ADES_QC = new SignatureQualification("Not AdES but QC", "Not Advanced Electronic Signature but supported by a Qualified Certificate",
            "urn:cef:dss:signatureQualification:notAdESbutQC");

        /**
         * Not Advanced Electronic Signature
         */
        public static readonly SignatureQualification NOT_ADES = new SignatureQualification("Not AdES", "Not Advanced Electronic Signature", "urn:cef:dss:signatureQualification:notAdES");

        /**
         * Not Applicable
         */
        public static readonly SignatureQualification NA = new SignatureQualification("N/A", "Not applicable", "urn:cef:dss:signatureQualification:notApplicable");

        private static class Registry
        {
            public readonly static Dictionary<string, SignatureQualification> QUALIFS_BY_READABLE = registerByReadable();

            private static Dictionary<string, SignatureQualification> registerByReadable()
            {
                Dictionary<string, SignatureQualification> map = new Dictionary<string, SignatureQualification>();
                foreach (SignatureQualification qualification in Values.Values)
                {
                    map.Add(qualification.Readable, qualification);
                }
                return map;
            }
        }

        private SignatureQualification(string readable, string label, string uri)
        {
            Readable = readable;
            Label = label;
            Uri = uri;
        }

        public string Readable { get; }

        public string Label { get; }

        public string Uri { get; }

        /**
         * SignatureQualification can be null
         * 
         * @param value
         *            the qualification name to be converted to the enum
         * @return the linked SignatureQualification or null
         */
        public static SignatureQualification forName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                return Values[value];
            }
            return null;
        }

        /**
         * SignatureQualification can be null
         * 
         * @param readable
         *            the readable description of the qualification to be converted to the enum
         * @return the linked SignatureQualification or null
         */
        public static SignatureQualification FromReadable(string readable)
        {
            if (!string.IsNullOrEmpty(readable))
            {
                return Registry.QUALIFS_BY_READABLE[readable];
            }
            return null;
        }

        /**
         * SignatureQualification can be null
         * 
         * @param uri
         *            the uri of the linked {@link SignatureQualification}
         * @return the linked SignatureQualification or null
         */
        public static SignatureQualification ForURI(string uri)
        {
            if (!string.IsNullOrEmpty(uri))
            {
                foreach (SignatureQualification signatureQualification in Values.Values)
                {
                    if (uri.Equals(signatureQualification.Uri))
                    {
                        return signatureQualification;
                    }
                }
            }
            return null;
        }

        private static readonly IReadOnlyDictionary<string, SignatureQualification> Values = new Dictionary<string, SignatureQualification>
        {
            { nameof(QESIG), QESIG },
            { nameof(QESEAL), QESEAL },
            { nameof(QES), QES },
            { nameof(ADESIG_QC), ADESIG_QC },
            { nameof(ADESEAL_QC), ADESEAL_QC },
            { nameof(ADES_QC), ADES_QC },
            { nameof(ADESIG), ADESIG },
            { nameof(ADESEAL), ADESEAL },
            { nameof(ADES), ADES },
            { nameof(INDETERMINATE_QESIG), INDETERMINATE_QESIG },
            { nameof(INDETERMINATE_QESEAL), INDETERMINATE_QESEAL },
            { nameof(INDETERMINATE_QES), INDETERMINATE_QES },
            { nameof(INDETERMINATE_ADESIG_QC), INDETERMINATE_ADESIG_QC },
            { nameof(INDETERMINATE_ADESEAL_QC), INDETERMINATE_ADESEAL_QC },
            { nameof(INDETERMINATE_ADES_QC), INDETERMINATE_ADES_QC },
            { nameof(INDETERMINATE_ADESIG), INDETERMINATE_ADESIG },
            { nameof(INDETERMINATE_ADESEAL), INDETERMINATE_ADESEAL },
            { nameof(INDETERMINATE_ADES), INDETERMINATE_ADES },
            { nameof(NOT_ADES_QC_QSCD), NOT_ADES_QC_QSCD },
            { nameof(NOT_ADES_QC), NOT_ADES_QC },
            { nameof(NOT_ADES), NOT_ADES },
            { nameof(NA), NA }
        };
    }
}