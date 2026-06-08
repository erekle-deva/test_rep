namespace Guess_num
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        


        private void OnCounterClicked(object sender, EventArgs e)
        {

            int start_num = Convert.ToInt32(start_range.Text);
            int end_num = Convert.ToInt32(end_range.Text);
            int user_guess = Convert.ToInt32(user_input.Text);

            


            Random rand_num = new Random();

            int random_numer = rand_num.Next(start_num, end_num);


            while (user_guess != random_numer)
            {

                DisplayAlert("guess incorect", "try again", "Ok");

            }

            DisplayAlert("Great, guess is correct", Convert.ToString(random_numer), "Okay");





        }






    }

}
