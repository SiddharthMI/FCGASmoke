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

namespace Sid_FCGAProject.GL_Product
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The FWCIQuoteDocuments recording.
    /// </summary>
    [TestModule("43373bc6-02f4-4477-92f1-d08ac557e43d", ModuleType.Recording, 1)]
    public partial class FWCIQuoteDocuments : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static FWCIQuoteDocuments instance = new FWCIQuoteDocuments();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public FWCIQuoteDocuments()
        {
            FWCIPremium = "0";
            Status_Reason = "FWCI Carrier Selection";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static FWCIQuoteDocuments Instance
        {
            get { return instance; }
        }

#region Variables

        string _FWCIPremium;

        /// <summary>
        /// Gets or sets the value of variable FWCIPremium.
        /// </summary>
        [TestVariable("9042cf7f-589a-4e1f-80ae-aecb22435fac")]
        public string FWCIPremium
        {
            get { return _FWCIPremium; }
            set { _FWCIPremium = value; }
        }

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("63e5decf-25b3-41ac-ae29-a794267e230a")]
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FwcPremium' at Center.", repo.ApplicationUnderTest.FwcPremiumInfo, new RecordItemIndex(0));
            //repo.ApplicationUnderTest.FwcPremium.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.FwcPremium' and assigning its value to variable 'FWCIPremium'.", repo.ApplicationUnderTest.FwcPremiumInfo, new RecordItemIndex(1));
            FWCIPremium = repo.ApplicationUnderTest.FwcPremium.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", FWCIPremium, new RecordItemIndex(2));
            
            // Download FWCI Quote Docs
            Report.Log(ReportLevel.Info, "Section", "Download FWCI Quote Docs", new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadFWCIQuote' at Center.", repo.ApplicationUnderTest.BtnDownloadFWCIQuoteInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.BtnDownloadFWCIQuote.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Quote.Close' at Center.", repo.Quote.CloseInfo, new RecordItemIndex(6));
            //repo.Quote.Close.Click();
            //Delay.Milliseconds(0);
            
            // Download FWCI Worksheet Docs
            Report.Log(ReportLevel.Info, "Section", "Download FWCI Worksheet Docs", new RecordItemIndex(7));
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnDownloadFWCIRatingWorksheet' at Center.", repo.ApplicationUnderTest.BtnDownloadFWCIRatingWorksheetInfo, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.BtnDownloadFWCIRatingWorksheet.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(9));
            //Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Quote.Close' at Center.", repo.Quote.CloseInfo, new RecordItemIndex(10));
            //repo.Quote.Close.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(11));
            //Delay.Duration(2000, false);
            
            // Select Carrier
            Report.Log(ReportLevel.Info, "Section", "Select Carrier", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnCarrierFWCI' at Center.", repo.ApplicationUnderTest.BtnCarrierFWCIInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.BtnCarrierFWCI.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
