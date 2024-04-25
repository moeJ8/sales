namespace practice
{
    public partial class MainPage : ContentPage
    {
        string gender;
        string s1, s2, s3, s4;

        List<Sales> salesList = new List<Sales>();
        public MainPage()
        {
            InitializeComponent();

        }

        private void Add_Clicked(System.Object sender, System.EventArgs e)
        {
            
            if(male.IsChecked)
            {
                gender = "male";
            }
            else if (female.IsChecked )
            {
                gender = "female";
            }
            if(se1.IsChecked)
            {
                s1 ="fisher";
            }
             if(se2.IsChecked)
            {
                s2 ="Staying at Home";
            }
             if (se3.IsChecked)
            {
                s3 = "Painting";
            }
             if (se4.IsChecked)
            {
                s4 = "Football";
            }


            
            salesList.Add (new Sales(Name.Text, SurName.Text, num.Text, gender,s1,s2,s3,s4));
        }

        private void Show_Clicked(System.Object sender, System.EventArgs e)
        {
            slist.ItemsSource = null;
            slist.ItemsSource = salesList;
            
        }
    }

}
