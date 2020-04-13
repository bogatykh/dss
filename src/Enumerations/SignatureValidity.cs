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
    public sealed class SignatureValidity
    {
        public static readonly SignatureValidity VALID = new SignatureValidity(0);
        public static readonly SignatureValidity INVALID = new SignatureValidity(1);
        public static readonly SignatureValidity NOT_EVALUATED = new SignatureValidity(2);

        private readonly int _value;

        private SignatureValidity(int value)
        {
            _value = value;
        }

        public override bool Equals(object obj)
        {
            SignatureValidity item = obj as SignatureValidity;

            if (item == null)
            {
                return false;
            }

            return item._value == _value;
        }

        public override int GetHashCode()
        {
            return _value;
        }

        public static SignatureValidity Get(bool? isValid)
        {
            if (isValid == null)
            {
                return NOT_EVALUATED;
            }
            else if (isValid.GetValueOrDefault())
            {
                return VALID;
            }
            else
            {
                return INVALID;
            }
        }

    }
}