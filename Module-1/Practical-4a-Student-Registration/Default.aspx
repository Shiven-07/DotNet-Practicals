<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="StudentRegForm.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Registration</title>
    <style>
        body { font-family: Arial; margin: 30px; }
        .form-group { margin: 10px 0; }
        label { display: inline-block; width: 180px; font-weight: bold; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Student Registration Form</h2>
        <hr />
        <div class="form-group">
            <asp:Label Text="Student Name:" runat="server" />
            <asp:TextBox ID="txtName" runat="server" Width="200px" />
        </div>
        <div class="form-group">
            <asp:Label Text="Gender:" runat="server" />

<asp:RadioButton ID="rbMale" GroupName="gender" Text="Male" runat="server" />
            <asp:RadioButton ID="rbFemale" GroupName="gender" Text="Female" runat="server"
/>
        </div>
        <div class="form-group">
            <asp:Label Text="Course:" runat="server" />
            <asp:DropDownList ID="ddlCourse" runat="server">
                <asp:ListItem Text="Select Course" Value="" />
                <asp:ListItem Text="BSc IT" Value="BSc IT" />
                <asp:ListItem Text="BSc CS" Value="BSc CS" />
                <asp:ListItem Text="BCA" Value="BCA" />
            </asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label Text="Date of Birth:" runat="server" />
            <asp:Calendar ID="calDOB" runat="server" />
        </div>
        <div class="form-group">
            <asp:CheckBox ID="chkTerms" Text="I accept Terms and Conditions" runat="server"
/>
        </div>
        <div class="form-group">
            <asp:Button ID="btnSubmit" Text="Register" runat="server"
                OnClick="btnSubmit_Click" />
            <asp:Button ID="btnClear" Text="Clear" runat="server"
                OnClick="btnClear_Click" />
        </div>
        <hr />
        <asp:Label ID="lblOutput" runat="server" ForeColor="Green" Font-Bold="true" />
    </form>
</body>
</html>
