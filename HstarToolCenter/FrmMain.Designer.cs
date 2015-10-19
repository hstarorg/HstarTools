namespace HstarToolCenter
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControlTop = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBarBottom = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlLeft = new DevExpress.XtraEditors.GroupControl();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).BeginInit();
            this.groupControlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControlTop
            // 
            this.ribbonControlTop.ExpandCollapseItem.Id = 0;
            this.ribbonControlTop.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlTop.ExpandCollapseItem});
            this.ribbonControlTop.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlTop.MaxItemId = 1;
            this.ribbonControlTop.Name = "ribbonControlTop";
            this.ribbonControlTop.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControlTop.Size = new System.Drawing.Size(1352, 151);
            this.ribbonControlTop.StatusBar = this.ribbonStatusBarBottom;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBarBottom
            // 
            this.ribbonStatusBarBottom.Location = new System.Drawing.Point(0, 740);
            this.ribbonStatusBarBottom.Name = "ribbonStatusBarBottom";
            this.ribbonStatusBarBottom.Ribbon = this.ribbonControlTop;
            this.ribbonStatusBarBottom.Size = new System.Drawing.Size(1352, 23);
            // 
            // groupControlLeft
            // 
            this.groupControlLeft.Controls.Add(this.accordionControl1);
            this.groupControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControlLeft.Location = new System.Drawing.Point(0, 151);
            this.groupControlLeft.Name = "groupControlLeft";
            this.groupControlLeft.Size = new System.Drawing.Size(254, 589);
            this.groupControlLeft.TabIndex = 3;
            this.groupControlLeft.Text = "二级菜单";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(2, 21);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(250, 566);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Text = "Element1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 763);
            this.Controls.Add(this.groupControlLeft);
            this.Controls.Add(this.ribbonStatusBarBottom);
            this.Controls.Add(this.ribbonControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControlTop;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBarBottom;
            this.Text = "幻星☆工具中心";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlLeft)).EndInit();
            this.groupControlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlTop;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBarBottom;
        private DevExpress.XtraEditors.GroupControl groupControlLeft;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

