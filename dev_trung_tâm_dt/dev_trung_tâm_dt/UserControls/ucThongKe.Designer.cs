namespace dev_trung_tâm_dt.UserControls
{
    partial class ucThongKe
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chartControl4 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.chartControl1);
            this.groupControl1.Location = new System.Drawing.Point(9, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(523, 405);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thống kê số lượng học viên theo tuổi";
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(2, 28);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Series 1";
            series1.View = pieSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(519, 375);
            this.chartControl1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.chartControl2);
            this.groupControl2.Location = new System.Drawing.Point(538, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(523, 405);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thống kê học viên theo giới tính";
            // 
            // chartControl2
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.5;-0.866025403784439;0;0;0.866025403784439;0.5;0;0;0;0;1";
            this.chartControl2.Diagram = simpleDiagram3D1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(2, 28);
            this.chartControl2.Name = "chartControl2";
            series2.Name = "Series 1";
            series2.View = pie3DSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(519, 375);
            this.chartControl2.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl3.Controls.Add(this.chartControl3);
            this.groupControl3.Location = new System.Drawing.Point(9, 415);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(523, 405);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Thống kê số lượng lớp học";
            // 
            // chartControl3
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl3.Diagram = xyDiagram1;
            this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Location = new System.Drawing.Point(2, 28);
            this.chartControl3.Name = "chartControl3";
            series3.Name = "Series 1";
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl3.Size = new System.Drawing.Size(519, 375);
            this.chartControl3.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl4.Controls.Add(this.chartControl4);
            this.groupControl4.Location = new System.Drawing.Point(540, 415);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(523, 405);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Thống kê đăng kí";
            // 
            // chartControl4
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl4.Diagram = xyDiagram2;
            this.chartControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl4.Legend.Name = "Default Legend";
            this.chartControl4.Location = new System.Drawing.Point(2, 28);
            this.chartControl4.Name = "chartControl4";
            series4.ArgumentDataMember = "nam";
            series4.Name = "Series 1";
            series4.ValueDataMembersSerializable = "soluong";
            series4.View = splineSeriesView1;
            this.chartControl4.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.chartControl4.Size = new System.Drawing.Size(519, 375);
            this.chartControl4.TabIndex = 0;
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1078, 826);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private DevExpress.XtraCharts.ChartControl chartControl4;
    }
}
