﻿﻿/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System.Text;

namespace D3TypeDescriptor
{
    class DT_FIXEDARRAY : BasicTypeDescriptor
    {
        public override void GenerateField(StringBuilder b, int pad, FieldDescriptor f)
        {
            f.SubType.GenerateFixedArrayField(b, pad, f);
        }

        public override void GenerateEncodeBitBuffer(StringBuilder b, int pad, FieldDescriptor f, string bitBufferName)
        {
            f.SubType.GenerateFixedArrayEncodeBitBuffer(b, pad, f, bitBufferName);
        }

        public override void GenerateParseBitBuffer(StringBuilder b, int pad, FieldDescriptor f, string bitBufferName)
        {
            f.SubType.GenerateFixedArrayParseBitBuffer(b, pad, f, bitBufferName);
        }
    }
}
