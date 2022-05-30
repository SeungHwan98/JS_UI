namespace DXApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Home = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.File = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.OpenBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveBtn = new DevExpress.XtraBars.BarButtonItem();
            this.SaveAsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.DataControl = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.MakeDataBtn = new DevExpress.XtraBars.BarButtonItem();
            this.MakeTestBtn = new DevExpress.XtraBars.BarButtonItem();
            this.MainBtn = new DevExpress.XtraBars.BarButtonItem();
            this.Graph = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.LDAViewerBtn = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(35, 32, 35, 32);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.OpenBtn,
            this.SaveBtn,
            this.SaveAsBtn,
            this.MakeDataBtn,
            this.MakeTestBtn,
            this.MainBtn,
            this.LDAViewerBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Home});
            this.ribbonControl1.Size = new System.Drawing.Size(1151, 151);
            // 
            // Home
            // 
            this.Home.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.File,
            this.DataControl,
            this.Graph});
            this.Home.Name = "Home";
            this.Home.Text = "Home";
            // 
            // File
            // 
            this.File.ItemLinks.Add(this.OpenBtn);
            this.File.ItemLinks.Add(this.SaveBtn);
            this.File.ItemLinks.Add(this.SaveAsBtn);
            this.File.Name = "File";
            this.File.Text = "File";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Caption = "Open";
            this.OpenBtn.Id = 1;
            this.OpenBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.OpenBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.OpenBtn.Name = "OpenBtn";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Caption = "Save";
            this.SaveBtn.Id = 2;
            this.SaveBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.SaveBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.SaveBtn.Name = "SaveBtn";
            // 
            // SaveAsBtn
            // 
            this.SaveAsBtn.Caption = "Save As";
            this.SaveAsBtn.Id = 3;
            this.SaveAsBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.SaveAsBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.SaveAsBtn.Name = "SaveAsBtn";
            // 
            // DataControl
            // 
            this.DataControl.ItemLinks.Add(this.MakeDataBtn);
            this.DataControl.ItemLinks.Add(this.MakeTestBtn);
            this.DataControl.ItemLinks.Add(this.MainBtn);
            this.DataControl.Name = "DataControl";
            this.DataControl.Text = "Data Control";
            // 
            // MakeDataBtn
            // 
            this.MakeDataBtn.Caption = "Make Data";
            this.MakeDataBtn.Id = 4;
            this.MakeDataBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("makeDataBtn.ImageOptions.Image")));
            this.MakeDataBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("makeDataBtn.ImageOptions.LargeImage")));
            this.MakeDataBtn.Name = "MakeDataBtn";
            // 
            // MakeTestBtn
            // 
            this.MakeTestBtn.Caption = "Make Test";
            this.MakeTestBtn.Id = 5;
            this.MakeTestBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("MakeTestBtn.ImageOptions.Image")));
            this.MakeTestBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("MakeTestBtn.ImageOptions.LargeImage")));
            this.MakeTestBtn.Name = "MakeTestBtn";
            // 
            // MainBtn
            // 
            this.MainBtn.Caption = "Main";
            this.MainBtn.Id = 6;
            this.MainBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.MainBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.MainBtn.Name = "MainBtn";
            // 
            // Graph
            // 
            this.Graph.ItemLinks.Add(this.LDAViewerBtn, true);
            this.Graph.Name = "Graph";
            this.Graph.Text = "Graph";
            // 
            // LDAViewerBtn
            // 
            this.LDAViewerBtn.Caption = "LDA Viewer";
            this.LDAViewerBtn.Id = 7;
            this.LDAViewerBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image2")));
            this.LDAViewerBtn.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage2")));
            this.LDAViewerBtn.Name = "LDAViewerBtn";
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 584);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage Home;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup File;
        private DevExpress.XtraBars.BarButtonItem OpenBtn;
        private DevExpress.XtraBars.BarButtonItem SaveBtn;
        private DevExpress.XtraBars.BarButtonItem SaveAsBtn;
        private DevExpress.XtraBars.BarButtonItem MakeDataBtn;
        private DevExpress.XtraBars.BarButtonItem MakeTestBtn;
        private DevExpress.XtraBars.BarButtonItem MainBtn;
        private DevExpress.XtraBars.BarButtonItem LDAViewerBtn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup DataControl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Graph;
    }
}

