namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangePositionButton_Click(object sender, EventArgs e)
        {
            Random randomPosition=new Random();
            var xPosition=randomPosition.NextInt64(1,300);
            var yPoistion = randomPosition.NextInt64(1, 300);
            this.ChangePositionButton.Location = new Point((int)xPosition, (int)yPoistion);
        }
    }
}