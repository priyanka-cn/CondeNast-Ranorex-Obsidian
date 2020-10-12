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

namespace ContextCreation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ActionsInCriteria recording.
    /// </summary>
    [TestModule("30722468-b857-497b-ad6f-db2a66af3458", ModuleType.Recording, 1)]
    public partial class ActionsInCriteria : ITestModule
    {
        /// <summary>
        /// Holds an instance of the ContextCreationRepository repository.
        /// </summary>
        public static ContextCreationRepository repo = ContextCreationRepository.Instance;

        static ActionsInCriteria instance = new ActionsInCriteria();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActionsInCriteria()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActionsInCriteria Instance
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
            Mouse.DefaultMoveTime = 400;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditContext' at 12;5.", repo.ApplicationUnderTest.EditContextInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.EditContext.Click("12;5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'ApplicationUnderTest.ViewCriteriaInContext'", repo.ApplicationUnderTest.ViewCriteriaInContextInfo, new ActionTimeout(5000), new RecordItemIndex(1));
            repo.ApplicationUnderTest.ViewCriteriaInContextInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ViewCriteriaInContext' at 3;10.", repo.ApplicationUnderTest.ViewCriteriaInContextInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.ViewCriteriaInContext.Click("3;10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PreviewResultsCriteria' at 75;6.", repo.ApplicationUnderTest.PreviewResultsCriteriaInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.PreviewResultsCriteria.Click("75;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -920 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(-920);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelCriteriaInContext' at 20;9.", repo.ApplicationUnderTest.CancelCriteriaInContextInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.CancelCriteriaInContext.Click("20;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditCriteriaInContext' at 8;6.", repo.ApplicationUnderTest.EditCriteriaInContextInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.EditCriteriaInContext.Click("8;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CriteriaDescription' at 221;29.", repo.ApplicationUnderTest.CriteriaDescriptionInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.CriteriaDescription.Click("221;29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'ApplicationUnderTest.CriteriaDescription'.", repo.ApplicationUnderTest.CriteriaDescriptionInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.CriteriaDescription.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateCriteria' at 33;15.", repo.ApplicationUnderTest.CreateCriteriaInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.CreateCriteria.Click("33;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AttachNamedCriteria' at 102;6.", repo.ApplicationUnderTest.AttachNamedCriteriaInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.AttachNamedCriteria.Click("102;6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -2042 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-2042);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -3042 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-3042);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SelectAttachNamedCriteriaCheckbox' at Center.", repo.ApplicationUnderTest.SelectAttachNamedCriteriaCheckboxInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.SelectAttachNamedCriteriaCheckbox.Click();
            Delay.Milliseconds(0);
            
            //Validate_SelectAttachNamedCriteri(repo.ApplicationUnderTest.SelectAttachNamedCriteriInfo);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AttachSelectedNamedCriteria' at 58;27.", repo.ApplicationUnderTest.AttachSelectedNamedCriteriaInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.AttachSelectedNamedCriteria.Click("58;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ViewNamedCriteriaContext' at 3;11.", repo.ApplicationUnderTest.ViewNamedCriteriaContextInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.ViewNamedCriteriaContext.Click("3;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -773 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(-773);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PreviewResultsCriteria' at 70;19.", repo.ApplicationUnderTest.PreviewResultsCriteriaInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.PreviewResultsCriteria.Click("70;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelCriteriaInContext' at Center.", repo.ApplicationUnderTest.CancelCriteriaInContextInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.CancelCriteriaInContext.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Include_AddCriteria' at 52;8.", repo.ApplicationUnderTest.Include_AddCriteriaInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.Include_AddCriteria.Click("52;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CriteriaType' at 30;19.", repo.ApplicationUnderTest.CriteriaTypeInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.CriteriaType.Click("30;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.QueryByField' at 43;15.", repo.ApplicationUnderTest.QueryByFieldInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.QueryByField.Click("43;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.RawCriteriaMax256Characters' at 38;21.", repo.ApplicationUnderTest.RawCriteriaMax256CharactersInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.RawCriteriaMax256Characters.Click("38;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '\"Nail color\"' with focus on 'ApplicationUnderTest.RawCriteriaMax256Characters'.", repo.ApplicationUnderTest.RawCriteriaMax256CharactersInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.RawCriteriaMax256Characters.PressKeys("\"Nail color\"");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ColMd12ContextList.HALKeywords' at 108;27.", repo.ApplicationUnderTest.ColMd12ContextList.HALKeywordsInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.ColMd12ContextList.HALKeywords.Click("108;27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Button' at 36;15.", repo.ApplicationUnderTest.ButtonInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.Button.Click("36;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CriteriaName' at 408;13.", repo.ApplicationUnderTest.CriteriaNameInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.CriteriaName.Click("408;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Nail Color' with focus on 'ApplicationUnderTest.CriteriaName'.", repo.ApplicationUnderTest.CriteriaNameInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.CriteriaName.PressKeys("Nail Color");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateQueryByFieldCriteria' at 36;19.", repo.ApplicationUnderTest.CreateQueryByFieldCriteriaInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.CreateQueryByFieldCriteria.Click("36;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ApplicationUnderTest.ViewQueryByFieldCriteriaContext' at 3;10.", repo.ApplicationUnderTest.ViewQueryByFieldCriteriaContextInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.ViewQueryByFieldCriteriaContext.MoveTo("3;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'ApplicationUnderTest.ViewQueryByFieldCriteriaContext' at 3;10.", repo.ApplicationUnderTest.ViewQueryByFieldCriteriaContextInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.ViewQueryByFieldCriteriaContext.MoveTo("3;10");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -4121 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(-4121);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1015 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-1015);
            Delay.Milliseconds(400);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.PreviewResultsCriteria' at 62;21.", repo.ApplicationUnderTest.PreviewResultsCriteriaInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.PreviewResultsCriteria.Click("62;21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CancelCriteriaInContext' at 26;3.", repo.ApplicationUnderTest.CancelCriteriaInContextInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.CancelCriteriaInContext.Click("26;3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EditQueryByFieldCriteiraContext' at 5;8.", repo.ApplicationUnderTest.EditQueryByFieldCriteiraContextInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.EditQueryByFieldCriteiraContext.Click("5;8");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CriteriaDescription' at 358;16.", repo.ApplicationUnderTest.CriteriaDescriptionInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.CriteriaDescription.Click("358;16");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'ApplicationUnderTest.CriteriaDescription'.", repo.ApplicationUnderTest.CriteriaDescriptionInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.CriteriaDescription.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Button' at 66;9.", repo.ApplicationUnderTest.ButtonInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.Button.Click("66;9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ColMd12ContextList.Menu1' at 37;19.", repo.ApplicationUnderTest.ColMd12ContextList.Menu1Info, new RecordItemIndex(40));
            repo.ApplicationUnderTest.ColMd12ContextList.Menu1.Click("37;19");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ColMd12ContextList.English' at 61;23.", repo.ApplicationUnderTest.ColMd12ContextList.EnglishInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.ColMd12ContextList.English.Click("61;23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CreateQueryByFieldCriteria' at 35;15.", repo.ApplicationUnderTest.CreateQueryByFieldCriteriaInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.CreateQueryByFieldCriteria.Click("35;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SavePublish' at 100;14.", repo.ApplicationUnderTest.SavePublishInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.SavePublish.Click("100;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
