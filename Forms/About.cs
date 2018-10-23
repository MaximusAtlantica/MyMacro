using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyMacro.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Shown(object sender, EventArgs e)
        {
            LinkLabel.Link links = new LinkLabel.Link();
            links.LinkData = "https://github.com/MaximusAtlantica/MyMacro";
            link_Credit.Links.Add(links);
            string Message = "Fungsi :\n" +
                "• F11 - Pilih Target / F12 - On Off\n" +
                "• Scroll Down = Search All (tombol X)\n" +
                "• Scroll Up = Skip (tombol ~)\n" +
                "• Scroll Click = 1 (tombol 1)\n\n" +
                "Note : Jika kalian Run Atlantica as Admin,\n"+
                "Maka Run Macro ini as Admin juga baru bisa";
            lbl_About.Text = Message;
        }

        private void link_Credit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
