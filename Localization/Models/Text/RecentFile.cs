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
namespace GUITurboAssembler.Localization.Models.Text
{
    public class RecentFile
    {
        public string DeleteConfirmation { get; set; } = "Delete Confirmation";
        public string MissingFileMsg { get; set; } = "The following file cannot be located on the disk";
        public string RemoveMissingFileConfirmation { get; set; } = "Do you want to remove the broken link?";
        public string RemoveRecentFileListConfirmation { get; set; } = "Are you sure you want to clear the list of recent files?";
    }
}
