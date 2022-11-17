using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; } = "Roster App";

        public Command UpdateApplicationCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
