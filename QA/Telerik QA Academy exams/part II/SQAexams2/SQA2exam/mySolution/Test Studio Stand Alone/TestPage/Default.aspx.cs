using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Profile;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Telerik.Web.UI;
using System.Linq;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load()
    {
    }
    protected void RadGrid1_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        RadGrid1.DataSource = Cache["Data"] as DataTable;
    }
    protected void RadGrid1_ItemCommand(object sender, Telerik.Web.UI.GridCommandEventArgs e)
    {
        if (e.CommandName == RadGrid.DeleteCommandName)
        {
            GridEditableItem item = e.Item as GridEditableItem;
            if (item != null)
            {
                object dataKey = item.GetDataKeyValue("ProductID");
                DataTable table = Cache["Data"] as DataTable;
                if (table != null && dataKey != null)
                {
                    table.AsEnumerable().Where(r => r.Field<int>("ProductID") == Convert.ToInt32(dataKey)).FirstOrDefault().Delete();
                }
            }
        }
        if (e.CommandName == RadGrid.UpdateCommandName)
        {
            GridEditableItem item = e.Item as GridEditableItem;
            if (item != null)
            {
                object dataKey = item.GetDataKeyValue("ProductID");
                DataTable table = Cache["Data"] as DataTable;
                if (table != null && dataKey != null)
                {
                    DataRow row = table.AsEnumerable().Where(r => r.Field<int>("ProductID") == Convert.ToInt32(dataKey)).FirstOrDefault();
                    item.UpdateValues(row);
                }
            }
        }
        if (e.CommandName == RadGrid.PerformInsertCommandName)
        {
            GridEditableItem item = e.Item as GridEditableItem;
            if (item != null)
            {
                DataTable table = Cache["Data"] as DataTable;
                if (table != null)
                {
                    DataRow newRow = table.NewRow();
                    item.UpdateValues(newRow);
                    newRow["ProductID"] = table.AsEnumerable().OrderBy(r => r.Field<int>("ProductID")).LastOrDefault().Field<int>("ProductID") + 1;
                    table.Rows.Add(newRow);

                }
            }
        }
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        CacheManager.ResetCache(this.Context.ApplicationInstance);
        RadGrid1.Rebind();
    }
    protected void RadGrid1_ItemCreated(object sender, GridItemEventArgs e)
    {
        if (e.Item is GridEditFormItem && e.Item.IsInEditMode)
        {
            GridEditFormItem item = e.Item as GridEditFormItem;
            GridNumericColumnEditor editor = item.EditManager.GetColumnEditor("UnitPrice") as GridNumericColumnEditor;
            if (editor != null)
            {
                RadNumericTextBox tb = editor.NumericTextBox;
                if (tb != null)
                {
                    RequiredFieldValidator validator = new RequiredFieldValidator();
                    validator.ForeColor = Color.Red;
                    validator.ID = "UnitPrice_Validator";
                    validator.Text = "  Required!";
                    validator.ControlToValidate = tb.ID;
                    editor.NumericTextBox.Parent.Controls.Add(validator);
                }
            }
        }
    }
}