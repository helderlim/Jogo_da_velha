using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class Form1 : Form
    {
        int jogador = 1, jogadas = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //bloqueia os botões ao final da partida 
        private void para()
        {
            // trava todos os botões 
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            //seleciona qual jogador ganho na vez
            if (jogador == 1)
            {
                mensagem.Text = "Jogador O venceu PARABENS!!!!";
                retorno.Enabled = true;
               
            }
            else
            {
                mensagem.Text = "jogador X venceu PARABENS !!!";
                retorno.Enabled = true;
            }
            //reseta o contator para dar velha 
            jogadas = 0;
        }
        //filtra as possibilidades de ganhos na partida 
        private void vencedor()
        {
            

            if (btn2.Text == btn1.Text && btn3.Text == btn1.Text && btn1.Text != "")
            {
                
                para();
               
            }
            else if (btn5.Text == btn4.Text && btn6.Text == btn4.Text && btn4.Text != "")
            {
                para();
              
            }
            else if (btn8.Text == btn7.Text && btn7.Text == btn9.Text && btn7.Text != "")
            {
                para();
                
            }
            else if (btn5.Text == btn1.Text && btn1.Text == btn9.Text && btn1.Text != "")
            {
                para();
            }
            else if (btn5.Text == btn3.Text && btn7.Text == btn3.Text && btn3.Text != "")
            {
                para();
            }
            else if (btn4.Text == btn1.Text && btn1.Text == btn7.Text && btn1.Text != "")
            {
                para();
            } else if (btn5.Text == btn2.Text && btn2.Text == btn8.Text && btn2.Text != "")
            {
                para();
            } else if (btn6.Text == btn3.Text && btn3.Text == btn9.Text && btn3.Text != "")
            {
                para();
            }
            //quando der velha 
            else if (jogadas == 9)
            {
                mensagem.Text = "deu velha !!";
                retorno.Enabled = true;
                btn1.Enabled = false;
                btn2.Enabled = false;
                btn3.Enabled = false;
                btn4.Enabled = false;
                btn5.Enabled = false;
                btn6.Enabled = false;
                btn7.Enabled = false;
                btn8.Enabled = false;
                btn9.Enabled = false;
                jogadas = 0;
            }
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                if (jogador == 1)
                {
                   
                    btn2.Text = "X";
                    vez.Text = "vez do joador O";
                }
                else
                {
                    btn2.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
                
                jogador = jogador * -1;
                vencedor();

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                if (jogador == 1)
                {
                    btn3.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn3.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
                
                jogador = jogador * -1;
                vencedor();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                if (jogador == 1)
                {
                    btn4.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn4.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
                
                jogador = jogador * -1;
                vencedor();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                if (jogador == 1)
                {
                    btn5.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn5.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
                
                jogador = jogador * -1;
                vencedor();

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                if (jogador == 1)
                {
                    btn6.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn6.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
      
                jogador = jogador * -1;
                vencedor();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                if (jogador == 1)
                {
                    btn7.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn7.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
              
                jogador = jogador * -1;
                vencedor();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                if (jogador == 1)
                {
                    btn8.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn8.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
            
                jogador = jogador * -1;
                vencedor();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                if (jogador == 1)
                {
                    btn9.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn9.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
      
                jogador = jogador * -1;
                vencedor();
            }
        }
        //botão de reset onde habilita novamente todos os botões inclusive os texts 
        private void retorno_Click(object sender, EventArgs e)
        {
            retorno.Enabled = false;
            
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            mensagem.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                if (jogador == 1)
                {
                    btn1.Text = "X";
                    vez.Text = "vez do jogador O";
                }
                else
                {
                    btn1.Text = "O";
                    vez.Text = "vez do jogador X";
                }
                jogadas++;
  
                jogador = jogador * -1;
                vencedor();
            }
        }
    }
}
