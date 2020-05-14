using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    class Picture
    {
        private string fileName;
        PictureBox pictureBox;
        public Picture(string fileName, PictureBox pictureBox)
        {
            this.fileName = fileName;
            this.pictureBox = pictureBox;
        }

        public string FileName { get { return fileName; } }
        public PictureBox PicBox { get { return pictureBox; } }

        public bool choice(string secondFileName)
        {
            if (secondFileName == fileName)
                return true;
            else
                return false;
        }
    }
}
