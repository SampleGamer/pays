using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Les_structures_séquentielles_et_alternatives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculerNote_Click(object sender, EventArgs e)
        {
            double Exam1, Exam2, Exam3, Trav1, Trav2, Trav3, Trav4, NoteExam, NoteTrav, NoteFin;
            bool Resultat;

            Resultat = double.TryParse(txtExam1.Text, out Exam1);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note de l'examen #1 #1 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtExam2.Text, out Exam2);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note de l'examen #2 #1 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtExam3.Text, out Exam3);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note de l'examen #3 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtTravail1.Text, out Trav1);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note du travail #1 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtTravail2.Text, out Trav2);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note du travail #2 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtTravail3.Text, out Trav3);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note du travail #3 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            Resultat = double.TryParse(txtTravail4.Text, out Trav4);
            if (Resultat == false)
            {
                MessageBox.Show("Veuiller verifier si la note du travail #4 est valide ou si la case est vide.",
                    "Ereur de validation note!");
                return;
            }

            NoteExam = (Exam1 + Exam2 + Exam3) * 100 / 70;
            NoteTrav = (Trav1 + Trav2 + Trav3 + Trav4) * 100 / 65;
            NoteFin = (NoteExam * 80 / 100) + (NoteTrav * 20 / 100);

            txtNoteEtudiant.Text = String.Format("{0:0.00}", NoteFin);

            if (NoteFin >= 60)
            {
                txtROuE.Text = "Réussite";
            }
            else
            {
                txtROuE.Text = "Échec";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
