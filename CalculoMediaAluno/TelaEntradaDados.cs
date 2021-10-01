using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMediaAluno
{
    public partial class TelaEntradaDados : Form
    {
        public TelaEntradaDados()
        {
            InitializeComponent();
        }

        private decimal MediaAluno (params decimal [] notas) 
        {
            decimal soma = 0;
            for(int i = 0; i <= notas.GetLength(0) - 1; i++)
            {
                soma += notas[i];
            }
            return soma / notas.Length;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string nascimento = dtpNascimento.Value.ToString();
            decimal nota1 = nAtiv01.Value;
            decimal nota2 = nAtiv02.Value;
            decimal nota3 = nAtiv03.Value;
            decimal nota4 = nAtiv04.Value;

            lstBoxResul.Items.Add(
                "Aluno: " + nome
        
                );
            lstBoxResul.Items.Add(
                "Data de Nascimento: " + nascimento
                );
            
            lstBoxResul.Items.Add("Notas das Atividades");
            lstBoxResul.Items.Add("Atividade 01: " + nota1);
            lstBoxResul.Items.Add("Atividade 02: " + nota2);
            lstBoxResul.Items.Add("Atividade 03: " + nota3);
            lstBoxResul.Items.Add("Atividade 04: " + nota4);

            lstBoxResul.Items.Add("Média Final: " + MediaAluno(nota1, nota2, nota3, nota4));

            decimal media = MediaAluno(nota1, nota2, nota3, nota4);

            decimal valormedia = nMedia.Value;
            if(media >= valormedia)
            {
                MessageBox.Show("Aluno Aprovado!");

            }
            else
            {
                MessageBox.Show("Aluno Reprovado!");
            }
           

        }
    }
}
