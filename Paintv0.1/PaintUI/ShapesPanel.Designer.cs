namespace PaintUI
{
    partial class ShapesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapesPanel));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.thicknessSlide = new Bunifu.Framework.UI.BunifuSlider();
            this.curShapeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShapesPanel));
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.Shapes_OutlineCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label4 = new System.Windows.Forms.Label();
            this.Shapes_FillCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.Shapes_Label3 = new System.Windows.Forms.Label();
            this.Shapes_Label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
            this.colorPanel = new PaintUI.ColorPanel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCards1.SuspendLayout();
=======
            this.rectangleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ellipseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lineButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hexagonButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.iso_triangleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.triangleButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.starButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.arrowButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lightningButton = new Bunifu.Framework.UI.BunifuFlatButton();
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.thicknessSlide);
            this.bunifuCards1.Controls.Add(this.curShapeBtn);
            this.bunifuCards1.Controls.Add(this.Shapes_OutlineCheckBox);
            this.bunifuCards1.Controls.Add(this.Shapes_Label4);
            this.bunifuCards1.Controls.Add(this.Shapes_FillCheckBox);
            this.bunifuCards1.Controls.Add(this.Shapes_Label3);
            this.bunifuCards1.Controls.Add(this.Shapes_Label1);
            this.bunifuCards1.Controls.Add(this.colorPanel);
            this.bunifuTransition1.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.TabIndex = 0;
            // 
            // thicknessSlide
            // 
            this.thicknessSlide.BackColor = System.Drawing.Color.Transparent;
            this.thicknessSlide.BackgroudColor = System.Drawing.Color.DarkGray;
            this.thicknessSlide.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.thicknessSlide, BunifuAnimatorNS.DecorationType.None);
            this.thicknessSlide.IndicatorColor = System.Drawing.Color.DarkCyan;
            this.thicknessSlide.Location = new System.Drawing.Point(55, 244);
            this.thicknessSlide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thicknessSlide.MaximumValue = 30;
            this.thicknessSlide.Name = "thicknessSlide";
            this.thicknessSlide.Size = new System.Drawing.Size(259, 41);
            this.thicknessSlide.TabIndex = 51;
            this.thicknessSlide.Value = 5;
            // 
            // curShapeBtn
            // 
            this.curShapeBtn.Activecolor = System.Drawing.Color.Aqua;
            this.curShapeBtn.BackColor = System.Drawing.Color.Transparent;
            this.curShapeBtn.BackgroundImage = global::PaintUI.Properties.Resources.Rectangle1;
            this.curShapeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.curShapeBtn.BorderRadius = 0;
            this.curShapeBtn.ButtonText = "";
            this.curShapeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.curShapeBtn, BunifuAnimatorNS.DecorationType.None);
            this.curShapeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.curShapeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.curShapeBtn.Iconimage = null;
            this.curShapeBtn.Iconimage_right = null;
            this.curShapeBtn.Iconimage_right_Selected = null;
            this.curShapeBtn.Iconimage_Selected = null;
            this.curShapeBtn.IconMarginLeft = 0;
            this.curShapeBtn.IconMarginRight = 0;
            this.curShapeBtn.IconRightVisible = true;
            this.curShapeBtn.IconRightZoom = 0D;
            this.curShapeBtn.IconVisible = true;
            this.curShapeBtn.IconZoom = 90D;
            this.curShapeBtn.IsTab = false;
            this.curShapeBtn.Location = new System.Drawing.Point(133, 76);
            this.curShapeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.curShapeBtn.Name = "curShapeBtn";
            this.curShapeBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.curShapeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.curShapeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.curShapeBtn.selected = false;
            this.curShapeBtn.Size = new System.Drawing.Size(76, 74);
            this.curShapeBtn.TabIndex = 50;
            this.curShapeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.curShapeBtn.Textcolor = System.Drawing.Color.White;
            this.curShapeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curShapeBtn.Click += new System.EventHandler(this.curShapeBtn_Click);
            // 
            // Shapes_OutlineCheckBox
            // 
            this.Shapes_OutlineCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_OutlineCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_OutlineCheckBox.Checked = true;
            this.Shapes_OutlineCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.bunifuTransition1.SetDecoration(this.Shapes_OutlineCheckBox, BunifuAnimatorNS.DecorationType.None);
            this.Shapes_OutlineCheckBox.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(232, 189);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
