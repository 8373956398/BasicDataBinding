using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicDataBinding
{
    public partial class MainPage : ContentPage
    {
        public List<Data> people = new List<Data>()
        {
            new Data{Name="praveen", Address="Delhi"},
            new Data{Name="abhinav", Address="nodia"},
            new Data{Name="Ashwini", Address="greaternodia"},
            new Data{Name="neelam", Address="Sagarpur"}
        };
        public MainPage()
        {
            InitializeComponent();
            mylist.ItemsSource = people;

        }
    }
}
