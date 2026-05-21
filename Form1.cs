using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using OOPFoundation; // IMPORTANTE: Adicionado o uso do namespace exigido pelo PDF

namespace CalculadoraDeMedias08
{
    public partial class TXTPIM : Form
    {
        // Força o uso da cultura brasileira para evitar quebras se o Windows do professor estiver em inglês
        private readonly CultureInfo culturaBr = CultureInfo.GetCultureInfo("pt-BR");

        public TXTPIM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Estado inicial exigido pelo item 5 e 8 do PDF
            BOXEXAME.Enabled = false;
            BOXFINAL.Enabled = false;
            BTFINAL.Enabled = false;
            BT2LIMPAR.Enabled = false;

            BOXSEMESTRAL.Text = "0,0";
            BOXFINAL.Text = "0,0";

            panel1.BackColor = Color.LightGray;
            lblStatus.Text = "EM ANDAMENTO";
            lblStatus.ForeColor = Color.Black;
        }

        // --- 1. BOTÃO CALCULAR SEMESTRAL (BTSEMESTRAL) ---
        private void BTSEMESTRAL_Click(object sender, EventArgs e)
        {
            try
            {
                var sanitizador = new SanitizadorNota();
                var validador = new ValidadorNota(); // Usando a classe corrigida conforme UML

                string textonp1 = sanitizador.Sanitize(BOXNP1.Text);
                string textonp2 = sanitizador.Sanitize(BOXNP2.Text);
                string textonpim = sanitizador.Sanitize(BOXPIM.Text);

                // Conversão explícita usando a cultura unificada (pt-BR)
                double np1 = Convert.ToDouble(textonp1, culturaBr);
                double np2 = Convert.ToDouble(textonp2, culturaBr);
                double pim = Convert.ToDouble(textonpim, culturaBr);

                if (!validador.DoubleIsValid(np1) || !validador.DoubleIsValid(np2) || !validador.DoubleIsValid(pim))
                {
                    MessageBox.Show("As notas devem estar entre 0,0 e 10,0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Fórmula do Item 6 do PDF
                double mediaSemestral = ((4 * np1) + (4 * np2) + (2 * pim)) / 10;
                mediaSemestral = Math.Round(mediaSemestral, 1, MidpointRounding.AwayFromZero);

                BOXSEMESTRAL.Text = mediaSemestral.ToString("F1", culturaBr);

                if (mediaSemestral >= 7.0)
                {
                    lblStatus.Text = "APROVADO";
                    panel1.BackColor = Color.SpringGreen;

                    BOXEXAME.Enabled = false;
                    BTFINAL.Enabled = false;
                    BT2LIMPAR.Enabled = false;
                }
                else
                {
                    lblStatus.Text = "EM EXAME";
                    panel1.BackColor = Color.Orange;

                    // Habilita controles da direita (Item 8.ii.3)
                    BOXEXAME.Enabled = true;
                    BTFINAL.Enabled = true;
                    BT2LIMPAR.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, digite apenas números válidos nos campos de notas.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 2. BOTÃO CALCULAR FINAL (BTFINAL) ---
        private void BTFINAL_Click(object sender, EventArgs e)
        {
            try
            {
                var sanitizador = new SanitizadorNota();
                var validador = new ValidadorNota();

                string textoExame = sanitizador.Sanitize(BOXEXAME.Text);
                double notaExame = Convert.ToDouble(textoExame, culturaBr);

                if (!validador.DoubleIsValid(notaExame))
                {
                    MessageBox.Show("A nota do exame deve estar entre 0,0 e 10,0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double mediaSemestral = Convert.ToDouble(BOXSEMESTRAL.Text, culturaBr);
                double mediaFinal = (mediaSemestral + notaExame) / 2;
                mediaFinal = Math.Round(mediaFinal, 1, MidpointRounding.AwayFromZero);

                BOXFINAL.Text = mediaFinal.ToString("F1", culturaBr);

                if (mediaFinal >= 5.0)
                {
                    lblStatus.Text = "APROVADO";
                    panel1.BackColor = Color.SpringGreen;
                }
                else
                {
                    lblStatus.Text = "REPROVADO";
                    panel1.BackColor = Color.Crimson;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, digite uma nota válida para o exame.", "Erro de Digitação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 3. BOTÃO LIMPAR ESQUERDA/SEMESTRAL (BT1LIMPAR) ---
        private void BT1LIMPAR_Click(object sender, EventArgs e)
        {
            BOXNP1.Text = "";
            BOXNP2.Text = "";
            BOXPIM.Text = "";
            BOXEXAME.Text = "";
            BOXSEMESTRAL.Text = "0,0";
            BOXFINAL.Text = "0,0"; // Adicionado para zerar ambas conforme Item 8.i.2

            lblStatus.Text = "EM ANDAMENTO";
            lblStatus.ForeColor = Color.Black;
            panel1.BackColor = Color.LightGray;

            BOXEXAME.Enabled = false;
            BOXFINAL.Enabled = false;
            BTFINAL.Enabled = false;
            BT2LIMPAR.Enabled = false;
        }

        // --- 4. BOTÃO LIMPAR DIREITA/FINAL (BT2LIMPAR) ---
        private void BT2LIMPAR_Click(object sender, EventArgs e)
        {
            BOXEXAME.Text = "";
            BOXFINAL.Text = "0,0";

            lblStatus.ForeColor = Color.Black;  // Adicionado conforme Item 8.iii.3
            panel1.BackColor = Color.LightGray;
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void TXTNP2_Click(object sender, EventArgs e) { }
        private void lblStatus_Click(object sender, EventArgs e) { }
    }
}

// --- ARQUITETURA CONFORME DIAGRAMA UML (PÁGINA 4) ---
namespace OOPFoundation
{
    public interface IDoubleValidation
    {
        bool DoubleIsValid(double doubleToValidate); // Ajustado para corresponder ao padrão do projeto
    }

    public abstract class ADoubleValidation : IDoubleValidation
    {
        protected double LowerLimit { get; set; }
        protected double UpperLimit { get; set; }

        public abstract bool DoubleIsValid(double doubleToValidate);
    }

    public class ValidadorNota : ADoubleValidation
    {
        public ValidadorNota()
        {
            // Define o intervalo fechado [0,0; 10,0] do Item 10.i
            LowerLimit = 0.0;
            UpperLimit = 10.0;
        }

        public override bool DoubleIsValid(double nota)
        {
            return nota >= LowerLimit && nota <= UpperLimit;
        }
    }

    public class SanitizadorNota
    {
        public string Sanitize(string texto)
        {
            // Se o campo estiver em branco, lança String vazia para estourar o try-catch
            // Isso impede que o app assuma nota '0' sem o usuário ter digitado nada
            if (string.IsNullOrWhiteSpace(texto)) return string.Empty;

            string formatado = Regex.Replace(texto, @"[^0-9,.]", "");
            return formatado.Replace('.', ',');
        }
    }
}
