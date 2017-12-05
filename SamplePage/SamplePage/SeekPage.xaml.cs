using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SamplePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeekPage : ContentPage
    {
        public SeekPage()
        {
            InitializeComponent();
        }

        private void OnSelectedIndexChanged(object sender, EventArgs eventArgs)
        { 
            var picker2 = new Picker { Title = "Select a monkey" };
            if (this.picker.SelectedIndex == 0)
            {
                picker2.Items.Add("Baboon");
                picker2.Items.Add("Capuchin Monkey");
                picker2.Items.Add("Blue Monkey");
                picker2.Items.Add("Squirrel Monkey");
                picker2.Items.Add("Golden Lion Tamarin");
                picker2.Items.Add("Howler Monkey");
                picker2.Items.Add("Japanese Macaque");
            }
            

        }
    }


}