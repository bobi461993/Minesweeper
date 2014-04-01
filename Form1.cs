using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form1 : Form
    {
        List<Button> btnList; //
        public Form1()
        {
            InitializeComponent();
            loadButtons();
        }

        private void loadButtons()
        {
            btnList = new List<Button>();
            int w = panel1.Width / 9;
            int h = panel1.Height / 9;

            //Button btn = new Button();
            //btn.Name = "btn1";
            //btn.Size = new Size(w, h);
            //btn.Location = new Point(15, 15);
            //btnList.Add(btn);
            ////this.Controls.Add(btn);
            //panel1.Controls.Add(btn);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Name = "btn" + i.ToString();
                    btn.Size = new Size(w, h);
                    btn.Location = new Point(w * i, 5 + h * j);
                    btnList.Add(btn);
                    panel1.Controls.Add(btn);
                }
            }
        }
    }
}
