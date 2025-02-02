namespace Main
{
    public partial class MainPage : ContentPage
    {
        int count = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            ShowCount();
            
        }

        private void Counter2Btn_Clicked(object sender, EventArgs e)
        {
            count *= 2;
            ShowCount();
        }

        private void Counter3Btn_Clicked(object sender, EventArgs e)
        {
            count *= 3;
            ShowCount();
        }

        private void ShowCount()
        {
            if (count >= 100000)
                count = 1;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
