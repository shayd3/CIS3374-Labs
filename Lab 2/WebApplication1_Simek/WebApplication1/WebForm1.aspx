<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
    <link href="css/datepicker.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Arvo" rel="stylesheet">
    <style>
        #main {
            position: absolute;
            top: 0;
            bottom: 0;
            left: 0;
            right: 0;
            margin: auto;
            height: 50%;
            width: 80%;
        }

        #header {
            top: 0;
            width: 100%;
            height: 25%;
            background-color: #990033;
            text-align: center;
            padding: 10px;
        }

        h1 {
            color: white;
            font-family: 'Arvo', serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="header">
            <img src="https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Temple_T_logo.svg/2000px-Temple_T_logo.svg.png" alt="temple-logo" width="50px"/>
            <h1>Student Profile Program</h1>
        </div>
        <div id="main">
            <div class="alert alert-danger alert-dismissible" role="alert" id="divError" visible="false" runat="server" style="background-image: none;">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <span class="glyphicon glyphicon-exclamation-sign" aria-hidden="true"></span>
                <asp:Label ID="lblErrorMessage" runat="server"></asp:Label>
            </div>
            <div class="alert alert-success alert-dismissible" role="alert" id="divSucess" visible="false" runat="server" style="background-image: none;">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                <asp:Label ID="lblSucess" runat="server"></asp:Label>
            </div>

            <div class="row" style="padding: 25px;">
                <div class="col-sm-4">
                    <label for="txtFirstName">First Name</label>
                    <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control" placeholder="John" required></asp:TextBox>
                </div>
                <div class="col-sm-4">
                    <label for="txtMiddleName">Middle Name</label>
                    <asp:TextBox ID="txtMiddleName" runat="server" CssClass="form-control" placeholder="Jacob" required></asp:TextBox>
                </div>
                <div class="col-sm-4">
                    <label for="txtLastName">Last Name</label>
                    <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control" placeholder="Smith" required></asp:TextBox>
                </div>
            </div>
            <div class="row" style="padding: 25px;">

                <div class="col-sm-2">
                    <label>Birth Month</label>
                    <asp:DropDownList ID="ddlDOBMonth" runat="server" CssClass="form-control" required>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-2">
                    <label>Birth Day</label>
                    <asp:DropDownList ID="ddlDOBDay" runat="server" CssClass="form-control" required>
                        <asp:ListItem>01</asp:ListItem>
                        <asp:ListItem>02</asp:ListItem>
                        <asp:ListItem>03</asp:ListItem>
                        <asp:ListItem>04</asp:ListItem>
                        <asp:ListItem>05</asp:ListItem>
                        <asp:ListItem>06</asp:ListItem>
                        <asp:ListItem>07</asp:ListItem>
                        <asp:ListItem>08</asp:ListItem>
                        <asp:ListItem>09</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-2">
                    <label>Birth Year</label>
                    <asp:DropDownList ID="ddlDOBYear" runat="server" CssClass="form-control" required>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-6">
                    <label for="txtPhoneNum1">Phone Number</label>
                    <asp:TextBox ID="txtPhoneNum1" runat="server" CssClass="form-control" placeholder="(XXX)XXX-XXXX" required></asp:TextBox>
                </div>
            </div>
            <div class="row" style="padding: 25px;">
                <div class="col-sm-6">
                    <label for="txtTUid">TUID</label>
                    <asp:TextBox ID="txtTUid" runat="server" CssClass="form-control" required placeholder="9XXXXXXXXX"></asp:TextBox>
                </div>
                <div class="col-sm-3">
                    <label for="ddlExpectedGradSem">Expected Graducation Semster</label>
                    <asp:DropDownList ID="ddlExpectedGradSem" runat="server" CssClass="form-control" required>
                        <asp:ListItem>Fall</asp:ListItem>
                        <asp:ListItem>Spring</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-3">
                    <label for="ddlExpectedGradYear">Expected Graducation Year</label>
                    <asp:DropDownList ID="ddlExpectedGradYear" runat="server" CssClass="form-control" required>
                        <asp:ListItem>2016</asp:ListItem>
                        <asp:ListItem>2017</asp:ListItem>
                        <asp:ListItem>2018</asp:ListItem>
                        <asp:ListItem>2019</asp:ListItem>
                        <asp:ListItem>2020</asp:ListItem>
                        <asp:ListItem>2021</asp:ListItem>
                        <asp:ListItem>2022</asp:ListItem>
                        <asp:ListItem>2023</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row" style="padding: 25px;">
                <div class="col-sm-5">
                    <label for="txtEmail">Email</label>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" required placeholder="john@website.com"></asp:TextBox>
                </div>
                <div class="col-sm-4">
                    <label for="lbxMajor">Major</label>
                    <asp:DropDownList ID="ddlMajor" runat="server" CssClass="form-control">
                        <asp:ListItem>Agriculture</asp:ListItem>
                        <asp:ListItem>Archiecture</asp:ListItem>
                        <asp:ListItem>Art</asp:ListItem>
                        <asp:ListItem>Biology</asp:ListItem>
                        <asp:ListItem>Business</asp:ListItem>
                        <asp:ListItem>Communications</asp:ListItem>
                        <asp:ListItem>Computer Science</asp:ListItem>
                        <asp:ListItem>Education</asp:ListItem>
                        <asp:ListItem>Engineering</asp:ListItem>
                        <asp:ListItem>Health Care</asp:ListItem>
                        <asp:ListItem>Literature</asp:ListItem>
                        <asp:ListItem>Law</asp:ListItem>
                        <asp:ListItem>Mathematics</asp:ListItem>
                        <asp:ListItem>Mechanics</asp:ListItem>
                        <asp:ListItem>Philosophy</asp:ListItem>
                        <asp:ListItem>Psychology</asp:ListItem>
                        <asp:ListItem>Social Services</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-sm-3">
                    <label for="radUnderGrad">Are you an undergraduate student?</label>
                    <asp:RadioButtonList ID="radUndergrad" runat="server" required>
                        <asp:ListItem>&nbsp;&nbsp;Yes</asp:ListItem>
                        <asp:ListItem>&nbsp;&nbsp;No</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="row" style="padding: 25px;">
                <div class="col-sm-4"></div>
                <div class="col-sm-2">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Student" CssClass="btn btn-default" OnClick="btnAdd_Click" />
                </div>
                <div class="col-sm-2">
                    <asp:Button ID="btnReport" runat="server" Text="Run Report" CssClass="btn btn-success" OnClick="btnReport_Click" UseSubmitBehavior ="false"/>
                </div>
            </div>
        </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script src="js/DatePicker.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</body>
</html>
