using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kashmir
{
    public partial class FrmCalc : Form
    {
        int StartingLabelX = 0;
        int StartingLabelY = 0;
        int StartingNumericX = 0;
        int StartingNumericY = 0;
        public FrmCalc()
        {
            InitializeComponent();
            StartingLabelX = LblWidth.Location.X;
            StartingLabelY = LblWidth.Location.Y;
            StartingNumericX = NumericWidth.Location.X;
            StartingNumericY = NumericWidth.Location.Y;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (RadioDouble.Checked)
            {
                NumericResult.Value = NumericWidth.Value * 2;
            }
            else
            {
                float FirstResult = (float)Math.Round(((float)(NumericWidth.Value * 2) / 1.4), 1);
                float SecondResult = (float)((double)NumericHeight.Value + 0.15);
                double Result = Math.Ceiling((double)FirstResult) * SecondResult;
                NumericWidthCount.Value = (decimal)Math.Ceiling(FirstResult);
                NumericResult.Value = (decimal)(Math.Ceiling(Result * 4) / 4);
            }
        }

        private void RadioDouble_CheckedChanged(object sender, EventArgs e)
        {
            ClearForm();
            LblHeight.Visible = false;
            NumericHeight.Visible = false;
            LblWidth.Location = new Point(LblHeight.Location.X, LblHeight.Location.Y);
            NumericWidth.Location = new Point(NumericHeight.Location.X, NumericHeight.Location.Y);
        }

        private void RadioSingle_CheckedChanged(object sender, EventArgs e)
        {
            ClearForm();
            LblHeight.Visible = true;
            NumericHeight.Visible = true;
            LblWidth.Location = new Point(StartingLabelX, StartingLabelY);
            NumericWidth.Location = new Point(StartingNumericX, StartingNumericY);
        }
        private void ClearForm()
        {
            NumericWidth.Value = 0;
            NumericHeight.Value = 0;
            NumericResult.Value = 0;
            NumericWidthCount.Value = 0;
        }
    }
}
