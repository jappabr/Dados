using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variaveis globais
        Random rnd = new Random(); //instancia de classe Random (objeto)
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int soma = 0; // Variavel usada para soma
            button7.Enabled = false; //impede repetição do botão
            int n = rnd.Next(1, 7);
            n = rnd.Next(1, 7); //Gera um numero ao acaso entre 1 e 6
            soma += n; // "formula" para calculo dos dados, repetida por todos os botões
            Btn1.Text = n.ToString();
            pictureBox1.Load("dado" + n + ".png"); //Usado este formato para a pesquisa da imagem.
            n = rnd.Next(1, 7); //Gera um numero ao acaso entre 1 e 6
            soma += n;
            Btn2.Text = n.ToString();
            pictureBox2.Load("dado" + n + ".png");
            n = rnd.Next(1, 7);
            soma += n;
            Btn3.Text = n.ToString();
            pictureBox3.Load("dado" + n + ".png");
            n = rnd.Next(1, 7); 
            soma += n;
            Btn4.Text = n.ToString();
            pictureBox4.Load("dado" + n + ".png");
            n = rnd.Next(1, 7); 
            soma += n;
            button5.Text = n.ToString();
            pictureBox5.Load("dado" + n + ".png");
            n = rnd.Next(1, 7); 
            soma += n;
            button6.Text = n.ToString();
            pictureBox6.Load("dado" + n + ".png");
            label1.Text = ("A soma dos seus dados é igual a: " + soma);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            string reset = "-";
            button7.Enabled = true;
            label1.Text = ("Jogo reiniciado, inicie um novo.");
            pictureBox1.Load("dado0.png");
            pictureBox2.Load("dado0.png");
            pictureBox3.Load("dado0.png");
            pictureBox4.Load("dado0.png");
            pictureBox5.Load("dado0.png");
            pictureBox6.Load("dado0.png");
            Btn1.Text = reset;
            Btn2.Text = reset;
            Btn3.Text = reset;
            Btn4.Text = reset; 
            button5.Text = reset; 
            button6.Text = reset;
            
        }
    }
}
