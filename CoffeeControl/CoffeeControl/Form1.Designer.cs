namespace CoffeeControl
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ShopsBox = new System.Windows.Forms.ComboBox();
            this.WorkerBox = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dealButton = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.sysMsgTextBox = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.PanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.button14 = new System.Windows.Forms.Button();
            this.positionsList = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelMaterials = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShopsBox
            // 
            this.ShopsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ShopsBox.FormattingEnabled = true;
            this.ShopsBox.Location = new System.Drawing.Point(12, 15);
            this.ShopsBox.Name = "ShopsBox";
            this.ShopsBox.Size = new System.Drawing.Size(160, 26);
            this.ShopsBox.TabIndex = 0;
            this.ShopsBox.Text = "Кофейня";
            this.ShopsBox.SelectedIndexChanged += new System.EventHandler(this.ShopsBox_SelectedIndexChanged);
            // 
            // WorkerBox
            // 
            this.WorkerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.WorkerBox.FormattingEnabled = true;
            this.WorkerBox.Location = new System.Drawing.Point(187, 15);
            this.WorkerBox.Name = "WorkerBox";
            this.WorkerBox.Size = new System.Drawing.Size(160, 26);
            this.WorkerBox.TabIndex = 1;
            this.WorkerBox.Text = "Работник";
            this.WorkerBox.SelectedIndexChanged += new System.EventHandler(this.WorkerBox_SelectedIndexChanged);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1202, 577);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 521;
            this.lineShape1.X2 = 521;
            this.lineShape1.Y1 = 8;
            this.lineShape1.Y2 = 550;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(12, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-107, -102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(100, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оприходование расходных материалов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(816, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Продажи";
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(776, 528);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(135, 23);
            this.dealButton.TabIndex = 10;
            this.dealButton.Text = "Продать";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(816, 391);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 24);
            this.label24.TabIndex = 11;
            this.label24.Text = "Текущий чек";
            // 
            // sysMsgTextBox
            // 
            this.sysMsgTextBox.BackColor = System.Drawing.Color.Azure;
            this.sysMsgTextBox.Location = new System.Drawing.Point(12, 480);
            this.sysMsgTextBox.Multiline = true;
            this.sysMsgTextBox.Name = "sysMsgTextBox";
            this.sysMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sysMsgTextBox.Size = new System.Drawing.Size(496, 71);
            this.sysMsgTextBox.TabIndex = 12;
            this.sysMsgTextBox.TextChanged += new System.EventHandler(this.sysMsgTextBox_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(29, 430);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(176, 22);
            this.label25.TabIndex = 13;
            this.label25.Text = "Системные сообщения";
            // 
            // PanelProducts
            // 
            this.PanelProducts.AutoScroll = true;
            this.PanelProducts.BackColor = System.Drawing.Color.Tan;
            this.PanelProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelProducts.Location = new System.Drawing.Point(541, 54);
            this.PanelProducts.Name = "PanelProducts";
            this.PanelProducts.Size = new System.Drawing.Size(638, 317);
            this.PanelProducts.TabIndex = 69;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.Menu;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button14.Location = new System.Drawing.Point(211, 102);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(64, 32);
            this.button14.TabIndex = 70;
            this.button14.Text = "Стоп";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // positionsList
            // 
            this.positionsList.BackColor = System.Drawing.Color.Azure;
            this.positionsList.FormattingEnabled = true;
            this.positionsList.Location = new System.Drawing.Point(541, 440);
            this.positionsList.Name = "positionsList";
            this.positionsList.Size = new System.Drawing.Size(638, 82);
            this.positionsList.TabIndex = 72;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelMaterials
            // 
            this.PanelMaterials.BackColor = System.Drawing.Color.Tan;
            this.PanelMaterials.Location = new System.Drawing.Point(13, 196);
            this.PanelMaterials.Name = "PanelMaterials";
            this.PanelMaterials.Size = new System.Drawing.Size(495, 175);
            this.PanelMaterials.TabIndex = 73;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(929, 528);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Отмена покупки";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 74;
            this.button3.Text = "Синхронизировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1202, 577);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.PanelMaterials);
            this.Controls.Add(this.positionsList);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.PanelProducts);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.sysMsgTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dealButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WorkerBox);
            this.Controls.Add(this.ShopsBox);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "CoffeeControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ShopsBox;
        private System.Windows.Forms.ComboBox WorkerBox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox sysMsgTextBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.FlowLayoutPanel PanelProducts;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.ListBox positionsList;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel PanelMaterials;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button button3;
    }
}

