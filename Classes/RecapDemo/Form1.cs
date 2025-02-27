﻿using System;
using System.Windows.Forms;

namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = System.Drawing.Color.Black;

                    }
                    else
                    {
                        buttons[i, j].BackColor = System.Drawing.Color.White;
                    }

                    this.Controls.Add(buttons[i, j]);

                }
                top += 50;
                left = 0;
            }
            top = 0;
        }
    }
}
