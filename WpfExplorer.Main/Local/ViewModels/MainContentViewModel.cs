using CommunityToolkit.Mvvm.Input;
using Jamesnet.Wpf.Mvvm;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using WpfExplorer.Support.Local.Helpers;
using WpfExplorer.Support.Local.Models;


namespace WpfExplorer.Main.Local.ViewModels
{
    public partial class MainContentViewModel : ObservableBase
    {
        //public ICommand FolderChangedCommand { get; init; }
        private readonly FileService _fileService;

        public List<FolderInfo> Roots { get; init; }

        public MainContentViewModel(FileService fileServie)
        {
            //FolderChangedCommand = new RelayCommand<FolderInfo>(FolderChanged);
            _fileService = fileServie;
            
            Roots = _fileService.GenerateRootNodes();
        }

        [RelayCommand]
        private void FolderChanged(FolderInfo folderInfo)
        {
            //MessageBox.Show($"Selected : {folderInfo.Name}");
            _fileService.RefreshSubdirectories(folderInfo);
        }
    }
}
