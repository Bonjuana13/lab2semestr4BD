namespace lab2semestr4BD
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenZoo = new System.Windows.Forms.Button();
            this.OpenCage = new System.Windows.Forms.Button();
            this.OpenAnimal = new System.Windows.Forms.Button();
            this.OpenClass = new System.Windows.Forms.Button();
            this.PanelZoo = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteZoo_But = new System.Windows.Forms.Button();
            this.ChangeZoo_But = new System.Windows.Forms.Button();
            this.DGVzoo = new System.Windows.Forms.DataGridView();
            this.AddZoo_But = new System.Windows.Forms.Button();
            this.PanelCage = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteCage_But = new System.Windows.Forms.Button();
            this.ChangeCage_But = new System.Windows.Forms.Button();
            this.DGVcage = new System.Windows.Forms.DataGridView();
            this.AddCage_But = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PanelAnimal = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteAnimal_But = new System.Windows.Forms.Button();
            this.ChangeAnimal_But = new System.Windows.Forms.Button();
            this.DGVanimal = new System.Windows.Forms.DataGridView();
            this.AddAnimal_But = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelClass = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeleteClass_But = new System.Windows.Forms.Button();
            this.ChangeClass_But = new System.Windows.Forms.Button();
            this.DGVclass = new System.Windows.Forms.DataGridView();
            this.AddClass_But = new System.Windows.Forms.Button();
            this.PanelZoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVzoo)).BeginInit();
            this.PanelCage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcage)).BeginInit();
            this.PanelAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVanimal)).BeginInit();
            this.PanelClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclass)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenZoo
            // 
            this.OpenZoo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenZoo.Location = new System.Drawing.Point(12, 12);
            this.OpenZoo.Name = "OpenZoo";
            this.OpenZoo.Size = new System.Drawing.Size(212, 66);
            this.OpenZoo.TabIndex = 2;
            this.OpenZoo.Text = "Зоопарк";
            this.OpenZoo.UseVisualStyleBackColor = false;
            this.OpenZoo.Click += new System.EventHandler(this.OpenZoo_Click);
            // 
            // OpenCage
            // 
            this.OpenCage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenCage.Location = new System.Drawing.Point(314, 12);
            this.OpenCage.Name = "OpenCage";
            this.OpenCage.Size = new System.Drawing.Size(212, 66);
            this.OpenCage.TabIndex = 3;
            this.OpenCage.Text = "Вольеры";
            this.OpenCage.UseVisualStyleBackColor = false;
            this.OpenCage.Click += new System.EventHandler(this.OpenCage_Click);
            // 
            // OpenAnimal
            // 
            this.OpenAnimal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenAnimal.Location = new System.Drawing.Point(626, 12);
            this.OpenAnimal.Name = "OpenAnimal";
            this.OpenAnimal.Size = new System.Drawing.Size(212, 66);
            this.OpenAnimal.TabIndex = 4;
            this.OpenAnimal.Text = "Животные";
            this.OpenAnimal.UseVisualStyleBackColor = false;
            this.OpenAnimal.Click += new System.EventHandler(this.OpenAnimal_Click);
            // 
            // OpenClass
            // 
            this.OpenClass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenClass.Location = new System.Drawing.Point(930, 12);
            this.OpenClass.Name = "OpenClass";
            this.OpenClass.Size = new System.Drawing.Size(212, 66);
            this.OpenClass.TabIndex = 5;
            this.OpenClass.Text = "Классы (Отряды)";
            this.OpenClass.UseVisualStyleBackColor = false;
            this.OpenClass.Click += new System.EventHandler(this.OpenClass_Click);
            // 
            // PanelZoo
            // 
            this.PanelZoo.Controls.Add(this.textBox1);
            this.PanelZoo.Controls.Add(this.label11);
            this.PanelZoo.Controls.Add(this.DeleteZoo_But);
            this.PanelZoo.Controls.Add(this.ChangeZoo_But);
            this.PanelZoo.Controls.Add(this.DGVzoo);
            this.PanelZoo.Controls.Add(this.AddZoo_But);
            this.PanelZoo.Location = new System.Drawing.Point(12, 93);
            this.PanelZoo.Name = "PanelZoo";
            this.PanelZoo.Size = new System.Drawing.Size(1130, 546);
            this.PanelZoo.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(511, 371);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 30);
            this.textBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(310, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(189, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "Название зоопарка";
            // 
            // DeleteZoo_But
            // 
            this.DeleteZoo_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteZoo_But.Name = "DeleteZoo_But";
            this.DeleteZoo_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteZoo_But.TabIndex = 3;
            this.DeleteZoo_But.Text = "Удалить";
            this.DeleteZoo_But.UseVisualStyleBackColor = true;
            this.DeleteZoo_But.Click += new System.EventHandler(this.DeleteZoo_But_Click);
            // 
            // ChangeZoo_But
            // 
            this.ChangeZoo_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeZoo_But.Name = "ChangeZoo_But";
            this.ChangeZoo_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeZoo_But.TabIndex = 2;
            this.ChangeZoo_But.Text = "Изменение";
            this.ChangeZoo_But.UseVisualStyleBackColor = true;
            this.ChangeZoo_But.Click += new System.EventHandler(this.ChangeZoo_But_Click);
            // 
            // DGVzoo
            // 
            this.DGVzoo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVzoo.Location = new System.Drawing.Point(20, 20);
            this.DGVzoo.Name = "DGVzoo";
            this.DGVzoo.RowHeadersWidth = 51;
            this.DGVzoo.RowTemplate.Height = 24;
            this.DGVzoo.Size = new System.Drawing.Size(1088, 300);
            this.DGVzoo.TabIndex = 1;
            // 
            // AddZoo_But
            // 
            this.AddZoo_But.Location = new System.Drawing.Point(20, 335);
            this.AddZoo_But.Name = "AddZoo_But";
            this.AddZoo_But.Size = new System.Drawing.Size(284, 73);
            this.AddZoo_But.TabIndex = 0;
            this.AddZoo_But.Text = "Добавить";
            this.AddZoo_But.UseVisualStyleBackColor = true;
            this.AddZoo_But.Click += new System.EventHandler(this.AddZoo_But_Click);
            // 
            // PanelCage
            // 
            this.PanelCage.Controls.Add(this.comboBox1);
            this.PanelCage.Controls.Add(this.label3);
            this.PanelCage.Controls.Add(this.textBox3);
            this.PanelCage.Controls.Add(this.label2);
            this.PanelCage.Controls.Add(this.textBox2);
            this.PanelCage.Controls.Add(this.label1);
            this.PanelCage.Controls.Add(this.DeleteCage_But);
            this.PanelCage.Controls.Add(this.ChangeCage_But);
            this.PanelCage.Controls.Add(this.DGVcage);
            this.PanelCage.Controls.Add(this.AddCage_But);
            this.PanelCage.Location = new System.Drawing.Point(15, 90);
            this.PanelCage.Name = "PanelCage";
            this.PanelCage.Size = new System.Drawing.Size(1130, 546);
            this.PanelCage.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(511, 371);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 30);
            this.textBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(310, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Название клетки";
            // 
            // DeleteCage_But
            // 
            this.DeleteCage_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteCage_But.Name = "DeleteCage_But";
            this.DeleteCage_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteCage_But.TabIndex = 3;
            this.DeleteCage_But.Text = "Удалить";
            this.DeleteCage_But.UseVisualStyleBackColor = true;
            this.DeleteCage_But.Click += new System.EventHandler(this.DeleteCage_But_Click);
            // 
            // ChangeCage_But
            // 
            this.ChangeCage_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeCage_But.Name = "ChangeCage_But";
            this.ChangeCage_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeCage_But.TabIndex = 2;
            this.ChangeCage_But.Text = "Изменение";
            this.ChangeCage_But.UseVisualStyleBackColor = true;
            this.ChangeCage_But.Click += new System.EventHandler(this.ChangeCage_But_Click);
            // 
            // DGVcage
            // 
            this.DGVcage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcage.Location = new System.Drawing.Point(20, 20);
            this.DGVcage.Name = "DGVcage";
            this.DGVcage.RowHeadersWidth = 51;
            this.DGVcage.RowTemplate.Height = 24;
            this.DGVcage.Size = new System.Drawing.Size(1088, 300);
            this.DGVcage.TabIndex = 1;
            // 
            // AddCage_But
            // 
            this.AddCage_But.Location = new System.Drawing.Point(20, 335);
            this.AddCage_But.Name = "AddCage_But";
            this.AddCage_But.Size = new System.Drawing.Size(284, 73);
            this.AddCage_But.TabIndex = 0;
            this.AddCage_But.Text = "Добавить";
            this.AddCage_But.UseVisualStyleBackColor = true;
            this.AddCage_But.Click += new System.EventHandler(this.AddCage_But_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(511, 414);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(307, 30);
            this.textBox3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(310, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Кол-во животинки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(312, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Зоопарк";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(511, 461);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(307, 33);
            this.comboBox1.TabIndex = 14;
            // 
            // PanelAnimal
            // 
            this.PanelAnimal.Controls.Add(this.comboBox3);
            this.PanelAnimal.Controls.Add(this.label7);
            this.PanelAnimal.Controls.Add(this.comboBox2);
            this.PanelAnimal.Controls.Add(this.label4);
            this.PanelAnimal.Controls.Add(this.textBox4);
            this.PanelAnimal.Controls.Add(this.label5);
            this.PanelAnimal.Controls.Add(this.textBox5);
            this.PanelAnimal.Controls.Add(this.label6);
            this.PanelAnimal.Controls.Add(this.DeleteAnimal_But);
            this.PanelAnimal.Controls.Add(this.ChangeAnimal_But);
            this.PanelAnimal.Controls.Add(this.DGVanimal);
            this.PanelAnimal.Controls.Add(this.AddAnimal_But);
            this.PanelAnimal.Location = new System.Drawing.Point(9, 90);
            this.PanelAnimal.Name = "PanelAnimal";
            this.PanelAnimal.Size = new System.Drawing.Size(1130, 546);
            this.PanelAnimal.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(511, 439);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(307, 33);
            this.comboBox2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(410, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Клетка";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(511, 338);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(307, 30);
            this.textBox4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(408, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Годики";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(511, 389);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(307, 30);
            this.textBox5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(408, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Кличка";
            // 
            // DeleteAnimal_But
            // 
            this.DeleteAnimal_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteAnimal_But.Name = "DeleteAnimal_But";
            this.DeleteAnimal_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteAnimal_But.TabIndex = 3;
            this.DeleteAnimal_But.Text = "Удалить";
            this.DeleteAnimal_But.UseVisualStyleBackColor = true;
            this.DeleteAnimal_But.Click += new System.EventHandler(this.DeleteAnimal_But_Click);
            // 
            // ChangeAnimal_But
            // 
            this.ChangeAnimal_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeAnimal_But.Name = "ChangeAnimal_But";
            this.ChangeAnimal_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeAnimal_But.TabIndex = 2;
            this.ChangeAnimal_But.Text = "Изменение";
            this.ChangeAnimal_But.UseVisualStyleBackColor = true;
            this.ChangeAnimal_But.Click += new System.EventHandler(this.ChangeAnimal_But_Click);
            // 
            // DGVanimal
            // 
            this.DGVanimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVanimal.Location = new System.Drawing.Point(20, 20);
            this.DGVanimal.Name = "DGVanimal";
            this.DGVanimal.RowHeadersWidth = 51;
            this.DGVanimal.RowTemplate.Height = 24;
            this.DGVanimal.Size = new System.Drawing.Size(1088, 300);
            this.DGVanimal.TabIndex = 1;
            // 
            // AddAnimal_But
            // 
            this.AddAnimal_But.Location = new System.Drawing.Point(20, 335);
            this.AddAnimal_But.Name = "AddAnimal_But";
            this.AddAnimal_But.Size = new System.Drawing.Size(284, 73);
            this.AddAnimal_But.TabIndex = 0;
            this.AddAnimal_But.Text = "Добавить";
            this.AddAnimal_But.UseVisualStyleBackColor = true;
            this.AddAnimal_But.Click += new System.EventHandler(this.AddAnimal_But_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(512, 486);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(307, 33);
            this.comboBox3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(411, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Класс";
            // 
            // PanelClass
            // 
            this.PanelClass.Controls.Add(this.textBox6);
            this.PanelClass.Controls.Add(this.label12);
            this.PanelClass.Controls.Add(this.DeleteClass_But);
            this.PanelClass.Controls.Add(this.ChangeClass_But);
            this.PanelClass.Controls.Add(this.DGVclass);
            this.PanelClass.Controls.Add(this.AddClass_But);
            this.PanelClass.Location = new System.Drawing.Point(15, 90);
            this.PanelClass.Name = "PanelClass";
            this.PanelClass.Size = new System.Drawing.Size(1130, 546);
            this.PanelClass.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(508, 346);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(307, 30);
            this.textBox6.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(317, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Название класса";
            // 
            // DeleteClass_But
            // 
            this.DeleteClass_But.Location = new System.Drawing.Point(824, 335);
            this.DeleteClass_But.Name = "DeleteClass_But";
            this.DeleteClass_But.Size = new System.Drawing.Size(284, 73);
            this.DeleteClass_But.TabIndex = 3;
            this.DeleteClass_But.Text = "Удалить";
            this.DeleteClass_But.UseVisualStyleBackColor = true;
            this.DeleteClass_But.Click += new System.EventHandler(this.DeleteClass_But_Click);
            // 
            // ChangeClass_But
            // 
            this.ChangeClass_But.Location = new System.Drawing.Point(20, 414);
            this.ChangeClass_But.Name = "ChangeClass_But";
            this.ChangeClass_But.Size = new System.Drawing.Size(284, 73);
            this.ChangeClass_But.TabIndex = 2;
            this.ChangeClass_But.Text = "Изменение";
            this.ChangeClass_But.UseVisualStyleBackColor = true;
            this.ChangeClass_But.Click += new System.EventHandler(this.ChangeClass_But_Click);
            // 
            // DGVclass
            // 
            this.DGVclass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVclass.Location = new System.Drawing.Point(20, 20);
            this.DGVclass.Name = "DGVclass";
            this.DGVclass.RowHeadersWidth = 51;
            this.DGVclass.RowTemplate.Height = 24;
            this.DGVclass.Size = new System.Drawing.Size(1088, 300);
            this.DGVclass.TabIndex = 1;
            // 
            // AddClass_But
            // 
            this.AddClass_But.Location = new System.Drawing.Point(20, 335);
            this.AddClass_But.Name = "AddClass_But";
            this.AddClass_But.Size = new System.Drawing.Size(284, 73);
            this.AddClass_But.TabIndex = 0;
            this.AddClass_But.Text = "Добавить";
            this.AddClass_But.UseVisualStyleBackColor = true;
            this.AddClass_But.Click += new System.EventHandler(this.AddClass_But_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 655);
            this.Controls.Add(this.PanelClass);
            this.Controls.Add(this.PanelAnimal);
            this.Controls.Add(this.PanelCage);
            this.Controls.Add(this.PanelZoo);
            this.Controls.Add(this.OpenClass);
            this.Controls.Add(this.OpenAnimal);
            this.Controls.Add(this.OpenCage);
            this.Controls.Add(this.OpenZoo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная 2";
            this.PanelZoo.ResumeLayout(false);
            this.PanelZoo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVzoo)).EndInit();
            this.PanelCage.ResumeLayout(false);
            this.PanelCage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcage)).EndInit();
            this.PanelAnimal.ResumeLayout(false);
            this.PanelAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVanimal)).EndInit();
            this.PanelClass.ResumeLayout(false);
            this.PanelClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVclass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenZoo;
        private System.Windows.Forms.Button OpenCage;
        private System.Windows.Forms.Button OpenAnimal;
        private System.Windows.Forms.Button OpenClass;
        private System.Windows.Forms.Panel PanelZoo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteZoo_But;
        private System.Windows.Forms.Button ChangeZoo_But;
        private System.Windows.Forms.DataGridView DGVzoo;
        private System.Windows.Forms.Button AddZoo_But;
        private System.Windows.Forms.Panel PanelCage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteCage_But;
        private System.Windows.Forms.Button ChangeCage_But;
        private System.Windows.Forms.DataGridView DGVcage;
        private System.Windows.Forms.Button AddCage_But;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelAnimal;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteAnimal_But;
        private System.Windows.Forms.Button ChangeAnimal_But;
        private System.Windows.Forms.DataGridView DGVanimal;
        private System.Windows.Forms.Button AddAnimal_But;
        private System.Windows.Forms.Panel PanelClass;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeleteClass_But;
        private System.Windows.Forms.Button ChangeClass_But;
        private System.Windows.Forms.DataGridView DGVclass;
        private System.Windows.Forms.Button AddClass_But;
    }
}

