namespace Process_Model
{
    partial class GridForm
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuestionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuestionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuestionText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnswerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEST5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "CustomSqlQuery";
            this.gridControl1.DataSource = this.sqlDataSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(817, 483);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Process Model DB";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "CustomSqlQuery";
            customSqlQuery1.Sql = " SELECT q.*, a.* FROM Questions q, Answers a WHERE q.QuestionID = AnswerID;";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colQuestionID,
            this.colQuestionNo,
            this.colQuestionText,
            this.colAnswerID,
            this.gridColumn1,
            this.coltest2,
            this.coltest4,
            this.colTEST5,
            this.coltest6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.DataSourceChanged += new System.EventHandler(this.gridView1_DataSourceChanged);
            // 
            // colQuestionID
            // 
            this.colQuestionID.FieldName = "QuestionID";
            this.colQuestionID.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colQuestionID.Name = "colQuestionID";
            this.colQuestionID.OptionsColumn.AllowEdit = false;
            this.colQuestionID.Visible = true;
            this.colQuestionID.VisibleIndex = 0;
            this.colQuestionID.Width = 201;
            // 
            // colQuestionNo
            // 
            this.colQuestionNo.FieldName = "QuestionNo";
            this.colQuestionNo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colQuestionNo.Name = "colQuestionNo";
            this.colQuestionNo.Visible = true;
            this.colQuestionNo.VisibleIndex = 1;
            this.colQuestionNo.Width = 201;
            // 
            // colQuestionText
            // 
            this.colQuestionText.FieldName = "QuestionText";
            this.colQuestionText.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colQuestionText.Name = "colQuestionText";
            this.colQuestionText.Visible = true;
            this.colQuestionText.VisibleIndex = 2;
            this.colQuestionText.Width = 201;
            // 
            // colAnswerID
            // 
            this.colAnswerID.FieldName = "AnswerID";
            this.colAnswerID.Name = "colAnswerID";
            this.colAnswerID.Visible = true;
            this.colAnswerID.VisibleIndex = 3;
            this.colAnswerID.Width = 201;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "@test1";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 201;
            // 
            // coltest2
            // 
            this.coltest2.FieldName = "test2";
            this.coltest2.Name = "coltest2";
            this.coltest2.Visible = true;
            this.coltest2.VisibleIndex = 5;
            this.coltest2.Width = 201;
            // 
            // coltest4
            // 
            this.coltest4.FieldName = "test4";
            this.coltest4.Name = "coltest4";
            this.coltest4.Visible = true;
            this.coltest4.VisibleIndex = 6;
            this.coltest4.Width = 201;
            // 
            // colTEST5
            // 
            this.colTEST5.FieldName = "TEST5";
            this.colTEST5.Name = "colTEST5";
            this.colTEST5.Visible = true;
            this.colTEST5.VisibleIndex = 7;
            this.colTEST5.Width = 201;
            // 
            // coltest6
            // 
            this.coltest6.FieldName = "test6";
            this.coltest6.Name = "coltest6";
            this.coltest6.Visible = true;
            this.coltest6.VisibleIndex = 8;
            this.coltest6.Width = 201;
            // 
            // GridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 483);
            this.Controls.Add(this.gridControl1);
            this.Name = "GridForm";
            this.Text = "GridForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestionID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestionNo;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestionText;
        private DevExpress.XtraGrid.Columns.GridColumn colAnswerID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn coltest2;
        private DevExpress.XtraGrid.Columns.GridColumn coltest4;
        private DevExpress.XtraGrid.Columns.GridColumn colTEST5;
        private DevExpress.XtraGrid.Columns.GridColumn coltest6;
    }
}