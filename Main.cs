using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CreateShortGuid
{
    public partial class Main : Form
    {
        private enum ShortGuidTypeView
        {
            Unknow = 0,
            OnlyValue = 1,
            RegistryFormat = 2,
            StaticConstStruct = 3,
        }

        private ShortGuid? _shortGuid;
        private Color _tbShortGuidBackColor;
        private ShortGuidTypeView _typeView = ShortGuidTypeView.OnlyValue;

        public Main()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tbShortGuidBackColor = tbShortGuid.BackColor;
            format1.Select();
            New_Click(this, EventArgs.Empty);
        }

        private void New_Click(object sender, EventArgs e)
        {
            tbShortGuid.Text = Guid.NewGuid().ToString();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(CopyShortGuid());
        }

        private void SelectedFormat()
        {
            switch (_typeView)
            {
                case ShortGuidTypeView.OnlyValue:
                    format1.Select();
                    break;
                case ShortGuidTypeView.RegistryFormat:
                    format2.Select();
                    break;
                case ShortGuidTypeView.StaticConstStruct:
                    format3.Select();
                    break;
            }
        }

        private void ShowShortGuid()
        {
            lResult.Text = CopyShortGuid();
        }

        private string CopyShortGuid()
        {
            if (!_shortGuid.HasValue)
            {
                tbShortGuid.BackColor = Color.Red;
                return string.Empty;
            }

            tbShortGuid.BackColor = _tbShortGuidBackColor;
            Guid guid = _shortGuid.Value.Guid;
            string str = _shortGuid.Value.Value;
            StringBuilder builder = new StringBuilder();
            switch (_typeView)
            {
                case ShortGuidTypeView.OnlyValue:
                    builder.Append("\"" + str + "\"");
                    break;
                case ShortGuidTypeView.RegistryFormat:
                    builder.AppendLine("//" + guid.ToString("B").ToUpper());
                    builder.Append("\"" + str + "\"");
                    break;
                case ShortGuidTypeView.StaticConstStruct:
                    builder.AppendLine("//" + guid.ToString("B").ToUpper());
                    builder.Append("static ShortGuid <<name>> = new ShortGuid(\"" + str + "\");");
                    break;
            }
            return builder.ToString();
        }

        private void format1_CheckedChanged(object sender, EventArgs e)
        {
            if (!format1.Checked) return;

            _typeView = ShortGuidTypeView.OnlyValue;
            ShowShortGuid();
        }

        private void format2_CheckedChanged(object sender, EventArgs e)
        {
            if (!format2.Checked) return;

            _typeView = ShortGuidTypeView.RegistryFormat;
            ShowShortGuid();
        }

        private void format3_CheckedChanged(object sender, EventArgs e)
        {
            if (!format3.Checked) return;

            _typeView = ShortGuidTypeView.StaticConstStruct;
            ShowShortGuid();
        }

        private void tbShortGuid_TextChanged(object sender, EventArgs e)
        {
            ShortGuid guid;
            _shortGuid = null;
            if (ShortGuid.TryParse(tbShortGuid.Text.Trim(), out guid))
            {
                _shortGuid = new ShortGuid?(guid);
            }
            ShowShortGuid();
        }
    }
}
