namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MoveButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.EraserButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FillButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.EffectsButton);
            this.bunifuGradientPanel1.Controls.Add(this.BrushesButton);
            this.bunifuGradientPanel1.Controls.Add(this.CanvasButton);
            this.bunifuGradientPanel1.Controls.Add(this.ShapesButton);
            this.bunifuGradientPanel1.Controls.Add(this.TextButton);
            this.bunifuGradientPanel1.Controls.Add(this.MenuButton);
            this.bunifuGradientPanel1.Controls.Add(this.MinimizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.MaximizeButton);
            this.bunifuGradientPanel1.Controls.Add(this.CloseButton);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(1240, 10);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.ImageActive = null;
            this.MaximizeButton.Location = new System.Drawing.Point(1200, 10);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(30, 30);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(1155, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Zoom = 10;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MenuButton
            // 
            this.MenuButton.BackColor = System.Drawing.Color.Transparent;
            this.MenuButton.color = System.Drawing.Color.Transparent;
            this.MenuButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Font = new System.Drawing.Font("Roboto", 13F);
            this.MenuButton.ForeColor = System.Drawing.Color.White;
            this.MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("MenuButton.Image")));
            this.MenuButton.ImagePosition = -5;
            this.MenuButton.ImageZoom = 70;
            this.MenuButton.LabelPosition = 26;
            this.MenuButton.LabelText = "Menu";
            this.MenuButton.Location = new System.Drawing.Point(10, 36);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(80, 70);
            this.MenuButton.TabIndex = 3;
            // 
            // TextButton
            // 
            this.TextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.color = System.Drawing.Color.Transparent;
            this.TextButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TextButton.Font = new System.Drawing.Font("Roboto", 13F);
            this.TextButton.ForeColor = System.Drawing.Color.White;
            this.TextButton.Image = ((System.Drawing.Image)(resources.GetObject("TextButton.Image")));
            this.TextButton.ImagePosition = -10;
            this.TextButton.ImageZoom = 80;
            this.TextButton.LabelPosition = 27;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(320, 36);
            this.TextButton.Margin = new System.Windows.Forms.Padding(4);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(80, 70);
            this.TextButton.TabIndex = 4;
            // 
            // ShapesButton
            // 
            this.ShapesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShapesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShapesButton.color = System.Drawing.Color.Transparent;
            this.ShapesButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.ShapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShapesButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.ShapesButton.ForeColor = System.Drawing.Color.White;
            this.ShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("ShapesButton.Image")));
            this.ShapesButton.ImagePosition = -5;
            this.ShapesButton.ImageZoom = 65;
            this.ShapesButton.LabelPosition = 23;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(440, 36);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(86, 70);
            this.ShapesButton.TabIndex = 5;
            // 
            // CanvasButton
            // 
            this.CanvasButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CanvasButton.BackColor = System.Drawing.Color.Transparent;
            this.CanvasButton.color = System.Drawing.Color.Transparent;
            this.CanvasButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.CanvasButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CanvasButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.CanvasButton.ForeColor = System.Drawing.Color.White;
            this.CanvasButton.Image = ((System.Drawing.Image)(resources.GetObject("CanvasButton.Image")));
            this.CanvasButton.ImagePosition = -5;
            this.CanvasButton.ImageZoom = 70;
            this.CanvasButton.LabelPosition = 23;
            this.CanvasButton.LabelText = "Canvas";
            this.CanvasButton.Location = new System.Drawing.Point(560, 36);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(4);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(86, 70);
            this.CanvasButton.TabIndex = 7;
            // 
            // BrushesButton
            // 
            this.BrushesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrushesButton.BackColor = System.Drawing.Color.Transparent;
            this.BrushesButton.color = System.Drawing.Color.Transparent;
            this.BrushesButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.BrushesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrushesButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.BrushesButton.ForeColor = System.Drawing.Color.White;
            this.BrushesButton.Image = ((System.Drawing.Image)(resources.GetObject("BrushesButton.Image")));
            this.BrushesButton.ImagePosition = 0;
            this.BrushesButton.ImageZoom = 65;
            this.BrushesButton.LabelPosition = 23;
            this.BrushesButton.LabelText = "Brushes";
            this.BrushesButton.Location = new System.Drawing.Point(680, 36);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(90, 70);
            this.BrushesButton.TabIndex = 8;
            // 
            // EffectsButton
            // 
            this.EffectsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EffectsButton.BackColor = System.Drawing.Color.Transparent;
            this.EffectsButton.color = System.Drawing.Color.Transparent;
            this.EffectsButton.colorActive = System.Drawing.Color.DeepSkyBlue;
            this.EffectsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EffectsButton.Font = new System.Drawing.Font("Roboto", 12F);
            this.EffectsButton.ForeColor = System.Drawing.Color.White;
            this.EffectsButton.Image = ((System.Drawing.Image)(resources.GetObject("EffectsButton.Image")));
            this.EffectsButton.ImagePosition = 0;
            this.EffectsButton.ImageZoom = 60;
            this.EffectsButton.LabelPosition = 23;
            this.EffectsButton.LabelText = "Effects";
            this.EffectsButton.Location = new System.Drawing.Point(800, 36);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(90, 70);
            this.EffectsButton.TabIndex = 9;
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
            this.panel1.Controls.Add(this.CropButton);
            this.panel1.Controls.Add(this.SelectButton);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 60);
            this.panel1.TabIndex = 1;
            // 
            // SelectButton
            // 
            this.SelectButton.Active = false;
            this.SelectButton.Activecolor = System.Drawing.Color.Transparent;
            this.SelectButton.BackColor = System.Drawing.Color.Transparent;
            this.SelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButton.BorderRadius = 0;
            this.SelectButton.ButtonText = "Select";
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectButton.DisabledColor = System.Drawing.Color.Gray;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SelectButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.SelectButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SelectButton.selected = false;
            this.SelectButton.Size = new System.Drawing.Size(130, 60);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelectButton.Textcolor = System.Drawing.Color.Black;
            this.SelectButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CropButton
            // 
            this.CropButton.Active = false;
            this.CropButton.Activecolor = System.Drawing.Color.Transparent;
            this.CropButton.BackColor = System.Drawing.Color.Transparent;
            this.CropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CropButton.BorderRadius = 0;
            this.CropButton.ButtonText = " Crop";
            this.CropButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CropButton.DisabledColor = System.Drawing.Color.Gray;
            this.CropButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.CropButton.Location = new System.Drawing.Point(130, 0);
            this.CropButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CropButton.Name = "CropButton";
            this.CropButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CropButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.CropButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.CropButton.selected = false;
            this.CropButton.Size = new System.Drawing.Size(130, 60);
            this.CropButton.TabIndex = 1;
            this.CropButton.Text = " Crop";
            this.CropButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CropButton.Textcolor = System.Drawing.Color.Black;
            this.CropButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PanButton
            // 
            this.PanButton.Active = false;
            this.PanButton.Activecolor = System.Drawing.Color.Transparent;
            this.PanButton.BackColor = System.Drawing.Color.Transparent;
            this.PanButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanButton.BorderRadius = 0;
            this.PanButton.ButtonText = "   Pan";
            this.PanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanButton.DisabledColor = System.Drawing.Color.Gray;
            this.PanButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.PanButton.Location = new System.Drawing.Point(260, 0);
            this.PanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanButton.Name = "PanButton";
            this.PanButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PanButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.PanButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PanButton.selected = false;
            this.PanButton.Size = new System.Drawing.Size(130, 60);
            this.PanButton.TabIndex = 2;
            this.PanButton.Text = "   Pan";
            this.PanButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PanButton.Textcolor = System.Drawing.Color.Black;
            this.PanButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ZoomButton
            // 
            this.ZoomButton.Active = false;
            this.ZoomButton.Activecolor = System.Drawing.Color.Transparent;
            this.ZoomButton.BackColor = System.Drawing.Color.Transparent;
            this.ZoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZoomButton.BorderRadius = 0;
            this.ZoomButton.ButtonText = " Zoom";
            this.ZoomButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ZoomButton.DisabledColor = System.Drawing.Color.Gray;
            this.ZoomButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.ZoomButton.Location = new System.Drawing.Point(390, 0);
            this.ZoomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.ZoomButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ZoomButton.selected = false;
            this.ZoomButton.Size = new System.Drawing.Size(130, 60);
            this.ZoomButton.TabIndex = 3;
            this.ZoomButton.Text = " Zoom";
            this.ZoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ZoomButton.Textcolor = System.Drawing.Color.Black;
            this.ZoomButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MoveButton
            // 
            this.MoveButton.Active = false;
            this.MoveButton.Activecolor = System.Drawing.Color.Transparent;
            this.MoveButton.BackColor = System.Drawing.Color.Transparent;
            this.MoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoveButton.BorderRadius = 0;
            this.MoveButton.ButtonText = "  Move";
            this.MoveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoveButton.DisabledColor = System.Drawing.Color.Gray;
            this.MoveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.MoveButton.Location = new System.Drawing.Point(520, 0);
            this.MoveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Normalcolor = System.Drawing.Color.Transparent;
            this.MoveButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.MoveButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.MoveButton.selected = false;
            this.MoveButton.Size = new System.Drawing.Size(130, 60);
            this.MoveButton.TabIndex = 4;
            this.MoveButton.Text = "  Move";
            this.MoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoveButton.Textcolor = System.Drawing.Color.Black;
            this.MoveButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // EraserButton
            // 
            this.EraserButton.Active = false;
            this.EraserButton.Activecolor = System.Drawing.Color.Transparent;
            this.EraserButton.BackColor = System.Drawing.Color.Transparent;
            this.EraserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EraserButton.BorderRadius = 0;
            this.EraserButton.ButtonText = "  Eraser";
            this.EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EraserButton.DisabledColor = System.Drawing.Color.Gray;
            this.EraserButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.EraserButton.Location = new System.Drawing.Point(650, 0);
            this.EraserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Normalcolor = System.Drawing.Color.Transparent;
            this.EraserButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.EraserButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.EraserButton.selected = false;
            this.EraserButton.Size = new System.Drawing.Size(130, 60);
            this.EraserButton.TabIndex = 5;
            this.EraserButton.Text = "  Eraser";
            this.EraserButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EraserButton.Textcolor = System.Drawing.Color.Black;
            this.EraserButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FillButton
            // 
            this.FillButton.Active = false;
            this.FillButton.Activecolor = System.Drawing.Color.Transparent;
            this.FillButton.BackColor = System.Drawing.Color.Transparent;
            this.FillButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FillButton.BorderRadius = 0;
            this.FillButton.ButtonText = "  Fill";
            this.FillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FillButton.DisabledColor = System.Drawing.Color.Gray;
            this.FillButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.FillButton.Location = new System.Drawing.Point(780, 0);
            this.FillButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FillButton.Name = "FillButton";
            this.FillButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FillButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.FillButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FillButton.selected = false;
            this.FillButton.Size = new System.Drawing.Size(130, 60);
            this.FillButton.TabIndex = 6;
            this.FillButton.Text = "  Fill";
            this.FillButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FillButton.Textcolor = System.Drawing.Color.Black;
            this.FillButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(980, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 551);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(52, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 458);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton CloseButton;
        private Bunifu.Framework.UI.BunifuImageButton MaximizeButton;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeButton;
        private Bunifu.Framework.UI.BunifuTileButton MenuButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton SelectButton;
        private Bunifu.Framework.UI.BunifuFlatButton FillButton;
        private Bunifu.Framework.UI.BunifuFlatButton EraserButton;
        private Bunifu.Framework.UI.BunifuFlatButton MoveButton;
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

