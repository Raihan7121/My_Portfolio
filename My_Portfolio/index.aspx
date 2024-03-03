<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="My_Portfolio.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="UTF-8"/> 
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <link rel="stylesheet" type="text/css" href="~/EXTENSION/style.css"/>
        <title></title>
        <!--box icons link-->
        <link rel="stylesheet" href="https://unpkg.com/boxicons@latest/css/boxicons.min.css"/>

        <!--remix icons link -->
        <link href="https://cdn.jsdelivr.net/npm/remixicon@4.1.0/fonts/remixicon.css" rel="stylesheet"/>


        <!--google fonts link-->
        <link rel="preconnect" href="https://fonts.googleapis.com"/>
        <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
        <link href="https://fonts.googleapis.com/css2?family=Inter:wght@300;400;500;60 0;700;800;900&display=swap" rel="stylesheet"/>
        <script src="https://kit.fontawesome.com/bc9a31bc44.js" crossorigin="anonymous"></script>

        <link rel="stylesheet" href="https://unpkg.com/aos@next/dist/aos.css" />
</head>
<body>
    <form id="form1" runat="server">
            <header>
        <a href="#home" class="logo">RAI <span>HAN.</span></a>
        
        <div class="bx bx-menu" id="menu-icon"></div>

        <ul class="navlist">
            <li><a href="#home">Home</a></li>
            <li><a href="#about">About</a></li>
            <li><a href="#Projects">Projects</a></li>
            <li><a href="#achievement">Achievements</a></li>
            <li><a href="#contact">Contact</a></li>

        </ul>
                
        <div class="top-btnn">
            
            <a runat="server" id="Admin_login" class="btn">Admin Login</a>
            <a href="#contact" class="h-btn">Contact me</a>
        </div>

    </header>

    <section class="hero" id="home">
        <div class="main-content" data-aos="fade-in">
            <h4>Hi, There!</h4>
            <h1>I'm <span runat="server" id="About_name"></span></h1>
            <p runat="server" id="About_detail">
               
            </p>
            <div class="social">
                <a href="https://www.facebook.com/profile.php?id=100060307328465"><i class="fa-brands fa-facebook"></i></a>
                <a href="#"><i class="fa-brands fa-telegram"></i></a>
                <a href="#"><i class="fa-brands fa-linkedin"></i></a>
                <a href="#"><i class="fa-solid fa-envelope"></i></a>

            </div>

            <div class="main-btn">
                <a href="#" class="btn">Hire Me</a>
                <a href="#" class="btn btn2">DownLoad CV</a>
            </div>


        </div>

    </section>

    <!--about-->
    <section class="about" id="about">
        <div class="about-img" data-aos="zoom-in-down">
            <img src="EXTENSION/pic2.jpg"/>
        </div>

        <div class="about-text" data-aos="zoom-in-up">
            <h2>I am CS <span>Student</span> <br> & Web Developer </h2>
        <div class="exp-area">
            <p class="exp">
                Year:
                <span>3 Year</span>
            </p>
            <p class="exp">
                Specialty:
                <span>HTML, CSS, javaScript</span>
            </p>
            <p class="exp">
                Address:
                <span>Dhaka, Bangladesh</span>
            </p>
            <p class="exp">
                Email:
                <span>raihr7121@gmail.com</span>
            </p>
            <p class="exp">
                Phone:
                <span>01920771838</span>
            </p>
    
        </div>
            <a href="#Projects" class="btn">View All Projects</a>
        </div>

    </section>

    <!--service-->
    <section class="Projects" id="Projects">
        <div class="center-text" data-aos="fade-down">
            <h2>My <span>Projects</span></h2>
        </div>

        <div class="Services-content Portfolio-content" data-aos="zoom-in-up">
            <div class="box row">
                <img runat="server" id="Project1" >
                <h3 runat="server" id="Project1_name"></h3>
                <p runat="server" id="Project1_description">
                    
                </p>
                <a runat="server" id="Project1_github" >
                    Download now
                    <i class="fa-brands fa-github"></i>
                </a>
            </div>

            <div class="box row " id="bondhon">
                <img runat="server" id="Project2"  />
                <h3 runat="server" id="Project2_name"></h3>
                <p runat="server" id="Project2_description">

                </p>
                <a runat="server" id="Project2_github">
                    Download now
                    <i class="fa-brands fa-github"></i>


                </a>
            </div>

            <div class="box row">
                <img runat="server" id="Project3"/>
                <h3 runat="server" id="Project3_name"></h3>
                <p runat="server" id="Project3_description">
                </p>
                <a runat="server" id="Project3_github">
                    Download now
                    <i class="fa-brands fa-github"></i>


                </a>
            </div>
        </div>
    
    </section>

    <!--portfolio-->
    <section class="achievement portfolio" id="achievement">

        <div class="center-text" data-aos="fade-down">
            <h2>My <span>Achievements</span></h2>
        </div>

        <div class="Portfolio-content" data-aos="zoom-in-up">
            <div class="row">
                <img src="EXTENSION/sgipc.jpg"/>
                <div class="main-row">
                    <div class="row-text">
                        <h5>IKPC AWARD</h5>
                    </div>

                </div>
                
                <h4>Awarded BEST TEAM 2K20 for achieving position 11th place in IKPC-2023</h4>
            </div>
            

            <div class="row">
                <img src="EXTENSION/attendanc.jpg"/>
                <div class="main-row">
                    <div class="row-text">
                        <h5>PERFECT ATTENDANCE CERTIFICATE</h5>
                    </div>

                </div>
                
                <h4>Completed the 2years course of study at NDC with 100% attendance</h4>
            </div>

            

            <!-- <div class="row">
                <img src="my_photo.jpg">
                <div class="main-row">
                    <div class="row-text">
                        <h5>Website Design</h5>
                    </div>

                </div>
                <div class="row-icon">
                    <i class="fa-brands fa-github"></i>
                    
                </div>
                
            </div> -->

        </div>


    </section>

    <!--contact-->
    <section class="contact" id="contact">

        <div class="center-text" data-aos="fade-down">
            
            <h2>Contact<span>Me</span></h2>
        </div>

        <div class="contact-form" data-aos="zoom-in">
            
                <asp:TextBox ID="Name" placeholder="Your name" runat="server" required ></asp:TextBox>
                <asp:TextBox ID="Email" placeholder="Email Address.." runat="server" required></asp:TextBox>
                <textarea name="" id="Message_text" runat="server" cols="30" rows="10" placeholder="Write Message Here..." required ></textarea>
               
                <asp:Button ID="SubmitButton" runat="server" Text="Send Message" OnClick="Contact_Submit_Button" CssClass="btn" />

            
        </div> 

    </section> 

    <div class="footer">
        <div class="copyright">
            <p>2024 Raihan Hossain, All Rights Reserved.</p>            
        </div>
        <a href="#home" class="scroll-top">
            <i class="fa-solid fa-arrow-up"></i>  
        </a>
        
    </div>
   
    
    <!--js link-->
    <script src="script.js"></script>
    <script src="https://unpkg.com/aos@next/dist/aos.js"></script>
    <script>
      AOS.init({
            offset:300,
            duration: 1400,

      });
    </script>
    </form>
</body>
</html>
