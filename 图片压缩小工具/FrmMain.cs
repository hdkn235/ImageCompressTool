using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace 图片压缩小工具
{
    public partial class FrmMain : Form
    {
        //注册表 目录的名称
        private static readonly string item = "ImgCompressTool";
        //压缩图片的线程
        private Thread thCompress = null;
        private delegate void myDelegate(int x, int y);

        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加文件按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "图像文件(*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BindingList<ImageEntity> list = GetImageList(ofd.FileNames);
                if (list.Count > 0)
                {
                    dgvFileList.DataSource = list;
                    for (int i = 0; i < dgvFileList.Rows.Count; i++)
                    {
                        dgvFileList.Rows[i].Cells["Sel"].Value = "1";
                    }
                }
            }
        }

        /// <summary>
        /// 得到图片对象列表
        /// </summary>
        /// <param name="filesPath"></param>
        /// <returns></returns>
        private BindingList<ImageEntity> GetImageList(string[] filesPath)
        {
            BindingList<ImageEntity> list = new BindingList<ImageEntity>();
            if (dgvFileList.Rows.Count > 0)
            {
                list = dgvFileList.DataSource as BindingList<ImageEntity>;
            }
            foreach (string filePath in filesPath)
            {
                if ("*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG;".Contains(Path.GetExtension(filePath).ToUpper()))
                {
                    ImageEntity img = new ImageEntity();
                    img.ImgName = Path.GetFileName(filePath);
                    img.ImgPath = filePath;
                    list.Add(img);
                }
            }
            return list;
        }

        /// <summary>
        /// 添加文件夹按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string floderPath = fbd.SelectedPath;
                BindingList<ImageEntity> list = GetImageList(Directory.GetFiles(floderPath));
                if (list.Count > 0)
                {
                    dgvFileList.DataSource = list;
                    for (int i = 0; i < dgvFileList.Rows.Count; i++)
                    {
                        dgvFileList.Rows[i].Cells["Sel"].Value = "1";
                    }
                }
            }
        }

        /// <summary>
        /// 删除选中项按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelSel_Click(object sender, EventArgs e)
        {
            for (int i = dgvFileList.Rows.Count - 1; i >= 0; i--)
            {
                if (dgvFileList.Rows[i].Cells["Sel"].Value != null && dgvFileList.Rows[i].Cells["Sel"].Value.ToString() == "1")
                {
                    dgvFileList.Rows.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// 清空列表按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvFileList.Rows.Clear();
        }

        /// <summary>
        /// 全选checkbox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSelAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvFileList.Rows.Count; i++)
            {
                dgvFileList.Rows[i].Cells["Sel"].Value = cbSelAll.Checked ? "1" : "0";
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < gbSelSaveType.Controls.Count; i++)//将它们放入容器里
            {
                if (gbSelSaveType.Controls[i] is RadioButton)
                {
                    RadioButton temp = (RadioButton)gbSelSaveType.Controls[i];
                    if (temp.Tag.ToString() == CommonHelper.GetValue(item, SetKey.SaveType))
                    {
                        temp.Checked = true;
                        break;
                    }
                }
            }
            numLimitSize.Value = Convert.ToInt32(CommonHelper.GetValue(item, SetKey.LimitSize));
            numPercent.Value = Convert.ToInt32(CommonHelper.GetValue(item, SetKey.Percent));
        }

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegisterHelper rh = new RegisterHelper();
            string saveType = "";
            for (int i = 0; i < gbSelSaveType.Controls.Count; i++)//将它们放入容器里
            {
                if (gbSelSaveType.Controls[i] is RadioButton)
                {
                    RadioButton temp = (RadioButton)gbSelSaveType.Controls[i];
                    if (temp.Checked)//判断是否选中
                    {
                        saveType = temp.Tag.ToString();
                    }
                }
            }
            CommonHelper.SetValue(item, SetKey.SaveType, saveType);
            CommonHelper.SetValue(item, SetKey.LimitSize, numLimitSize.Value.ToString());
            CommonHelper.SetValue(item, SetKey.Percent, numPercent.Value.ToString());
        }

        /// <summary>
        /// 浏览按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtOtherFolder.Text = fbd.SelectedPath;
            }
        }

        /// <summary>
        /// 开始压缩按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCompress_Click(object sender, EventArgs e)
        {
            if (btnStartCompress.Text == "停止压缩")
            {
                btnStartCompress.Text = "开始压缩";
                thCompress.Abort();
                return;
            }

            List<string> list = new List<string>();
            if (Check(out list))
            {
                btnStartCompress.Text = "停止压缩";

                if (list.Count > 0)
                {
                    try
                    {
                        string targetPath = "";
                        string saveType = "";

                        if (rbtnSaveOther.Checked == true)
                        {
                            saveType = rbtnSaveOther.Tag.ToString();
                            targetPath = txtOtherFolder.Text;
                            if (!Directory.Exists(targetPath))
                            {
                                Directory.CreateDirectory(targetPath);
                            }
                        }
                        else if (rbtnSaveSelf.Checked == true)
                        {
                            saveType = rbtnSaveSelf.Tag.ToString();
                        }

                        pbCompress.Maximum = list.Count;
                        pbCompress.Value = 0;

                        lblProgess.Text = "开始压缩";

                        thCompress = new Thread(delegate() { StartCompress(list.ToArray(), saveType, targetPath, Convert.ToInt32(numLimitSize.Value), Convert.ToDouble(numPercent.Value) / 100); });
                        thCompress.Name = "CompressImage";
                        thCompress.IsBackground = true;
                        thCompress.Start();
                    }
                    catch (Exception ex)
                    {
                        btnStartCompress.Text = "开始压缩";
                        thCompress.Abort();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 检查并初始化
        /// </summary>
        /// <returns></returns>
        private bool Check(out List<string> list)
        {
            list = new List<string>();
            if (rbtnSaveOther.Checked == true)
            {
                if (string.IsNullOrEmpty(txtOtherFolder.Text))
                {
                    MessageBox.Show("请选择保存路径！");
                    return false;
                }
            }

            for (int i = 0; i < dgvFileList.Rows.Count; i++)
            {
                if (dgvFileList.Rows[i].Cells["Sel"].Value != null && dgvFileList.Rows[i].Cells["Sel"].Value.ToString() == "1")
                {
                    list.Add(dgvFileList.Rows[i].Cells["ImgPath"].Value.ToString());
                }
            }
            if (list.Count == 0)
            {
                MessageBox.Show("请选择需要压缩的图片！");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 开始压缩
        /// </summary>
        /// <param name="paths"></param>
        public void StartCompress(string[] paths, string saveType, string targetPath, int limitSize, double percent)
        {
            string path = "";
            for (int i = 0; i < paths.Length; i++)
            {
                if (saveType == "1")
                {
                    path = Path.Combine(targetPath, Path.GetFileNameWithoutExtension(paths[i]) + ".jpg");
                }
                else
                {
                    path = paths[i];
                }

                FileInfo f = new FileInfo(paths[i]);
                if (f.Length < limitSize * 1024 && saveType == "1")
                {
                    f.CopyTo(path, true);
                    continue;
                }

                ImageHelper ih = new ImageHelper(paths[i]);

                while (f.Length > limitSize * 1024)
                {
                    if (ih.PercentImage(percent, path))
                    {
                        f = new FileInfo(path);
                        ih = new ImageHelper(path);
                    }
                    else
                    {
                        MessageBox.Show(ih.ErrMessage);
                        return;
                    }
                }

                SetCount(paths.Length, i);
            }

            SetFinishState(paths.Length);
        }

        /// <summary>
        /// “保存到另一个文件夹” checkbox事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnSaveOther_CheckedChanged(object sender, EventArgs e)
        {
            btnBrowse.Enabled = txtOtherFolder.Enabled = rbtnSaveOther.Checked;
        }

        /// <summary>
        /// 跨线程调用控件 设置发送状态
        /// </summary>
        /// <param name="total">总数</param>
        /// <param name="index">第几个</param>
        private void SetCount(int total, int index)
        {
            if (pbCompress.InvokeRequired)
            {
                myDelegate a = SetCount;
                this.Invoke(a, total, index);
            }
            else
            {
                pbCompress.Value += 1;
                lblProgess.Text = string.Format("总共{0}张图片，已压缩{1}张", total, index + 1);
            }
        }

        /// <summary>
        /// 设置压缩结束时状态
        /// </summary>
        /// <param name="total"></param>
        private void SetFinishState(int total)
        {
            if (lblProgess.InvokeRequired)
            {
                Action<int> a = SetFinishState;
                this.Invoke(a, total);
            }
            else
            {
                lblProgess.Text = "压缩成功完成，共压缩" + total + "张图片";
                btnStartCompress.Text = "开始压缩";
                pbCompress.Value = 0;
                thCompress.Abort();
            }
        }
    }
}
