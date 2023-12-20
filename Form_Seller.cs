using OrderingSystem.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    public partial class Form_Seller : Form
    {
        public bool hasChange = false;
        private String IMG_PATH = AppDomain.CurrentDomain.BaseDirectory + "\\Image";
        public Form_Seller()
        {
            InitializeComponent();
            //
            if (!Directory.Exists(IMG_PATH))
                Directory.CreateDirectory(IMG_PATH);
        }

        private void Form_Seller_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            String path = ofd.FileName;

            label1.Text = path;
            pictureBox1.Image = new Bitmap(path);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String oldpath = label1.Text;

                String newFile = $"Img_{DateTime.Now.ToString("yyyy-M-d_H-m-ss")}.jpg";

                String newFilepath = Path.Combine(IMG_PATH, newFile);

                System.IO.File.Copy(oldpath, newFilepath);
                //MessageBox.Show("Uploaded!");


                using (var db = new Isda_Ordering_SystemEntities())
                {
                    var newBook = new Product();
                    newBook.ProductName = txtBookTitle.Text;
                    newBook.ProductPrice = Convert.ToDecimal(txtPrice.Text);
                    newBook.ProductImgPath = newFile;

                    db.Product.Add(newBook);
                    db.SaveChanges();

                    hasChange = true;
                }
                MessageBox.Show("Uploaded!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
