using FaceMan.Tools.Models.CodeGenerator;

using System.Collections.ObjectModel;

namespace FaceMan.Tools.ViewModels.Pages.CodeGenerator
{
    public class AddOrEditTableViewModel : ObservableObject
    {
        public ObservableCollection<Field> Fields { get; set; }
    }
}
