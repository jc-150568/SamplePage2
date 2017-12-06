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
        {/*
            if (this.picker.SelectedIndex == 0)
            {
                picker2.Items.Clear();
                picker2.Items.Add("Baboon");
                picker2.Items.Add("Capuchin Monkey");
                picker2.Items.Add("Blue Monkey");
                picker2.Items.Add("Squirrel Monkey");
                picker2.Items.Add("Golden Lion Tamarin");
                picker2.Items.Add("Howler Monkey");
                picker2.Items.Add("Japanese Macaque");
            }

            if (this.picker.SelectedIndex == 1)
            {
                picker2.Items.Clear();
                picker2.Items.Add("2Baboon");
                picker2.Items.Add("2Capuchin Monkey");
                picker2.Items.Add("2Blue Monkey");
                picker2.Items.Add("2Squirrel Monkey");
                picker2.Items.Add("2Golden Lion Tamarin");
                picker2.Items.Add("2Howler Monkey");
                picker2.Items.Add("2Japanese Macaque");
            }

            if (this.picker.SelectedIndex == 2)
            {
                picker2.Items.Clear();
                picker2.Items.Add("3Baboon");
                picker2.Items.Add("3Capuchin Monkey");
                picker2.Items.Add("3Blue Monkey");
                picker2.Items.Add("3Squirrel Monkey");
                picker2.Items.Add("3Golden Lion Tamarin");
                picker2.Items.Add("3Howler Monkey");
                picker2.Items.Add("3Japanese Macaque");
            }*/
        }
    }


}