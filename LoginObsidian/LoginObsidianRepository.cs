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

namespace LoginObsidian
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the LoginObsidianRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f69fcabe-3d3c-49d1-94d5-8e10d5614587")]
    public partial class LoginObsidianRepository : RepoGenBaseFolder
    {
        static LoginObsidianRepository instance = new LoginObsidianRepository();
        LoginObsidianRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        LoginObsidianRepositoryFolders.DropdownAppFolder _dropdown;
        LoginObsidianRepositoryFolders.ObsidianStagingCondeIoUsersPasswordAppFolder _obsidianstagingcondeiouserspassword;

        /// <summary>
        /// Gets the singleton class instance representing the LoginObsidianRepository element repository.
        /// </summary>
        [RepositoryFolder("f69fcabe-3d3c-49d1-94d5-8e10d5614587")]
        public static LoginObsidianRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public LoginObsidianRepository() 
            : base("LoginObsidianRepository", "/", null, 0, false, "f69fcabe-3d3c-49d1-94d5-8e10d5614587", ".\\RepositoryImages\\LoginObsidianRepositoryf69fcabe.rximgres")
        {
            _applicationundertest = new LoginObsidianRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _dropdown = new LoginObsidianRepositoryFolders.DropdownAppFolder(this);
            _obsidianstagingcondeiouserspassword = new LoginObsidianRepositoryFolders.ObsidianStagingCondeIoUsersPasswordAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f69fcabe-3d3c-49d1-94d5-8e10d5614587")]
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
        [RepositoryFolder("c9aeb153-65fc-4e2b-acf6-9fda92dce74d")]
        public virtual LoginObsidianRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The Dropdown folder.
        /// </summary>
        [RepositoryFolder("9cd2ab7c-8f01-4bac-8e55-41ccfe9ee10a")]
        public virtual LoginObsidianRepositoryFolders.DropdownAppFolder Dropdown
        {
            get { return _dropdown; }
        }

        /// <summary>
        /// The ObsidianStagingCondeIoUsersPassword folder.
        /// </summary>
        [RepositoryFolder("d1507476-514d-43de-9f0f-d07382ef1577")]
        public virtual LoginObsidianRepositoryFolders.ObsidianStagingCondeIoUsersPasswordAppFolder ObsidianStagingCondeIoUsersPassword
        {
            get { return _obsidianstagingcondeiouserspassword; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class LoginObsidianRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("c9aeb153-65fc-4e2b-acf6-9fda92dce74d")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            LoginObsidianRepositoryFolders.ContainerFolder _container;
            RepoItemInfo _useremailInfo;
            RepoItemInfo _userpasswordInfo;
            RepoItemInfo _resetpasswordlinkInfo;
            RepoItemInfo _contextstudioInfo;
            RepoItemInfo _buttonInfo;
            RepoItemInfo _closeInfo;
            RepoItemInfo _contextdescriptionInfo;
            RepoItemInfo _ataglogoutInfo;
            RepoItemInfo _logoutInfo;
            RepoItemInfo _forgotpasswordInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='obsidian-staging.conde.io']", parentFolder, 30000, null, false, "c9aeb153-65fc-4e2b-acf6-9fda92dce74d", "")
            {
                _container = new LoginObsidianRepositoryFolders.ContainerFolder(this);
                _useremailInfo = new RepoItemInfo(this, "UserEmail", ".//input[#'user_email']", 30000, null, "30aa3156-89d7-45ef-ba92-3c6e65088364");
                _userpasswordInfo = new RepoItemInfo(this, "UserPassword", ".//input[#'user_password']", 30000, null, "948265b4-e204-4bbd-8b29-1ed57d84763f");
                _resetpasswordlinkInfo = new RepoItemInfo(this, "ResetPasswordLink", ".//form[#'new_user']/?/?/input[@name='commit']", 30000, null, "5577d352-3b43-4eb3-b9d5-301da7285601");
                _contextstudioInfo = new RepoItemInfo(this, "ContextStudio", ".//h1[#'site_title']/a[@innertext='Context Studio']", 30000, null, "78a43905-d300-4f9b-8d7d-80f72604b884");
                _buttonInfo = new RepoItemInfo(this, "Button", "body/div[1]/div/div/div/div[2]/input[@type='button']", 30000, null, "502d2d8a-929e-4b6c-9bcc-fbee4c8bc39d");
                _closeInfo = new RepoItemInfo(this, "Close", "body/div[1]/div/div/div/div[2]/?/?/a[@innertext='Close']", 30000, null, "776b90fa-9729-4a76-8981-7638881ef85f");
                _contextdescriptionInfo = new RepoItemInfo(this, "ContextDescription", ".//input[#'context-description']", 30000, null, "83c8e62e-c090-4b2a-8252-f40bde12fbf3");
                _ataglogoutInfo = new RepoItemInfo(this, "ATagLogout", ".//div[#'myDropdown']/a[@innertext='  Logout']", 30000, null, "d1384c83-1531-44fb-8dad-d765ddce06ee");
                _logoutInfo = new RepoItemInfo(this, "Logout", ".//li[#'logout']/a[@innertext='Logout']", 30000, null, "41fa2a06-0c4d-4d7a-a523-18c729719e2b");
                _forgotpasswordInfo = new RepoItemInfo(this, "ForgotPassword", ".//form[#'new_user']/a[@innertext='Forgot password?']", 30000, null, "0077fdda-d6b3-48ce-a66d-9781c39898ab");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c9aeb153-65fc-4e2b-acf6-9fda92dce74d")]
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
            [RepositoryItemInfo("c9aeb153-65fc-4e2b-acf6-9fda92dce74d")]
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
            [RepositoryItem("30aa3156-89d7-45ef-ba92-3c6e65088364")]
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
            [RepositoryItemInfo("30aa3156-89d7-45ef-ba92-3c6e65088364")]
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
            [RepositoryItem("948265b4-e204-4bbd-8b29-1ed57d84763f")]
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
            [RepositoryItemInfo("948265b4-e204-4bbd-8b29-1ed57d84763f")]
            public virtual RepoItemInfo UserPasswordInfo
            {
                get
                {
                    return _userpasswordInfo;
                }
            }

            /// <summary>
            /// The ResetPasswordLink item.
            /// </summary>
            [RepositoryItem("5577d352-3b43-4eb3-b9d5-301da7285601")]
            public virtual Ranorex.InputTag ResetPasswordLink
            {
                get
                {
                    return _resetpasswordlinkInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The ResetPasswordLink item info.
            /// </summary>
            [RepositoryItemInfo("5577d352-3b43-4eb3-b9d5-301da7285601")]
            public virtual RepoItemInfo ResetPasswordLinkInfo
            {
                get
                {
                    return _resetpasswordlinkInfo;
                }
            }

            /// <summary>
            /// The ContextStudio item.
            /// </summary>
            [RepositoryItem("78a43905-d300-4f9b-8d7d-80f72604b884")]
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
            [RepositoryItemInfo("78a43905-d300-4f9b-8d7d-80f72604b884")]
            public virtual RepoItemInfo ContextStudioInfo
            {
                get
                {
                    return _contextstudioInfo;
                }
            }

            /// <summary>
            /// The Button item.
            /// </summary>
            [RepositoryItem("502d2d8a-929e-4b6c-9bcc-fbee4c8bc39d")]
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
            [RepositoryItemInfo("502d2d8a-929e-4b6c-9bcc-fbee4c8bc39d")]
            public virtual RepoItemInfo ButtonInfo
            {
                get
                {
                    return _buttonInfo;
                }
            }

            /// <summary>
            /// The Close item.
            /// </summary>
            [RepositoryItem("776b90fa-9729-4a76-8981-7638881ef85f")]
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
            [RepositoryItemInfo("776b90fa-9729-4a76-8981-7638881ef85f")]
            public virtual RepoItemInfo CloseInfo
            {
                get
                {
                    return _closeInfo;
                }
            }

            /// <summary>
            /// The ContextDescription item.
            /// </summary>
            [RepositoryItem("83c8e62e-c090-4b2a-8252-f40bde12fbf3")]
            public virtual Ranorex.InputTag ContextDescription
            {
                get
                {
                    return _contextdescriptionInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The ContextDescription item info.
            /// </summary>
            [RepositoryItemInfo("83c8e62e-c090-4b2a-8252-f40bde12fbf3")]
            public virtual RepoItemInfo ContextDescriptionInfo
            {
                get
                {
                    return _contextdescriptionInfo;
                }
            }

            /// <summary>
            /// The ATagLogout item.
            /// </summary>
            [RepositoryItem("d1384c83-1531-44fb-8dad-d765ddce06ee")]
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
            [RepositoryItemInfo("d1384c83-1531-44fb-8dad-d765ddce06ee")]
            public virtual RepoItemInfo ATagLogoutInfo
            {
                get
                {
                    return _ataglogoutInfo;
                }
            }

            /// <summary>
            /// The Logout item.
            /// </summary>
            [RepositoryItem("41fa2a06-0c4d-4d7a-a523-18c729719e2b")]
            public virtual Ranorex.ATag Logout
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Logout item info.
            /// </summary>
            [RepositoryItemInfo("41fa2a06-0c4d-4d7a-a523-18c729719e2b")]
            public virtual RepoItemInfo LogoutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }

            /// <summary>
            /// The ForgotPassword item.
            /// </summary>
            [RepositoryItem("0077fdda-d6b3-48ce-a66d-9781c39898ab")]
            public virtual Ranorex.ATag ForgotPassword
            {
                get
                {
                    return _forgotpasswordInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ForgotPassword item info.
            /// </summary>
            [RepositoryItemInfo("0077fdda-d6b3-48ce-a66d-9781c39898ab")]
            public virtual RepoItemInfo ForgotPasswordInfo
            {
                get
                {
                    return _forgotpasswordInfo;
                }
            }

            /// <summary>
            /// The Container folder.
            /// </summary>
            [RepositoryFolder("9c190b5e-4c7b-44ef-9b59-819c571fd66e")]
            public virtual LoginObsidianRepositoryFolders.ContainerFolder Container
            {
                get { return _container; }
            }
        }

        /// <summary>
        /// The ContainerFolder folder.
        /// </summary>
        [RepositoryFolder("9c190b5e-4c7b-44ef-9b59-819c571fd66e")]
        public partial class ContainerFolder : RepoGenBaseFolder
        {
            RepoItemInfo _usermenuInfo;
            RepoItemInfo _classificationselectInfo;
            RepoItemInfo _searchcontextInfo;
            RepoItemInfo _searchfieldInfo;
            RepoItemInfo _classificationsInfo;
            RepoItemInfo _subclassificationsInfo;
            RepoItemInfo _subclassificationsselectInfo;
            RepoItemInfo _clearfilterInfo;
            RepoItemInfo _contextcodeInfo;
            RepoItemInfo _contextnameInfo;
            RepoItemInfo _editcontextInfo;
            RepoItemInfo _showcontextInfo;
            RepoItemInfo _googleInfo;
            RepoItemInfo _priyankarameshInfo;

            /// <summary>
            /// Creates a new Container  folder.
            /// </summary>
            public ContainerFolder(RepoGenBaseFolder parentFolder) :
                    base("Container", "body/div", parentFolder, 30000, null, false, "9c190b5e-4c7b-44ef-9b59-819c571fd66e", "")
            {
                _usermenuInfo = new RepoItemInfo(this, "UserMenu", "div[1]//button[@innertext='Admin User ']", 30000, null, "d406bc9c-f621-4b9c-bd81-e8343b0c7933");
                _classificationselectInfo = new RepoItemInfo(this, "ClassificationSelect", "div[2]/div[1]/div/div[1]/?/?/ul/li[2]/a[@innertext='Automotive']", 30000, null, "8322d83b-13be-4bad-8f6f-15c89ea943bc");
                _searchcontextInfo = new RepoItemInfo(this, "SearchContext", "div[2]/div[1]/div/div[1]/div[1]/?/?/i", 30000, null, "6d2062ba-9272-4fe8-9621-e037a9175f9c");
                _searchfieldInfo = new RepoItemInfo(this, "SearchField", "div[2]/div[1]/div/div[1]/div[1]/?/?/input[@name='search']", 30000, null, "d6f8d75e-8556-4b0f-b321-dba5bd213ce1");
                _classificationsInfo = new RepoItemInfo(this, "Classifications", "div[2]/div[1]/div/div[1]/div[2]/buttontag[@class='button-link dropdown-toggle drop-down-title btn btn float-right classification filt']", 30000, null, "d4072f08-56f9-4c29-bae0-c10dd79aa521");
                _subclassificationsInfo = new RepoItemInfo(this, "SubClassifications", "div[2]/div[1]/div/div[1]/div[3]/button[@innertext='Sub-Classifications ']", 30000, null, "b000ec6a-f913-4c7e-868f-0a518a731774");
                _subclassificationsselectInfo = new RepoItemInfo(this, "SubClassificationsSelect", "div[2]/div[1]/div/div[1]/div[3]/ul/li[1]/a[@innertext='Auto Body Styles']", 30000, null, "91a8ffa8-7fdc-45bc-a353-ccd0dfc69903");
                _clearfilterInfo = new RepoItemInfo(this, "ClearFilter", "div[2]/div[1]/div/div[3]/?/?/a[@innertext='Clear Filter']", 30000, null, "15ff1ce7-f18c-402f-8cf4-13a798bc55cb");
                _contextcodeInfo = new RepoItemInfo(this, "ContextCode", "div[2]/div[2]/?/?/table/tbody/tr[1]/td[1]/?/?/a", 30000, null, "475fc72c-b780-4813-8bed-790a0bca5716");
                _contextnameInfo = new RepoItemInfo(this, "ContextName", "div[2]/div[2]/?/?/table/tbody/tr[1]/td[2]/?/?/div/span[1]/a", 30000, null, "2ad33d06-80af-4e38-97cb-44764366e77d");
                _editcontextInfo = new RepoItemInfo(this, "EditContext", "div[2]/div[2]/?/?/table/tbody/tr[1]/td[6]//a[@innertext='Edit']", 30000, null, "f2215fe1-521c-4985-9b80-ada8c5f27d99");
                _showcontextInfo = new RepoItemInfo(this, "ShowContext", "div[2]/div[2]/?/?/table/tbody/tr[1]/td[6]//a[@innertext='Show']", 30000, null, "0d542a7f-c0a3-4b53-93a7-aa4a0372889e");
                _googleInfo = new RepoItemInfo(this, "Google", "div/div/div[2]/div[2]/a[@href>'http://obsidian-staging.c']/?/?/b[@innertext='Google']", 30000, null, "35b61803-94e1-4e08-9037-727cab320ec2");
                _priyankarameshInfo = new RepoItemInfo(this, "PriyankaRamesh", ".//button[@innertext='Priyanka Ramesh ']", 30000, null, "d7a23546-0eda-4bc4-b0cd-098259398187");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9c190b5e-4c7b-44ef-9b59-819c571fd66e")]
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
            [RepositoryItemInfo("9c190b5e-4c7b-44ef-9b59-819c571fd66e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The UserMenu item.
            /// </summary>
            [RepositoryItem("d406bc9c-f621-4b9c-bd81-e8343b0c7933")]
            public virtual Ranorex.ButtonTag UserMenu
            {
                get
                {
                    return _usermenuInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The UserMenu item info.
            /// </summary>
            [RepositoryItemInfo("d406bc9c-f621-4b9c-bd81-e8343b0c7933")]
            public virtual RepoItemInfo UserMenuInfo
            {
                get
                {
                    return _usermenuInfo;
                }
            }

            /// <summary>
            /// The ClassificationSelect item.
            /// </summary>
            [RepositoryItem("8322d83b-13be-4bad-8f6f-15c89ea943bc")]
            public virtual Ranorex.ATag ClassificationSelect
            {
                get
                {
                    return _classificationselectInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ClassificationSelect item info.
            /// </summary>
            [RepositoryItemInfo("8322d83b-13be-4bad-8f6f-15c89ea943bc")]
            public virtual RepoItemInfo ClassificationSelectInfo
            {
                get
                {
                    return _classificationselectInfo;
                }
            }

            /// <summary>
            /// The SearchContext item.
            /// </summary>
            [RepositoryItem("6d2062ba-9272-4fe8-9621-e037a9175f9c")]
            public virtual Ranorex.ITag SearchContext
            {
                get
                {
                    return _searchcontextInfo.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The SearchContext item info.
            /// </summary>
            [RepositoryItemInfo("6d2062ba-9272-4fe8-9621-e037a9175f9c")]
            public virtual RepoItemInfo SearchContextInfo
            {
                get
                {
                    return _searchcontextInfo;
                }
            }

            /// <summary>
            /// The SearchField item.
            /// </summary>
            [RepositoryItem("d6f8d75e-8556-4b0f-b321-dba5bd213ce1")]
            public virtual Ranorex.InputTag SearchField
            {
                get
                {
                    return _searchfieldInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The SearchField item info.
            /// </summary>
            [RepositoryItemInfo("d6f8d75e-8556-4b0f-b321-dba5bd213ce1")]
            public virtual RepoItemInfo SearchFieldInfo
            {
                get
                {
                    return _searchfieldInfo;
                }
            }

            /// <summary>
            /// The Classifications item.
            /// </summary>
            [RepositoryItem("d4072f08-56f9-4c29-bae0-c10dd79aa521")]
            public virtual Ranorex.ButtonTag Classifications
            {
                get
                {
                    return _classificationsInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The Classifications item info.
            /// </summary>
            [RepositoryItemInfo("d4072f08-56f9-4c29-bae0-c10dd79aa521")]
            public virtual RepoItemInfo ClassificationsInfo
            {
                get
                {
                    return _classificationsInfo;
                }
            }

            /// <summary>
            /// The SubClassifications item.
            /// </summary>
            [RepositoryItem("b000ec6a-f913-4c7e-868f-0a518a731774")]
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
            [RepositoryItemInfo("b000ec6a-f913-4c7e-868f-0a518a731774")]
            public virtual RepoItemInfo SubClassificationsInfo
            {
                get
                {
                    return _subclassificationsInfo;
                }
            }

            /// <summary>
            /// The SubClassificationsSelect item.
            /// </summary>
            [RepositoryItem("91a8ffa8-7fdc-45bc-a353-ccd0dfc69903")]
            public virtual Ranorex.ATag SubClassificationsSelect
            {
                get
                {
                    return _subclassificationsselectInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The SubClassificationsSelect item info.
            /// </summary>
            [RepositoryItemInfo("91a8ffa8-7fdc-45bc-a353-ccd0dfc69903")]
            public virtual RepoItemInfo SubClassificationsSelectInfo
            {
                get
                {
                    return _subclassificationsselectInfo;
                }
            }

            /// <summary>
            /// The ClearFilter item.
            /// </summary>
            [RepositoryItem("15ff1ce7-f18c-402f-8cf4-13a798bc55cb")]
            public virtual Ranorex.ATag ClearFilter
            {
                get
                {
                    return _clearfilterInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ClearFilter item info.
            /// </summary>
            [RepositoryItemInfo("15ff1ce7-f18c-402f-8cf4-13a798bc55cb")]
            public virtual RepoItemInfo ClearFilterInfo
            {
                get
                {
                    return _clearfilterInfo;
                }
            }

            /// <summary>
            /// The ContextCode item.
            /// </summary>
            [RepositoryItem("475fc72c-b780-4813-8bed-790a0bca5716")]
            public virtual Ranorex.ATag ContextCode
            {
                get
                {
                    return _contextcodeInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ContextCode item info.
            /// </summary>
            [RepositoryItemInfo("475fc72c-b780-4813-8bed-790a0bca5716")]
            public virtual RepoItemInfo ContextCodeInfo
            {
                get
                {
                    return _contextcodeInfo;
                }
            }

            /// <summary>
            /// The ContextName item.
            /// </summary>
            [RepositoryItem("2ad33d06-80af-4e38-97cb-44764366e77d")]
            public virtual Ranorex.ATag ContextName
            {
                get
                {
                    return _contextnameInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ContextName item info.
            /// </summary>
            [RepositoryItemInfo("2ad33d06-80af-4e38-97cb-44764366e77d")]
            public virtual RepoItemInfo ContextNameInfo
            {
                get
                {
                    return _contextnameInfo;
                }
            }

            /// <summary>
            /// The EditContext item.
            /// </summary>
            [RepositoryItem("f2215fe1-521c-4985-9b80-ada8c5f27d99")]
            public virtual Ranorex.ATag EditContext
            {
                get
                {
                    return _editcontextInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The EditContext item info.
            /// </summary>
            [RepositoryItemInfo("f2215fe1-521c-4985-9b80-ada8c5f27d99")]
            public virtual RepoItemInfo EditContextInfo
            {
                get
                {
                    return _editcontextInfo;
                }
            }

            /// <summary>
            /// The ShowContext item.
            /// </summary>
            [RepositoryItem("0d542a7f-c0a3-4b53-93a7-aa4a0372889e")]
            public virtual Ranorex.ATag ShowContext
            {
                get
                {
                    return _showcontextInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The ShowContext item info.
            /// </summary>
            [RepositoryItemInfo("0d542a7f-c0a3-4b53-93a7-aa4a0372889e")]
            public virtual RepoItemInfo ShowContextInfo
            {
                get
                {
                    return _showcontextInfo;
                }
            }

            /// <summary>
            /// The Google item.
            /// </summary>
            [RepositoryItem("35b61803-94e1-4e08-9037-727cab320ec2")]
            public virtual Ranorex.BTag Google
            {
                get
                {
                    return _googleInfo.CreateAdapter<Ranorex.BTag>(true);
                }
            }

            /// <summary>
            /// The Google item info.
            /// </summary>
            [RepositoryItemInfo("35b61803-94e1-4e08-9037-727cab320ec2")]
            public virtual RepoItemInfo GoogleInfo
            {
                get
                {
                    return _googleInfo;
                }
            }

            /// <summary>
            /// The PriyankaRamesh item.
            /// </summary>
            [RepositoryItem("d7a23546-0eda-4bc4-b0cd-098259398187")]
            public virtual Ranorex.ButtonTag PriyankaRamesh
            {
                get
                {
                    return _priyankarameshInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The PriyankaRamesh item info.
            /// </summary>
            [RepositoryItemInfo("d7a23546-0eda-4bc4-b0cd-098259398187")]
            public virtual RepoItemInfo PriyankaRameshInfo
            {
                get
                {
                    return _priyankarameshInfo;
                }
            }
        }

        /// <summary>
        /// The DropdownAppFolder folder.
        /// </summary>
        [RepositoryFolder("9cd2ab7c-8f01-4bac-8e55-41ccfe9ee10a")]
        public partial class DropdownAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Dropdown  folder.
            /// </summary>
            public DropdownAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Dropdown", "/container[@caption='dropdown']", parentFolder, 30000, null, true, "9cd2ab7c-8f01-4bac-8e55-41ccfe9ee10a", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9cd2ab7c-8f01-4bac-8e55-41ccfe9ee10a")]
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
            [RepositoryItemInfo("9cd2ab7c-8f01-4bac-8e55-41ccfe9ee10a")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The ObsidianStagingCondeIoUsersPasswordAppFolder folder.
        /// </summary>
        [RepositoryFolder("d1507476-514d-43de-9f0f-d07382ef1577")]
        public partial class ObsidianStagingCondeIoUsersPasswordAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _backInfo;

            /// <summary>
            /// Creates a new ObsidianStagingCondeIoUsersPassword  folder.
            /// </summary>
            public ObsidianStagingCondeIoUsersPasswordAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ObsidianStagingCondeIoUsersPassword", "/form[@title>'obsidian-staging.conde.io/users/password']", parentFolder, 30000, null, true, "d1507476-514d-43de-9f0f-d07382ef1577", "")
            {
                _backInfo = new RepoItemInfo(this, "Back", "container[@accessiblename>'obsidian-staging.conde.io/users/password']/container[@accessiblename='Google Chrome']//button[@accessiblename='Back']", 30000, null, "9b7e0dd9-a3c0-4dda-9e02-ca367df97268");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d1507476-514d-43de-9f0f-d07382ef1577")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d1507476-514d-43de-9f0f-d07382ef1577")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Back item.
            /// </summary>
            [RepositoryItem("9b7e0dd9-a3c0-4dda-9e02-ca367df97268")]
            public virtual Ranorex.Button Back
            {
                get
                {
                    return _backInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The Back item info.
            /// </summary>
            [RepositoryItemInfo("9b7e0dd9-a3c0-4dda-9e02-ca367df97268")]
            public virtual RepoItemInfo BackInfo
            {
                get
                {
                    return _backInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
