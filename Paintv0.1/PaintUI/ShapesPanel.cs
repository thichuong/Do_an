﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Bunifu.Framework.UI;
using System.Drawing.Drawing2D;

namespace PaintUI
{
    public partial class ShapesPanel : UserControl
    {
        Pen pen;
        Brush brush;

        ShapeSelections selShape;

        bool fill;
        bool outline;

        bool pickerActive;

        public ShapesPanel()
        {
            InitializeComponent();
            pen = new Pen(colorPanel.getColor1(), 5);
            brush = new SolidBrush(colorPanel.getColor2());

            fill = false;
            outline = true;
            pickerActive = false;

            Shapes_FillCheckBox.Checked = false;
            Shapes_OutlineCheckBox.Checked = true;

            ResizeHelper.SetRevolution(curShapeBtn);

            selShape = new ShapeSelections();
            selShape.Location = new Point(0, curShapeBtn.Location.Y+curShapeBtn.Size.Height + 10);
            selShape.Size = new Size(Width+20, 0);
            Controls.Add(selShape);
            selShape.Show();
            selShape.BringToFront();

            selShape.ShapeSelected += SelShape_ShapeSelected;
            colorPanel.StateChanged += ColorPanel_StateChanged;
        }

        private void ColorPanel_StateChanged(object sender, EventArgs e)
        {
            pickerActive = !pickerActive;
        }

        private void SelShape_ShapeSelected(object sender, EventArgs e)
        {
            curShapeBtn.BackgroundImage = selShape.getImage();
            Slider slider = new Slider();
            slider.Sliding(selShape);
        }

        private void curShapeBtn_Leave(object sender, EventArgs e)
        {
            curShapeBtn.BackgroundImage = selShape.getImage();
            Slider slider = new Slider();
            slider.Sliding(selShape);
        }

        //Button Click
        private void curShapeBtn_Click(object sender, EventArgs e)
        {
            Slider slider = new Slider();
            slider.Sliding(selShape);
        }
        
        //draw outline and fill color
        public void FillShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            switch (selShape.getShape())
            {
                case 0: //rec
                    g.FillRectangle(brush, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 1: //elp
                    g.FillEllipse(brush, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 2: //line
                    break;
                case 3: //arr
                    g.FillPolygon(brush, Shape.FormArrow(old, cur, size));
                    break;
                case 4: //star
                    g.FillPolygon(brush, Shape.FormStar(old, cur, size));
                    break;
                case 5: //tri
                    g.FillPolygon(brush, Shape.FormTriangle(old, cur, size));
                    break;
                case 6: //lgt
                    g.FillPolygon(brush, Shape.FormLightning(old, cur, size));
                    break;
                case 7: //iso
                    g.FillPolygon(brush, Shape.FormIsoTriangle(old, cur, size));
                    break; 
                case 8: //hex
                    g.FillPolygon(brush, Shape.FormHexagon(old, cur, size));
                    break;
                case 9: //hrt
                    g.FillPath(brush, Shape.FormWHeart(old, cur, size));
                    break;
                default:
                    break;
            }
        }

        public void DrawOutline(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            switch (selShape.getShape())
            {
                case 0: // rec
                    g.DrawRectangle(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 1: //elp
                    g.DrawEllipse(pen, size.Width > 0 ? old.X : cur.X, size.Height > 0 ? old.Y : cur.Y, Math.Abs(size.Width), Math.Abs(size.Height));
                    break;
                case 2: //line
                    g.DrawLine(pen, old, cur);
                    break;
                case 3: //arr
                    g.DrawPolygon(pen, Shape.FormArrow(old, cur, size));
                    break;
                case 4: //star
                    g.DrawPolygon(pen, Shape.FormStar(old, cur, size));
                    break;
                case 5: //tri
                    g.DrawPolygon(pen, Shape.FormTriangle(old, cur, size));
                    break;
                case 6: //lgt
                    g.DrawPolygon(pen, Shape.FormLightning(old, cur, size));
                    break;
                case 7: //iso
                    g.DrawPolygon(pen, Shape.FormIsoTriangle(old, cur, size));
                    break; 
                case 8: //hex
                    g.DrawPolygon(pen, Shape.FormHexagon(old, cur, size));
                    break;
                case 9: //heart
                    try
                    {
                        pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                        g.DrawPath(pen, Shape.FormLHeart(old, cur, size));
                        g.DrawPath(pen, Shape.FormRHeart(old, cur, size));
                    }
                    catch (Exception)
                    {

                    }
                    break;
                default:
                    break;
            }
        }

        public void DrawShapes(PictureBox p, Bitmap bm, Graphics g, Point old, Point cur, Size size)
        {
            if(fill)
            {
                brush = new SolidBrush(colorPanel.getColor2());

                FillShapes(p, bm, g, old, cur, size);
            }
            if(outline)
            {
                pen = new Pen(colorPanel.getColor1(), thicknessSlide.Value);
                
                DrawOutline(p, bm, g, old, cur, size);
            }
        }
        
        private void Shapes_FillCheckBox_OnChange(object sender, EventArgs e)
        {
            if(fill)
                fill = false;
            else
                fill = true;
        }

        private void Shapes_OutlineCheckBox_OnChange(object sender, EventArgs e)
        {
            if (outline)
                outline = false;
            else
                outline = true;
        }
}
}
