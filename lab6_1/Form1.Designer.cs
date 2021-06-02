
namespace lab6_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Y_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.A_TextBox = new System.Windows.Forms.TextBox();
            this.C_TextBox = new System.Windows.Forms.TextBox();
            this.A_label = new System.Windows.Forms.Label();
            this.C_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.Parameters = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_TextBox = new System.Windows.Forms.TextBox();
            this.B_label = new System.Windows.Forms.Label();
            this.Button_ReDraw = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Function3_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Function2_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Function1_Radio_Button = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Choose_Color = new System.Windows.Forms.Button();
            this.Output_Mode = new System.Windows.Forms.ComboBox();
            this.Graph_Color_Label = new System.Windows.Forms.Label();
            this.Draw_Panel = new System.Windows.Forms.Panel();
            this.Output_Mode_Label = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Y_TextBox
            // 
            this.Y_TextBox.Location = new System.Drawing.Point(518, 196);
            this.Y_TextBox.Name = "Y_TextBox";
            this.Y_TextBox.Size = new System.Drawing.Size(125, 27);
            this.Y_TextBox.TabIndex = 0;
            // 
            // A_TextBox
            // 
            this.A_TextBox.Location = new System.Drawing.Point(518, 52);
            this.A_TextBox.Name = "A_TextBox";
            this.A_TextBox.Size = new System.Drawing.Size(125, 27);
            this.A_TextBox.TabIndex = 1;
            // 
            // C_TextBox
            // 
            this.C_TextBox.Location = new System.Drawing.Point(518, 147);
            this.C_TextBox.Name = "C_TextBox";
            this.C_TextBox.Size = new System.Drawing.Size(125, 27);
            this.C_TextBox.TabIndex = 2;
            // 
            // A_label
            // 
            this.A_label.AutoSize = true;
            this.A_label.Location = new System.Drawing.Point(495, 55);
            this.A_label.Name = "A_label";
            this.A_label.Size = new System.Drawing.Size(17, 20);
            this.A_label.TabIndex = 4;
            this.A_label.Text = "a";
            // 
            // C_label
            // 
            this.C_label.AutoSize = true;
            this.C_label.Location = new System.Drawing.Point(495, 150);
            this.C_label.Name = "C_label";
            this.C_label.Size = new System.Drawing.Size(16, 20);
            this.C_label.TabIndex = 5;
            this.C_label.Text = "c";
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.Location = new System.Drawing.Point(496, 199);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(16, 20);
            this.Y_label.TabIndex = 6;
            this.Y_label.Text = "y";
            // 
            // Parameters
            // 
            this.Parameters.AutoSize = true;
            this.Parameters.Location = new System.Drawing.Point(495, 23);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(93, 20);
            this.Parameters.TabIndex = 9;
            this.Parameters.Text = "Параметры:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.B_TextBox);
            this.groupBox1.Controls.Add(this.B_label);
            this.groupBox1.Controls.Add(this.Button_ReDraw);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Button_Choose_Color);
            this.groupBox1.Controls.Add(this.Output_Mode);
            this.groupBox1.Controls.Add(this.Graph_Color_Label);
            this.groupBox1.Controls.Add(this.Draw_Panel);
            this.groupBox1.Controls.Add(this.Parameters);
            this.groupBox1.Controls.Add(this.Output_Mode_Label);
            this.groupBox1.Controls.Add(this.Y_label);
            this.groupBox1.Controls.Add(this.C_label);
            this.groupBox1.Controls.Add(this.A_label);
            this.groupBox1.Controls.Add(this.C_TextBox);
            this.groupBox1.Controls.Add(this.A_TextBox);
            this.groupBox1.Controls.Add(this.Y_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(857, 769);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "График функции";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // B_TextBox
            // 
            this.B_TextBox.Location = new System.Drawing.Point(518, 101);
            this.B_TextBox.Name = "B_TextBox";
            this.B_TextBox.Size = new System.Drawing.Size(125, 27);
            this.B_TextBox.TabIndex = 11;
            // 
            // B_label
            // 
            this.B_label.AutoSize = true;
            this.B_label.Location = new System.Drawing.Point(494, 104);
            this.B_label.Name = "B_label";
            this.B_label.Size = new System.Drawing.Size(18, 20);
            this.B_label.TabIndex = 12;
            this.B_label.Text = "b";
            // 
            // Button_ReDraw
            // 
            this.Button_ReDraw.Location = new System.Drawing.Point(662, 147);
            this.Button_ReDraw.Name = "Button_ReDraw";
            this.Button_ReDraw.Size = new System.Drawing.Size(181, 76);
            this.Button_ReDraw.TabIndex = 10;
            this.Button_ReDraw.Text = "Перерисовать";
            this.Button_ReDraw.UseVisualStyleBackColor = true;
            this.Button_ReDraw.Click += new System.EventHandler(this.Button_ReDraw_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Function3_Radio_Button);
            this.groupBox2.Controls.Add(this.Function2_Radio_Button);
            this.groupBox2.Controls.Add(this.Function1_Radio_Button);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(19, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 217);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите функцию";
            // 
            // Function3_Radio_Button
            // 
            this.Function3_Radio_Button.AutoSize = true;
            this.Function3_Radio_Button.Location = new System.Drawing.Point(6, 164);
            this.Function3_Radio_Button.Name = "Function3_Radio_Button";
            this.Function3_Radio_Button.Size = new System.Drawing.Size(102, 24);
            this.Function3_Radio_Button.TabIndex = 5;
            this.Function3_Radio_Button.Text = "Функция 3";
            this.Function3_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Function2_Radio_Button
            // 
            this.Function2_Radio_Button.AutoSize = true;
            this.Function2_Radio_Button.Location = new System.Drawing.Point(6, 101);
            this.Function2_Radio_Button.Name = "Function2_Radio_Button";
            this.Function2_Radio_Button.Size = new System.Drawing.Size(102, 24);
            this.Function2_Radio_Button.TabIndex = 4;
            this.Function2_Radio_Button.Text = "Функция 2";
            this.Function2_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Function1_Radio_Button
            // 
            this.Function1_Radio_Button.AutoSize = true;
            this.Function1_Radio_Button.Checked = true;
            this.Function1_Radio_Button.Location = new System.Drawing.Point(6, 38);
            this.Function1_Radio_Button.Name = "Function1_Radio_Button";
            this.Function1_Radio_Button.Size = new System.Drawing.Size(102, 24);
            this.Function1_Radio_Button.TabIndex = 3;
            this.Function1_Radio_Button.TabStop = true;
            this.Function1_Radio_Button.Text = "Функция 1";
            this.Function1_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 150);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 51);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(340, 57);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Choose_Color
            // 
            this.Button_Choose_Color.Location = new System.Drawing.Point(771, 101);
            this.Button_Choose_Color.Name = "Button_Choose_Color";
            this.Button_Choose_Color.Size = new System.Drawing.Size(72, 27);
            this.Button_Choose_Color.TabIndex = 14;
            this.Button_Choose_Color.Text = "...";
            this.Button_Choose_Color.UseVisualStyleBackColor = true;
            this.Button_Choose_Color.Click += new System.EventHandler(this.Button_Choose_Color_Click);
            // 
            // Output_Mode
            // 
            this.Output_Mode.FormattingEnabled = true;
            this.Output_Mode.Items.AddRange(new object[] {
            "Точки",
            "Линия",
            "Bitmap(Experimental)"});
            this.Output_Mode.Location = new System.Drawing.Point(662, 52);
            this.Output_Mode.Name = "Output_Mode";
            this.Output_Mode.Size = new System.Drawing.Size(181, 28);
            this.Output_Mode.TabIndex = 15;
            this.Output_Mode.SelectedIndexChanged += new System.EventHandler(this.Output_Mode_SelectedIndexChanged);
            // 
            // Graph_Color_Label
            // 
            this.Graph_Color_Label.AutoSize = true;
            this.Graph_Color_Label.Location = new System.Drawing.Point(662, 104);
            this.Graph_Color_Label.Name = "Graph_Color_Label";
            this.Graph_Color_Label.Size = new System.Drawing.Size(103, 20);
            this.Graph_Color_Label.TabIndex = 11;
            this.Graph_Color_Label.Text = "Цвет графика";
            // 
            // Draw_Panel
            // 
            this.Draw_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Draw_Panel.Location = new System.Drawing.Point(6, 256);
            this.Draw_Panel.Name = "Draw_Panel";
            this.Draw_Panel.Size = new System.Drawing.Size(845, 507);
            this.Draw_Panel.TabIndex = 13;
            this.Draw_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw_Panel_Paint);
            // 
            // Output_Mode_Label
            // 
            this.Output_Mode_Label.AutoSize = true;
            this.Output_Mode_Label.Location = new System.Drawing.Point(662, 23);
            this.Output_Mode_Label.Name = "Output_Mode_Label";
            this.Output_Mode_Label.Size = new System.Drawing.Size(112, 20);
            this.Output_Mode_Label.TabIndex = 12;
            this.Output_Mode_Label.Text = "Режим вывода";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "equation.png");
            this.imageList1.Images.SetKeyName(1, "equation2.png");
            this.imageList1.Images.SetKeyName(2, "equation3.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 793);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Y_TextBox;
        private System.Windows.Forms.TextBox A_TextBox;
        private System.Windows.Forms.TextBox C_TextBox;
        private System.Windows.Forms.Label A_label;
        private System.Windows.Forms.Label C_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.Label Parameters;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Output_Mode;
        private System.Windows.Forms.Button Button_Choose_Color;
        private System.Windows.Forms.Panel Draw_Panel;
        private System.Windows.Forms.Label Output_Mode_Label;
        private System.Windows.Forms.Label Graph_Color_Label;
        private System.Windows.Forms.Button Button_ReDraw;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Function3_Radio_Button;
        private System.Windows.Forms.RadioButton Function2_Radio_Button;
        private System.Windows.Forms.RadioButton Function1_Radio_Button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox B_TextBox;
        private System.Windows.Forms.Label B_label;
    }
}

