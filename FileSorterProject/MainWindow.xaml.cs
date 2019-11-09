using FileSorterProject.Models;
using FileSorterProject.Services.Implementations;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FileSorterProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string path { get; set; }
        private FileService fileService;
        private SortingService sortingService;
        private SortableList sortableList;
        public MainWindow()
        {
            InitializeComponent();
            fileService = new FileService();
            sortingService = new SortingService();
        }

        private void Button_Click_OpenFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.DefaultExt = ".txt";
            ofd.Filter = "Text Document (.txt)|*.txt";
            if(ofd.ShowDialog() == true)
            {
                path = ofd.FileName;
                textBoxPath.Text = path;
                textBoxContent.Text = string.Join(System.Environment.NewLine, fileService.ReadFromFile(path));
            }
        }

        private void Button_Click_Sort(object sender, RoutedEventArgs e)
        {
            if (path != null)
            {
                sortableList = new SortableList(fileService.ReadFromFile(path));
                sortingService.Sort(sortableList);
                fileService.WriteToFile(path, sortableList.List);
                textBoxContent.Text = string.Join(System.Environment.NewLine, sortableList.List);
            }
        }

        private void TextBoxContent_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
