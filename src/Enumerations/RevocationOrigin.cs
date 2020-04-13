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
    public enum RevocationOrigin
    {
        /// <summary>
        /// The revocation data was embedded in the CMS SignedData itself (used in CAdES)
        /// </summary>
        CMS_SIGNED_DATA,

        /// <summary>
        /// The revocation data was embedded in the TimeStampToken.SignedData (used in CAdES)
        /// </summary>
        TIMESTAMP_SIGNED_DATA,

        /// <summary>
        /// The revocation data was embedded in the signature 'revocation-values'
        /// attribute (used in CAdES and XAdES)
        /// </summary>
        REVOCATION_VALUES,

        /// <summary>
        /// The revocation data was embedded in the signature 'AttributeRevocationValues'
        /// attribute (used in XAdES)
        /// </summary>
        ATTRIBUTE_REVOCATION_VALUES,

        /// <summary>
        /// The revocation data was embedded in the signature 'TimeStampValidationData'
        /// attribute (used in XAdES)
        /// </summary>
        TIMESTAMP_VALIDATION_DATA,

        /// <summary>
        /// The revocation data was embedded to the contents of DSS PDF dictionary (used in PAdES)
        /// </summary>
        DSS_DICTIONARY,

        /// <summary>
        /// The revocation data was embedded to VRI dictionary (used in PAdES)
        /// </summary>
        VRI_DICTIONARY,

        /// <summary>
        /// The revocation value was embedded in the timestamp attribute (used in CAdES)
        /// </summary>
        TIMESTAMP_REVOCATION_VALUES,

        /// <summary>
        /// The revocation data was obtained from the ADBE attribute
        /// </summary>
        ADBE_REVOCATION_INFO_ARCHIVAL,

        /// <summary>
        /// The revocation data was embedded in signature or timestamp.
        /// </summary>
        INPUT_DOCUMENT,

        /// <summary>
        /// The revocation data was provided by the user or online OCSP/CRL
        /// </summary>
        EXTERNAL,

        /// <summary>
        /// The revocation data was obtained from a local DB or cache
        /// </summary>
        CACHED
    }
}