using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //設定クラスのオブジェクトを生成
        Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }
        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = string.Empty;

            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }
            var carReport = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };

            listCarReports.Add(carReport);

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.ClearSelection();//セルの選択を解除する
            InputItemsUpdate();
        }


        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return MakerGroup.トヨタ;
            }
            if (rbNissan.Checked) {
                return MakerGroup.日産;
            }
            if (rbHonda.Checked) {
                return MakerGroup.ホンダ;
            }
            if (rbSubaru.Checked) {
                return MakerGroup.スバル;
            }
            if (rbimport.Checked) {
                return MakerGroup.輸入車;
            }
            return MakerGroup.その他;
        }

        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            InputItemAllClear();
        }


        private void InputItemAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pbPicture.Image = null;

            dgvRecords.ClearSelection();//セルの選択を解除する
        }


        private void SetRadioButtonMaker(MakerGroup maker) {
            switch (maker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbimport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }
        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeleteRecord_Click(object sender, EventArgs e) {
            //RemoveAt(消したい場所のインデックス番号)
            if ((dgvRecords.CurrentRow is null) ||
                    (!dgvRecords.CurrentRow.Selected)) return;

            listCarReports.RemoveAt(dgvRecords.CurrentRow.Index);

            //ImputItemsUpdate();

        }

        private void InputItemsUpdate() {
            if (!dgvRecords.CurrentRow.Selected)
                InputItemAllClear();
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {
            if (dgvRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを提出してください";
                return;
            }
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }
            listCarReports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value.Date;
            listCarReports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text.Trim();
            listCarReports[dgvRecords.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text.Trim();
            listCarReports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbAuthor(cbCarName.Text.Trim());

            dgvRecords.Refresh();  //データグリッドビューの更新
            tsslbMessage.Text = "レポートを修正しました";
        }

        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {
            if ((dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
                || (!dgvRecords.CurrentRow.Selected)) return;



            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;

            InputItemsUpdate();//データグリッドビューを更新したら呼ぶメソッド
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
            }
        }

        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）
            //284以降を参考にする（ファイル名:setting.xml）
            using(var writer = XmlWriter.Create("setting.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }
    }
}
