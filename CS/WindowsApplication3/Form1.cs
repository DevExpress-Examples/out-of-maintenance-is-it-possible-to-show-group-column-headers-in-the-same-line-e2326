using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace WindowsApplication3
{
    public partial class Form1 : Form
    {
        BindingList<TestData> data;

        public Form1()
        {
            InitializeComponent();
            data = new BindingList<TestData>();
            myGridControl1.DataSource = data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
            myGridView1.CollapseAllGroups();
        }

        public void InitData()
        {
            for (int i = 0; i <= 4; i++)
                data.Add(new TestData() { Column1 = i, Column2 = i, Column3 = i, Column4 = i, Column5 = i, Column6 = i, Column7 = i, Column8 = i, Column9 = i, Column10 = i });
        }
    }

    public class TestData
    {
        public int Column1 { get; set; }
        public int Column10 { get; set; }
        public int Column2 { get; set; }
        public int Column3 { get; set; }
        public int Column4 { get; set; }
        public int Column5 { get; set; }
        public int Column6 { get; set; }
        public int Column7 { get; set; }
        public int Column8 { get; set; }
        public int Column9 { get; set; }
    }
}
