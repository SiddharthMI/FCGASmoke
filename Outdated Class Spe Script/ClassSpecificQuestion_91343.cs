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

namespace Sid_FCGAProject.Outdated_Class_Spe_Script
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ClassSpecificQuestion_91343 recording.
    /// </summary>
    [TestModule("bdaf664e-8d07-4d3c-ae64-0b62985bdb63", ModuleType.Recording, 1)]
    public partial class ClassSpecificQuestion_91343 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repository.
        /// </summary>
        public static global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository repo = global::Sid_FCGAProject.Project_Repository.Sid_FCGAProjectRepository.Instance;

        static ClassSpecificQuestion_91343 instance = new ClassSpecificQuestion_91343();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ClassSpecificQuestion_91343()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ClassSpecificQuestion_91343 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo5' at 20;21.", repo.ApplicationUnderTest.MyTable.LabelTagNo5Info, new RecordItemIndex(0));
            repo.ApplicationUnderTest.MyTable.LabelTagNo5.Click("20;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo8' at 14;25.", repo.ApplicationUnderTest.MyTable.LabelTagNo8Info, new RecordItemIndex(1));
            repo.ApplicationUnderTest.MyTable.LabelTagNo8.Click("14;25");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MyTable.LabelTagNo9' at 15;24.", repo.ApplicationUnderTest.MyTable.LabelTagNo9Info, new RecordItemIndex(2));
            repo.ApplicationUnderTest.MyTable.LabelTagNo9.Click("15;24");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
