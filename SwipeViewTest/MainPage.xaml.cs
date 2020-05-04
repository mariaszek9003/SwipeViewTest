using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeViewTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool isClosed;
        public MainPage()
        {
            InitializeComponent();

            testButton.Clicked += TestButton_Clicked;
            testSwipeView.RightItems.Add(new SwipeItem()
            {
                Text = "C# test",
                BackgroundColor = Color.LightBlue,
            });
        }

        private void TestButton_Clicked(object sender, EventArgs e)
        {
            if (isClosed)
            {
                isClosed = false;
                testSwipeView.Open(OpenSwipeItem.RightItems);
            }
            else
            {
                isClosed = true;
                testSwipeView.Close();
            }

            testLabel.Text = string.Format("SwipeView is {0}", isClosed ? "closed" : "opened");
        }
    }
}
