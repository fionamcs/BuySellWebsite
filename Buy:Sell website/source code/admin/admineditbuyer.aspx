<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admineditbuyer.aspx.cs" Inherits="admin_admineditbuyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Elmtree</title>

    <!-- Bootstrap Core CSS - Uses Bootswatch Flatly Theme: http://bootswatch.com/flatly/ -->
    <link href="../css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="../css/freelancer.css" rel="stylesheet">

    <!-- Custom Fonts -->
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Montserrat:400,700" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Lato:400,700,400italic,700italic" rel="stylesheet" type="text/css">

    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
        <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
        <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
    <![endif]-->
</head>
<body>
    <form id="form1" runat="server">
    <!--<body id="page-top" class="index">-->

    <!-- Navigation -->
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header page-scroll">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="#page-top">Elmtree</a>
            </div>

            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav navbar-right">
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                    <li class="page-scroll">
                        <a href="adminhome.aspx">Admin Homepage</a>
                    </li>
                    <li class="page-scroll">
                        <a href="adminitems.aspx">Items</a>
                    </li>
                    <li class="page-scroll">
                        <a href=".aspx">Comments</a>
                    </li>
                    <li class="page-scroll">
                        <a href=".aspx">Ratings</a>
                    </li>
                    <li class="page-scroll">
                        <a href="adminusers.aspx">Buyer/Sellers</a>
                    </li>
                    <li class="page-scroll">
                        <a href="admincategorys.aspx">Categories</a>
                    </li>
                    <asp:Button ID="outbutton" runat="server" Text="Sign Out" OnClick="outbutton_Click" CssClass="btn btn-success"/>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container-fluid -->
    </nav>

    <!-- Header -->
    <header>
        <div class="container">
            <div class="row">
                <div class="col-xs-12">                   
                    <div class="intro-text">
                        <span class="name">Admin Edit Buyer</span>
                        <hr class="star-light">
                        <span class="skills"></span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Portfolio Grid Section -->
    <section id="portfolio">
        <div class="container">
            <div class="row">
                <span class="form-group">

                    <!-- first name -->
                <div class="form-group"> 
					 <label for="firstname" class="col-sm-2 control-label">First Name: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="firstname" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />
                  
                      <!-- last name -->
                <div class="form-group"> 
					 <label for="lastname" class="col-sm-2 control-label">Last Name: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="lastname" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />

                      <!-- username -->
                <div class="form-group"> 
					 <label for="username" class="col-sm-2 control-label">Username: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="username" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />

                      <!-- password -->
                <div class="form-group"> 
					 <label for="password" class="col-sm-2 control-label">Password: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="password" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />

                    <!-- Address -->
					<div class="form-group"> 
                         <label for="address" class="col-sm-2 control-label">Address: </label>
						<div class="col-sm-6">
						<asp:TextBox ID="address"  CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
						</div>
                    </div>
					<br />
                    <br />
                    <br />

                    <!-- phone -->
					<div class="form-group"> 
                         <label for="phone" class="col-sm-2 control-label">Phone Number:</label>
                        <div class="col-sm-6">
						<asp:TextBox ID="phone" CssClass="form-control" runat="server"></asp:TextBox>
						</div>
					</div>
                    <br />
                    <br />
                    <br />

                      <!-- email -->
                <div class="form-group"> 
					 <label for="email" class="col-sm-2 control-label">Email: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="email" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />

                      <!-- Learning -->
                <div class="form-group"> 
					 <label for="leanring" class="col-sm-2 control-label">Learning Institute: </label>
					 <div class="col-sm-6">
                    <asp:TextBox ID="learning" CssClass="form-control" runat="server">
                    </asp:TextBox>
					</div>
				</div>
                  <br />
                  <br />

                        <!-- Image -->
                        <div class="form-group">
				            <label for="inputtype" class="col-sm-2 control-label">Profile Picture:</label>
                            <div class="col-sm-6">
				            <asp:FileUpload ID="myimage" CssClass="form-control" runat="server" /> 
                            <asp:Image ID="Image1" runat="server" /> 
                             </div>
				        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                    <asp:Button CssClass="btn btn-primary btn-lg" ID="updatebutton" role="button" runat="server" Text="Update Item" OnClick="updatebutton_Click" />
                       </div>
                         <br/>
                    <asp:Label ID="myinfo" runat="server" Text=""  Width="100px"></asp:Label>
                  <br/>
                
                </div>
    </section>

  
    <!-- Footer -->
    <footer class="text-center">
        <div class="footer-above">
            <div class="container">
                <div class="row">
                    <div class="footer-col col-md-4">
                        <h3>Contact Us</h3>
                        <p>72 University Creasent<br>Belfast, BT9 3GT</p>
                    </div>
                    <div class="footer-col col-md-4">
                        <h3>Around the Web</h3>
                        <ul class="list-inline">
                            <li>
                                <a href="#" class="btn-social btn-outline"><i class="fa fa-fw fa-facebook"></i></a>
                            </li>
                            <li>
                                <a href="#" class="btn-social btn-outline"><i class="fa fa-fw fa-google-plus"></i></a>
                            </li>
                            <li>
                                <a href="#" class="btn-social btn-outline"><i class="fa fa-fw fa-twitter"></i></a>
                            </li>
                            <li>
                                <a href="#" class="btn-social btn-outline"><i class="fa fa-fw fa-linkedin"></i></a>
                            </li>
                            <li>
                                <a href="#" class="btn-social btn-outline"><i class="fa fa-fw fa-dribbble"></i></a>
                            </li>
                        </ul>
                    </div>
                    <div class="footer-col col-md-4">
                        <h3>Who we are?</h3>
                        <p>Sell your unwanted items for cash, and give them a new home. Find all your university and further educational essentials for less!</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="footer-below">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        Copyright &copy; Your Website 2014
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- jQuery -->
    <script src="js/jquery.js"></script>

    <!-- Bootstrap Core JavaScript -->
    <script src="js/bootstrap.min.js"></script>

    <!-- Plugin JavaScript -->
    <script src="http://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>
    <script src="js/classie.js"></script>
    <script src="js/cbpAnimatedHeader.js"></script>

    <!-- Contact Form JavaScript -->
    <script src="js/jqBootstrapValidation.js"></script>
    <script src="js/contact_me.js"></script>

    <!-- Custom Theme JavaScript -->
    <script src="js/freelancer.js"></script>

    </form>
</body>
</html>


