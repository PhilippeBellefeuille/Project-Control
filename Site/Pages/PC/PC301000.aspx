<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true"
    ValidateRequest="false" CodeFile="PC301000.aspx.cs" Inherits="Page_PC301000" Title="Untitled Page" %>
<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>
<%@ Register Assembly="PX.Web.Controls.PC" Namespace="PX.Web.Controls.PC" TagPrefix="pxpc" %>

<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%" PrimaryView="Document" TypeName="PX.Objects.PC.PCTaskMaint">
		<CallbackCommands>
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
	<px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100" Width="100%" DataMember="Document" TabIndex="100">
		<Template>
			<px:PXLayoutRule runat="server" StartRow="True"/>
		    <px:PXSelector ID="edTaskType" runat="server" DataField="TaskType">
            </px:PXSelector>
            <px:PXSelector ID="edTaskNbr" runat="server" DataField="TaskNbr">
            </px:PXSelector>
            <px:PXDropDown ID="edStatus" runat="server" DataField="Status">
            </px:PXDropDown>
            <px:PXTextEdit ID="edDescription" runat="server" AlreadyLocalized="False" DataField="Description" DefaultLocale="">
            </px:PXTextEdit>
            <px:PXDateTimeEdit ID="edStartDate" runat="server" AlreadyLocalized="False" DataField="StartDate" DefaultLocale="">
            </px:PXDateTimeEdit>
            <px:PXDateTimeEdit ID="edEndDate" runat="server" AlreadyLocalized="False" DataField="EndDate" DefaultLocale="">
            </px:PXDateTimeEdit>
            <px:PXTimeSpan ID="tsDuration" runat="server" DataField="Duration" InputMask="hh:mm" />
            <px:PXTimeSpan ID="tsEstimate" runat="server" DataField="Estimate" InputMask="hh:mm" />
            <px:PXSegmentMask ID="edEstimatorID" runat="server" DataField="EstimatorID">
            </px:PXSegmentMask>

		</Template>
	</px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <pxpc:PXGantt ID="ganttControl" runat="server"></pxpc:PXGantt>
</asp:Content>
