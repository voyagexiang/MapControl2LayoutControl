namespace MapTLayout
{
    partial class FormLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_mapLayoutControl = new SuperMap.UI.MapLayoutControl();
            this.workspaceTree1 = new SuperMap.UI.WorkspaceTree();
            this.SuspendLayout();
            // 
            // m_mapLayoutControl
            // 
            this.m_mapLayoutControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_mapLayoutControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_mapLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_mapLayoutControl.IsCursorCustomized = false;
            this.m_mapLayoutControl.IsGridSnapable = false;
            this.m_mapLayoutControl.IsHorizontalScrollbarVisible = false;
            this.m_mapLayoutControl.IsSnapEnabled = true;
            this.m_mapLayoutControl.IsVerticalScrollbarVisible = false;
            this.m_mapLayoutControl.IsWaitCursorEnabled = true;
            this.m_mapLayoutControl.LayoutAction = SuperMap.UI.Action.Select2;
            this.m_mapLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.m_mapLayoutControl.MapAction = SuperMap.UI.Action.Null;
            this.m_mapLayoutControl.Name = "m_mapLayoutControl";
            this.m_mapLayoutControl.RefreshAtTracked = true;
            this.m_mapLayoutControl.RefreshInInvalidArea = false;
            this.m_mapLayoutControl.Size = new System.Drawing.Size(800, 450);
            this.m_mapLayoutControl.TabIndex = 1;
            this.m_mapLayoutControl.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // workspaceTree1
            // 
            this.workspaceTree1.AllowDrop = true;
            this.workspaceTree1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceTree1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspaceTree1.ImageIndex = 0;
            this.workspaceTree1.ItemHeight = 17;
            this.workspaceTree1.Location = new System.Drawing.Point(296, 83);
            this.workspaceTree1.Name = "workspaceTree1";
            this.workspaceTree1.SelectedImageIndex = 0;
            this.workspaceTree1.SelectedNodes = new System.Windows.Forms.TreeNode[0];
            this.workspaceTree1.Size = new System.Drawing.Size(200, 300);
            this.workspaceTree1.TabIndex = 2;
            this.workspaceTree1.Workspace = null;
            // 
            // FormLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workspaceTree1);
            this.Controls.Add(this.m_mapLayoutControl);
            this.Name = "FormLayout";
            this.Text = "FormLayout";
            this.Load += new System.EventHandler(this.FormLayout_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SuperMap.UI.MapLayoutControl m_mapLayoutControl;
        private SuperMap.UI.WorkspaceTree workspaceTree1;
    }
}