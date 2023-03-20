﻿using SEV.Task._5.Core;
using System;
using System.Reflection.Emit;
using System.Windows;
using System.Windows.Controls;

namespace SEV.Task._5.View.Pages.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                int DecimalNumber = 0;

                for (int i = 0; i < A.Length; i++) 
                {
                    if (A[A.Length - i - 1] == '0') continue; 
                    DecimalNumber += (int)Math.Pow(2, i);
                }
                string B = Convert.ToString(DecimalNumber, 16);
                MessageBox.Show($"{B}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
                //TestWIndow tw = new(this);

            }

        }

    }
}