=======
            this.Shapes_OutlineCheckBox.Location = new System.Drawing.Point(189, 404);
            this.Shapes_OutlineCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.Shapes_OutlineCheckBox.Name = "Shapes_OutlineCheckBox";
            this.Shapes_OutlineCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_OutlineCheckBox.TabIndex = 30;
            this.Shapes_OutlineCheckBox.OnChange += new System.EventHandler(this.Shapes_OutlineCheckBox_OnChange);
            // 
            // Shapes_Label4
            // 
            this.Shapes_Label4.AutoSize = true;
            this.Shapes_Label4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Shapes_Label4, BunifuAnimatorNS.DecorationType.None);
            this.Shapes_Label4.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Shapes_Label4.Location = new System.Drawing.Point(76, 172);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(133, 52);
            this.Shapes_Label4.TabIndex = 29;
=======
            this.Shapes_Label4.Location = new System.Drawing.Point(51, 390);
            this.Shapes_Label4.Name = "Shapes_Label4";
            this.Shapes_Label4.Size = new System.Drawing.Size(110, 43);
            this.Shapes_Label4.TabIndex = 15;
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.Shapes_Label4.Text = "Outline";
            // 
            // Shapes_FillCheckBox
            // 
            this.Shapes_FillCheckBox.BackColor = System.Drawing.Color.DarkCyan;
            this.Shapes_FillCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Shapes_FillCheckBox.Checked = true;
            this.Shapes_FillCheckBox.CheckedOnColor = System.Drawing.Color.DarkCyan;
            this.bunifuTransition1.SetDecoration(this.Shapes_FillCheckBox, BunifuAnimatorNS.DecorationType.None);
            this.Shapes_FillCheckBox.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(232, 326);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(9, 14, 9, 14);
=======
            this.Shapes_FillCheckBox.Location = new System.Drawing.Point(189, 346);
            this.Shapes_FillCheckBox.Margin = new System.Windows.Forms.Padding(8, 11, 8, 11);
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.Shapes_FillCheckBox.Name = "Shapes_FillCheckBox";
            this.Shapes_FillCheckBox.Size = new System.Drawing.Size(20, 20);
            this.Shapes_FillCheckBox.TabIndex = 28;
            this.Shapes_FillCheckBox.OnChange += new System.EventHandler(this.Shapes_FillCheckBox_OnChange);
            // 
            // Shapes_Label3
            // 
            this.Shapes_Label3.AutoSize = true;
            this.Shapes_Label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Shapes_Label3, BunifuAnimatorNS.DecorationType.None);
            this.Shapes_Label3.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Shapes_Label3.Location = new System.Drawing.Point(88, 313);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(68, 52);
            this.Shapes_Label3.TabIndex = 27;
=======
            this.Shapes_Label3.Location = new System.Drawing.Point(67, 331);
            this.Shapes_Label3.Name = "Shapes_Label3";
            this.Shapes_Label3.Size = new System.Drawing.Size(55, 43);
            this.Shapes_Label3.TabIndex = 13;
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.Shapes_Label3.Text = "Fill";
            // 
            // Shapes_Label1
            // 
            this.Shapes_Label1.AutoSize = true;
            this.Shapes_Label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.Shapes_Label1, BunifuAnimatorNS.DecorationType.None);
            this.Shapes_Label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.Shapes_Label1.Location = new System.Drawing.Point(113, 19);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(127, 52);
            this.Shapes_Label1.TabIndex = 26;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // colorPanel
            // 
            this.colorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.colorPanel, BunifuAnimatorNS.DecorationType.None);
            this.colorPanel.Location = new System.Drawing.Point(0, 400);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(338, 346);
            this.colorPanel.TabIndex = 1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation4;
