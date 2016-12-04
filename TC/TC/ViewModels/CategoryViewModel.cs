using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using TC.Models;

namespace TC.ViewModels
{
    public class CategoryViewModel: MvxViewModel
    {
        public ObservableCollection<Category> ListCategory { get; set; }
        public CategoryViewModel()
        {
            ListCategory = new ObservableCollection<Category>
            {
                new Category("Category 1", "Description 1",
                    "http://img.f29.vnecdn.net/2016/10/22/anhmoi2-3086-1477115773_490x294.jpg"),
                new Category("Category 2", "Description 2",
                    "http://img.f29.vnecdn.net/2016/10/22/anhmoi2-3086-1477115773_490x294.jpg"),
                new Category("Category 3", "Description 3",
                    "http://img.f30.vnecdn.net/2016/10/21/buonlau-3209-1477065005_180x108.jpg"),
                new Category("Category 4", "Description 4",
                    "http://img.f30.vnecdn.net/2016/10/21/buonlau-3209-1477065005_180x108.jpg")
            };


        }
    }
}