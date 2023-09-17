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
    public class IDE
    {
        public string AssembleAbortByUser { get; set; } = "The code assemble process has been aborted by the user.";
        public string AssembleCompleteWithWarning { get; set; } = "The code assemble process completed with warnings.";
        public string AssembleFailedDueToIntegrity { get; set; } = "The code assemble process is aborted due to failed integrity test.";
        public string AssembleFailedDueToSubProcess { get; set; } = "The code assemble process failed due to a sub-process failure.";
        public string AssembleFailedWithError { get; set; } = "The code assemble process failed with errors.";
        public string AssembleFileAndProceedPromptMsg { get; set; } = "The current code has not been assembled. Would you like to assemble and proceed?";
        public string AssembleSkipped { get; set; } = "The code assemble process has been skipped.";
        public string AssembleSucessful { get; set; } = "The code assemble process completed successfully.";
        public string AssembleToObjectFile { get; set; } = "Assembling source code to object file using arguments";
        public string AssembleToObjectFileCustomCmd { get; set; } = "Assembling source code with custom command";
        public string BuildAbortByUser { get; set; } = "The code build process has been aborted by the user.";
        public string BuildFailedDueToIntegrity { get; set; } = "The code build process is aborted due to failed integrity test.";
        public string BuildFailedDueToSubProcess { get; set; } = "The code build process failed due to a sub-process failure.";
        public string BuildFailedWithError { get; set; } = "The code build process failed with errors.";
        public string BuildFileAndProceedPromptMsg { get; set; } = "The current code has not been built. Would you like to build and proceed?";
        public string BuildObjectFileToExe { get; set; } = "Building object file to executable file using arguments";
        public string BuildObjectFileCustomCmd { get; set; } = "Building object file with custom command";
        public string BuildSkipped { get; set; } = "The code build process has been skipped.";
        public string BuildSucessful { get; set; } = "The code build process completed successfully.";
        public string Character { get; set; } = "Character";
        public string Close { get; set; } = "Close";
        public string Custom { get; set; } = "Custom";
        public string CustomCommandText { get; set; } = "Enter complete command including filename (check guide for help)";
        public string CustomAssembleFailed { get; set; } = "Custom assembly task failed to invoke because no custom command was specified.";
        public string CustomizeBuildFailed { get; set; } = "Custom build task failed to invoke because no custom command was specified.";
        public string DroppedFileErrorMsg { get; set; } = "The dropped file cannot be opened in the editor. Please contact the developer for assistance.";
        public string ExecutingCmd { get; set; } = "Executing command";
        public string FileAlreadyOpenedMsg { get; set; } = "This file is already open";
        public string FileName { get; set; } = "Filename";
        public string FileProperties { get; set; } = "File Properties";
        public string FilePropertiesError { get; set; } = "Properties of file cannot be shown for unsaved files.";
        public string Find { get; set; } = "Find";
        public string FindAndReplace { get; set; } = "Find And Replace";
        public string FindNext { get; set; } = "Find next";
        public string GoToLine { get; set; } = "Go to Line";
        public string HideLogConsole { get; set; } = "Hide log console";
        public string InvalidFileExtension { get; set; } = "The chosen file has an unsupported extension; only .asm files are accepted.";
        public string InvalidFilenameCharacter { get; set; } = "Filename cannot contain spaces or the following characters:";
        public string InvalidFilenameLength { get; set; } = "Filename cannot exceed 8 characters.";
        public string InvalidFileTitle { get; set; } = "Invalid Filename";
        public string Line { get; set; } = "Line";
        public string LineNumber { get; set; } = "Line Number";
        public string MatchCase { get; set; } = "Match case";
        public string MatchWholeWord { get; set; } = "Match whole word";
        public string MenuAssemble { get; set; } = "&Assemble";
        public string MenuAssembleAndBuild { get; set; } = "A&ssemble && Build";
        public string MenuAssembleBuildAndRun { get; set; } = "Asse&mble, Build && Run";
        public string MenuBarAssembleAndBuildText { get; set; } = "Assemble and build into an executable";
        public string MenuBarAssembleBuildAndRunText { get; set; } = "Assemble, build into an executable, and execute the program";
        public string MenuBarAssembleText { get; set; } = "Assemble the source code";
        public string MenuBarCodeDownText { get; set; } = "Shift selected code(s) downward";
        public string MenuBarCodeUpText { get; set; } = "Shift selected code(s) upward";
        public string MenuBarCommentCodeText { get; set; } = "Toggle comments for selected code";
        public string MenuBarCopyText { get; set; } = "&Copy";
        public string MenuBarCutText { get; set; } = "Cu&t";
        public string MenuBarDecreaseZoomText { get; set; } = "Decrease zoom level";
        public string MenuBarDeleteText { get; set; } = "Delete";
        public string MenuBarExitText { get; set; } = "&Quit";
        public string MenuBarHelpText { get; set; } = "View &Help";
        public string MenuBarIncreaseZoomText { get; set; } = "Increase zoom level";
        public string MenuBarLinkText { get; set; } = "Build executable";
        public string MenuBarNewText { get; set; } = "Open a new tab";
        public string MenuBarOpenText { get; set; } = "Open an existing ASM file";
        public string MenuBarPasteText { get; set; } = "&Paste";
        public string MenuBarPreferenceText { get; set; } = "Pre&ference";
        public string MenuBarPrintText { get; set; } = "Print the current file";
        public string MenuBarPropertiesText { get; set; } = "View file properties";
        public string MenuBarRedoText { get; set; } = "&Redo";
        public string MenuBarResetZoomText { get; set; } = "Reset the zoom level";
        public string MenuBarRunText { get; set; } = "Run the program";
        public string MenuBarSaveAsText { get; set; } = "Save the current file as a new file";
        public string MenuBarSaveText { get; set; } = "Save the current file";
        public string MenuBarUndoText { get; set; } = "&Undo";
        public string MenuBuild { get; set; } = "&Build";
        public string MenuChangeCaseTo { get; set; } = "Change the &case to";
        public string MenuChangeCaseToLowercase { get; set; } = "lowercase";
        public string MenuChangeCaseToUppercase { get; set; } = "UPPERCASE";
        public string MenuCheckForUpdate { get; set; } = "Check for update";
        public string MenuClearAll { get; set; } = "&Clear All";
        public string MenuClearLogConsole { get; set; } = "Clear log console";
        public string MenuClose { get; set; } = "&Close";
        public string MenuCloseActive { get; set; } = "C&lose Active";
        public string MenuCloseAll { get; set; } = "Close &All";
        public string MenuCloseOthers { get; set; } = "Close &Others";
        public string MenuDownloadLatestVersion { get; set; } = "Download &latest version";
        public string MenuEdit { get; set; } = "&Edit";
        public string MenuExamples { get; set; } = "&Examples";
        public string MenuFile { get; set; } = "&File";
        public string MenuHelp { get; set; } = "&Help";
        public string MenuLogConsole { get; set; } = "Log console";
        public string MenuMakeDonation { get; set; } = "Make a donation";
        public string MenuNew { get; set; } = "&New";
        public string MenuNewTab { get; set; } = "&New Tab";
        public string MenuOpen { get; set; } = "&Open";
        public string MenuOpenContainingFolder { get; set; } = "Open containing folder";
        public string MenuPrint { get; set; } = "&Print";
        public string MenuPrintPreview { get; set; } = "Print preview";
        public string MenuRecentFiles { get; set; } = "&Recent files";
        public string MenuReplace { get; set; } = "&Replace";
        public string MenuRun { get; set; } = "&Run";
        public string MenuSave { get; set; } = "&Save";
        public string MenuSaveAs { get; set; } = "Save As";
        public string MenuSelectAll { get; set; } = "Select &All";
        public string MenuTools { get; set; } = "&Tools";
        public string MenuViewChangeHistory { get; set; } = "&View change history";
        public string MenuViewFileProperties { get; set; } = "&View file properties";
        public string MenuViewUsage { get; set; } = "View &usage information";
        public string MenuVisitDeveloperHomepage { get; set; } = "Visit developer's page";
        public string MenuVisitProductHomepage { get; set; } = "Visit &product page";
        public string MenuWindows { get; set; } = "&Window";
        public string NewUpdateTitle { get; set; } = "New Update";
        public string NotFound { get; set; } = "Not found";
        public string NoUpdateMsg { get; set; } = "You are already using the latest version.";
        public string NoUpdateTitle { get; set; } = "No update";
        public string OccuranceReplaced { get; set; } = "occurrence(s) replaced";
        public string OpenError { get; set; } = "Open Error";
        public string OpenFolder { get; set; } = "Open Folder";
        public string OpenFolderError { get; set; } = "The folder of the unsaved file cannot be opened. Please save the file and then try again";
        public string OpeningFile { get; set; } = "Opening file";
        public string ProgramExecutedSuccessfully { get; set; } = "Program executed successfully";
        public string PropertiesCreatedOn { get; set; } = "Created on";
        public string PropertiesFileLocation { get; set; } = "File location";
        public string PropertiesLastAccessedOn { get; set; } = "Last accessed on";
        public string PropertiesLastModifiedOn { get; set; } = "Last modified on";
        public string Replace { get; set; } = "Replace";
        public string ReplaceAll { get; set; } = "Replace all";
        public string RunAbortByUser { get; set; } = "The execution of the executable has been aborted by the user.";
        public string RunExecutable { get; set; } = "Executing the executable file.";
        public string RunExecutableWithLauncher { get; set; } = "Executing the executable file using the Assembly Launcher.";
        public string RunFailed { get; set; } = "The execution of the executable process has encountered a failure.";
        public string RunFailedDueToIntegrity { get; set; } = "The execution of the executable has been aborted due to a failed integrity test.";
        public string RunFailedDueToSubProcess { get; set; } = "The execution of the executable failed due to a sub-process failure.";
        public string RunSkipped { get; set; } = "The execution of the executable has been skipped.";
        public string RunSucessful { get; set; } = "The execution of the executable completed successfully.";
        public string SaveFileAndProceedPromptMsg { get; set; } = "The current file has been modified and is unsaved. Would you like to save and proceed?";
        public string SaveFilePromptMsg { get; set; } = "The current file has been modified and is unsaved. Would you like to save it?";
        public string SaveTabAndProceedPromptMsg { get; set; } = "UnsavedTabTitleThe current tab has been modified and is unsaved. Would you like to save and proceed?";
        public string SaveTabPromptMsg { get; set; } = "The current tab has been modified and is unsaved. Would you like to save it?";
        public string SavingFile { get; set; } = "Saving file";
        public string SavingFileAs { get; set; } = "Saving file as";
        public string ShowLogConsole { get; set; } = "Show log console";
        public string SourceFile { get; set; } = "Source file";
        public string SuccessullyRestoredLastSession { get; set; } = "Your last session has been successfully restored.";
        public string TotalCharacters { get; set; } = "Total characters";
        public string TotalLines { get; set; } = "Total lines";
        public string UnAssembledCode { get; set; } = "Unassembled Code";
        public string UnBuiltCode { get; set; } = "Unbuilt Code";
        public string UnsavedFileTitle { get; set; } = "Unsaved File";
        public string UnsavedTabTitle { get; set; } = "Unsaved Tab";
        public string UpdateCheckFailedMsg { get; set; } = "An error occurred while checking for application updates.";
        public string UpdateCheckFailedTitle { get; set; } = "Update Error";
        public string UpdateHasBeenReleased { get; set; } = "is released and available for download";
    }
}

