<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpies.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="epic-spies-logo.jpg" />
            <br />
           <h2>New Spy Assignment Form</h2>
            <p>Spy Code Name:
                <asp:TextBox ID="codeNameTextBox" runat="server"></asp:TextBox>
            </p>
            <p>New Assignment Name:
                <asp:TextBox ID="assignmentTextBox" runat="server"></asp:TextBox>
            </p>
            <p>&nbsp;</p>
            <p>End Date of Previous Assignment</p>
            <p>
                <asp:Calendar ID="previousEndCalendar" runat="server"></asp:Calendar>
            </p>
            <p>&nbsp;</p>
            <p>Start Date of New Assignment</p>
            <p>
                <asp:Calendar ID="newStartCalendar" runat="server"></asp:Calendar>
            </p>
            <p>&nbsp;</p>
            <p>Projected End Date of New Assignment</p>
            <p>
                <asp:Calendar ID="newEndCalendar" runat="server"></asp:Calendar>
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Button ID="assignSpyButton" runat="server" OnClick="assignSpyButton_Click" Text="Assign Spy" />
            </p>
            <p>&nbsp;</p>
            <p>
                <asp:Label ID="resultLabel" runat="server"></asp:Label>
            </p> </div>
    </form>
</body>
</html>
