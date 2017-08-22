using Huanent.VisualStudio.DebuggerVisualizers.List;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;

[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(List<>),
Description = "list可视化工具")]


[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(ConcurrentStack‎<>),
Description = "list可视化工具")]

[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(ConcurrentQueue‎<>),
Description = "list可视化工具")]


[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(Collection‎<>),
Description = "list可视化工具")]

[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(ConcurrentBag<>),
Description = "list可视化工具")]

[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(Queue<>),
Description = "list可视化工具")]

[assembly: DebuggerVisualizer(
typeof(ListVisualizer),
typeof(ListDataSource),
Target = typeof(Stack<>),
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
