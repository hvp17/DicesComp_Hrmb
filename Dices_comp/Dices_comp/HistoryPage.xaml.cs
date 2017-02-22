using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dices_comp.Entities;
using Xamarin.Forms;

namespace Dices_comp
{
    public partial class HistoryPage : ContentPage
    {
        private ObservableCollection<string> rollSource = new ObservableCollection<string>();
        public HistoryPage(ObservableCollection<string> rolls)
        {
            rollSource = rolls;
            
            //InitializeComponent();
            Inticomp();
        }

        private void Inticomp()
        {
            StackLayout mainLayout = new StackLayout();
            StackLayout listViewLayout = new StackLayout();

            Button but = new Button();
            Button clearBtn = new Button();

            ListView historyView = new ListView();

            clearBtn.Text = "Clear";
            clearBtn.Clicked += (sender, args) => UpdateView();

            but.Text = "Return";
            but.Clicked += (sender, args) => Return();
            historyView.ItemsSource = rollSource;
            listViewLayout.Children.Add(historyView);

            mainLayout.Children.Add(listViewLayout);
            mainLayout.Children.Add(clearBtn);
            mainLayout.Children.Add(but);

            Content = mainLayout;
        }

        private void UpdateView()
        {
            
                rollSource.Clear();
            
        }

        private async void Return()
        {
            await Navigation.PopAsync();
        }
    }
}
