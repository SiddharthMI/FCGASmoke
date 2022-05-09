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

namespace Sid_FCGAProject.Common
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CO_PaymentMethod recording.
    /// </summary>
    [TestModule("e59f0d6e-9ebe-4171-86ee-269ac36882a9", ModuleType.Recording, 1)]
    public partial class CO_PaymentMethod : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static CO_PaymentMethod instance = new CO_PaymentMethod();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CO_PaymentMethod()
        {
            PaymentMethod = "Online Payment";
            Status_Reason = "Payment Method";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CO_PaymentMethod Instance
        {
            get { return instance; }
        }

#region Variables

        string _PaymentMethod;

        /// <summary>
        /// Gets or sets the value of variable PaymentMethod.
        /// </summary>
        [TestVariable("1baf6e86-344f-4720-b5d2-704d8933fdb3")]
        public string PaymentMethod
        {
            get { return _PaymentMethod; }
            set { _PaymentMethod = value; }
        }

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("7691f303-d326-41e4-9d48-31b72436621b")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectDeposit' at Center.", repo.ApplicationUnderTest.SelectDepositInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SelectDeposit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Search' at Center.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PaymentMethod' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Search.PressKeys(PaymentMethod);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest.Search'.", repo.ApplicationUnderTest.SearchInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.Search.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Ranorex.AutomationHelpers.UserCodeCollections.WebLibrary.ReportFullPageScreenshot(repo.ApplicationUnderTest.SelfInfo);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.NPFPolicySubmit' at Center.", repo.ApplicationUnderTest.NPFPolicySubmitInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.NPFPolicySubmit.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(6));
            //Delay.Duration(20000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.LblBusinessName'", repo.ApplicationUnderTest.LblBusinessNameInfo, new ActionTimeout(30000), new RecordItemIndex(7));
            repo.ApplicationUnderTest.LblBusinessNameInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(8));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
