using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diego_Henrique_felis
{
    public partial class Tela : Form
    {
        public Tela()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.Text = string.Empty;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos TXT | *.txt";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                rtb1.Text = leitor.ReadToEnd();
                leitor.Close();
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar como";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivos TXT | *.txt";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(rtb1.Text);
                gravar.Close();
            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectedText == "")
            {
                MessageBox.Show("Nenhum texto selecionado.");
            }
            else
            {
                Clipboard.SetText(rtb1.SelectedText);
                rtb1.SelectedText = "";
            }

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb1.SelectedText = Clipboard.GetText();
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                rtb1.SelectionFont = fontDialog1.Font;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                rtb1.SelectionColor = colorDialog1.Color;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtb1.Text = string.Empty;
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Abrir arquivo";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Arquivos TXT | *.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader leitor = new System.IO.StreamReader(openFileDialog1.FileName);
                rtb1.Text = leitor.ReadToEnd();
                leitor.Close();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvar como";
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "Arquivos TXT | *.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamWriter gravar = new System.IO.StreamWriter(saveFileDialog1.FileName);
                gravar.Write(rtb1.Text);
                gravar.Close();
            }
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            if (rtb1.SelectedText == "")
            {
                MessageBox.Show("Nenhum texto selecionado.");
            }
            else
            {
                Clipboard.SetText(rtb1.SelectedText);
                rtb1.SelectedText = "";
            }
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtb1.SelectedText);
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtb1.SelectedText = Clipboard.GetText();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feito pelo Dieguinho Henryyyyyy!");
        }
    }
}
