using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace jogoMemoria
{
    public partial class Form1 : Form
    {
        //é necessário a criação da base de dados 'ranking'
        //tabela 'rank'
        //colunas 'nome' e 'tempo'

        int[,] blocos;
        Random rand = new Random();
        int click;
        int m, n;
        int x, y;
        int cron;
        int fim;
        int render;
        Button btn1, btn2;

        private void novo()
        {
            int elem = 0;
            blocos = new int[4, 5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    blocos[i,j] = (elem++)/2;
                } 
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int m = rand.Next(0, 4);
                    int n = rand.Next(0, 5);

                    int tmp = blocos[i, j];
                    blocos[i, j] = blocos[m, n];
                    blocos[m, n] = tmp;
                }
            }

            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";            
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";           
            button16.Text = "";
            button17.Text = "";
            button18.Text = "";
            button19.Text = "";           
            button23.Text = "";
            button24.Text = "";
            button25.Text = "";
            button26.Text = "";           
            button30.Text = "";
            button31.Text = "";
            button32.Text = "";
            button33.Text = "";

            button2.BackColor = Color.DarkMagenta;
            button3.BackColor = Color.DarkMagenta;
            button4.BackColor = Color.DarkMagenta;
            button5.BackColor = Color.DarkMagenta;
            button9.BackColor = Color.DarkMagenta;
            button10.BackColor = Color.DarkMagenta;
            button11.BackColor = Color.DarkMagenta;
            button12.BackColor = Color.DarkMagenta;
            button16.BackColor = Color.DarkMagenta;
            button17.BackColor = Color.DarkMagenta;
            button18.BackColor = Color.DarkMagenta;
            button19.BackColor = Color.DarkMagenta;
            button23.BackColor = Color.DarkMagenta;
            button24.BackColor = Color.DarkMagenta;
            button25.BackColor = Color.DarkMagenta;
            button26.BackColor = Color.DarkMagenta;
            button30.BackColor = Color.DarkMagenta;
            button31.BackColor = Color.DarkMagenta;
            button32.BackColor = Color.DarkMagenta;
            button33.BackColor = Color.DarkMagenta;

            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();           
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();            
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();            
            button23.Show();
            button24.Show();
            button25.Show();
            button26.Show();           
            button30.Show();
            button31.Show();
            button32.Show();
            button33.Show();

            click = 0;
            timer1.Stop();
            timer2.Stop();
            label1.Text = "0:00.0";
            fim = 0;
            render = 0;            
        }

        private void renderiza(Button btn, int i, int j)
        {
            int valor = blocos[i, j];
            render = valor;

            switch (render)
            {
                case 0: btn.BackColor = Color.Blue;
                break;                   
                case 1: btn.BackColor = Color.Yellow;
                break;
                case 2: btn.BackColor = Color.Black ;
                break;
                case 3: btn.BackColor = Color.Chocolate;
                break;
                case 4: btn.BackColor = Color.Crimson;
                break;
                case 5: btn.BackColor = Color.Cyan;
                break;
                case 6: btn.BackColor = Color.CadetBlue;
                break;
                case 7: btn.BackColor = Color.Gray;
                break;
                case 8: btn.BackColor = Color.Green;
                break;
                case 9: btn.BackColor = Color.Fuchsia;
                break;
                case 10: btn.BackColor = Color.Lime;
                break;
                case 11: btn.BackColor = Color.Navy;
                break;
                case 12: btn.BackColor = Color.Black;
                break;
                case 13: btn.BackColor = Color.Red;
                break;
                case 14: btn.BackColor = Color.Peru;
                break;
                case 15: btn.BackColor = Color.Silver;
                break;
                case 16: btn.BackColor = Color.Violet ;
                break;              
            }           
        }

        private void escolha(Button btn, int i, int j) 
        {
            if (click == 0 || click == 3 || click == 2)
            {
                if (click == 2)
                {
                    timer2_Tick(null, null);
                    cron += 50;
                }
                renderiza(btn, i, j);
                m = i;
                n = j;
                btn1 = btn;                
                if (click == 0)
                {
                    cron = 0;
                    timer1.Start();
                }
                click = 1;
            }
            else if (click == 1 && btn != btn1)
            {
                renderiza(btn, i, j);
                x = i;
                y = j;
                btn2 = btn;
                timer2.Start();
                click = 2;
            }
        }

        public Form1()
        {
            InitializeComponent();
            novo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novo();
            btn1.BackColor = Color.DarkMagenta;
            btn2.BackColor = Color.DarkMagenta;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 0, 4);
        }       

        private void button10_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 0);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 1);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 2);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 3);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 1, 4);
        }              

        private void button12_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 0);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 1);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 3);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 2, 4);
        }     
        
        private void button11_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 0);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 1);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 3);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            escolha((Button)sender, 3, 4);
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            int tmp = ++cron;
            label1.Text = (tmp/(60*10)).ToString();
            tmp -= (tmp / (60 * 10) * (60 *10));
            label1.Text += ":";
            if (tmp < 100)
            {
                label1.Text += "0";
            }
            label1.Text += (tmp / 10).ToString();
            label1.Text += ".";
            tmp -= (tmp / 10) * 10;
            label1.Text += tmp.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
           
           
            if (blocos[m, n] == blocos[x, y])
            {
                btn1.Hide(); 
                btn2.Hide();                
                if (++fim == 10)
                {
                    timer1.Stop();
                    MessageBox.Show("Parabéns!!");
                    

                   
                }
            }
            else
            {
                btn1.BackColor = Color.DarkMagenta;
                btn2.BackColor = Color.DarkMagenta;
            }
            click = 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nome;
            string tempo;

            nome = textBox1.Text;
            tempo = label1.Text.ToString();
            
            MySqlConnection conn = new MySqlConnection("User Id=root; Host=localhost; Database=ranking");

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MySqlCommand comando = conn.CreateCommand();

            comando.CommandText = "INSERT INTO rank (nome,tempo) VALUES ('" + nome + "', '" + tempo + "');";

            try
            {
                int result = comando.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Ok!");

                }
                else
                {

                    MessageBox.Show("Erro");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Ranking.Items.Clear();

            MySqlConnection conn = new MySqlConnection("User Id=root; Host=localhost; Database=ranking");

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MySqlCommand comando = conn.CreateCommand();


            comando.CommandText = "SELECT * FROM rank ORDER BY tempo";

            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

               Ranking.Items.Add(reader["nome"].ToString() +"   -   "+reader["tempo"].ToString());

            }
            

            conn.Close();
        }             
                     
    }     
       
}
