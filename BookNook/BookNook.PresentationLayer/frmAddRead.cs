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
using BookNook.Controllers;
using BookNook.DomainModel.Repositories;

namespace BookNook.PresentationLayer
{
    public partial class frmAddRead : Form, IAddNewReadBookView
    {
        ReadController _controller;
        IReadRepository _repo;
        
        public frmAddRead()
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
        public DateTime DateRead => dateReadPicker.Value;
        public int Rating => int.Parse(ratingInput.Text);

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _controller.AddNewReadBook(this, _repo);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmAddRead_Load(object sender, EventArgs e)
        {

        }
    }
}
