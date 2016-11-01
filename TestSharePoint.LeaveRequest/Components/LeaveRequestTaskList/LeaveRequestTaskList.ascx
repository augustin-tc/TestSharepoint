<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LeaveRequestTaskList.ascx.cs" Inherits="TestSharePoint.LeaveRequest.Components.LeaveRequestTaskList.LeaveRequestTaskList" %>
<div id="divLeaveRequest">
<h3 id="titleLeaveRequest" runat="server">My Leave requests to validate</h3>
    
    <asp:GridView ID="gvtasks" runat="server"></asp:GridView>
    <div id="divTest" runat="server" visible="false">

        <textarea id="testAreaTest" runat="server" rows="8"></textarea>
        <asp:Button ID="BtTestQuery" runat="server" OnClick="BtTestQuery_Click" Text="Test" />
        <div id="divQueryResult" runat="server"></div>
    </div>
</div>