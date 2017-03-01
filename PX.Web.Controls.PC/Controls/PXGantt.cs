using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PX.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.HtmlControls;

namespace PX.Web.Controls.PC
{
    public class PXGantt : WebControl, IPXScriptControl
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the PXGantt class.
        /// </summary>
        public PXGantt()
        {
        }

        #endregion

        #region IPXScriptControl Implementation

        /// <summary>
        /// Gets or sets a value indicating whether client-side scripts is enabled.
        /// </summary>
        [Category("Behavior"), DefaultValue(true)]
        [Description("Indicates whether client-side scripts are enabled.")]
        public bool EnableClientScript
        {
            get { return (bool)STM.GetProp(this.ViewState, "EnableScript", true); }
            set { STM.SetProp(this.ViewState, "EnableScript", value, true); }
        }
        
        /// <summary>
		/// Gets the client-side class name.
		/// </summary>
		string IPXScriptControl.ClientClassName
        {
            get { return this.GetType().Name; }
        }

        private ScriptRegisterFlag scriptFlags;
        /// <summary>
		/// Gets or sets the JavaScript registration options.
		/// </summary>
		ScriptRegisterFlag IPXScriptControl.RegisterFlags
        {
            get
            {
                if (this.scriptFlags == ScriptRegisterFlag.NotSet)
                    return ScriptRegisterFlag.Default;
                return this.scriptFlags;

            }
            set
            {
                this.scriptFlags = value;
            }
        }

        bool IPXScriptControl.RenderTemplateData
        {
            get { return true; }
        }

        //-------------------------------------------------------------------------
        /// <summary>
        /// Perform the additional JavaScript modules registration.
        /// </summary>
        void IPXScriptControl.RegisterModules(JSManager sm)
        {
            sm.RegisterModule(typeof(PXGantt), "PX.Web.Controls.PC.Scripts.px_gantt.js");
            sm.RegisterModule(typeof(PXGantt), "PX.Web.Controls.PC.Scripts.dhtmlxgantt.js");
        }

        /// <summary>
		/// Register additional client-side properties.
		/// </summary>
		void IPXScriptControl.RegisterProperties(JSObject obj)
        {
        }


        /// <summary>
        /// Perform the additional JavaScript variables registration.
        /// </summary>
        void IPXScriptControl.RegisterVariables(JSManager sm)
        {
        }

        #endregion

        #region RenderFunctions

        /// <summary>
        /// Pre-render event handler. Register requiered CSS classes and scripts
        /// </summary>
        protected override void OnPreRender(EventArgs e)
        {
            // register CSS-styles
            //this.StyleManager.Register();

            // register embeded java script and initialize script blocks
            if (this.EnableClientScript)
            {
                //this.Page.RegisterRequiresPostBack(this);
                JSManager.Register(this);
            }
            base.OnPreRender(e);
        }

        /// <summary>
        /// Redefines a tag key for PXGantt control in order to render it as a Div
        /// </summary>
        protected override HtmlTextWriterTag TagKey
        {
            get
            {
                return HtmlTextWriterTag.Div;
            }
        }

        /// <summary>
        /// Overrides RenderContent event handler. Implements render logic of the control.
        /// </summary>
        protected override void RenderContents(HtmlTextWriter writer)
        {
            this.Controls.Clear();
            this.CreateContent();
            base.RenderContents(writer);
        }

        /// <summary>
        /// Top-level function for content creation. Fills up 
        /// </summary>
        /// <param name="outline">table, which will filled with control's content.</param>
        private void CreateContent()
        {
        }
        
        #endregion
    }
}