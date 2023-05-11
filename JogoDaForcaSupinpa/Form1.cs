using System.Reflection.Metadata.Ecma335;

namespace JogoDaForcaSupinpa
{
    public partial class telaPrincipal : Form
    {
        string palavra1, tentadas;
        char letra;
        int quantidade = 0, erros = 0, faltam = 0;
        char[] escondido;
        bool achou = false, tenta = false;
        public telaPrincipal()
        {
            InitializeComponent();
            escondido = new char[20];
        }

        private string PalavraAleatoria()
        {


            string[] palavras =
           {
            "ABACATE",
            "ABACAXI",
            "ACEROLA",
            "ACAI",
            "ARACA",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJA",
            "CAJU",
            "CARAMBOLA",
            "CUPUACU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MACA",
            "MANGABA",
            "MANGA",
            "MARACUJA",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA" };
            Random rand = new Random();
            string palavra = palavras[rand.Next(palavras.Length)];
            return palavra;
        }

        private void telaPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void lb_cabeca_Click(object sender, EventArgs e)
        {

        }

        private void lb_coluna_Click(object sender, EventArgs e)
        {

        }

        private void lb_braco2_Click(object sender, EventArgs e)
        {

        }

        private void lb_braco1_Click(object sender, EventArgs e)
        {

        }

        private void lb_pernas_Click(object sender, EventArgs e)
        {

        }

        private void lb_Boneco_Click(object sender, EventArgs e)
        {

        }

        private void bt_iniciar_Click(object sender, EventArgs e)
        {
            palavra1 = PalavraAleatoria();
            quantidade = palavra1.Length;
            faltam = quantidade;
            lb_palavra.Text = "";
            lb_tentativas.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                escondido[cont] = '*';
                lb_palavra.Text = lb_palavra.Text + escondido[cont];
            }
            erros = 0;
            lb_cabeca.Visible = false;
            lb_braco1.Visible = false;
            lb_braco2.Visible = false;
            lb_pernas.Visible = false;
            lb_coluna.Visible = false;
            txt_PalavraSecreta.Enabled = false;
            bt_Start.Enabled = false;
            maskedTextBox1.Enabled = true;
            bt_tentar.Enabled = true;
            maskedTextBox1.Focus();
            lb_faltam.Text = faltam.ToString();
            lb_erros.Text = erros.ToString();






        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair da aplicaçao ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void letra_Q_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "Q";
        }

        private void letra_W_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "W";
        }

        private void letra_E_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "E";
        }

        private void letra_R_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "R";
        }

        private void letra_T_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "T";
        }

        private void letra_Y_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "Y";
        }

        private void letra_U_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "U";
        }

        private void letra_I_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "I";
        }

        private void letra_O_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "O";
        }

        private void letra_P_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "P";
        }

        private void letra_A_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "A";
        }

        private void letra_S_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "S";
        }

        private void letra_D_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "D";
        }

        private void letra_F_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "F";
        }

        private void letra_G_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "G";
        }

        private void letra_H_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "H";
        }

        private void letra_J_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "J";
        }

        private void letra_K_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "K";
        }

        private void letra_L_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "L";
        }

        private void letra_Z_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "Z";
        }

        private void letra_X_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "X";
        }

        private void letra_C_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "C";
        }

        private void letra_V_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "V";
        }

        private void letra_B_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "B";
        }

        private void letra_N_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text += "N";
        }

        private void letra_M_Click(object sender, EventArgs e)
        {

            maskedTextBox1.Text += "M";
        }




        private void txt_ContadorDeErros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_PalavraSecretaCerta_TextChanged(object sender, EventArgs e)
        {


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_PalavraSecreta_TextChanged_1(object sender, EventArgs e)
        {


        }

        private void bt_tentar_Click(object sender, EventArgs e)
        {
            //verificar se a letra ja foi encontrada
            letra = maskedTextBox1.Text[0];
            for (int cont = 0; cont != quantidade; cont++)
            {
                if (letra == escondido[cont])
                {
                    tenta = true;
                }

            }
            // codigo que verifica se a letra ja foi tentada
            tentadas = lb_tentativas.Text;
            int quant = tentadas.Length;
            for (int cont = 0; cont != quant; cont++)
            {
                if (letra == tentadas[cont])
                {
                    tenta = true;
                }

            }
            if (tenta == true)
            {
                MessageBox.Show("Voce ja digitou essa letra");
            }
            else
            {
                //codigo q procura letra na palavra escondida
                for (int cont = 0; cont != quantidade; cont++)
                {
                    if (letra == palavra1[cont])
                    {
                        escondido[cont] = letra;
                        achou = true;
                        faltam = faltam - 1;
                    }
                }
            }
            //reiniciando  a palavra  exibida  no form
            lb_palavra.Text = "";
            for (int cont = 0; cont != quantidade; cont++)
            {
                lb_palavra.Text = lb_palavra.Text + escondido[cont];
            }
            //em caso de vitoria

            if (faltam == 0)
            {
                MessageBox.Show("Parabens seu NOIA! vOCE venceu");


                bt_Start.Enabled = true;
                txt_PalavraSecreta.Enabled = true;
                maskedTextBox1.Enabled = false;
                bt_tentar.Enabled = false;
                txt_PalavraSecreta.Text = "";
                txt_PalavraSecreta.Focus();


            }
            //atualizar letras tentadas

            if ((achou == false) & (tenta == false))
            {
                erros++;
                lb_tentativas.Text = lb_tentativas.Text + " " + letra;

            }
            //atualizar exibicao do boneco
            if (erros == 1)
            {
                lb_cabeca.Visible = true;

            }
            if (erros == 2)
            {
                lb_coluna.Visible = true;
            }
            if (erros == 3)
            {
                lb_braco1.Visible = true;
            }
            if (erros == 4)
            {
                lb_pernas.Visible = true;
            }
            if (erros == 5)
            {
                lb_braco2.Visible = true;

                MessageBox.Show("PERDEU VACILAO!!!");
                bt_Start.Enabled = true;
                txt_PalavraSecreta.Enabled = true;
                maskedTextBox1.Enabled = false;
                bt_tentar.Enabled = false;
                txt_PalavraSecreta.Text = "";
                txt_PalavraSecreta.Focus();
            }

            //REINICIAR AS VARIAVEIS DE COMPARACAO
            tenta = false;
            achou = false;
            maskedTextBox1.Text = "";
            maskedTextBox1.Focus();

            lb_faltam.Text = faltam.ToString();
            lb_erros.Text = erros.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}