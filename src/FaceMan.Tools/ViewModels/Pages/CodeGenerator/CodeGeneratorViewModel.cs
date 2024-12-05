using FaceMan.Tools.Db;
using FaceMan.Tools.Models.CodeGenerator;

using System.Collections.ObjectModel;

using Wpf.Ui.Controls;

namespace FaceMan.Tools.ViewModels.Pages.CodeGenerator
{
    public partial class CodeGeneratorViewModel : ObservableObject, INavigationAware
    {
        private bool _isInitialized = false;

        public CodeGeneratorViewModel()
        {
        }

        public void OnNavigatedTo()
        {
            if (!_isInitialized)
            {
                _isInitialized = true;
            }
        }

        public void OnNavigatedFrom() { }

        public ObservableCollection<Entity> Entities { get; set; }

        public void Query()
        {
            var entities = DBHelper.sqlite.Select<Entity>().ToList();
            Entities = new ObservableCollection<Entity>(entities);
        }
    }
}
