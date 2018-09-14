﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DeliveryApp.Droid
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText emailEditText;
        EditText passwordEditText;
        EditText confirmPasswordEditText;
        Button regusterUserButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Register);

            emailEditText = FindViewById<EditText>(Resource.Id.registerEmailEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.registerPasswordEditText);
            confirmPasswordEditText = FindViewById<EditText>(Resource.Id.confirmPasswordEditText);
            regusterUserButton = FindViewById<Button>(Resource.Id.registerUserButton);

            regusterUserButton.Click += RegusterUserButton_Click;

            string email = Intent.GetStringExtra("email");
            emailEditText.Text = email;
        }

        void RegusterUserButton_Click(object sender, EventArgs e)
        {
            
        }

    }
}
