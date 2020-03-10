using SuperMap.Data;
using SuperMap.UI;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MapTLayout
{
    public partial class mainForm : Form
    {
        private Workspace m_workspace;
        private MapControl m_mapControl;
        public mainForm()
        {
            try
            {
                InitializeComponent();
                CheckForIllegalCrossThreadCalls = false;

                this.m_workspace = new Workspace(this.components);
                this.m_mapControl = new MapControl();

                m_mapControl.Dock = DockStyle.Fill;    

                m_mapControl.Map.Workspace = m_workspace;
                Initialize();

                base.Controls.Add(m_mapControl);
                base.Controls.SetChildIndex(m_mapControl, 0);
                m_mapControl.Map.ViewEntire();
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 打开需要的工作空间文件及地图
        /// Open the workspace and the map
        /// </summary>
        private void Initialize()
        {
            try
            {
                // 打开工作空间及地图
                // Open the workspace and the map
                String filePath = "E:\\supermap\\supermap-iobjectsdotnet-10.0.0-17523-73237-all\\SampleData\\ThematicMaps\\Thematicmaps.smwu";

                WorkspaceConnectionInfo conInfo = new WorkspaceConnectionInfo(filePath);
                m_workspace.Open(conInfo);
                if (SuperMap.Data.Environment.CurrentCulture != "zh-CN")
                {
                    m_mapControl.Map.Open("Beijing-Tianjin Area Division Map");
                }
                else
                {
                    m_mapControl.Map.Open("京津地区地图");
                }


                // 调整mapControl的状态
                // Adjust the condition of mapControl
                m_mapControl.Action = SuperMap.UI.Action.Pan;
                m_mapControl.IsWaitCursorEnabled = false;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        private void buttonLayout_Click(object sender, EventArgs e)
        {
            FormLayout formLayout = new FormLayout(m_mapControl.Map);
            formLayout.ShowDialog();
        }
    }
}
