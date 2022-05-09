﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Sid_FCGAProject.WC_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BMQuoteDocument recording.
    /// </summary>
    [TestModule("35883a1a-f0a5-4793-a679-b46efe4ef714", ModuleType.Recording, 1)]
    public partial class BMQuoteDocument : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static BMQuoteDocument instance = new BMQuoteDocument();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BMQuoteDocument()
        {
            BMPremium = "0";
            Status_Reason = "Benchmark Carrier Selection";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BMQuoteDocument Instance
        {
            get { return instance; }
        }

#region Variables

        string _BMPremium;

        /// <summary>
        /// Gets or sets the value of variable BMPremium.
        /// </summary>
        [TestVariable("724950a8-6e87-46bf-a31e-c5380eb60e74")]
        public string BMPremium
        {
            get { return _BMPremium; }
            set { _BMPremium = value; }
        }

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("8f1dd563-e8d6-45ae-855d-3f220b7cc532")]
        public string Status_Reason
        {
            get { return _Status_Reason; }
            set { _Status_Reason = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BenchmarkPremium' at Center.", repo.ApplicationUnderTest.BenchmarkPremiumInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.BenchmarkPremium.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.BenchmarkPremium' and assigning its value to variable 'BMPremium'.", repo.ApplicationUnderTest.BenchmarkPremiumInfo, new RecordItemIndex(1));
            BMPremium = repo.ApplicationUnderTest.BenchmarkPremium.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", BMPremium, new RecordItemIndex(2));
            
            // Download BM Quote Docs
            Report.Log(ReportLevel.Info, "Section", "Download BM Quote Docs", new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadBMQuote' at Center.", repo.ApplicationUnderTest.BtnDownloadBMQuoteInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.BtnDownloadBMQuote.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsQawinstonFwcinsComFWCPortalP.Close' at Center.", repo.HttpsQawinstonFwcinsComFWCPortalP.CloseInfo, new RecordItemIndex(6));
            //repo.HttpsQawinstonFwcinsComFWCPortalP.Close.Click();
            //Delay.Milliseconds(0);
            
            // Download BM Worksheet Docs
            Report.Log(ReportLevel.Info, "Section", "Download BM Worksheet Docs", new RecordItemIndex(7));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadBMRatingWorksheet' at 78;20.", repo.ApplicationUnderTest.BtnDownloadBMRatingWorksheetInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.BtnDownloadBMRatingWorksheet.Click("78;20");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(9));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HttpsQawinstonFwcinsComFWCPortalP.Close' at Center.", repo.HttpsQawinstonFwcinsComFWCPortalP.CloseInfo, new RecordItemIndex(10));
            //repo.HttpsQawinstonFwcinsComFWCPortalP.Close.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            //Delay.Duration(2000, false);
            
            // Select Carrier
            Report.Log(ReportLevel.Info, "Section", "Select Carrier", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnCarrierBest' at 32;20.", repo.ApplicationUnderTest.BtnCarrierBestInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.BtnCarrierBest.Click("32;20");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
