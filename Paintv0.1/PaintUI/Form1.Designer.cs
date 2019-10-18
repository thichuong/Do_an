namespace PaintUI
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.FillButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EraserButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SketchBox = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ToolsPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.RedoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UndoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.brushesPanel = new PaintUI.BrushesPanel();
            this.textPanel = new PaintUI.TextPanel();
            this.shapesPanel = new PaintUI.ShapesPanel();
            this.effectsPanel = new PaintUI.EffectsPanel();
            this.canvasPanel = new PaintUI.CanvasPanel();
            this.menuPanel1 = new PaintUI.MenuPanel();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BunifuElipse1
            // 
            this.BunifuElipse1.ElipseRadius = 5;
            this.BunifuElipse1.TargetControl = this;
            // 
            // BunifuDragControl1
            // 
            this.BunifuDragControl1.Fixed = true;
            this.BunifuDragControl1.Horizontal = true;
            this.BunifuDragControl1.TargetControl = null;
            this.BunifuDragControl1.Vertical = true;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeButton.Image = global::PaintUI.Properties.Resources.min;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1305, 14);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(34, 38);
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
            this.BunifuTransition1.SetDecoration(this.MaximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MaximizeButton.Image = global::PaintUI.Properties.Resources.max;
            this.MaximizeButton.ImageActive = null;
            this.MaximizeButton.Location = new System.Drawing.Point(1354, 14);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(34, 38);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.BunifuTransition1.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseButton.Image = global::PaintUI.Properties.Resources.exit1;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(1394, 14);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(34, 38);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditPanel.Controls.Add(this.FillButton);
            this.EditPanel.Controls.Add(this.EraserButton);
            this.EditPanel.Controls.Add(this.MoveButton);
            this.EditPanel.Controls.Add(this.ZoomButton);
            this.EditPanel.Controls.Add(this.PanButton);
            this.EditPanel.Controls.Add(this.SelectButton);
            this.EditPanel.Controls.Add(this.CropButton);
            this.BunifuTransition1.SetDecoration(this.EditPanel, BunifuAnimatorNS.DecorationType.None);
            this.EditPanel.Location = new System.Drawing.Point(1, 174);
            this.EditPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1441, 75);
            this.EditPanel.TabIndex = 1;
            // 
            // FillButton
            // 
            this.FillButton.Activecolor = System.Drawing.Color.Transparent;
            this.FillButton.BackColor = System.Drawing.Color.Transparent;
            this.FillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FillButton.BorderRadius = 0;
            this.FillButton.ButtonText = "Fill  ";
            this.FillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.FillButton, BunifuAnimatorNS.DecorationType.None);
            this.FillButton.DisabledColor = System.Drawing.Color.Gray;
            this.FillButton.Iconcolor = System.Drawing.Color.Transparent;
            this.FillButton.Iconimage = global::PaintUI.Properties.Resources.FillIcon;
            this.FillButton.Iconimage_right = null;
            this.FillButton.Iconimage_right_Selected = null;
            this.FillButton.Iconimage_Selected = null;
            this.FillButton.IconMarginLeft = 0;
            this.FillButton.IconMarginRight = 0;
            this.FillButton.IconRightVisible = true;
            this.FillButton.IconRightZoom = 0D;
            this.FillButton.IconVisible = true;
            this.FillButton.IconZoom = 55D;
            this.FillButton.IsTab = false;
            this.FillButton.Location = new System.Drawing.Point(900, 0);
            this.FillButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.FillButton.Name = "FillButton";
            this.FillButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FillButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.FillButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FillButton.selected = false;
            this.FillButton.Size = new System.Drawing.Size(146, 75);
            this.FillButton.TabIndex = 7;
            this.FillButton.Text = "Fill  ";
            this.FillButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FillButton.Textcolor = System.Drawing.Color.Black;
            this.FillButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // EraserButton
            // 
            this.EraserButton.Activecolor = System.Drawing.Color.Transparent;
            this.EraserButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EraserButton.BorderRadius = 0;
            this.EraserButton.ButtonText = "Eraser ";
            this.EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.EraserButton, BunifuAnimatorNS.DecorationType.None);
            this.EraserButton.DisabledColor = System.Drawing.Color.Gray;
            this.EraserButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EraserButton.Iconimage = global::PaintUI.Properties.Resources._123;
            this.EraserButton.Iconimage_right = null;
            this.EraserButton.Iconimage_right_Selected = null;
            this.EraserButton.Iconimage_Selected = null;
            this.EraserButton.IconMarginLeft = 0;
            this.EraserButton.IconMarginRight = 0;
            this.EraserButton.IconRightVisible = true;
            this.EraserButton.IconRightZoom = 0D;
            this.EraserButton.IconVisible = true;
            this.EraserButton.IconZoom = 55D;
            this.EraserButton.IsTab = false;
            this.EraserButton.Location = new System.Drawing.Point(742, 0);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EraserButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.EraserButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.EraserButton.selected = false;
            this.EraserButton.Size = new System.Drawing.Size(158, 75);
            this.EraserButton.TabIndex = 6;
            this.EraserButton.Text = "Eraser ";
            this.EraserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraserButton.Textcolor = System.Drawing.Color.Black;
            this.EraserButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // MoveButton
            // 
            this.MoveButton.Activecolor = System.Drawing.Color.Transparent;
            this.MoveButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveButton.BorderRadius = 0;
            this.MoveButton.ButtonText = "Move ";
            this.MoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.MoveButton, BunifuAnimatorNS.DecorationType.None);
            this.MoveButton.DisabledColor = System.Drawing.Color.Gray;
            this.MoveButton.Iconcolor = System.Drawing.Color.Transparent;
            this.MoveButton.Iconimage = global::PaintUI.Properties.Resources.MoveIcon;
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
            this.MoveButton.Location = new System.Drawing.Point(596, 0);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MoveButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.MoveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.MoveButton.selected = false;
            this.MoveButton.Size = new System.Drawing.Size(146, 75);
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
            this.BunifuTransition1.SetDecoration(this.ZoomButton, BunifuAnimatorNS.DecorationType.None);
            this.ZoomButton.DisabledColor = System.Drawing.Color.Gray;
            this.ZoomButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.Iconimage = global::PaintUI.Properties.Resources.ZoomIcon;
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
            this.ZoomButton.Location = new System.Drawing.Point(450, 0);
            this.ZoomButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.ZoomButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ZoomButton.selected = false;
            this.ZoomButton.Size = new System.Drawing.Size(146, 75);
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
            this.BunifuTransition1.SetDecoration(this.PanButton, BunifuAnimatorNS.DecorationType.None);
            this.PanButton.DisabledColor = System.Drawing.Color.Gray;
            this.PanButton.Iconcolor = System.Drawing.Color.Transparent;
            this.PanButton.Iconimage = global::PaintUI.Properties.Resources.pan_symbol;
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
            this.PanButton.Location = new System.Drawing.Point(304, 0);
            this.PanButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.PanButton.Name = "PanButton";
            this.PanButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PanButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.PanButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PanButton.selected = false;
            this.PanButton.Size = new System.Drawing.Size(146, 75);
            this.PanButton.TabIndex = 3;
            this.PanButton.Text = "Pan  ";
            this.PanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PanButton.Textcolor = System.Drawing.Color.Black;
            this.PanButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // SelectButton
            // 
            this.SelectButton.Activecolor = System.Drawing.Color.Transparent;
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButton.BorderRadius = 0;
            this.SelectButton.ButtonText = "Select  ";
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.SelectButton, BunifuAnimatorNS.DecorationType.None);
            this.SelectButton.DisabledColor = System.Drawing.Color.Gray;
            this.SelectButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SelectButton.Iconimage = global::PaintUI.Properties.Resources.selecticon;
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
            this.SelectButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SelectButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.SelectButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SelectButton.selected = false;
            this.SelectButton.Size = new System.Drawing.Size(158, 75);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select  ";
            this.SelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectButton.Textcolor = System.Drawing.Color.Black;
            this.SelectButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // CropButton
            // 
            this.CropButton.Activecolor = System.Drawing.Color.Transparent;
            this.CropButton.BackColor = System.Drawing.Color.Transparent;
            this.CropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CropButton.BorderRadius = 0;
            this.CropButton.ButtonText = "Crop ";
            this.CropButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.CropButton, BunifuAnimatorNS.DecorationType.None);
            this.CropButton.DisabledColor = System.Drawing.Color.Gray;
            this.CropButton.Iconcolor = System.Drawing.Color.Transparent;
            this.CropButton.Iconimage = global::PaintUI.Properties.Resources.crop_icon;
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
            this.CropButton.Location = new System.Drawing.Point(158, 0);
            this.CropButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.CropButton.Name = "CropButton";
            this.CropButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CropButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.CropButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.CropButton.selected = false;
            this.CropButton.Size = new System.Drawing.Size(146, 75);
            this.CropButton.TabIndex = 1;
            this.CropButton.Text = "Crop ";
            this.CropButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CropButton.Textcolor = System.Drawing.Color.Black;
            this.CropButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            // 
            // BunifuTransition1
            // 
            this.BunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.BunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.BunifuTransition1.DefaultAnimation = animation2;
            // 
            // SketchBox
            // 
            this.SketchBox.BackColor = System.Drawing.Color.White;
            this.BunifuTransition1.SetDecoration(this.SketchBox, BunifuAnimatorNS.DecorationType.None);
            this.SketchBox.Location = new System.Drawing.Point(0, 243);
            this.SketchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(1100, 685);
            this.SketchBox.TabIndex = 3;
            this.SketchBox.TabStop = false;
            this.SketchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SketchBox_Paint);
            this.SketchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseDown);
            this.SketchBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseMove);
            this.SketchBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseUp);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.CloseButton);
            this.bunifuGradientPanel1.Controls.Add(this.MaximizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.MinimizeButton);
            this.BunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -1);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1440, 59);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // ToolsPanel
            // 
            this.ToolsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ToolsPanel.BackgroundImage")));
            this.ToolsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsPanel.Controls.Add(this.RedoButton);
            this.ToolsPanel.Controls.Add(this.UndoButton);
            this.ToolsPanel.Controls.Add(this.EffectsButton);
            this.ToolsPanel.Controls.Add(this.BrushesButton);
            this.ToolsPanel.Controls.Add(this.CanvasButton);
            this.ToolsPanel.Controls.Add(this.ShapesButton);
            this.ToolsPanel.Controls.Add(this.TextButton);
            this.ToolsPanel.Controls.Add(this.MenuButton);
            this.BunifuTransition1.SetDecoration(this.ToolsPanel, BunifuAnimatorNS.DecorationType.None);
            this.ToolsPanel.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.ToolsPanel.GradientBottomRight = System.Drawing.Color.DimGray;
            this.ToolsPanel.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.ToolsPanel.GradientTopRight = System.Drawing.Color.Red;
            this.ToolsPanel.Location = new System.Drawing.Point(3, 57);
            this.ToolsPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Quality = 10;
            this.ToolsPanel.Size = new System.Drawing.Size(1440, 117);
            this.ToolsPanel.TabIndex = 4;
            // 
            // RedoButton
            // 
            this.RedoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.color = System.Drawing.Color.Transparent;
            this.RedoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.RedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.RedoButton, BunifuAnimatorNS.DecorationType.None);
            this.RedoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.RedoButton.ForeColor = System.Drawing.Color.Black;
            this.RedoButton.Image = global::PaintUI.Properties.Resources.RedoIcon;
            this.RedoButton.ImagePosition = -5;
            this.RedoButton.ImageZoom = 60;
            this.RedoButton.LabelPosition = 30;
            this.RedoButton.LabelText = "Redo";
            this.RedoButton.Location = new System.Drawing.Point(1196, 32);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(79, 75);
            this.RedoButton.TabIndex = 11;
            // 
            // UndoButton
            // 
            this.UndoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.color = System.Drawing.Color.Transparent;
            this.UndoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.UndoButton, BunifuAnimatorNS.DecorationType.None);
            this.UndoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.UndoButton.ForeColor = System.Drawing.Color.Black;
            this.UndoButton.Image = global::PaintUI.Properties.Resources.UndoIcon;
            this.UndoButton.ImagePosition = -5;
            this.UndoButton.ImageZoom = 60;
            this.UndoButton.LabelPosition = 30;
            this.UndoButton.LabelText = "Undo";
            this.UndoButton.Location = new System.Drawing.Point(1099, 32);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(80, 75);
            this.UndoButton.TabIndex = 10;
            // 
            // EffectsButton
            // 
            this.EffectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EffectsButton.BackColor = System.Drawing.Color.Transparent;
            this.EffectsButton.color = System.Drawing.Color.Transparent;
            this.EffectsButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.EffectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.EffectsButton, BunifuAnimatorNS.DecorationType.None);
            this.EffectsButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.EffectsButton.ForeColor = System.Drawing.Color.Black;
            this.EffectsButton.Image = global::PaintUI.Properties.Resources.EffectIcon;
            this.EffectsButton.ImagePosition = -3;
            this.EffectsButton.ImageZoom = 55;
            this.EffectsButton.LabelPosition = 30;
            this.EffectsButton.LabelText = "Effects";
            this.EffectsButton.Location = new System.Drawing.Point(897, 19);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(101, 88);
            this.EffectsButton.TabIndex = 9;
            this.EffectsButton.Click += new System.EventHandler(this.EffectsButton_Click);
            // 
            // BrushesButton
            // 
            this.BrushesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrushesButton.BackColor = System.Drawing.Color.Transparent;
            this.BrushesButton.color = System.Drawing.Color.Transparent;
            this.BrushesButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.BrushesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.BrushesButton, BunifuAnimatorNS.DecorationType.None);
            this.BrushesButton.Font = new System.Drawing.Font("Segoe Print", 10.5F);
            this.BrushesButton.ForeColor = System.Drawing.Color.Black;
            this.BrushesButton.Image = global::PaintUI.Properties.Resources.BrushesIcon;
            this.BrushesButton.ImagePosition = -1;
            this.BrushesButton.ImageZoom = 60;
            this.BrushesButton.LabelPosition = 27;
            this.BrushesButton.LabelText = "Brushes";
            this.BrushesButton.Location = new System.Drawing.Point(761, 19);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(101, 88);
            this.BrushesButton.TabIndex = 8;
            this.BrushesButton.Click += new System.EventHandler(this.BrushesButton_Click);
            // 
            // CanvasButton
            // 
            this.CanvasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CanvasButton.BackColor = System.Drawing.Color.Transparent;
            this.CanvasButton.color = System.Drawing.Color.Transparent;
            this.CanvasButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.CanvasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.CanvasButton, BunifuAnimatorNS.DecorationType.None);
            this.CanvasButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.CanvasButton.ForeColor = System.Drawing.Color.Black;
            this.CanvasButton.Image = global::PaintUI.Properties.Resources.CanvasIcon;
            this.CanvasButton.ImagePosition = -6;
            this.CanvasButton.ImageZoom = 60;
            this.CanvasButton.LabelPosition = 30;
            this.CanvasButton.LabelText = "Canvas";
            this.CanvasButton.Location = new System.Drawing.Point(630, 19);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(97, 88);
            this.CanvasButton.TabIndex = 7;
            this.CanvasButton.Click += new System.EventHandler(this.CanvasButton_Click);
            // 
            // ShapesButton
            // 
            this.ShapesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShapesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShapesButton.color = System.Drawing.Color.Transparent;
            this.ShapesButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.ShapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.ShapesButton, BunifuAnimatorNS.DecorationType.None);
            this.ShapesButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.ShapesButton.ForeColor = System.Drawing.Color.Black;
            this.ShapesButton.Image = global::PaintUI.Properties.Resources._2dShape;
            this.ShapesButton.ImagePosition = -6;
            this.ShapesButton.ImageZoom = 60;
            this.ShapesButton.LabelPosition = 30;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(496, 19);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(97, 88);
            this.ShapesButton.TabIndex = 6;
            this.ShapesButton.Click += new System.EventHandler(this.ShapesButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.color = System.Drawing.Color.Transparent;
            this.TextButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.TextButton, BunifuAnimatorNS.DecorationType.None);
            this.TextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.ForeColor = System.Drawing.Color.Black;
            this.TextButton.Image = global::PaintUI.Properties.Resources.TextIcon;
            this.TextButton.ImagePosition = -13;
            this.TextButton.ImageZoom = 80;
            this.TextButton.LabelPosition = 34;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(357, 19);
            this.TextButton.Margin = new System.Windows.Forms.Padding(6);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(90, 88);
            this.TextButton.TabIndex = 5;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.color = System.Drawing.Color.Transparent;
            this.MenuButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BunifuTransition1.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Black;
            this.MenuButton.Image = global::PaintUI.Properties.Resources.MenuIcon;
            this.MenuButton.ImagePosition = -5;
            this.MenuButton.ImageZoom = 65;
            this.MenuButton.LabelPosition = 34;
            this.MenuButton.LabelText = "Menu";
            this.MenuButton.Location = new System.Drawing.Point(12, 19);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(6);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(90, 88);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // brushesPanel
            // 
            this.brushesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.brushesPanel, BunifuAnimatorNS.DecorationType.None);
            this.brushesPanel.Location = new System.Drawing.Point(1098, 247);
            this.brushesPanel.Name = "brushesPanel";
            this.brushesPanel.Size = new System.Drawing.Size(342, 681);
            this.brushesPanel.TabIndex = 13;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.textPanel, BunifuAnimatorNS.DecorationType.None);
            this.textPanel.Location = new System.Drawing.Point(1099, 248);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(342, 680);
            this.textPanel.TabIndex = 17;
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.shapesPanel, BunifuAnimatorNS.DecorationType.None);
            this.shapesPanel.Location = new System.Drawing.Point(1096, 243);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(342, 685);
            this.shapesPanel.TabIndex = 16;
            // 
            // effectsPanel
            // 
            this.effectsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.effectsPanel, BunifuAnimatorNS.DecorationType.None);
            this.effectsPanel.Location = new System.Drawing.Point(1098, 243);
            this.effectsPanel.Name = "effectsPanel";
            this.effectsPanel.Size = new System.Drawing.Size(342, 685);
            this.effectsPanel.TabIndex = 15;
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BunifuTransition1.SetDecoration(this.canvasPanel, BunifuAnimatorNS.DecorationType.None);
            this.canvasPanel.Location = new System.Drawing.Point(1098, 243);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(342, 685);
            this.canvasPanel.TabIndex = 14;
            // 
            // menuPanel1
            // 
            this.menuPanel1.BackColor = System.Drawing.Color.Aqua;
            this.BunifuTransition1.SetDecoration(this.menuPanel1, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel1.Location = new System.Drawing.Point(2, 58);
            this.menuPanel1.Name = "menuPanel1";
            this.menuPanel1.Size = new System.Drawing.Size(1435, 870);
            this.menuPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1440, 930);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.SketchBox);
            this.Controls.Add(this.brushesPanel);
            this.Controls.Add(this.textPanel);
            this.Controls.Add(this.shapesPanel);
            this.Controls.Add(this.effectsPanel);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.menuPanel1);
            this.BunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.EditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse BunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl BunifuDragControl1;
        private System.Windows.Forms.Panel EditPanel;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private Bunifu.Framework.UI.BunifuFlatButton SelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton EraserButton;
        private Bunifu.Framework.UI.BunifuFlatButton MoveButton;
        private System.Windows.Forms.PictureBox SketchBox;
        private Bunifu.Framework.UI.BunifuFlatButton FillButton;
        private BunifuAnimatorNS.BunifuTransition BunifuTransition1;
        private BrushesPanel brushesPanel;
        private ShapesPanel shapesPanel;
        private EffectsPanel effectsPanel;
        private CanvasPanel canvasPanel;
        private TextPanel textPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel ToolsPanel;
        private Bunifu.Framework.UI.BunifuTileButton RedoButton;
        private Bunifu.Framework.UI.BunifuTileButton UndoButton;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuTileButton MenuButton;
        private MenuPanel menuPanel1;
    }
}

