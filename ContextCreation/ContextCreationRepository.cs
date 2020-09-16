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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ContextCreation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ContextCreationRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("3c1d8e65-33e2-4e0b-bf1a-4762e295e4a8")]
    public partial class ContextCreationRepository : RepoGenBaseFolder
    {
        static ContextCreationRepository instance = new ContextCreationRepository();
        ContextCreationRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        ContextCreationRepositoryFolders.DropdownAppFolder _dropdown;

        /// <summary>
        /// Gets the singleton class instance representing the ContextCreationRepository element repository.
        /// </summary>
        [RepositoryFolder("3c1d8e65-33e2-4e0b-bf1a-4762e295e4a8")]
        public static ContextCreationRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ContextCreationRepository() 
            : base("ContextCreationRepository", "/", null, 0, false, "3c1d8e65-33e2-4e0b-bf1a-4762e295e4a8", ".\\RepositoryImages\\ContextCreationRepository3c1d8e65.rximgres")
        {
            _applicationundertest = new ContextCreationRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _dropdown = new ContextCreationRepositoryFolders.DropdownAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("3c1d8e65-33e2-4e0b-bf1a-4762e295e4a8")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("823c9497-8fe1-4f43-92e3-c31c632170d8")]
        public virtual ContextCreationRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The Dropdown folder.
        /// </summary>
        [RepositoryFolder("1eaae59b-427a-476d-ad5d-64c6ca22be28")]
        public virtual ContextCreationRepositoryFolders.DropdownAppFolder Dropdown
        {
            get { return _dropdown; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class ContextCreationRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("823c9497-8fe1-4f43-92e3-c31c632170d8")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            ContextCreationRepositoryFolders.AutoMarginColMd4ColMdOffset2PlFolder _automargincolmd4colmdoffset2pl;
            RepoItemInfo _useremailInfo;
            RepoItemInfo _userpasswordInfo;
            RepoItemInfo _contextstudioInfo;
            RepoItemInfo _createcontextInfo;
            RepoItemInfo _contextnameInfo;
            RepoItemInfo _classificationsdropdownmenushowInfo;
            RepoItemInfo _classificationselectionInfo;
            RepoItemInfo _savepublishInfo;
            RepoItemInfo _userprofilebuttonInfo;
            RepoItemInfo _ataglogoutInfo;
            RepoItemInfo _editInfo;
            RepoItemInfo _criterianameInfo;
            RepoItemInfo _rawcriteriaInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='obsidian-staging.conde.io']", parentFolder, 30000, null, false, "823c9497-8fe1-4f43-92e3-c31c632170d8", "")
            {
                _automargincolmd4colmdoffset2pl = new ContextCreationRepositoryFolders.AutoMarginColMd4ColMdOffset2PlFolder(this);
                _useremailInfo = new RepoItemInfo(this, "UserEmail", ".//input[#'user_email']", 30000, null, "42d79b3b-080b-46f6-a75f-24122bf286e9");
                _userpasswordInfo = new RepoItemInfo(this, "UserPassword", ".//input[#'user_password']", 30000, null, "7119820c-9335-4301-818d-c672ce267863");
                _contextstudioInfo = new RepoItemInfo(this, "ContextStudio", ".//h1[#'site_title']/a[@innertext='Context Studio']", 30000, null, "96b4961a-cfdc-4d13-8d70-f151de7507e7");
                _createcontextInfo = new RepoItemInfo(this, "CreateContext", "body/div[1]/div[2]/div[1]/div[1]/div[2]/input[@type='button']", 30000, null, "58b75242-4a55-41b0-867d-c4760893c1c3");
                _contextnameInfo = new RepoItemInfo(this, "ContextName", ".//input[#'context-name']", 30000, null, "1d556758-5038-47bb-a621-4d464e4da2c4");
                _classificationsdropdownmenushowInfo = new RepoItemInfo(this, "ClassificationsDropdownMenuShow", "body/div[2]/div[1]/div[3]/div[2]/ul", 30000, null, "bd8443de-8839-4706-a5b3-3420d31fc10b");
                _classificationselectionInfo = new RepoItemInfo(this, "ClassificationSelection", "body/div[2]/div[1]/div[3]/div[2]/ul/li[25]/a[@innertext='Style & Fashion']", 30000, null, "cdbfa5af-020b-4ec1-9c06-6f2ab179a852");
                _savepublishInfo = new RepoItemInfo(this, "SavePublish", "body/div[1]/div[1]/div[1]/div[1]/div[2]/input[@type='button'][1]", 30000, null, "a952fb2f-b29b-46c7-a302-1e591a9191bf");
                _userprofilebuttonInfo = new RepoItemInfo(this, "UserProfileButton", "body/div/div[1]//button[@innertext='Priyanka Ramesh ']", 30000, null, "0b0d954d-9463-4dea-873a-464804d09fe8");
                _ataglogoutInfo = new RepoItemInfo(this, "ATagLogout", ".//div[#'myDropdown']/a[@innertext='  Logout']", 30000, null, "aed89080-5778-401d-8065-d6a13ff918c2");
                _editInfo = new RepoItemInfo(this, "Edit", "body/div/div[2]/div[2]/?/?/table/tbody/tr[1]/td[6]/span[@innertext=' /  / ']/a[@innertext='Edit']", 30000, null, "5874e392-e729-4b5c-9fa4-5e344e22ef07");
                _criterianameInfo = new RepoItemInfo(this, "CriteriaName", ".//input[#'criteria-name']", 30000, null, "0b5665c0-bce7-40b7-bd7c-1c606eb24cb9");
                _rawcriteriaInfo = new RepoItemInfo(this, "RawCriteria", ".//textarea[#'raw-criteria']", 30000, null, "2f341cdc-9efe-4d35-b9a2-9c3cceeb05fa");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("823c9497-8fe1-4f43-92e3-c31c632170d8")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("823c9497-8fe1-4f43-92e3-c31c632170d8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The UserEmail item.
            /// </summary>
            [RepositoryItem("42d79b3b-080b-46f6-a75f-24122bf286e9")]
            public virtual Ranorex.InputTag UserEmail
            {
                get
                {
                    return _useremailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserEmail item info.
            /// </summary>
            [RepositoryItemInfo("42d79b3b-080b-46f6-a75f-24122bf286e9")]
            public virtual RepoItemInfo UserEmailInfo
            {
                get
                {
                    return _useremailInfo;
                }
            }

            /// <summary>
            /// The UserPassword item.
            /// </summary>
            [RepositoryItem("7119820c-9335-4301-818d-c672ce267863")]
            public virtual Ranorex.InputTag UserPassword
            {
                get
                {
                    return _userpasswordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The UserPassword item info.
            /// </summary>
            [RepositoryItemInfo("7119820c-9335-4301-818d-c672ce267863")]
            public virtual RepoItemInfo UserPasswordInfo
            {
                get
                {
                    return _userpasswordInfo;
                }
            }

            /// <summary>
            /// The ContextStudio item.
            /// </summary>
            [RepositoryItem("96b4961a-cfdc-4d13-8d70-f151de7507e7")]
            public virtual Ranorex.ATag ContextStudio
            {
                get
                {
                    return _contextstudioInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ContextStudio item info.
            /// </summary>
            [RepositoryItemInfo("96b4961a-cfdc-4d13-8d70-f151de7507e7")]
            public virtual RepoItemInfo ContextStudioInfo
            {
                get
                {
                    return _contextstudioInfo;
                }
            }

            /// <summary>
            /// The CreateContext item.
            /// </summary>
            [RepositoryItem("58b75242-4a55-41b0-867d-c4760893c1c3")]
            public virtual Ranorex.InputTag CreateContext
            {
                get
                {
                    return _createcontextInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The CreateContext item info.
            /// </summary>
            [RepositoryItemInfo("58b75242-4a55-41b0-867d-c4760893c1c3")]
            public virtual RepoItemInfo CreateContextInfo
            {
                get
                {
                    return _createcontextInfo;
                }
            }

            /// <summary>
            /// The ContextName item.
            /// </summary>
            [RepositoryItem("1d556758-5038-47bb-a621-4d464e4da2c4")]
            public virtual Ranorex.InputTag ContextName
            {
                get
                {
                    return _contextnameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The ContextName item info.
            /// </summary>
            [RepositoryItemInfo("1d556758-5038-47bb-a621-4d464e4da2c4")]
            public virtual RepoItemInfo ContextNameInfo
            {
                get
                {
                    return _contextnameInfo;
                }
            }

            /// <summary>
            /// The ClassificationsDropdownMenuShow item.
            /// </summary>
            [RepositoryItem("bd8443de-8839-4706-a5b3-3420d31fc10b")]
            public virtual Ranorex.UlTag ClassificationsDropdownMenuShow
            {
                get
                {
                    return _classificationsdropdownmenushowInfo.CreateAdapter<Ranorex.UlTag>(true);
                }
            }

            /// <summary>
            /// The ClassificationsDropdownMenuShow item info.
            /// </summary>
            [RepositoryItemInfo("bd8443de-8839-4706-a5b3-3420d31fc10b")]
            public virtual RepoItemInfo ClassificationsDropdownMenuShowInfo
            {
                get
                {
                    return _classificationsdropdownmenushowInfo;
                }
            }

            /// <summary>
            /// The ClassificationSelection item.
            /// </summary>
            [RepositoryItem("cdbfa5af-020b-4ec1-9c06-6f2ab179a852")]
            public virtual Ranorex.ATag ClassificationSelection
            {
                get
                {
                    return _classificationselectionInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ClassificationSelection item info.
            /// </summary>
            [RepositoryItemInfo("cdbfa5af-020b-4ec1-9c06-6f2ab179a852")]
            public virtual RepoItemInfo ClassificationSelectionInfo
            {
                get
                {
                    return _classificationselectionInfo;
                }
            }

            /// <summary>
            /// The SavePublish item.
            /// </summary>
            [RepositoryItem("a952fb2f-b29b-46c7-a302-1e591a9191bf")]
            public virtual Ranorex.InputTag SavePublish
            {
                get
                {
                    return _savepublishInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The SavePublish item info.
            /// </summary>
            [RepositoryItemInfo("a952fb2f-b29b-46c7-a302-1e591a9191bf")]
            public virtual RepoItemInfo SavePublishInfo
            {
                get
                {
                    return _savepublishInfo;
                }
            }

            /// <summary>
            /// The UserProfileButton item.
            /// </summary>
            [RepositoryItem("0b0d954d-9463-4dea-873a-464804d09fe8")]
            public virtual Ranorex.ButtonTag UserProfileButton
            {
                get
                {
                    return _userprofilebuttonInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The UserProfileButton item info.
            /// </summary>
            [RepositoryItemInfo("0b0d954d-9463-4dea-873a-464804d09fe8")]
            public virtual RepoItemInfo UserProfileButtonInfo
            {
                get
                {
                    return _userprofilebuttonInfo;
                }
            }

            /// <summary>
            /// The ATagLogout item.
            /// </summary>
            [RepositoryItem("aed89080-5778-401d-8065-d6a13ff918c2")]
            public virtual Ranorex.ATag ATagLogout
            {
                get
                {
                    return _ataglogoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ATagLogout item info.
            /// </summary>
            [RepositoryItemInfo("aed89080-5778-401d-8065-d6a13ff918c2")]
            public virtual RepoItemInfo ATagLogoutInfo
            {
                get
                {
                    return _ataglogoutInfo;
                }
            }

            /// <summary>
            /// The Edit item.
            /// </summary>
            [RepositoryItem("5874e392-e729-4b5c-9fa4-5e344e22ef07")]
            public virtual Ranorex.ATag Edit
            {
                get
                {
                    return _editInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Edit item info.
            /// </summary>
            [RepositoryItemInfo("5874e392-e729-4b5c-9fa4-5e344e22ef07")]
            public virtual RepoItemInfo EditInfo
            {
                get
                {
                    return _editInfo;
                }
            }

            /// <summary>
            /// The CriteriaName item.
            /// </summary>
            [RepositoryItem("0b5665c0-bce7-40b7-bd7c-1c606eb24cb9")]
            public virtual Ranorex.InputTag CriteriaName
            {
                get
                {
                    return _criterianameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The CriteriaName item info.
            /// </summary>
            [RepositoryItemInfo("0b5665c0-bce7-40b7-bd7c-1c606eb24cb9")]
            public virtual RepoItemInfo CriteriaNameInfo
            {
                get
                {
                    return _criterianameInfo;
                }
            }

            /// <summary>
            /// The RawCriteria item.
            /// </summary>
            [RepositoryItem("2f341cdc-9efe-4d35-b9a2-9c3cceeb05fa")]
            public virtual Ranorex.TextAreaTag RawCriteria
            {
                get
                {
                    return _rawcriteriaInfo.CreateAdapter<Ranorex.TextAreaTag>(true);
                }
            }

            /// <summary>
            /// The RawCriteria item info.
            /// </summary>
            [RepositoryItemInfo("2f341cdc-9efe-4d35-b9a2-9c3cceeb05fa")]
            public virtual RepoItemInfo RawCriteriaInfo
            {
                get
                {
                    return _rawcriteriaInfo;
                }
            }

            /// <summary>
            /// The AutoMarginColMd4ColMdOffset2Pl folder.
            /// </summary>
            [RepositoryFolder("6cdecef8-8273-4e0c-80f5-3abac59c2774")]
            public virtual ContextCreationRepositoryFolders.AutoMarginColMd4ColMdOffset2PlFolder AutoMarginColMd4ColMdOffset2Pl
            {
                get { return _automargincolmd4colmdoffset2pl; }
            }
        }

        /// <summary>
        /// The AutoMarginColMd4ColMdOffset2PlFolder folder.
        /// </summary>
        [RepositoryFolder("6cdecef8-8273-4e0c-80f5-3abac59c2774")]
        public partial class AutoMarginColMd4ColMdOffset2PlFolder : RepoGenBaseFolder
        {
            RepoItemInfo _subclassificationsInfo;
            RepoItemInfo _buttontagclassificationsInfo;
            RepoItemInfo _subclassificationselectionInfo;
            RepoItemInfo _addcriteriaInfo;
            RepoItemInfo _buttonInfo;
            RepoItemInfo _button1Info;
            RepoItemInfo _attachnamedcriteriaInfo;
            RepoItemInfo _closeInfo;
            RepoItemInfo _divtagaddexcludecriteriaInfo;
            RepoItemInfo _addcriteria1Info;
            RepoItemInfo _button2Info;
            RepoItemInfo _button3Info;

            /// <summary>
            /// Creates a new AutoMarginColMd4ColMdOffset2Pl  folder.
            /// </summary>
            public AutoMarginColMd4ColMdOffset2PlFolder(RepoGenBaseFolder parentFolder) :
                    base("AutoMarginColMd4ColMdOffset2Pl", "body/div[2]/div[1]/div[3]", parentFolder, 30000, null, false, "6cdecef8-8273-4e0c-80f5-3abac59c2774", "")
            {
                _subclassificationsInfo = new RepoItemInfo(this, "SubClassifications", "?/?/button[@innertext='Sub-Classifications ']", 30000, null, "69dcfa3e-f624-47c3-aaa3-76a5793e6edf");
                _buttontagclassificationsInfo = new RepoItemInfo(this, "ButtonTagClassifications", "?/?/button[@innertext=' Classifications']", 30000, null, "125d9ce1-f3bc-44ec-989c-462bdcbaddce");
                _subclassificationselectionInfo = new RepoItemInfo(this, "SubClassificationSelection", "?/?/ul/li[1]/a[@innertext='Beauty']", 30000, null, "31531f54-6f65-4cd9-a64b-1913f58ee3f8");
                _addcriteriaInfo = new RepoItemInfo(this, "AddCriteria", "div/div[2]/?/?/a[@innertext='Add Criteria']", 30000, null, "78040042-89a2-4408-bfbc-17121ae285ab");
                _buttonInfo = new RepoItemInfo(this, "Button", "div[2]//input[@value='Preview Results']", 30000, null, "6a9ed6dc-7cf2-4b8a-87e3-a7dc50006ab0");
                _button1Info = new RepoItemInfo(this, "Button1", "div[2]//input[@value='Create Criteria']", 30000, null, "f94559b0-27bf-45b6-9c2e-67d859765bd0");
                _attachnamedcriteriaInfo = new RepoItemInfo(this, "AttachNamedCriteria", "div/div[2]/?/?/a[@innertext='Attach Named Criteria']", 30000, null, "d7784f1e-51e1-42d4-b5d4-45556b9ccf33");
                _closeInfo = new RepoItemInfo(this, "Close", "div[1]/div[2]//a[@innertext='Close']", 30000, null, "2f407228-71ca-4efc-81b3-fc8ba6ab41dd");
                _divtagaddexcludecriteriaInfo = new RepoItemInfo(this, "DivTagAddEXCLUDECriteria", ".//div[@innertext>'  Add EXCLUDE Criteria']", 30000, null, "8e2cc944-fdc7-47de-abd9-248f7e8b14c4");
                _addcriteria1Info = new RepoItemInfo(this, "AddCriteria1", "div/div[2]/?/?/a[@innertext='Add Criteria']", 30000, null, "7767cf83-0ac9-4bc9-af82-58d1d8359889");
                _button2Info = new RepoItemInfo(this, "Button2", "div[2]//input[@value='Preview Results']", 30000, null, "fa21f38c-07df-4934-ac4e-f9b05001d058");
                _button3Info = new RepoItemInfo(this, "Button3", "div[2]//input[@value='Create Criteria']", 30000, null, "e506fd3e-f6c8-4b52-810f-73ed67759631");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("6cdecef8-8273-4e0c-80f5-3abac59c2774")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("6cdecef8-8273-4e0c-80f5-3abac59c2774")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SubClassifications item.
            /// </summary>
            [RepositoryItem("69dcfa3e-f624-47c3-aaa3-76a5793e6edf")]
            public virtual Ranorex.ButtonTag SubClassifications
            {
                get
                {
                    return _subclassificationsInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The SubClassifications item info.
            /// </summary>
            [RepositoryItemInfo("69dcfa3e-f624-47c3-aaa3-76a5793e6edf")]
            public virtual RepoItemInfo SubClassificationsInfo
            {
                get
                {
                    return _subclassificationsInfo;
                }
            }

            /// <summary>
            /// The ButtonTagClassifications item.
            /// </summary>
            [RepositoryItem("125d9ce1-f3bc-44ec-989c-462bdcbaddce")]
            public virtual Ranorex.ButtonTag ButtonTagClassifications
            {
                get
                {
                    return _buttontagclassificationsInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The ButtonTagClassifications item info.
            /// </summary>
            [RepositoryItemInfo("125d9ce1-f3bc-44ec-989c-462bdcbaddce")]
            public virtual RepoItemInfo ButtonTagClassificationsInfo
            {
                get
                {
                    return _buttontagclassificationsInfo;
                }
            }

            /// <summary>
            /// The SubClassificationSelection item.
            /// </summary>
            [RepositoryItem("31531f54-6f65-4cd9-a64b-1913f58ee3f8")]
            public virtual Ranorex.ATag SubClassificationSelection
            {
                get
                {
                    return _subclassificationselectionInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The SubClassificationSelection item info.
            /// </summary>
            [RepositoryItemInfo("31531f54-6f65-4cd9-a64b-1913f58ee3f8")]
            public virtual RepoItemInfo SubClassificationSelectionInfo
            {
                get
                {
                    return _subclassificationselectionInfo;
                }
            }

            /// <summary>
            /// The AddCriteria item.
            /// </summary>
            [RepositoryItem("78040042-89a2-4408-bfbc-17121ae285ab")]
            public virtual Ranorex.ATag AddCriteria
            {
                get
                {
                    return _addcriteriaInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AddCriteria item info.
            /// </summary>
            [RepositoryItemInfo("78040042-89a2-4408-bfbc-17121ae285ab")]
            public virtual RepoItemInfo AddCriteriaInfo
            {
                get
                {
                    return _addcriteriaInfo;
                }
            }

            /// <summary>
            /// The Button item.
            /// </summary>
            [RepositoryItem("6a9ed6dc-7cf2-4b8a-87e3-a7dc50006ab0")]
            public virtual Ranorex.InputTag Button
            {
                get
                {
                    return _buttonInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Button item info.
            /// </summary>
            [RepositoryItemInfo("6a9ed6dc-7cf2-4b8a-87e3-a7dc50006ab0")]
            public virtual RepoItemInfo ButtonInfo
            {
                get
                {
                    return _buttonInfo;
                }
            }

            /// <summary>
            /// The Button1 item.
            /// </summary>
            [RepositoryItem("f94559b0-27bf-45b6-9c2e-67d859765bd0")]
            public virtual Ranorex.InputTag Button1
            {
                get
                {
                    return _button1Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Button1 item info.
            /// </summary>
            [RepositoryItemInfo("f94559b0-27bf-45b6-9c2e-67d859765bd0")]
            public virtual RepoItemInfo Button1Info
            {
                get
                {
                    return _button1Info;
                }
            }

            /// <summary>
            /// The AttachNamedCriteria item.
            /// </summary>
            [RepositoryItem("d7784f1e-51e1-42d4-b5d4-45556b9ccf33")]
            public virtual Ranorex.ATag AttachNamedCriteria
            {
                get
                {
                    return _attachnamedcriteriaInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AttachNamedCriteria item info.
            /// </summary>
            [RepositoryItemInfo("d7784f1e-51e1-42d4-b5d4-45556b9ccf33")]
            public virtual RepoItemInfo AttachNamedCriteriaInfo
            {
                get
                {
                    return _attachnamedcriteriaInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("2f407228-71ca-4efc-81b3-fc8ba6ab41dd")]
            public virtual Ranorex.ATag Close
            {
                get
                {
                    return _closeInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Close item info.
            /// </summary>
            [RepositoryItemInfo("2f407228-71ca-4efc-81b3-fc8ba6ab41dd")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }

            /// <summary>
            /// The DivTagAddEXCLUDECriteria item.
            /// </summary>
            [RepositoryItem("8e2cc944-fdc7-47de-abd9-248f7e8b14c4")]
            public virtual Ranorex.DivTag DivTagAddEXCLUDECriteria
            {
                get
                {
                    return _divtagaddexcludecriteriaInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagAddEXCLUDECriteria item info.
            /// </summary>
            [RepositoryItemInfo("8e2cc944-fdc7-47de-abd9-248f7e8b14c4")]
            public virtual RepoItemInfo DivTagAddEXCLUDECriteriaInfo
            {
                get
                {
                    return _divtagaddexcludecriteriaInfo;
                }
            }

            /// <summary>
            /// The AddCriteria1 item.
            /// </summary>
            [RepositoryItem("7767cf83-0ac9-4bc9-af82-58d1d8359889")]
            public virtual Ranorex.ATag AddCriteria1
            {
                get
                {
                    return _addcriteria1Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The AddCriteria1 item info.
            /// </summary>
            [RepositoryItemInfo("7767cf83-0ac9-4bc9-af82-58d1d8359889")]
            public virtual RepoItemInfo AddCriteria1Info
            {
                get
                {
                    return _addcriteria1Info;
                }
            }

            /// <summary>
            /// The Button2 item.
            /// </summary>
            [RepositoryItem("fa21f38c-07df-4934-ac4e-f9b05001d058")]
            public virtual Ranorex.InputTag Button2
            {
                get
                {
                    return _button2Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Button2 item info.
            /// </summary>
            [RepositoryItemInfo("fa21f38c-07df-4934-ac4e-f9b05001d058")]
            public virtual RepoItemInfo Button2Info
            {
                get
                {
                    return _button2Info;
                }
            }

            /// <summary>
            /// The Button3 item.
            /// </summary>
            [RepositoryItem("e506fd3e-f6c8-4b52-810f-73ed67759631")]
            public virtual Ranorex.InputTag Button3
            {
                get
                {
                    return _button3Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Button3 item info.
            /// </summary>
            [RepositoryItemInfo("e506fd3e-f6c8-4b52-810f-73ed67759631")]
            public virtual RepoItemInfo Button3Info
            {
                get
                {
                    return _button3Info;
                }
            }
        }

        /// <summary>
        /// The DropdownAppFolder folder.
        /// </summary>
        [RepositoryFolder("1eaae59b-427a-476d-ad5d-64c6ca22be28")]
        public partial class DropdownAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dropdown  folder.
            /// </summary>
            public DropdownAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dropdown", "/container[@caption='dropdown']", parentFolder, 30000, null, true, "1eaae59b-427a-476d-ad5d-64c6ca22be28", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1eaae59b-427a-476d-ad5d-64c6ca22be28")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1eaae59b-427a-476d-ad5d-64c6ca22be28")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}