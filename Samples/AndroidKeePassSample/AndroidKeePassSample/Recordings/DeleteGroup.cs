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

namespace AndroidKeePassSample.Recordings
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DeleteCategory recording.
    /// </summary>
    [TestModule("221f3e06-a65a-44c1-8b45-7501a9963729", ModuleType.Recording, 1)]
    public partial class DeleteGroup : ITestModule
    {
        /// <summary>
        /// Holds an instance of the AndroidKeePassSample.AndroidKeePassSampleRepository repository.
        /// </summary>
        public static AndroidKeePassSample.AndroidKeePassSampleRepository repo = AndroidKeePassSample.AndroidKeePassSampleRepository.Instance;

        static DeleteGroup instance = new DeleteGroup();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DeleteGroup()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DeleteGroup Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable varGroupName.
        /// </summary>
        [TestVariable("20304009-2a35-4050-9036-e53d51cc5590")]
        public string varGroupName
        {
            get { return repo.varGroupName; }
            set { repo.varGroupName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.GroupActivity.GroupEntry' at Center", repo.ComAndroidKeepass.GroupActivity.GroupEntryInfo, new RecordItemIndex(0));
            repo.ComAndroidKeepass.GroupActivity.GroupEntry.Touch(2000);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComAndroidKeepass.DeleteGroup' at Center", repo.ComAndroidKeepass.DeleteGroupInfo, new RecordItemIndex(1));
            repo.ComAndroidKeepass.DeleteGroup.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
