using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DemoLib.Data;
using DemoLib.Tovars;

namespace DemoForms
{
    public partial class MainForm : Form
    {
        private DataTovar dataTovar;

        public MainForm()
        {
            InitializeComponent(); // Должно быть здесь
            dataTovar = new DataTovar();
            LoadTovars();
        }

        private void LoadTovars()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear(); // Теперь должно работать

                List<Tovar> tovars = dataTovar.GetAllTovars();

                if (tovars.Count == 0)
                {
                    Label lblEmpty = new Label();
                    lblEmpty.Text = "Нет товаров в базе данных";
                    lblEmpty.AutoSize = true;
                    lblEmpty.Font = new System.Drawing.Font("Arial", 12);
                    flowLayoutPanel1.Controls.Add(lblEmpty);
                }
                else
                {
                    foreach (Tovar tovar in tovars)
                    {
                        TovarCard card = new TovarCard();
                        card.ShowAllTovars(tovar);
                        card.Margin = new Padding(5);
                        flowLayoutPanel1.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}