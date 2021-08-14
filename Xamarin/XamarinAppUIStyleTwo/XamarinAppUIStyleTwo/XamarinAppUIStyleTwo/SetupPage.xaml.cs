using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAppUIStyleTwo.ViewModels;

namespace XamarinAppUIStyleTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SetupPage : ContentPage
    {

        private bool agentActive = true;
        private bool controllerActive = false;
        bool _collapsed;
        double formHeight;
        public SetupPage()
        {
            InitializeComponent();
            formHeight = AgentForm.Height;
        }

        public async void Agent_Selected(object sender, EventArgs e)
        {
            if (controllerActive)
            {
                agentActive = true;
                var selection = RoleSelection;

                ControllerText.FontFamily = "OpenSansBold";
                await selection.TranslateTo(0, 0, 300, Easing.Linear);
                AgentText.FontFamily = "OpenSansExtraBold";

                agentActive = true;
                controllerActive = false;

                ControllerForm.IsVisible = false;
                await ControllerForm.FadeTo(0, 100);

                AgentForm.IsVisible = true;
                await AgentForm.FadeTo(1, 100);
            }
        }

        public async void Controller_Selected(object sender, EventArgs e)
        {
            if (agentActive)
            {
                agentActive = false;
                controllerActive = true;
                var firstWidth = this.AgentStack.Width;
                var secondWidth = this.ControllerStack.Width;
                var selection = this.RoleSelection;
                AgentText.FontFamily = "OpenSansBold";
                await selection.TranslateTo(firstWidth + roleGrid.ColumnSpacing, 0, 300, Easing.Linear);
                ControllerText.FontFamily = "OpenSansExtraBold";
                AgentForm.IsVisible = false;
                await AgentForm.FadeTo(0, 100);

                ControllerForm.IsVisible = true;
                await ControllerForm.FadeTo(1, 100);





            }
        }

        public async void Go_Clicked(object sender, EventArgs e)
        {
            
            // btn.IsEnabled = false;
            //btn.BackgroundColor = Color.Gray;
            /*AgentTitle.IsVisible = true;
             Title.IsVisible = false;
             BtnControl.IsVisible = false;

             AgentForm.IsVisible = false;
             AgentListView.IsVisible = true;*/
            //await AgentForm.RotateYTo(-90, 200);
            //AgentForm.RotationY = -270;
            //AgentForm.IsVisible = false;
            //AgentForm.RotateYTo(-360, 200);
            //AgentListView.IsVisible = true;
            //AgentListView.FadeTo(1, 100);
            //await AgentForm.TranslateTo(0, 0, 300);

            /* Forms.RotationY = -270;
             await AgentListView.RotateYTo(-90, 500, Easing.SpringIn);
             Forms.IsVisible = false;
             AgentListView.IsVisible = true;
             await AgentListView.RotateYTo(-360, 500, Easing.SpringOut);
             AgentListView.RotationY = 0;*/

            if (!_collapsed)
            {

                // await Forms.TranslateTo(0, -Forms.Bounds.Height, 300, Easing.Linear);
                //await Task.WhenAll(
                //    Forms.ScaleYTo(0, 500, Easing.Linear),
                //    // Forms.ScaleXTo(0, 1000, Easing.Linear),
                //     Forms.TranslateTo(0, -Header.Height, 1000, Easing.Linear)

                // );
                AgentListView.IsVisible = true;
                await AgentFormStack.TranslateTo(0, -Forms.Bounds.Height, 500, Easing.SinInOut);
                AgentFormStack.IsVisible = false;
                AgentForm.HeightRequest = 100;
                AgentList.IsVisible = true;
                //AgentListView.TranslateTo(0, 0, 3000, Easing.SinInOut);                
                _collapsed = true;

            }
            else
            {
                // await Forms.TranslateTo(0, 0, 300, Easing.Linear);
                //Forms.ScaleTo(1, 300, Easing.Linear);

                AgentList.IsVisible = false;
                AgentListView.IsVisible = false;
                AgentForm.HeightRequest = formHeight;

                AgentFormStack.IsVisible = true;
                await AgentFormStack.TranslateTo(0, -0, 500, Easing.SinInOut);
              
                _collapsed = false;

            }
            //AgentForm.RotationY = 0;
        }

        public async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Agent;
            bool choice = await DisplayAlert("", "Confirm Selection of Agent " + item.FirstName + " " + item.LastName + " ?", "OK", "Cancel");

            if(choice) await DisplayAlert("Agent Selected ", "You selected Agent " + item.FirstName + " " + item.LastName , "OK" );
        }

        private async void SubmitController(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ControllerHomePage());
        }
    }

}