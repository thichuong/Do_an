using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintUI
{
    public partial class LayerPanel : UserControl
    {
        public int LayerCounter=-1;
        public event EventHandler AddLayerClicked;
        public event EventHandler LayerClicked;
        public event EventHandler BaseLayerClicked;
        public event EventHandler LayerRemoved;
        public bool rightclicked = false;
        Button layer1;
        public int removedLayerIndex=0;
        public List<Button> layerIconList = new List<Button>();
        public LayerPanel()
        {
            InitializeComponent();
            this.ControlRemoved += LayerPanel_ControlRemoved;
           
        }
        public void reset()
        {
            while(LayerCounter>-1)
            {
                this.Controls.Remove(layerIconList[LayerCounter]);
                LayerCounter--;
            }
        }
        private void LayerPanel_ControlRemoved(object sender, ControlEventArgs e)
        {            
            removedLayerIndex = Convert.ToInt32(e.Control.Name);
            BaseLayer.Focus();
            if (this.LayerRemoved!=null)
            {
                this.LayerRemoved(sender, e);
            }
        }      
        private void AddButton_Click(object sender, EventArgs e)
        {
            LayerCounter++;
            initLayer();            
            this.Controls.Add(layer1);
            layerIconList.Add(layer1);
            
            if (this.AddLayerClicked!=null)
            {
                this.AddLayerClicked(sender, e);
            }
        }
        void initLayer()
        {     
            layer1 = new Button();
            layer1.Size = AddButton.Size;
            layer1.Dock = DockStyle.Top;
            layer1.BackColor = Color.White;
            layer1.Font = AddButton.Font;
            if (LayerCounter == 0) layer1.Text = LayerCounter.ToString();
            else if (layerIconList.Count > 0)
            {
                int maxIndex = Convert.ToInt32(layerIconList[layerIconList.Count - 1].Text);
                layer1.Text = (maxIndex + 1).ToString();
            }
            else layer1.Text = "0";
            layer1.Name = LayerCounter.ToString();            
            Console.WriteLine("counting " +layerIconList.Count);          
            layer1.MouseDown += Layer1_MouseDown;
        }

        private void Layer1_MouseDown(object sender, MouseEventArgs e)
        {
            rightclicked = false;
            if (e.Button == MouseButtons.Right)
            {
                rightclicked = true;
                Button btn = sender as Button;
                this.Controls.Remove(btn);
                layerIconList.Remove(btn);
            }
            if (this.LayerClicked != null)
            {
                this.LayerClicked(sender, e);
            }
        }

        private void BaseLayer_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.BaseLayerClicked!=null)
            {
                this.BaseLayerClicked(sender, e);
            }
        }
       
    }
}
