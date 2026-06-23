using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace graduation_work
{
    public partial class Form2 : Form
    {

        

        public Form2()
        {
            InitializeComponent();

            this.Text = "検索画面";

            ComboBoxItemSet();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 各列の文字配置を左寄せに設定
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            // ユーザーには見せないように、image列を非表示にする
            dataGridView1.Columns[4].Visible = false;

            //　コンボボックスの初期項目を空白にする
            cmbOrigin.SelectedIndex = -1;
            cmbHairLength.SelectedIndex = -1;

            //　品種名の初期は空
            txtBreeds.Text = string.Empty;
            //　件数の初期設定
            labelCnt.Text = "0";
        }

        //　検索ボタン
        private void btnSerch_Click(object sender, EventArgs e)
        {
            string Breeds = string.Empty;          //品種名用の変数
            string Origin = string.Empty;          //原産国用の変数
            string HairLength = string.Empty;      //毛並み用の変数
            string Features = string.Empty;        //特徴用の変数
            string picFileName = string.Empty;　　 //image用の変数

            StringBuilder sql = new StringBuilder();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //select文
                    sql.AppendLine(" SELECT cat_master.breeds, ");
                    sql.AppendLine(" origin_master.origin, ");
                    sql.AppendLine(" hairlength_master.hairlength, ");
                    sql.AppendLine(" cat_master.features, ");
                    sql.AppendLine(" cat_master.image ");
                    sql.AppendLine(" FROM cat_master ");
                    sql.AppendLine(" INNER JOIN origin_master ");
                    sql.AppendLine(" ON origin_master.origin_cd = cat_master.origin_cd ");
                    sql.AppendLine(" INNER JOIN hairlength_master ");
                    sql.AppendLine(" ON cat_master.hairlength_cd = hairlength_master.hairlength_cd ");
                    bool flg = false;

                    if (txtBreeds.Text.Trim() != "" && cmbOrigin.Text != "" & cmbHairLength.Text != "")
                    {
                        sql.AppendLine(string.Format(" where cat_master.breeds like'%{0}%'", txtBreeds.Text.Trim()));
                        sql.AppendLine(string.Format(" or origin_master.origin = '{0}'", cmbOrigin.Text));
                        sql.AppendLine(string.Format(" or hairlength_master.hairlength = '{0}'", cmbHairLength.Text));
                    }
                    else
                    {
                        //品種
                        if (txtBreeds.Text.Trim() != "")
                        {
                            sql.AppendLine(string.Format(" where cat_master.breeds like'%{0}%'", txtBreeds.Text.Trim()));
                            flg = true;
                        }

                        //原産国
                        if (cmbOrigin.Text != "")
                        {
                            if (flg == true)
                            {
                                sql.AppendLine(string.Format(" or origin_master.origin = '{0}'", cmbOrigin.Text));
                            }
                            else
                            {
                                sql.AppendLine(string.Format(" where origin_master.origin = '{0}'", cmbOrigin.Text));
                                flg = true;
                            }
                        }

                        //毛並み
                        if (cmbHairLength.Text != "")
                        {
                            if (flg == true)
                            {
                                sql.AppendLine(string.Format(" or hairlength_master.hairlength = '{0}'", cmbHairLength.Text));
                            }
                            else
                            {
                                sql.AppendLine(string.Format(" where hairlength_master.hairlength = '{0}'", cmbHairLength.Text));
                                flg = true;
                            }
                        }
                    }

                    //　品種IDの番号を昇順に並べ替え
                    sql.AppendLine(" ORDER BY breeds_id ASC");

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn))
                        {
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {
                                //dataGridView1の行クリア
                                dataGridView1.Rows.Clear();

                                while (reader.Read())
                                {
                                    Breeds = reader["breeds"].ToString();
                                    Origin = reader["origin"].ToString();
                                    HairLength = reader["hairlength"].ToString();
                                    Features = reader["features"].ToString();
                                    picFileName = reader["image"].ToString();

                                dataGridView1.Rows.Add(Breeds, Origin, HairLength, Features,  picFileName);
                                }
                            }
                        }
                    labelCnt.Text = dataGridView1.RowCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"エラー",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //　クリアボタン
        private void btnClear_Click(object sender, EventArgs e)
        {
            //　コンボボックスの初期項目を空白にする
            cmbOrigin.SelectedIndex = -1;
            cmbHairLength.SelectedIndex = -1;

            //　品種名の初期は空
            txtBreeds.Text = string.Empty;

            //　件数を初期設定"0"にする
            dataGridView1.Rows.Clear();
            labelCnt.Text = "0";
        }

        //　閉じるボタン
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //コンボボックスにデータをセットする
        private void ComboBoxItemSet()
        {
            string sql = "";

            //原産国(cmbOrigin)のデータをセット
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try{
                    conn.Open();

                    //コンボボックスクリア
                    cmbOrigin.Items.Clear();

                    //コンボボックスに空をセット
                    cmbOrigin.Items.Add("");

                    sql = "select origin from origin_master";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using(var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) 
                            {
                                //コンボボックスに項目を追加
                                cmbOrigin.Items.Add(reader["Origin"].ToString());
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"エラー",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }

            //毛並み(cmbHairLemgth)のデータをセット
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //コンボボックスクリア
                    cmbHairLength.Items.Clear();

                    //コンボボックスに空をセット
                    cmbHairLength.Items.Add("");

                    sql = "select hairlength from hairlength_master";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                //コンボボックスに項目を追加
                                cmbHairLength.Items.Add(reader["HairLength"].ToString());
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //　削除画面へ（遷移）ボタン
        private void btnDelet_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }


        //　imageの挿入
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // 何も選択されていない場合や、複数行選択されている場合は処理しない
            if (dataGridView1.SelectedRows.Count != 1)
            {
                picBox.Image = null;
                return;
            }

            // 選択された行を取得
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            // セルの値を各テキストボックスに割り当てる
            txtBreeds2.Text = row.Cells[0].Value.ToString();
            txtOrigin.Text = row.Cells[1].Value.ToString();
            txtHairLength.Text = row.Cells[2].Value.ToString();

            string fileName = row.Cells[3].Value?.ToString() ?? string.Empty;

            if (!string.IsNullOrEmpty(fileName))
            {
                // 写真が置いてある場所のパスを作る
                string fullPath = System.IO.Path.Combine(Application.StartupPath, "images", fileName);

                // 念のためファイルが本当にそこにあれば表示する
                if (System.IO.File.Exists(fullPath))
                {
                    picBox.Image = Image.FromFile(fullPath);
                }
                else
                {
                    picBox.Image = null; // 写真ファイル自体がなければ空にする
                }
            }
            else
            {
                picBox.Image = null; // データにファイル名がなければ空にする
            }
        }


        //　追加画面へ（遷移）ボタン
        private void btnAddition_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();
        }
    }
}
