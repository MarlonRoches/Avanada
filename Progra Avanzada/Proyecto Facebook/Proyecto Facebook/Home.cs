using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Facebook
{
    public partial class Home : Form
    {
        public int medidor = 0;
        private int childFormNumber = 0;
       public bool fInicio=true, fMesseger = true, fContactos = true;
        

        private void toolsMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
        
           
           
            
        }

        
        private void fileMenu_Click(object sender, EventArgs e)
        {
           
                NewsFeed childForm = new NewsFeed();
                childForm.MdiParent = this;
                childForm.Text = "NewsFeed";
                childForm.Show();
             
            
        }

        private void editMenu_Click(object sender, EventArgs e)
        {
            
                Messeger childForm = new Messeger();
                childForm.MdiParent = this;
                childForm.Text = "Messeger";
                childForm.Show();
                fMesseger = false;
            
        }

        private void viewMenu_Click(object sender, EventArgs e)
        {
          
                Contactos childForm = new Contactos();
                childForm.MdiParent = this;
                childForm.Text = "Contactos";
                childForm.Show();
           
        }






















































































        public Home()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
