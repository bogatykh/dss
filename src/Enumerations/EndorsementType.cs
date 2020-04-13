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
    public sealed class EndorsementType
    {
        public static readonly EndorsementType CERTIFIED = new EndorsementType("certified");

        public static readonly EndorsementType CLAIMED = new EndorsementType("claimed");

        public static readonly EndorsementType SIGNED = new EndorsementType("signed");

        private EndorsementType(string value)
        {
            Value = value;
        }

        public string Value { get; }

        public static EndorsementType FromString(string value)
        {
            foreach (var endorsement in Values)
            {
                if (endorsement.Value.Equals(value))
                {
                    return endorsement;
                }
            }
            return null;
        }

        private static readonly IEnumerable<EndorsementType> Values = new EndorsementType[]
        {
            CERTIFIED,
            CLAIMED,
            SIGNED
        };
    }
}