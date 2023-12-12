<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <title>PARTIETY</title>

<style type="text/css">
    .auto-style1 {
    text-align: right;
    }
     .auto-style2 {
     text-align: left;
     }
     * {box-sizing:border-box}

    /* Slideshow container */
    .slideshow-container {
    max-width: 1000px;
    position: relative;
    margin: auto;
    }

    /* Hide the images by default */
    .mySlides {
    display: none;
    }

    /* Next & previous buttons */
    .prev, .next {
    cursor: pointer;
    position: absolute;
    top: 50%;
    width: auto;
    margin-top: -22px;
    padding: 16px;
    color: #8080ff;
    font-weight: bold;
     font-size: 18px;
    transition: 0.6s ease;
    border-radius: 0 3px 3px 0;
    user-select: none;
    }

    /* Position the "next button" to the right */
    .next {
    right: 0;
    border-radius: 3px 0 0 3px;
    }

    /* On hover, add a black background color with a little bit see-through */
    .prev:hover, .next:hover {
     background-color: rgb(179, 179, 179);
     }

    /* Caption text */
    .text {
     color: #000000;
     font-size: 15px;
     padding: 8px 12px;
     position: absolute;
     bottom: 8px;
     width: 100%;
     text-align: center;
     }

    /* Number text (1/3 etc) */
    .numbertext {
    color: #8080ff;
    font-size: 12px;
    padding: 8px 12px;
    position: absolute;
    top: 0;
    }
    
    /* The dots/bullets/indicators */
    .dot {
    cursor: pointer;
    height: 15px;
    width: 15px;
    margin: 0 2px;
    background-color: #bbb;
    border-radius: 50%;
    display: inline-block;
    transition: background-color 0.6s ease;
    }

    .active, .dot:hover {
    background-color: #717171;
    }

    /* Fading animation */
    .w3fade {
    -webkit-animation-name: fade;
     -webkit-animation-duration: 1.5s;
     animation-name: fade;
     animation-duration: 1.5s;
    }

    @-webkit-keyframes w3fade {
    from {opacity: .4} 
    to {opacity: 1}
    }

    @keyframes w3fade {
    from {opacity: .4} 
    to {opacity: 1}
    } 
</style>


</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      

    
    <div class="slideshow-container">
            <div class="mySlides w3fade">
                <div class="numbertext">1/4</div>
                <img src="pics/mickey.png" alt="Mickey Mouse Theme" style="height: 600px; width:100%"/>
                <div class="text">Mickey Mouse Theme</div>

            </div>

            <div class="mySlides w3fade">
                <div class="numbertext">2/4</div>
                <img src="pics/rose_theme.png" alt="Rose Theme" style="height: 600px; width:100%"/>
                <div class="text">Rose Theme</div>
            </div>

            <div class="mySlides w3fade">
                <div class="numbertext">3/4</div>
                <img src="pics/unicorn.png" alt="Unicorn Balloons" style="height: 600px; width:100%"/>
                <div class="text">Unicorn Balloons</div>

            </div>

            <div class="mySlides w3fade">
                <div class="numbertext">4/4</div>
                <img src="pics/vampire.png" alt="Vampire Theme" style="height: 600px; width:100%"/>
                <div class="text">Vampire Theme</div>

            </div>
  
              <div style="text-align:center">
                <span class="dot"></span> 
                <span class="dot"></span> 
                <span class="dot"></span> 
                <span class="dot"></span>
                </div>
            <br/>
            
        </div>
        <script type="text/javascript">
            var slideIndex = 0;
            showSlides();

            function showSlides() {
                var i;
                var slides = document.getElementsByClassName("mySlides");
                for (i = 0; i < slides.length; i++) {
                    slides[i].style.display = "none";
                }
                slideIndex++;
                //if (slideIndex > slides.length) { slideIndex = 1 }
                slides[slideIndex - 1].style.display = "block";
                setTimeout(showSlides, 10000); // Change image every 10 seconds
            }
        </script>
</asp:Content>



