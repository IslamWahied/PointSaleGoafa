using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSell.AddForms
{
    public partial class frmPowersOfUsers : MaterialSkin.Controls.MaterialForm
    {
        DB con = new DB();
        public frmPowersOfUsers()
        {
            InitializeComponent();
        }

        private void frmPowersOfUsers_Load(object sender, EventArgs e)
        {
            
            gridControl1.DataSource = con.GetData("select * from UserLogin");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            DataTable GetDataTable(GridView view)
            {
                DataTable dt = new DataTable();
                foreach (GridColumn c in view.Columns)
                    dt.Columns.Add(c.FieldName, c.ColumnType);
                for (int r = 0; r < view.RowCount; r++)
                {
                    object[] rowValues = new object[dt.Columns.Count];
                    for (int c = 0; c < dt.Columns.Count; c++)
                        rowValues[c] = view.GetRowCellValue(r, dt.Columns[c].ColumnName);
                    dt.Rows.Add(rowValues);
                }
                return dt;
            }
        }
        void GetDataTable(GridView view)
        {
            ArrayList rows = new ArrayList();

            // Add the selected rows to the list. 
            Int32[] selectedRowHandles = gridView1.GetSelectedRows();
            for (int i = 0; i < selectedRowHandles.Length; i++)
            {
                int selectedRowHandle = selectedRowHandles[i];
                if (selectedRowHandle >= 0)
                    rows.Add(gridView1.GetDataRow(selectedRowHandle));
            }
           
           
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //   GetDataTable(gridView1) ;
            //gridView1.ViewRepository.Container.Components.
        }
    }
}
