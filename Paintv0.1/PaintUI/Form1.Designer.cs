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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.EditPanel = new System.Windows.Forms.Panel();
            this.FillButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EraserButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.RedoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UndoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.colorPanel = new PaintUI.ColorPanel();
            this.brushesPanel = new PaintUI.BrushesPanel();
            this.textPanel = new PaintUI.TextPanel();
            this.effectsPanel = new PaintUI.EffectsPanel();
            this.canvasPanel = new PaintUI.CanvasPanel();
            this.shapesPanel = new PaintUI.ShapesPanel();
            this.ToolsPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelCavas = new PaintUI.DoubleBufferPanel();
            this.SketchBox = new PaintUI.Canvas();
            this.LeftTopPanel = new PaintUI.DoubleBufferPanel();
            this.RightTopPanel = new PaintUI.DoubleBufferPanel();
            this.RightBottomPanel = new PaintUI.DoubleBufferPanel();
            this.LeftBottomPanel = new PaintUI.DoubleBufferPanel();
            this.menuPanel = new PaintUI.MenuPanel();
            this.EditPanel.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.ToolsPanel.SuspendLayout();
            this.panelCavas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditPanel.Controls.Add(this.FillButton);
            this.EditPanel.Controls.Add(this.EraserButton);
            this.EditPanel.Controls.Add(this.MoveButton);
            this.EditPanel.Controls.Add(this.ZoomButton);
            this.EditPanel.Controls.Add(this.PanButton);
            this.EditPanel.Controls.Add(this.SelectButton);
            this.EditPanel.Controls.Add(this.CropButton);
            this.bunifuTransition1.SetDecoration(this.EditPanel, BunifuAnimatorNS.DecorationType.None);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPanel.Location = new System.Drawing.Point(0, 96);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1400, 60);
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
            this.bunifuTransition1.SetDecoration(this.FillButton, BunifuAnimatorNS.DecorationType.None);
            this.FillButton.DisabledColor = System.Drawing.Color.Gray;
            this.FillButton.Iconcolor = System.Drawing.Color.Transparent;
            this.FillButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("FillButton.Iconimage")));
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
            this.FillButton.Location = new System.Drawing.Point(800, 0);
            this.FillButton.Margin = new System.Windows.Forms.Padding(6);
            this.FillButton.Name = "FillButton";
            this.FillButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FillButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.FillButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FillButton.selected = false;
            this.FillButton.Size = new System.Drawing.Size(130, 60);
            this.FillButton.TabIndex = 7;
            this.FillButton.Text = "Fill  ";
            this.FillButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FillButton.Textcolor = System.Drawing.Color.Black;
            this.FillButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Activecolor = System.Drawing.Color.Transparent;
            this.EraserButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EraserButton.BorderRadius = 0;
            this.EraserButton.ButtonText = "Eraser ";
            this.EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.EraserButton, BunifuAnimatorNS.DecorationType.None);
            this.EraserButton.DisabledColor = System.Drawing.Color.Gray;
            this.EraserButton.Iconcolor = System.Drawing.Color.Transparent;
            this.EraserButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("EraserButton.Iconimage")));
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
            this.EraserButton.Location = new System.Drawing.Point(660, 0);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(6);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EraserButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.EraserButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.EraserButton.selected = false;
            this.EraserButton.Size = new System.Drawing.Size(140, 60);
            this.EraserButton.TabIndex = 6;
            this.EraserButton.Text = "Eraser ";
            this.EraserButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EraserButton.Textcolor = System.Drawing.Color.Black;
            this.EraserButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
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
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.TimeStep = 0.1F;
            // 
            // RedoButton
            // 
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.color = System.Drawing.Color.Transparent;
            this.RedoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.RedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.RedoButton, BunifuAnimatorNS.DecorationType.None);
            this.RedoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.RedoButton.ForeColor = System.Drawing.Color.Black;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.ImagePosition = -5;
            this.RedoButton.ImageZoom = 60;
            this.RedoButton.LabelPosition = 30;
            this.RedoButton.LabelText = "Redo";
            this.RedoButton.Location = new System.Drawing.Point(843, 16);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(71, 56);
            this.RedoButton.TabIndex = 11;
            // 
            // UndoButton
            // 
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.color = System.Drawing.Color.Transparent;
            this.UndoButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.UndoButton, BunifuAnimatorNS.DecorationType.None);
            this.UndoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.UndoButton.ForeColor = System.Drawing.Color.Black;
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.ImagePosition = -5;
            this.UndoButton.ImageZoom = 60;
            this.UndoButton.LabelPosition = 30;
            this.UndoButton.LabelText = "Undo";
            this.UndoButton.Location = new System.Drawing.Point(764, 16);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(71, 56);
            this.UndoButton.TabIndex = 10;
            // 
            // EffectsButton
            // 
            this.EffectsButton.BackColor = System.Drawing.Color.Transparent;
            this.EffectsButton.color = System.Drawing.Color.Transparent;
            this.EffectsButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.EffectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.EffectsButton, BunifuAnimatorNS.DecorationType.None);
            this.EffectsButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.EffectsButton.ForeColor = System.Drawing.Color.Black;
            this.EffectsButton.Image = ((System.Drawing.Image)(resources.GetObject("EffectsButton.Image")));
            this.EffectsButton.ImagePosition = -3;
            this.EffectsButton.ImageZoom = 65;
            this.EffectsButton.LabelPosition = 30;
            this.EffectsButton.LabelText = "Effects";
            this.EffectsButton.Location = new System.Drawing.Point(583, 13);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(89, 72);
            this.EffectsButton.TabIndex = 9;
            this.EffectsButton.Click += new System.EventHandler(this.EffectsButton_Click);
            // 
            // BrushesButton
            // 
            this.BrushesButton.BackColor = System.Drawing.Color.Transparent;
            this.BrushesButton.color = System.Drawing.Color.Transparent;
            this.BrushesButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.BrushesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BrushesButton, BunifuAnimatorNS.DecorationType.None);
            this.BrushesButton.Font = new System.Drawing.Font("Segoe Print", 10.5F);
            this.BrushesButton.ForeColor = System.Drawing.Color.Black;
            this.BrushesButton.Image = ((System.Drawing.Image)(resources.GetObject("BrushesButton.Image")));
            this.BrushesButton.ImagePosition = -1;
            this.BrushesButton.ImageZoom = 65;
            this.BrushesButton.LabelPosition = 27;
            this.BrushesButton.LabelText = "Brushes";
            this.BrushesButton.Location = new System.Drawing.Point(486, 14);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(89, 72);
            this.BrushesButton.TabIndex = 8;
            this.BrushesButton.Click += new System.EventHandler(this.BrushesButton_Click);
            // 
            // CanvasButton
            // 
            this.CanvasButton.BackColor = System.Drawing.Color.Transparent;
            this.CanvasButton.color = System.Drawing.Color.Transparent;
            this.CanvasButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.CanvasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.CanvasButton, BunifuAnimatorNS.DecorationType.None);
            this.CanvasButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.CanvasButton.ForeColor = System.Drawing.Color.Black;
            this.CanvasButton.Image = ((System.Drawing.Image)(resources.GetObject("CanvasButton.Image")));
            this.CanvasButton.ImagePosition = -6;
            this.CanvasButton.ImageZoom = 65;
            this.CanvasButton.LabelPosition = 30;
            this.CanvasButton.LabelText = "Canvas";
            this.CanvasButton.Location = new System.Drawing.Point(389, 14);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(89, 72);
            this.CanvasButton.TabIndex = 7;
            this.CanvasButton.Click += new System.EventHandler(this.CanvasButton_Click);
            // 
            // ShapesButton
            // 
            this.ShapesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShapesButton.color = System.Drawing.Color.Transparent;
            this.ShapesButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.ShapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ShapesButton, BunifuAnimatorNS.DecorationType.None);
            this.ShapesButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.ShapesButton.ForeColor = System.Drawing.Color.Black;
            this.ShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("ShapesButton.Image")));
            this.ShapesButton.ImagePosition = -6;
            this.ShapesButton.ImageZoom = 65;
            this.ShapesButton.LabelPosition = 30;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(292, 14);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(89, 72);
            this.ShapesButton.TabIndex = 6;
            this.ShapesButton.Click += new System.EventHandler(this.ShapesButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.color = System.Drawing.Color.Transparent;
            this.TextButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.TextButton, BunifuAnimatorNS.DecorationType.None);
            this.TextButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.ForeColor = System.Drawing.Color.Black;
            this.TextButton.Image = ((System.Drawing.Image)(resources.GetObject("TextButton.Image")));
            this.TextButton.ImagePosition = -11;
            this.TextButton.ImageZoom = 65;
            this.TextButton.LabelPosition = 28;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(194, 14);
            this.TextButton.Margin = new System.Windows.Forms.Padding(5);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(89, 72);
            this.TextButton.TabIndex = 5;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.color = System.Drawing.Color.Transparent;
            this.MenuButton.colorActive = System.Drawing.Color.DarkMagenta;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Black;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImagePosition = -4;
            this.MenuButton.ImageZoom = 65;
            this.MenuButton.LabelPosition = 28;
            this.MenuButton.LabelText = "Menu";
            this.MenuButton.Location = new System.Drawing.Point(5, 13);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(5);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(101, 72);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.colorPanel);
            this.bunifuGradientPanel2.Controls.Add(this.brushesPanel);
            this.bunifuGradientPanel2.Controls.Add(this.textPanel);
            this.bunifuGradientPanel2.Controls.Add(this.effectsPanel);
            this.bunifuGradientPanel2.Controls.Add(this.canvasPanel);
            this.bunifuGradientPanel2.Controls.Add(this.shapesPanel);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.LightCoral;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.MistyRose;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(1100, 156);
            this.bunifuGradientPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(300, 757);
            this.bunifuGradientPanel2.TabIndex = 20;
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.colorPanel, BunifuAnimatorNS.DecorationType.None);
            this.colorPanel.Location = new System.Drawing.Point(-1, 379);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(306, 281);
            this.colorPanel.TabIndex = 22;
            // 
            // brushesPanel
            // 
            this.brushesPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.brushesPanel, BunifuAnimatorNS.DecorationType.None);
            this.brushesPanel.Location = new System.Drawing.Point(1, 0);
            this.brushesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.brushesPanel.Name = "brushesPanel";
            this.brushesPanel.Size = new System.Drawing.Size(300, 350);
            this.brushesPanel.TabIndex = 21;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.textPanel, BunifuAnimatorNS.DecorationType.None);
            this.textPanel.Location = new System.Drawing.Point(1, 2);
            this.textPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(300, 350);
            this.textPanel.TabIndex = 0;
            // 
            // effectsPanel
            // 
            this.effectsPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.effectsPanel, BunifuAnimatorNS.DecorationType.None);
            this.effectsPanel.Location = new System.Drawing.Point(-1, 2);
            this.effectsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.effectsPanel.Name = "effectsPanel";
            this.effectsPanel.Size = new System.Drawing.Size(303, 354);
            this.effectsPanel.TabIndex = 2;
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.canvasPanel, BunifuAnimatorNS.DecorationType.None);
            this.canvasPanel.Location = new System.Drawing.Point(0, 2);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(300, 354);
            this.canvasPanel.TabIndex = 3;
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.shapesPanel, BunifuAnimatorNS.DecorationType.None);
            this.shapesPanel.Location = new System.Drawing.Point(-1, 2);
            this.shapesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(306, 353);
            this.shapesPanel.TabIndex = 1;
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
            this.bunifuTransition1.SetDecoration(this.ToolsPanel, BunifuAnimatorNS.DecorationType.None);
            this.ToolsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolsPanel.GradientBottomLeft = System.Drawing.Color.Magenta;
            this.ToolsPanel.GradientBottomRight = System.Drawing.Color.DimGray;
            this.ToolsPanel.GradientTopLeft = System.Drawing.Color.DarkRed;
            this.ToolsPanel.GradientTopRight = System.Drawing.Color.Red;
            this.ToolsPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolsPanel.Name = "ToolsPanel";
            this.ToolsPanel.Quality = 10;
            this.ToolsPanel.Size = new System.Drawing.Size(1400, 96);
            this.ToolsPanel.TabIndex = 4;
            // 
            // panelCavas
            // 
            this.panelCavas.Controls.Add(this.SketchBox);
            this.panelCavas.Controls.Add(this.LeftTopPanel);
            this.panelCavas.Controls.Add(this.RightTopPanel);
            this.panelCavas.Controls.Add(this.RightBottomPanel);
            this.panelCavas.Controls.Add(this.LeftBottomPanel);
            this.bunifuTransition1.SetDecoration(this.panelCavas, BunifuAnimatorNS.DecorationType.None);
            this.panelCavas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCavas.Location = new System.Drawing.Point(0, 156);
            this.panelCavas.Name = "panelCavas";
            this.panelCavas.Size = new System.Drawing.Size(1100, 757);
            this.panelCavas.TabIndex = 26;
            this.panelCavas.SizeChanged += new System.EventHandler(this.panelCavas_SizeChanged);
            // 
            // SketchBox
            // 
            this.SketchBox.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.SketchBox, BunifuAnimatorNS.DecorationType.None);
            this.SketchBox.Location = new System.Drawing.Point(62, 87);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(905, 534);
            this.SketchBox.TabIndex = 30;
            this.SketchBox.TabStop = false;
            this.SketchBox.LocationChanged += new System.EventHandler(this.SketchBox_LocationChanged);
            this.SketchBox.SizeChanged += new System.EventHandler(this.SketchBox_SizeChanged);
            this.SketchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SketchBox_Paint);
            this.SketchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseDown);
            this.SketchBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseMove);
            this.SketchBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseUp);
            // 
            // LeftTopPanel
            // 
            this.LeftTopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LeftTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.LeftTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftTopPanel.Location = new System.Drawing.Point(78, 70);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(10, 10);
            this.LeftTopPanel.TabIndex = 29;
            this.LeftTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseDown);
            this.LeftTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseMove);
            this.LeftTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseUp);
            // 
            // RightTopPanel
            // 
            this.RightTopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightTopPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.RightTopPanel, BunifuAnimatorNS.DecorationType.None);
            this.RightTopPanel.Location = new System.Drawing.Point(975, 70);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(10, 10);
            this.RightTopPanel.TabIndex = 27;
            this.RightTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseDown);
            this.RightTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseMove);
            this.RightTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_MouseUp);
            // 
            // RightBottomPanel
            // 
            this.RightBottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.RightBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bunifuTransition1.SetDecoration(this.RightBottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.RightBottomPanel.Location = new System.Drawing.Point(975, 641);
            this.RightBottomPanel.Name = "RightBottomPanel";
            this.RightBottomPanel.Size = new System.Drawing.Size(10, 10);
            this.RightBottomPanel.TabIndex = 27;
            this.RightBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
            this.RightBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
            this.RightBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
            // 
            // LeftBottomPanel
            // 
            this.LeftBottomPanel.BackColor = System.Drawing.SystemColors.Control;
            this.LeftBottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bunifuTransition1.SetDecoration(this.LeftBottomPanel, BunifuAnimatorNS.DecorationType.None);
            this.LeftBottomPanel.Location = new System.Drawing.Point(48, 627);
            this.LeftBottomPanel.Name = "LeftBottomPanel";
            this.LeftBottomPanel.Size = new System.Drawing.Size(10, 10);
            this.LeftBottomPanel.TabIndex = 27;
            this.LeftBottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseDown);
            this.LeftBottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseMove);
            this.LeftBottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftBottomPanel_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(300, 480);
            this.menuPanel.TabIndex = 19;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1400, 913);
            this.Controls.Add(this.panelCavas);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.ToolsPanel);
            this.Controls.Add(this.menuPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Paint";
            this.EditPanel.ResumeLayout(false);
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.ToolsPanel.ResumeLayout(false);
            this.panelCavas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel EditPanel;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private Bunifu.Framework.UI.BunifuFlatButton SelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton EraserButton;
        private Bunifu.Framework.UI.BunifuFlatButton MoveButton;
        private Bunifu.Framework.UI.BunifuFlatButton FillButton;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuTileButton RedoButton;
        private Bunifu.Framework.UI.BunifuTileButton UndoButton;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuTileButton MenuButton;
        private MenuPanel menuPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private TextPanel textPanel;
        private CanvasPanel canvasPanel;
        private EffectsPanel effectsPanel;
        private ShapesPanel shapesPanel;
        private BrushesPanel brushesPanel;
        private ColorPanel colorPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel ToolsPanel;
        private DoubleBufferPanel panelCavas;
        private DoubleBufferPanel LeftTopPanel;
        private DoubleBufferPanel RightBottomPanel;
        private DoubleBufferPanel LeftBottomPanel;
        private DoubleBufferPanel RightTopPanel;
        private Canvas SketchBox;
    }
}

