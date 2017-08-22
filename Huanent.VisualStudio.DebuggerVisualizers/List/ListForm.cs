using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Huanent.VisualStudio.DebuggerVisualizers.List
{
    public partial class ListForm : BaseForm
    {
        public DataTable Data { get; set; }
        public ListForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dataGridView.DataSource = Data;
            if (Data == null || Data.Rows.Count == 0) return;
            btnSaveXml.Click += SaveXml;
            btnSaveJson.Click += SaveJson;
            btnCopyXml.Click += CopyXml;
            btnCopyJson.Click += CopyJson;
        }

        private void CopyJson(object sender, EventArgs e)
        {
            string json = DataTableToJson(Data);
            Clipboard.SetText(json);
        }

        private void CopyXml(object sender, EventArgs e)
        {
            var builder = new StringBuilder();
            Data.WriteXml(new StringWriter(builder));
            string xmlStr = builder.ToString();
            Clipboard.SetText(xmlStr);
        }

        private void SaveJson(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "json文件（*.json）|*.json";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = saveFileDialog.FileName.ToString();
                    string json = DataTableToJson(Data);
                    File.WriteAllText(localFilePath, json);
                }
            }
        }

        private void SaveXml(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "xml文件（*.xml）|*.xml";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string localFilePath = saveFileDialog.FileName.ToString();
                    Data.WriteXml(localFilePath);
                }
            }
        }

        /// <summary>
        /// 将datatable转换为json  
        /// </summary>
        /// <param name="dt">Dt</param>
        /// <returns>JSON字符串</returns>
        private string DataTableToJson(DataTable dt)
        {
            var jss = new JavaScriptSerializer();
            bool isPrimitive = dt.Columns.Count == 1 && string.IsNullOrWhiteSpace(dt.Columns[0].ColumnName);
            if (isPrimitive)
            {
                var objects = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    objects.Add(dr[0]);
                }
                return jss.Serialize(objects);
            }
            else
            {
                var dic = new List<Dictionary<string, object>>();
                foreach (DataRow dr in dt.Rows)
                {
                    var drow = new Dictionary<string, object>();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        drow.Add(dc.ColumnName, dr[dc.ColumnName]);
                    }
                    dic.Add(drow);
                }
                return jss.Serialize(dic);
            }
        }

    }
}
