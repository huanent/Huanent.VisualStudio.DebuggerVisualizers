﻿using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Data;
using System.IO;
using System.Linq;

namespace Huanent.VisualStudio.DebuggerVisualizers.List
{
    class ListDataSource : VisualizerObjectSource
    {
        public override void GetData(object target, Stream outgoingData)
        {
            dynamic dynamicObject = target;
            var genericType = target.GetType().GenericTypeArguments.FirstOrDefault();
            var dt = new DataTable(genericType.Name);

            if (genericType == null)
            {
                base.GetData(dt, outgoingData);
                return;
            }


            if (genericType.IsPrimitive || genericType == typeof(string))
            {
                dt.Columns.Add(" ");

                foreach (object item in dynamicObject)
                {
                    var row = dt.NewRow();
                    row.SetField(0, item);
                    dt.Rows.Add(row);
                }
            }
            else
            {
                var types = genericType.GetProperties();

                if (types.Count() == 0)
                {
                    base.GetData(dt, outgoingData);
                    return;
                }

                foreach (var item in types)
                {
                    var type = item.PropertyType.IsPrimitive ? item.PropertyType : typeof(string);
                    dt.Columns.Add(item.Name, type);
                }

                foreach (object item in dynamicObject)
                {
                    var row = dt.NewRow();
                    foreach (var col in types)
                    {
                        object value = col.GetValue(item);
                        object type = col.PropertyType.IsPrimitive ? value : value.ToString();
                        row.SetField(col.Name, col.GetValue(item));
                    }
                    dt.Rows.Add(row);
                }
            }

            base.GetData(dt, outgoingData);
        }


    }
}
