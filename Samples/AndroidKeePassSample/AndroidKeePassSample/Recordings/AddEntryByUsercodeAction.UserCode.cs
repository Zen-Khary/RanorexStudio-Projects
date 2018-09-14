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
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AndroidKeePassSample.Recordings
{
	public partial class AddEntryByUsercodeAction
	{
		/// <summary>
		/// This method gets called right after the recording has been started.
		/// It can be used to execute recording specific initialization code.
		/// </summary>
		private void Init()
		{
			// Your recording specific initialization code goes here.
		}

		public void AddEntryWithParams(string aTitle, string aUsername, string aPassword, string aURL, string aIconIndex)
		{

			Ranorex.Delay.Milliseconds(500);
			
			// Open Icon Dialog
			Ranorex.Report.Info ("Touch button 'Icon'");
			repo.ComAndroidKeepass.EntryActivity.IconButton.Touch();
			
			Ranorex.Delay.Milliseconds(500);

			// Select Icon
			Ranorex.Report.Info ("Touch icon image");
			repo.ComAndroidKeepass.IconImage.Touch();
			
			Ranorex.Delay.Milliseconds(500);

			// Set value to title field
			Ranorex.Report.Info ("Set value to 'Title'");
			repo.ComAndroidKeepass.EntryActivity.TextFields.EntryTitle.TextValue = aTitle;
			
			Ranorex.Delay.Milliseconds(500);
			
			// Set value to username field
			Ranorex.Report.Info ("Set value to field 'Username'");
			repo.ComAndroidKeepass.EntryActivity.TextFields.EntryUserName.TextValue = aUsername;
			
			Ranorex.Delay.Milliseconds(500);
			
			// Set value to password field
			Ranorex.Report.Info ("Set value to field 'Password'");
			repo.ComAndroidKeepass.EntryActivity.TextFields.EntryPassword.TextValue = aPassword;

			Ranorex.Delay.Milliseconds(500);
			
			// Set value to password confirmation field
			Ranorex.Report.Info ("Set value to field 'Password Confirmation'");
			repo.ComAndroidKeepass.EntryActivity.TextFields.EntryConfpassword.TextValue = aPassword;
			
			Ranorex.Delay.Milliseconds(500);
			
			// Set value to URL field
			Ranorex.Report.Info ("Set value to field 'URL'");
			repo.ComAndroidKeepass.EntryActivity.TextFields.EntryUrl.TextValue = aURL;
		}
	}
}