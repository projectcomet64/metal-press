
namespace M64MMPresser
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTimeline = new System.Windows.Forms.Panel();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTimelineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnsemble = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbOrk = new System.Windows.Forms.TabPage();
            this.tbCam = new System.Windows.Forms.TabPage();
            this.nudScaleZ = new System.Windows.Forms.NumericUpDown();
            this.nudScaleY = new System.Windows.Forms.NumericUpDown();
            this.nudScaleX = new System.Windows.Forms.NumericUpDown();
            this.cbSync = new System.Windows.Forms.CheckBox();
            this.cbAddOnChange = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbScaleZ = new System.Windows.Forms.TrackBar();
            this.tbScaleY = new System.Windows.Forms.TrackBar();
            this.tbScaleX = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbpTimelineControls = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSyncWithComposer = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCollapseTl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWipe = new System.Windows.Forms.Button();
            this.cmsDirection = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmLookUp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookDown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookRight = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookForward = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLookBehind = new System.Windows.Forms.ToolStripMenuItem();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.msMainMenu.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbOrk.SuspendLayout();
            this.tbCam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleX)).BeginInit();
            this.tbpTimelineControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTimeline
            // 
            this.pnlTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTimeline.Location = new System.Drawing.Point(0, 0);
            this.pnlTimeline.Name = "pnlTimeline";
            this.pnlTimeline.Size = new System.Drawing.Size(704, 229);
            this.pnlTimeline.TabIndex = 13;
            // 
            // msMainMenu
            // 
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutKIOToolStripMenuItem});
            this.msMainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(704, 23);
            this.msMainMenu.TabIndex = 14;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTimelineToolStripMenuItem,
            this.loadTimelineToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveTimelineToolStripMenuItem
            // 
            this.saveTimelineToolStripMenuItem.Name = "saveTimelineToolStripMenuItem";
            this.saveTimelineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.saveTimelineToolStripMenuItem.Text = "Save Timeline...";
            this.saveTimelineToolStripMenuItem.Click += new System.EventHandler(this.saveTimelineToolStripMenuItem_Click);
            // 
            // loadTimelineToolStripMenuItem
            // 
            this.loadTimelineToolStripMenuItem.Name = "loadTimelineToolStripMenuItem";
            this.loadTimelineToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadTimelineToolStripMenuItem.Text = "Load Timeline...";
            this.loadTimelineToolStripMenuItem.Click += new System.EventHandler(this.loadTimelineToolStripMenuItem_Click);
            // 
            // aboutKIOToolStripMenuItem
            // 
            this.aboutKIOToolStripMenuItem.Name = "aboutKIOToolStripMenuItem";
            this.aboutKIOToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.aboutKIOToolStripMenuItem.Text = "About Press...";
            this.aboutKIOToolStripMenuItem.Click += new System.EventHandler(this.aboutKIOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Scale changing not working?\r\nPress the button below at anytime to fix that.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEnsemble
            // 
            this.btnEnsemble.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnsemble.Location = new System.Drawing.Point(229, 68);
            this.btnEnsemble.Name = "btnEnsemble";
            this.btnEnsemble.Size = new System.Drawing.Size(239, 23);
            this.btnEnsemble.TabIndex = 1;
            this.btnEnsemble.Text = "ALLOW MARIO TO TRASCEND\r\n";
            this.btnEnsemble.UseVisualStyleBackColor = true;
            this.btnEnsemble.Click += new System.EventHandler(this.btnEnsemble_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbOrk);
            this.tbcMain.Controls.Add(this.tbCam);
            this.tbcMain.Controls.Add(this.tbpTimelineControls);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(704, 273);
            this.tbcMain.TabIndex = 16;
            // 
            // tbOrk
            // 
            this.tbOrk.Controls.Add(this.btnEnsemble);
            this.tbOrk.Controls.Add(this.label1);
            this.tbOrk.Location = new System.Drawing.Point(4, 22);
            this.tbOrk.Name = "tbOrk";
            this.tbOrk.Padding = new System.Windows.Forms.Padding(3);
            this.tbOrk.Size = new System.Drawing.Size(696, 247);
            this.tbOrk.TabIndex = 0;
            this.tbOrk.Text = "Presser";
            this.tbOrk.UseVisualStyleBackColor = true;
            // 
            // tbCam
            // 
            this.tbCam.AutoScroll = true;
            this.tbCam.Controls.Add(this.nudScaleZ);
            this.tbCam.Controls.Add(this.nudScaleY);
            this.tbCam.Controls.Add(this.nudScaleX);
            this.tbCam.Controls.Add(this.cbSync);
            this.tbCam.Controls.Add(this.cbAddOnChange);
            this.tbCam.Controls.Add(this.label3);
            this.tbCam.Controls.Add(this.tbScaleZ);
            this.tbCam.Controls.Add(this.tbScaleY);
            this.tbCam.Controls.Add(this.tbScaleX);
            this.tbCam.Controls.Add(this.label7);
            this.tbCam.Controls.Add(this.label6);
            this.tbCam.Controls.Add(this.label4);
            this.tbCam.Location = new System.Drawing.Point(4, 22);
            this.tbCam.Name = "tbCam";
            this.tbCam.Padding = new System.Windows.Forms.Padding(3);
            this.tbCam.Size = new System.Drawing.Size(696, 247);
            this.tbCam.TabIndex = 1;
            this.tbCam.Text = "Scale Controls";
            this.tbCam.UseVisualStyleBackColor = true;
            // 
            // nudScaleZ
            // 
            this.nudScaleZ.Location = new System.Drawing.Point(330, 124);
            this.nudScaleZ.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudScaleZ.Name = "nudScaleZ";
            this.nudScaleZ.Size = new System.Drawing.Size(57, 20);
            this.nudScaleZ.TabIndex = 10;
            this.nudScaleZ.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudScaleZ.ValueChanged += new System.EventHandler(this.nudUpdate);
            // 
            // nudScaleY
            // 
            this.nudScaleY.Location = new System.Drawing.Point(330, 92);
            this.nudScaleY.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudScaleY.Name = "nudScaleY";
            this.nudScaleY.Size = new System.Drawing.Size(57, 20);
            this.nudScaleY.TabIndex = 10;
            this.nudScaleY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudScaleY.ValueChanged += new System.EventHandler(this.nudUpdate);
            // 
            // nudScaleX
            // 
            this.nudScaleX.Location = new System.Drawing.Point(330, 59);
            this.nudScaleX.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudScaleX.Name = "nudScaleX";
            this.nudScaleX.Size = new System.Drawing.Size(57, 20);
            this.nudScaleX.TabIndex = 10;
            this.nudScaleX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudScaleX.ValueChanged += new System.EventHandler(this.nudUpdate);
            // 
            // cbSync
            // 
            this.cbSync.AutoSize = true;
            this.cbSync.Location = new System.Drawing.Point(61, 161);
            this.cbSync.Name = "cbSync";
            this.cbSync.Size = new System.Drawing.Size(117, 17);
            this.cbSync.TabIndex = 9;
            this.cbSync.Text = "Synchronize scales";
            this.cbSync.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttInfo.SetToolTip(this.cbSync, "Links all scales together.");
            this.cbSync.UseVisualStyleBackColor = true;
            this.cbSync.CheckedChanged += new System.EventHandler(this.cbSync_CheckedChanged);
            // 
            // cbAddOnChange
            // 
            this.cbAddOnChange.AutoSize = true;
            this.cbAddOnChange.Location = new System.Drawing.Point(250, 161);
            this.cbAddOnChange.Name = "cbAddOnChange";
            this.cbAddOnChange.Size = new System.Drawing.Size(137, 17);
            this.cbAddOnChange.TabIndex = 9;
            this.cbAddOnChange.Text = "Keyframe Record mode";
            this.cbAddOnChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttInfo.SetToolTip(this.cbAddOnChange, "Every time you use the Position or Rotation controls, a Keyframe will be added or" +
        " replaced in the current location of the trackhead.");
            this.cbAddOnChange.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(465, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 160);
            this.label3.TabIndex = 2;
            this.label3.Text = "The max scale forward is 400%. The min scale backwards is 0%.\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.AutoSize = false;
            this.tbScaleZ.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbScaleZ.Location = new System.Drawing.Point(61, 124);
            this.tbScaleZ.Maximum = 4000;
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(263, 22);
            this.tbScaleZ.TabIndex = 3;
            this.tbScaleZ.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbScaleZ.Value = 1000;
            this.tbScaleZ.Scroll += new System.EventHandler(this.tbScaleZ_Scroll);
            // 
            // tbScaleY
            // 
            this.tbScaleY.AutoSize = false;
            this.tbScaleY.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbScaleY.Location = new System.Drawing.Point(61, 92);
            this.tbScaleY.Maximum = 4000;
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(263, 22);
            this.tbScaleY.TabIndex = 3;
            this.tbScaleY.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbScaleY.Value = 1000;
            this.tbScaleY.Scroll += new System.EventHandler(this.tbScaleY_Scroll);
            // 
            // tbScaleX
            // 
            this.tbScaleX.AutoSize = false;
            this.tbScaleX.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbScaleX.Location = new System.Drawing.Point(61, 57);
            this.tbScaleX.Maximum = 4000;
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(263, 22);
            this.tbScaleX.TabIndex = 3;
            this.tbScaleX.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbScaleX.Value = 1000;
            this.tbScaleX.Scroll += new System.EventHandler(this.tbScaleX_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Scale Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Scale Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Scale X";
            // 
            // tbpTimelineControls
            // 
            this.tbpTimelineControls.Controls.Add(this.groupBox1);
            this.tbpTimelineControls.Location = new System.Drawing.Point(4, 22);
            this.tbpTimelineControls.Name = "tbpTimelineControls";
            this.tbpTimelineControls.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTimelineControls.Size = new System.Drawing.Size(696, 247);
            this.tbpTimelineControls.TabIndex = 2;
            this.tbpTimelineControls.Text = "Timeline Controls";
            this.tbpTimelineControls.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSyncWithComposer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCollapseTl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnWipe);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 225);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timeline";
            // 
            // cbSyncWithComposer
            // 
            this.cbSyncWithComposer.AutoSize = true;
            this.cbSyncWithComposer.Location = new System.Drawing.Point(82, 157);
            this.cbSyncWithComposer.Name = "cbSyncWithComposer";
            this.cbSyncWithComposer.Size = new System.Drawing.Size(452, 17);
            this.cbSyncWithComposer.TabIndex = 10;
            this.cbSyncWithComposer.Text = "Synchronize Timeline with Animation Timer (Preferable to use alongside METAL Comp" +
    "oser)";
            this.cbSyncWithComposer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbSyncWithComposer.UseVisualStyleBackColor = true;
            this.cbSyncWithComposer.CheckedChanged += new System.EventHandler(this.cbSyncWithComposer_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(288, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 63);
            this.label5.TabIndex = 3;
            this.label5.Text = "This hides the Timeline. Useful if you don\'t want to use any of that fancy schman" +
    "cy keyframe thing and just want the scale controls.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCollapseTl
            // 
            this.btnCollapseTl.Location = new System.Drawing.Point(288, 19);
            this.btnCollapseTl.Name = "btnCollapseTl";
            this.btnCollapseTl.Size = new System.Drawing.Size(273, 23);
            this.btnCollapseTl.TabIndex = 2;
            this.btnCollapseTl.Text = "Collapse/uncollapse Timeline";
            this.btnCollapseTl.UseVisualStyleBackColor = true;
            this.btnCollapseTl.Click += new System.EventHandler(this.btnCollapseTl_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 140);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnWipe
            // 
            this.btnWipe.Location = new System.Drawing.Point(6, 19);
            this.btnWipe.Name = "btnWipe";
            this.btnWipe.Size = new System.Drawing.Size(273, 23);
            this.btnWipe.TabIndex = 0;
            this.btnWipe.Text = "Wipe Timeline (no undo!)";
            this.btnWipe.UseVisualStyleBackColor = true;
            this.btnWipe.Click += new System.EventHandler(this.btnWipe_Click);
            // 
            // cmsDirection
            // 
            this.cmsDirection.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsDirection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmLookUp,
            this.tsmLookDown,
            this.tsmLookLeft,
            this.tsmLookRight,
            this.tsmLookForward,
            this.tsmLookBehind});
            this.cmsDirection.Name = "cmsDirection";
            this.cmsDirection.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.cmsDirection.Size = new System.Drawing.Size(118, 136);
            // 
            // tsmLookUp
            // 
            this.tsmLookUp.Name = "tsmLookUp";
            this.tsmLookUp.Size = new System.Drawing.Size(117, 22);
            this.tsmLookUp.Text = "Up";
            // 
            // tsmLookDown
            // 
            this.tsmLookDown.Name = "tsmLookDown";
            this.tsmLookDown.Size = new System.Drawing.Size(117, 22);
            this.tsmLookDown.Text = "Down";
            // 
            // tsmLookLeft
            // 
            this.tsmLookLeft.Name = "tsmLookLeft";
            this.tsmLookLeft.Size = new System.Drawing.Size(117, 22);
            this.tsmLookLeft.Text = "Left";
            // 
            // tsmLookRight
            // 
            this.tsmLookRight.Name = "tsmLookRight";
            this.tsmLookRight.Size = new System.Drawing.Size(117, 22);
            this.tsmLookRight.Text = "Right";
            // 
            // tsmLookForward
            // 
            this.tsmLookForward.Name = "tsmLookForward";
            this.tsmLookForward.Size = new System.Drawing.Size(117, 22);
            this.tsmLookForward.Text = "Forward";
            // 
            // tsmLookBehind
            // 
            this.tsmLookBehind.Name = "tsmLookBehind";
            this.tsmLookBehind.Size = new System.Drawing.Size(117, 22);
            this.tsmLookBehind.Text = "Behind";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 23);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tbcMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pnlTimeline);
            this.scMain.Panel2MinSize = 220;
            this.scMain.Size = new System.Drawing.Size(704, 506);
            this.scMain.SplitterDistance = 273;
            this.scMain.TabIndex = 17;
            this.scMain.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 529);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2048, 1024);
            this.MinimumSize = new System.Drawing.Size(720, 312);
            this.Name = "FrmMain";
            this.Text = "METAL Press";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.tbcMain.ResumeLayout(false);
            this.tbOrk.ResumeLayout(false);
            this.tbCam.ResumeLayout(false);
            this.tbCam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScaleX)).EndInit();
            this.tbpTimelineControls.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsDirection.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlTimeline;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTimelineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutKIOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnsemble;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbOrk;
        private System.Windows.Forms.TabPage tbCam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbScaleX;
        private System.Windows.Forms.ContextMenuStrip cmsDirection;
        private System.Windows.Forms.ToolStripMenuItem tsmLookUp;
        private System.Windows.Forms.ToolStripMenuItem tsmLookDown;
        private System.Windows.Forms.ToolStripMenuItem tsmLookLeft;
        private System.Windows.Forms.ToolStripMenuItem tsmLookRight;
        private System.Windows.Forms.ToolStripMenuItem tsmLookForward;
        private System.Windows.Forms.ToolStripMenuItem tsmLookBehind;
        private System.Windows.Forms.TabPage tbpTimelineControls;
        private System.Windows.Forms.CheckBox cbAddOnChange;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCollapseTl;
        private System.Windows.Forms.CheckBox cbSync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbScaleZ;
        private System.Windows.Forms.TrackBar tbScaleY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbSyncWithComposer;
        private System.Windows.Forms.NumericUpDown nudScaleZ;
        private System.Windows.Forms.NumericUpDown nudScaleY;
        private System.Windows.Forms.NumericUpDown nudScaleX;
    }
}