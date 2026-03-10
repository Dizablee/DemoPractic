using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DemoLib.Tovars;

namespace DemoForms
{
    public partial class TovarCard : UserControl
    {
        private Tovar tovar_;

        public TovarCard()
        {
            InitializeComponent();
            // Простая настройка PictureBox
            pictureTovar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void ShowAllTovars(Tovar tovar)
        {
            tovar_ = tovar;

            // Текстовые поля
            lblName.Text = tovar.tovar_name;
            lblCategory.Text = tovar.tovar_category;
            labelOpisanie.Text = tovar.opisanie;
            labelPostavshik.Text = tovar.postavshik;
            labelProizvod.Text = tovar.proizvoditel;
            labelIzmerenie.Text = tovar.edinitsa_izmere;
            labelSkidka.Text = tovar.skidka.ToString() + "%";
            labelTsena.Text = tovar.price.ToString();
            labelCount.Text = tovar.count.ToString();

            // ЗАГРУЗКА ФОТО (ПРОСТО)
            string photoFileName = tovar.photo;

            if (!string.IsNullOrEmpty(photoFileName))
            {
                // Путь к папке Resources
                string resourcesPath = Path.Combine(Application.StartupPath, "Resources");
                string fullPath = Path.Combine(resourcesPath, photoFileName);

                // Проверяем и загружаем
                if (File.Exists(fullPath))
                {
                    try
                    {
                        pictureTovar.Image = Image.FromFile(fullPath);
                    }
                    catch
                    {
                        pictureTovar.BackColor = Color.LightGray;
                    }
                }
                else
                {
                    pictureTovar.BackColor = Color.LightGray;
                }
            }
            else
            {
                pictureTovar.BackColor = Color.LightGray;
            }
        }
    }
}