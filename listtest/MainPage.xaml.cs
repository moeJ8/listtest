namespace listtest
{
    public partial class MainPage : ContentPage
    {
         List<Student> students = new List<Student>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(idd.Text, out ID);

            students.Add(new Student(ID, name.Text, lastName.Text));
            studentList.ItemsSource = null;
            studentList.ItemsSource = students;
            
        }
    }

}
