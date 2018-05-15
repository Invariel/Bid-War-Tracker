using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bid_War_Tracker
{
    public partial class BidWarTracker : Form
    {
        const String TWITCH_CLIENT_ID = "tat6p79u4bgn9eo0mbpns6jjhkilnv";
        const String TWITCH_OAUTH_URI = "https://invariel.ca/webauth/donation_auth_twitch.html";

        const String STREAMLABS_CLIENT_ID = "fcKZK5vLNV51ComT5OkbAMFHGlZYUCqUlVvRRKgn";
        const String STREAMLABS_OAUTH_URI = "https://invariel.ca/webauth/donation_auth_streamlabs.html";

        public BidWarTracker()
        {
            InitializeComponent();

            btn_StreamLabsOAuth.Click += StreamLabsOauth;
            btn_TwitchOAuth.Click += TwitchOauth;
        }

        private void StreamLabsOauth(object sender, EventArgs e)
        {
            String uri = String.Format("{0}?{1}={2}&{3}={4}&{5}={6}&{7}={8}",
                                       "https://streamlabs.com/api/v1.0/authorize",
                                       "response_type", "code",
                                       "client_id", STREAMLABS_CLIENT_ID,
                                       "redirect_url", STREAMLABS_OAUTH_URI,
                                       "scope", "donations.read");
            System.Diagnostics.Process.Start(uri);
        }

        private void TwitchOauth(object sender, EventArgs e)
        {
            String uri = String.Format("{0}?{1}={2}&{3}={4}&{5}={6}&{7}={8}",
                                       "https://id.twitch.tv/oauth2/authorize",
                                       "client_id", TWITCH_CLIENT_ID,
                                       "redirect_uri", TWITCH_OAUTH_URI,
                                       "response_type", "token",
                                       "scope", "channel_subscriptions");

            System.Diagnostics.Process.Start(uri);
        }
    }
}
