namespace arduino_robot_controller
{
    public partial class Form1 : Form
    {
        private ReadController controller = new ReadController();

        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
            tmr.Interval = 50;   // milliseconds
            tmr.Tick += Tmr_Tick;  // set handler
            tmr.Start();
            controller.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Tmr_Tick(object sender, EventArgs e)  //run this logic each timer tick
        {
            Console.WriteLine(controller.a);
            Console.WriteLine(controller.x);
        }

    }
}