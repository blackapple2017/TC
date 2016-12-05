using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using MvvmCross.Droid.Views;
using TC.Models;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Binding.Droid.Views;

namespace TC.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
            CategoryListView catListView = FindViewById<CategoryListView>(Resource.Layout.FirstView);
        }
    }

    public class CategoryListView : MvxListView
    {
        public CategoryListView(Context context, IAttributeSet attrs) : base(context, attrs, new CategoryAdapter(context))
        {
        }
    }
    class CategoryAdapter : MvxAdapter
    {
        private FirstView firstView;
        public CategoryAdapter(Context context, IMvxAndroidBindingContext bindingContext) : base(context, bindingContext)
        {
        }
        public CategoryAdapter(Context context) : base(context, MvxAndroidBindingContextHelpers.Current())
        {
        }
        public override int GetItemViewType(int position)
        {
            return position%2;
        }

        public override int ViewTypeCount => 2;

        protected override global::Android.Views.View GetBindableView(global::Android.Views.View convertView,
            object dataContext, int templateId)
        {
            var cat = dataContext as Category;
            return base.GetBindableView(convertView, dataContext, cat.Id%2 == 0 ? Resource.Layout.category_item : Resource.Layout.category_item_2);
        }
    }
}
