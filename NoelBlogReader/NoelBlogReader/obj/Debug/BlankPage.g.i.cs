﻿

#pragma checksum "C:\Users\Noel\documents\visual studio 11\Projects\NoelBlogReader\NoelBlogReader\BlankPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "50C26A3C0FC5ED850A29050065A6FD6B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace NoelBlogReader
{
    public partial class BlankPage : Windows.UI.Xaml.Controls.Page
    {
        private Windows.UI.Xaml.Controls.TextBlock TitleText;
        private Windows.UI.Xaml.Controls.ListView ItemListView;
        private Windows.UI.Xaml.Controls.TextBlock PostTitleText;
        private Windows.UI.Xaml.Controls.WebView ContentView;
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///BlankPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            TitleText = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("TitleText");
            ItemListView = (Windows.UI.Xaml.Controls.ListView)this.FindName("ItemListView");
            PostTitleText = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("PostTitleText");
            ContentView = (Windows.UI.Xaml.Controls.WebView)this.FindName("ContentView");
        }
    }
}



