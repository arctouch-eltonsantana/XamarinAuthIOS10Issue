using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Auth;
using Xamarin.Forms;

namespace XamarinAuthIssue
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        OAuth2Authenticator auth;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                auth = new OAuth2Authenticator
            (
                clientId: "",
                clientSecret: "",
                scope: "r_liteprofile",
                authorizeUrl: new Uri("https://www.linkedin.com/oauth/v2/authorization"),
                redirectUrl: new Uri(""),
                accessTokenUrl: new Uri("https://www.linkedin.com/oauth/v2/accessToken"),
                getUsernameAsync: null,
                isUsingNativeUI: false
            )
                {
                    ShowErrors = true,
                    DoNotEscapeScope = false,
                    AccessTokenName = "oauth2_access_token"
                };

                auth.Completed += OnAuthenticationCompleted;
                auth.Error += OnAuthenticationFailed;

                var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
                presenter.Login(auth);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void OnAuthenticationCompleted(object sender, AuthenticatorCompletedEventArgs e)
        {
            DetachAuthEvents(sender as OAuth2Authenticator);

            if (e.IsAuthenticated)
            {
                Debug.WriteLine("Authenticated");
            }
            else
            {
                Debug.WriteLine(e.ToString());
            }
        }

        private void DetachAuthEvents(OAuth2Authenticator authenticator)
        {
            if (authenticator != null)
            {
                authenticator.Completed -= OnAuthenticationCompleted;
                authenticator.Error -= OnAuthenticationFailed;
            }
        }

        private void OnAuthenticationFailed(object sender, AuthenticatorErrorEventArgs e)
        {
            Debug.WriteLine($"Error: {e.Message}");
        }
    }
}
