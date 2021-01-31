using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookNook.Base;

namespace BookNook.PresentationLayer
{
    public partial class frmAddTBR : Form, IAddNewTBRBookView
    {
        public frmAddTBR()
        { 
            InitializeComponent();
        }

        public bool ShowViewModal()
        {
            if (this.ShowDialog() == DialogResult.OK)
                return true;
            else
                return false;
        }

        public string Title => titleInput.Text;
        public string Author => authorInput.Text;
        public string Publisher => publisherInput.Text;
        public DateTime DatePublished => datePublishedPicker.Value;
        public string Genre => genreInput.Text;
        public int NumberOfPages => int.Parse(pagesInput.Text);
        public string RecommendedBy => recommendedInput.Text;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void frmAddTBR_Load(object sender, EventArgs e)
        {

        }
    }
}
