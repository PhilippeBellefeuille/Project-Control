<%@ Page Language="C#" MasterPageFile="~/MasterPages/FormDetail.master" AutoEventWireup="true" ValidateRequest="false" CodeFile="PC201000.aspx.cs"
    Inherits="Page_PC201000" Title="Untitled Page" %>

<%@ MasterType VirtualPath="~/MasterPages/FormDetail.master" %>
<asp:Content ID="cont1" ContentPlaceHolderID="phDS" runat="Server">
    <px:PXDataSource ID="ds" runat="server" Visible="True" Width="100%" TypeName="PX.Objects.PC.PCTaskTypeMaint" PrimaryView="Document">
        <CallbackCommands>
            <px:PXDSCallbackCommand Name="Insert" PostData="Self" />
            <px:PXDSCallbackCommand CommitChanges="True" Name="Save" />
            <px:PXDSCallbackCommand Name="First" PostData="Self" StartNewGroup="true" />
            <px:PXDSCallbackCommand Name="Last" PostData="Self" />
        </CallbackCommands>
    </px:PXDataSource>
</asp:Content>
<asp:Content ID="cont2" ContentPlaceHolderID="phF" runat="Server">
    <px:PXFormView ID="form" runat="server" DataSourceID="ds" Style="z-index: 100" Width="100%" DataMember="Document" Caption="Task Type Settings"
        DefaultControlID="edTaskType" NoteIndicator="True" FilesIndicator="True" ActivityIndicator="true" ActivityField="NoteActivity">
        <Template>
            <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="SM" ControlSize="XM" />
            <px:PXLayoutRule runat="server" Merge="True" />
            <px:PXSelector Size="xs" ID="edTaskType" runat="server" DataField="TaskType" />
            <px:PXCheckBox CommitChanges="True" ID="chkActive" runat="server" Checked="True" DataField="Active" />
            <px:PXLayoutRule runat="server" Merge="False" />
            <px:PXTextEdit ID="edDescription" runat="server" DataField="Description" />
        </Template>
    </px:PXFormView>
</asp:Content>
<asp:Content ID="cont3" ContentPlaceHolderID="phG" runat="Server">
    <px:PXTab ID="tab" runat="server" Width="100%" Height="606px" DataSourceID="ds" DataMember="CurrentDocument" LinkPage="">
        <AutoSize Enabled="True" Container="Window" MinHeight="150" />
        <Items>
            <px:PXTabItem Text="General Settings">
                <Template>
                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="M" ControlSize="XM" />
                    <px:PXSelector ID="edNumberingID" runat="server" DataField="NumberingID" AllowEdit="True" />
                    <px:PXCheckBox SuppressLabel="True" ID="chkIsBillable" runat="server" DataField="IsBillable" />
                    <px:PXCheckBox SuppressLabel="True" ID="chkRequiresEstimate" runat="server" DataField="RequiresEstimate" />
                </Template>
            </px:PXTabItem>
            <px:PXTabItem Text="Resources" >
                <Template>
                    <px:PXGrid runat="server" ID="grid" SkinID="DetailsInTab" DataSourceID="ds" Width="100%" Height="180px">
                        <AutoSize Enabled="True" MinHeight="150" />
                        <Levels>
                            <px:PXGridLevel DataMember="Resources" DataKeyNames="OrderType,Operation">
                                <RowTemplate>
                                    <px:PXLayoutRule runat="server" StartColumn="True" LabelsWidth="SM" ControlSize="XM" />
                                    <px:PXSelector ID="edBAccountID" runat="server" DataField="BAccountID"  />
                                </RowTemplate>
                                <Columns>
                                    <px:PXGridColumn DataField="BAccountID" Visible="False" Width="200px" />
                                </Columns>
                                <Layout FormViewHeight="" />
                            </px:PXGridLevel>
                        </Levels>
                    </px:PXGrid>
                </Template>
            </px:PXTabItem>
        </Items>
    </px:PXTab>
</asp:Content>
