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

namespace Example_One
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Example_OneRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("fb517513-597f-46f9-9003-8ae1823bf021")]
    public partial class Example_OneRepository : RepoGenBaseFolder
    {
        static Example_OneRepository instance = new Example_OneRepository();
        Example_OneRepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the Example_OneRepository element repository.
        /// </summary>
        [RepositoryFolder("fb517513-597f-46f9-9003-8ae1823bf021")]
        public static Example_OneRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Example_OneRepository() 
            : base("Example_OneRepository", "/", null, 0, false, "fb517513-597f-46f9-9003-8ae1823bf021", ".\\RepositoryImages\\Example_OneRepositoryfb517513.rximgres")
        {
            _rxmainframe = new Example_OneRepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("fb517513-597f-46f9-9003-8ae1823bf021")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("c5000240-b28d-4461-abcd-9c8635a4e0c5")]
        public virtual Example_OneRepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class Example_OneRepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("c5000240-b28d-4461-abcd-9c8635a4e0c5")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            Example_OneRepositoryFolders.RxTabIntroductionFolder _rxtabintroduction;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@title~'^Ranorex\\ Studio\\ Demo\\ Appli' and @processname='RxDemoApp' and @controltypename='RxMainFrame' and @instance='0']", parentFolder, 30000, null, true, "c5000240-b28d-4461-abcd-9c8635a4e0c5", "")
            {
                _rxtabintroduction = new Example_OneRepositoryFolders.RxTabIntroductionFolder(this);
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c5000240-b28d-4461-abcd-9c8635a4e0c5")]
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
            [RepositoryItemInfo("c5000240-b28d-4461-abcd-9c8635a4e0c5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RxTabIntroduction folder.
            /// </summary>
            [RepositoryFolder("d73b8a5e-788d-49c1-a5a9-c7960d3312db")]
            public virtual Example_OneRepositoryFolders.RxTabIntroductionFolder RxTabIntroduction
            {
                get { return _rxtabintroduction; }
            }
        }

        /// <summary>
        /// The RxTabIntroductionFolder folder.
        /// </summary>
        [RepositoryFolder("d73b8a5e-788d-49c1-a5a9-c7960d3312db")]
        public partial class RxTabIntroductionFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _lblwelcomemessageInfo;

            /// <summary>
            /// Creates a new RxTabIntroduction  folder.
            /// </summary>
            public RxTabIntroductionFolder(RepoGenBaseFolder parentFolder) :
                    base("RxTabIntroduction", "?/?/tabpage[@controlname='RxTabIntroduction']", parentFolder, 30000, null, false, "d73b8a5e-788d-49c1-a5a9-c7960d3312db", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/text[@accessiblename='Enter your name']", 30000, null, "844e60ed-d40e-4a0e-a687-1feee1e5bbc3");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "button[@controlname='btnSubmitUserName']", 30000, null, "093be186-c9b5-4b42-be0e-78dc58c44037");
                _lblwelcomemessageInfo = new RepoItemInfo(this, "LblWelcomeMessage", "text[@controlname='lblWelcomeMessage']", 30000, null, "a3fe2df0-f021-4343-8d7f-5b469df9bde4");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d73b8a5e-788d-49c1-a5a9-c7960d3312db")]
            public virtual Ranorex.TabPage Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.TabPage>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d73b8a5e-788d-49c1-a5a9-c7960d3312db")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("844e60ed-d40e-4a0e-a687-1feee1e5bbc3")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("844e60ed-d40e-4a0e-a687-1feee1e5bbc3")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("093be186-c9b5-4b42-be0e-78dc58c44037")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("093be186-c9b5-4b42-be0e-78dc58c44037")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item.
            /// </summary>
            [RepositoryItem("a3fe2df0-f021-4343-8d7f-5b469df9bde4")]
            public virtual Ranorex.Text LblWelcomeMessage
            {
                get
                {
                    return _lblwelcomemessageInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The LblWelcomeMessage item info.
            /// </summary>
            [RepositoryItemInfo("a3fe2df0-f021-4343-8d7f-5b469df9bde4")]
            public virtual RepoItemInfo LblWelcomeMessageInfo
            {
                get
                {
                    return _lblwelcomemessageInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}