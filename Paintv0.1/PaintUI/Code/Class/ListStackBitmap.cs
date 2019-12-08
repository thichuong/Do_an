using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PaintUI.Code.Class
{
    class ListStackBitmap
    {
        List<Stack<Bitmap>> ListStackBM;
        Stack<Bitmap> bm;
        public ListStackBitmap()
        {
            ListStackBM = new List<Stack<Bitmap>>();
            bm = new Stack<Bitmap>();
        }
        public void addStack(Stack<Bitmap> bitmaps)
        {
            ListStackBM.Add(bitmaps);
        }
        public void Push(Bitmap bmp,int curLayer)
        {
            if (curLayer != -1)
                ListStackBM[curLayer].Push((Bitmap)bmp.Clone());
            else
                bm.Push((Bitmap)bmp.Clone());
        }
        public int Count(int curLayer)
        {
            if (curLayer != -1)
                return ListStackBM[curLayer].Count();
            else
                return bm.Count();
        }
        public Bitmap Pop(int curLayer)
        {
            if (curLayer != -1)
                return (Bitmap)ListStackBM[curLayer].Pop().Clone();
            else
                return (Bitmap)bm.Pop().Clone();
        }
      
        public Bitmap Peek(int curLayer)
        {
            if (curLayer != -1)
                return (Bitmap)ListStackBM[curLayer].Peek().Clone();
            else
                return (Bitmap)bm.Peek().Clone();
        }
    }
}
