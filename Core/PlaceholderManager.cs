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
        // Расширающий метод для текстбокса
        public static void AddPlaceholder(this TextBox tb, string placeholderText )
        {
            // Заполняет текстовое поле плейсхолдером
            tb.ForeColor = Color.Gray;
            tb.Text = placeholderText;

            // Лямбда-выражения для управления событиями

            // Событие входа текстового поля в фокус
            tb.Enter += (s, e) => // Приписываем событию метод с делегатом EventHandler(object s, EventArgs e)
            {
                if (tb.Text == placeholderText)
                {
                    tb.ForeColor = Color.Black;
                    tb.Text = "";
                }

            };

            // Событие выхода из фокуса
            tb.Leave += (s, e) =>
            {
                if(tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;
                    tb.Text = placeholderText;
                }


            };

        }

        private static void Tb_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
