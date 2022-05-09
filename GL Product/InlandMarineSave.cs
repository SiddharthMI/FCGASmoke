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
    ///The InlandMarineSave recording.
    /// </summary>
    [TestModule("593593d5-16cb-4664-ac36-9733284812b4", ModuleType.Recording, 1)]
    public partial class InlandMarineSave : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static InlandMarineSave instance = new InlandMarineSave();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InlandMarineSave()
        {
            Status_Reason = "Inland Marine Save";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InlandMarineSave Instance
        {
            get { return instance; }
        }

#region Variables

        string _Status_Reason;

        /// <summary>
        /// Gets or sets the value of variable Status_Reason.
        /// </summary>
        [TestVariable("28220f1a-823b-44eb-9b1d-bce365cc5477")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BtnSave1' at Center.", repo.ApplicationUnderTest.BtnSave1Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.BtnSave1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 15s to exist. Associated repository item: 'ApplicationUnderTest.UWBtnSave'", repo.ApplicationUnderTest.UWBtnSaveInfo, new ActionTimeout(15000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.UWBtnSaveInfo.WaitForExists(15000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
