﻿namespace Huanent.VisualStudio.DebuggerVisualizers.List
{
    partial class ListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnSaveXml = new System.Windows.Forms.ToolStripMenuItem();
            this.复制xml到剪切板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaceJson = new System.Windows.Forms.ToolStripMenuItem();
            this.复制json到剪切板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 39);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 37;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(774, 490);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveXml,
            this.复制xml到剪切板ToolStripMenuItem,
            this.btnSaceJson,
            this.复制json到剪切板ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(114, 35);
            this.btnSaveXml.Text = "保存xml";
            // 
            // 复制xml到剪切板ToolStripMenuItem
            // 
            this.复制xml到剪切板ToolStripMenuItem.Name = "复制xml到剪切板ToolStripMenuItem";
            this.复制xml到剪切板ToolStripMenuItem.Size = new System.Drawing.Size(114, 35);
            this.复制xml到剪切板ToolStripMenuItem.Text = "复制xml";
            // 
            // btnSaceJson
            // 
            this.btnSaceJson.Name = "btnSaceJson";
            this.btnSaceJson.Size = new System.Drawing.Size(121, 35);
            this.btnSaceJson.Text = "保存json";
            // 
            // 复制json到剪切板ToolStripMenuItem
            // 
            this.复制json到剪切板ToolStripMenuItem.Name = "复制json到剪切板ToolStripMenuItem";
            this.复制json到剪切板ToolStripMenuItem.Size = new System.Drawing.Size(121, 35);
            this.复制json到剪切板ToolStripMenuItem.Text = "复制json";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 529);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListForm";
            this.Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveXml;
        private System.Windows.Forms.ToolStripMenuItem btnSaceJson;
        private System.Windows.Forms.ToolStripMenuItem 复制xml到剪切板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制json到剪切板ToolStripMenuItem;
    }
}