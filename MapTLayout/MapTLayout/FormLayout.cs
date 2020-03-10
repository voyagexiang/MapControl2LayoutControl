using SuperMap.Data;
using SuperMap.Layout;
using SuperMap.Mapping;
using SuperMap.UI;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace MapTLayout
{
    public partial class FormLayout : Form
    {
        private Workspace m_workspace;
        private Map m_map;
        private int m_mapID;

        public FormLayout(Map map)
        {
            InitializeComponent();
            m_workspace = map.Workspace;
            m_map = map;
            m_mapLayoutControl = new MapLayoutControl();
            base.Controls.Add(m_mapLayoutControl);
            base.Controls.SetChildIndex(m_mapLayoutControl, 0);
            m_mapLayoutControl.Dock = DockStyle.Fill;
            m_mapLayoutControl.MapLayout.Workspace = m_workspace;
            m_mapLayoutControl.IsHorizontalScrollbarVisible = false;
            m_mapLayoutControl.IsVerticalScrollbarVisible = false;


        }

        private void FormLayout_Load(object sender, EventArgs e)
        {
            try
            {
                //初始化展示地图
                //这种也可以
                //string mapName = m_workspace.Maps[0];
                //InitializeLayout(mapName);
                //但这种最保险
                m_workspace.Maps.Add("tem", m_map.ToXML());
                InitializeLayout("tem");
                m_mapLayoutControl.ElementAdded += new ElementEventHandler(m_mapLayoutControl_ElementAdded);
                m_mapLayoutControl.TrackMode = TrackMode.Edit;
                m_mapLayoutControl.MapLayout.Zoom(4);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        public void InitializeLayout(string mapName)
        {
            try
            {
                LayoutElements elements = m_mapLayoutControl.MapLayout.Elements;
                // 构造GeoMap
                GeoMap geoMap = new GeoMap();

                //设置地图名称，在工作空间内的地图
                geoMap.MapName = mapName;

                // 设置GeoMap对象的外切矩形
                Rectangle2D rect = new Rectangle2D(new Point2D(1000, 1300), new Size2D(1500, 1500));
                GeoRectangle geoRect = new GeoRectangle(rect, 0);
                geoMap.Shape = geoRect;

                elements.AddNew(geoMap);
                m_mapID = elements.GetID();

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 对象添加事件
        /// Maplayout tracked eventhandle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void m_mapLayoutControl_ElementAdded(object sender, ElementEventArgs e)
        {
            try
            {
                LayoutElements elements = m_mapLayoutControl.MapLayout.Elements;
                if (elements.SeekID(e.ID))
                {
                    Geometry gemetry = elements.GetGeometry();
                    if (gemetry != null)
                    {
                        GeoNorthArrow northArrow = gemetry as GeoNorthArrow;
                        if (northArrow != null)
                        {
                            northArrow.BindingGeoMapID = m_mapID;
                        }

                        GeoMapScale mapScale = gemetry as GeoMapScale;
                        if (mapScale != null)
                        {
                            mapScale.BindingGeoMapID = m_mapID;
                        }

                        elements.SetGeometry(gemetry);
                        elements.Refresh();
                        m_mapLayoutControl.MapLayout.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }


    }
}
