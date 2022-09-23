using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB.;Initial Catalog=Notas;Integrated Security=True");
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }
        double nota1, nota2, nota3, nota4;
        bool testar;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void btncalcular_Click(object sender, EventArgs e)
        {
            testar = double.TryParse(Entrada1.Text, out nota1);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 1.");
                return;
            }
            testar = double.TryParse(Entrada2.Text, out nota2);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 2.");
                return;
            }
            testar = double.TryParse(Entrada3.Text, out nota3);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 3.");
                return;
            }
            testar = double.TryParse(Entrada4.Text, out nota4);
            if (testar == false)
            {
                MessageBox.Show("Faltou informar nota 1.");
                return;
            }
            CalcularNotas calc = new CalcularNotas(nota1, nota2, nota3, nota4);
            label1.Text = string.Format("Maior nota:.........................." + calc.MaiorValor().ToString(CultureInfo.InvariantCulture));
            label2.Text = string.Format("Menor nota:.........................." + calc.MenorValor().ToString(CultureInfo.InvariantCulture));
            label3.Text = string.Format("Media:..............................." + calc.Media().ToString(CultureInfo.InvariantCulture));
            label4.Text = string.Format("Soma notas pares:...................." + calc.SomarPares().ToString(CultureInfo.InvariantCulture));
            label5.Text = string.Format("Soma notas impares:.................." + calc.SomarImpares().ToString(CultureInfo.InvariantCulture));
            label6.Text = string.Format("Qtde de notas >= 7:.................." + calc.NotasMaior7().ToString(CultureInfo.InvariantCulture));

        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (Entrada1.Text != "" && Entrada2.Text != "" && Entrada3.Text != "" && Entrada4.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Alunos(nota1,nota2,nota3,nota4) VALUES(@nota1,@nota2,@nota3,@nota4)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@nota1", Entrada1.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@nota2", Entrada2.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@nota3", Entrada3.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@nota4", Entrada4.Text.ToUpper());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro incluído com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    limpar_Click();

                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("Maior nota:...................{0}", 0);
            label2.Text = string.Format("Menor nota:...................{0}", 0);
            label3.Text = string.Format("Média.........................{0}", 0);
            label4.Text = string.Format("Soma das notas pares..........{0}", 0);
            label5.Text = string.Format("Soma das notas impares......{0}", 0);
            label6.Text = string.Format("Qtde de notas >= a 7.......{0}", 0);
            Entrada1.Text = "";
            Entrada2.Text = "";
            Entrada3.Text = "";
            Entrada4.Text = "";
            try
            {
                cmd = new SqlCommand("DELETE Alunos", con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("registro Limpado com sucesso...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do programa ?", "Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Entrada1.Focus();
            }
        }

        private void btnler_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("SELECT * FROM Alunos", con);
                con.Open();
                cmd.ExecuteNonQuery();

                string retorno = "";
                string retorno2 = "";
                string retorno3 = "";
                string retorno4 = "";
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    retorno += reader["nota1"];
                    retorno2 += reader["nota2"];
                    retorno3 += reader["nota3"];
                    retorno4 += reader["nota4"];
                }
                Entrada1.Text = retorno;
                Entrada2.Text = retorno2;
                Entrada3.Text = retorno3;
                Entrada4.Text = retorno4;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            finally
            {
                con.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Entrada1_TextChanged(object sender, EventArgs e)
        {

        }
        private void limpar_Click()
        {
            Entrada1.Text = "";
            Entrada2.Text = "";
            Entrada3.Text = "";
            Entrada4.Text = "";
        }
    }
}
