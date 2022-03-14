using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaDeDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public static int x = 0; (assim atribuimos uma variável global, serve tanto para esse form e tanto para outro)
        //Form1.x = 20; (desta maneira declaramos um valor a uma variável global fora de seu form)

        Substituir frm = new Substituir();
        public static string o = "";
        public static string o2 = "";

        private void button3_Click(object sender, EventArgs e)
        {
            //cor
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //substituir
            frm.ShowDialog(); //assim abrimos um outro form ao clicar nesse botão, além de não deixar sair dele

                richTextBox1.Text = richTextBox1.Text.Replace(o, o2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abrir
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //salvar
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //fonte
            Color aux = richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = aux;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
