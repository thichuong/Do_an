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
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.RedoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.UndoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FillButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EraserButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.SketchBox = new System.Windows.Forms.PictureBox();
            this.MenuPanel1 = new PaintUI.MenuPanel();
            this.TextPanel1 = new PaintUI.TextPanel();
            this.ShapesPanel1 = new PaintUI.ShapesPanel();
            this.CanvasPanel1 = new PaintUI.CanvasPanel();
            this.BrushesPanel1 = new PaintUI.BrushesPanel();
            this.EffectsPanel1 = new PaintUI.EffectsPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.RedoButton);
            this.bunifuGradientPanel1.Controls.Add(this.UndoButton);
            this.bunifuGradientPanel1.Controls.Add(this.EffectsButton);
            this.bunifuGradientPanel1.Controls.Add(this.BrushesButton);
            this.bunifuGradientPanel1.Controls.Add(this.CanvasButton);
            this.bunifuGradientPanel1.Controls.Add(this.ShapesButton);
            this.bunifuGradientPanel1.Controls.Add(this.TextButton);
            this.bunifuGradientPanel1.Controls.Add(this.MenuButton);
            this.bunifuGradientPanel1.Controls.Add(this.MinimizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.MaximizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.CloseButton);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Aqua;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1280, 110);
            this.bunifuGradientPanel1.TabIndex = 0;
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
            this.RedoButton.LabelPosition = 30;
            this.RedoButton.LabelText = "Redo";
            this.RedoButton.Location = new System.Drawing.Point(1110, 50);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(4);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(70, 60);
            this.RedoButton.TabIndex = 11;
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
            this.UndoButton.LabelPosition = 30;
            this.UndoButton.LabelText = "Undo";
            this.UndoButton.Location = new System.Drawing.Point(1039, 50);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(71, 60);
            this.UndoButton.TabIndex = 10;
            // 
            // EffectsButton
            // 
            this.EffectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EffectsButton.BackColor = System.Drawing.Color.Transparent;
            this.EffectsButton.color = System.Drawing.Color.Transparent;
            this.EffectsButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.EffectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.EffectsButton, BunifuAnimatorNS.DecorationType.None);
            this.EffectsButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.EffectsButton.ForeColor = System.Drawing.Color.Black;
            this.EffectsButton.Image = global::PaintUI.Properties.Resources.EffectIcon;
            this.EffectsButton.ImagePosition = -3;
            this.EffectsButton.ImageZoom = 55;
            this.EffectsButton.LabelPosition = 30;
            this.EffectsButton.LabelText = "Effects";
            this.EffectsButton.Location = new System.Drawing.Point(800, 36);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(90, 70);
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
            this.bunifuTransition1.SetDecoration(this.BrushesButton, BunifuAnimatorNS.DecorationType.None);
            this.BrushesButton.Font = new System.Drawing.Font("Segoe Print", 10.5F);
            this.BrushesButton.ForeColor = System.Drawing.Color.Black;
            this.BrushesButton.Image = global::PaintUI.Properties.Resources.BrushesIcon;
            this.BrushesButton.ImagePosition = -1;
            this.BrushesButton.ImageZoom = 60;
            this.BrushesButton.LabelPosition = 27;
            this.BrushesButton.LabelText = "Brushes";
            this.BrushesButton.Location = new System.Drawing.Point(680, 36);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(90, 70);
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
            this.bunifuTransition1.SetDecoration(this.CanvasButton, BunifuAnimatorNS.DecorationType.None);
            this.CanvasButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.CanvasButton.ForeColor = System.Drawing.Color.Black;
            this.CanvasButton.Image = global::PaintUI.Properties.Resources.CanvasIcon;
            this.CanvasButton.ImagePosition = -6;
            this.CanvasButton.ImageZoom = 60;
            this.CanvasButton.LabelPosition = 30;
            this.CanvasButton.LabelText = "Canvas";
            this.CanvasButton.Location = new System.Drawing.Point(560, 36);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(86, 70);
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
            this.bunifuTransition1.SetDecoration(this.ShapesButton, BunifuAnimatorNS.DecorationType.None);
            this.ShapesButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.ShapesButton.ForeColor = System.Drawing.Color.Black;
            this.ShapesButton.Image = global::PaintUI.Properties.Resources._2dShape;
            this.ShapesButton.ImagePosition = -6;
            this.ShapesButton.ImageZoom = 60;
            this.ShapesButton.LabelPosition = 30;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(440, 36);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(86, 70);
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
            this.bunifuTransition1.SetDecoration(this.TextButton, BunifuAnimatorNS.DecorationType.None);
            this.TextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.ForeColor = System.Drawing.Color.Black;
            this.TextButton.Image = global::PaintUI.Properties.Resources.TextIcon;
            this.TextButton.ImagePosition = -13;
            this.TextButton.ImageZoom = 80;
            this.TextButton.LabelPosition = 34;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(320, 36);
            this.TextButton.Margin = new System.Windows.Forms.Padding(5);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(80, 70);
            this.TextButton.TabIndex = 5;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.color = System.Drawing.Color.Transparent;
            this.MenuButton.colorActive = System.Drawing.Color.DarkTurquoise;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.MenuButton, BunifuAnimatorNS.DecorationType.None);
            this.MenuButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.ForeColor = System.Drawing.Color.Black;
            this.MenuButton.Image = global::PaintUI.Properties.Resources.MenuIcon;
            this.MenuButton.ImagePosition = -5;
            this.MenuButton.ImageZoom = 65;
            this.MenuButton.LabelPosition = 34;
            this.MenuButton.LabelText = "Menu";
            this.MenuButton.Location = new System.Drawing.Point(10, 36);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(5);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(80, 70);
            this.MenuButton.TabIndex = 4;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeButton.Image = global::PaintUI.Properties.Resources.min;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1155, 10);
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
            this.MaximizeButton.Location = new System.Drawing.Point(1200, 10);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
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
            this.bunifuTransition1.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseButton.Image = global::PaintUI.Properties.Resources.exit1;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(1240, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.FillButton);
            this.panel1.Controls.Add(this.EraserButton);
            this.panel1.Controls.Add(this.MoveButton);
            this.panel1.Controls.Add(this.ZoomButton);
            this.panel1.Controls.Add(this.PanButton);
            this.panel1.Controls.Add(this.SelectButton);
            this.panel1.Controls.Add(this.CropButton);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 60);
            this.panel1.TabIndex = 1;
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
            this.ZoomButton.Click += new System.EventHandler(this.ZoomButton_Click);
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
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation5;
            // 
            // SketchBox
            // 
            this.SketchBox.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.SketchBox, BunifuAnimatorNS.DecorationType.None);
            this.SketchBox.Location = new System.Drawing.Point(80, 220);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(750, 450);
            this.SketchBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SketchBox.TabIndex = 3;
            this.SketchBox.TabStop = false;
            this.SketchBox.Paint += new System.Windows.Forms.PaintEventHandler(this.SketchBox_Paint);
            this.SketchBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseDown);
            this.SketchBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseMove);
            this.SketchBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SketchBox_MouseUp);
            // 
            // MenuPanel1
            // 
            this.bunifuTransition1.SetDecoration(this.MenuPanel1, BunifuAnimatorNS.DecorationType.None);
            this.MenuPanel1.Location = new System.Drawing.Point(0, 110);
            this.MenuPanel1.Name = "MenuPanel1";
            this.MenuPanel1.Size = new System.Drawing.Size(200, 210);
            this.MenuPanel1.TabIndex = 18;
            // 
            // TextPanel1
            // 
            this.TextPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.TextPanel1, BunifuAnimatorNS.DecorationType.None);
            this.TextPanel1.Location = new System.Drawing.Point(980, 170);
            this.TextPanel1.Name = "TextPanel1";
            this.TextPanel1.Size = new System.Drawing.Size(300, 551);
            this.TextPanel1.TabIndex = 17;
            // 
            // ShapesPanel1
            // 
            this.ShapesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.ShapesPanel1, BunifuAnimatorNS.DecorationType.None);
            this.ShapesPanel1.Location = new System.Drawing.Point(980, 170);
            this.ShapesPanel1.Name = "ShapesPanel1";
            this.ShapesPanel1.Size = new System.Drawing.Size(300, 551);
            this.ShapesPanel1.TabIndex = 16;
            // 
            // CanvasPanel1
            // 
            this.CanvasPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.CanvasPanel1, BunifuAnimatorNS.DecorationType.None);
            this.CanvasPanel1.Location = new System.Drawing.Point(980, 170);
            this.CanvasPanel1.Name = "CanvasPanel1";
            this.CanvasPanel1.Size = new System.Drawing.Size(300, 551);
            this.CanvasPanel1.TabIndex = 15;
            // 
            // BrushesPanel1
            // 
            this.BrushesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.BrushesPanel1, BunifuAnimatorNS.DecorationType.None);
            this.BrushesPanel1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BrushesPanel1.Location = new System.Drawing.Point(980, 170);
            this.BrushesPanel1.Name = "BrushesPanel1";
            this.BrushesPanel1.Size = new System.Drawing.Size(300, 551);
            this.BrushesPanel1.TabIndex = 14;
            // 
            // EffectsPanel1
            // 
            this.EffectsPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.EffectsPanel1, BunifuAnimatorNS.DecorationType.None);
            this.EffectsPanel1.Location = new System.Drawing.Point(980, 170);
            this.EffectsPanel1.Name = "EffectsPanel1";
            this.EffectsPanel1.Size = new System.Drawing.Size(300, 551);
            this.EffectsPanel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MenuPanel1);
            this.Controls.Add(this.TextPanel1);
            this.Controls.Add(this.ShapesPanel1);
            this.Controls.Add(this.CanvasPanel1);
            this.Controls.Add(this.BrushesPanel1);
            this.Controls.Add(this.EffectsPanel1);
            this.Controls.Add(this.SketchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTileButton MenuButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private Bunifu.Framework.UI.BunifuFlatButton SelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton EraserButton;
        private Bunifu.Framework.UI.BunifuFlatButton MoveButton;
        private System.Windows.Forms.PictureBox SketchBox;
        private Bunifu.Framework.UI.BunifuFlatButton FillButton;
        private Bunifu.Framework.UI.BunifuTileButton RedoButton;
        private Bunifu.Framework.UI.BunifuTileButton UndoButton;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private EffectsPanel EffectsPanel1;
        private BrushesPanel BrushesPanel1;
        private CanvasPanel CanvasPanel1;
        private ShapesPanel ShapesPanel1;
        private TextPanel TextPanel1;
        private MenuPanel MenuPanel1;
    }
}

