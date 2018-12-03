using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace HelloXamlBinding
{
    public class MainForm : Form
    {
        public MainForm()
        {
            XamlReader.Load(this);
            Create();
        }
        private void Create() {
            var textBox = new TextBox();
            textBox.TextBinding.BindDataContext((UrlModel m) => m.Url);

            Content = textBox;

            // set the view model for the form and all child controls
            var model = new UrlModel { Url = "https://www.yahoo.co.jp" };
            DataContext = model;
        }
    }
}
