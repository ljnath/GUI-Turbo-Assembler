/**
 * GUI Turbo Assembler - an essential 32-64bit localized IDE for Assembly Language with TASM, TASM32, TLINK, TLINK32, TD and TD32
 * Copyright (C) 2013-2024 Lakhya's Innovation Inc., Lakhya Jyoti Nath (ljnath)
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
    public class Preference
    {
        public string Advance { get; set; } = "Advance";
        public string AdvCurrentArgs { get; set; } = "Launcher Settings and Arguments";
        public string AdvCustomizeArgs { get; set; } = "Customize Arguments";
        public string Basic { get; set; } = "Basic";
        public string CustomizeArgsNote { get; set; } = "Please provide custom arguments for Turbo Assembler and/or Turbo Linker. You can find the available arguments for both 'Turbo Assembler' and 'Turbo Linker' in the 'View Arguments' sections. If you prefer not to modify these settings, you can leave these fields empty.";
        public string CustomizeArgsWaningMessage { get; set; } = "Assembly and linking of code may fail if invalid arguments are provided";
        public string CustomizeArgsWarningTitle { get; set; } = "Warning";
        public string CustomizeEditor { get; set; } = "Customize Editor";
        public string CustomizeIde { get; set; } = "Customize IDE";
        public string EnableAutoLineIndentInEditor { get; set; } = "Enable automatic line indentation in the code editor";
        public string EnableAutomaticUpdate { get; set; } = "Enable automatic update checks on startup";
        public string EnableAutoScrollInLogConsole { get; set; } = "Enable automatic scrolling in the ouptut window";
        public string EnableEditorDarkMode { get; set; } = "Enable dark mode in the code editor";
        public string EnableTextWrappingInEditor { get; set; } = "Enable text wrapping in the code editor";
        public string LaunchInMaximixedMode { get; set; } = "Launch IDE in maximized mode";
        public string RestoreIdePosAndSize { get; set; } = "Restore the IDE's position and size upon startup";
        public string RestoreLastSesion { get; set; } = "Restore last session at startup";
        public string SelectEditorFontSize { get; set; } = "Select editor font size";
        public string SelectEditorTheme { get; set; } = "Select editor theme";
        public string SelectIdeLanguage { get; set; } = "Select language";
        public string SelectIdeTheme { get; set; } = "Select theme";
        public string SelectTurboArchitecture { get; set; } = "Select Turbo assembler and linker mode";
        public string Title { get; set; } = "Preferences";
        public string UseCustomLauncherToRunExe { get; set; } = "Utilize custom launcher to run the assembled executable file";
        public string ViewArgs { get; set; } = "View Arguments";
    }
}
