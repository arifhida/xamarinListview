using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinListView.model;

namespace XamarinListView
{
    class myListAdapter : BaseAdapter<Person>
    {
        private List<Person> mItems;
        private Context mcontext;

        public myListAdapter(Context context,List<Person> items)
        {
            mItems = items;
            mcontext = context;
        }
        public override Person this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override int Count
        {
            get { return mItems.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if(row == null)
            {
                row = LayoutInflater.From(mcontext).Inflate(Resource.Layout.listViewRow, null, false);
            }
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = mItems[position].FirstName;
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = mItems[position].LastName;
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = mItems[position].Age;
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mItems[position].Gender;
            return row;
        }
    }
}