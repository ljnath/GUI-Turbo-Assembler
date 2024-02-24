using GUITurboAssembler.Localization;
using GUITurboAssembler.Localization.Handlers;
using GUITurboAssembler.Localization.Handlers.Exceptions;
using GUITurboAssembler.Localization.Models;
using GUITurboAssembler.Localization.Models.Text;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO.Fakes;
using System.Text.RegularExpressions;
using ZeroDepJson.Fakes;

namespace LocalizationTests
{
    [TestClass]
    public class TextHandlerTests
    {
        [TestMethod()]
        public void Load_ValidateDefaultLocale()
        {
            TextHandler textHandler = new TextHandler();
            Texts actualTexts = textHandler.Load("EN");

            Assert.AreEqual("EN", actualTexts.Language.Code);
            Assert.AreEqual("English", actualTexts.Language.Name);
        }

        [TestMethod()]
        public void Load_ValidateCustomLocale()
        {
            Texts expectedTexts = new Texts();
            expectedTexts.Language.Code = "XYZ";
            expectedTexts.Language.Name = "XYZ Language";

            using (ShimsContext.Create())
            {
                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return true; };

                // mocking the streamreader creation, for any argument the stream-reader creation will do nothing
                ShimStreamReader.ConstructorStringEncoding = (parent, arg1, arg2) => { };

                // mocking the ZeroDepJson library Desearlize property, for any streamreader it will return the expected object
                ShimZeroDepJson.DeserializeTextReaderTypeJsonOptions = (parent, arg1, arg2) => { return expectedTexts; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();
                Texts actualTexts = textHandler.Load("xyz");

                // assertion
                Assert.AreEqual(expectedTexts.Language.Code, actualTexts.Language.Code);
                Assert.AreEqual(expectedTexts.Language.Name, actualTexts.Language.Name);
            }
        }

        [TestMethod()]
        public void Load_ValidateExceptionIncaseOfMissingLocaleFile()
        {
            using (ShimsContext.Create())
            {
                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return false; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();

                // assertion
                Exception ex = Assert.ThrowsException<LocalizationException>(() => textHandler.Load("xyz"));
                Assert.AreEqual(true, Regex.IsMatch(ex.Message, "(Language file).+(XYZ.lang is missing)"));
            }
        }



        [TestMethod()]
        public void GetAvailableLanguages_ValidateDefaultLocale()
        {
            TextHandler textHandler = new TextHandler();
            Locale[] locales = textHandler.GetAvailableLanguages();

            // list of all expected locales
            List<string[]> expectedLocales = new List<string[]>
            {
                new string[] { "DE", "Deutsch" },
                new string[] { "EN", "English" },
                new string[] { "FR", "Français" },
                new string[] { "HI", "हिंदी" },
                new string[] { "PL", "Polski" },
                new string[] { "RU", "русский" },
                new string[] { "ZH-HANT", "中國傳統的" },
            };

            // assert if all found locales are in the above expected order
            for (int i = 0; i < locales.Length; i++)
            {
                Assert.AreEqual(expectedLocales[i][0], locales[i].Code);
                Assert.AreEqual(expectedLocales[i][1], locales[i].Name);
            }
        }

        [TestMethod()]
        public void GetAvailableLanguages_ValidateEnLocaleIsSkipped()
        {
            string[] customLocaleFiles = new string[] { "EN.lang" };

            Texts expectedTexts = new Texts();
            expectedTexts.Language.Code = "EN";
            expectedTexts.Language.Name = "English";

            using (ShimsContext.Create())
            {
                // faking/mocking the directory getFiles; we will return a custom1.lang file
                ShimDirectory.GetFilesStringStringSearchOption = (arg1, arg2, arg3) => { return customLocaleFiles; };

                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return true; };

                // mocking the streamreader creation, for any argument the stream-reader creation will do nothing
                ShimStreamReader.ConstructorStringEncoding = (parent, arg1, arg2) => { };

                // mocking the ZeroDepJson library Desearlize property, for any streamreader it will return the expected object
                ShimZeroDepJson.DeserializeTextReaderTypeJsonOptions = (parent, arg1, arg2) => { return expectedTexts; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();
                Locale[] locales = textHandler.GetAvailableLanguages();

                // assertion
                Assert.AreEqual(7, locales.Length);
            }
        }

