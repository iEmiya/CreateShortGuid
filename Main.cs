using System;
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

        private ShortGuid _shortGuid;
        private ShortGuidTypeView _typeView = ShortGuidTypeView.OnlyValue;

        public Main()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New_Click(this, EventArgs.Empty);
        }

        private void New_Click(object sender, EventArgs e)
        {
            _shortGuid = ShortGuid.NewGuid();
            SelectedFormat();
            ShowShortGuid();
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
            var sb = new StringBuilder();
            switch (_typeView)
            {
                case ShortGuidTypeView.OnlyValue:
                    sb.AppendLine("\"" + _shortGuid.Value + "\"");
                    break;
                case ShortGuidTypeView.RegistryFormat:
                    sb.AppendLine("//" + _shortGuid.Guid.ToString("B").ToUpper());
                    sb.AppendLine("\"" + _shortGuid.Value + "\"");
                    break;
                case ShortGuidTypeView.StaticConstStruct:
                    sb.AppendLine("//" + _shortGuid.Guid.ToString("B").ToUpper());
                    sb.AppendLine("static ShortGuid <<name>> = new ShortGuid(\"" + _shortGuid.Value + "\");");
                    break;
            }
            return sb.ToString();
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
    }
}
