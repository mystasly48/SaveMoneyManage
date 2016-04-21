using System;
using System.Windows.Forms;
using SaveMoneyManage.Properties;

namespace SaveMoneyManage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        // oneLabel = １円玉
        // fiveLabel = ５円玉
        // tenLabel = １０円玉
        // totalLabel = 合計金額
        // oneNumeric = １円玉
        // fiveNumeric = ５円玉
        // tenNumeric = １０円玉
        // saveBtn = 保存

        Settings settings = new Settings();

        private void Form1_Load(object sender, EventArgs e) {
            oneLabel.Text = settings.oneLabel;
            fiveLabel.Text = settings.fiveLabel;
            tenLabel.Text = settings.tenLabel;
            totalLabel.Text = settings.totalLabel;
            oneNumeric.Value = settings.oneNumeric;
            fiveNumeric.Value = settings.fiveNumeric;
            tenNumeric.Value = settings.tenNumeric;
        }

        // 保存　クリック
        private void button1_Click(object sender, EventArgs e) {
            SaveChanges();
        }

        // １円玉　増減
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
            UpdateValue(1, oneNumeric, oneLabel);
        }

        // ５円玉　増減
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) {
            UpdateValue(5, fiveNumeric, fiveLabel);
        }

        // １０円玉　増減
        private void numericUpDown3_ValueChanged(object sender, EventArgs e) {
            UpdateValue(10, tenNumeric, tenLabel);
        }

        // 増減計算
        private void UpdateValue(Int32 coin, NumericUpDown numericUpDown, Label label) {
            var value = Convert.ToInt32(numericUpDown.Value);
            var money = value * coin;
            label.Text = money.ToString();

            var one = Convert.ToInt32(oneLabel.Text);
            var five = Convert.ToInt32(fiveLabel.Text);
            var ten = Convert.ToInt32(tenLabel.Text);

            var total = one + five + ten;

            totalLabel.Text = total.ToString();
        }

        // 保存
        private void SaveChanges() {
            settings.oneLabel = oneLabel.Text;
            settings.fiveLabel = fiveLabel.Text;
            settings.tenLabel = tenLabel.Text;
            settings.totalLabel = totalLabel.Text;
            settings.oneNumeric = oneNumeric.Value;
            settings.fiveNumeric = fiveNumeric.Value;
            settings.tenNumeric = tenNumeric.Value;
            settings.Save();
        }

        //　閉じる　クリック
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // 変更されているが保存をされていない場合に警告を表示
            //var result = MessageBox.Show("変更内容を保存しますか？",
            //    "確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes) {
            //     保存
            //    saveChanges();
            //} else if (result == DialogResult.No) {
            //     保存しない
            //} else if (result == DialogResult.Cancel) {
            //     キャンセル
            //    e.Cancel = true;
            //}
        }
    }
}
