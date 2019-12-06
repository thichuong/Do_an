﻿namespace PaintUI
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LeftTopPanel_1 = new System.Windows.Forms.Panel();
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.LeftBottomPanel_1 = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightBottomPanel_1 = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel_1 = new System.Windows.Forms.Panel();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelCavas = new PaintUI.DoubleBufferPanel();
            this.layerPanel = new PaintUI.LayerPanel();
            this.SketchBox = new PaintUI.Canvas();
            this.RightTopPanel = new PaintUI.DoubleBufferPanel();
            this.LeftBottomPanel = new PaintUI.DoubleBufferPanel();
            this.RightBottomPanel = new PaintUI.DoubleBufferPanel();
            this.LeftTopPanel = new PaintUI.DoubleBufferPanel();
            this.menuPanel = new PaintUI.MenuPanel();
            this.doubleBufferPanel2 = new PaintUI.DoubleBufferPanel();
            this.shapesPanel = new PaintUI.ShapesPanel();
            this.effectsPanel = new PaintUI.EffectsPanel();
            this.textPanel = new PaintUI.TextPanel();
            this.brushesPanel = new PaintUI.BrushesPanel();
            this.canvasPanel = new PaintUI.CanvasPanel();
            this.doubleBufferPanel1 = new PaintUI.DoubleBufferPanel();
            this.titleLb = new System.Windows.Forms.Label();
            this.RedoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UndoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.OpenLayerListButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditPanel.SuspendLayout();
            this.panelCavas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.doubleBufferPanel2.SuspendLayout();
            this.doubleBufferPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenLayerListButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            this.bunifuTransition1.Interval = 12;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bunifuTransition1.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Location = new System.Drawing.Point(10, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1410, 10);
            this.TopPanel.TabIndex = 30;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // LeftTopPanel_1
            // 
            this.LeftTopPanel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LeftTopPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.LeftTopPanel_1, BunifuAnimatorNS.DecorationType.None);
            this.LeftTopPanel_1.Location = new System.Drawing.Point(0, 0);
            this.LeftTopPanel_1.Name = "LeftTopPanel_1";
            this.LeftTopPanel_1.Size = new System.Drawing.Size(10, 10);
            this.LeftTopPanel_1.TabIndex = 32;
            this.LeftTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseDown);
            this.LeftTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseMove);
            this.LeftTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_1_MouseUp);
            // 
            // Leftpanel
            // 
            this.Leftpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Leftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Leftpanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.bunifuTransition1.SetDecoration(this.Leftpanel, BunifuAnimatorNS.DecorationType.None);
            this.Leftpanel.Location = new System.Drawing.Point(-2, 13);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(10, 861);
            this.Leftpanel.TabIndex = 33;
            this.Leftpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseDown);
            this.Leftpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseMove);
            this.Leftpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftPanel_MouseUp);
            // 
            // LeftBottomPanel_1
            // 
            this.LeftBottomPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftBottomPanel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LeftBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.LeftBottomPanel_1, BunifuAnimatorNS.DecorationType.None);
            this.LeftBottomPanel_1.Location = new System.Drawing.Point(-2, 874);
            this.LeftBottomPanel_1.Name = "LeftBottomPanel_1";
            this.LeftBottomPanel_1.Size = new System.Drawing.Size(10, 16);
            this.LeftBottomPanel_1.TabIndex = 34;
            this.LeftBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseDown);
            this.LeftBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseMove);
            this.LeftBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_1_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bunifuTransition1.SetDecoration(this.BottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.BottomPanel.Location = new System.Drawing.Point(8, 874);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1414, 14);
            this.BottomPanel.TabIndex = 35;
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // RightBottomPanel_1
            // 
            this.RightBottomPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBottomPanel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.RightBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.RightBottomPanel_1, BunifuAnimatorNS.DecorationType.None);
            this.RightBottomPanel_1.Location = new System.Drawing.Point(1422, 874);
            this.RightBottomPanel_1.Name = "RightBottomPanel_1";
            this.RightBottomPanel_1.Size = new System.Drawing.Size(10, 17);
            this.RightBottomPanel_1.TabIndex = 36;
            this.RightBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
            this.RightBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
            this.RightBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.bunifuTransition1.SetDecoration(this.RightPanel, BunifuAnimatorNS.DecorationType.None);
            this.RightPanel.Location = new System.Drawing.Point(1422, 13);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(10, 861);
            this.RightPanel.TabIndex = 37;
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // RightTopPanel_1
            // 
            this.RightTopPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopPanel_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.RightTopPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.RightTopPanel_1, BunifuAnimatorNS.DecorationType.None);
            this.RightTopPanel_1.Location = new System.Drawing.Point(1422, 3);
            this.RightTopPanel_1.Name = "RightTopPanel_1";
            this.RightTopPanel_1.Size = new System.Drawing.Size(10, 10);
            this.RightTopPanel_1.TabIndex = 38;
            this.RightTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseDown);
            this.RightTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseMove);
            this.RightTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseUp);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditPanel.Controls.Add(this.OpenLayerListButton);
            this.EditPanel.Controls.Add(this.SelectButton);
            this.EditPanel.Controls.Add(this.MoveButton);
            this.EditPanel.Controls.Add(this.ZoomButton);
            this.EditPanel.Controls.Add(this.PanButton);
            this.EditPanel.Controls.Add(this.CropButton);
            this.bunifuTransition1.SetDecoration(this.EditPanel, BunifuAnimatorNS.DecorationType.None);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPanel.Location = new System.Drawing.Point(3, 101);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1101, 58);
            this.EditPanel.TabIndex = 42;
            // 
            // SelectButton
            // 
            this.SelectButton.Activecolor = System.Drawing.Color.Transparent;
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButton.BorderRadius = 0;
            this.SelectButton.ButtonText = "Select  ";
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.SelectButton, BunifuAnimatorNS.DecorationType.None);
            this.SelectButton.DisabledColor = System.Drawing.Color.Gray;
            this.SelectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SelectButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("SelectButton.Iconimage")));
            this.SelectButton.Iconimage_right = null;
            this.SelectButton.Iconimage_right_Selected = null;
            this.SelectButton.Iconimage_Selected = null;
            this.SelectButton.IconMarginLeft = 0;
            this.SelectButton.IconMarginRight = 0;
            this.SelectButton.IconRightVisible = true;
            this.SelectButton.IconRightZoom = 0D;
            this.SelectButton.IconVisible = true;
            this.SelectButton.IconZoom = 55D;
            this.SelectButton.IsTab = false;
            this.SelectButton.Location = new System.Drawing.Point(0, 0);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(6);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SelectButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.SelectButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SelectButton.selected = false;
            this.SelectButton.Size = new System.Drawing.Size(140, 60);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select  ";
            this.SelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectButton.Textcolor = System.Drawing.Color.Black;
            this.SelectButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // MoveButton
            // 
            this.MoveButton.Activecolor = System.Drawing.Color.Transparent;
            this.MoveButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveButton.BorderRadius = 0;
            this.MoveButton.ButtonText = "Move ";
            this.MoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.MoveButton, BunifuAnimatorNS.DecorationType.None);
            this.MoveButton.DisabledColor = System.Drawing.Color.Gray;
            this.MoveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MoveButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("MoveButton.Iconimage")));
            this.MoveButton.Iconimage_right = null;
            this.MoveButton.Iconimage_right_Selected = null;
            this.MoveButton.Iconimage_Selected = null;
            this.MoveButton.IconMarginLeft = 0;
            this.MoveButton.IconMarginRight = 0;
            this.MoveButton.IconRightVisible = true;
            this.MoveButton.IconRightZoom = 0D;
            this.MoveButton.IconVisible = true;
            this.MoveButton.IconZoom = 55D;
            this.MoveButton.IsTab = false;
            this.MoveButton.Location = new System.Drawing.Point(530, 0);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(6);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MoveButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.MoveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.MoveButton.selected = false;
            this.MoveButton.Size = new System.Drawing.Size(130, 60);
            this.MoveButton.TabIndex = 5;
            this.MoveButton.Text = "Move ";
            this.MoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoveButton.Textcolor = System.Drawing.Color.Black;
            this.MoveButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // ZoomButton
            // 
            this.ZoomButton.Activecolor = System.Drawing.Color.Transparent;
            this.ZoomButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomButton.BorderRadius = 0;
            this.ZoomButton.ButtonText = "Zoom";
            this.ZoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ZoomButton, BunifuAnimatorNS.DecorationType.None);
            this.ZoomButton.DisabledColor = System.Drawing.Color.Gray;
            this.ZoomButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ZoomButton.Iconimage")));
            this.ZoomButton.Iconimage_right = null;
            this.ZoomButton.Iconimage_right_Selected = null;
            this.ZoomButton.Iconimage_Selected = null;
            this.ZoomButton.IconMarginLeft = 0;
            this.ZoomButton.IconMarginRight = 0;
            this.ZoomButton.IconRightVisible = true;
            this.ZoomButton.IconRightZoom = 0D;
            this.ZoomButton.IconVisible = true;
            this.ZoomButton.IconZoom = 55D;
            this.ZoomButton.IsTab = false;
            this.ZoomButton.Location = new System.Drawing.Point(400, 0);
            this.ZoomButton.Margin = new System.Windows.Forms.Padding(6);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.ZoomButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ZoomButton.selected = false;
            this.ZoomButton.Size = new System.Drawing.Size(130, 60);
            this.ZoomButton.TabIndex = 4;
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZoomButton.Textcolor = System.Drawing.Color.Black;
            this.ZoomButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // PanButton
            // 
            this.PanButton.Activecolor = System.Drawing.Color.Transparent;
            this.PanButton.BackColor = System.Drawing.Color.Transparent;
            this.PanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanButton.BorderRadius = 0;
            this.PanButton.ButtonText = "Pan  ";
            this.PanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.PanButton, BunifuAnimatorNS.DecorationType.None);
            this.PanButton.DisabledColor = System.Drawing.Color.Gray;
            this.PanButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PanButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("PanButton.Iconimage")));
            this.PanButton.Iconimage_right = null;
            this.PanButton.Iconimage_right_Selected = null;
            this.PanButton.Iconimage_Selected = null;
            this.PanButton.IconMarginLeft = 0;
            this.PanButton.IconMarginRight = 0;
            this.PanButton.IconRightVisible = true;
            this.PanButton.IconRightZoom = 0D;
            this.PanButton.IconVisible = true;
            this.PanButton.IconZoom = 55D;
            this.PanButton.IsTab = false;
            this.PanButton.Location = new System.Drawing.Point(270, 0);
            this.PanButton.Margin = new System.Windows.Forms.Padding(6);
            this.PanButton.Name = "PanButton";
            this.PanButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PanButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.PanButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PanButton.selected = false;
            this.PanButton.Size = new System.Drawing.Size(130, 60);
            this.PanButton.TabIndex = 3;
            this.PanButton.Text = "Pan  ";
            this.PanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PanButton.Textcolor = System.Drawing.Color.Black;
            this.PanButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.PanButton.Click += new System.EventHandler(this.PanButton_Click);
            // 
            // CropButton
            // 
            this.CropButton.Activecolor = System.Drawing.Color.Transparent;
            this.CropButton.BackColor = System.Drawing.Color.Transparent;
            this.CropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CropButton.BorderRadius = 0;
            this.CropButton.ButtonText = "Crop ";
            this.CropButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.CropButton, BunifuAnimatorNS.DecorationType.None);
            this.CropButton.DisabledColor = System.Drawing.Color.Gray;
            this.CropButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CropButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("CropButton.Iconimage")));
            this.CropButton.Iconimage_right = null;
            this.CropButton.Iconimage_right_Selected = null;
            this.CropButton.Iconimage_Selected = null;
            this.CropButton.IconMarginLeft = 0;
            this.CropButton.IconMarginRight = 0;
            this.CropButton.IconRightVisible = true;
            this.CropButton.IconRightZoom = 0D;
            this.CropButton.IconVisible = true;
            this.CropButton.IconZoom = 55D;
            this.CropButton.IsTab = false;
            this.CropButton.Location = new System.Drawing.Point(140, 0);
            this.CropButton.Margin = new System.Windows.Forms.Padding(6);
            this.CropButton.Name = "CropButton";
            this.CropButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CropButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.CropButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.CropButton.selected = false;
            this.CropButton.Size = new System.Drawing.Size(130, 60);
            this.CropButton.TabIndex = 1;
            this.CropButton.Text = "Crop ";
            this.CropButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CropButton.Textcolor = System.Drawing.Color.Black;
            this.CropButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // panelCavas
            // 
            this.panelCavas.BackColor = System.Drawing.Color.Silver;
            this.panelCavas.Controls.Add(this.layerPanel);
            this.panelCavas.Controls.Add(this.SketchBox);
            this.panelCavas.Controls.Add(this.RightTopPanel);
            this.panelCavas.Controls.Add(this.LeftBottomPanel);
            this.panelCavas.Controls.Add(this.RightBottomPanel);
            this.panelCavas.Controls.Add(this.LeftTopPanel);
            this.bunifuTransition1.SetDecoration(this.panelCavas, BunifuAnimatorNS.DecorationType.None);
            this.panelCavas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCavas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelCavas.Location = new System.Drawing.Point(3, 159);
            this.panelCavas.Name = "panelCavas";
            this.panelCavas.Size = new System.Drawing.Size(1101, 720);
            this.panelCavas.TabIndex = 44;
            this.panelCavas.SizeChanged += new System.EventHandler(this.panelCavas_SizeChanged);
            // 
            // layerPanel
            // 
            this.layerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.layerPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuTransition1.SetDecoration(this.layerPanel, BunifuAnimatorNS.DecorationType.None);
            this.layerPanel.Location = new System.Drawing.Point(1041, 5);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(60, 382);
            this.layerPanel.TabIndex = 31;
            // 
            // SketchBox
            // 
            this.SketchBox.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.SketchBox, BunifuAnimatorNS.DecorationType.None);
            this.SketchBox.Location = new System.Drawing.Point(160, 132);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(758, 502);
            this.SketchBox.TabIndex = 30;
            this.SketchBox.TabStop = false;
            this.SketchBox.LocationChanged += new System.EventHandler(this.SketchBox_LocationChanged);
            this.SketchBox.SizeChanged += new System.EventHandler(this.SketchBox_SizeChanged);
            this.SketchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SketchBox_Paint);
            this.SketchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseDown);
            this.SketchBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseMove);
            this.SketchBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseUp);
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.RightTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.RightTopPanel.Location = new System.Drawing.Point(920, 119);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(10, 10);
            this.RightTopPanel.TabIndex = 27;
            this.RightTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseDown);
            this.RightTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseMove);
            this.RightTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseUp);
            // 
            // LeftBottomPanel
            // 
            this.LeftBottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LeftBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.LeftBottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftBottomPanel.Location = new System.Drawing.Point(120, 641);
            this.LeftBottomPanel.Name = "LeftBottomPanel";
            this.LeftBottomPanel.Size = new System.Drawing.Size(10, 10);
            this.LeftBottomPanel.TabIndex = 27;
            this.LeftBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseDown);
            this.LeftBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseMove);
            this.LeftBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseUp);
            // 
            // RightBottomPanel
            // 
            this.RightBottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.RightBottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.RightBottomPanel.Location = new System.Drawing.Point(951, 624);
            this.RightBottomPanel.Name = "RightBottomPanel";
            this.RightBottomPanel.Size = new System.Drawing.Size(10, 10);
            this.RightBottomPanel.TabIndex = 27;
            this.RightBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseDown);
            this.RightBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseMove);
            this.RightBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_MouseUp);
            // 
            // LeftTopPanel
            // 
            this.LeftTopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LeftTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.LeftTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftTopPanel.Location = new System.Drawing.Point(144, 119);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(10, 10);
            this.LeftTopPanel.TabIndex = 29;
            this.LeftTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseDown);
            this.LeftTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseMove);
            this.LeftTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Location = new System.Drawing.Point(2, 103);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(198, 151);
            this.menuPanel.TabIndex = 43;
            // 
            // doubleBufferPanel2
            // 
            this.doubleBufferPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.doubleBufferPanel2.Controls.Add(this.shapesPanel);
            this.doubleBufferPanel2.Controls.Add(this.effectsPanel);
            this.doubleBufferPanel2.Controls.Add(this.textPanel);
            this.doubleBufferPanel2.Controls.Add(this.brushesPanel);
            this.doubleBufferPanel2.Controls.Add(this.canvasPanel);
            this.bunifuTransition1.SetDecoration(this.doubleBufferPanel2, BunifuAnimatorNS.DecorationType.None);
            this.doubleBufferPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.doubleBufferPanel2.Location = new System.Drawing.Point(1104, 101);
            this.doubleBufferPanel2.Name = "doubleBufferPanel2";
            this.doubleBufferPanel2.Size = new System.Drawing.Size(323, 778);
            this.doubleBufferPanel2.TabIndex = 40;
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuTransition1.SetDecoration(this.shapesPanel, BunifuAnimatorNS.DecorationType.None);
            this.shapesPanel.Location = new System.Drawing.Point(0, 0);
            this.shapesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(324, 772);
            this.shapesPanel.TabIndex = 38;
            // 
            // effectsPanel
            // 
            this.effectsPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.effectsPanel, BunifuAnimatorNS.DecorationType.None);
            this.effectsPanel.Location = new System.Drawing.Point(0, 0);
            this.effectsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.effectsPanel.Name = "effectsPanel";
            this.effectsPanel.Size = new System.Drawing.Size(324, 775);
            this.effectsPanel.TabIndex = 33;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.textPanel, BunifuAnimatorNS.DecorationType.None);
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(323, 775);
            this.textPanel.TabIndex = 35;
            // 
            // brushesPanel
            // 
            this.brushesPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuTransition1.SetDecoration(this.brushesPanel, BunifuAnimatorNS.DecorationType.None);
            this.brushesPanel.Location = new System.Drawing.Point(0, 0);
            this.brushesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brushesPanel.Name = "brushesPanel";
            this.brushesPanel.Size = new System.Drawing.Size(323, 774);
            this.brushesPanel.TabIndex = 39;
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.canvasPanel, BunifuAnimatorNS.DecorationType.None);
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(324, 775);
            this.canvasPanel.TabIndex = 32;
            // 
            // doubleBufferPanel1
            // 
            this.doubleBufferPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.doubleBufferPanel1.Controls.Add(this.titleLb);
            this.doubleBufferPanel1.Controls.Add(this.RedoButton);
            this.doubleBufferPanel1.Controls.Add(this.CloseButton);
            this.doubleBufferPanel1.Controls.Add(this.EffectsButton);
            this.doubleBufferPanel1.Controls.Add(this.CanvasButton);
            this.doubleBufferPanel1.Controls.Add(this.BrushesButton);
            this.doubleBufferPanel1.Controls.Add(this.UndoButton);
            this.doubleBufferPanel1.Controls.Add(this.ShapesButton);
            this.doubleBufferPanel1.Controls.Add(this.MinimizeButton);
            this.doubleBufferPanel1.Controls.Add(this.MaximizeButton);
            this.doubleBufferPanel1.Controls.Add(this.MenuButton);
            this.doubleBufferPanel1.Controls.Add(this.TextButton);
            this.bunifuTransition1.SetDecoration(this.doubleBufferPanel1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(3, 3);
            this.doubleBufferPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(1424, 98);
            this.doubleBufferPanel1.TabIndex = 29;
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.titleLb, BunifuAnimatorNS.DecorationType.None);
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(12, 3);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(155, 20);
            this.titleLb.TabIndex = 12;
            this.titleLb.Text = "Untitled - Skuitch";
            // 
            // RedoButton
            // 
            this.RedoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.color = System.Drawing.Color.Transparent;
            this.RedoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.RedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.RedoButton, BunifuAnimatorNS.DecorationType.None);
            this.RedoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.RedoButton.ForeColor = System.Drawing.Color.Black;
            this.RedoButton.Image = global::PaintUI.Properties.Resources.RedoIcon;
            this.RedoButton.ImagePosition = -5;
            this.RedoButton.ImageZoom = 60;
            this.RedoButton.LabelPosition = 27;
            this.RedoButton.LabelText = "Redo";
            this.RedoButton.Location = new System.Drawing.Point(1265, 35);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(67, 60);
            this.RedoButton.TabIndex = 11;
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseButton.Image = global::PaintUI.Properties.Resources.exit1;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(1391, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EffectsButton
            // 
            this.EffectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EffectsButton.AutoSize = true;
            this.EffectsButton.BackColor = System.Drawing.Color.Transparent;
            this.EffectsButton.color = System.Drawing.Color.Transparent;
            this.EffectsButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.EffectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.EffectsButton, BunifuAnimatorNS.DecorationType.None);
            this.EffectsButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.EffectsButton.ForeColor = System.Drawing.Color.Black;
            this.EffectsButton.Image = global::PaintUI.Properties.Resources.EffectIcon;
            this.EffectsButton.ImagePosition = -3;
            this.EffectsButton.ImageZoom = 55;
            this.EffectsButton.LabelPosition = 30;
            this.EffectsButton.LabelText = "Effects";
            this.EffectsButton.Location = new System.Drawing.Point(755, 27);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(90, 70);
            this.EffectsButton.TabIndex = 9;
            this.EffectsButton.Click += new System.EventHandler(this.EffectsButton_Click);
            // 
            // CanvasButton
            // 
            this.CanvasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CanvasButton.AutoSize = true;
            this.CanvasButton.BackColor = System.Drawing.Color.Transparent;
            this.CanvasButton.color = System.Drawing.Color.Transparent;
            this.CanvasButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.CanvasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.CanvasButton, BunifuAnimatorNS.DecorationType.None);
            this.CanvasButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.CanvasButton.ForeColor = System.Drawing.Color.Black;
            this.CanvasButton.Image = global::PaintUI.Properties.Resources.CanvasIcon;
            this.CanvasButton.ImagePosition = -6;
            this.CanvasButton.ImageZoom = 60;
            this.CanvasButton.LabelPosition = 30;
            this.CanvasButton.LabelText = "Canvas";
            this.CanvasButton.Location = new System.Drawing.Point(563, 27);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(86, 70);
            this.CanvasButton.TabIndex = 7;
            this.CanvasButton.Click += new System.EventHandler(this.CanvasButton_Click);
            // 
            // BrushesButton
            // 
            this.BrushesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrushesButton.AutoSize = true;
            this.BrushesButton.BackColor = System.Drawing.Color.Transparent;
            this.BrushesButton.color = System.Drawing.Color.Transparent;
            this.BrushesButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.BrushesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BrushesButton, BunifuAnimatorNS.DecorationType.None);
            this.BrushesButton.Font = new System.Drawing.Font("Segoe Print", 10.5F);
            this.BrushesButton.ForeColor = System.Drawing.Color.Black;
            this.BrushesButton.Image = global::PaintUI.Properties.Resources.BrushesIcon;
            this.BrushesButton.ImagePosition = -1;
            this.BrushesButton.ImageZoom = 60;
            this.BrushesButton.LabelPosition = 27;
            this.BrushesButton.LabelText = "Brushes";
            this.BrushesButton.Location = new System.Drawing.Point(658, 25);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(90, 70);
            this.BrushesButton.TabIndex = 8;
            this.BrushesButton.Click += new System.EventHandler(this.BrushesButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.color = System.Drawing.Color.Transparent;
            this.UndoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.UndoButton, BunifuAnimatorNS.DecorationType.None);
            this.UndoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.UndoButton.ForeColor = System.Drawing.Color.Black;
            this.UndoButton.Image = global::PaintUI.Properties.Resources.UndoIcon;
            this.UndoButton.ImagePosition = -5;
            this.UndoButton.ImageZoom = 60;
            this.UndoButton.LabelPosition = 27;
            this.UndoButton.LabelText = "Undo";
            this.UndoButton.Location = new System.Drawing.Point(1180, 35);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(70, 60);
            this.UndoButton.TabIndex = 10;
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ShapesButton
            // 
            this.ShapesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShapesButton.AutoSize = true;
            this.ShapesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShapesButton.color = System.Drawing.Color.Transparent;
            this.ShapesButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.ShapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ShapesButton, BunifuAnimatorNS.DecorationType.None);
            this.ShapesButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.ShapesButton.ForeColor = System.Drawing.Color.Black;
            this.ShapesButton.Image = global::PaintUI.Properties.Resources._2dShape;
            this.ShapesButton.ImagePosition = -6;
            this.ShapesButton.ImageZoom = 60;
            this.ShapesButton.LabelPosition = 30;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(470, 26);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(86, 70);
            this.ShapesButton.TabIndex = 6;
            this.ShapesButton.Click += new System.EventHandler(this.ShapesButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeButton.Image = global::PaintUI.Properties.Resources.min;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1319, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.MaximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeButton.Image = global::PaintUI.Properties.Resources.max;
            this.MaximizeButton.ImageActive = null;
            this.MaximizeButton.Location = new System.Drawing.Point(1355, 3);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.color = System.Drawing.Color.Transparent;
            this.MenuButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Black;
            this.MenuButton.Image = global::PaintUI.Properties.Resources.MenuIcon;
            this.MenuButton.ImagePosition = -5;
            this.MenuButton.ImageZoom = 62;
            this.MenuButton.LabelPosition = 34;
            this.MenuButton.LabelText = "Menu";
            this.MenuButton.Location = new System.Drawing.Point(16, 27);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(5);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(87, 70);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextButton.AutoSize = true;
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.color = System.Drawing.Color.Transparent;
            this.TextButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.TextButton, BunifuAnimatorNS.DecorationType.None);
            this.TextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.ForeColor = System.Drawing.Color.Black;
            this.TextButton.Image = global::PaintUI.Properties.Resources.TextIcon;
            this.TextButton.ImagePosition = -13;
            this.TextButton.ImageZoom = 80;
            this.TextButton.LabelPosition = 34;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(381, 27);
            this.TextButton.Margin = new System.Windows.Forms.Padding(5);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(80, 70);
            this.TextButton.TabIndex = 5;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.doubleBufferPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // OpenLayerListButton
            // 
            this.OpenLayerListButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.OpenLayerListButton, BunifuAnimatorNS.DecorationType.None);
            this.OpenLayerListButton.Image = global::PaintUI.Properties.Resources.lay;
            this.OpenLayerListButton.ImageActive = null;
            this.OpenLayerListButton.Location = new System.Drawing.Point(1040, 0);
            this.OpenLayerListButton.Name = "OpenLayerListButton";
            this.OpenLayerListButton.Size = new System.Drawing.Size(60, 58);
            this.OpenLayerListButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OpenLayerListButton.TabIndex = 32;
            this.OpenLayerListButton.TabStop = false;
            this.OpenLayerListButton.Zoom = 5;
            this.OpenLayerListButton.Click += new System.EventHandler(this.OpenLayerListButton_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1430, 882);
            this.Controls.Add(this.panelCavas);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.doubleBufferPanel2);
            this.Controls.Add(this.doubleBufferPanel1);
            this.Controls.Add(this.RightTopPanel_1);
            this.Controls.Add(this.LeftBottomPanel_1);
            this.Controls.Add(this.Leftpanel);
            this.Controls.Add(this.LeftTopPanel_1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.RightBottomPanel_1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Paint";
            this.EditPanel.ResumeLayout(false);
            this.panelCavas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.doubleBufferPanel2.ResumeLayout(false);
            this.doubleBufferPanel1.ResumeLayout(false);
            this.doubleBufferPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenLayerListButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private DoubleBufferPanel LeftTopPanel;
        private DoubleBufferPanel RightBottomPanel;
        private DoubleBufferPanel LeftBottomPanel;
        private DoubleBufferPanel RightTopPanel;
        private Canvas SketchBox;
        private Bunifu.Framework.UI.BunifuTileButton RedoButton;
        private Bunifu.Framework.UI.BunifuTileButton UndoButton;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuTileButton MenuButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private EffectsPanel effectsPanel;
        private CanvasPanel canvasPanel;
        private TextPanel textPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftTopPanel_1;
        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel LeftBottomPanel_1;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightBottomPanel_1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel RightTopPanel_1;
        private DoubleBufferPanel doubleBufferPanel2;
        private System.Windows.Forms.Panel EditPanel;
        private Bunifu.Framework.UI.BunifuFlatButton SelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton MoveButton;
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private MenuPanel menuPanel;
        private DoubleBufferPanel panelCavas;
        private DoubleBufferPanel doubleBufferPanel1;
        private System.Windows.Forms.Label titleLb;
        private ShapesPanel shapesPanel;
        private BrushesPanel brushesPanel;
        private LayerPanel layerPanel;
        private Bunifu.Framework.UI.BunifuImageButton OpenLayerListButton;
    }
}

