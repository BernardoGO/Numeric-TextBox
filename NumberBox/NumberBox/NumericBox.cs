using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace NumberBox
{
    [ToolboxBitmapAttribute(typeof(TextBox))]

    public partial class NumericBox : TextBox
    {
        #region private vars
        private const int WM_PAINT = 0x000F;
        private int defaultValue = 0;
        private bool allowSpace = true;
        private bool allowNumbers = true;
        private bool allowDecimal = true;
        private bool allowControls = true;
        private bool allowLetters = true;
        private bool changeColor = false;
        private bool transparentBox = false;
        private Color changeColorTo = Color.AliceBlue;
        private Color color;
        #endregion

        #region Initialize
        public NumericBox()
        {
            InitializeComponent();
        }

        public NumericBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region events
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            NumberFormatInfo numberFormatInfo = CultureInfo.CurrentCulture.NumberFormat;
            
            if (e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else if(allowNumbers && char.IsNumber(e.KeyChar))
                e.Handled = false;
            else if (allowDecimal && e.KeyChar.ToString() == numberFormatInfo.NumberDecimalSeparator)
                e.Handled = false;
            else if (allowLetters && char.IsLetter(e.KeyChar))
                e.Handled = false;
            else if (allowControls && char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (allowSpace && e.KeyChar == (char)Keys.Space)
                e.Handled = false;
            else
                e.Handled = true;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (changeColor)
            {
                color = this.BackColor;
                this.BackColor = changeColorTo;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            if (changeColor)
                this.BackColor = color;
        }

        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);

            if (m.Msg == WM_PAINT && transparentBox)
            {
                this.BackColor = this.FindForm().BackColor;

            }

        }
        #endregion

        #region Getters and Setters
        internal int Integer
        {
           get
            {
                try
                {
                    return Convert.ToInt32(this.Text);
                }
                catch { return defaultValue; }
            }
        }

        internal double Double
        {
            get
            {
                try
                {
                    return Convert.ToDouble(this.Text);
                }
                catch { return defaultValue; }
            }
        }

        
        #endregion

        #region properties
        public int DefaultValue
        {
            set
            {
                this.defaultValue = value;
            }

            get
            {
                return this.defaultValue;
            }
        }
        public bool ChangeColor
        {
            set
            {
                this.changeColor = value;
            }

            get
            {
                return this.changeColor;
            }
        }
        public bool AllowDecimal
        {
            set
            {
                this.allowDecimal = value;
            }

            get
            {
                return this.allowDecimal;
            }
        }
        public bool AllowLetters
        {
            set
            {
                this.allowLetters = value;
            }

            get
            {
                return this.allowLetters;
            }
        }
        public bool AllowControls
        {
            set
            {
                this.allowControls = value;
            }

            get
            {
                return this.allowControls;
            }
        }

        public bool AllowNumbers
        {
            set
            {
                this.allowNumbers = value;
            }

            get
            {
                return this.allowNumbers;
            }
        }

        public bool AllowSpace
        {
            set
            {
                this.allowSpace = value;
            }

            get
            {
                return this.allowSpace;
            }
        }

        public Color ChangeColorTo
        {
            set
            {
                this.changeColorTo = value;
            }

            get
            {
                return this.changeColorTo;
            }
        }

        public bool TransparentBox
        {
            set
            {
                this.transparentBox = value;
            }

            get
            {
                return this.transparentBox;
            }
        }
        #endregion
    }
}
