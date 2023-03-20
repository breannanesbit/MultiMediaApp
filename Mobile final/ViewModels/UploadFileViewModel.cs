using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Mobile_final.ViewModels
{
    public partial class UploadFileViewModel : ObservableObject
    {
        [ObservableProperty]
        private string filePath = "Testing";


        [RelayCommand]
        public async Task PickFileToUpload()
        {
            var result = await FilePicker.Default.PickAsync();
            FilePath = result.FullPath;
        }
    }
}
