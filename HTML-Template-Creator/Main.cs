using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace HTML_Template_Creator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private string ProjectName;
        public string ProjectDirectory;

        private bool HasName = false;
        private bool HasPath = false;

        private void Main_Load(object sender, EventArgs e)
        {
            OpenButton.Enabled = false;
        }

        //Header label
        private void Header_Click(object sender, EventArgs e)
        { }

        //Create button
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (HasName == true && HasPath == true)
            {
                Create(ProjectDirectory, ProjectName);
            }
            else if (HasName == false && HasPath == true)
            {
                DoneText.ForeColor = Color.Red;
                DoneText.Text = "You need a name";
            }
            else if (HasName == true && HasPath == false)
            {
                DoneText.ForeColor = Color.Red;
                DoneText.Text = "You need a path";
            }
            else
            {
                DoneText.ForeColor = Color.Red;
                DoneText.Text = "You need a name and path";
            }
        }

        //Brows for files button
        private void BrowsButton_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowDialog();
            ProjectDirectory = FolderBrowser.SelectedPath;
            DirectoryInput.Text = ProjectDirectory;
            HasPath = true;
        }

        //Directory input field
        private void DirectoryInput_TextChanged(object sender, EventArgs e)
        {
            ProjectDirectory = DirectoryInput.Text;
            HasPath = true;
        }

        //Name label click
        private void label1_Click(object sender, EventArgs e)
        { }

        //Name input field
        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            ProjectName = NameInput.Text;
            HasName = true;
        }

        public string GetPath()
        {
            return ProjectDirectory;
        }

        public void Create(string Path, string Name)
        {
            //Creating all strings
            string PathString = @Path + @"\" + Name;

            string CssPath = @PathString + @"\css";
            string JSPath = @PathString + @"\js";
            string ImgPath = @PathString + @"\img";
            string MiscPath = @PathString + @"\misc";

            //Creating folders
            Directory.CreateDirectory(PathString);
            Directory.CreateDirectory(CssPath);
            Directory.CreateDirectory(JSPath);
            Directory.CreateDirectory(ImgPath);
            Directory.CreateDirectory(MiscPath);

            // Verify the path that you have constructed.
            Console.WriteLine("Path to my file: {0}\n", PathString);

            File.Create(CssPath + @"\style.css");

            WriteToFile();

            DoneText.ForeColor = Color.Green;
            OpenButton.Enabled = true;
            DoneText.Text = "Done!";
        }

        private void WriteToFile()
        {
            using (FileStream fs = new FileStream(ProjectDirectory + @"\" + ProjectName + @"\index.html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.WriteLine("<!DOCTYPE html>");
                    w.WriteLine("<html lang=" + "en" + ">");
                    w.WriteLine("<head>");
                    w.WriteLine("    <link rel=" + "stylesheet" + "href=" + "css / style.css" + ">");
                    w.WriteLine("    <meta charset=" + "UTF - 8" + ">");
                    w.WriteLine("    <meta name=" + "viewport" + " content=" + "width = device - width, initial - scale = 1.0" + ">");
                    w.WriteLine("    <meta http-equiv=" + "X - UA - Compatible" + "content=" + "ie = edge" + ">");
                    w.WriteLine("    <title>Document</title>");
                    w.WriteLine("</head>");
                    w.WriteLine("<body>");
                    w.WriteLine("");
                    w.WriteLine("</body>");
                    w.WriteLine("</html>");
                }
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = ProjectDirectory + @"\" + Name,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }
    }
}