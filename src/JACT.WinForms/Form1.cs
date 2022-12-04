namespace JACT.WinForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void form1_Resize(object sender, EventArgs e)
    {
        splitContainer1.SplitterDistance = this.Width / 2;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void toolStripProgressBar1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click_1(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        var result = folderBrowserDialog1.ShowDialog();
    }

    private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
    {

    }
}