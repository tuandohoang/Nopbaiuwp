﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Newtonsoft.Json;
using T1808AHelloUWP.Entity;
using T1808AHelloUWP.Service;
using SQLitePCL;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1808AHelloUWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserInformation : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;

        public UserInformation()
        {
            Debug.WriteLine("Init userinformation.");
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
            this.Loaded += LoadUserInformation;
        }

        private async void LoadUserInformation(object sender, RoutedEventArgs e)
        {
            MemberCredential memberCredential = ProjectConfiguration.CurrentMemberCredential;
            if (ProjectConfiguration.CurrentMemberCredential == null)
            {
                memberCredential = await this._fileService.ReadMemberCredentialFromFile();
            }
            if (memberCredential == null)
            {
                this.Frame.Navigate(typeof(LoginPage));
            }

            if (memberCredential != null)
            {
                var member = this._memberService.GetInformation(memberCredential.token);
                Email.Text = member.email;
                Name.Text = member.firstName + " " + member.lastName;
            }
            LoadDatabase();
        }
        private void LoadDatabase()
        {
            // Get a reference to the SQLite database
            var conn = new SQLiteConnection("sqlitepcldemo.db");
            string sql =
                @"CREATE TABLE IF NOT EXISTS Customer (Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,Name VARCHAR( 140 ),City VARCHAR( 140 ),Contact VARCHAR( 140 ));";
            using (var statement = conn.Prepare(sql))
            {
                statement.Step();
            }

            try
            {
                using (var custstmt = conn.Prepare("INSERT INTO Customer (Name, City, Contact) VALUES (?, ?, ?)"))
                {
                    custstmt.Bind(1, "Hung");
                    custstmt.Bind(2, "hanoi");
                    custstmt.Bind(3, "alo");
                    custstmt.Step();
                }

            }
            catch (Exception ex)
            {
                // TODO: Handle error
            }



        }
    }

}