=======
            this.Shapes_Label1.Location = new System.Drawing.Point(90, 11);
            this.Shapes_Label1.Name = "Shapes_Label1";
            this.Shapes_Label1.Size = new System.Drawing.Size(106, 43);
            this.Shapes_Label1.TabIndex = 9;
            this.Shapes_Label1.Text = "Shapes";
            // 
            // rectangleButton
            // 
            this.rectangleButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.rectangleButton.BackColor = System.Drawing.Color.Transparent;
            this.rectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleButton.BorderRadius = 0;
            this.rectangleButton.ButtonText = "";
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.DisabledColor = System.Drawing.Color.Gray;
            this.rectangleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.rectangleButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Iconimage")));
            this.rectangleButton.Iconimage_right = null;
            this.rectangleButton.Iconimage_right_Selected = null;
            this.rectangleButton.Iconimage_Selected = null;
            this.rectangleButton.IconMarginLeft = 0;
            this.rectangleButton.IconMarginRight = 0;
            this.rectangleButton.IconRightVisible = true;
            this.rectangleButton.IconRightZoom = 0D;
            this.rectangleButton.IconVisible = true;
            this.rectangleButton.IconZoom = 55D;
            this.rectangleButton.IsTab = false;
            this.rectangleButton.Location = new System.Drawing.Point(53, 60);
            this.rectangleButton.Margin = new System.Windows.Forms.Padding(6);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Normalcolor = System.Drawing.Color.Transparent;
            this.rectangleButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.rectangleButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.rectangleButton.selected = false;
            this.rectangleButton.Size = new System.Drawing.Size(51, 51);
            this.rectangleButton.TabIndex = 17;
            this.rectangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rectangleButton.Textcolor = System.Drawing.Color.Black;
            this.rectangleButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.ellipseButton.BackColor = System.Drawing.Color.Transparent;
            this.ellipseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ellipseButton.BorderRadius = 0;
            this.ellipseButton.ButtonText = "";
            this.ellipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseButton.DisabledColor = System.Drawing.Color.Gray;
            this.ellipseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ellipseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Iconimage")));
            this.ellipseButton.Iconimage_right = null;
            this.ellipseButton.Iconimage_right_Selected = null;
            this.ellipseButton.Iconimage_Selected = null;
            this.ellipseButton.IconMarginLeft = 0;
            this.ellipseButton.IconMarginRight = 0;
            this.ellipseButton.IconRightVisible = true;
            this.ellipseButton.IconRightZoom = 0D;
            this.ellipseButton.IconVisible = true;
            this.ellipseButton.IconZoom = 55D;
            this.ellipseButton.IsTab = false;
            this.ellipseButton.Location = new System.Drawing.Point(116, 60);
            this.ellipseButton.Margin = new System.Windows.Forms.Padding(6);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ellipseButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.ellipseButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ellipseButton.selected = false;
            this.ellipseButton.Size = new System.Drawing.Size(51, 51);
            this.ellipseButton.TabIndex = 18;
            this.ellipseButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ellipseButton.Textcolor = System.Drawing.Color.Black;
            this.ellipseButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.lineButton.BackColor = System.Drawing.Color.Transparent;
            this.lineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineButton.BorderRadius = 0;
            this.lineButton.ButtonText = "";
            this.lineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineButton.DisabledColor = System.Drawing.Color.Gray;
            this.lineButton.Iconcolor = System.Drawing.Color.Transparent;
            this.lineButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("lineButton.Iconimage")));
            this.lineButton.Iconimage_right = null;
            this.lineButton.Iconimage_right_Selected = null;
            this.lineButton.Iconimage_Selected = null;
            this.lineButton.IconMarginLeft = 0;
            this.lineButton.IconMarginRight = 0;
            this.lineButton.IconRightVisible = true;
            this.lineButton.IconRightZoom = 0D;
            this.lineButton.IconVisible = true;
            this.lineButton.IconZoom = 55D;
            this.lineButton.IsTab = false;
            this.lineButton.Location = new System.Drawing.Point(179, 60);
            this.lineButton.Margin = new System.Windows.Forms.Padding(6);
            this.lineButton.Name = "lineButton";
            this.lineButton.Normalcolor = System.Drawing.Color.Transparent;
            this.lineButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.lineButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.lineButton.selected = false;
            this.lineButton.Size = new System.Drawing.Size(51, 51);
            this.lineButton.TabIndex = 19;
            this.lineButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lineButton.Textcolor = System.Drawing.Color.Black;
            this.lineButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // hexagonButton
            // 
            this.hexagonButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.hexagonButton.BackColor = System.Drawing.Color.Transparent;
            this.hexagonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hexagonButton.BorderRadius = 0;
            this.hexagonButton.ButtonText = "";
            this.hexagonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hexagonButton.DisabledColor = System.Drawing.Color.Gray;
            this.hexagonButton.Iconcolor = System.Drawing.Color.Transparent;
            this.hexagonButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("hexagonButton.Iconimage")));
            this.hexagonButton.Iconimage_right = null;
            this.hexagonButton.Iconimage_right_Selected = null;
            this.hexagonButton.Iconimage_Selected = null;
            this.hexagonButton.IconMarginLeft = 0;
            this.hexagonButton.IconMarginRight = 0;
            this.hexagonButton.IconRightVisible = true;
            this.hexagonButton.IconRightZoom = 0D;
            this.hexagonButton.IconVisible = true;
            this.hexagonButton.IconZoom = 55D;
            this.hexagonButton.IsTab = false;
            this.hexagonButton.Location = new System.Drawing.Point(179, 186);
            this.hexagonButton.Margin = new System.Windows.Forms.Padding(6);
            this.hexagonButton.Name = "hexagonButton";
            this.hexagonButton.Normalcolor = System.Drawing.Color.Transparent;
            this.hexagonButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.hexagonButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.hexagonButton.selected = false;
            this.hexagonButton.Size = new System.Drawing.Size(51, 51);
            this.hexagonButton.TabIndex = 20;
            this.hexagonButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hexagonButton.Textcolor = System.Drawing.Color.Black;
            this.hexagonButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.hexagonButton.Click += new System.EventHandler(this.hexagonButton_Click);
            // 
            // iso_triangleButton
            // 
            this.iso_triangleButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.iso_triangleButton.BackColor = System.Drawing.Color.Transparent;
            this.iso_triangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iso_triangleButton.BorderRadius = 0;
            this.iso_triangleButton.ButtonText = "";
            this.iso_triangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iso_triangleButton.DisabledColor = System.Drawing.Color.Gray;
            this.iso_triangleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.iso_triangleButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("iso_triangleButton.Iconimage")));
            this.iso_triangleButton.Iconimage_right = null;
            this.iso_triangleButton.Iconimage_right_Selected = null;
            this.iso_triangleButton.Iconimage_Selected = null;
            this.iso_triangleButton.IconMarginLeft = 0;
            this.iso_triangleButton.IconMarginRight = 0;
            this.iso_triangleButton.IconRightVisible = true;
            this.iso_triangleButton.IconRightZoom = 0D;
            this.iso_triangleButton.IconVisible = true;
            this.iso_triangleButton.IconZoom = 55D;
            this.iso_triangleButton.IsTab = false;
            this.iso_triangleButton.Location = new System.Drawing.Point(116, 186);
            this.iso_triangleButton.Margin = new System.Windows.Forms.Padding(6);
            this.iso_triangleButton.Name = "iso_triangleButton";
            this.iso_triangleButton.Normalcolor = System.Drawing.Color.Transparent;
            this.iso_triangleButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.iso_triangleButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.iso_triangleButton.selected = false;
            this.iso_triangleButton.Size = new System.Drawing.Size(51, 51);
            this.iso_triangleButton.TabIndex = 24;
            this.iso_triangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iso_triangleButton.Textcolor = System.Drawing.Color.Black;
            this.iso_triangleButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.iso_triangleButton.Click += new System.EventHandler(this.iso_triangleButton_Click);
            // 
            // triangleButton
            // 
            this.triangleButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.triangleButton.BackColor = System.Drawing.Color.Transparent;
            this.triangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.triangleButton.BorderRadius = 0;
            this.triangleButton.ButtonText = "";
            this.triangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.triangleButton.DisabledColor = System.Drawing.Color.Gray;
            this.triangleButton.Iconcolor = System.Drawing.Color.Transparent;
            this.triangleButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("triangleButton.Iconimage")));
            this.triangleButton.Iconimage_right = null;
            this.triangleButton.Iconimage_right_Selected = null;
            this.triangleButton.Iconimage_Selected = null;
            this.triangleButton.IconMarginLeft = 0;
            this.triangleButton.IconMarginRight = 0;
            this.triangleButton.IconRightVisible = true;
            this.triangleButton.IconRightZoom = 0D;
            this.triangleButton.IconVisible = true;
            this.triangleButton.IconZoom = 55D;
            this.triangleButton.IsTab = false;
            this.triangleButton.Location = new System.Drawing.Point(179, 123);
            this.triangleButton.Margin = new System.Windows.Forms.Padding(6);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Normalcolor = System.Drawing.Color.Transparent;
            this.triangleButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.triangleButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.triangleButton.selected = false;
            this.triangleButton.Size = new System.Drawing.Size(51, 51);
            this.triangleButton.TabIndex = 23;
            this.triangleButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.triangleButton.Textcolor = System.Drawing.Color.Black;
            this.triangleButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
            // 
            // starButton
            // 
            this.starButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.starButton.BackColor = System.Drawing.Color.Transparent;
            this.starButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.starButton.BorderRadius = 0;
            this.starButton.ButtonText = "";
            this.starButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starButton.DisabledColor = System.Drawing.Color.Gray;
            this.starButton.Iconcolor = System.Drawing.Color.Transparent;
            this.starButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("starButton.Iconimage")));
            this.starButton.Iconimage_right = null;
            this.starButton.Iconimage_right_Selected = null;
            this.starButton.Iconimage_Selected = null;
            this.starButton.IconMarginLeft = 0;
            this.starButton.IconMarginRight = 0;
            this.starButton.IconRightVisible = true;
            this.starButton.IconRightZoom = 0D;
            this.starButton.IconVisible = true;
            this.starButton.IconZoom = 55D;
            this.starButton.IsTab = false;
            this.starButton.Location = new System.Drawing.Point(116, 123);
            this.starButton.Margin = new System.Windows.Forms.Padding(6);
            this.starButton.Name = "starButton";
            this.starButton.Normalcolor = System.Drawing.Color.Transparent;
            this.starButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.starButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.starButton.selected = false;
            this.starButton.Size = new System.Drawing.Size(51, 51);
            this.starButton.TabIndex = 22;
            this.starButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.starButton.Textcolor = System.Drawing.Color.Black;
            this.starButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // arrowButton
            // 
            this.arrowButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.arrowButton.BackColor = System.Drawing.Color.Transparent;
            this.arrowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowButton.BorderRadius = 0;
            this.arrowButton.ButtonText = "";
            this.arrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arrowButton.DisabledColor = System.Drawing.Color.Gray;
            this.arrowButton.Iconcolor = System.Drawing.Color.Transparent;
            this.arrowButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("arrowButton.Iconimage")));
            this.arrowButton.Iconimage_right = null;
            this.arrowButton.Iconimage_right_Selected = null;
            this.arrowButton.Iconimage_Selected = null;
            this.arrowButton.IconMarginLeft = 0;
            this.arrowButton.IconMarginRight = 0;
            this.arrowButton.IconRightVisible = true;
            this.arrowButton.IconRightZoom = 0D;
            this.arrowButton.IconVisible = true;
            this.arrowButton.IconZoom = 55D;
            this.arrowButton.IsTab = false;
            this.arrowButton.Location = new System.Drawing.Point(53, 123);
            this.arrowButton.Margin = new System.Windows.Forms.Padding(6);
            this.arrowButton.Name = "arrowButton";
            this.arrowButton.Normalcolor = System.Drawing.Color.Transparent;
            this.arrowButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.arrowButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.arrowButton.selected = false;
            this.arrowButton.Size = new System.Drawing.Size(51, 51);
            this.arrowButton.TabIndex = 21;
            this.arrowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.arrowButton.Textcolor = System.Drawing.Color.Black;
            this.arrowButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.arrowButton.Click += new System.EventHandler(this.arrowButton_Click);
            // 
            // lightningButton
            // 
            this.lightningButton.Activecolor = System.Drawing.Color.DodgerBlue;
            this.lightningButton.BackColor = System.Drawing.Color.Transparent;
            this.lightningButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lightningButton.BorderRadius = 0;
            this.lightningButton.ButtonText = "";
            this.lightningButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lightningButton.DisabledColor = System.Drawing.Color.Gray;
            this.lightningButton.Iconcolor = System.Drawing.Color.Transparent;
            this.lightningButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("lightningButton.Iconimage")));
            this.lightningButton.Iconimage_right = null;
            this.lightningButton.Iconimage_right_Selected = null;
            this.lightningButton.Iconimage_Selected = null;
            this.lightningButton.IconMarginLeft = 0;
            this.lightningButton.IconMarginRight = 0;
            this.lightningButton.IconRightVisible = true;
            this.lightningButton.IconRightZoom = 0D;
            this.lightningButton.IconVisible = true;
            this.lightningButton.IconZoom = 55D;
            this.lightningButton.IsTab = false;
            this.lightningButton.Location = new System.Drawing.Point(53, 186);
            this.lightningButton.Margin = new System.Windows.Forms.Padding(6);
            this.lightningButton.Name = "lightningButton";
            this.lightningButton.Normalcolor = System.Drawing.Color.Transparent;
            this.lightningButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.lightningButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.lightningButton.selected = false;
            this.lightningButton.Size = new System.Drawing.Size(51, 51);
            this.lightningButton.TabIndex = 25;
            this.lightningButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lightningButton.Textcolor = System.Drawing.Color.Black;
            this.lightningButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.lightningButton.Click += new System.EventHandler(this.lightningButton_Click);
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            // 
            // ShapesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
