using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace App_SPP_New.CustomUI
{
    public class HXDatePicker : DateTimePicker
    {
        //fields
        //apperance
        private Color skinColor = Color.Black;
        private Color textColor = Color.White;
        private Color borderColor = Color.Black;
        private int borderSize = 0;

        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.WhiteCalendarMini;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        //props
        [Category("Props")]
        public Color SkinColor 
        { 
            get
            { 
                return skinColor; 
            }
            set
            { 
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.8F)
                    calendarIcon = Properties.Resources.BlackCalendarMini;
                else calendarIcon = Properties.Resources.WhiteCalendarMini;
                this.Invalidate();
            }
        }

        [Category("Props")]
        public Color TextColor
        {
            get
            {
               return textColor;
            } 
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        [Category("Props")]
        public Color BorderColor 
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            } 
        }

        [Category("Props")]
        public int BorderSize 
        { 
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            } 
        }

        //constructor
        public HXDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);
        }

        //overide medo
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics()) 
            using (Pen penBorder = new Pen(borderColor, borderSize)) 
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Surfae
                graphics.FillRectangle(skinBrush, clientArea);
                //tex(important)
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Openclender
                if (droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                //boder
                if (borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                //ico
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height) / 2);

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }

        //priv mtod
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidth <= this.Width - (calendarIconWidth + 20))
                return calendarIconWidth;
            else return arrowIconWidth;
        }
    }
}
