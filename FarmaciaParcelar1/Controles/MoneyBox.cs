using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaciaParcelar1.Controles
{
    class MoneyBox : TextBox
    {
        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.BackColor = Color.SkyBlue;
            this.SelectAll();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.BackColor = Color.White;

            if (this.Text == "")
            {
                return;
            }
            try
            {
                NumberFormatInfo info = new NumberFormatInfo();
                info.CurrencySymbol = "Kz ";
                decimal valor = Convert.ToDecimal(this.Text.Replace("Kz ", ""));
                this.Text = String.Format(info ,"{0:c}", valor);
            }
            catch
            {
                this.Text = "";
                MessageBox.Show("Valor inválido", "moeda");
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "";
                e.SuppressKeyPress = true;
            }

        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.TextAlign = HorizontalAlignment.Center;
        }


    }
}
