using System.Threading;
using System.Windows.Forms;

namespace Loading
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnLoading_Click(object sender, System.EventArgs e)
        {
            LoadingHelper.ShowLoading("有朋自远方来，不亦乐乎。", this, o =>
            {
                //这里写处理耗时的代码，代码处理完成则自动关闭该窗口
                Thread.Sleep(10000);
            });
        }
    }
}
