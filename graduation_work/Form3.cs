using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace graduation_work
{
    public partial class Form3 : Form
    {

        

        public Form3()
        {
            InitializeComponent();

            this.Text = "削除画面";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (dataGridView2.Columns.Count >= 4)
            {
                // ユーザーには見せないように、IDの列(一番左)を非表示にする
                dataGridView2.Columns[0].Visible = false;


                // 各列の文字配置を左寄せに設定
                dataGridView2.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGridView2.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            //品種名の初期は空
            txtBreeds.Text = string.Empty;
            //件数の初期設定は0
            labelCnt.Text = "0";
        }

        private void btnSerch2_Click(object sender, EventArgs e)
        {
            string Breeds_id = string.Empty;    //品種番号用の変数
            string Breeds = "";                 //品種名用の変数
            string Origin = "";                 //原産国用の変数
            string HairLength = "";             //毛並み用の変数

            StringBuilder sql = new StringBuilder();

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //select文
                    sql.AppendLine(" select cat_master.breeds_id, ");
                    sql.AppendLine(" cat_master.breeds, ");
                    sql.AppendLine(" origin_master.origin, ");
                    sql.AppendLine(" hairlength_master.hairlength ");
                    sql.AppendLine(" from cat_master ");
                    sql.AppendLine(" inner join origin_master ");
                    sql.AppendLine(" on origin_master.origin_cd = cat_master.origin_cd ");
                    sql.AppendLine(" inner join hairlength_master ");
                    sql.AppendLine(" on cat_master.hairlength_cd = hairlength_master.hairlength_cd ");

                    if (txtBreeds.Text.Trim() != "")
                    {
                        sql.AppendLine(string.Format(" where cat_master.breeds like '%{0}%'", txtBreeds.Text.Trim()));
                    }

                    //　品種IDの番号を昇順に並べ替え
                    sql.AppendLine(" ORDER BY breeds_id ASC");

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql.ToString(), conn))
                    {

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            //dataGridViewの行クリア
                            dataGridView2.Rows.Clear();

                            while (reader.Read())
                            {
                                Breeds_id = reader["breeds_id"].ToString();
                                Breeds = reader["breeds"].ToString();
                                Origin = reader["origin"].ToString();
                                HairLength = reader["hairlength"].ToString();

                                // 非表示の0番目の列に「Breeds_id」を隠し持たせる
                                dataGridView2.Rows.Add(Breeds_id, Breeds, Origin, HairLength);
                            }
                        }
                    }
                    labelCnt.Text = dataGridView2.RowCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "エラー",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            // 何も選択されていない場合や、複数行選択されている場合は処理しない
            if (dataGridView2.SelectedRows.Count != 1) return;

            // 選択された行を取得
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            // セルの値を各テキストボックスに割り当てる
            txtDelBreeds.Text = row.Cells[1].Value.ToString();
            txtDelOrigin.Text = row.Cells[2].Value.ToString();
            txtDelHairLength.Text = row.Cells[3].Value.ToString();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtBreeds.Text = string.Empty;
            dataGridView2.Rows.Clear();
            labelCnt.Text = "0";
            txtDelBreeds.Text = string.Empty;
            txtDelOrigin.Text = string.Empty;
            txtDelHairLength.Text = string.Empty;
        }

        private void btnDelet2_Click(object sender, EventArgs e)
        {
            // そもそも削除対象が選択されていない場合は処理を中断
            if (dataGridView2.SelectedRows.Count != 1)
            {
                MessageBox.Show("削除する行を選択してください。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult result = MessageBox.Show("本当に削除しますか？","確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 現在選択されている行の「0番目のセル（隠してあるbreeds_id）」を取得
                string targetId = dataGridView2.CurrentRow.Cells[0].Value.ToString();

                // イベントを一時的に切り離す
                dataGridView2.SelectionChanged -= dataGridView2_SelectionChanged;

                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (NpgsqlTransaction tran = conn.BeginTransaction())
                        {
                            string sql = "DELETE FROM cat_master WHERE breeds_id = @breeds_id";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                            {
                                try
                                {
                                    cmd.Parameters.AddWithValue("@breeds_id", int.Parse(targetId));
                                    cmd.ExecuteNonQuery();
                                    tran.Commit();

                                    MessageBox.Show("削除しました！", "情報",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show(ex2.Message, "エラー",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    // エラーが起きたら、画面から消さずに処理を終わらせる
                                    dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;
                                    return;
                                }
                            }
                        }
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message, "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                        //データグリッドビューから選択された行を消す
                        int rowIndex = dataGridView2.CurrentRow.Index;
                        dataGridView2.Rows.RemoveAt(rowIndex);

                        //テキストボックスの文字をすべて消す
                        txtDelBreeds.Text = string.Empty;
                        txtDelOrigin.Text = string.Empty;
                        txtDelHairLength.Text = string.Empty;

                        //どの行も選ばれていない状態にする
                        dataGridView2.ClearSelection();

                        //件数表示を更新する
                        labelCnt.Text = dataGridView2.RowCount.ToString();

                        //処理が終わったら、イベントを元の状態に戻す
                        dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

            }
            else
            {
                MessageBox.Show("キャンセルされました。","キャンセル",
                    MessageBoxButtons.OK,MessageBoxIcon.Information);
            } 
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