        [TestMethod()]
        public void GetAvailableLanguages_ValidateOneCustomLocaleFile()
        {
            string[] customLocaleFiles = new string[] { "custom1.lang" };

            Texts expectedTexts = new Texts();
            expectedTexts.Language.Code = "CUSTOM_1";
            expectedTexts.Language.Name = "CUSTOM_ONE";

            using (ShimsContext.Create())
            {
                // faking/mocking the directory getFiles; we will return a custom1.lang file
                ShimDirectory.GetFilesStringStringSearchOption = (arg1, arg2, arg3) => { return customLocaleFiles; };

                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return true; };

                // mocking the streamreader creation, for any argument the stream-reader creation will do nothing
                ShimStreamReader.ConstructorStringEncoding = (parent, arg1, arg2) => { };

                // mocking the ZeroDepJson library Desearlize property, for any streamreader it will return the expected object
                ShimZeroDepJson.DeserializeTextReaderTypeJsonOptions = (parent, arg1, arg2) => { return expectedTexts; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();
                Locale[] locales = textHandler.GetAvailableLanguages();

                // assertion
                Assert.AreEqual(expectedTexts.Language.Code, locales[7].Code);
                Assert.AreEqual(expectedTexts.Language.Name, locales[7].Name);
            }
        }

        [TestMethod()]
        public void GetAvailableLanguages_ValidateMultipleCustomLocaleFiles()
        {
            string[] customLocaleFiles = new string[] { "custom1.lang", "custom2.lang" };

            Texts expectedTexts = new Texts();
            expectedTexts.Language.Code = "DUMMUY";
            expectedTexts.Language.Name = "Dummy language name";

            using (ShimsContext.Create())
            {
                // faking/mocking the directory getFiles; we will return a custom1.lang file
                ShimDirectory.GetFilesStringStringSearchOption = (arg1, arg2, arg3) => { return customLocaleFiles; };

                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return true; };

                // mocking the streamreader creation, for any argument the stream-reader creation will do nothing
                ShimStreamReader.ConstructorStringEncoding = (parent, arg1, arg2) => { };

                // mocking the ZeroDepJson library Desearlize property, for any streamreader it will return the expected object
                ShimZeroDepJson.DeserializeTextReaderTypeJsonOptions = (parent, arg1, arg2) => { return expectedTexts; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();
                Locale[] locales = textHandler.GetAvailableLanguages();

                // assert that count is default + 2 = 9
                Assert.AreEqual(9, locales.Length);
            }
        }

        [TestMethod()]
        public void GetAvailableLanguages_ValidateMissingCustomLocaleFilesShouldNotBeLoaded()
        {
            string[] customLocaleFiles = new string[] { "custom1.lang"};

            using (ShimsContext.Create())
            {
                // faking/mocking the directory getFiles; we will return a custom1.lang file
                ShimDirectory.GetFilesStringStringSearchOption = (arg1, arg2, arg3) => { return customLocaleFiles; };

                // faking/mocking the file exists method; for any argument it will be true
                ShimFile.ExistsString = (arg1) => { return false; };

                // mocking the streamreader creation, for any argument the stream-reader creation will do nothing
                ShimStreamReader.ConstructorStringEncoding = (parent, arg1, arg2) => { };

                //// mocking the ZeroDepJson library Desearlize property, for any streamreader it will return the expected object
                //ShimZeroDepJson.DeserializeTextReaderTypeJsonOptions = (parent, arg1, arg2) => { return expectedTexts; };

                // calling our method to test
                TextHandler textHandler = new TextHandler();
                Locale[] locales = textHandler.GetAvailableLanguages();

                // assert that count is default
                Assert.AreEqual(7, locales.Length);
            }
        }
    }
}
