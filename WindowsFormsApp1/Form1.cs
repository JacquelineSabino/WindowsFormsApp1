using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string caminho = @"c:\temp\";
        public Form1()
        {
            InitializeComponent();
        }

        private bool DiretoryExist()
        {
            
            if (Directory.Exists(caminho))
                return true;

            return false;
        }

        private FileInfo[] GetImages()
        {
            DirectoryInfo directorysearch = new DirectoryInfo(caminho);
            FileInfo[] images = directorysearch.GetFiles();
            return images;
        }

        private void StoreImageFifo()
        {
            Queue fifoImages = new Queue();
            FileInfo[] collectionImages = GetImages(); 
            foreach (var fileImage in collectionImages)
            {
                fifoImages.Enqueue(fileImage);
            }
        }

        

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (DiretoryExist())
            {
                StoreImageFifo();

            }
        }
    }
}
