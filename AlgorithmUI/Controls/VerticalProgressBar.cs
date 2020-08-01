using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Algorithm.Controls
{
	public enum Styles { Classic, Solid }
	public enum BorderStyles { Classic, None }

	[Description("Vertical Progress Bar")]
	[ToolboxBitmap(typeof(ProgressBar))]
	[Browsable(false)]
	public sealed class VerticalProgressBar : UserControl
	{
		private Container components = null;

		private int _value = 50;
		private int _minimum = 0;
		private int _maximum = 100;

		private Styles _style = Styles.Solid;
		private BorderStyles _borderStyle = BorderStyles.Classic;
		private Color _color = Color.Green;
		private Color _borderColor = Color.Gray;

		public VerticalProgressBar()
		{
			InitializeComponent();
			
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);

			Name = "VerticalProgressBar";
			Size = new Size(18, 100);
		}

		[Description("VerticalProgressBar Maximum Value")]
		[Category("VerticalProgressBar")]
		[RefreshProperties(RefreshProperties.All)]
		public int Maximum
		{
			get => _maximum;
			set
			{
				_maximum = value;
				if (_maximum < _minimum) _minimum = _maximum;
				if (_maximum < _value) _value = _maximum;
				Invalidate();
			}
		}

		[Description("VerticalProgressBar Minimum Value")]
		[Category("VerticalProgressBar")]
		[RefreshProperties(RefreshProperties.All)]
		public int Minimum
		{
			get => _minimum;
			set
			{
				_minimum = value;
				if (_minimum > _maximum) _maximum = _minimum;
				if (_minimum > _value) _value = _minimum;
				Invalidate();
			}
		}

		[Description("VerticalProgressBar Step")]
		[Category("VerticalProgressBar")]
		[RefreshProperties(RefreshProperties.All)]
		public int Step { get; set; } = 10;

		[Description("VerticalProgressBar Current Value")]
		[Category("VerticalProgressBar")]
		public int Value
		{
			get => _value;
			set
			{
				_value = value;
				SetValue();
				Invalidate();
			}
		}

		[Description("VerticalProgressBar Color")]
		[Category("VerticalProgressBar")]
		[RefreshProperties(RefreshProperties.All)]
		public Color Color
		{
			get => _color;
			set
			{
				_color = value;
				Invalidate();
			}
		}

		[Description("VerticalProgressBar BorderColor")]
		[Category("VerticalProgressBar")]
		[RefreshProperties(RefreshProperties.All)]
		public Color BorderColor
		{
			get => _borderColor;
			set
			{
				_borderColor = value;
				Invalidate();
			}
		}

		[Description("VerticalProgressBar Border Style")]
		[Category("VerticalProgressBar")]
		public new BorderStyles BorderStyle
		{
			get => _borderStyle;
			set
			{
				_borderStyle = value;
				Invalidate();
			}
		}

		[Description("VerticalProgressBar Style")]
		[Category("VerticalProgressBar")]
		public Styles Style
		{
			get => _style;
			set
			{
				_style = value;
				Invalidate();
			}
		}

		public void PerformStep()
		{
			_value += Step;
			SetValue();
			Invalidate();
		}

		private void SetValue()
		{
			if (_value > _maximum) _value = _maximum;
			if (_value < _minimum) _value = _minimum;
		}

		public void Increment(int value)
		{
			_value += value;
			SetValue();
			Invalidate();
		}

		private void DrawBorder(Graphics dc)
		{
			if (_borderStyle == BorderStyles.Classic)
			{
				Color darkColor = ControlPaint.Dark(BorderColor);
				Color brightColor = ControlPaint.Dark(BackColor);

				Pen pen = new Pen(darkColor, 1);
				dc.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);

				pen = new Pen(brightColor, 1);
				dc.DrawLine(pen, 0, Height, Width, Height);
				dc.DrawLine(pen, Width, Height, Width, 0);
			}
		}

		private void DrawBar(Graphics dc)
		{
			if (_minimum == _maximum || (_value - _minimum) == 0) return;

			int width, height, x, y;           

			if (_borderStyle == BorderStyles.None)
			{
				width = Width;
				x = 0;
				y = Height;
			}
			else
			{
				if (Width > 4 || Height > 2)
				{
					width = Width - 4;
					x = 2;
					y = Height - 1;
				}
				else return;
			}

			height = (_value - _minimum) * Height / (_maximum - _minimum);

			if (_style == Styles.Solid)
			{
				DrawSolidBar(dc, x, y, width, height);
			}

			if (_style == Styles.Classic)
			{
				DrawClassicBar(dc, x, y, width, height);
			}
		}

		private void DrawSolidBar(Graphics dc, int x, int y, int width, int height)
		{
			dc.FillRectangle(new SolidBrush(_color), x, y - height, width, height);
		}

		private void DrawClassicBar(Graphics dc, int x, int y, int width, int height)
		{
			int valuepos_y = y - height;   
			int blockheight = width * 3 / 4; 

			if (blockheight <= -1) return;

			for (int currentpos = y; currentpos > valuepos_y; currentpos -= blockheight + 1)
			{
				dc.FillRectangle(new SolidBrush(_color), x, currentpos - blockheight, width, blockheight);
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics dc = e.Graphics;
	
			DrawBar(dc);			
			DrawBorder(dc);
			base.OnPaint(e);
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			Invalidate();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null) components.Dispose();
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new Container();
		}
	}
}