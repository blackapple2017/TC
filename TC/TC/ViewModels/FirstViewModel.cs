using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using TC.Models;

namespace TC.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        public ObservableCollection<Category> ListCategory { get; set; }

        public FirstViewModel()
        {
            ListCategory = new ObservableCollection<Category>
            {
                new Category("Category 1", "Description 1", "images/img_1_tb.jpg"),
                new Category("Category 2", "Description 2", "images/img_2_tb.jpg"),
                new Category("Category 3", "Description 3", "images/img_3_tb.jpg"),
                new Category("Category 4", "Description 4", "images/img_1_tb.jpg")
            };

        }

        private MvxCommand<Category> _categorySelectedCommand;
        public System.Windows.Input.ICommand CategorySelected
        {
            get
            {
                _categorySelectedCommand = _categorySelectedCommand ?? new MvxCommand<Category>(DoSelectedCategory);
                return _categorySelectedCommand;
            }
        }

        private void DoSelectedCategory(Category obj)
        {
            System.Diagnostics.Debug.WriteLine("Category selected: " + obj.Name);
            ShowViewModel<CategoryViewModel>();
        }
    }
}
