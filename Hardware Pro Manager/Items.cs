using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Hardware_Pro_Manager
{
    public partial class Items : Form
    {
        // 'key' will store the ID of the selected item for updates/deletes.
        int key = 0;

        public Items()
        {
            InitializeComponent();
            FillGrid(); // Load data when the form opens.
        }

        // --- DATA & HELPER METHODS ---

        void FillGrid()
        {
            string query = "SELECT ItId, ItName, ItCat, ItType, ItPrice, ItQty FROM ItemTbl";
            ItemDGV.DataSource = DbHelper.ExecuteQuery(query);
        }

        void Reset()
        {
            ItName.Text = "";
            CatCp.SelectedIndex = -1; // Clear selection
            TypeCb.SelectedIndex = -1; // Clear selection
            PriceTb.Text = "";
            QtyTb.Text = "";
            key = 0;
        }

        void SaveItem()
        {
            // Secure query with placeholders
            string query = "INSERT INTO ItemTbl (ItName, ItCat, ItType, ItPrice, ItQty) VALUES (@Name, @Cat, @Type, @Price, @Qty)";
            
            // Create parameters to safely pass values
            SqlParameter[] parameters = {
                new SqlParameter("@Name", ItName.Text),
                new SqlParameter("@Cat", CatCp.SelectedItem.ToString()),
                new SqlParameter("@Type", TypeCb.SelectedItem.ToString()),
                new SqlParameter("@Price", Convert.ToInt32(PriceTb.Text)),
                new SqlParameter("@Qty", Convert.ToInt32(QtyTb.Text))
            };
            
            DbHelper.ExecuteNonQuery(query, parameters);
            
            MessageBox.Show("Item Saved!");
            FillGrid();
            Reset();
        }

        void UpdateItem()
        {
            // Secure query with placeholders
            string query = "UPDATE ItemTbl SET ItName = @Name, ItCat = @Cat, ItType = @Type, ItPrice = @Price, ItQty = @Qty WHERE ItId = @Key";
            
            SqlParameter[] parameters = {
                new SqlParameter("@Name", ItName.Text),
                new SqlParameter("@Cat", CatCp.SelectedItem.ToString()),
                new SqlParameter("@Type", TypeCb.SelectedItem.ToString()),
                new SqlParameter("@Price", Convert.ToInt32(PriceTb.Text)),
                new SqlParameter("@Qty", Convert.ToInt32(QtyTb.Text)),
                new SqlParameter("@Key", key)
            };
            
            DbHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Item Updated!");
            FillGrid();
            Reset();
        }

        void DeleteItem()
        {
            string query = "DELETE FROM ItemTbl WHERE ItId = @Key";
            SqlParameter[] parameters = { new SqlParameter("@Key", key) };
            DbHelper.ExecuteNonQuery(query, parameters);

            MessageBox.Show("Item Deleted!");
            FillGrid();
            Reset();
        }

        // Filter the grid based on the selected Category
        void FilterByCategory()
        {
            if (FilterCat.SelectedItem.ToString() == "All")
            {
                FillGrid();
            }
            else
            {
                string query = "SELECT * FROM ItemTbl WHERE ItCat = @Category";
                SqlParameter[] parameters = { new SqlParameter("@Category", FilterCat.SelectedItem.ToString()) };
                ItemDGV.DataSource = DbHelper.ExecuteQuery(query, parameters);
            }
        }

        // Filter the grid based on the selected Type
        void FilterByType()
        {
            if (FilterType.SelectedItem.ToString() == "All")
            {
                FillGrid();
            }
            else
            {
                string query = "SELECT * FROM ItemTbl WHERE ItType = @Type";
                SqlParameter[] parameters = { new SqlParameter("@Type", FilterType.SelectedItem.ToString()) };
                ItemDGV.DataSource = DbHelper.ExecuteQuery(query, parameters);
            }
        }

        // --- EVENT HANDLERS ---

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ItName.Text) || string.IsNullOrWhiteSpace(PriceTb.Text) || string.IsNullOrWhiteSpace(QtyTb.Text) || CatCp.SelectedIndex == -1 || TypeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields and make selections.");
            }
            else
            {
                SaveItem();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select an item from the list to update.");
            }
            else
            {
                UpdateItem();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Please select an item from the list to delete.");
            }
            else
            {
                DeleteItem();
            }
        }
        
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ItemDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ItName.Text = ItemDGV.Rows[e.RowIndex].Cells["NameDGV"].Value.ToString();
                CatCp.SelectedItem = ItemDGV.Rows[e.RowIndex].Cells["CatDGV"].Value.ToString();
                TypeCb.SelectedItem = ItemDGV.Rows[e.RowIndex].Cells["TypeDGV"].Value.ToString();
                PriceTb.Text = ItemDGV.Rows[e.RowIndex].Cells["PriceDGV"].Value.ToString();
                QtyTb.Text = ItemDGV.Rows[e.RowIndex].Cells["QtyDGV"].Value.ToString();
                key = Convert.ToInt32(ItemDGV.Rows[e.RowIndex].Cells["IDDGV"].Value);
            }
        }
        
        private void FilterCat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void FilterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterByType();
        }

        // --- NAVIGATION ---
        private void label1_Click(object sender, EventArgs e) { new Customers().Show(); this.Hide(); }
        private void pictureBox2_Click(object sender, EventArgs e) { new Customers().Show(); this.Hide(); }
        private void label2_Click(object sender, EventArgs e) { new Sales().Show(); this.Hide(); }
        private void label4_Click(object sender, EventArgs e) { new Feedbacks().Show(); this.Hide(); }
        private void label5_Click(object sender, EventArgs e) { Application.Exit(); }
        private void label10_Click(object sender, EventArgs e) { new Login().Show(); this.Hide(); }

        // --- Unused Event Handlers ---
        private void label3_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void Items_Load(object sender, EventArgs e) { }
        private void ItemDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}