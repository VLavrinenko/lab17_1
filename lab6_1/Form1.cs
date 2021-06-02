using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab6_1
{
    public partial class Form1 : Form
    {
        Color color = Color.Red;
        int mode = 1;
        double a = 5, b = 100, c = -0.5, y = 2;

        private void Output_Mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = ((ComboBox)sender).SelectedIndex;
            Draw_Panel.Invalidate();
        }

        public Form1()
        {
            InitializeComponent();
            Output_Mode.SelectedIndex = mode;
            A_TextBox.Text = a.ToString();
            B_TextBox.Text = b.ToString();
            C_TextBox.Text = c.ToString();
            Y_TextBox.Text = y.ToString();
        }

        private void Draw_Panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(color, 2);
            int Zero_X_Point = Draw_Panel.Width / 2;
            int Zero_Y_Point = Draw_Panel.Height / 2;
            float x1 = 0, y1 = 0 + Zero_Y_Point;
            switch (Output_Mode.SelectedIndex)
            {
                case 1://drawline
                    {
                        try
                        {
                            for (double i = x1+1; i < Zero_X_Point; i += 3) // почему +3 я сам не понимаю, наверно связано с синусом 
                            {
                                PointF point1 = new PointF(x1 + Zero_X_Point, y1);
                                PointF point2 = new PointF(Convert.ToSingle(i)+ Zero_X_Point, Convert.ToSingle(MyFunc(i) + Zero_Y_Point));
                                x1 = Convert.ToSingle(i);
                                y1 = Convert.ToSingle(MyFunc(i) + Zero_Y_Point);
                                e.Graphics.DrawLine(pen, point1, point2);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Значения функции больше 1E+-12, функция будет отрисована не полностью!", "Error!");
                        } //я протестил, ошибок нет ))))))))
                        break;
                    }
                case 0://drawellips
                    {

                        try
                        {
                            for (double i = 1; i < Zero_X_Point; i += 3) // почему +3 я сам не понимаю, наверно связано с синусом
                            {
                                Rectangle dot = new Rectangle(Convert.ToInt32(i+ Zero_X_Point), Convert.ToInt32(MyFunc(i) + Zero_Y_Point), 2, 2);
                                e.Graphics.DrawEllipse(pen, dot);
                            }
                        }

                        catch
                        {
                            MessageBox.Show("Значения функции больше 1E+-12, функция будет отрисована не полностью!", "Error!");
                        } //я протестил, ошибок нет ))))))))
                        break;
                    }
                case 2://bitmap
                    {
                        Bitmap Function = new Bitmap(Draw_Panel.Width, Draw_Panel.Height);
                        try
                        {
                            for (double i = 0; i < Zero_X_Point - 1; i += 3) // почему +3 я сам не понимаю, наверно связано с синусом
                            {
                                Function.SetPixel(Convert.ToInt32(i + Zero_X_Point), Convert.ToInt32(MyFunc(i) + Zero_Y_Point), color);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Overflow.", "ERROR");
                        }

                        e.Graphics.DrawImageUnscaled(Function, Point.Empty);
                        break;
                    }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button_ReDraw_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(A_TextBox.Text);
            b = Convert.ToDouble(B_TextBox.Text);
            y = Convert.ToDouble(Y_TextBox.Text);
            c = Convert.ToDouble(C_TextBox.Text);
            Draw_Panel.Invalidate();
        }

        private void Button_Choose_Color_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = color;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                color = dialog.Color;
                Draw_Panel.Invalidate();
            }
        }
        private double MyFunc(double x)
        {
            if (Function1_Radio_Button.Checked)
            {
                return a * Math.Pow(x, -c) * Math.Sin(y * x + b);
            }
            else if (Function2_Radio_Button.Checked)
            {
                return (-a * Math.Sqrt(x) + b * y + Math.Cos(x) * Math.Sin(c));
            }
            else if (Function3_Radio_Button.Checked)
            {
                return (Math.Pow(a, 2) * x + (b - a) * y + Math.Sin(c));
            }
            else return 0;
        }
    }
}
