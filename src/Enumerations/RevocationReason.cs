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
    /**
     * This enum is used to get string value of CRLReason
     * 
     * The CRLReason enumeration.
     * 
     * <pre>
     * CRLReason ::= ENUMERATED {
     *  unspecified             (0),
     *  keyCompromise           (1),
     *  cACompromise            (2),
     *  affiliationChanged      (3),
     *  superseded              (4),
     *  cessationOfOperation    (5),
     *  certificateHold         (6),
     *  removeFromCRL           (8),
     *  privilegeWithdrawn      (9),
     *  aACompromise           (10)
     * }
     * </pre>
     */
    public sealed class RevocationReason : UriBasedEnum
    {
        public static readonly RevocationReason UNSPECIFIED = new RevocationReason("unspecified", "urn:etsi:019102:revocationReason:unspecified", 0);

        public static readonly RevocationReason KEY_COMPROMISE = new RevocationReason("keyCompromise", "urn:etsi:019102:revocationReason:keyCompromise", 1);

        public static readonly RevocationReason CA_COMPROMISE = new RevocationReason("cACompromise", "urn:etsi:019102:revocationReason:cACompromise", 2);

        public static readonly RevocationReason AFFILIATION_CHANGED = new RevocationReason("affiliationChanged", "urn:etsi:019102:revocationReason:affiliationChanged", 3);

        public static readonly RevocationReason SUPERSEDED = new RevocationReason("superseded", "urn:etsi:019102:revocationReason:superseded", 4);

        public static readonly RevocationReason CESSATION_OF_OPERATION = new RevocationReason("cessationOfOperation", "urn:etsi:019102:revocationReason:cessationOfOperation", 5);

        public static readonly RevocationReason CERTIFICATE_HOLD = new RevocationReason("certificateHold", "urn:etsi:019102:revocationReason:certificateHold", 6);

        // Missing in ETSI VR standard
        public static readonly RevocationReason REMOVE_FROM_CRL = new RevocationReason("removeFromCRL", "urn:etsi:019102:revocationReason:removeFromCRL", 8);

        public static readonly RevocationReason PRIVILEGE_WITHDRAWN = new RevocationReason("privilegeWithdrawn", "urn:etsi:019102:revocationReason:privilegeWithdrawn", 9);

        // Missing in ETSI VI standard
        public static readonly RevocationReason AA_COMPROMISE = new RevocationReason("aACompromise", "urn:etsi:019102:revocationReason:aACompromise", 10);

        private RevocationReason(string shortName, string uri, int value)
        {
            ShortName = shortName;
            Uri = uri;
            Value = value;
        }

        public string ShortName { get; }

        public string Uri { get; }

        public int Value { get; }

        public static RevocationReason fromInt(int value)
        {
            foreach (RevocationReason reason in Values)
            {
                if (reason.Value == value)
                {
                    return reason;
                }
            }
            return null;
        }

        private static readonly IReadOnlyCollection<RevocationReason> Values = new RevocationReason[]
        {
            UNSPECIFIED,
            KEY_COMPROMISE,
            CA_COMPROMISE,
            AFFILIATION_CHANGED,
            SUPERSEDED,
            CESSATION_OF_OPERATION,
            CERTIFICATE_HOLD,
            REMOVE_FROM_CRL,
            PRIVILEGE_WITHDRAWN,
            AA_COMPROMISE
        };
    }
}