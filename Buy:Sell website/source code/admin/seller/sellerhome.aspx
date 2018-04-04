<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sellerhome.aspx.cs" Inherits="admin_seller_sellerhome" %>

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
    <link href="../../css/bootstrap.min.css" rel="stylesheet">

    <!-- Custom CSS -->
    <link href="../../css/freelancer.css" rel="stylesheet">

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
    <div id="page-top" class="index">

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
                        <a href="sellerhome.aspx">Seller Homepage</a>
                    </li>
                    <li class="page-scroll">
                        <a href="selleraccount.aspx">My Account</a>
                    </li>
                    <li class="page-scroll">
                        <a href="sellitems.aspx">Sell Items</a>
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

    <!-- Sign in Section -->
    <section id="portfolio">
        <div class="container">
            <div class="row">
                 <div class="col-lg-12 text-center">
                    <h2>Hello, Seller</h2>
                
                    <h2>Your Items</h2>
                     <h3>Click on the images to edit items </h3>
                    
                      <div class="col-md-4">
                            <div class="container">

            
            <asp:SqlDataSource ID="item" runat="server" 
            ConnectionString="<%$ ConnectionStrings:connect %>" 
                SelectCommand="SELECT items.ID, items.name, items.description, items.price, items.image, typeofcategoryID.category FROM items INNER JOIN typeofcategoryID ON items.
                typeofcategoryID = typeofcategoryID.ID ORDER BY items.price DESC">
            
            </asp:SqlDataSource>
                 <asp:ListView ID="listofitems" runat="server" DataSourceID="item">
                   
                     <EmptyDataTemplate>
                         <span>No data was returned.</span>
                     </EmptyDataTemplate>
                     
                     <ItemTemplate>
                      <div class="col-md-4">

                    
                          <div class="col-md-8 pad2 lead">
                             
                           <p><span> <asp:Label Text='<%# Eval("name") %>' runat="server" ID="namelabel" />
                               
                           <asp:HyperLink ID="itemhyperlink" runat="server" NavigateUrl='<%#"edititem.aspx?itemid="+ Eval("ID")%>'>
                         <div class="imgright">
                             <asp:Image ID="imagepic" runat="server" ImageURL='<%# "../../../files/"+Eval("image") %>' width="200px" />
                         </div></asp:HyperLink>
          
                          
                        </span>
                               <span>Price:
                                   <asp:Label Text='<%# Eval("price") %>' runat="server" ID="pricelabel" />
                               </span>
                               <span>Category: 
                                   <asp:Label Text='<%# Eval("category")%>' runat="server" ID="categorylabel" />
                               </span>
                               <br />
                           </p>
                                  
                        </div>
                     
                          </div>
                         
                    </ItemTemplate></asp:ListView>
                                         
                          <div class="col-md-8 pad2 lead">

                         <div class="col-md-8">

                <div class ="container">

                                     </div>
                </div>
                </div>
                </div>
            </section>
        </div>
    

    <!-- About Section -->
    <section class="success" id="about">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>About Us</h2>
                    <hr class="star-light">
                </div>
            </div>
            <div class="row">
                <div class="col-lg-4 col-lg-offset-2">
                    <p>Elmtree, buy and sell allows you to buy all your Further Education essentials for less!</p>
                </div>
                <div class="col-lg-4">
                    <p>Sell your unwanted books, technology and other items, for cash and give them a new home!</p>
                </div>
            </div>
        </div>
    </section>

    <!-- Contact Section -->
    <section id="contact">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">

                    

                    <h2>Sell Items</h2>
                    <p>Sell your unwanted items</p>
                    <p><a class="btn btn-success" href="sellitems.aspx" role="button">Sell Items Now &raquo;</a></p>
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
</form>
</div>
</html>
