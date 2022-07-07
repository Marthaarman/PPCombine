using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PPCombine
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private ArrayList PowerPointItems = new ArrayList();
        private ImageList imagelist_PowerPointItems = new ImageList();
        private ImageList imagelist_PowerPointSlides = new ImageList();


        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void setImageListSize()
        {
            /*int size1 = listView1.Height;
            int size2 = listView2.Height;
            imagelist_PowerPointItems.ImageSize = new Size(size1, size1);
            imagelist_PowerPointSlides.ImageSize = new Size(size2, size2);*/
        }

        private void addImageToPowerPointList(Image img)
        {
            /*imagelist_PowerPointItems.Images.Add(img);
            this.listView1.LargeImageList = imagelist_PowerPointItems;

            ListViewItem item = new ListViewItem();
            item.ImageIndex = imagelist_PowerPointItems.Images.Count - 1;

            this.listView1.Items.Add(item);*/
        }

       

        /* 
         * SOURCES: 
         * https://stackoverflow.com/questions/1259369/embed-powerpoint-viewer-in-c-sharp-win-form
         * https://stackoverflow.com/questions/10296018/get-system-windows-forms-iwin32window-from-wpf-window
         * https://stackoverflow.com/questions/72887547/export-ppt-slide-in-c-sharp-provides-error-powerpoint-cant-save-0-to-1
         */
        private void process_powerpoint(String file)
        {


            IntPtr screenClasshWnd = (IntPtr)0;
            IntPtr x = (IntPtr)0;

            PowerPoint.Application application = new PowerPoint.Application();
            PowerPoint.Presentation presentation = application.Presentations.Open2007(file, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue);
            PowerPointItems.Add(presentation);

            updatePowerPointList();

          

            




            /*
            PowerPoint.SlideShowSettings sst1 = presentation.SlideShowSettings;
            sst1.ShowType = (PowerPoint.PpSlideShowType)1;
            sst1.ShowPresenterView = MsoTriState.msoFalse;
            PowerPoint.SlideShowWindow sw = sst1.Run();*/



            this.Focus();

            //application.SlideShowEnd += new Microsoft.Office.Interop.PowerPoint.EApplication_SlideShowEndEventHandler(SlideShowEnds);
        }

        private void updatePowerPointList()
        {
            this.comboBox_PowerPoints.Items.Clear();
            for(int i = 0; i < PowerPointItems.Count; i++)
            {
                PowerPoint.Presentation presentation = (PowerPoint.Presentation) PowerPointItems[i];
                this.comboBox_PowerPoints.Items.Add((i + 1) + " - " + presentation.Name);
            }

            if (PowerPointItems.Count > 0)
            {
                this.comboBox_PowerPoints.SelectedIndex = 0;
            }else
            {
                this.comboBox_PowerPoints.SelectedIndex = -1;
                this.comboBox_PowerPoints.Text = "";
            }

            updateSlidesList();
        }

        private void updateSlidesList()
        {
            this.comboBox_slides.Items.Clear();
            this.comboBox_slides.Text = "";
            for(int i = 0; i < PowerPointItems.Count; i++)
            {
                PowerPoint.Presentation presentation = (PowerPoint.Presentation) PowerPointItems[i];
                PowerPoint.Slides slides = presentation.Slides;
                for(int j = 1; j <= slides.Count; j++)
                {
                    this.comboBox_slides.Items.Add("[" + (i + 1) + "] " + slides[j].Name);
                }
            }
        }

        private void createSlideImages(PowerPoint.Presentation presentation, PowerPoint.Slides slides)
        {
            String folder = @"C:\Users\marth\Downloads\tmpFolder\";
            folder += presentation.Name + "\\";

            //  create directory for slide shots
            DirectoryInfo dir = new DirectoryInfo(folder);
            if (dir.Exists)
            {
                dir.Delete(true);
            }
            Directory.CreateDirectory(folder);


            //  create all slide shots
            String firstSlide = null;
            foreach (PowerPoint.Slide slide in slides)
            {
                if (firstSlide == null)
                {
                    firstSlide = slide.Name;
                }
                String exportName = folder + slide.Name + ".png";
                slide.Export(exportName, "jpg");
            }

            //  upload first slide shot into list


            Image img = Image.FromFile(folder + firstSlide + ".png");
            addImageToPowerPointList(img);
        }

        private void button_PowerPoints_moveUp_Click(object sender, EventArgs e)
        {
            int selectedPowerPointIndex = this.comboBox_PowerPoints.SelectedIndex;
            if (selectedPowerPointIndex != null && selectedPowerPointIndex > 0)
            {
                int newPowerPointIndex = selectedPowerPointIndex - 1;
                ArrayList tmpArrayList = new ArrayList();

                for(int i = 0; i < newPowerPointIndex; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }
                }
                tmpArrayList.Add(PowerPointItems[selectedPowerPointIndex]);

                for(int i = newPowerPointIndex; i < PowerPointItems.Count; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }
                }
               
                PowerPointItems = tmpArrayList;
                
                updatePowerPointList();
                this.comboBox_PowerPoints.SelectedIndex = newPowerPointIndex;

            }
        }

        private void button_PowerPoints_moveDown_Click(object sender, EventArgs e)
        {
            int selectedPowerPointIndex = this.comboBox_PowerPoints.SelectedIndex;
            if (selectedPowerPointIndex != null && selectedPowerPointIndex < (PowerPointItems.Count - 1))
            {
                int newPowerPointIndex = selectedPowerPointIndex + 1;
                ArrayList tmpArrayList = new ArrayList();

                for (int i = 0; i < newPowerPointIndex; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }else
                    {
                        tmpArrayList.Add(PowerPointItems[i + 1]);
                    }
                }
                tmpArrayList.Add(PowerPointItems[selectedPowerPointIndex]);

                for (int i = (newPowerPointIndex + 1); i < PowerPointItems.Count; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }
                }

                PowerPointItems = tmpArrayList;

                updatePowerPointList();
                this.comboBox_PowerPoints.SelectedIndex = newPowerPointIndex;

            }
        }

        private void button_PowerPoints_add_Click(object sender, EventArgs e)
        {
            /*SOURCE: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-6.0*/
            //  Variables the file info is stored to
            var fileContent = string.Empty;
            var filePath = string.Empty;

            //  set image thumb sizes
            setImageListSize();

            //  setup dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //  File type filter
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "(*.ppt)|*.ppt|(*.pptx)|*.pptx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                //  open the dialog and if result found
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            /* END SOURCE */


            //  process file
            if (filePath != string.Empty)
            {
                process_powerpoint(filePath);
            }
        }

        private void button_PowerPoints_delete_Click(object sender, EventArgs e)
        {
            int selectedPowerPointIndex = this.comboBox_PowerPoints.SelectedIndex;
            if (selectedPowerPointIndex != null)
            {
                ArrayList tmpArrayList = new ArrayList();
                for (int i = 0; i < PowerPointItems.Count; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }
                }

                PowerPointItems = tmpArrayList;
                updatePowerPointList();
            }
        }
    }

    
}
