using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;

namespace Roster.Client.ViewModel
{
    class HomeViewModel
    {
        public string Title { get; set; }

        public Command UpdateApplicationCommand;
    }
}
