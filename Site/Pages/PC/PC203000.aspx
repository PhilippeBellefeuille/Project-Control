<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormTab.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="PC203000.aspx.cs" Inherits="Page_PC203000" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/FormTab.master" %>
<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
	<px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%" TypeName="PX.Objects.PC.PCResourceMaint" PrimaryView="Document" PageLoadBehavior="GoFirstRecord">
		<CallbackCommands>
			<px:PXDSCallbackCommand Name="Insert" PostData="Self" />
			<px:PXDSCallbackCommand CommitChanges="True" Name="Save" />
			<px:PXDSCallbackCommand Name="First" PostData="Self" StartNewGroup="True" />
			<px:PXDSCallbackCommand Name="Last" PostData="Self" />
		</CallbackCommands>
	</px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
	<px:PXFormView ID="frmHeader" runat="server" DataSourceID="ds" Style="z-index: 100" Width="100%" DataMember="Document" Caption="Calendar Summary">
		<Template>
			<px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="SM" ControlSize="M" />
			<px:PXSelector ID="edAcctCD" runat="server" DataField="AcctCD" CommitChanges="True" />
			<px:PXTextEdit ID="edAcctName" runat="server" DataField="AcctName" />
			<px:PXDropDown ID="edExpertiseLevel" runat="server" DataField="ExpertiseLevel" />
		</Template>
	</px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <px:PXSmartPanel ID="pnlEmployeeExtend" runat="server" Key="EmployeeExtend" Caption="Extend Employee" CaptionVisible="True" LoadOnDemand="true"
		DesignView="Content" HideAfterAction="false" AcceptButtonID="PXButtonOK" CancelButtonID="PXButtonCancel" >
		<px:PXFormView ID="formEmployeeExtend" runat="server" DataSourceID="ds" Style="z-index: 100" Width="100%" DataMember="EmployeeExtend"
			CaptionVisible="False">
			<ContentStyle BackColor="Transparent" BorderStyle="None" />
			<Template>
				<px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="S" ControlSize="XM" />
				<px:PXSelector ID="edBAccountID" runat="server" DataField="BAccountID" CommitChanges="True" />
			</Template>
		</px:PXFormView>
		<px:PXPanel ID="PXPanel1" runat="server" SkinID="Buttons">
			<px:PXButton ID="PXButtonOK" runat="server" DialogResult="OK" Text="OK" />
			<px:PXButton ID="PXButtonCancel" runat="server" DialogResult="Cancel" Text="Cancel" />
		</px:PXPanel>
	</px:PXSmartPanel>
	<px:PXTab ID="tab" runat="server" Width="100%" Height="250px" DataSourceID="ds" DataMember="CurrentDocument" LinkIndicator="False">
		<Items>
			<px:PXTabItem Text="Assignment Calendar">
				<Template>
					<px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="XXS" ControlSize="XXS" />
					<px:PXLabel ID="LL1" runat="server"> Day of Week </px:PXLabel>
					<px:PXCheckBox CommitChanges="True" ID="chkSunAssignableDay" runat="server" DataField="SunAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkMonAssignableDay" runat="server" DataField="MonAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkTueAssignableDay" runat="server" DataField="TueAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkWedAssignableDay" runat="server" DataField="WedAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkThuAssignableDay" runat="server" DataField="ThuAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkFriAssignableDay" runat="server" DataField="FriAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXCheckBox CommitChanges="True" ID="chkSatAssignableDay" runat="server" DataField="SatAssignableDay" AlignLeft="True" SuppressLabel="True" />
					<px:PXLayoutRule runat="server" StartColumn="True" ControlSize="XS" LabelsWidth="XXS" />
                    <px:PXLabel ID="LL2" runat="server">Time Available for Assignment</px:PXLabel>
                    <px:PXTimeSpan ID="tsSunAssignableTime" runat="server" DataField="SunAssignableTime" InputMask="hh:mm" LabelID="LL4" LabelPostfix="" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsMonAssignableTime" runat="server" DataField="MonAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsTueAssignableTime" runat="server" DataField="TueAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsWedAssignableTime" runat="server" DataField="WedAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsThuAssignableTime" runat="server" DataField="ThuAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsFriAssignableTime" runat="server" DataField="FriAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
                    <px:PXTimeSpan ID="tsSatAssignableTime" runat="server" DataField="SatAssignableTime" InputMask="hh:mm" SuppressLabel="True"/>
				</Template>
			</px:PXTabItem>
		</Items>
		<AutoSize Container="Window" Enabled="True" />
	</px:PXTab>
</asp:Content>
