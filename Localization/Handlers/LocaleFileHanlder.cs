/**
 * GUI Turbo Assembler - an essential 32-64bit localized IDE for Assembly Language with TASM, TASM32, TLINK, TLINK32, TD and TD32
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
using GUITurboAssembler.Localization.Common;
using GUITurboAssembler.Localization.Handlers.Exceptions;
using GUITurboAssembler.Localization.Models;
using GUITurboAssembler.Localization.Models.Text;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GUITurboAssembler.Localization.Handlers
{
    class LocaleFileHandler
    {
        internal Texts LoadMultilingualText(string lanaguageCode)
        {
            Texts multilingualText = new Texts();

            // loading language file only when language code is not EN
            if (!lanaguageCode.ToUpper().Equals(Constants.EnglishLocaleCode))
            {
                string languageFilePath = GetLangaugeFilePath(lanaguageCode);
                using (StreamReader streamReader = new StreamReader(languageFilePath, Encoding.UTF8))
                {
                    multilingualText = ZeroDepJson.ZeroDepJson.Deserialize<Texts>(streamReader);
                }
            }

            return multilingualText;
        }

        internal List<Locale> ScanForNewLanguages()
        {
            List<Locale> newLanguages = new List<Locale>();

            // scan for all language files which are non-default
            List<string> languagesFiles = Directory
                .GetFiles(Constants.LocaleDirectory, "*.lang", SearchOption.TopDirectoryOnly)
                .Where(file => !Constants.SupportedLocales.Contains(Path.GetFileNameWithoutExtension(file)))
                .ToList();

            foreach (string languageFile in languagesFiles)
            {
                try
                {
                    // try to load the file, if load succeeds then its valid
                    Texts languageTexts = LoadMultilingualText(Path.GetFileNameWithoutExtension(languageFile));

                    // incase of broken lang file, EN will be the langauge code
                    // so we need to skip adding that
                    if (languageTexts.Language.Code != Constants.EnglishLocaleCode)
                        newLanguages.Add(languageTexts.Language);
                }
                catch
                {
                    // incase of JSON deserialization error
                }
            }

            return newLanguages;
        }

        private string GetLangaugeFilePath(string languageCode)
        {
            string lanaguageFilePath = Path.Combine(Constants.LocaleDirectory, string.Format("{0}.lang", languageCode.ToUpper()));
            if (!File.Exists(lanaguageFilePath))
                throw new LocalizationException(string.Format("Language file {0} is missing", lanaguageFilePath));

            return lanaguageFilePath;
        }
    }
}
