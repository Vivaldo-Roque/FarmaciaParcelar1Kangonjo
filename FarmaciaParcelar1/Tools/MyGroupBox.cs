using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace FarmaciaParcelar1.Tools
{
    
    public partial class MyGroupBox : Form
    {
        private void MyGroupBox_Load(object sender, EventArgs e)
        {
            myGroupBox myGroupBox = new myGroupBox
            {
                Text = "GroupBox1",
                BorderColor = Color.Red
            };
            this.Controls.Add(myGroupBox);
        }

    }
    public class myGroupBox : GroupBox
    {
        private Color borderColor;
        public Color BorderColor
        {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        public myGroupBox()
        {
            this.borderColor = Color.Black;
        }
        protected override void OnPaint(PaintEventArgs e)
    {
        Size tSize = TextRenderer.MeasureText(this.Text, this.Font);
        Rectangle borderRect = e.ClipRectangle;
        ControlPaint.DrawBorder(e.Graphics, borderRect, this.borderColor, ButtonBorderStyle.Solid);
        borderRect.Y += tSize.Height / 2;
        borderRect.Height -= tSize.Height / 2;
        Rectangle textRect = e.ClipRectangle;
        textRect.Width = tSize.Width;
        textRect.X += 6;
        textRect.Height = tSize.Height;
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
    }
    }
}