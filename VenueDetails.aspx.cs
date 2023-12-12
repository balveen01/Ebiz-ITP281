using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VenueDetails : System.Web.UI.Page
{
    Venue prod = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        Venue aVenue = new Venue();
        // Get Product ID from querystring
        string venueId = Request.QueryString["venueId"].ToString();
        prod = aVenue.getVenue(venueId);

        lbl_VenueName.Text = prod.venue_name;
        lbl_VenueDesc.Text = prod.venue_desc;
        lbl_VenueCap.Text = prod.venue_cap.ToString("c");
        img_Venue.ImageUrl = "~\\Images\\" + prod.venue_img;
        lbl_VenueLink.Text = prod.venue_link;

        lbl_VenueCap.Text = prod.venue_cap.ToString();
        lbl_VenueId.Text = venueId.ToString();
    }

    protected void lbl_VenueLink_Click(object sender, EventArgs e)
    {
        Response.Redirect(lbl_VenueLink.Text);
    }
}