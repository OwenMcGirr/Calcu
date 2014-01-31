using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Calcu
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        bool pls;
        bool mnus;
        bool dv;
        bool mult;
        decimal answer_dec;
        decimal dec;

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            { }
            else
            {
                dec = decimal.Parse(noarea.Text);
                pls = true;
                mnus = false;
                dv = false;
                mult = false;
                del.IsEnabled = false;
                noarea.Text = "";
                clr.IsEnabled = false;
                point.IsEnabled = true;
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                div.IsEnabled = false;
                multi.IsEnabled = false;
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            { }
            else
            {
                dec = decimal.Parse(noarea.Text);
                pls = false;
                mnus = true;
                dv = false;
                mult = false;
                del.IsEnabled = false;
                noarea.Text = "";
                clr.IsEnabled = false;
                point.IsEnabled = true;
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                div.IsEnabled = false;
                multi.IsEnabled = false;
            }
        }

        private void multi_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            { }
            else
            {
                dec = decimal.Parse(noarea.Text);
                pls = false;
                mnus = false;
                dv = false;
                mult = true;
                del.IsEnabled = false;
                noarea.Text = "";
                clr.IsEnabled = false;
                point.IsEnabled = true;
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                div.IsEnabled = false;
                multi.IsEnabled = false;
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            { }
            else
            {
                dec = decimal.Parse(noarea.Text);
                pls = false;
                mnus = false;
                dv = true;
                mult = false;
                del.IsEnabled = false;
                noarea.Text = "";
                clr.IsEnabled = false;
                point.IsEnabled = true;
                plus.IsEnabled = false;
                minus.IsEnabled = false;
                div.IsEnabled = false;
                multi.IsEnabled = false;
            }
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            { }
            else
            {
                if (pls)
                {
                    answer_dec = dec + decimal.Parse(noarea.Text);
                    noarea.Text = answer_dec.ToString();
                    if (!noarea.Text.Contains("."))
                    {
                        point.IsEnabled = true;
                    }
                    pls = false;
                    mnus = false;
                    dv = false;
                    mult = false;
                    answer_dec = 0;
                    plus.IsEnabled = true;
                    minus.IsEnabled = true;
                    div.IsEnabled = true;
                    multi.IsEnabled = true;
                }
                if (mnus)
                {
                    answer_dec = dec - decimal.Parse(noarea.Text);
                    noarea.Text = answer_dec.ToString();
                    if (!noarea.Text.Contains("."))
                    {
                        point.IsEnabled = true;
                    }
                    pls = false;
                    mnus = false;
                    dv = false;
                    mult = false;
                    answer_dec = 0;
                    plus.IsEnabled = true;
                    minus.IsEnabled = true;
                    div.IsEnabled = true;
                    multi.IsEnabled = true;
                }
                if (dv)
                {
                    try
                    {
                        answer_dec = dec / decimal.Parse(noarea.Text);
                        noarea.Text = answer_dec.ToString();
                        if (!noarea.Text.Contains("."))
                        {
                            point.IsEnabled = true;
                        }
                    }
                    catch (System.DivideByZeroException)
                    {
                        noarea.Text = "Error";
                    }
                    pls = false;
                    mnus = false;
                    dv = false;
                    mult = false;
                    answer_dec = 0;
                    plus.IsEnabled = true;
                    minus.IsEnabled = true;
                    div.IsEnabled = true;
                    multi.IsEnabled = true;
                }
                if (mult)
                {
                    answer_dec = dec * decimal.Parse(noarea.Text);
                    noarea.Text = answer_dec.ToString();
                    if (!noarea.Text.Contains("."))
                    {
                        point.IsEnabled = true;
                    }
                    pls = false;
                    mnus = false;
                    dv = false;
                    mult = false;
                    answer_dec = 0;
                    plus.IsEnabled = true;
                    minus.IsEnabled = true;
                    div.IsEnabled = true;
                    multi.IsEnabled = true;
                }
            }
        }

        private void clr_Click(object sender, RoutedEventArgs e)
        {
            pls = false;
            mnus = false;
            mult = false;
            dv = false;
            dec = 0;
            noarea.Text = "";
            answer_dec = 0;
            clr.IsEnabled = false;
            point.IsEnabled = true;
            del.IsEnabled = false;
            plus.IsEnabled = true;
            minus.IsEnabled = true;
            div.IsEnabled = true;
            multi.IsEnabled = true;
        }

        private void Page_SizeChanged_1(object sender, SizeChangedEventArgs e)
        {
            if (ApplicationView.Value == ApplicationViewState.Snapped)
            {
                ttle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                noarea.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b1.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b2.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b3.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b4.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b5.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b6.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b7.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b8.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b9.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                b0.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                point.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                clr.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                del.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                plus.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                minus.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                multi.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                div.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                equals.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
                snappedttle.Visibility = Windows.UI.Xaml.Visibility.Visible;
            }
            else
            {
                ttle.Visibility = Windows.UI.Xaml.Visibility.Visible;
                noarea.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b1.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b2.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b3.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b4.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b5.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b6.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b7.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b8.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b9.Visibility = Windows.UI.Xaml.Visibility.Visible;
                b0.Visibility = Windows.UI.Xaml.Visibility.Visible;
                point.Visibility = Windows.UI.Xaml.Visibility.Visible;
                clr.Visibility = Windows.UI.Xaml.Visibility.Visible;
                del.Visibility = Windows.UI.Xaml.Visibility.Visible;
                plus.Visibility = Windows.UI.Xaml.Visibility.Visible;
                minus.Visibility = Windows.UI.Xaml.Visibility.Visible;
                multi.Visibility = Windows.UI.Xaml.Visibility.Visible;
                div.Visibility = Windows.UI.Xaml.Visibility.Visible;
                equals.Visibility = Windows.UI.Xaml.Visibility.Visible;
                snappedttle.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "1";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "2";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "3";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "4";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "5";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "6";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "7";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "8";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "9";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void b0_Click(object sender, RoutedEventArgs e)
        {
            noarea.Text = noarea.Text + "0";
            del.IsEnabled = true;
            clr.IsEnabled = true;
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            var text = noarea.Text;
            if (noarea.Text == "")
            { }
            else
            {
                string sub = text.Substring(text.Length - 1);
                if (!noarea.Text.Contains("."))
                {
                    point.IsEnabled = true;
                }
                noarea.Text = text.Remove(text.Length - 1);
            }
            if (noarea.Text == "")
            {
                del.IsEnabled = false;
                clr.IsEnabled = false;
            }
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (noarea.Text == "")
            {
                noarea.Text = "0";
            }
            noarea.Text = noarea.Text + ".";
            del.IsEnabled = true;
            clr.IsEnabled = true;
            point.IsEnabled = false;
        }
    }
}
