﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //adicionado
using System.Runtime.Serialization.Formatters.Binary; //adicionado
using System.Runtime.Serialization; //adicionado

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Versão em testes, poderá haver erros.");
        }
        float calcTotal1;
        float calcTotal2;
        float calcTotal3;
        float calcTotal4;
        float calcTotal5;
        float calcTotal6;
        float vlrTipo1;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Temos que zerar os valores dos strings, senão o programa não irá reconhecer os valores.
            calcTotal1 = 0;
            calcTotal2 = 0;
            calcTotal3 = 0;
            calcTotal4 = 0;
            calcTotal5 = 0;
            calcTotal6 = 0;
            vlrTipo1 = 0F;
            // Para as variáveis texto(string) que estão em float, temos que transformar o número em string para que a conversão ocorra corretamente.

            // Para zerar cálculo do apartamento
            txtMetr.Text = (calcTotal1).ToString();
            txtQtdap.Text = (calcTotal2).ToString();
            txtQtdan.Text = (calcTotal3).ToString();
            txtAppan.Text = (calcTotal5).ToString();
            txtConcrs.Text = (calcTotal4).ToString();
            txtAppcon.Text = (calcTotal3).ToString();
            txtQtdjogo.Text = (calcTotal4).ToString();
            txtRendm.Text = (calcTotal3).ToString();
            txtNummj.Text = (calcTotal1).ToString();
            txtQtdt.Text = (calcTotal2).ToString();
            txtDias.Text = (calcTotal3).ToString();
            txtMeses.Text = (calcTotal4).ToString();
            txtNmonta.Text = (calcTotal5).ToString();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPerim.SelectedItem.ToString() == "Meio")
            {
                vlrTipo1 = 0.5F;
            }
            else if (comboPerim.SelectedItem.ToString() == "Integral")
            {
                vlrTipo1 = 1F;
            }
        }
        // Botão Calcular apartamento
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                calcTotal1 = float.Parse(txtMetr.Text) / float.Parse(txtRendm.Text);
                calcTotal2 = float.Parse(txtQtdap.Text) / (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text));
                calcTotal3 = (float.Parse(txtQtdt.Text) * (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text))) / ((float.Parse(txtAppcon.Text) * float.Parse(txtConcrs.Text)) * 4) / float.Parse(txtQtdjogo.Text);
                calcTotal5 = float.Parse(txtNummj.Text) * float.Parse(txtQtdjogo.Text);
                calcTotal4 = float.Parse(txtMeses.Text) * 30;
                txtNummj.Text = (calcTotal1).ToString();
                txtQtdt.Text = (calcTotal2).ToString();
                txtDias.Text = (calcTotal4).ToString();
                txtMeses.Text = (calcTotal3).ToString();
                txtNmonta.Text = (calcTotal5).ToString();
                calcTotal1 = float.Parse(txtMetr.Text) / float.Parse(txtRendm.Text);
                calcTotal2 = float.Parse(txtQtdap.Text) / (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text));
                calcTotal3 = (float.Parse(txtQtdt.Text) * (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text))) / ((float.Parse(txtAppcon.Text) * float.Parse(txtConcrs.Text)) * 4) / float.Parse(txtQtdjogo.Text);
                calcTotal5 = float.Parse(txtNummj.Text) * float.Parse(txtQtdjogo.Text);
                calcTotal4 = float.Parse(txtMeses.Text) * 30;
                txtNummj.Text = (calcTotal1).ToString();
                txtQtdt.Text = (calcTotal2).ToString();
                txtDias.Text = (calcTotal4).ToString();
                txtMeses.Text = (calcTotal3).ToString();
                txtNmonta.Text = (calcTotal5).ToString();
                calcTotal1 = float.Parse(txtMetr.Text) / float.Parse(txtRendm.Text);
                calcTotal2 = float.Parse(txtQtdap.Text) / (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text));
                calcTotal3 = (float.Parse(txtQtdt.Text) * (float.Parse(txtQtdan.Text) * float.Parse(txtAppan.Text))) / ((float.Parse(txtAppcon.Text) * float.Parse(txtConcrs.Text)) * 4) / float.Parse(txtQtdjogo.Text);
                calcTotal5 = float.Parse(txtNummj.Text) * float.Parse(txtQtdjogo.Text);
                calcTotal4 = float.Parse(txtMeses.Text) * 30;
                txtNummj.Text = (calcTotal1).ToString();
                txtQtdt.Text = (calcTotal2).ToString();
                txtDias.Text = (calcTotal4).ToString();
                txtMeses.Text = (calcTotal3).ToString();
                txtNmonta.Text = (calcTotal5).ToString();
            }


            catch (FormatException)
            {
                MessageBox.Show("Formato inválido.");
            }

            catch (DivideByZeroException)
            {
                MessageBox.Show("Algum valor está zero, não é possível obter cálculo.");
            }
        }
        // Programação para imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font fonte2 = new Font("Arial", 30, FontStyle.Bold, GraphicsUnit.Pixel);
                Font fonte = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);

                e.Graphics.DrawString("Relatório de Perfomance", fonte2, Brushes.Black, 240, 70);
                e.Graphics.DrawString("Empresa:", fonte, Brushes.Black, 20, 200);
                e.Graphics.DrawString(txtEmpr.Text, fonte, Brushes.Black, 130, 200);
                e.Graphics.DrawString("Nome da Obra:", fonte, Brushes.Black, 20, 250);
                e.Graphics.DrawString(txtObra.Text, fonte, Brushes.Black, 185, 250);
                e.Graphics.DrawString("Responsável:", fonte, Brushes.Black, 20, 300);
                e.Graphics.DrawString(txtResp.Text, fonte, Brushes.Black, 170, 300);
                e.Graphics.DrawString("m² de Fôrmas:", fonte, Brushes.Black, 20, 350);
                e.Graphics.DrawString((txtMetr.Text + "m²"), fonte, Brushes.Black, 170, 350);
                e.Graphics.DrawString("Qtd. de Apartamentos:", fonte, Brushes.Black, 20, 400);
                e.Graphics.DrawString(txtQtdap.Text, fonte, Brushes.Black, 240, 400);
                e.Graphics.DrawString("Rendimento por Montador:", fonte, Brushes.Black, 20, 450);
                e.Graphics.DrawString((txtRendm.Text + "%"), fonte, Brushes.Black, 280, 450);
                e.Graphics.DrawString("Qtd. de Jogos:", fonte, Brushes.Black, 20, 500);
                e.Graphics.DrawString(txtQtdjogo.Text, fonte, Brushes.Black, 165, 500);
                e.Graphics.DrawString("Tipo de Jogo:", fonte, Brushes.Black, 20, 550);
                e.Graphics.DrawString(comboPerim.SelectedItem.ToString(), fonte, Brushes.Black, 165, 550);
                e.Graphics.DrawString("Concretagem por Semana:", fonte, Brushes.Black, 20, 600);
                e.Graphics.DrawString(txtConcrs.Text, fonte, Brushes.Black, 290, 600);
                e.Graphics.DrawString("Qtd. de Andares:", fonte, Brushes.Black, 20, 650);
                e.Graphics.DrawString(txtQtdan.Text, fonte, Brushes.Black, 195, 650);
                e.Graphics.DrawString("Qtd. de Apartamentos por Andar:", fonte, Brushes.Black, 20, 700);
                e.Graphics.DrawString(txtAppan.Text, fonte, Brushes.Black, 345, 700);
                e.Graphics.DrawString("Apartamentos por Concretagem:", fonte, Brushes.Black, 20, 750);
                e.Graphics.DrawString(txtAppcon.Text, fonte, Brushes.Black, 345, 750);
                e.Graphics.DrawString("Número de Montadores por Jogo:", fonte, Brushes.Black, 20, 800);
                e.Graphics.DrawString(txtNummj.Text, fonte, Brushes.Black, 350, 800);
                e.Graphics.DrawString("Qtd. de Torres:", fonte, Brushes.Black, 20, 850);
                e.Graphics.DrawString(txtQtdt.Text, fonte, Brushes.Black, 175, 850);
                e.Graphics.DrawString("Dias de Aluguel:", fonte, Brushes.Black, 20, 900);
                e.Graphics.DrawString(txtDias.Text, fonte, Brushes.Black, 190, 900);
                e.Graphics.DrawString("Meses de Aluguel:", fonte, Brushes.Black, 20, 950);
                e.Graphics.DrawString(txtMeses.Text, fonte, Brushes.Black, 210, 950);
                e.Graphics.DrawString("Número Total de Montadores:", fonte, Brushes.Black, 20, 1000);
                e.Graphics.DrawString(txtNmonta.Text, fonte, Brushes.Black, 320, 1000);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Por favor preencha todos os campos.");
                printPreviewDialog1.Close();
            }
        }
        // Para a barra do Menu
        // Botão Sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("S-Calculator version 1.0 Beta\n\nProgrammer: Adriano Kim\n\nDesign: Marcelo Hwang / Adriano Kim");
        }
        [Serializable] // Permite que a classe seja salva em um arquivo
        public class data // A classe de dados
        {
            public string empresa;
            public string obra;
            public string responsavel;
            public string areaformas;
            public string qtdapart;
            public string qtdandartorre;
            public string qtdappandar;
            public string concrsemana;
            public string apconcr;
            public string qtdjogos;
            public string perimetro;
            public string rendmontador;
            public string nummonta;
            public string qtdtorres;
            public string qtddias;
            public string qtdmeses;
            public string qtdnummontatotal;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter reader = new BinaryFormatter();
                FileStream input = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                data[] Dados = (data[])reader.Deserialize(input);

                txtEmpr.Text = Dados[0].empresa;
                txtObra.Text = Dados[1].obra;
                txtResp.Text = Dados[2].responsavel;
                txtMetr.Text = Dados[3].areaformas;
                txtQtdap.Text = Dados[4].qtdapart;
                txtQtdan.Text = Dados[5].qtdandartorre;
                txtAppan.Text = Dados[6].qtdappandar;
                txtConcrs.Text = Dados[7].concrsemana;
                txtAppcon.Text = Dados[8].apconcr;
                txtQtdjogo.Text = Dados[9].qtdjogos;
                comboPerim.Text = Dados[10].perimetro;
                txtRendm.Text = Dados[11].rendmontador;
                txtNummj.Text = Dados[12].nummonta;
                txtQtdt.Text = Dados[13].qtdtorres;
                txtDias.Text = Dados[14].qtddias;
                txtMeses.Text = Dados[15].qtdmeses;
                txtNmonta.Text = Dados[16].qtdnummontatotal;
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.RestoreDirectory = true;
            //read and filter the raw data
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                FileStream output = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                data[] Dados = new data[17]; //Criando o Array de 17 variáveis

                Dados[0] = new data(); //Instanciando o primeiro dado
                Dados[1] = new data(); //Instanciando o segundo dado e assim vai
                Dados[2] = new data();
                Dados[3] = new data();
                Dados[4] = new data();
                Dados[5] = new data();
                Dados[6] = new data();
                Dados[7] = new data();
                Dados[8] = new data();
                Dados[9] = new data();
                Dados[10] = new data();
                Dados[11] = new data();
                Dados[12] = new data();
                Dados[13] = new data();
                Dados[14] = new data();
                Dados[15] = new data();
                Dados[16] = new data();

                Dados[0].empresa = txtEmpr.Text.ToString(); //Armazenando o texto Empresa
                Dados[1].obra = txtObra.Text.ToString(); //Armazenando o texto Obra
                Dados[2].responsavel = txtResp.Text.ToString();
                Dados[3].areaformas = txtMetr.Text.ToString();
                Dados[4].qtdapart = txtQtdap.Text.ToString();
                Dados[5].qtdandartorre = txtQtdan.Text.ToString();
                Dados[6].qtdappandar = txtAppan.Text.ToString();
                Dados[7].concrsemana = txtConcrs.Text.ToString();
                Dados[8].apconcr = txtAppcon.Text.ToString();
                Dados[9].qtdjogos = txtQtdjogo.Text.ToString();
                Dados[10].perimetro = comboPerim.Text.ToString();
                Dados[11].rendmontador = txtRendm.Text.ToString();
                Dados[12].nummonta = txtNummj.Text.ToString();
                Dados[13].qtdtorres = txtQtdt.Text.ToString();
                Dados[14].qtddias = txtDias.Text.ToString();
                Dados[15].qtdmeses = txtMeses.Text.ToString();
                Dados[16].qtdnummontatotal = txtNmonta.Text.ToString();

                formatter.Serialize(output, Dados);

                output.Close();
            }
        }
    }
}
