using System.Collections;
namespace arduino_robot_controller
{
    public partial class Form1 : Form
    {
        private ReadController controller = new ReadController();
        private bool enabled = false;
        bool[] buttons;
        int[] axies;

        public Form1()
        {
            controller.Start();
            InitializeComponent();
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 10;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
            EnabledText.Text = "Disabled";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttons = controller.GetButtons();
            axies = controller.GetAxies();
            for (int i = 0; i < buttons.Length; i++)
            {
                checkedListBox1.Items.Add(new CheckBox());
                checkedListBox1.Height = (checkedListBox1.Items.Count + 1) * checkedListBox1.ItemHeight;
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            buttons = controller.GetButtons();
            axies = controller.GetAxies();
            for(int i = 0; i < buttons.Length; i++)
            {
                checkedListBox1.SetItemChecked(i, buttons[i]);
            }
        }

        private void SendData()
        {
            //TODO: make this work
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            EnabledText.Text = "Enabled";
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            EnabledText.Text = "Disabled";
        }
    }
}