using System;
using System.Windows.Forms;
using OrmTest.DAL;

namespace OrmTest
{
    public partial class Form1 : Form
    {
        private IDAL _dapperDAL;
        private IDAL _efDAL;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dapperDAL = new DapperDAL();
            _efDAL     = new EfDAL();
        }

        public int Count { get; private set; } = 1000;

        private void btnDapper_Click(object sender, EventArgs e)
        {
            var action = new Action(() =>
                                    {
                                        for ( var i = 0; i < Count; i++ )
                                        {
                                            _dapperDAL = new DapperDAL();
                                            _dapperDAL.Get();
                                        }
                                    });
            var elapsedResult = InvokeTimer(action);
            lblResult.Text = elapsedResult.ToString();
        }

        private void btnEF_Click(object sender, EventArgs e)
        {
            var action = new Action(() =>
                                    {
                                        for ( var i = 0; i < Count; i++ )
                                        {
                                            _efDAL = new EfDAL();
                                            _efDAL.Get();
                                        }
                                    });
            var elapsedResult = InvokeTimer(action);
            lblResult.Text = elapsedResult.ToString();
        }

        private long InvokeTimer(Action action)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Restart();
            //此處放測試的部份
            action.Invoke();

            //測試結束
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }



    }
}
