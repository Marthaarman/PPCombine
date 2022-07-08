using System;
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Core;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

/* 
* SOURCES: 
* https://stackoverflow.com/questions/1259369/embed-powerpoint-viewer-in-c-sharp-win-form
* https://stackoverflow.com/questions/10296018/get-system-windows-forms-iwin32window-from-wpf-window
* https://stackoverflow.com/questions/72887547/export-ppt-slide-in-c-sharp-provides-error-powerpoint-cant-save-0-to-1
*/

namespace PPCombine
{

    public partial class Form1 : Form
    {
        private ArrayList PowerPointItems = new ArrayList();
        private ImageList imagelist_PowerPointItems = new ImageList();
        private ImageList imagelist_PowerPointSlides = new ImageList();

        private int currentPowerPointIndex = -1;
        private int currentSlideIndex = -1;

        private String formName = "Form1";

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyUp += listener_keyPress;
            this.FormClosed += listener_closeForm;
        }

        
        private void listener_keyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                nextSlide();
            }
            else if (e.KeyCode == Keys.Left)
            {
                prevSlide();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                closePowerPoint(currentPowerPointIndex);
                this.button_PowerPoints_moveDown.Enabled = true;
                this.button_PowerPoints_moveUp.Enabled = true;
                this.button_PowerPoints_delete.Enabled = true;
            }

            e.Handled = true;
        }

        private void listener_closeForm(object sender, EventArgs e)
        {
            for(int i = 0; i < PowerPointItems.Count; i++)
            {
                closePowerPoint(i);
            }
        }

        
        private void process_powerpoint(String file)
        {
            PowerPoint.Application application = new PowerPoint.Application();
            PowerPoint.Presentation presentation = application.Presentations.Open2007(file, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue);
            PowerPointItems.Add(presentation);

            updatePowerPointList();
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

        
        

        private void openPowerPoint()
        {
            if (currentPowerPointIndex != -1 && PowerPointItems.Count > 0)
            {
                PowerPoint.Presentation presentation = (PowerPoint.Presentation)PowerPointItems[currentPowerPointIndex];
                if (presentation != null)
                {
                    PowerPoint.SlideShowSettings sst1 = presentation.SlideShowSettings;
                    sst1.ShowType = (PowerPoint.PpSlideShowType)1;
                    sst1.ShowPresenterView = MsoTriState.msoFalse;
                    PowerPoint.SlideShowWindow sw = sst1.Run();
                    presentation.SlideShowWindow.View.GotoSlide(currentSlideIndex + 1);
                    setControlInfo();
                }

                this.button_PowerPoints_moveDown.Enabled = false;
                this.button_PowerPoints_moveUp.Enabled = false;
                this.button_PowerPoints_delete.Enabled = false;
            }
            Thread.Sleep(10);
            Application.OpenForms[this.formName]?.Activate();
        }

        private void goToSlide(int n)
        {
            PowerPoint.Presentation presentation = (PowerPoint.Presentation)PowerPointItems[currentPowerPointIndex];
            presentation.SlideShowWindow.View.GotoSlide(n + 1);
            this.Focus();
            setControlInfo();
        }

        private void closePowerPoint(int n)
        {
            if (n >= 0 && n < PowerPointItems.Count)
            {
                PowerPoint.Presentation presentation = (PowerPoint.Presentation)PowerPointItems[n];
                String file = presentation.Path + "\\" + presentation.Name;
                presentation.Close();//presentation.SlideShowWindow.View.Exit();
                PowerPoint.Application application = new PowerPoint.Application();
                PowerPointItems[n] = application.Presentations.Open2007(file, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoTrue);
            }
            this.Focus();
            Thread.Sleep(10);
            Application.OpenForms[this.formName]?.Activate();
        }

        

        private void nextSlide()
        {
            if (currentPowerPointIndex != -1 && PowerPointItems.Count > 0)
            {
                
                PowerPoint.Presentation presentation = (PowerPoint.Presentation)PowerPointItems[currentPowerPointIndex];
                currentSlideIndex = presentation.SlideShowWindow.View.Slide.SlideNumber - 1;
                currentSlideIndex++;
                if (currentSlideIndex >= presentation.Slides.Count)
                {
                    if (currentPowerPointIndex >= PowerPointItems.Count - 1)
                    {
                        currentSlideIndex--;
                        return;
                    }else
                    {
                        int closeNR = currentPowerPointIndex;
                        currentPowerPointIndex++;
                        currentSlideIndex = 0;
                        openPowerPoint();
                        closePowerPoint(closeNR);
                    }
                }
                goToSlide(currentSlideIndex);
            }
        }

        private void prevSlide()
        {
            if (currentPowerPointIndex != -1 && PowerPointItems.Count > 0)
            {
                PowerPoint.Presentation presentation = (PowerPoint.Presentation)PowerPointItems[currentPowerPointIndex];
                currentSlideIndex = presentation.SlideShowWindow.View.Slide.SlideNumber - 1;
                currentSlideIndex--;
                if (currentSlideIndex < 0)
                {
                    if (currentPowerPointIndex == 0)
                    {
                        currentSlideIndex++;
                        return;
                    }else if(currentPowerPointIndex > 0) {
                        int closeNR = currentPowerPointIndex;
                        currentPowerPointIndex--;
                        presentation = (PowerPoint.Presentation) PowerPointItems[currentPowerPointIndex];
                        currentSlideIndex = 0;
                        openPowerPoint();
                        currentSlideIndex = presentation.Slides.Count - 1;
                        goToSlide(currentSlideIndex);
                        closePowerPoint(closeNR);
                    }
                }
                goToSlide(currentSlideIndex);
            }
        }

        private void setControlInfo()
        {
            PowerPoint.Presentation presentation = (PowerPoint.Presentation) PowerPointItems[currentPowerPointIndex];
            this.label_currentPowerPointValue.Text = presentation.Name;
            this.label_currentSlideValue.Text = (currentSlideIndex + 1).ToString();
            if (currentSlideIndex + 1 >= presentation.Slides.Count)
            {
                if(currentPowerPointIndex + 1 < PowerPointItems.Count)
                {
                    presentation = (PowerPoint.Presentation)PowerPointItems[currentPowerPointIndex + 1];
                    this.label_nextPowerPointValue.Text = presentation.Name;
                    this.label_nextSlideValue.Text = (1).ToString();
                }else
                {
                    this.label_nextPowerPointValue.Text = "[Finished] " + presentation.Name;
                    this.label_nextSlideValue.Text = "[Finished] " + (currentSlideIndex + 1).ToString();
                }
               
            }else
            {
                this.label_nextPowerPointValue.Text = presentation.Name;
                this.label_nextSlideValue.Text = (currentSlideIndex + 2).ToString();
            }

            
        }

        private void button_nextSlide_Click(object sender, EventArgs e)
        {
            nextSlide();
        }

        private void button_prevSlide_Click(object sender, EventArgs e)
        {
            prevSlide();
        }

        private void button_PowerPointStart_Click(object sender, EventArgs e)
        {
            currentPowerPointIndex = 0;
            currentSlideIndex = 0;
            openPowerPoint();
        }

        private void button_PowerPointStop_Click(object sender, EventArgs e)
        {
            closePowerPoint(currentPowerPointIndex);
            this.button_PowerPoints_moveDown.Enabled = true;
            this.button_PowerPoints_moveUp.Enabled = true;
            this.button_PowerPoints_delete.Enabled = true;
        }

        private void button_slideGoTo_Click(object sender, EventArgs e)
        {
            int selectedSlideIndex = this.comboBox_slides.SelectedIndex;
            int closeNR = -1;
            if (selectedSlideIndex >= 0)
            {
                for (int i = 0; i < PowerPointItems.Count; i++)
                {
                    PowerPoint.Presentation presentation = (PowerPoint.Presentation)(PowerPointItems[i]);
                    if(selectedSlideIndex < presentation.Slides.Count)
                    {
                        if(i != currentPowerPointIndex)
                        {
                            closeNR = currentPowerPointIndex;
                        }
                        currentPowerPointIndex = i;
                        currentSlideIndex = selectedSlideIndex;
                        break;
                    }else
                    {
                        selectedSlideIndex -= presentation.Slides.Count;
                    }
                }
                
                openPowerPoint();

                if(closeNR >= 0)
                {
                    closePowerPoint(closeNR);
                }
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

        private void button_PowerPoints_moveUp_Click(object sender, EventArgs e)
        {
            int selectedPowerPointIndex = this.comboBox_PowerPoints.SelectedIndex;
            if (selectedPowerPointIndex != null && selectedPowerPointIndex > 0)
            {
                int newPowerPointIndex = selectedPowerPointIndex - 1;
                ArrayList tmpArrayList = new ArrayList();

                for (int i = 0; i < newPowerPointIndex; i++)
                {
                    if (i != selectedPowerPointIndex)
                    {
                        tmpArrayList.Add(PowerPointItems[i]);
                    }
                }
                tmpArrayList.Add(PowerPointItems[selectedPowerPointIndex]);

                for (int i = newPowerPointIndex; i < PowerPointItems.Count; i++)
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
                    }
                    else
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


        private void createSlideImages(PowerPoint.Presentation presentation, PowerPoint.Slides slides)
        {
            /*String folder = @"C:\Users\marth\Downloads\tmpFolder\";
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
            addImageToPowerPointList(img);*/
        }


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
    }

    
}
