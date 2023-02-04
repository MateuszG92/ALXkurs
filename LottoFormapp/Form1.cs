using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LottoFormapp
{
    public partial class Form1 : Form
    {
        private StringBuilder ChosenNumbers;
        private StringBuilder DrawnNumbers;
        private List<int> ChosenNumberList=new List<int>();
        private List<int> DrawnNumbersList = new List<int>();
        private List<int> AllNumbers=new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49};
        private int numberOfChosenNumbers = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            ChosenNumbers = new StringBuilder();
            DrawnNumbers = new StringBuilder();
        }

        void DrawingNumbers()
        {
            DrawnNumbersList.Clear();
            DrawnNumbers.Clear();
            DrawnNumbersTextbox.Text = DrawnNumbers.ToString();
            for (int i = 0; i < 6; i++)
            {
                var index = random.Next(0, AllNumbers.Count);
                DrawnNumbersList.Add(AllNumbers[index]);
                DrawnNumbers.Append(AllNumbers[index] + " ");
                DrawnNumbersTextbox.Text = DrawnNumbers.ToString();
                AllNumbers.Remove(AllNumbers[index]);
            }
            foreach  (var item in DrawnNumbersList)
            {
                AllNumbers.Add(item);
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            if (ChosenNumberList.Count == 6)
            {
                DrawingNumbers();
            }
            else
            {
                DrawnNumbersTextbox.Text = "Najpierw wybierz 6 liczb";
            }
            WinTextbox.Text = "Wciœnij przycisk by sprawdziæ czy wygra³eœ.";
        }

        private void NumberButtons_Click(object sender, EventArgs e)
        {
            numberOfChosenNumbers++;
            if (numberOfChosenNumbers <= 6)
            {
                Button button = (Button)sender;
                ChosenNumbers.Append(button.TabIndex+" ");
                ChosenNumberList.Add(button.TabIndex);
                ChosenNumberTextbox.Text = ChosenNumbers.ToString();
                button.Enabled=false;
            }
            else
            {
                WinTextbox.Text = "Ju¿ wybra³eœ 6 liczb. Wciœnij LOSUJ";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void CheckingButton_Click(object sender, EventArgs e)
        {
            int winningTier = 0;
            foreach (var item in ChosenNumberList)
            {
                if (DrawnNumbersList.Contains(item))
                {
                    winningTier++;
                }
            }
            switch (winningTier)
            {
            case 0:
                WinTextbox.Text = "Nastêpnym razem siê uda. Wrzuæ monetê.";
                break;
            case 1:
                WinTextbox.Text = "Trafi³eœ jedn¹ liczbe. Wygrywasz - NIC.";
                break;
            case 2:
                WinTextbox.Text = "Trafi³eœ dwie liczby. Wygrywasz - NIC.";
                break;
            case 3:
                WinTextbox.Text = "Trafi³eœ trójkê. Zwróci³ Ci sie kupon.";
                break;
            case 4:
                WinTextbox.Text = "Trafi³eœ czwórkê. Coœ tam wygra³eœ.";
                break;
            case 5:
                WinTextbox.Text = "Trafi³eœ PIÊÆ liczb. Jesteœ bogaty.";
                break;
            case 6:
                WinTextbox.Text = "ROZBIJASZ BANK";
                break;
            }
        }
    }
}