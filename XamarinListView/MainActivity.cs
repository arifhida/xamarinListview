using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using XamarinListView.model;

namespace XamarinListView
{
    [Activity(Label = "XamarinListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<Person> mList;
        private ListView mListview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListview = FindViewById<ListView>(Resource.Id.myListview);
            mList = createList();
            myListAdapter adapter = new myListAdapter(this, mList);
            mListview.Adapter = adapter;
            mListview.ItemClick += MListview_ItemClick;
        }

        private void MListview_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private List<Person> createList()
        {
            var list = new List<Person>();

            list.Add(new Person()
            {
                FirstName = "John",
                LastName = "McClane",
                Age = "22",
                Gender = "Male"
            });
            list.Add(new Person()
            {
                FirstName = "Jerry",
                LastName = "McGuire",
                Age = "35",
                Gender = "Male"
            });
            list.Add(new Person()
            {
                FirstName = "Marry",
                LastName = "Curry",
                Age = "50",
                Gender = "Female"
            });

            list.Add(new Person()
            {
                FirstName = "Peter",
                LastName = "Parker",
                Age = "20",
                Gender = "Male"
            });

            return list;
        }
    }
}

