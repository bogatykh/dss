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
    public sealed class TimestampQualification : UriBasedEnum
    {
        public static readonly TimestampQualification QTSA = new TimestampQualification("QTSA", "Qualified timestamp", "urn:cef:dss:timestampQualification:QTSA");

        public static readonly TimestampQualification TSA = new TimestampQualification("TSA", "Not qualified timestamp", "urn:cef:dss:timestampQualification:TSA");

        public static readonly TimestampQualification NA = new TimestampQualification("N/A", "Not applicable", "urn:cef:dss:timestampQualification:notApplicable");

        private TimestampQualification(string readable, string label, string uri)
        {
            Readable = readable;
            Label = label;
            Uri = uri;
        }

        public string Readable { get; }

        public string Label { get; }

        public string Uri { get; }
    }
}