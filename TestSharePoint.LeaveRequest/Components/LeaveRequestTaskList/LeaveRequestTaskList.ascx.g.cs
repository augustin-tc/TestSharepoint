﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestSharePoint.LeaveRequest.Components.LeaveRequestTaskList {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class LeaveRequestTaskList {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl titleLeaveRequest;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView gvtasks;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlTextArea testAreaTest;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.WebControls.Button BtTestQuery;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divQueryResult;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected global::System.Web.UI.HtmlControls.HtmlGenericControl divTest;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "14.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(LeaveRequestTaskList target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControltitleLeaveRequest() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("h3");
            this.titleLeaveRequest = @__ctrl;
            @__ctrl.ID = "titleLeaveRequest";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("My Leave requests to validate"));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlgvtasks() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.gvtasks = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "gvtasks";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlTextArea @__BuildControltestAreaTest() {
            global::System.Web.UI.HtmlControls.HtmlTextArea @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlTextArea();
            this.testAreaTest = @__ctrl;
            @__ctrl.ID = "testAreaTest";
            @__ctrl.Rows = 8;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.WebControls.Button @__BuildControlBtTestQuery() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.BtTestQuery = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "BtTestQuery";
            @__ctrl.Text = "Test";
            @__ctrl.Click -= new System.EventHandler(this.BtTestQuery_Click);
            @__ctrl.Click += new System.EventHandler(this.BtTestQuery_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivQueryResult() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.divQueryResult = @__ctrl;
            @__ctrl.ID = "divQueryResult";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private global::System.Web.UI.HtmlControls.HtmlGenericControl @__BuildControldivTest() {
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl;
            @__ctrl = new global::System.Web.UI.HtmlControls.HtmlGenericControl("div");
            this.divTest = @__ctrl;
            @__ctrl.ID = "divTest";
            @__ctrl.Visible = false;
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlTextArea @__ctrl1;
            @__ctrl1 = this.@__BuildControltestAreaTest();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        "));
            global::System.Web.UI.WebControls.Button @__ctrl2;
            @__ctrl2 = this.@__BuildControlBtTestQuery();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl3;
            @__ctrl3 = this.@__BuildControldivQueryResult();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void @__BuildControlTree(global::TestSharePoint.LeaveRequest.Components.LeaveRequestTaskList.LeaveRequestTaskList @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<div id=\"divLeaveRequest\">\r\n"));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl1;
            @__ctrl1 = this.@__BuildControltitleLeaveRequest();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    \r\n    "));
            global::System.Web.UI.WebControls.GridView @__ctrl2;
            @__ctrl2 = this.@__BuildControlgvtasks();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    "));
            global::System.Web.UI.HtmlControls.HtmlGenericControl @__ctrl3;
            @__ctrl3 = this.@__BuildControldivTest();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</div>"));
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "14.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
