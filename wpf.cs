// Cоздаем пустую форму с именем FormForZenno;
System.Windows.Forms.Form FormForZenno = new System.Windows.Forms.Form();

// Cоздаем компонент TextBox с именем textBox1;
System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
// Cоздаем компонент Label с именем label1;
System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
// Cоздаем компонент CheckBox с именем checkBox1;
System.Windows.Forms.CheckBox checkBox1 = new System.Windows.Forms.CheckBox();
// Cоздаем компонент RadioButton с именем radioButton1;
System.Windows.Forms.RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
// Cоздаем компонент Button с именем button1;
System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
// Cоздаем компонент Button с именем button2;
System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
// Cоздаем компонент ComboBox с именем comboBox1;
System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
// Cоздаем компонент Button с именем button3;
System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
// Cоздаем компонент Button с именем button4;
System.Windows.Forms.Button button4 = new System.Windows.Forms.Button();
// Cоздаем компонент OpenFileDialog с именем openFileDialog1;
System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
// Cоздаем компонент SaveFileDialog с именем saveFileDialog1;
System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
// Cоздаем компонент NumericUpDown с именем numericUpDown1;
System.Windows.Forms.NumericUpDown numericUpDown1 = new System.Windows.Forms.NumericUpDown();
textBox1.Location = new System.Drawing.Point(152, 24);
textBox1.Name = "textBox1";
textBox1.Size = new System.Drawing.Size(100, 20);
textBox1.TabIndex = 0;
textBox1.Text = "Поле ввода";
label1.AutoSize = true;
label1.Location = new System.Drawing.Point(40, 24);
label1.Name = "label1";
label1.Size = new System.Drawing.Size(57, 13);
label1.TabIndex = 1;
label1.Text = "Название";
checkBox1.AutoSize = true;
checkBox1.Location = new System.Drawing.Point(32, 72);
checkBox1.Name = "checkBox1";
checkBox1.Size = new System.Drawing.Size(70, 17);
checkBox1.TabIndex = 2;
checkBox1.Text = "Чекбокс";
checkBox1.UseVisualStyleBackColor = true;
radioButton1.AutoSize = true;
radioButton1.Location = new System.Drawing.Point(32, 112);
radioButton1.Name = "radioButton1";
radioButton1.Size = new System.Drawing.Size(85, 17);
radioButton1.TabIndex = 3;
radioButton1.TabStop = true;
radioButton1.Text = "Радиобатон";
radioButton1.UseVisualStyleBackColor = true;
button1.Location = new System.Drawing.Point(32, 160);
button1.Name = "button1";
button1.Size = new System.Drawing.Size(99, 23);
button1.TabIndex = 4;
button1.Text = "Кнопка Открыть";
button1.UseVisualStyleBackColor = true;

// Действие при клике для button1 
// Проверьте синтаксис и количество закрывающих скобок  и ; 

button1.Click+=delegate(object sender, EventArgs e)
        {
            // Открываем диалог выбора файлов
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filenameOpen = openFileDialog1.FileName;
            // Работаем с полученным файлом
            textBox1.Text = filenameOpen;
        };

button2.Location = new System.Drawing.Point(152, 160);
button2.Name = "button2";
button2.Size = new System.Drawing.Size(115, 23);
button2.TabIndex = 5;
button2.Text = "Кнопка Сохранить";
button2.UseVisualStyleBackColor = true;

// Действие при клике для button2 
// Проверьте синтаксис и количество закрывающих скобок  и ; 

button2.Click+=delegate(object sender, EventArgs e)
        {
            // Открываем диалог выбора файлов
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            // получаем выбранный файл
            string filenameSave = saveFileDialog1.FileName;

            // Сохраняем в файл
            System.IO.File.WriteAllText(filenameSave, checkBox1.Text, Encoding.UTF8);
            // Работаем с полученным файлом
            textBox1.Text = filenameSave;
        };

comboBox1.FormattingEnabled = true;
comboBox1.Items.AddRange(new object[] {
            "Вариант 1",
            "Вариант 2",
            "Вариант 3"});
comboBox1.Location = new System.Drawing.Point(144, 72);
comboBox1.Name = "comboBox1";
comboBox1.Size = new System.Drawing.Size(121, 21);
comboBox1.TabIndex = 6;
comboBox1.Text = "Выбор вариантов";
button3.Location = new System.Drawing.Point(40, 216);
button3.Name = "button3";
button3.Size = new System.Drawing.Size(75, 23);
button3.TabIndex = 7;
button3.Text = "ОК";
button3.UseVisualStyleBackColor = true;

// Действие при клике для button3 
// Проверьте синтаксис и количество закрывающих скобок  и ; 

button3.Click+=delegate(object sender, EventArgs e)
        {
            // Прописать сохранение значений полей в переменные
            string strPathSave = textBox1.Text;
            string strCheckBox = checkBox1.Checked.ToString();
            string strRadioButton = radioButton1.Checked.ToString();
            string strComboBox = comboBox1.Text;
            int intCountAdvert = (int)numericUpDown1.Value;
			project.Variables["zero"].Value = strPathSave;
            string[] arrData =
                {
                    strPathSave,
                    strCheckBox,
                    strRadioButton,
                    strComboBox,
                    intCountAdvert.ToString()
                };

            // Сохраняем в файл
            System.IO.File.WriteAllLines(strPathSave, arrData, Encoding.UTF8);

            FormForZenno.Close();
        };

button4.Location = new System.Drawing.Point(176, 216);
button4.Name = "button4";
button4.Size = new System.Drawing.Size(75, 23);
button4.TabIndex = 8;
button4.Text = "Отмена";
button4.UseVisualStyleBackColor = true;

// Действие при клике для button4 
// Проверьте синтаксис и количество закрывающих скобок  и ; 

button4.Click+=delegate(object sender, EventArgs e)
        {
            FormForZenno.Close();
		};

numericUpDown1.Location = new System.Drawing.Point(224, 112);
numericUpDown1.Name = "numericUpDown1";
numericUpDown1.Size = new System.Drawing.Size(40, 20);
numericUpDown1.TabIndex = 9;
FormForZenno.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
FormForZenno.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
FormForZenno.ClientSize = new System.Drawing.Size(284, 262);
FormForZenno.Controls.Add(numericUpDown1);
FormForZenno.Controls.Add(button4);
FormForZenno.Controls.Add(button3);
FormForZenno.Controls.Add(comboBox1);
FormForZenno.Controls.Add(button2);
FormForZenno.Controls.Add(button1);
FormForZenno.Controls.Add(radioButton1);
FormForZenno.Controls.Add(checkBox1);
FormForZenno.Controls.Add(label1);
FormForZenno.Controls.Add(textBox1);
FormForZenno.Name = "FormForZenno";
FormForZenno.Text = "Форма для Zenno";
// Пропуск параметра System.ComponentModel.ISupportInitialize
FormForZenno.ResumeLayout(false);
FormForZenno.PerformLayout();

// Добавьте FormForZenno. к ResumeLayout и PerformLayout выше этого сообщения

// Закомментируйте параметры формы по умолчанию, если они заданы в ее настройках
// Название формы по умолчанию
FormForZenno.Text = "Название Формы";
// АвтоРазмер формы по умолчанию
FormForZenno.AutoSize =  true;
// Местоположение формы по умолчанию
FormForZenno.Location = new System.Drawing.Point(150,300);
// Запуск формы по центру экрана
FormForZenno.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
// Размер формы по умолчанию
FormForZenno.Size = new System.Drawing.Size(300, 180);


// Показываем нашу форму 
FormForZenno.ShowDialog();
