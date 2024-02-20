namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top = 0;
            int left = 0;   
            for(int i = 0; i<buttons.GetUpperBound(0); i++) // 0. boyutun alailece�i max de�er
            { 
                for(int j = 0; j<buttons.GetUpperBound(1);  j++) // 1. boyutun alaca�� max de�er
                {
                    buttons[i, j] = new Button(); // Her seferinde newlemek gerek ��nk� olu�an butonlar her zaman yeni bir butondur.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left; // Soldan uzakl�k
                    buttons[i, j].Top = top;
                    left += 50;
                    if ((i + j)%2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }

                top += 50; // Butonun yukardan uzakl���
                left = 0;
            }
            

        }
    }
}