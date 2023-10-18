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
    public class ChangeHistory
    {
        private static string[] change100Texts = new string[]
        {
            "Version 1.0 | Built on : 09th March 2013, 16:39:20 Hrs.",
            "First release",
            "Added a basic editor with features to open and save files",
            "Added support to store setting and user preferences locally",
            "Added log console feature to read program output",
            "Added 'GTASM_Launcher' to handle execution of final program output",
            "Restricts user from opening and saving filename with length more then 8 characters",
            "Restricts user from opening and saving filename whose filename contains 'space'"
        };

        private static string[] change110Texts = new string[] {
            "Version 1.1 | Built on : 23rd March 2013 , 12:45:28 Hrs.",
            "Added support for entering custom arguments  for assembler and linker",
            "Added option to wrap text in the code-editor",
            "Added option to display statistics",
            "Added support to view all available arguments in Turbo assembler and linker",
            "Changed button text in 'about' form",
            "Added support for context menu in code-editor",
            "Fixed status display issue",
            "Added status display for opening and saving file as well",
            "Added auto-scrolling feature for the console output",
            "Added option to toggle auto-scrolling feature",
            "Changed program's title",
            "Added redo feature",
            "Added notification for UN-saved file"
        };

        private static string[] change120Texts = new string[]
        {
            "Version 1.2 | Built on : 23rd March 2013 , 13:52:42 Hrs.",
            "Prevented user from compiling, linking, running executables with an un-saved file",
            "Added support to view change logs"
        };

        private static string[] change130Texts = new string[]
        {
            "Version 1.3 | Built on : 25th March 2013 , 11:10:17 Hrs.",
            "Spell-checked",
            "Redesigned 'View change log' form",
            "Redesigned the main window",
            "Added capability to resize the editor and console",
            "Added option to show/hide console",
            "Minor modification in 'About' form",
            "Optimised and improved 'Assembly Launcher' to version 1.1",
            "Fixed random creation of settings file in Windows XP",
            "Replaced settings.xml with config.xml",
            "Added capability to change and save font details",
            "Code optimised"
        };

        private static string[] change200Texts = new string[]
        {
            "Version 2.0 | Built on : 06th September 2013, 20:41:38 Hrs.",
            "Fixed form display bug",
            "Fixed multiple 'save dialog' display bug",
            "Fixed bug related to unsaved notification at first launch",
            "Fixed system critical bug related to setting file storage",
            "Fixed many line number related bugs",
            "Redesigned editor with improved feature",
            "Redesigned the line number display system",
            "Changed file IO encoding to ASCII",
            "Changed default font for code as well as line number",
            "Changed text of Option\\Show console",
            "Changed text of Option\\Pause console after execution",
            "Added option to change the case of codes",
            "Added find feature",
            "Added find and replace feature",
            "Added product, company and developer homepage under help",
            "Added Drag and Drop feature for files only",
            "Added manual and auto indentation on written code",
            "Added support to display complete line of code, when line number is clicked",
            "Added support to display total lines and character count",
            "Added support to print and print preview file",
            "Added Preference dialog box to replace options displayed under Options",
            "Added feature to customise editor's various color scheme",
            "Added Syntax Highlighting feature",
            "Added code folding feature",
            "Added Recent File feature",
            "Improved internal coding",
            "Added feature to view file properties",
            "Added 'Open With' GUI Turbo Assembler feature",
            "Added file association feature, now user can directly double-click on an asm file to open it in GUI Turbo Assembler",
            "Added menubar for one-touch access and better UI",
            "Added feature to download the latest version available",
            "Added help support"
        };

        private static string[] change210Texts = new string[]
        {
            "Version 2.1 | Built on : 10th October 2013, 04:42:37 Hrs.",
            "Fixed buggy message displaying at compilation, build and run time",
            "Fixed bug message and labels.",
            "Fixed bug encountered  while trying to launch a missing executable",
            "Fixed bug encountered  while trying to launch application after last closing it in minimized  state",
            "Fixed installation issue in x64 system",
            "Changed About dialog and text",
            "Changed icons of various button, also added icons under menubar items, and under various context menu",
            "Changed Preference dialog layout. Integrated the working of 'View Argument' and 'Set Argument' dialog into it. Also integrated the 'Font' setting under edit menu to the preference dialog",
            "Changed buttons name of various message box",
            "Changed default color of line number to grey and added support to change the background color of the line-number",
            "Changed file type icon",
            "Changed help file",
            "Changed default font of editor",
            "Changed to be more user interactive",
            "Added feature to move 'Line of Code' up and down",
            "Added feature to comment a selected line",
            "Added menu buttons to comment/un-comment code(s) and for moving code(s) up or down",
            "Added tabbed browsing of assembly files, with all necessary tab functions.",
            "Added 'Save As' button in the standard toolbar.",
            "Added one-touch button to show/hide log console in the standard toolbar",
            "Added context menu for tabs for easy access to necessary features.",
            "Added feature to 'Open folder, where active code resides'",
            "Added feature to list all open tabs, and to access those with a single click",
            "Added zooming feature, accessible with with menu buttons or shortcuts",
            "Added End User License Agreement, which has to be read and agreed at first application launch",
            "Modified program behavior  to allow only single running instance",
            "Reduced installation file size",
            "Changed algorithms and coding for better performance",
            "Upgraded 'Print' & 'Print Preview' functionality"
        };

        private static string[] change220Texts = new string[]
        {
            "Version 2.2 | Built on : 31st January 2014, 20:38:44 Hrs.",
            "Fixed bug related to EULA bypass as in previous version.",
            "Changed shortcut for new tab.", "Modularised application using Dynamic Data Library.",
            "Added OS Detection feature to warn 64-bit users about incompatibility of Turbo Assembler and Linker beforehand.",
            "Added support of making donations.",
            "Added tool-tip feature, displayed when cursor is moved over a tab.",
            "Disabled word wrap by default.",
            "Disabled log console by default."
        };

        private static string[] change230Texts = new string[]
        {
            "Version 2.3 | Built on : 02nd July 2014, 21:46:29 Hrs.",
            "Removed company homepage link.",
            "Edited developer homepage link."
        };

        private static string[] change300Texts = new string[]
        {
            "Version 3.0 | Built on : 14th March 2015, 18:20:55 Hrs.",
            "Added full support for 64-bit machine; comes with 64-bit binaries.",
            "Added 64-bit support for Borland Turbo Assembler and Turbo Linker using DOSBox.",
            "Added multilingual feature.",
            "Added new language French",
            "Added new language Russian.",
            "Added new language Chinese Traditional.",
            "Added new language Hindi.",
            "Added feature to check for update at startup.",
            "Added feature to save session, and automatically restore it at startup",
            "Replaced internal IO file format from XML (config.xml) to DAT (config.dat).",
            "Fixed mistyped texts.",
            "Improved internal codes for maximum efficiency.",
            "Fixed EULA bugs.",
            "Restricts user from using 32-bit binaries in 64-bit environment.",
            "Fixed bugs and issues."
        };

        private static string[] change301Texts = new string[]
        {
            "Version 3.0.1 | Built on : 11th May 2016, 01:30:45 Hrs.",
            "Added support to handle ASM file with macro in 64-bit version"
        };

        private static string[] change400Texts = new string[]
        {
            "Version 4.0 | Built on : 18th September 2023, 00:04:02 Hrs.",
            "Added localized text support for German and Polish.",
            "Added support for restoring any broken settings with a single click.",
            "Added support to run custom assemble and build commands for advance user",
            "Added the option to Open containing folder for saved source files under the File menu.",
            "Enhanced localization support by reading locale files from disk instead of hard-coded values, enabling users to utilize custom localized texts and contribute to public releases.",
            "Enhanced filename validation during file operations in accordance with Turbo Assembler and Linker specifications.",
            "Enhanced the assembly and build process in 64-bit systems to operate in the source directory instead of copying to the installation directory.",
            "Enhanced the Preferences menu by consolidating all editor settings into one location, with updated texts and ordering of user controls.",
            "Fixed tooltip display in tab titles.",
            "Fixed EULA.",
            "Implemented integrity checks for all non-system executable files invoked by GUI Turbo Assembler to bolster software security.",
            "Implemented user experience improvements throughout the application.",
            "Improved logging in both the console and status bar.",
            "Improved session handling to restore previously opened source files, even if they have been deleted.",
            "Included default debug arguments for Turbo Assembler.",
            "Included example assembly programs for reference.",
            "Included the ability to copy-paste default arguments from Preferences.",
            "Increased the maximum supported count of recent files from 10 to 20.",
            "Integrated both 32-bit and 64-bit functionality into a single 32-bit binary, eliminating the need for a separate 64-bit binary.",
            "Integrated with Gatekeeper for application update notification",
            "Introduced localization support in the IDE's GoTo dialog.",
            "Introduced on-demand license checks under the Help menu.",
            "Introduced support for silent assembly and code building, eliminating console pop-up screens.",
            "Provided support for cancelling tasks via the Message dialog.",
            "Resolved assembly and build failures in 64-bit environments caused by locked files.",
            "Restructured the Options menu items, placing them under the Tools menu.",
            "Revamped tab design with new color schemes for active and inactive tabs.",
            "Revised menu and prompt texts to improve grammatical correctness.",
            "Transitioned the persistence layer from the Windows Registry to a configuration file in the user's application directory.",
            "Transitioned to the new and improved Assembly Launcher 2.0.",
            "Upgraded the previously used version of FastColoredTextBox to the latest forked version for enhanced performance.",
            "Upgraded to the new and improved guiTasmX64 based on DOSBox 0.74-3, featuring silent execution capabilities."
        };

        private static string[] change500Texts = new string[]
        {
            "Version 5.0 | Built on : 19th October 2023, 02:27:15 Hrs.",
            "Added support for docking code editors and other tabs for maximum developer efficiency",
            "Added Terminal to allow users to directly type and run commands in the IDE",
            "Added support for debugging code using Turbo Debugger",
            "Added support to customize the Visual Studio 2015-based theme in the IDE. Supported themes include Blue, Dark, and Light",
            "Added support for macros",
            "Added support to open and edit .INC file",
            "Added support to customize the code editor mode for Dark and Light.",
            "Added support to preserve the docked layout",
            "Enhanced the update notification to prompt the user before navigating to the download page",
            "Removed support for Font Family and editor color customization",
            "Removed the 'View Usage Info' functionality",
            "Removed Custom Assemble and Custom Build feature",
            "Revamped the About section",
            "Updated icons and fonts"
        };

        public string Title { get; set; } = "Change History";
        public string Version { get; set; } = "Version";
        public string[] Change100 { get; set; } = change100Texts;
        public string[] Change110 { get; set; } = change110Texts;
        public string[] Change120 { get; set; } = change120Texts;
        public string[] Change130 { get; set; } = change130Texts;
        public string[] Change200 { get; set; } = change200Texts;
        public string[] Change210 { get; set; } = change210Texts;
        public string[] Change220 { get; set; } = change220Texts;
        public string[] Change230 { get; set; } = change230Texts;
        public string[] Change300 { get; set; } = change300Texts;
        public string[] Change301 { get; set; } = change301Texts;
        public string[] Change400 { get; set; } = change400Texts;
        public string[] Change500 { get; set; } = change500Texts;
    }
}
