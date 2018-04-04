<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signin.aspx.cs" Inherits="signin" %>

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
        <form runat="server">

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

    <!-- Sign in Section -->
    <section id="portfolio">
        <div class="container">
            <div class="row">
                 <div class="col-lg-12 text-center">
                    <h2>Buyer Sign In</h2>

                     <!--------------------------------Buyer Sign In ----------------------------------->
         <div class ="entry">
             <p>Username:
                <asp:TextBox ID="username" runat="server" type="" placeholder="username" class="form-control" />
                   </p>
                         <p>Password:
                    <asp:TextBox ID="password"  runat="server"  type="" placeholder="password" class="form-control" />
                    </p>
             
                 
                 <asp:Button ID="setsession" runat="server" Text="Buyer Sign In" OnClick="setsession_Click" class="btn btn-success" />
             
                
         </div>
                     <br />
                    <br />
               <p><a class="btn btn-success" href="picksignup.aspx" role="button">Sign Up &raquo;</a></p>
                    
                
                    
                     <!----------------------------------Seller Sign In --------------------------------->
                <div class="entry">     
                <h2>Seller Sign In</h2>
                     <p>Username:
                         <asp:TextBox ID="uname" runat="server" type="" placeholder="username" class="form-control" />
                     </p>
                    <p>Password:
                    <asp:TextBox ID="pword" runat="server" type="" placeholder="password" class="form-control" />
                    </p>
                    <asp:Button ID ="setsess" runat="server" Text="Seller Sign In" OnClick="setsess_Click" class="btn btn-success" />
                    <br />
                    <br />
                <p><a class="btn btn-success" href="picksignup.aspx" role="button">Sign Up &raquo;</a></p>




                    <!------------------------------------------ Admin Sign In ------------------------------------->
                    <div class="entry"> 
                        <br />
                        <br />
                        <br />
                            
                <h2>Admin Sign In</h2>
                     <p>Username:
                         <asp:TextBox ID="adminname" runat="server" type="" placeholder="username" class="form-control" />
                     </p>
                    <p>Password:
                    <asp:TextBox ID="adpassword" runat="server" type="" placeholder="password" class="form-control" />
                    </p>
                    <asp:Button ID ="in" runat="server" Text="Admin Sign In" OnClick="in_Click" class="btn btn-success" />
                    <br />
                    <br />
                </div>
                </div>
            </div>
            </div>

        
    </section>

       

    

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
