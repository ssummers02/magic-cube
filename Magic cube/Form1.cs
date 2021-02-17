using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Magic_cube
{
    public partial class Form1 : Form
    {
        private int N = 3;
        List<List<int>> list = new List<List<int>>();
        List<List<TextBox>> boxList = new List<List<TextBox>>();

        public Form1()
        {
            InitializeComponent();
            CreateTextBoxes();
        }

        private void PrintMagicLabel(int a)
        {
            magicLabel = new Label();
            magicLabel.AutoSize = true;
            magicLabel.BackColor = Color.Transparent;
            magicLabel.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            magicLabel.ForeColor = Color.Gray;
            magicLabel.Location = new Point(20, 20 + 35 * N);
            magicLabel.Name = "magicLabel";
            magicLabel.Size = new Size(200, 19);
            magicLabel.Text = $@"Не магический квадрат";

            if (a == 1)
                magicLabel.Text = $@"Магический квадрат";

            this.Controls.Add(magicLabel);
        }

        private void DeleteControls()
        {
            this.Controls.Remove(magicLabel);
        }

        private void ClearLists()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    list.Clear();
                }
            }
        }

        private void CreateTextBoxes()
        {
            for (int i = 0; i < N; i++)
            {
                boxList.Add(new List<TextBox>());

                for (int j = 0; j < N; j++)
                {
                    boxList.Add(new List<TextBox>());
                    var tempTextBox = new TextBox()
                    {
                        Name = Convert.ToString(i) + Convert.ToString(j),
                        Location = new Point(20 + 35 * j, 20 + 35 * i),
                        Size = new Size(30, 30),
                        Text = @"0"
                    };
                    boxList[i].Add(tempTextBox);
                    Controls.Add(boxList[i][j]);
                }
            }
        }

        private int ListChecker()
        {
            DeleteControls();

            for (int i = 0; i < N; i++)
            {
                list.Add(new List<int>());

                for (int j = 0; j < N; j++)
                {
                    boxList[i][j].Text = boxList[i][j].Text;
                    bool success = Int32.TryParse(boxList[i][j].Text, out var number);

                    if (success)
                        list[i].Add(number);
                    else
                    {
                        MessageBox.Show($@"Проверьте значения!");
                        return -1;
                    }
                }
            }

            return 1;
        }

        private int Parse()
        {
            List<int> valid = new List<int>()
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            List<int> ch = new List<int>();

            for (int i = 0; i < N; i++)
            {
                int s = 0;

                for (int j = 0; j < N; j++)
                {
                    s += list[i][j];
                    ch.Add(list[i][j]);
                }

                if (s != 15)
                    return -1;
            }

            ch.Sort();

            for (int i = 0; i < valid.Count; i++)
            {
                if (valid[i] != ch[i])
                {
                    MessageBox.Show(Convert.ToString(ch));
                    return -1;
                }
            }

            for (int i = 0; i < N; i++)
            {
                int s = 0;

                for (int j = 0; j < N; j++)
                    s += list[j][i];

                if (s != 15)
                    return -1;
            }

            int a = 0;
            for (int i = 0; i < N; i++)
                a += list[i][i];
            if (a != 15)
                return -1;

            int k = N - 1;
            a = 0;

            for (int i = 0; i < 3; i++)
            {
                a += list[i][k];
                k--;
            }

            if (a != 15)
                return -1;

            return 1;
        }

        private void CleanButtonClick(object sender, EventArgs e)
        {
            ClearLists();
            DeleteControls();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    boxList[i][j].Text = @"0";
                }
            }
        }

        private void CheckmagickButtonClick(object sender, EventArgs e)
        {
            if (ListChecker() == 1)
            {
                PrintMagicLabel(Parse());
                ClearLists();
            }
            else
            {
                ClearLists();
                DeleteControls();
            }
        }

        private void CreateMagickButtonClick(object sender, EventArgs e)
        {
            DeleteControls();
            boxList[0][0].Text = @"2";
            boxList[0][1].Text = @"7";
            boxList[0][2].Text = @"6";

            boxList[1][0].Text = @"9";
            boxList[1][1].Text = @"5";
            boxList[1][2].Text = @"1";

            boxList[2][0].Text = @"4";
            boxList[2][1].Text = @"3";
            boxList[2][2].Text = @"8";

            CheckmagickButtonClick(sender, e);
        }
    }
}