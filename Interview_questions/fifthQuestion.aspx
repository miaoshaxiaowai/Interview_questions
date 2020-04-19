<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fifthQuestion.aspx.cs" Inherits="Interview_questions.fifthQuestion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    
<body>
    <form id="form1" runat="server">
        <h1>第五步根据OrderID显示所有的Order和OrderProduct数据</h1>
        <h2>红色为OrderProduct的内容</h2>
        <h2><a href="/">返回第三步</a></h2>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="请输入1722-2016" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索"  />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="显示全部" />
        <div id="div1" runat="server"  >
            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
                <Columns>
                    <asp:BoundField DataField="OrderID" HeaderText="OrderID"  />
                    <asp:BoundField DataField="OrderNum" HeaderText="OrderNum" />
                    <asp:BoundField DataField="Hospital" HeaderText="Hospital" />
                    <asp:BoundField DataField="Doctor" HeaderText="Doctor" />
                    <asp:BoundField DataField="Patient" HeaderText="Patient" />
                    <asp:BoundField DataField="OrderKind" HeaderText="OrderKind" />
                    <asp:BoundField DataField="AcceptDate" HeaderText="AcceptDate" />
                    <asp:BoundField DataField="FinishDate" HeaderText="FinishDate" />
                    <asp:BoundField DataField="Products" HeaderText="Products" />
                    <asp:BoundField DataField="OrderProductID" HeaderText="OrderProductID" ItemStyle-ForeColor="Red"/>
                    <asp:BoundField DataField="Product" HeaderText="Product" ItemStyle-ForeColor="Red"/>
                    <asp:BoundField DataField="Color" HeaderText="Color" ItemStyle-ForeColor="Red"/>
                    <asp:BoundField DataField="Num" HeaderText="Num" ItemStyle-ForeColor="Red"/>
                    <asp:BoundField DataField="Price" HeaderText="Price" ItemStyle-ForeColor="Red"/>
                    <asp:BoundField DataField="SumPrice" HeaderText="SumPrice" ItemStyle-ForeColor="Red"/>
                </Columns>
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
            </asp:GridView>
              </div>
        
    </form>
</body>
</html>
