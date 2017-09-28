using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuickWatch2
{
    partial class searchWindow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_results = new System.Windows.Forms.ComboBox();
            this.linklabel_link = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.CausesValidation = false;
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tb_search.Location = new System.Drawing.Point(20, 44);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(194, 23);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyDown);
            this.tb_search.MouseEnter += new System.EventHandler(this.tb_search_MouseEnter);
            // 
            // bt_search
            // 
            this.bt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.bt_search.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.bt_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_search.Location = new System.Drawing.Point(230, 44);
            this.bt_search.Margin = new System.Windows.Forms.Padding(0);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(112, 23);
            this.bt_search.TabIndex = 2;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = false;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(16, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Watch now:";
            this.label1.Visible = false;
            // 
            // cb_results
            // 
            this.cb_results.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_results.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_results.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.cb_results.FormattingEnabled = true;
            this.cb_results.Location = new System.Drawing.Point(20, 82);
            this.cb_results.Name = "cb_results";
            this.cb_results.Size = new System.Drawing.Size(194, 23);
            this.cb_results.TabIndex = 3;
            this.cb_results.SelectedIndexChanged += new System.EventHandler(this.cb_results_SelectedIndexChanged_1);
            // 
            // linklabel_link
            // 
            this.linklabel_link.AutoSize = true;
            this.linklabel_link.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.linklabel_link.Location = new System.Drawing.Point(16, 147);
            this.linklabel_link.Name = "linklabel_link";
            this.linklabel_link.Size = new System.Drawing.Size(60, 15);
            this.linklabel_link.TabIndex = 4;
            this.linklabel_link.TabStop = true;
            this.linklabel_link.Text = "linkLabel1";
            this.linklabel_link.Visible = false;
            this.linklabel_link.VisitedLinkColor = System.Drawing.SystemColors.ButtonFace;
            this.linklabel_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_link_LinkClicked_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(16, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Title:";
            // 
            // searchWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linklabel_link);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_results);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "searchWindow";
            this.Size = new System.Drawing.Size(358, 181);
            this.Load += new System.EventHandler(this.searchWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_search;
        private Button bt_search;
        private Label label1;
        private ComboBox cb_results;
        private LinkLabel linklabel_link;
        private Label label2;
    }
}