<<<<<<< HEAD
            this.Controls.Add(this.bunifuCards1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(338, 746);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
=======
            this.Controls.Add(this.lightningButton);
            this.Controls.Add(this.iso_triangleButton);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.starButton);
            this.Controls.Add(this.arrowButton);
            this.Controls.Add(this.hexagonButton);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.ellipseButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.Shapes_OutlineCheckBox);
            this.Controls.Add(this.Shapes_Label4);
            this.Controls.Add(this.Shapes_FillCheckBox);
            this.Controls.Add(this.Shapes_Label3);
            this.Controls.Add(this.Shapes_Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ShapesPanel";
            this.Size = new System.Drawing.Size(300, 451);
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_OutlineCheckBox;
        private System.Windows.Forms.Label Shapes_Label4;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_FillCheckBox;
        private System.Windows.Forms.Label Shapes_Label3;
        private System.Windows.Forms.Label Shapes_Label1;
        private ColorPanel colorPanel;
        private Bunifu.Framework.UI.BunifuFlatButton curShapeBtn;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuSlider thicknessSlide;
=======

        private Bunifu.Framework.UI.BunifuCheckbox Shapes_OutlineCheckBox;
        private System.Windows.Forms.Label Shapes_Label4;
        private Bunifu.Framework.UI.BunifuCheckbox Shapes_FillCheckBox;
        private System.Windows.Forms.Label Shapes_Label3;
        private System.Windows.Forms.Label Shapes_Label1;
        private Bunifu.Framework.UI.BunifuFlatButton rectangleButton;
        private Bunifu.Framework.UI.BunifuFlatButton ellipseButton;
        private Bunifu.Framework.UI.BunifuFlatButton lineButton;
        private Bunifu.Framework.UI.BunifuFlatButton hexagonButton;
        private Bunifu.Framework.UI.BunifuFlatButton iso_triangleButton;
        private Bunifu.Framework.UI.BunifuFlatButton triangleButton;
        private Bunifu.Framework.UI.BunifuFlatButton starButton;
        private Bunifu.Framework.UI.BunifuFlatButton arrowButton;
        private Bunifu.Framework.UI.BunifuFlatButton lightningButton;
>>>>>>> 0072b7517241fa79201c2e0c4a0bc09a13a62c28
    }
}
