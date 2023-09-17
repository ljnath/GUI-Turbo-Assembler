/**
 * GUI Turbo Assembler - an essential Integrated Development Environment for Assembly language with TASM & TLINK
 * Copyright (C) 2013-2023 Lakhya's Innovation Inc., Lakhya Jyoti Nath (ljnath)
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
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 * 
 * Website: https://ljnath.com
 * Email: ljnath@ljnath.com / lakhya.sci@gmail.com
 **/
using System;
using System.Runtime.Serialization;

namespace GUITurboAssembler.Localization.Handlers.Exceptions
{
    [Serializable]
    class LocalizationException : Exception
    {

        public LocalizationException() : base() { }

        public LocalizationException(string message) : base(message) {  }

        public LocalizationException(string format, params object[] args) : base(string.Format(format, args)) { }

        public LocalizationException(string message, Exception innerException) : base(message, innerException) { }

        public LocalizationException(string format, Exception innerException, params object[] args) : base(string.Format(format, args), innerException) { }

        protected LocalizationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
