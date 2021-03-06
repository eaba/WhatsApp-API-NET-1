﻿/**
 * Copyright (C) 2015 smndtrl
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Tr.Com.Eimza.LibAxolotl.Util;

namespace Tr.Com.Eimza.LibAxolotl.Kdf
{
    public class DerivedRootSecrets
    {
        public static readonly int SIZE = 64;

        private readonly byte[] rootKey;
        private readonly byte[] chainKey;

        public DerivedRootSecrets(byte[] okm)
        {
            byte[][] keys = ByteUtil.Split(okm, 32, 32);
            this.rootKey = keys[0];
            this.chainKey = keys[1];
        }

        public byte[] GetRootKey()
        {
            return rootKey;
        }

        public byte[] GetChainKey()
        {
            return chainKey;
        }
    }
}