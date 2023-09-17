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
        public string DisplayLogConsole { get; set; } = "Display the log console";
        public string DisplayStandardToolbar { get; set; } = "Display the standard toolbar";
        public string DisplayStatusBar { get; set; } = "Display the status bar";
        public string Editor { get; set; } = "Editor";
        public string EditorBackgroundColor { get; set; } = "Background color for the code editor";
        public string EditorForegroundColor { get; set; } = "Foreground color for the code editor";
        public string EditorSelectedTextColor { get; set; } = "Selected text color in the code editor";
        public string EditorTextFont { get; set; } = "Text font for the code editor";
        public string EnableAutoLineIndentInEditor { get; set; } = "Enable automatic line indentation in the code editor";
        public string EnableAutomaticUpdate { get; set; } = "Enable automatic update checks on startup";
        public string EnableAutoScrollInLogConsole { get; set; } = "Enable automatic scrolling in the log console";
        public string EnableTextWrappingInEditor { get; set; } = "Enable text wrapping in the code editor";
        public string FailedUpdateCheck { get; set; } = "Update check failed";
        public string FailedUpdateCheckMsg { get; set; } = "GUI Turbo Assembler encountered an issue while attempting to check for updates. Please confirm that your system is connected to the internet and contact the developer if the problem persists.";
        public string LaunchInMaximixedMode { get; set; } = "Launch IDE in maximized mode";
        public string LineNumberBackgroundColor { get; set; } = "Background color for line numbers";
        public string LineNumberForegroundColor { get; set; } = "Foreground color for line numbers";
        public string LogConsoleBackgroundColor { get; set; } = "Background color for log console";
        public string LogConsoleForegroundColor { get; set; } = "Foreground color for log console";
        public string NewUpdateAvailableMessage { get; set; } = "There is a newer version of GUI Turbo Assembler ready for download";
        public string RestoreIdePosAndSize { get; set; } = "Restore the IDE's position and size upon startup";
        public string RestoreLastSesion { get; set; } = "Restore last session at startup";
        public string SelectIdeLanguage { get; set; } = "Select language";
        public string Title { get; set; } = "Preferences";
        public string UnsupportedFont { get; set; } = "Font not supported";
        public string UnsupportedFontMsg { get; set; } = "GUI Turbo Assembler doesn't support the chosen font";        
        public string UseCustomLauncherToRunExe { get; set; } = "Utilize custom launcher to run the assembled executable file";
        public string ViewArgs { get; set; } = "View arguments";
    }
}
