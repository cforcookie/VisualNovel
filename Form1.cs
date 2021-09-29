using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legends_of_KTEP
{
    public partial class Form1 : Form
    {
        //Блок глобальных перенных
        private static int i = 0; //Глобальный счетчик строк
        private static string[] narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Трактир_Начало.txt"); //Считование файла и запись всех прочитанных строк в список
        public static bool npc; //Булево значение, определяющие, по какому направлению идет сюжет
        //Список всех доступных расс в игре
        string[] rasist = new string[8] { "Человек мужчина", "Человек женщина", "Эльф мужчина", "Эльф женщина", "Дворф мужчина",
            "Дворф женщина", "Ликантроп мужчина", "Ликантроп женщина"};
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            //В этом блоке перечислены события, направленные на особые события в игре
            //Блок активирующийся, при окончании игры
            if (narrator[i] == "*КонецИгры")
            {
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                pictureBox1.Visible = false;
                label9.Visible = false;
                pictureBox2.Visible = false;
                button2.Visible = true;
                button2.Text = "Закрыть игру";
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\maxresdefault.jpg");
            }
            //Блок активирующийся, при возможности какого-то выбора в игре
            if (narrator[i] == "*ВыборТри")
            {
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label6.Text = narrator[i + 1] + label4.Text;
                label7.Text = narrator[i + 2] + label4.Text;
                label8.Text = narrator[i + 3];
                label3.Enabled = false;
                i = i + 4;
            }
            if (narrator[i] == "*ГлавныйГеройБезВыбора")
            {
                label6.Visible = true;
                label7.Visible = true;
                label6.Text = narrator[i + 1];
                label7.Text = narrator[i + 2];
                label3.Enabled = false;
                i = i + 3;
            }
            if (narrator[i] == "*ВыборЛокации")
            {
                label6.Visible = true;
                label7.Visible = true;
                label6.Text = narrator[i + 1];
                label7.Text = narrator[i + 2];
                label3.Enabled = false;
            }
            //Далее идут блоки персонажей в игре
            if (narrator[i] == "*Диктор")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Рассказчик";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Дана.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Данаймон")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Данаймон";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Дана.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Баг`Дан")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Баг`Дан";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_22-09-24.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Вовендальф")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Вовендальф";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Вовендальф.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Лягушка")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Лягушка";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_21-53-17.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Тёмариэль")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Тёмариэль";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Артёмка.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Стасяныч")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Стасяныч";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Стасян.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Копейна")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Копейна";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Копеина.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*Бармалеева")
            {
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Бармалеева";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\Бармалеева.jpg");
                label3.Text = narrator[i + 1];
                i++;
            }
            //Блоки связанные с главным героем(игроком)
            if (narrator[i] == "*ГлавныйГерой")
            {
                label9.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = narrator[i + 1];
                i++;
            }
            if (narrator[i] == "*ГлавныйГеройОпция")
            {
                label9.Visible = false;
                pictureBox2.Visible = false;
                label6.Visible = true;
                label3.Enabled = false;
                label6.Text = narrator[i + 1];
                i += 2;
            }
            //Блоки особых событий в игре, переключение между файлами сюжета игры
            if (narrator[i] == "$$$")
            {
                narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Развилка.txt");
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_21-53-15.jpg");
                i = 1;
            }
            if (narrator[i] == "%$$")
            {
                if (npc == true)
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Туманная тропа_Эльф.txt");
                }
                else
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Туманная тропа_Дворф.txt");
                }
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_22-39-14.jpg");
                i = 1;
            }
            if (narrator[i] == "%%$")
            {
                if (npc == true)
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Лагерь_Эльф.txt");
                }
                else
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Лагерь_Дворф.txt");
                }
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_22-41-33.jpg");
                i = 1;
            }
            if (narrator[i] == "%%%")
            {
                if (npc == true)
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Криптоземли_Эльф.txt");
                }
                else
                {
                    narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Криптоземли_Дворф.txt");
                }
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_22-44-43.jpg");
                i = 1;
            }
            if (narrator[i] == "!!!")
            {
                narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Трактир_Конец.txt");
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\C3hYgC3WAAAv-3s.jfif");
                i = 1;
                label4.Text = textBox1.Text;
                label9.Visible = true;
                pictureBox2.Visible = true;
                label9.Text = "Баг`Дан";
                pictureBox2.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_22-09-24.jpg");

            }
            //Переключение строк в игре, если ни одно из событий выше не вызвалось
            else
            {
                label3.Text = narrator[i];
                i++;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Lable 6-8 отведены для системы выбора, выбор влияет на сюжет
        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "- Я " + label4.Text)
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Enabled = true;
            }
            if (label6.Text == "- Мы пойдем в Глубь леса, там безопаснее... Скорее всего.")
            {
                npc = true;
                label6.Visible = false;
                label7.Visible = false;
                label3.Enabled = true;
                narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Лес.txt");
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_18-39-21.jpg");
                i = 1;
                label3.Text = narrator[i];
            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Enabled = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (label7.Text == "- Я великий и неповторимый герой - " + label4.Text)
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Enabled = true;
            }
            if (label7.Text == "- Мы пойдем в пещеру, вдруг там что-то есть...")
            {
                npc = false;
                label6.Visible = false;
                label7.Visible = false;
                label3.Enabled = true;
                narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/Пещера.txt");
                this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\photo_2021-06-20_18-39-23.jpg");
                i = 1;
                label3.Text = narrator[i];
            }
            else
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Enabled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (label8.Text == "- Неть...")
            {
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label3.Enabled = true;
                narrator = File.ReadAllLines("C:/Users/JastB/3D Objects/Новая папка/Дворф/ОтветНаНеть.txt");
                i = 1;
                label3.Text = narrator[i];
            }

        }
        //Блок отведен под стартовый экран и взаимодействие с ним
        //Нажатие кнопки button1 выключает стартовый экран и запускает игру
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\C3hYgC3WAAAv-3s.jfif");
            label1.Visible = false;
            label2.Visible = false;
            comboBox1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            pictureBox1.Visible = true;
            label4.Text = textBox1.Text;
            label5.Text = comboBox1.Text;

            for (int j = 0; j < rasist.Length; j++)
            {
                if (comboBox1.Text == rasist[j])
                {
                    string name = rasist[j] + ".jpg";
                    pictureBox1.BackgroundImage = new Bitmap(@"C:\Users\JastB\3D Objects\едрить-колотить\" + name);
                }
            }
            label3.Text = "Начало игры";
        }

        private void ё(object sender, EventArgs e)
        {

        }

        //Кнопка для закрытия игры, появляеться при окончании игры
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
