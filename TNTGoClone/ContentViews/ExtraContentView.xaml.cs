﻿using System.Threading.Tasks;
using TNTGoClone.Models;
using TNTGoClone.ViewModels;
using Xamarin.Forms;

namespace TNTGoClone.ContentViews
{
    public partial class ExtraContentView : ContentView
    {
        public ExtraContentView()
        {
            InitializeComponent();
        }

        protected override async void OnBindingContextChanged()
        {
            await OnBindingContextChangedAsync();
        }

        private async Task OnBindingContextChangedAsync()
        {
            base.OnBindingContextChanged();

            if (BindingContext is AppPage appPage)
                if (appPage.ViewModel is ExtraViewModel viewModel)
                    await viewModel.InitializeAsync();
        }
    }
}
