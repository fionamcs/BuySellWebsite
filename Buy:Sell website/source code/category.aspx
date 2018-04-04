<%@ Page Language="C#" AutoEventWireup="true" CodeFile="category.aspx.cs" Inherits="category" %>

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
    <link href="css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="css/freelancer.css" rel="stylesheet">

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
    <body id="page-top" class="index">

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
                        <a href="signin.aspx">Sign In</a>
                    </li>
                    <li class="page-scroll">
                        <a href="picksignup.aspx">Sign Up</a>
                    </li>
                    <li class="page-scroll">
                        <a href="shop.aspx">Items for Sale</a>
                    </li>
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
                <div class="col-lg-12">
                    <div class="intro-text">
                        <span class="name">Elmtree</span>
                        <hr class="star-light">
                        <span class="skills">Buy and Sell</span>
                    </div>
                </div>
            </div>
        </div>
    </header>


    <!-- Contact Section -->
    <section id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">

                        <!-- insert catergy stuff here -->
                       	
                    <asp:SqlDataSource ID="genreresult" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:connect %>" 
                            SelectCommand="SELECT [ID], [name], [description], [price], [typeofcategoryID], [image] 
                            FROM [items] WHERE ([typeofcategoryID] = @Id)">
                            <SelectParameters>
                                <asp:QueryStringParameter Name="Id" QueryStringField="categorytype" Type="Int16" />
                            </SelectParameters>
                        </asp:SqlDataSource>

						<div class="entry">

						</div>
						
					</div>



                    <asp:ListView ID="displaygenre" runat="server" DataSourceID="genreresult">
                     
                        <ItemTemplate>
                            <br />
                            Name:
                            <asp:HyperLink ID="HyperLink1" runat="server"
                                 NavigateUrl='<%# "item.aspx?itemid="+ Eval("ID") %>' >
                                 <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("name") %>' />
                                <div class="imgright">
                             <asp:Image ID="imagepic" runat="server" ImageURL='<%# "../files/"+Eval("image") %>' width="200px" />
                            </asp:HyperLink>
                            <br />
                            Description:
                            <asp:Label ID="descriptionLabel" runat="server" Text='<%# Eval("description") %>' />
                            <br />
                            Price:
                            <asp:Label ID="priceLabel" runat="server" Text='<%# Eval("price") %>' />
                            <br /><br /></span>
                        </ItemTemplate>
                    
                    </asp:ListView>
                        
                     
                    </div>
					</div>                      
					</div>
              
    </section>


        <!------------------------------------------------------------------------------------------------------>
        <!------------------------------------------------------------------------------------------------------>
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

</body>
</html>