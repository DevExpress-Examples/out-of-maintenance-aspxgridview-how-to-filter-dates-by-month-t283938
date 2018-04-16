using DevExpress.Data.Filtering;
using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxGridView1_AutoFilterCellEditorCreate(object sender, DevExpress.Web.ASPxGridViewEditorCreateEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        ComboBoxProperties comboBoxProp = new ComboBoxProperties();
        e.EditorProperties = comboBoxProp;
    }
    protected void ASPxGridView1_AutoFilterCellEditorInitialize(object sender, DevExpress.Web.ASPxGridViewEditorEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        ASPxComboBox comboBox = e.Editor as ASPxComboBox;
        comboBox.ValueType = typeof(string);
        for (int i = 1; i <= 12; i++)
            comboBox.Items.Add(NumberMonthConverter.GetTitleOfMonth(i), i);
    }
    protected void ASPxGridView1_ProcessColumnAutoFilter(object sender, ASPxGridViewAutoFilterEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        if (e.Kind == GridViewAutoFilterEventKind.CreateCriteria)
            e.Criteria = new BinaryOperator(e.Column.FieldName, e.Value, BinaryOperatorType.Equal);
        else
            if (e.Value != string.Empty)
                e.Value = NumberMonthConverter.GetTitleOfMonth(Convert.ToInt32(e.Value));
    }
    protected void ASPxGridView1_CustomUnboundColumnData(object sender, ASPxGridViewColumnDataEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        DateTime tempDate = (DateTime)e.GetListSourceFieldValue("OrderDate");
        e.Value = tempDate.Month;
    }
    protected void ASPxGridView1_CustomColumnDisplayText(object sender, ASPxGridViewColumnDisplayTextEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        e.DisplayText = e.GetFieldValue("OrderDate").ToString();
    }
    protected void ASPxGridView1_HeaderFilterFillItems(object sender, ASPxGridViewHeaderFilterEventArgs e) {
        if (e.Column.FieldName != "Month")
            return;
        e.Values.Clear();
        for (int i = 1; i <= 12; i++)
            e.AddValue(NumberMonthConverter.GetTitleOfMonth(i), i.ToString());
    }
}
