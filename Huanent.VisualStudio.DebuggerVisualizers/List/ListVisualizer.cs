using Huanent.VisualStudio.DebuggerVisualizers.List;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.Generic;
using System.Data;

[assembly: System.Diagnostics.DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(List<>),
Description = "list可视化工具")]
namespace Huanent.VisualStudio.DebuggerVisualizers.List
{
    class ListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            var data = (DataTable)VisualizerObjectSource.Deserialize(objectProvider.GetData());
            windowService.ShowDialog(new ListForm { Data = data });
        }
    }
}
