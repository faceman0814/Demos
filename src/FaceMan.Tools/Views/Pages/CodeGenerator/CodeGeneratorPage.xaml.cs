using FaceMan.Tools.ViewModels.Pages.CodeGenerator;

using Wpf.Ui.Controls;

namespace FaceMan.Tools.Views.Pages
{
    public partial class CodeGeneratorPage : INavigableView<CodeGeneratorViewModel>
    {
        public CodeGeneratorViewModel ViewModel { get; }

        public CodeGeneratorPage(CodeGeneratorViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
            viewModel.Query();
            this.DataContext = viewModel;
        }
    }
}
