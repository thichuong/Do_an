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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LayerButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuPanel = new PaintUI.MenuPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SelectButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.PanButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CropButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ZoomButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.layerPanel = new PaintUI.LayerPanel();
            this.panelCavas = new PaintUI.DoubleBufferPanel();
            this.SketchBox = new PaintUI.Canvas();
            this.RightTopPanel = new PaintUI.DoubleBufferPanel();
            this.LeftBottomPanel = new PaintUI.DoubleBufferPanel();
            this.RightBottomPanel = new PaintUI.DoubleBufferPanel();
            this.LeftTopPanel = new PaintUI.DoubleBufferPanel();
            this.doubleBufferPanel2 = new PaintUI.DoubleBufferPanel();
            this.shapesPanel = new PaintUI.ShapesPanel();
            this.effectsPanel = new PaintUI.EffectsPanel();
            this.textPanel = new PaintUI.TextPanel();
            this.brushesPanel = new PaintUI.BrushesPanel();
            this.canvasPanel = new PaintUI.CanvasPanel();
            this.doubleBufferPanel1 = new PaintUI.DoubleBufferPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EffectsButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.titleLb = new System.Windows.Forms.Label();
            this.CanvasButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.RedoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.BrushesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.CloseButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.UndoButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ShapesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MinimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.MaximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TextButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.MenuButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.EditPanel.SuspendLayout();
            this.panelCavas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).BeginInit();
            this.doubleBufferPanel2.SuspendLayout();
            this.doubleBufferPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuTransition1.Interval = 11;
            this.bunifuTransition1.TimeStep = 0.025F;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TopPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bunifuTransition1.SetDecoration(this.TopPanel, BunifuAnimatorNS.DecorationType.None);
            this.TopPanel.Location = new System.Drawing.Point(8, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1058, 8);
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
            this.LeftTopPanel_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftTopPanel_1.Name = "LeftTopPanel_1";
            this.LeftTopPanel_1.Size = new System.Drawing.Size(8, 8);
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
            this.Leftpanel.Location = new System.Drawing.Point(-2, 11);
            this.Leftpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(8, 700);
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
            this.LeftBottomPanel_1.Location = new System.Drawing.Point(-2, 710);
            this.LeftBottomPanel_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftBottomPanel_1.Name = "LeftBottomPanel_1";
            this.LeftBottomPanel_1.Size = new System.Drawing.Size(8, 13);
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
            this.BottomPanel.Location = new System.Drawing.Point(6, 710);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1060, 11);
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
            this.RightBottomPanel_1.Location = new System.Drawing.Point(1066, 710);
            this.RightBottomPanel_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightBottomPanel_1.Name = "RightBottomPanel_1";
            this.RightBottomPanel_1.Size = new System.Drawing.Size(8, 14);
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
            this.RightPanel.Location = new System.Drawing.Point(1066, 11);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(8, 700);
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
            this.RightTopPanel_1.Location = new System.Drawing.Point(1066, 2);
            this.RightTopPanel_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightTopPanel_1.Name = "RightTopPanel_1";
            this.RightTopPanel_1.Size = new System.Drawing.Size(8, 8);
            this.RightTopPanel_1.TabIndex = 38;
            this.RightTopPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseDown);
            this.RightTopPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseMove);
            this.RightTopPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightTopPanel_1_MouseUp);
            // 
            // EditPanel
            // 
            this.EditPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.label5);
            this.EditPanel.Controls.Add(this.LayerButton);
            this.EditPanel.Controls.Add(this.menuPanel);
            this.EditPanel.Controls.Add(this.label13);
            this.EditPanel.Controls.Add(this.label12);
            this.EditPanel.Controls.Add(this.SelectButton);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.PanButton);
            this.EditPanel.Controls.Add(this.CropButton);
            this.EditPanel.Controls.Add(this.ZoomButton);
            this.EditPanel.Controls.Add(this.layerPanel);
            this.bunifuTransition1.SetDecoration(this.EditPanel, BunifuAnimatorNS.DecorationType.None);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPanel.Location = new System.Drawing.Point(2, 82);
            this.EditPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(1068, 47);
            this.EditPanel.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Location = new System.Drawing.Point(101, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(235, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(361, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "H";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Location = new System.Drawing.Point(625, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "L";
            // 
            // LayerButton
            // 
            this.LayerButton.Activecolor = System.Drawing.Color.Transparent;
            this.LayerButton.BackColor = System.Drawing.Color.Transparent;
            this.LayerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayerButton.BorderRadius = 0;
            this.LayerButton.ButtonText = "Layer";
            this.LayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.LayerButton, BunifuAnimatorNS.DecorationType.None);
            this.LayerButton.DisabledColor = System.Drawing.Color.Gray;
            this.LayerButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LayerButton.Iconimage = global::PaintUI.Properties.Resources.lay;
            this.LayerButton.Iconimage_right = null;
            this.LayerButton.Iconimage_right_Selected = null;
            this.LayerButton.Iconimage_Selected = null;
            this.LayerButton.IconMarginLeft = 0;
            this.LayerButton.IconMarginRight = 0;
            this.LayerButton.IconRightVisible = true;
            this.LayerButton.IconRightZoom = 0D;
            this.LayerButton.IconVisible = true;
            this.LayerButton.IconZoom = 55D;
            this.LayerButton.IsTab = false;
            this.LayerButton.Location = new System.Drawing.Point(510, 0);
            this.LayerButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LayerButton.Name = "LayerButton";
            this.LayerButton.Normalcolor = System.Drawing.Color.Transparent;
            this.LayerButton.OnHovercolor = System.Drawing.Color.LightGray;
            this.LayerButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.LayerButton.selected = false;
            this.LayerButton.Size = new System.Drawing.Size(128, 49);
            this.LayerButton.TabIndex = 44;
            this.LayerButton.Text = "Layer";
            this.LayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LayerButton.Textcolor = System.Drawing.Color.Black;
            this.LayerButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.toolTip1.SetToolTip(this.LayerButton, "Move");
            this.LayerButton.Click += new System.EventHandler(this.LayerButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition1.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Location = new System.Drawing.Point(19, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(152, 116);
            this.menuPanel.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label13, BunifuAnimatorNS.DecorationType.None);
            this.label13.Location = new System.Drawing.Point(955, 1);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 69;
            this.label13.Text = "Ctrl+Y";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label12, BunifuAnimatorNS.DecorationType.None);
            this.label12.Location = new System.Drawing.Point(891, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Ctrl + Z";
            // 
            // SelectButton
            // 
            this.SelectButton.Activecolor = System.Drawing.Color.LightGray;
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
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Normalcolor = System.Drawing.Color.Transparent;
            this.SelectButton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.SelectButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.SelectButton.selected = false;
            this.SelectButton.Size = new System.Drawing.Size(128, 49);
            this.SelectButton.TabIndex = 2;
            this.SelectButton.Text = "Select  ";
            this.SelectButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectButton.Textcolor = System.Drawing.Color.Black;
            this.SelectButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.toolTip1.SetToolTip(this.SelectButton, "Select");
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Location = new System.Drawing.Point(490, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Z";
            // 
            // PanButton
            // 
            this.PanButton.Activecolor = System.Drawing.Color.LightGray;
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
            this.PanButton.Location = new System.Drawing.Point(255, 0);
            this.PanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanButton.Name = "PanButton";
            this.PanButton.Normalcolor = System.Drawing.Color.Transparent;
            this.PanButton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.PanButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.PanButton.selected = false;
            this.PanButton.Size = new System.Drawing.Size(128, 49);
            this.PanButton.TabIndex = 3;
            this.PanButton.Text = "Pan  ";
            this.PanButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PanButton.Textcolor = System.Drawing.Color.Black;
            this.PanButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.toolTip1.SetToolTip(this.PanButton, "Pan");
            this.PanButton.Click += new System.EventHandler(this.PanButton_Click);
            // 
            // CropButton
            // 
            this.CropButton.Activecolor = System.Drawing.Color.LightGray;
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
            this.CropButton.Location = new System.Drawing.Point(128, 0);
            this.CropButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CropButton.Name = "CropButton";
            this.CropButton.Normalcolor = System.Drawing.Color.Transparent;
            this.CropButton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.CropButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.CropButton.selected = false;
            this.CropButton.Size = new System.Drawing.Size(128, 49);
            this.CropButton.TabIndex = 1;
            this.CropButton.Text = "Crop ";
            this.CropButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CropButton.Textcolor = System.Drawing.Color.Black;
            this.CropButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.toolTip1.SetToolTip(this.CropButton, "Crop");
            this.CropButton.Click += new System.EventHandler(this.CropButton_Click);
            // 
            // ZoomButton
            // 
            this.ZoomButton.Activecolor = System.Drawing.Color.LightGray;
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
            this.ZoomButton.Location = new System.Drawing.Point(382, 0);
            this.ZoomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Normalcolor = System.Drawing.Color.Transparent;
            this.ZoomButton.OnHovercolor = System.Drawing.Color.Gainsboro;
            this.ZoomButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ZoomButton.selected = false;
            this.ZoomButton.Size = new System.Drawing.Size(128, 49);
            this.ZoomButton.TabIndex = 4;
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ZoomButton.Textcolor = System.Drawing.Color.Black;
            this.ZoomButton.TextFont = new System.Drawing.Font("Segoe Print", 10.6F);
            this.toolTip1.SetToolTip(this.ZoomButton, "Zoom");
            this.ZoomButton.Click += new System.EventHandler(this.ZoomButton_Click);
            // 
            // layerPanel
            // 
            this.layerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerPanel.BackColor = System.Drawing.Color.LightGray;
            this.bunifuTransition1.SetDecoration(this.layerPanel, BunifuAnimatorNS.DecorationType.None);
            this.layerPanel.Location = new System.Drawing.Point(644, 1);
            this.layerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layerPanel.Name = "layerPanel";
            this.layerPanel.Size = new System.Drawing.Size(424, 47);
            this.layerPanel.TabIndex = 31;
            // 
            // panelCavas
            // 
            this.panelCavas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCavas.BackColor = System.Drawing.Color.Silver;
            this.panelCavas.Controls.Add(this.SketchBox);
            this.panelCavas.Controls.Add(this.RightTopPanel);
            this.panelCavas.Controls.Add(this.LeftBottomPanel);
            this.panelCavas.Controls.Add(this.RightBottomPanel);
            this.panelCavas.Controls.Add(this.LeftTopPanel);
            this.bunifuTransition1.SetDecoration(this.panelCavas, BunifuAnimatorNS.DecorationType.None);
            this.panelCavas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelCavas.Location = new System.Drawing.Point(2, 129);
            this.panelCavas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCavas.Name = "panelCavas";
            this.panelCavas.Size = new System.Drawing.Size(826, 585);
            this.panelCavas.TabIndex = 44;
            this.panelCavas.SizeChanged += new System.EventHandler(this.panelCavas_SizeChanged);
            // 
            // SketchBox
            // 
            this.SketchBox.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.SketchBox, BunifuAnimatorNS.DecorationType.None);
            this.SketchBox.Location = new System.Drawing.Point(120, 107);
            this.SketchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SketchBox.Name = "SketchBox";
            this.SketchBox.Size = new System.Drawing.Size(568, 408);
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
            this.RightTopPanel.Location = new System.Drawing.Point(690, 97);
            this.RightTopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightTopPanel.Name = "RightTopPanel";
            this.RightTopPanel.Size = new System.Drawing.Size(8, 8);
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
            this.LeftBottomPanel.Location = new System.Drawing.Point(90, 521);
            this.LeftBottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftBottomPanel.Name = "LeftBottomPanel";
            this.LeftBottomPanel.Size = new System.Drawing.Size(8, 8);
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
            this.RightBottomPanel.Location = new System.Drawing.Point(713, 507);
            this.RightBottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightBottomPanel.Name = "RightBottomPanel";
            this.RightBottomPanel.Size = new System.Drawing.Size(8, 8);
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
            this.LeftTopPanel.Location = new System.Drawing.Point(108, 97);
            this.LeftTopPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftTopPanel.Name = "LeftTopPanel";
            this.LeftTopPanel.Size = new System.Drawing.Size(8, 8);
            this.LeftTopPanel.TabIndex = 29;
            this.LeftTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseDown);
            this.LeftTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseMove);
            this.LeftTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LeftTopPanel_MouseUp);
            // 
            // doubleBufferPanel2
            // 
            this.doubleBufferPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.doubleBufferPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.doubleBufferPanel2.Controls.Add(this.shapesPanel);
            this.doubleBufferPanel2.Controls.Add(this.effectsPanel);
            this.doubleBufferPanel2.Controls.Add(this.textPanel);
            this.doubleBufferPanel2.Controls.Add(this.brushesPanel);
            this.doubleBufferPanel2.Controls.Add(this.canvasPanel);
            this.bunifuTransition1.SetDecoration(this.doubleBufferPanel2, BunifuAnimatorNS.DecorationType.None);
            this.doubleBufferPanel2.Location = new System.Drawing.Point(828, 129);
            this.doubleBufferPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doubleBufferPanel2.Name = "doubleBufferPanel2";
            this.doubleBufferPanel2.Size = new System.Drawing.Size(242, 632);
            this.doubleBufferPanel2.TabIndex = 40;
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuTransition1.SetDecoration(this.shapesPanel, BunifuAnimatorNS.DecorationType.None);
            this.shapesPanel.Location = new System.Drawing.Point(-1, 2);
            this.shapesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(243, 580);
            this.shapesPanel.TabIndex = 38;
            // 
            // effectsPanel
            // 
            this.effectsPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.effectsPanel, BunifuAnimatorNS.DecorationType.None);
            this.effectsPanel.Location = new System.Drawing.Point(0, 0);
            this.effectsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.effectsPanel.Name = "effectsPanel";
            this.effectsPanel.Size = new System.Drawing.Size(243, 630);
            this.effectsPanel.TabIndex = 33;
            // 
            // textPanel
            // 
            this.textPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.textPanel, BunifuAnimatorNS.DecorationType.None);
            this.textPanel.Location = new System.Drawing.Point(0, 0);
            this.textPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textPanel.Name = "textPanel";
            this.textPanel.Size = new System.Drawing.Size(242, 630);
            this.textPanel.TabIndex = 35;
            // 
            // brushesPanel
            // 
            this.brushesPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuTransition1.SetDecoration(this.brushesPanel, BunifuAnimatorNS.DecorationType.None);
            this.brushesPanel.Location = new System.Drawing.Point(0, 0);
            this.brushesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.brushesPanel.Name = "brushesPanel";
            this.brushesPanel.Size = new System.Drawing.Size(242, 629);
            this.brushesPanel.TabIndex = 39;
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.canvasPanel, BunifuAnimatorNS.DecorationType.None);
            this.canvasPanel.Location = new System.Drawing.Point(0, 0);
            this.canvasPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(243, 630);
            this.canvasPanel.TabIndex = 32;
            // 
            // doubleBufferPanel1
            // 
            this.doubleBufferPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.doubleBufferPanel1.Controls.Add(this.label11);
            this.doubleBufferPanel1.Controls.Add(this.label6);
            this.doubleBufferPanel1.Controls.Add(this.label8);
            this.doubleBufferPanel1.Controls.Add(this.label7);
            this.doubleBufferPanel1.Controls.Add(this.label10);
            this.doubleBufferPanel1.Controls.Add(this.label9);
            this.doubleBufferPanel1.Controls.Add(this.EffectsButton);
            this.doubleBufferPanel1.Controls.Add(this.titleLb);
            this.doubleBufferPanel1.Controls.Add(this.CanvasButton);
            this.doubleBufferPanel1.Controls.Add(this.RedoButton);
            this.doubleBufferPanel1.Controls.Add(this.BrushesButton);
            this.doubleBufferPanel1.Controls.Add(this.CloseButton);
            this.doubleBufferPanel1.Controls.Add(this.UndoButton);
            this.doubleBufferPanel1.Controls.Add(this.ShapesButton);
            this.doubleBufferPanel1.Controls.Add(this.MinimizeButton);
            this.doubleBufferPanel1.Controls.Add(this.MaximizeButton);
            this.doubleBufferPanel1.Controls.Add(this.TextButton);
            this.doubleBufferPanel1.Controls.Add(this.MenuButton);
            this.bunifuTransition1.SetDecoration(this.doubleBufferPanel1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBufferPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.doubleBufferPanel1.Location = new System.Drawing.Point(2, 2);
            this.doubleBufferPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.doubleBufferPanel1.Name = "doubleBufferPanel1";
            this.doubleBufferPanel1.Size = new System.Drawing.Size(1068, 80);
            this.doubleBufferPanel1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label11, BunifuAnimatorNS.DecorationType.None);
            this.label11.Location = new System.Drawing.Point(101, 64);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "M";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(381, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "1";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(527, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "3";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(457, 64);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "2";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label10, BunifuAnimatorNS.DecorationType.None);
            this.label10.Location = new System.Drawing.Point(676, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "5";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Location = new System.Drawing.Point(601, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "4";
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
            this.EffectsButton.LabelText = "Effect";
            this.EffectsButton.Location = new System.Drawing.Point(615, 15);
            this.EffectsButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.EffectsButton.Name = "EffectsButton";
            this.EffectsButton.Size = new System.Drawing.Size(68, 63);
            this.EffectsButton.TabIndex = 27;
            this.EffectsButton.Click += new System.EventHandler(this.EffectsButton_Click);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.titleLb, BunifuAnimatorNS.DecorationType.None);
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(9, 2);
            this.titleLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(133, 17);
            this.titleLb.TabIndex = 12;
            this.titleLb.Text = "Untitled - Skuitch";
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
            this.CanvasButton.Location = new System.Drawing.Point(465, 15);
            this.CanvasButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CanvasButton.Name = "CanvasButton";
            this.CanvasButton.Size = new System.Drawing.Size(74, 63);
            this.CanvasButton.TabIndex = 25;
            this.CanvasButton.Click += new System.EventHandler(this.CanvasButton_Click);
            // 
            // RedoButton
            // 
            this.RedoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RedoButton.BackColor = System.Drawing.Color.Transparent;
            this.RedoButton.color = System.Drawing.Color.Transparent;
            this.RedoButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.RedoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.RedoButton, BunifuAnimatorNS.DecorationType.None);
            this.RedoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.RedoButton.ForeColor = System.Drawing.Color.Black;
            this.RedoButton.Image = global::PaintUI.Properties.Resources.RedoIcon;
            this.RedoButton.ImagePosition = -5;
            this.RedoButton.ImageZoom = 60;
            this.RedoButton.LabelPosition = 27;
            this.RedoButton.LabelText = "Redo";
            this.RedoButton.Location = new System.Drawing.Point(949, 27);
            this.RedoButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.RedoButton.Name = "RedoButton";
            this.RedoButton.Size = new System.Drawing.Size(50, 49);
            this.RedoButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.RedoButton, "Redo");
            this.RedoButton.Click += new System.EventHandler(this.RedoButton_Click);
            // 
            // BrushesButton
            // 
            this.BrushesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BrushesButton.AutoSize = true;
            this.BrushesButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BrushesButton.color = System.Drawing.Color.CornflowerBlue;
            this.BrushesButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.BrushesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.BrushesButton, BunifuAnimatorNS.DecorationType.None);
            this.BrushesButton.Font = new System.Drawing.Font("Segoe Print", 10.5F);
            this.BrushesButton.ForeColor = System.Drawing.Color.Black;
            this.BrushesButton.Image = global::PaintUI.Properties.Resources.BrushesIcon;
            this.BrushesButton.ImagePosition = -1;
            this.BrushesButton.ImageZoom = 60;
            this.BrushesButton.LabelPosition = 27;
            this.BrushesButton.LabelText = "Brush";
            this.BrushesButton.Location = new System.Drawing.Point(543, 15);
            this.BrushesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BrushesButton.Name = "BrushesButton";
            this.BrushesButton.Size = new System.Drawing.Size(68, 66);
            this.BrushesButton.TabIndex = 26;
            this.BrushesButton.Click += new System.EventHandler(this.BrushesButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.CloseButton, BunifuAnimatorNS.DecorationType.None);
            this.CloseButton.Image = global::PaintUI.Properties.Resources.exit1;
            this.CloseButton.ImageActive = null;
            this.CloseButton.Location = new System.Drawing.Point(1043, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 24);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 3;
            this.CloseButton.TabStop = false;
            this.toolTip1.SetToolTip(this.CloseButton, "Close");
            this.CloseButton.Zoom = 10;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // UndoButton
            // 
            this.UndoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UndoButton.BackColor = System.Drawing.Color.Transparent;
            this.UndoButton.color = System.Drawing.Color.Transparent;
            this.UndoButton.colorActive = System.Drawing.Color.CornflowerBlue;
            this.UndoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.UndoButton, BunifuAnimatorNS.DecorationType.None);
            this.UndoButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.UndoButton.ForeColor = System.Drawing.Color.Black;
            this.UndoButton.Image = global::PaintUI.Properties.Resources.UndoIcon;
            this.UndoButton.ImagePosition = -5;
            this.UndoButton.ImageZoom = 60;
            this.UndoButton.LabelPosition = 27;
            this.UndoButton.LabelText = "Undo";
            this.UndoButton.Location = new System.Drawing.Point(885, 26);
            this.UndoButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.UndoButton.Name = "UndoButton";
            this.UndoButton.Size = new System.Drawing.Size(52, 49);
            this.UndoButton.TabIndex = 10;
            this.toolTip1.SetToolTip(this.UndoButton, "Undo");
            this.UndoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // ShapesButton
            // 
            this.ShapesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ShapesButton.AutoSize = true;
            this.ShapesButton.BackColor = System.Drawing.Color.Transparent;
            this.ShapesButton.color = System.Drawing.Color.Transparent;
            this.ShapesButton.colorActive = System.Drawing.Color.Transparent;
            this.ShapesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.ShapesButton, BunifuAnimatorNS.DecorationType.None);
            this.ShapesButton.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.ShapesButton.ForeColor = System.Drawing.Color.Black;
            this.ShapesButton.Image = global::PaintUI.Properties.Resources._2dShape;
            this.ShapesButton.ImagePosition = -6;
            this.ShapesButton.ImageZoom = 60;
            this.ShapesButton.LabelPosition = 30;
            this.ShapesButton.LabelText = "Shapes";
            this.ShapesButton.Location = new System.Drawing.Point(396, 15);
            this.ShapesButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.ShapesButton.Name = "ShapesButton";
            this.ShapesButton.Size = new System.Drawing.Size(64, 63);
            this.ShapesButton.TabIndex = 24;
            this.ShapesButton.Click += new System.EventHandler(this.ShapesButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.MinimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.MinimizeButton.Image = global::PaintUI.Properties.Resources.min;
            this.MinimizeButton.ImageActive = null;
            this.MinimizeButton.Location = new System.Drawing.Point(989, 2);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(22, 24);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizeButton, "Minimize");
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
            this.MaximizeButton.Location = new System.Drawing.Point(1017, 2);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(22, 24);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaximizeButton.TabIndex = 2;
            this.MaximizeButton.TabStop = false;
            this.toolTip1.SetToolTip(this.MaximizeButton, "Maximize");
            this.MaximizeButton.Zoom = 10;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // TextButton
            // 
            this.TextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextButton.AutoSize = true;
            this.TextButton.BackColor = System.Drawing.Color.Transparent;
            this.TextButton.color = System.Drawing.Color.Transparent;
            this.TextButton.colorActive = System.Drawing.Color.Transparent;
            this.TextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.TextButton, BunifuAnimatorNS.DecorationType.None);
            this.TextButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextButton.ForeColor = System.Drawing.Color.Black;
            this.TextButton.Image = global::PaintUI.Properties.Resources.TextIcon;
            this.TextButton.ImagePosition = -13;
            this.TextButton.ImageZoom = 80;
            this.TextButton.LabelPosition = 34;
            this.TextButton.LabelText = "Text";
            this.TextButton.Location = new System.Drawing.Point(329, 15);
            this.TextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(62, 63);
            this.TextButton.TabIndex = 23;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
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
            this.MenuButton.Location = new System.Drawing.Point(40, 24);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(65, 57);
            this.MenuButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.MenuButton, "Expand Menu");
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.doubleBufferPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1072, 717);
            this.Controls.Add(this.panelCavas);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(75, 81);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.panelCavas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SketchBox)).EndInit();
            this.doubleBufferPanel2.ResumeLayout(false);
            this.doubleBufferPanel1.ResumeLayout(false);
            this.doubleBufferPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
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
        private Bunifu.Framework.UI.BunifuFlatButton ZoomButton;
        private Bunifu.Framework.UI.BunifuFlatButton PanButton;
        private Bunifu.Framework.UI.BunifuFlatButton CropButton;
        private MenuPanel menuPanel;
        private DoubleBufferPanel panelCavas;
        private DoubleBufferPanel doubleBufferPanel1;
        private System.Windows.Forms.Label titleLb;
        private ShapesPanel shapesPanel;
        private BrushesPanel brushesPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuTileButton EffectsButton;
        private Bunifu.Framework.UI.BunifuTileButton CanvasButton;
        private Bunifu.Framework.UI.BunifuTileButton BrushesButton;
        private Bunifu.Framework.UI.BunifuTileButton ShapesButton;
        private Bunifu.Framework.UI.BunifuTileButton TextButton;
        private Bunifu.Framework.UI.BunifuFlatButton LayerButton;
        private LayerPanel layerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

