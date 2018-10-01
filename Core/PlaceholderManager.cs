using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBicycle.Core
{
    public static class PlaceholderManager
    {
        public static void AddPlaceholder(this TextBox tb, string placeholderText )
        {
            // Fill text field with placeholder
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;

            // Textbox is in the focus
            tb.Enter += (s, e) =>
            {
                if (tb.Text != placeholderText)
                    return;
                tb.ForeColor = Color.Black;
                tb.Text = "";

            };

            // Textbox is out of focus
            tb.Leave += (s, e) =>
            {
                if (tb.Text != "")
                    return;
                tb.ForeColor = Color.Gray;
                tb.Text = placeholderText;
            };

        }
    }
}
