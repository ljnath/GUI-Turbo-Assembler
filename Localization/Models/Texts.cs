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
using GUITurboAssembler.Localization.Models.Text;

namespace GUITurboAssembler.Localization.Models
{
    public class Texts
    {
        public ChangeHistory ChangeHistory { get; set; } = new ChangeHistory();
        public IDE IDE { get; set; } = new IDE();
        public Locale Language { get; set; } = new Locale();
        public Others Others { get; set; } = new Others();
        public Preference Preference { get; set; } = new Preference();
        public RecentFile RecentFile { get; set; } = new RecentFile();
        public UsageInfo UsageInfo { get; set; } = new UsageInfo();
    }
}
