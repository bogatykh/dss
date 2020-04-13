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
    /// <summary>
    /// Defined in ETSI TS 119 172-1 Annex B
    /// </summary>
    public sealed class CommitmentType : UriBasedEnum, OidDescription
    {
        /// <summary>
        /// It indicates that the signer recognizes to have created, approved and sent the signed data.
        /// </summary>
        public static readonly CommitmentType ProofOfOrigin = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfOrigin", "1.2.840.113549.1.9.16.6.1", nameof(ProofOfOrigin));

        /// <summary>
        /// It indicates that signer recognizes to have received the content of the signed data.
        /// </summary>
        public static readonly CommitmentType ProofOfReceipt = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfReceipt", "1.2.840.113549.1.9.16.6.2", nameof(ProofOfReceipt));

        /// <summary>
        /// It indicates that the TSP providing that indication has delivered a signed data in a local store accessible to
        /// the recipient of the signed data.
        /// </summary>
        public static readonly CommitmentType ProofOfDelivery = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfDelivery", "1.2.840.113549.1.9.16.6.3", nameof(ProofOfDelivery));

        /// <summary>
        /// It indicates that the entity providing that indication has sent the signed data (but not necessarily created it).
        /// </summary>
        public static readonly CommitmentType ProofOfSender = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfSender", "1.2.840.113549.1.9.16.6.4", nameof(ProofOfSender));

        /// <summary>
        /// It indicates that the signer has approved the content of the signed data.
        /// </summary>
        public static readonly CommitmentType ProofOfApproval = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfApproval", "1.2.840.113549.1.9.16.6.5", nameof(ProofOfApproval));

        /// <summary>
        /// It indicates that the signer has created the signed data (but not necessarily approved, nor sent it).
        /// </summary>
        public static readonly CommitmentType ProofOfCreation = new CommitmentType("http://uri.etsi.org/01903/v1.2.2#ProofOfCreation", "1.2.840.113549.1.9.16.6.6", nameof(ProofOfCreation));

        private CommitmentType(string uri, string oid, string name)
        {
            Uri = uri;
            Oid = oid;
            Description = name;
        }

        /// <summary>
        /// XML URI (XAdES)
        /// </summary>
        public string Uri { get; }

        /// <summary>
        /// Object Identifier (CAdES)
        /// </summary>
        public string Oid { get; }

        public string Description { get; }
    }
}