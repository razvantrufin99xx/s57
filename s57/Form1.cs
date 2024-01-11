namespace s57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public aps theaps = new aps();

        private void Form1_Load(object sender, EventArgs e)
        {
            theaps.pbs.Add(new pb("pb1"));
            this.Text = theaps.denumire;
            this.Text += " , ";
            this.Text += theaps.pbs[0].denumire;


            //from pinslist or add new like this
            theaps.pbs[0].thegateslist.Add(new gate("AND", "AND", 10, 10, 100, 100));
            theaps.pbs[0].thegateslist[0].InputPins.Add(new pin("I0.0", 10, 10));
            theaps.pbs[0].thegateslist[0].InputPins.Add(new pin("I0.1", 10, 30));
            theaps.pbs[0].thegateslist[0].OutputPins.Add(new pin("O0.0", 110, 100));
            //take the pins from pinslist
            theaps.pbs[0].thefunctionItems.Add(new functionItem("ANDi00i01o00", "AND"));
            theaps.pbs[0].thefunctionItems[0].InputPins.Add(0);
            theaps.pbs[0].thefunctionItems[0].InputPins.Add(1);
            theaps.pbs[0].thefunctionItems[0].OutputPins.Add(2);

        }
    }
}
