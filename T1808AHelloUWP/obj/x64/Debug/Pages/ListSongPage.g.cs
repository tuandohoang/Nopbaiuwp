﻿#pragma checksum "C:\Users\Dell\Desktop\t1808a-uwp-master (2)\t1808a-uwp-master\T1808AHelloUWP\Pages\ListSongPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1A065AFEA41D7BF2D782F8350D7776B9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace T1808AHelloUWP.Pages
{
    partial class ListSongPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\ListSongPage.xaml line 47
                {
                    this.MyMediaElement = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 3: // Pages\ListSongPage.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.Previous;
                }
                break;
            case 4: // Pages\ListSongPage.xaml line 35
                {
                    this.PlayAndPauseButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.PlayAndPauseButton).Click += this.Play;
                }
                break;
            case 5: // Pages\ListSongPage.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element5).Click += this.Next;
                }
                break;
            case 6: // Pages\ListSongPage.xaml line 44
                {
                    this.NowPlayingText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\ListSongPage.xaml line 14
                {
                    this.ListViewSong = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10: // Pages\ListSongPage.xaml line 24
                {
                    global::Windows.UI.Xaml.Controls.SymbolIcon element10 = (global::Windows.UI.Xaml.Controls.SymbolIcon)(target);
                    ((global::Windows.UI.Xaml.Controls.SymbolIcon)element10).DoubleTapped += this.UIElement_OnDoubleTapped;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

