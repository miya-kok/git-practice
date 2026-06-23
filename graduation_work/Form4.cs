using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduation_work
{
    public partial class Form4 : Form
    {

        

        // コンボボックス用にKey(Code)とValue(Name)を保持するクラス
        public class ComboItem
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public ComboItem(string code, string name)
            {
                Code = code;
                Name = name;
            }

            // コンボボックスの画面上に表示されるテキストを決定するメソッド
            public override string ToString()
            {
                return Name;
            }
        }
        public Form4()
        {
            InitializeComponent();
            this.Text = "追加画面";
            ComboBoxItemSet();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtOthers.Enabled = false;
        }

        private void btnAddition2_Click(object sender, EventArgs e)
        {

            if (txtAddBreeds.Text.Trim() == string.Empty)
            {
                MessageBox.Show("品種名が未入力です。","警告",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtAddBreeds.Focus();
                return;
            }

            if (cmbOrigin.SelectedItem == null || cmbOrigin.SelectedIndex <= 0)
            {
                MessageBox.Show("原産国が未選択です。", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbOrigin.Focus();
                return;
            }

            if (cmbHairLength.SelectedItem == null || cmbHairLength.SelectedIndex <= 0)
            {
                MessageBox.Show("毛並みが未選択です。", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbHairLength.Focus();
                return;
            }


                // 画面から「文字列（テキスト）」取得
                string breedName = txtAddBreeds.Text.Trim();

                // 特長欄（txtOthers）の入力を取得
                string otherText = txtOthers.Text.Trim();

                // コンボボックスから選択された「オブジェクト」を型変換して、
                // Code(Key) と Name(Value) を取得する
                ComboItem selectedOrigin = (ComboItem)cmbOrigin.SelectedItem;
                ComboItem selectedHair = (ComboItem)cmbHairLength.SelectedItem;

                string originCode = selectedOrigin.Code;
                string originName = selectedOrigin.Name;
                string hairlengthCode = selectedHair.Code; 
                string hairlengthName = selectedHair.Name;


            // SELECT文を用いて重複チェック
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    try
                    {

                        conn.Open();
                        string sql = "SELECT breeds FROM cat_master WHERE breeds = @breeds;";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                         {
                            cmd.Parameters.AddWithValue("@breeds", breedName);
                       
                            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                            {

                                    if (reader.Read())
                                    {
                                        MessageBox.Show("この品種名はすでに登録されています。", "警告",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txtAddBreeds.Focus();
                                        return;
                                    }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("重複中にエラーが発生しました。\nエラー内容: " + ex.Message, "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // INSERT分を用いてデータベースに追加
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (NpgsqlTransaction tran = conn.BeginTransaction())
                        {
                            string sql2 = "INSERT INTO cat_master(breeds, origin_cd, hairlength_cd, features) VALUES(@breeds, @origin, @hairlength, @features);";

                            using (NpgsqlCommand cmd = new NpgsqlCommand(sql2, conn, tran))
                            {
                                cmd.Parameters.AddWithValue("@breeds", breedName);
                                cmd.Parameters.AddWithValue("@origin", int.Parse(originCode));
                                cmd.Parameters.AddWithValue("@hairlength", int.Parse(hairlengthCode));

                                if (string.IsNullOrEmpty(otherText))
                                {
                                    cmd.Parameters.AddWithValue("@features", DBNull.Value);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@features", otherText);
                                }

                                // SQLを実行（追加処理）
                                cmd.ExecuteNonQuery();
                            }
                            tran.Commit();
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("登録に失敗しました。\nエラー内容: " + ex2.Message, "エラー",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // データグリッドビューに新しい行を追加
                dataGridView3.Rows.Add(breedName, originName, hairlengthName);


                // 入力欄のリセット
                txtAddBreeds.Text = string.Empty;
                txtOthers.Text = string.Empty;
                cmbOrigin.SelectedIndex = 0; 
                cmbHairLength.SelectedIndex = 0; ;

                // グリッドの選択状態を一度クリアする
                dataGridView3.ClearSelection();

                MessageBox.Show("追加が完了しました。", "完了",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        
        //コンボボックスにデータをセットする
        private void ComboBoxItemSet()
        {

            //原産国(cmbOrigin)のデータをセット
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //コンボボックスクリア
                    cmbOrigin.Items.Clear();

                    //コンボボックスに空をセット
                    cmbOrigin.Items.Add(new ComboItem("", ""));

                    string sql = "SELECT origin_cd, origin FROM origin_master";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string code = reader["origin_cd"].ToString();
                                string name = reader["origin"].ToString();
                                cmbOrigin.Items.Add(new ComboItem(code, name));
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

            //毛並み(cmbHairLemgth)のデータをセット
            using (var conn = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //コンボボックスクリア
                    cmbHairLength.Items.Clear();

                    //コンボボックスに空をセット
                    cmbHairLength.Items.Add(new ComboItem("", ""));

                    string sql = "SELECT hairlength_cd, hairlength FROM hairlength_master";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string code = reader["hairlength_cd"].ToString();
                                string name = reader["hairlength"].ToString();
                                cmbHairLength.Items.Add(new ComboItem(code, name));
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

        private void btnClose3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleOtherTextBox();
        }

        private void cmbHairLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleOtherTextBox();
        }

        private void ToggleOtherTextBox()
        {
            // 1. 初期状態として、それぞれ「その他ではない」と仮定しておく
            bool isOriginOther = false;
            bool isHairOther = false;

            // 2. 原産国コンボボックスのチェック
            if (cmbOrigin.SelectedItem != null)
            {
                // 選択されている中身をComboItem型に変換
                ComboItem selectedOrigin = (ComboItem)cmbOrigin.SelectedItem;
                // 名前が「その他」なら、フラグを true にする
                if (selectedOrigin.Name == "その他")
                {
                    isOriginOther = true;
                }
            }

            // 3. 毛並みコンボボックスのチェック
            if (cmbHairLength.SelectedItem != null)
            {
                // 選択されている中身をComboItem型に変換
                ComboItem selectedHair = (ComboItem)cmbHairLength.SelectedItem;
                // 名前が「その他」なら、フラグを true にする
                if (selectedHair.Name == "その他")
                {
                    isHairOther = true;
                }
            }

            // 4. 最終判定：どちらか一方でも「その他」ならテキストボックスを有効にする
            if (isOriginOther || isHairOther)
            {
                txtOthers.Enabled = true;

                // 入力欄がまだ空っぽのときだけ、ユーザーがすぐ打てるようにカーソルを合わせる
                if (string.IsNullOrEmpty(txtOthers.Text))
                {
                    txtOthers.Focus();
                }
            }
            else
            {
                // どちらも「その他」じゃないなら、テキストボックスを無効化して文字を消す
                txtOthers.Enabled = false;
                txtOthers.Text = string.Empty;
            }
        }
    }
}
