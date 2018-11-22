// C������ ������ ����� � ������ FormForZenno;
System.Windows.Forms.Form FormForZenno = new System.Windows.Forms.Form();

// C������ ��������� TextBox � ������ textBox1;
System.Windows.Forms.TextBox textBox1 = new System.Windows.Forms.TextBox();
// C������ ��������� Label � ������ label1;
System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();
// C������ ��������� CheckBox � ������ checkBox1;
System.Windows.Forms.CheckBox checkBox1 = new System.Windows.Forms.CheckBox();
// C������ ��������� RadioButton � ������ radioButton1;
System.Windows.Forms.RadioButton radioButton1 = new System.Windows.Forms.RadioButton();
// C������ ��������� Button � ������ button1;
System.Windows.Forms.Button button1 = new System.Windows.Forms.Button();
// C������ ��������� Button � ������ button2;
System.Windows.Forms.Button button2 = new System.Windows.Forms.Button();
// C������ ��������� ComboBox � ������ comboBox1;
System.Windows.Forms.ComboBox comboBox1 = new System.Windows.Forms.ComboBox();
// C������ ��������� Button � ������ button3;
System.Windows.Forms.Button button3 = new System.Windows.Forms.Button();
// C������ ��������� Button � ������ button4;
System.Windows.Forms.Button button4 = new System.Windows.Forms.Button();
// C������ ��������� OpenFileDialog � ������ openFileDialog1;
System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
// C������ ��������� SaveFileDialog � ������ saveFileDialog1;
System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
// C������ ��������� NumericUpDown � ������ numericUpDown1;
System.Windows.Forms.NumericUpDown numericUpDown1 = new System.Windows.Forms.NumericUpDown();
textBox1.Location = new System.Drawing.Point(152, 24);
textBox1.Name = "textBox1";
textBox1.Size = new System.Drawing.Size(100, 20);
textBox1.TabIndex = 0;
textBox1.Text = "���� �����";
label1.AutoSize = true;
label1.Location = new System.Drawing.Point(40, 24);
label1.Name = "label1";
label1.Size = new System.Drawing.Size(57, 13);
label1.TabIndex = 1;
label1.Text = "��������";
checkBox1.AutoSize = true;
checkBox1.Location = new System.Drawing.Point(32, 72);
checkBox1.Name = "checkBox1";
checkBox1.Size = new System.Drawing.Size(70, 17);
checkBox1.TabIndex = 2;
checkBox1.Text = "�������";
checkBox1.UseVisualStyleBackColor = true;
radioButton1.AutoSize = true;
radioButton1.Location = new System.Drawing.Point(32, 112);
radioButton1.Name = "radioButton1";
radioButton1.Size = new System.Drawing.Size(85, 17);
radioButton1.TabIndex = 3;
radioButton1.TabStop = true;
radioButton1.Text = "����������";
radioButton1.UseVisualStyleBackColor = true;
button1.Location = new System.Drawing.Point(32, 160);
button1.Name = "button1";
button1.Size = new System.Drawing.Size(99, 23);
button1.TabIndex = 4;
button1.Text = "������ �������";
button1.UseVisualStyleBackColor = true;

// �������� ��� ����� ��� button1 
// ��������� ��������� � ���������� ����������� ������  � ; 

button1.Click+=delegate(object sender, EventArgs e)
        {
            // ��������� ������ ������ ������
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            // �������� ��������� ����
            string filenameOpen = openFileDialog1.FileName;
            // �������� � ���������� ������
            textBox1.Text = filenameOpen;
        };

button2.Location = new System.Drawing.Point(152, 160);
button2.Name = "button2";
button2.Size = new System.Drawing.Size(115, 23);
button2.TabIndex = 5;
button2.Text = "������ ���������";
button2.UseVisualStyleBackColor = true;

// �������� ��� ����� ��� button2 
// ��������� ��������� � ���������� ����������� ������  � ; 

button2.Click+=delegate(object sender, EventArgs e)
        {
            // ��������� ������ ������ ������
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
                return;

            // �������� ��������� ����
            string filenameSave = saveFileDialog1.FileName;

            // ��������� � ����
            System.IO.File.WriteAllText(filenameSave, checkBox1.Text, Encoding.UTF8);
            // �������� � ���������� ������
            textBox1.Text = filenameSave;
        };

comboBox1.FormattingEnabled = true;
comboBox1.Items.AddRange(new object[] {
            "������� 1",
            "������� 2",
            "������� 3"});
comboBox1.Location = new System.Drawing.Point(144, 72);
comboBox1.Name = "comboBox1";
comboBox1.Size = new System.Drawing.Size(121, 21);
comboBox1.TabIndex = 6;
comboBox1.Text = "����� ���������";
button3.Location = new System.Drawing.Point(40, 216);
button3.Name = "button3";
button3.Size = new System.Drawing.Size(75, 23);
button3.TabIndex = 7;
button3.Text = "��";
button3.UseVisualStyleBackColor = true;

// �������� ��� ����� ��� button3 
// ��������� ��������� � ���������� ����������� ������  � ; 

button3.Click+=delegate(object sender, EventArgs e)
        {
            // ��������� ���������� �������� ����� � ����������
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

            // ��������� � ����
            System.IO.File.WriteAllLines(strPathSave, arrData, Encoding.UTF8);

            FormForZenno.Close();
        };

button4.Location = new System.Drawing.Point(176, 216);
button4.Name = "button4";
button4.Size = new System.Drawing.Size(75, 23);
button4.TabIndex = 8;
button4.Text = "������";
button4.UseVisualStyleBackColor = true;

// �������� ��� ����� ��� button4 
// ��������� ��������� � ���������� ����������� ������  � ; 

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
FormForZenno.Text = "����� ��� Zenno";
// ������� ��������� System.ComponentModel.ISupportInitialize
FormForZenno.ResumeLayout(false);
FormForZenno.PerformLayout();

// �������� FormForZenno. � ResumeLayout � PerformLayout ���� ����� ���������

// ��������������� ��������� ����� �� ���������, ���� ��� ������ � �� ����������
// �������� ����� �� ���������
FormForZenno.Text = "�������� �����";
// ���������� ����� �� ���������
FormForZenno.AutoSize =  true;
// �������������� ����� �� ���������
FormForZenno.Location = new System.Drawing.Point(150,300);
// ������ ����� �� ������ ������
FormForZenno.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
// ������ ����� �� ���������
FormForZenno.Size = new System.Drawing.Size(300, 180);


// ���������� ���� ����� 
FormForZenno.ShowDialog();
