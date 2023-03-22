using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    [DefaultEvent("_TextChanged")]
    public partial class HRJTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;

        //Events
        public event EventHandler _TextChanged;

        //Properties
        [Category("RJ Code Advance")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate();}}

        [Category("RJ Code Advance")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        [Category("RJ Code Advance")]
        public bool UnderlineStyle { get => underlineStyle; set { underlineStyle = value; this.Invalidate(); } }

        [Category("RJ Code Advance")]
        public bool PasswordChar
        {
            get { return this.isPasswordChar; }
            set 
            { 
                isPasswordChar = value;
                txtMyBox.UseSystemPasswordChar = value;
            }
        }

        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return this.txtMyBox.Multiline; }
            set { txtMyBox.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; txtMyBox.BackColor = value; }}

        [Category("RJ Code Advance")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; txtMyBox.ForeColor = value; }}

        [Category("RJ Code Advance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                txtMyBox.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }

        [Category("RJ Code Advance")]
        public override string Text { 
            get
            {
                if (isPlaceholder) return "";
                return txtMyBox.Text;
            }
            set
            {
                txtMyBox.Text = value;
                SetPlaceHolder();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("RJ Code Advance")]
        public int BorderRadius { 
            get => borderRadius; 
            set 
            {
                if(value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate(); //Redraw control
                }
            } 
        }

        [Category("RJ Code Advance")]
        public Color PlaceholderColor { 
            get => placeholderColor;
            set 
            { 
                placeholderColor = value;
                if(isPasswordChar)
                {
                    txtMyBox.ForeColor = value;
                }
            } 
        }

        [Category("RJ Code Advance")]
        public string PlaceholderText { 
            get => placeholderText;
            set
            {
                placeholderText = value;
                txtMyBox.Text = "";
                SetPlaceHolder();
            }
        }

        //Constructor
        public HRJTextBox()
        {
            InitializeComponent();
        }

        //Overriden method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlineStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlineStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(txtMyBox.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                txtMyBox.Text = placeholderText;
                txtMyBox.ForeColor = placeholderColor;
                if (isPasswordChar)
                    txtMyBox.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceHolder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                txtMyBox.Text = "";
                txtMyBox.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    txtMyBox.UseSystemPasswordChar = true;
            }
        }

        private void SetTextBoxRoundRegion()
        {
            GraphicsPath pathTxt;
            if(Multiline)
            {
                pathTxt = GetFigurePath(txtMyBox.ClientRectangle, borderRadius - borderSize);
                txtMyBox.Region = new Region(pathTxt);
            } else
            {
                pathTxt = GetFigurePath(txtMyBox.ClientRectangle, borderSize*2);
                txtMyBox.Region = new Region(pathTxt);
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            {
                UpdateControlHeight();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //Private method
        private void UpdateControlHeight()
        {
            if(txtMyBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtMyBox.Multiline = true;
                txtMyBox.MinimumSize = new Size(0, txtHeight);
                txtMyBox.Multiline = false;
                this.Height = txtMyBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void txtMyBox_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void txtMyBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void txtMyBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void txtMyBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void txtMyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void txtMyBox_Enter(object sender, EventArgs e)
        {
            this.isFocused = true;
            this.Invalidate();
            RemovePlaceHolder();
        }

        private void txtMyBox_Leave(object sender, EventArgs e)
        {
            this.isFocused = false;
            this.Invalidate();
            SetPlaceHolder();
        }
    }
}
