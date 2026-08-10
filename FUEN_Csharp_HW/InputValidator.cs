using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUEN_Csharp_HW
{
    public delegate bool TryParseHandler<T>(string text, out T value);

    internal static class InputValidator
    {
        public static bool ValidateDecimal(TextBoxBase textbox, out decimal outputValue, string emptyMsg, string parseFailedMsg)
        {
            outputValue = -1;
            if (InputIsEmptyWithMsg(textbox, emptyMsg)) return false;
            if (!TryParseInputTextWithMsg(textbox, decimal.TryParse, out outputValue, parseFailedMsg)) return false;
            return true;
        }

        public static bool ValidateInt(TextBoxBase textbox, out int outputValue, string emptyMsg, string parseFailedMsg)
        {
            outputValue = -1;
            if (InputIsEmptyWithMsg(textbox, emptyMsg)) return false;
            if (!TryParseInputTextWithMsg(textbox, int.TryParse, out outputValue, parseFailedMsg)) return false;
            return true;
        }

        public static bool InputIsEmptyWithMsg(TextBoxBase txt, string errorMsg)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show(errorMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return true;
            }
            return false;
        }

        public static bool TryParseInputTextWithMsg<T>(TextBoxBase txt, TryParseHandler<T> handler, out T value, string errorMsg)
        {
            if (handler == null)
            {
                value = default;
                return false;
            }

            if (!handler(txt.Text, out value))
            {
                MessageBox.Show(errorMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt.Focus();
                txt.SelectAll();
                return false;
            }

            return true;
        }
    }
}
