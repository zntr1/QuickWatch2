using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace QuickWatch2
{
    public partial class searchWindow: UserControl
    {
        public static List<Result> searchResults = new List<Result>();


        public searchWindow()
        {
            InitializeComponent();

            ToolTip t = new ToolTip();
            t.InitialDelay = 1000;
            t.SetToolTip(this.tb_search, "Enter Series to find on bs.to");

        }

        private void searchWindow_Load(object sender, EventArgs e)
        {

        }

        private async void bt_search_Click(object sender, EventArgs e)
        {
            searchResults.Clear();
            cb_results.DataSource = searchResults;
            HtmlWeb web = new HtmlWeb();
            var doc = await Task.Factory.StartNew(() => web.Load(@"https://bs.to/serie-alphabet"));
            var nodes = doc.DocumentNode.SelectNodes("//*[@id=\"seriesContainer\"]//div");
            foreach (var node in nodes)
            {
                if (node.InnerText.ToLower().Contains(tb_search.Text.ToLower()))
                {

                    var innerHtmlString = node.InnerHtml;
                    innerHtmlString = innerHtmlString.Replace("<li>", "");
                    innerHtmlString = innerHtmlString.Replace("</li>", "");
                    innerHtmlString = innerHtmlString.Replace("<ul>", "");
                    innerHtmlString = innerHtmlString.Replace("</ul>", "");
                    innerHtmlString = innerHtmlString.Replace("<a href=\"", "");

                    var innerHtmlList = innerHtmlString.Split('\n').ToList();

                    foreach (var rowInformation in innerHtmlList)
                    {
                        if (!rowInformation.ToLower().Contains(tb_search.Text.ToLower())){
                            continue;
                        }
                        var rowInfoList = rowInformation.Split('"').ToList();
                        if (rowInfoList.Count < 2)
                        {
                            continue;
                        }

                        Result result = new Result();

                        var link = rowInfoList.ElementAt(0).Trim();
                        var name = rowInfoList.ElementAt(2).Trim();
                        link = "www.bs.to/" + link;

                        result.Link = link;
                        result.Title = name;

                        searchResults.Add(result);
                    }
                }
            }

            cb_results.DataSource = searchResults.Select(element => element.Title).ToList();

        }

        private void cb_results_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var result = searchResults.ElementAt(cb_results.SelectedIndex);
            linklabel_link.Text = result.Link;
            linklabel_link.Visible = true;
            label1.Visible = true;
        }

        private void linklabel_link_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linklabel_link.Text);
        }

        private void tb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                // gegen Beeps und autoclose
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (tb_search.Text == "")
                    return;
                bt_search.PerformClick();
            }
        }

        private void tb_search_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
