using EFCodeFirstNTierMapping.BLL;
using EFCodeFirstNTierMapping.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirstNTierMapping.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddCategory();
            AddFilms();
        }

        private void AddCategory()
        {
            CategoryService categoryService = new CategoryService();
            cmbCategoryName.DataSource = categoryService.GetCategories();
            cmbCategoryName.DisplayMember = "KategoriAdi";
            cmbCategoryName.ValueMember = "ID";
        }

        private void AddFilms()
        {
            FilmService filmService = new FilmService();
            filmService.GetFilms();
            
        }

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            BLL.FilmService filmService = new FilmService();

            Film film = new Film();
            film.FilmName = txtFilmName.Text;
            film.CategoryID = 5;
            film.FilmDetail = new FilmDetail()
            {
                DetailOfFilm = txtFilmDetail.Text
            };

            filmService.AddFilm(film);
            
        }
    }
}
