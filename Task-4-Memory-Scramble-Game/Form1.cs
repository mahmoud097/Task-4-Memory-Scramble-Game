namespace Task_4_Memory_Scramble_Game
{
    public partial class Form1 : Form
    {
        //initiate List numbers
        List<int> numbers = new List<int> { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6 };
        string firstChoice;
        string secondChoice;
        int tries;
        List<PictureBox> pictures = new List<PictureBox>();
        PictureBox picA;
        PictureBox picB;
        int totalTime = 30;
        int countDownTime;
        bool gameOver = false;

        public Form1()          // call method load pics
        {
            InitializeComponent();
            LoadPictures();
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void RestartGameEvent(object sender, EventArgs e)
        {

        }
        private void LoadPictures()
        {
            int leftPos = 20;
            int topPos = 20;
            int rows = 0;

            for (int i = 0; i < 12; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = 50;
                newPic.Width = 50;
                newPic.BackColor = Color.LightGray;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click;
                pictures.Add(newPic);

                if (rows < 3)
                {
                    rows++;
                    newPic.Left = leftPos;
                    newPic.Top = topPos;
                    this.Controls.Add(newPic);
                    leftPos = leftPos + 60;
                }

                if (rows == 3)
                {
                    leftPos = 20;
                    topPos += 60;
                    rows = 0;
                }
            }
            RestartGame();
        }

        private void NewPic_Click(object? sender, EventArgs e)
        {

        }

        private void RestartGame()
        {

        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {

        }
        private void GameOver()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
