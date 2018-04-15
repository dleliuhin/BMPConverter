using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BMPConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(@"D:\2 курс\4 семестр\ЭВМ\CourseWorkEVM\StartPhoto1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Загрузка формы
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  Имя файла
        } 

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Область для загрузки фото
            //По умолчанию стоит фотография "Нет фото"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.Text = ofd.FileName;
                    textBox1.Text = ofd.SafeFileName;
                    pictureBox1.Image = new Bitmap(@ofd.FileName);
                    pictureBox1.ImageLocation = ofd.FileName;   
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Текстовое окно, выводящее полный путь к файлу и полное его имя
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if(checkBox1.CheckState == CheckState.Checked)
                {
                    pictureBox1.Image.Save(Path.ChangeExtension(ofd.FileName,".Png"), System.Drawing.Imaging.ImageFormat.Png);
                }
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    pictureBox1.Image.Save(Path.ChangeExtension(ofd.FileName, ".Gif"), System.Drawing.Imaging.ImageFormat.Gif);
                }
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    pictureBox1.Image.Save(Path.ChangeExtension(ofd.FileName, ".Jpeg"), System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (checkBox4.CheckState == CheckState.Checked)
                {
                    pictureBox1.Image.Save(Path.ChangeExtension(ofd.FileName, ".Tiff"), System.Drawing.Imaging.ImageFormat.Tiff);
                }
                if (checkBox5.CheckState == CheckState.Checked)
                {
                    pictureBox1.Image.Save(Path.ChangeExtension(ofd.FileName, ".Icon"), System.Drawing.Imaging.ImageFormat.Icon);
                }
                 
                else if((checkBox1.CheckState==CheckState.Unchecked) 
                    && (checkBox2.CheckState==CheckState.Unchecked) 
                    && (checkBox3.CheckState==CheckState.Unchecked) 
                    && (checkBox4.CheckState==CheckState.Unchecked) 
                    && (checkBox5.CheckState==CheckState.Unchecked) )
                {
                    MessageBox.Show("Change format picture", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ChekBox - при указании конвертируется в Png
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //ChekBox - при указании конвертируется в Gif
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //ChekBox - при указании конвертируется в Jpeg
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Текстовое окно, выводящее имя файла с форматом
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Текст: "Путь к файлу"
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            pictureBox1.Image = new Bitmap(@"D:\2 курс\4 семестр\ЭВМ\CourseWorkEVM\StartPhoto1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            textBox1.Text = null;
            richTextBox1.Text = null;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //ChekBox - при указании конвертируется в Tiff
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //ChekBox - при указании конвертируется в Icon
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
