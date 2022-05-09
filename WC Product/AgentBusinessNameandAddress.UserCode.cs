﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Sid_FCGAProject.WC_Product
{
    public partial class AgentBusinessNameandAddress
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Key_sequence_TxtBussInsuredName(RepoItemInfo inputtagInfo)
        {
        	//Random rnd = new Random();
            //int Rand  = rnd.Next(1000, 9999);
            //BusinessName = BusinessName+Rand.ToString();

            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$BusinessName' with focus on 'inputtagInfo'.", inputtagInfo);
            inputtagInfo.FindAdapter<InputTag>().EnsureVisible();
            Keyboard.Press(BusinessName);
        }

    }
}
