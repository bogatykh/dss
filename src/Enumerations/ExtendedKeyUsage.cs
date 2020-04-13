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

namespace Dss.Enumerations
{
    public sealed class ExtendedKeyUsage : OidDescription
    {
        /**
         * The KeyPurposeId object.
         * KeyPurposeId ::= OBJECT IDENTIFIER
         *
         * id-kp ::= OBJECT IDENTIFIER { iso(1) identified-organization(3)
         * dod(6) internet(1) security(5) mechanisms(5) pkix(7) 3}
         */
        public static readonly ExtendedKeyUsage SERVER_AUTH = new ExtendedKeyUsage("serverAuth", "1.3.6.1.5.5.7.3.1");

        public static readonly ExtendedKeyUsage CLIENT_AUTH = new ExtendedKeyUsage("clientAuth", "1.3.6.1.5.5.7.3.2");

        public static readonly ExtendedKeyUsage CODE_SIGNING = new ExtendedKeyUsage("codeSigning", "1.3.6.1.5.5.7.3.3");

        public static readonly ExtendedKeyUsage EMAIL_PROTECTION = new ExtendedKeyUsage("emailProtection", "1.3.6.1.5.5.7.3.4");

        // 5,6,7 deprecated by RFC4945

        public static readonly ExtendedKeyUsage TIMESTAMPING = new ExtendedKeyUsage("timeStamping", "1.3.6.1.5.5.7.3.8");

        public static readonly ExtendedKeyUsage OCSP_SIGNING = new ExtendedKeyUsage("ocspSigning", "1.3.6.1.5.5.7.3.9");

        /**
         * ETSI TS 119 612
         * -- OID for TSL signing KeyPurposeID for ExtKeyUsageSyntax
         * id-tsl OBJECT IDENTIFIER { itu-t(0) identified-organization(4)
         * etsi(0) tsl-specification (2231) }
         * id-tsl-kp OBJECT IDENTIFIER ::= { id-tsl kp(3) }
         * id-tsl-kp-tslSigning OBJECT IDENTIFIER ::= { id-tsl-kp tsl-signing(0) }
         */
        public static readonly ExtendedKeyUsage TSL_SIGNING = new ExtendedKeyUsage("tslSigning", "0.4.0.2231.3.0");

        private ExtendedKeyUsage(string description, string oid)
        {
            Description = description;
            Oid = oid;
        }

        public string Oid { get; }

        public string Description { get; }
    }
}