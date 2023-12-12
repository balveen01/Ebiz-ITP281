<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DeliveryMap.aspx.cs" Inherits="DeliveryMap" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="viewport" content="initial-scale=1.0"/>
    <meta charset="utf-8"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge" />
    <title>Tracking Order</title>
    <link href="StyleCSS/Master.css" rel="stylesheet" type="text/css" />
    <style>
        #map{
            height: 500px;
            width: 500px;
            text-align:center;
        }
        .auto-style9 {
            width: 507px;
            height: 425px;
            text-align: left;
        }
                 .btnh {
  background-color: white; 
  color: black; 
  border: 2px solid fuchsia ;
  margin-top: 0px;
}

.btnh:hover {
  background-color: fuchsia;
  color: white;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="js" runat="server"></asp:Literal>
    <h1 class="text-center">Track Your Order Here!</h1>
    <div id="map" class="auto-style9">
    </div>
    

    <script type="text/javascript">
        function initMap()
        {
            //Map options
            var options = {
                zoom: 11,
                center: { lat: 1.379177, lng: 103.849749 }
            }
            // New map
            var map = new
            google.maps.Map(document.getElementById('map'), options);


            // Add marker
            var marker = new google.maps.Marker({
               position: { lat: 1.379177, lng: 103.849749 },
               map: map,
               
            });

            var infoWindow = new google.maps.InfoWindow({
                content: '<h1>Partiety Warehouse</h1>'
            });

            google.maps.event.addListener(marker,'click', function () {
              infoWindow.open(map, marker);
            });

          
            // my permenant code 
            addMarker({
                coords: { lat: 1.379177, lng: 103.849749 },
            });
            //make hardcoded code to become free soul
            addMarker1({
                coords: { lat: 1.3321, lng: 103.7744 },
            });
            addMarker2({
               coords: { lat: 1.4422, lng: 103.7859 },
            });
            addMarker3({
                coords: { lat: 1.3099, lng: 103.7775 },
            });


            // Add marker
            function addMarker(props) {
                var marker = new google.maps.Marker({
                    position: props.coords,
                    map: map,
                    title: 'PARTIETY WAREHOUSE'
               });
            }

            function addMarker1(props) {
                var marker = new google.maps.Marker({
                    position: props.coords,
                    map: map,
                    title: 'Order Number : 110 - Still in Warehouse.'
                });
            }

            function addMarker2(props) {
                var marker = new google.maps.Marker({
                    position: props.coords,
                    map: map,
                    title: 'Order Number : 100 - Delivered.'
                });
            }

            function addMarker3(props) {
                var marker = new google.maps.Marker({
                    position: props.coords,
                    map: map,
                    title: 'Order Number : 105 - Delivering In Progress.'
                });
            }
            //check content
            if (props.content)
            {
                if(props.content){
                    var infoWindow = new google.maps.InfoWindow({
                        content:props.content
                    });

                    marker.addListener('click', function(){
                        infoWindow.open(map, marker);
                    });
            }

        }
        //var getLocation = function (address) {
        //    var geocoder = new google.maps.Geocoder();

        //    geocoder.geocode({ 'address': address }, function (results, status) {

        //        if (status == google.maps.GeocoderStatus.OK) {
        //           var latitude = results[0].geometry.location.lat();
        //            var longitude = results[0].geometry.location.lng();
        //           alert(latitude);
        //       }
        //    });
        //}
        //getLocation('Singapore');

   } 
   </script>
    <script async defer
            src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD_gm--2RfX-dBBCk7mXva81u_Jl_CPvME&callback=initMap">

    </script>

    <asp:Button ID="btn_Home" CssClass="btnh" runat="server" OnClick="btn_Home_Click" Text="Back To Home" />
</asp:Content>

