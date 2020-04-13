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
    public sealed class CertificatePolicy : OidDescription
    {
        // ------------ ETSI TS 101 456

        /// <summary>
        /// A certificate policy for qualified certificates issued to the public.
        /// {itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(1456) policy-identifiers(1)
        /// qcp-public (2)}
        /// </summary>
        public static readonly CertificatePolicy QCP_PUBLIC = new CertificatePolicy("qcp-public", "0.4.0.1456.1.2");

        /// <summary>
        /// A certificate policy for qualified certificates issued to the public, requiring use of secure signature-creation
        /// devices.
        /// {itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(1456) policy-identifiers(1)
        /// qcp-public-with-sscd(1)}
        /// </summary>
        public static readonly CertificatePolicy QCP_PUBLIC_WITH_SSCD = new CertificatePolicy("qcp-public-with-sscd", "0.4.0.1456.1.1");

        // ------------ ETSI EN 319 411-1

        /// <summary>
        /// NCP: Normalized Certificate Policy
        /// itu-t(0) identified-organization(4) etsi(0) other-certificate-policies(2042) policy-identifiers(1) ncp (1)
        /// </summary>
        public static readonly CertificatePolicy NCP = new CertificatePolicy("normalized-certificate-policy", "0.4.0.2042.1.1");

        /// <summary>
        /// NCP+: Normalized Certificate Policy requiring a secure cryptographic device
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)ncpplus(2)
        /// </summary>
        public static readonly CertificatePolicy NCPP = new CertificatePolicy("normalized-certificate-policy-sscd", "0.4.0.2042.1.2");

        /// <summary>
        /// LCP: Lightweight Certificate Policy
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)lcp(3)
        /// </summary>
        public static readonly CertificatePolicy LCP = new CertificatePolicy("lightweight-certificate-policy", "0.4.0.2042.1.3");

        /// <summary>
        /// EVCP: Extended Validation Certificate Policy
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)evcp(4)
        /// </summary>
        public static readonly CertificatePolicy EVCP = new CertificatePolicy("extended-validation-certificate-policy", "0.4.0.2042.1.4");

        /// <summary>
        /// DVCP: Domain Validation Certificate Policy
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)dvcp(6)
        /// </summary>
        public static readonly CertificatePolicy DVCP = new CertificatePolicy("domain-validation-certificate-policy", "0.4.0.2042.1.6");

        /// <summary>
        /// OVCP: Organizational Validation Certificate Policy
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)ovcp(7)
        /// </summary>
        public static readonly CertificatePolicy OVCP = new CertificatePolicy("organizational-validation-certificate-policy", "0.4.0.2042.1.7");

        /// <summary>
        /// IVCP: Individual Validation Certificate Policy
        /// itu-t(0)identified-organization(4)etsi(0)other-certificate-policies(2042)policy-identifiers(1)ivcp(8)
        /// </summary>
        public static readonly CertificatePolicy IVCP = new CertificatePolicy("individual-validation-certificate-policy", "0.4.0.2042.1.8");

        // ------------ ETSI EN 319 411-2

        /// <summary>
        /// QCP-n: certificate policy for EU qualified certificates issued to natural persons;
        /// Itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(194112)
        /// policy-identifiers(1) qcp-natural (0)
        /// </summary>
        public static readonly CertificatePolicy QCP_NATURAL = new CertificatePolicy("qcp-natural", "0.4.0.194112.1.0");

        /// <summary>
        /// QCP-l: certificate policy for EU qualified certificates issued to legal persons;
        /// itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(194112)
        /// policy-identifiers(1) qcp-legal (1)
        /// </summary>
        public static readonly CertificatePolicy QCP_LEGAL = new CertificatePolicy("qcp-legal", "0.4.0.194112.1.1");

        /// <summary>
        /// QCP-n-qscd: certificate policy for EU qualified certificates issued to natural persons with private key related
        /// to the certified public key in a QSCD;
        /// Itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(194112)
        /// policy-identifiers(1) qcp-natural-qscd (2)
        /// </summary>
        public static readonly CertificatePolicy QCP_NATURAL_QSCD = new CertificatePolicy("qcp-natural-qscd", "0.4.0.194112.1.2");

        /// <summary>
        /// QCP-l-qscd: certificate policy for EU qualified certificates issued to legal persons with private key related to
        /// the certified public key in a QSCD;
        /// itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(194112)
        /// policy-identifiers(1) qcp-legal-qscd (3)
        /// </summary>
        public static readonly CertificatePolicy QCP_LEGAL_QSCD = new CertificatePolicy("qcp-legal-qscd", "0.4.0.194112.1.3");

        /// <summary>
        /// QCP-w: certificate policy for EU qualified website authentication certificates;
        /// itu-t(0) identified-organization(4) etsi(0) qualified-certificate-policies(194112)
        /// policy-identifiers(1) qcp-web (4)
        /// </summary>
        public static readonly CertificatePolicy QCP_WEB = new CertificatePolicy("qcp-web", "0.4.0.194112.1.4");

        private CertificatePolicy(string description, string oid)
        {
            Description = description;
            Oid = oid;
        }

        public string Oid { get; }

        public string Description { get; }
    }
}