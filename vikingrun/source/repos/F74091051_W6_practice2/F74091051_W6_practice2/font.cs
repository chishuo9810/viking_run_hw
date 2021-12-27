using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F74091051_W6_practice2
{
    class font
    {
        public void ChangeLabel(System.Windows.Forms.Label label,int i)
        {
            if (i == 1)
            {
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }
            else if (i ==2)
            {
                label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            }
            else if (i == 3)
            {
                label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            }
        }
        public void Font(System.Windows.Forms.Label label, System.Windows.Forms.RadioButton first, System.Windows.Forms.RadioButton second, System.Windows.Forms.RadioButton third, System.Windows.Forms.CheckBox one, System.Windows.Forms.CheckBox two,int i)
        {
            if (first.Checked)
            {
                if(one.Checked&&two.Checked)
                    label.Font = new System.Drawing.Font("標楷體", i, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                else if (one.Checked)
                {
                    label.Font = new System.Drawing.Font("標楷體", i, System.Drawing.FontStyle.Bold , System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (two.Checked)
                {
                    label.Font = new System.Drawing.Font("標楷體", i,  System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    label.Font = new System.Drawing.Font("標楷體", i, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            else if (second.Checked )
            {
                if (one.Checked && two.Checked)
                    label.Font = new System.Drawing.Font("新細明體", i, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                else if (one.Checked)
                {
                    label.Font = new System.Drawing.Font("新細明體", i, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (two.Checked)
                {
                    label.Font = new System.Drawing.Font("新細明體", i, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    label.Font = new System.Drawing.Font("新細明體", i, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            else if (third.Checked )
            {
                if (one.Checked && two.Checked)
                    label.Font = new System.Drawing.Font("微軟正黑體", i, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                else if (one.Checked)
                {
                    label.Font = new System.Drawing.Font("微軟正黑體", i, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else if (two.Checked)
                {
                    label.Font = new System.Drawing.Font("微軟正黑體", i, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    label.Font = new System.Drawing.Font("微軟正黑體", i, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }

        }
    }
}
