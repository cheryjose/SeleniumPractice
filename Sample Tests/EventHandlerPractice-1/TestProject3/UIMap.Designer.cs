﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 10.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace TestProject3
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
            HtmlDiv uIRcntPane = this.UIAjithmjoseGoogleSearWindow.UIAjithmjoseGoogleSearDocument.UIRcntPane;
            HtmlEdit uIQEdit = this.UIAjithmjoseGoogleSearWindow.UIAjithmjoseGoogleSearDocument.UIQEdit;
            HtmlHyperlink uIYouHyperlink = this.UIAjithmjoseGoogleSearWindow.UIAjithmjoseGoogleSearDocument.UIYouHyperlink;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover 'rcnt' pane at (904, 424)
            Mouse.Hover(uIRcntPane, new Point(904, 424));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'q' text box
            Mouse.Click(uIQEdit, new Point(181, 3));

            // Move 'q' text box from (177, 4) to '+You' link (38, 7)
            uIYouHyperlink.EnsureClickable(new Point(38, 7));
            Mouse.StartDragging(uIQEdit, new Point(177, 4));
            Mouse.StopDragging(uIYouHyperlink, new Point(38, 7));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Mouse hover '+You' link at (38, 7)
            Mouse.Hover(uIYouHyperlink, new Point(38, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Type 'Chery Jose' in 'q' text box
            uIQEdit.Text = this.RecordedMethod1Params.UIQEditText;
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
        
        public UIAjithmjoseGoogleSearWindow UIAjithmjoseGoogleSearWindow
        {
            get
            {
                if ((this.mUIAjithmjoseGoogleSearWindow == null))
                {
                    this.mUIAjithmjoseGoogleSearWindow = new UIAjithmjoseGoogleSearWindow();
                }
                return this.mUIAjithmjoseGoogleSearWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private UIAjithmjoseGoogleSearWindow mUIAjithmjoseGoogleSearWindow;
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
        /// Type 'Chery Jose' in 'q' text box
        /// </summary>
        public string UIQEditText = "Chery Jose";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIAjithmjoseGoogleSearWindow : BrowserWindow
    {
        
        public UIAjithmjoseGoogleSearWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "ajith m jose - Google Search";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("ajith m jose - Google Search");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIAjithmjoseGoogleSearDocument UIAjithmjoseGoogleSearDocument
        {
            get
            {
                if ((this.mUIAjithmjoseGoogleSearDocument == null))
                {
                    this.mUIAjithmjoseGoogleSearDocument = new UIAjithmjoseGoogleSearDocument(this);
                }
                return this.mUIAjithmjoseGoogleSearDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIAjithmjoseGoogleSearDocument mUIAjithmjoseGoogleSearDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class UIAjithmjoseGoogleSearDocument : HtmlDocument
    {
        
        public UIAjithmjoseGoogleSearDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = "gsr";
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "ajith m jose - Google Search";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = @"http://www.google.com.au/#hl=en&output=search&sclient=psy-ab&q=Ajith+m+Jose&oq=Ajith+m+Jose&gs_l=hp.12..0i30.3660.6960.0.13025.12.10.0.2.2.0.559.3412.2-4j4j1j1.10.0.les%3B..0.0...1c.1.5.psy-ab.jvWvhXFzDNU&pbx=1&bav=on.2,or.r_gc.r_pw.r_qf.&bvm=bv.43148975,d.dGI&fp=b4cdf8993f8329c8&biw=1280&bih=610";
            this.WindowTitles.Add("ajith m jose - Google Search");
            #endregion
        }
        
        #region Properties
        public HtmlDiv UIRcntPane
        {
            get
            {
                if ((this.mUIRcntPane == null))
                {
                    this.mUIRcntPane = new HtmlDiv(this);
                    #region Search Criteria
                    this.mUIRcntPane.SearchProperties[HtmlDiv.PropertyNames.Id] = "rcnt";
                    this.mUIRcntPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIRcntPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "\r\n\r\nSearch ResultsAJITH M JOSEwww.ajithm";
                    this.mUIRcntPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIRcntPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIRcntPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"POSITION: relative; ZOOM: 1; CLEA";
                    this.mUIRcntPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "123";
                    this.mUIRcntPane.WindowTitles.Add("ajith m jose - Google Search");
                    #endregion
                }
                return this.mUIRcntPane;
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
                    this.mUIQEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "5";
                    this.mUIQEdit.WindowTitles.Add("ajith m jose - Google Search");
                    #endregion
                }
                return this.mUIQEdit;
            }
        }
        
        public HtmlHyperlink UIYouHyperlink
        {
            get
            {
                if ((this.mUIYouHyperlink == null))
                {
                    this.mUIYouHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIYouHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "gb_119";
                    this.mUIYouHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIYouHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIYouHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "+You";
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/";
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://plus.google.com/?gpsrc=ogpy0&tab=wX";
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = "gbzt";
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=gb_119 class=gbzt onclick=gbar.logger";
                    this.mUIYouHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "3";
                    this.mUIYouHyperlink.WindowTitles.Add("ajith m jose - Google Search");
                    #endregion
                }
                return this.mUIYouHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlDiv mUIRcntPane;
        
        private HtmlEdit mUIQEdit;
        
        private HtmlHyperlink mUIYouHyperlink;
        #endregion
    }
}