using GateballChaveamento.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GateballChaveamento.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}