﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestProject2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            HtmlHyperlink uIDriveHyperlink = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIDriveHyperlink;
            BrowserWindow uIGoogleWindowsInterneWindow = this.UIGoogleWindowsInterneWindow;
            HtmlCell uIGs_tti0Cell = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIGs_tti0Cell;
            HtmlEdit uIQEdit = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIQEdit;
            HtmlDiv uIItemPane = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIAustraliaMakeGooglemPane.UIItemPane;
            HtmlDiv uIAustraliaPane1 = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIAustraliaPane.UIAustraliaPane1;
            HtmlButton uIBtnGButton = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIBtnGButton;
            HtmlSpan uIItemPane1 = this.UIGoogleWindowsInterneWindow.UIGoogleDocument.UIBtnGButton.UIItemPane;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Drive' link at (24, 12)
            Mouse.Hover(uIDriveHyperlink, new Point(24, 12));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Go to web page 'http://www.google.com/'
            uIGoogleWindowsInterneWindow.NavigateToUrl(new System.Uri(this.RecordedMethod1Params.UIGoogleWindowsInterneWindowUrl));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'gs_tti0' cell at (268, 3)
            Mouse.Hover(uIGs_tti0Cell, new Point(268, 3));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Type 'A' in 'q' text box
            uIQEdit.Text = this.RecordedMethod1Params.UIQEditText;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Unknown Name' pane at (607, 44)
            Mouse.Hover(uIItemPane, new Point(607, 44));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Type 'Ajith m Jose' in 'q' text box
            uIQEdit.Text = this.RecordedMethod1Params.UIQEditText1;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'Australia' pane at (738, 126)
            Mouse.Hover(uIAustraliaPane1, new Point(738, 126));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'btnG' button
            Mouse.Click(uIBtnGButton, new Point(34, 1));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'btnG' button at (34, 3)
            Mouse.Hover(uIBtnGButton, new Point(34, 3));

            // Mouse hover 'Unknown Name' pane at (4, 4)
            Mouse.Hover(uIItemPane1, new Point(4, 4));

            // Mouse hover 'btnG' button at (26, 2)
            Mouse.Hover(uIBtnGButton, new Point(26, 2));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Unknown Name' pane
            Mouse.Click(uIItemPane1, new Point(4, 0));
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public UIGoogleWindowsInterneWindow UIGoogleWindowsInterneWindow
        {
            get
            {
                if ((this.mUIGoogleWindowsInterneWindow == null))
                {
                    this.mUIGoogleWindowsInterneWindow = new UIGoogleWindowsInterneWindow();
                }
                return this.mUIGoogleWindowsInterneWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIGoogleWindowsInterneWindow mUIGoogleWindowsInterneWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://www.google.com/'
        /// </summary>
        public string UIGoogleWindowsInterneWindowUrl = "http://www.google.com/";
        
        /// <summary>
        /// Type 'A' in 'q' text box
        /// </summary>
        public string UIQEditText = "A";
        
        /// <summary>
        /// Type 'Ajith m Jose' in 'q' text box
        /// </summary>
        public string UIQEditText1 = "Ajith m Jose";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIGoogleWindowsInterneWindow : BrowserWindow
    {
        
        public UIGoogleWindowsInterneWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "Google";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("Google");
            this.WindowTitles.Add("ajith m jose - Google Search");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIGoogleDocument UIGoogleDocument
        {
            get
            {
                if ((this.mUIGoogleDocument == null))
                {
                    this.mUIGoogleDocument = new UIGoogleDocument(this);
                }
                return this.mUIGoogleDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIGoogleDocument mUIGoogleDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIGoogleDocument : HtmlDocument
    {
        
        public UIGoogleDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "gsr";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Google";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://www.google.com.au/";
            this.WindowTitles.Add("Google");
            this.WindowTitles.Add("ajith m jose - Google Search");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIDriveHyperlink
        {
            get
            {
                if ((this.mUIDriveHyperlink == null))
                {
                    this.mUIDriveHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIDriveHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "gb_25";
                    this.mUIDriveHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIDriveHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIDriveHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Drive";
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/";
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://drive.google.com/?tab=wo";
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "gbzt";
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=gb_25 class=gbzt onclick=gbar.logger.";
                    this.mUIDriveHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "11";
                    this.mUIDriveHyperlink.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIDriveHyperlink;
            }
        }
        
        public HtmlCell UIGs_tti0Cell
        {
            get
            {
                if ((this.mUIGs_tti0Cell == null))
                {
                    this.mUIGs_tti0Cell = new HtmlCell(this);
                    #region Search Criteria
                    this.mUIGs_tti0Cell.SearchProperties[HtmlCell.PropertyNames.Id] = "gs_tti0";
                    this.mUIGs_tti0Cell.SearchProperties[HtmlCell.PropertyNames.Name] = null;
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.InnerText] = null;
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.ControlDefinition] = "id=gs_tti0 class=gsib_a";
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.RowIndex] = "0";
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.ColumnIndex] = "1";
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.Class] = "gsib_a";
                    this.mUIGs_tti0Cell.FilterProperties[HtmlCell.PropertyNames.TagInstance] = "3";
                    this.mUIGs_tti0Cell.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIGs_tti0Cell;
            }
        }
        
        public HtmlEdit UIQEdit
        {
            get
            {
                if ((this.mUIQEdit == null))
                {
                    this.mUIQEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIQEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "gbqfq";
                    this.mUIQEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "q";
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "gbqfif";
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "style=\"Z-INDEX: 6; BORDER-BOTTOM: medium";
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "4";
                    this.mUIQEdit.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIQEdit;
            }
        }
        
        public UIAustraliaMakeGooglemPane UIAustraliaMakeGooglemPane
        {
            get
            {
                if ((this.mUIAustraliaMakeGooglemPane == null))
                {
                    this.mUIAustraliaMakeGooglemPane = new UIAustraliaMakeGooglemPane(this);
                }
                return this.mUIAustraliaMakeGooglemPane;
            }
        }
        
        public UIAustraliaPane UIAustraliaPane
        {
            get
            {
                if ((this.mUIAustraliaPane == null))
                {
                    this.mUIAustraliaPane = new UIAustraliaPane(this);
                }
                return this.mUIAustraliaPane;
            }
        }
        
        public UIBtnGButton UIBtnGButton
        {
            get
            {
                if ((this.mUIBtnGButton == null))
                {
                    this.mUIBtnGButton = new UIBtnGButton(this);
                }
                return this.mUIBtnGButton;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIDriveHyperlink;
        
        private HtmlCell mUIGs_tti0Cell;
        
        private HtmlEdit mUIQEdit;
        
        private UIAustraliaMakeGooglemPane mUIAustraliaMakeGooglemPane;
        
        private UIAustraliaPane mUIAustraliaPane;
        
        private UIBtnGButton mUIBtnGButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIAustraliaMakeGooglemPane : HtmlSpan
    {
        
        public UIAustraliaMakeGooglemPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "body";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Australia\r\n\r\n Make Google my homepage ";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = "ctr-p";
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "id=body class=ctr-p";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "40";
            this.WindowTitles.Add("Google");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"HEIGHT: 102px\"";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "5";
                    this.mUIItemPane.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIItemPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIAustraliaPane : HtmlDiv
    {
        
        public UIAustraliaPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDiv.PropertyNames.Id] = "lga";
            this.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Australia";
            this.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
            this.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"MARGIN-TOP: -22px; HEIGHT: 231px\"";
            this.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "56";
            this.WindowTitles.Add("Google");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIAustraliaPane1
        {
            get
            {
                if ((this.mUIAustraliaPane1 == null))
                {
                    this.mUIAustraliaPane1 = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIAustraliaPane1.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIAustraliaPane1.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIAustraliaPane1.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Australia";
                    this.mUIAustraliaPane1.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIAustraliaPane1.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIAustraliaPane1.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"PADDING-TOP: 112px\"";
                    this.mUIAustraliaPane1.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
                    this.mUIAustraliaPane1.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIAustraliaPane1;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIAustraliaPane1;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIBtnGButton : HtmlButton
    {
        
        public UIBtnGButton(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlButton.PropertyNames.Id] = "gbqfb";
            this.SearchProperties[HtmlButton.PropertyNames.Name] = "btnG";
            this.FilterProperties[HtmlButton.PropertyNames.DisplayText] = null;
            this.FilterProperties[HtmlButton.PropertyNames.Type] = "submit";
            this.FilterProperties[HtmlButton.PropertyNames.Title] = null;
            this.FilterProperties[HtmlButton.PropertyNames.Class] = "gbqfb";
            this.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "id=gbqfb class=gbqfb name=btnG type=subm";
            this.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "1";
            this.WindowTitles.Add("Google");
            #endregion
        }
        
        #region Properties
        public HtmlSpan UIItemPane
        {
            get
            {
                if ((this.mUIItemPane == null))
                {
                    this.mUIItemPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIItemPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.Class] = "gbqfi";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "class=gbqfi";
                    this.mUIItemPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "1";
                    this.mUIItemPane.WindowTitles.Add("Google");
                    #endregion
                }
                return this.mUIItemPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlSpan mUIItemPane;
        #endregion
    }
}