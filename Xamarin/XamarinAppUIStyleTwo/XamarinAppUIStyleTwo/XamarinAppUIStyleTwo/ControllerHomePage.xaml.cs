using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;
using XamarinAppUIStyleTwo.ViewModels;

namespace XamarinAppUIStyleTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControllerHomePage : ContentPage
    {
        private bool _addAgentFormToggle, _editAgentFormToggle;
        public ControllerHomePage()
        {
            InitializeComponent();

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
          
        }

        private void AddNewAgent(object sender, EventArgs e)
        {
            if (_addAgentFormToggle)
            {
                NewAgentForm.IsVisible = false;
                _addAgentFormToggle = false;
            }
            else
            {
                NewAgentForm.IsVisible = true;
                _addAgentFormToggle = true;
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as ControllerAgentsViewModel;
            AgentListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                AgentListView.ItemsSource = _container.AgentList;
            }
            else
            {
                AgentListView.ItemsSource = _container.AgentList.Where(i => i.FirstName.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            AgentListView.EndRefresh();
        }

      

        private void EditAgent(object sender, EventArgs e)
        {

            if (_editAgentFormToggle)
            {
                EditAgentForm.IsVisible = false;
                _editAgentFormToggle = false;
            }
            else
            {
                EditAgentForm.IsVisible = true;
                _editAgentFormToggle = true;
            }

        }

        
    }
}