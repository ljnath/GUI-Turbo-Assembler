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
using System.IO;
using System.Reflection;

namespace GUITurboAssembler.Localization.Common
{
    static class Constants
    {
        internal static string[] SupportedLocales => new string[] { "EN", "FR", "RU", "HI", "ZH-HANT", "DE", "PL" };
        internal static string EnglishLocaleCode => "EN";
        internal static string EnglishLocaleName => "English";
        internal static string LocaleDirectoryName => "locales";
        internal static string LocaleDirectory => Path.Combine(AssemblyDirectory, LocaleDirectoryName);
        private static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string assemblyPath = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(assemblyPath);
            }
        }
    }

}

