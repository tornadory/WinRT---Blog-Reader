﻿

#pragma checksum "C:\Users\Noel\documents\visual studio 11\Projects\NoelBlogReader\NoelBlogReader\SplitPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F9F08210F430EC6D87793B8E9D60958A"
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
    public partial class SplitPage : NoelBlogReader.Common.LayoutAwarePage
    {
        private NoelBlogReader.Common.LayoutAwarePage pageRoot;
        private Windows.UI.Xaml.Data.CollectionViewSource itemsViewSource;
        private Windows.UI.Xaml.Controls.ColumnDefinition primaryColumn;
        private Windows.UI.Xaml.Controls.Grid titlePanel;
        private Windows.UI.Xaml.Controls.ScrollViewer itemListScrollViewer;
        private Windows.UI.Xaml.Controls.ScrollViewer itemDetail;
        private Windows.UI.Xaml.Controls.Grid itemDetailGrid;
        private Windows.UI.Xaml.Controls.TextBlock itemTitle;
        private Windows.UI.Xaml.Controls.Border contentViewBorder;
        private Windows.UI.Xaml.Controls.WebView contentView;
        private Windows.UI.Xaml.Shapes.Rectangle contentViewRect;
        private Windows.UI.Xaml.Controls.ListView itemListView;
        private Windows.UI.Xaml.Controls.Button backButton;
        private Windows.UI.Xaml.Controls.TextBlock pageTitle;
        private Windows.UI.Xaml.VisualState FullScreenLandscape;
        private Windows.UI.Xaml.VisualState Filled;
        private Windows.UI.Xaml.VisualState FullScreenPortrait;
        private Windows.UI.Xaml.VisualState FullScreenPortrait_Detail;
        private Windows.UI.Xaml.VisualState Snapped;
        private Windows.UI.Xaml.VisualState Snapped_Detail;
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///SplitPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (NoelBlogReader.Common.LayoutAwarePage)this.FindName("pageRoot");
            itemsViewSource = (Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("itemsViewSource");
            primaryColumn = (Windows.UI.Xaml.Controls.ColumnDefinition)this.FindName("primaryColumn");
            titlePanel = (Windows.UI.Xaml.Controls.Grid)this.FindName("titlePanel");
            itemListScrollViewer = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("itemListScrollViewer");
            itemDetail = (Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("itemDetail");
            itemDetailGrid = (Windows.UI.Xaml.Controls.Grid)this.FindName("itemDetailGrid");
            itemTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("itemTitle");
            contentViewBorder = (Windows.UI.Xaml.Controls.Border)this.FindName("contentViewBorder");
            contentView = (Windows.UI.Xaml.Controls.WebView)this.FindName("contentView");
            contentViewRect = (Windows.UI.Xaml.Shapes.Rectangle)this.FindName("contentViewRect");
            itemListView = (Windows.UI.Xaml.Controls.ListView)this.FindName("itemListView");
            backButton = (Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            FullScreenLandscape = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenLandscape");
            Filled = (Windows.UI.Xaml.VisualState)this.FindName("Filled");
            FullScreenPortrait = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait");
            FullScreenPortrait_Detail = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait_Detail");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
            Snapped_Detail = (Windows.UI.Xaml.VisualState)this.FindName("Snapped_Detail");
        }
    }
}



