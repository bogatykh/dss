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
    /// Signature profiles (form+level) handled by the SD-DSS framework.
    /// </summary>
    public enum SignatureLevel
    {
        XML_NOT_ETSI, XAdES_C, XAdES_X, XAdES_XL, XAdES_A, XAdES_BASELINE_LTA, XAdES_BASELINE_LT, XAdES_BASELINE_T, XAdES_BASELINE_B,

        CMS_NOT_ETSI, CAdES_BASELINE_LTA, CAdES_BASELINE_LT, CAdES_BASELINE_T, CAdES_BASELINE_B, CAdES_101733_C, CAdES_101733_X, CAdES_101733_A,

        PDF_NOT_ETSI, PAdES_BASELINE_LTA, PAdES_BASELINE_LT, PAdES_BASELINE_T, PAdES_BASELINE_B, PKCS7_B, PKCS7_T, PKCS7_LT, PKCS7_LTA,

        UNKNOWN
    }
}