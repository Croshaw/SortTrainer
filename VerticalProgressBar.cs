using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTrainer
{
    public partial class VerticalProgressBar : Control
    {
        private Color _color;
        private int _value;
        public Color GridColor { get; set; }
        public Color Color { get { return _color; } set { _color = value; OnPropChanged(); } }
        public bool ShowGrid { get; set; }
        public bool ShowValue { get; set; }
        public int MaxValue { get; set; }
        public int MinValue { get; set; }
        public int Value { get { return _value; } set { _value = value; OnPropChanged(); } }
        public int Step { get; set; }

        public VerticalProgressBar()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
            Size = new Size(20, 91);
            GridColor = Color.Black;
            _color = Color.Blue;
            _value = 50;
            MaxValue = 100;
            MinValue = 0;
            Step = 1;
            ShowGrid = true;
            ShowValue = true;
        }

        private void OnPropChanged()
        {
            try
            {
                this.Refresh();
            }
            catch { }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.Clear(Parent.BackColor);

            Size _sizeText = g.MeasureString(Value.ToString(), Font).ToSize();
            Size _sizeRect = new(Size.Width, ShowValue ? (Size.Height - _sizeText.Height-5) : Size.Height);

            
            using SolidBrush brush = new(Color);
            double _height = (double)Value / (double)MaxValue;
            g.FillRectangle(new SolidBrush(BackColor), 0, 0, _sizeRect.Width, _sizeRect.Height);
            g.FillRectangle(brush, 0, _sizeRect.Height - (int)(_height * _sizeRect.Height), _sizeRect.Width, (int)(_height * _sizeRect.Height));
            if (ShowGrid)
            {
                using Pen pen = new(GridColor);
                g.DrawRectangle(pen, 0, 0, _sizeRect.Width - 1, _sizeRect.Height - (ShowValue ? 0 : 1)); 
            }
            if(ShowValue)
                g.DrawString(Value.ToString(), Font, new SolidBrush(ForeColor), (Size.Width/2)-(_sizeText.Width/2), _sizeRect.Height + 5);

        }
    }
}
