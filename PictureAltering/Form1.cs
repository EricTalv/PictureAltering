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

namespace PictureAltering
{
    public partial class Form1 : Form
    {

        public string[] files;

        Image Pilt;
        Bitmap Piltmap1, Piltmap2;
        int PiltW, PiltH;

        public Form1()
        {
            InitializeComponent();

            DefaultPicturePack();

            PBX_Input.SizeMode = PictureBoxSizeMode.Zoom;
            PBX_Output.SizeMode = PictureBoxSizeMode.Zoom;
        }

        #region TOOLSTRIP TOGGLE-BUTTONS
        //Array for shapes
        private ToolStripButton[] Shapes;

        // Allow only one shape selection at a time.
        private void Shapes_Click(object sender, EventArgs e)
        {
            SelectToolStripButton(sender as ToolStripButton, Shapes);
        }

        // Select the indicated button and deselect the others.
        private void SelectToolStripButton(ToolStripButton selected_button, ToolStripButton[] buttons)
        {
            foreach (ToolStripButton test_button in buttons)
            {
                test_button.Checked = (test_button == selected_button);
            }
        }
        #endregion

        //Choose ONE file 
        private void TLS_ChooseFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    if (LBX_Pictures.Items.Contains(Path.GetFileName(OFD.FileName)))
                    {
                        return;
                    }

                    else
                    {
                        string chosenFile = OFD.FileName;
                        files = files.Concat(new string[] { chosenFile }).ToArray();
                        LBX_Pictures.Items.Add(Path.GetFileName(chosenFile));
                    }
                }
            }
        }

        //Add Pictures to listbox from folder
        private void TLS_ChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                LBX_Pictures.Items.Clear();

                files = Directory.GetFiles(FBD.SelectedPath);

                foreach (var file in files)
                {
                    LBX_Pictures.Items.Add(Path.GetFileName(file));
                }

            }
        }

        //Add Default Pictures
        private void DefaultPicturePack()
        {
            files = Directory.GetFiles("DefaultCats");

            foreach (var file in files)
            {
                LBX_Pictures.Items.Add(Path.GetFileName(file));
            }
        }

        //What happens if a different picture is chosen
        private void LBX_Pictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (toolTriangle.Checked)
                {
                    Triangle();
                }

                if (toolCircle.Checked)
                {
                    Circle();
                }

                if (toolDiamond.Checked)
                {
                    Diamond();
                }

                StandBy();

                TSL_Size.Text = "Size: " + PBX_Input.Image.Size.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void toolTriangle_Click(object sender, EventArgs e)
        {
            Triangle();
        }
        private void toolCircle_Click(object sender, EventArgs e)
        {
            Circle();
        }
        private void toolDiamond_Click(object sender, EventArgs e)
        {
            Diamond();
        }

        //Show picture in INPUT
        private void StandBy()
        {
            try
            {
                string ImagePath = files[LBX_Pictures.SelectedIndex];
                PBX_Input.Image = new Bitmap(ImagePath);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //Go through triangle logic -> OUTPUT
        private void Triangle()
        {
            StandBy();

            L_ModeStatus.Text = "Mode: Triangle";

            if (PBX_Input.Image != null)
            {
                Piltmap1 = new Bitmap(PBX_Input.Image);

                PiltW = PBX_Input.Image.Width;
                PiltH = PBX_Input.Image.Height;

                Piltmap2 = new Bitmap(PiltW, PiltH);

                for (int y = 0; y < PiltH; y++)
                {
                    int laius = (int)((float)y * PiltW / PiltH);
                    int dx = (PiltW - laius) / 2;

                    for (int x = 0; x < laius; x++)
                    {
                        int xx = (int)((float)x * PiltW / laius);
                        Color c = Piltmap1.GetPixel(xx, y);
                        Piltmap2.SetPixel(dx + x, y, c);
                    }
                }
                PBX_Output.Image = Piltmap2;
            }
            else
            {
                return;
            }
        }

        //Init items
        private void Form1_Load(object sender, EventArgs e)
        {
            Shapes = new ToolStripButton[]
          {
                toolTriangle,
                toolCircle,
                toolDiamond
          };

            foreach (ToolStripButton B in Shapes) { B.Click += Shapes_Click; }
        }

        private void Circle()
        {
            try
            {
                StandBy();

                L_ModeStatus.Text = "Mode: Circle";

                if (PBX_Input.Image != null)
                {
                    Piltmap1 = new Bitmap(PBX_Input.Image);

                    PiltW = PBX_Input.Image.Width;
                    PiltH = PBX_Input.Image.Height;

                    Piltmap2 = new Bitmap(PiltW, PiltH);

                    float a = PiltW / 2;
                    float b = PiltH / 2;

                    for (int y = 0; y < PiltH; y++)
                    {
                        double yy = b - y;
                        double xx = a / b * Math.Sqrt(b * b - yy * yy);
                        int dx = (int)(b - xx);
                        int laius = (int)(2 * xx);

                        for (int x = 0; x < laius; x++)
                        {
                            int xxx = x * PiltW / laius;
                            Color c = Piltmap1.GetPixel(xxx, y);
                            Piltmap2.SetPixel(dx + x, y, c);
                        }
                    }
                    PBX_Output.Image = Piltmap2;
                }
                else
                {
                    return;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Diamond()
        {
            try
            {
                StandBy();

                L_ModeStatus.Text = "Mode: Diamond";

                Bitmap Piltmap1 = new Bitmap(PBX_Input.Image);

                PiltW = Piltmap1.Width;
                PiltH = Piltmap1.Height;
                PointF[] x =
                {
                    new PointF(PiltW * 0.5f, 0),
                    new PointF(0, PiltH * 0.4f),
                    new PointF(PiltW, PiltH * 0.6f)
                };

                Bitmap Piltmap2 = new Bitmap(
                (int)Piltmap1.Width,
                (int)Piltmap1.Height);

                Graphics gr_dest = Graphics.FromImage(Piltmap2);

                gr_dest.DrawImage(Piltmap1, x);

                PBX_Output.Image = Piltmap2;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
