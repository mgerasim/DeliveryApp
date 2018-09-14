using Foundation;
using System;
using UIKit;

namespace DeliveryApp.iOS
{
    public partial class RegViewController : UIViewController
    {
        public string emailAddress;

        public RegViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            registerEmailEditField.Text = emailAddress;
        }
    }
}