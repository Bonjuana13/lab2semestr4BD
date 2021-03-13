using lab2semestr4BD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2semestr4BD
{
    public partial class Form1 : Form
    {

        /*КОНТЕКСТ ДАННЫХ*/
        /// <summary>
        /// Связь с контекстом данных
        /// </summary>
        DaBaTheZooEntities1 db = new DaBaTheZooEntities1();



        /*ЗАПУСК ФОРМЫ*/
        /// <summary>
        /// Инициализация проекта
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            CloseAllTables();

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }



        /*РАБОТА С ПАНЕЛЯМИ*/
        /// <summary>
        /// Закрытие всех панелей
        /// </summary>
        private void CloseAllTables()
        {
            PanelZoo.Visible = false;
            PanelCage.Visible = false;
            PanelAnimal.Visible = false;
            PanelClass.Visible = false;
        }

        /// <summary>
        /// Убрать цвет с кнопок
        /// </summary>
        private void OffColor()
        {
            OpenZoo.BackColor = SystemColors.ActiveCaption;
            OpenCage.BackColor = SystemColors.ActiveCaption;
            OpenAnimal.BackColor = SystemColors.ActiveCaption;
            OpenClass.BackColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// Открытие панели зоопарк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenZoo_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenZoo.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelZoo.Visible = true;
            ShowMeAllZoo();
        }

        /// <summary>
        /// Открытие панели вольер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCage_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenCage.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelCage.Visible = true;
            ShowMeAllCage();

            //Добавление в комбобокс
            var tocom = (from zoo in db.Zoos
                           select new { zoo.ZooId, zoo.ZooName }).ToList();
            comboBox1.DataSource = tocom;
            comboBox1.DisplayMember = "ZooName";
            comboBox1.ValueMember = "ZooId";
        }

        /// <summary>
        /// Открытие панели животное
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAnimal_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenAnimal.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelAnimal.Visible = true;
            ShowMeAllAnimal();

            //Добавление в комбобокс
            var tocom = (from cage in db.Cages
                         select new { cage.CageId, cage.CageName }).ToList();
            comboBox2.DataSource = tocom;
            comboBox2.DisplayMember = "CageName";
            comboBox2.ValueMember = "CageId";

            var tocom1 = (from cl in db.Classes
                         select new { cl.ClassId, cl.ClassName }).ToList();
            comboBox3.DataSource = tocom1;
            comboBox3.DisplayMember = "ClassName";
            comboBox3.ValueMember = "ClassId";
        }

        /// <summary>
        /// Открытие панели класс
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenClass_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenClass.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelClass.Visible = true;
            ShowMeAllClass();
        }



        /*ВЫВОД ДАННЫХ*/
        /// <summary>
        /// Вывести зоопарки
        /// </summary>
        public void ShowMeAllZoo()
        {
            var zoolist = (from zoo in db.Zoos
                            select new { zoo.ZooId, zoo.ZooName }).ToList();
            DGVzoo.DataSource = zoolist;
            DGVzoo.Columns[0].HeaderText = "Айди";
            DGVzoo.Columns[1].HeaderText = "Название";
        }

        /// <summary>
        /// Вывести вольеры
        /// </summary>
        public void ShowMeAllCage()
        {
            var cagelist = (from cage in db.Cages
                            join zoo in db.Zoos on cage.ZooZooId equals zoo.ZooId
                            select new { cage.CageId, cage.CageName, cage.CageCount, zoo.ZooName }).ToList();
            DGVcage.DataSource = cagelist;
            DGVcage.Columns[0].HeaderText = "Айди";
            DGVcage.Columns[1].HeaderText = "Клетка";
            DGVcage.Columns[2].HeaderText = "Количество животинки";
            DGVcage.Columns[3].HeaderText = "Зоопарк";
        }

        /// <summary>
        /// Вывести животных
        /// </summary>
        public void ShowMeAllAnimal()
        {
            var animallist = (from animal in db.Animals
                            join cage in db.Cages on animal.CageCageId equals cage.CageId
                            join cl1 in db.Classes on animal.ClassClassId equals cl1.ClassId
                            select new { animal.AnimalId, animal.AnimalName, animal.AnimalAge, cage.CageName, cl1.ClassName }).ToList();
            DGVanimal.DataSource = animallist;
            DGVanimal.Columns[0].HeaderText = "Айди";
            DGVanimal.Columns[1].HeaderText = "Кличка";
            DGVanimal.Columns[2].HeaderText = "Годики";
            DGVanimal.Columns[3].HeaderText = "Клетка";
            DGVanimal.Columns[4].HeaderText = "Класс (отряд)";
        }

        /// <summary>
        /// Вывести классы
        /// </summary>
        public void ShowMeAllClass()
        {
            var classlist = (from cl in db.Classes
                             select new { cl.ClassId, cl.ClassName }).ToList();
            DGVclass.DataSource = classlist;
            DGVclass.Columns[0].HeaderText = "Айди";
            DGVclass.Columns[1].HeaderText = "Название класса";
        }




        /*ЗООПАРК*/
        /// <summary>
        /// Очистка полей зоопарка
        /// </summary>
        private void CleanZoo()
        {
            textBox1.Text = "";
        }

        /// <summary>
        /// Добавить зоопарк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddZoo_But_Click(object sender, EventArgs e)
        {
            try
            {
                Zoo zoo = new Zoo { ZooName = textBox1.Text };
                db.Zoos.Add(zoo);
                db.SaveChanges();
                CleanZoo();
                ShowMeAllZoo();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменить зоопарк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeZoo_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Zoos.Find(DGVzoo[0, DGVzoo.CurrentRow.Index].Value);
                currentrow.ZooName = textBox1.Text;
                db.SaveChanges();
                CleanZoo();
                DGVzoo.Refresh();
                ShowMeAllZoo();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удалить зоопарк
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteZoo_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Zoos.Find(DGVzoo[0, DGVzoo.CurrentRow.Index].Value);
                db.Zoos.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllZoo();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }




        /*ВОЛЬЕРЫ*/
        /// <summary>
        /// Очистка полей вольеров
        /// </summary>
        private void CleanCage()
        {
            textBox2.Text = "";
            textBox3.Text = "";
        }

        /// <summary>
        /// Добавление вольера (клетки)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCage_But_Click(object sender, EventArgs e)
        {
            try
            {
                Cage cage = new Cage { CageName = textBox2.Text, CageCount = Convert.ToInt32(textBox3.Text), ZooZooId = Convert.ToInt32(comboBox1.SelectedValue) };
                db.Cages.Add(cage);
                db.SaveChanges();
                CleanCage();
                ShowMeAllCage();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение вольера (клетки)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCage_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Cages.Find(DGVcage[0, DGVcage.CurrentRow.Index].Value);
                currentrow.CageName = textBox2.Text;
                currentrow.CageCount = Convert.ToInt32(textBox3.Text);
                currentrow.ZooZooId = Convert.ToInt32(comboBox1.SelectedValue);
                db.SaveChanges();
                CleanCage();
                DGVcage.Refresh();
                ShowMeAllCage();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление вольера (клетки)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCage_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Cages.Find(DGVcage[0, DGVcage.CurrentRow.Index].Value);
                db.Cages.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllCage();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }




        /*ЖИВОТНЫЕ*/
        /// <summary>
        /// Очистка полей животных
        /// </summary>
        private void CleanAnimal()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        /// <summary>
        /// Добавление животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAnimal_But_Click(object sender, EventArgs e)
        {
            try
            {
                Animal animal = new Animal { AnimalName = textBox4.Text, AnimalAge = Convert.ToByte(textBox5.Text), CageCageId = Convert.ToInt32(comboBox2.SelectedValue), ClassClassId = Convert.ToInt32(comboBox3.SelectedValue) };
                db.Animals.Add(animal);
                db.SaveChanges();
                CleanAnimal();
                ShowMeAllAnimal();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAnimal_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Animals.Find(DGVanimal[0, DGVanimal.CurrentRow.Index].Value);
                currentrow.AnimalName = textBox4.Text;
                currentrow.AnimalAge = Convert.ToByte(textBox5.Text);
                currentrow.CageCageId = Convert.ToInt32(comboBox2.SelectedValue);
                currentrow.ClassClassId = Convert.ToInt32(comboBox3.SelectedValue);
                db.SaveChanges();
                CleanAnimal();
                DGVanimal.Refresh();
                ShowMeAllAnimal();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление животного
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAnimal_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Animals.Find(DGVanimal[0, DGVanimal.CurrentRow.Index].Value);
                db.Animals.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllAnimal();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }




        /*КЛАССЫ*/
        /// <summary>
        /// Очистка полей классов
        /// </summary>
        private void CleanClass()
        {
            textBox6.Text = "";
        }

        /// <summary>
        /// Добавление класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddClass_But_Click(object sender, EventArgs e)
        {
            try
            {
                Class cla = new Class { ClassName = textBox6.Text };
                db.Classes.Add(cla);
                db.SaveChanges();
                CleanClass();
                ShowMeAllClass();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeClass_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Classes.Find(DGVclass[0, DGVclass.CurrentRow.Index].Value);
                currentrow.ClassName = textBox6.Text;
                db.SaveChanges();
                CleanClass();
                DGVclass.Refresh();
                ShowMeAllClass();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление класса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteClass_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Classes.Find(DGVclass[0, DGVclass.CurrentRow.Index].Value);
                db.Classes.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllClass();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }
    }
}
