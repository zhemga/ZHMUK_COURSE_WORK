namespace CourseWork.Views.ScheduleOfficeHourStatusView {
    partial class ScheduleOfficeHourStatusView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
			this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
						this.ScheduleOfficeHoursGridControl = new DevExpress.XtraGrid.GridControl();
			this.ScheduleOfficeHoursGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ScheduleOfficeHoursBarManager = new DevExpress.XtraBars.BarManager();
			this.ScheduleOfficeHoursBar = new DevExpress.XtraBars.Bar();
			this.ScheduleOfficeHoursXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.ScheduleOfficeHoursPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiScheduleOfficeHoursNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiScheduleOfficeHoursEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiScheduleOfficeHoursDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiScheduleOfficeHoursRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.ScheduleOfficeHoursBarManager)).BeginInit();
						 
			this.SuspendLayout();
			// 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
			// 
            // windowsUIButtonPanelMain
            // 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"));
						this.windowsUIButtonPanelMain.Buttons.Add(new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled"));
						// 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.TextVisible = false;
			// 
            // dataLayoutControl1item.CommandPropertyName
            // 
            this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.scheduleOfficeHourStatusViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.scheduleOfficeHourStatusViewBindingSource.DataSource = typeof(CourseWork.Model.ScheduleOfficeHourStatus);
			this.dataLayoutControl1.DataSource = scheduleOfficeHourStatusViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//ScheduleOfficeHoursGridControl
			//
			this.ScheduleOfficeHoursGridControl.MainView = this.ScheduleOfficeHoursGridView;
			this.ScheduleOfficeHoursGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScheduleOfficeHoursGridControl.Name = "ScheduleOfficeHoursGridControl";
            this.ScheduleOfficeHoursGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ScheduleOfficeHoursGridView});
			//
			//ScheduleOfficeHoursGridView
			//
            this.ScheduleOfficeHoursGridView.GridControl = this.ScheduleOfficeHoursGridControl;
            this.ScheduleOfficeHoursGridView.Name = "ScheduleOfficeHoursGridView";
            this.ScheduleOfficeHoursGridView.OptionsBehavior.Editable = false;
            this.ScheduleOfficeHoursGridView.OptionsBehavior.ReadOnly = true;
			this.ScheduleOfficeHoursGridView.OptionsView.ShowGroupPanel = false;
			//
			//ScheduleOfficeHoursPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters ScheduleOfficeHoursPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DoctorScheduleOfficeHoursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DoctorScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.FieldName = "Doctor";
		    DoctorScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ScheduleOfficeHoursPopulateColumnsParameters.CustomColumnParameters.Add(DoctorScheduleOfficeHoursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters PatientScheduleOfficeHoursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            PatientScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.FieldName = "Patient";
		    PatientScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ScheduleOfficeHoursPopulateColumnsParameters.CustomColumnParameters.Add(PatientScheduleOfficeHoursChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ScheduleOfficeHourStatusScheduleOfficeHoursChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ScheduleOfficeHourStatusScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.FieldName = "ScheduleOfficeHourStatus";
		    ScheduleOfficeHourStatusScheduleOfficeHoursChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			ScheduleOfficeHoursPopulateColumnsParameters.CustomColumnParameters.Add(ScheduleOfficeHourStatusScheduleOfficeHoursChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ScheduleOfficeHoursScheduleOfficeHoursChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ScheduleOfficeHoursScheduleOfficeHoursChildPopulateColumnParameters.FieldName = "ScheduleOfficeHoursScheduleOfficeHours";
            ScheduleOfficeHoursScheduleOfficeHoursChildPopulateColumnParameters.Path = "ScheduleOfficeHours.ScheduleOfficeHourStatusStatusName";
			ScheduleOfficeHoursPopulateColumnsParameters.CustomColumnParameters.Add(ScheduleOfficeHoursScheduleOfficeHoursChildPopulateColumnParameters);
			 
		    this.ScheduleOfficeHoursGridView.PopulateColumns(typeof(CourseWork.Model.ScheduleOfficeHour),ScheduleOfficeHoursPopulateColumnsParameters);
			//
			//ScheduleOfficeHoursBindingSource
			//
			System.Windows.Forms.BindingSource ScheduleOfficeHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
			ScheduleOfficeHoursBindingSource.DataSource = typeof(CourseWork.Model.ScheduleOfficeHour);
            this.ScheduleOfficeHoursGridControl.DataSource = ScheduleOfficeHoursBindingSource;
			//
			//ScheduleOfficeHoursXtraUserControl
			//
            this.ScheduleOfficeHoursXtraUserControl.Controls.Add(ScheduleOfficeHoursGridControl);
			this.ScheduleOfficeHoursXtraUserControl.Name = "ScheduleOfficeHoursXtraUserControl";
			this.ScheduleOfficeHoursXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//ScheduleOfficeHoursNew
			//
			this.bbiScheduleOfficeHoursNew.Caption = "New";
			this.bbiScheduleOfficeHoursNew.Name = "bbiScheduleOfficeHoursNew";
			this.bbiScheduleOfficeHoursNew.ImageUri.Uri = "New";
			this.bbiScheduleOfficeHoursNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ScheduleOfficeHoursBarManager.Items.Add(this.bbiScheduleOfficeHoursNew);
			this.ScheduleOfficeHoursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursNew));
			this.ScheduleOfficeHoursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursNew));
						//
			//ScheduleOfficeHoursEdit
			//
			this.bbiScheduleOfficeHoursEdit.Caption = "Edit";
			this.bbiScheduleOfficeHoursEdit.Name = "bbiScheduleOfficeHoursEdit";
			this.bbiScheduleOfficeHoursEdit.ImageUri.Uri = "Edit";
			this.bbiScheduleOfficeHoursEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ScheduleOfficeHoursBarManager.Items.Add(this.bbiScheduleOfficeHoursEdit);
			this.ScheduleOfficeHoursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursEdit));
			this.ScheduleOfficeHoursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursEdit));
						//
			//ScheduleOfficeHoursDelete
			//
			this.bbiScheduleOfficeHoursDelete.Caption = "Delete";
			this.bbiScheduleOfficeHoursDelete.Name = "bbiScheduleOfficeHoursDelete";
			this.bbiScheduleOfficeHoursDelete.ImageUri.Uri = "Delete";
			this.bbiScheduleOfficeHoursDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ScheduleOfficeHoursBarManager.Items.Add(this.bbiScheduleOfficeHoursDelete);
			this.ScheduleOfficeHoursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursDelete));
			this.ScheduleOfficeHoursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursDelete));
						//
			//ScheduleOfficeHoursRefresh
			//
			this.bbiScheduleOfficeHoursRefresh.Caption = "Refresh";
			this.bbiScheduleOfficeHoursRefresh.Name = "bbiScheduleOfficeHoursRefresh";
			this.bbiScheduleOfficeHoursRefresh.ImageUri.Uri = "Refresh";
			this.bbiScheduleOfficeHoursRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.ScheduleOfficeHoursBarManager.Items.Add(this.bbiScheduleOfficeHoursRefresh);
			this.ScheduleOfficeHoursBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursRefresh));
			this.ScheduleOfficeHoursPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiScheduleOfficeHoursRefresh));
						//
			//ScheduleOfficeHoursBar
			//
			this.ScheduleOfficeHoursBar.BarName = "ScheduleOfficeHours";
            this.ScheduleOfficeHoursBar.DockCol = 0;
            this.ScheduleOfficeHoursBar.DockRow = 0;
            this.ScheduleOfficeHoursBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ScheduleOfficeHoursBar.OptionsBar.AllowQuickCustomization = false;
            this.ScheduleOfficeHoursBar.OptionsBar.DrawDragBorder = false;
            this.ScheduleOfficeHoursBar.Text = "ScheduleOfficeHours";
			//
			//ScheduleOfficeHoursBarManager
			//
			this.ScheduleOfficeHoursBarManager.AllowCustomization = false;
            this.ScheduleOfficeHoursBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.ScheduleOfficeHoursBar});
            this.ScheduleOfficeHoursBarManager.Form = ScheduleOfficeHoursXtraUserControl;
            this.ScheduleOfficeHoursBarManager.MainMenu = this.ScheduleOfficeHoursBar;
			// 
            // ScheduleOfficeHoursPopUpMenu
            // 
            this.ScheduleOfficeHoursPopUpMenu.Manager = this.ScheduleOfficeHoursBarManager;
            this.ScheduleOfficeHoursPopUpMenu.Name = "ScheduleOfficeHoursPopUpMenu";
			//
			//ScheduleOfficeHoursRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters ScheduleOfficeHoursRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            ScheduleOfficeHoursRetriveFieldParameters.FieldName = "ScheduleOfficeHours";
            ScheduleOfficeHoursRetriveFieldParameters.ControlForField = ScheduleOfficeHoursXtraUserControl;
			ScheduleOfficeHoursRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(ScheduleOfficeHoursRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(CourseWork.ViewModels.ScheduleOfficeHourStatusViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "ScheduleOfficeHourStatus - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//ScheduleOfficeHourStatusView
			//
			this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Size = new System.Drawing.Size(1024, 768);
            this.Name = "ScheduleOfficeHourStatusView";
						((System.ComponentModel.ISupportInitialize)(this.ScheduleOfficeHoursBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource scheduleOfficeHourStatusViewBindingSource;
				private DevExpress.XtraGrid.GridControl ScheduleOfficeHoursGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView ScheduleOfficeHoursGridView;
		private DevExpress.XtraBars.BarManager ScheduleOfficeHoursBarManager;
		private DevExpress.XtraBars.Bar ScheduleOfficeHoursBar;
		private DevExpress.XtraEditors.XtraUserControl ScheduleOfficeHoursXtraUserControl;
		private DevExpress.XtraBars.PopupMenu ScheduleOfficeHoursPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiScheduleOfficeHoursNew;
				private DevExpress.XtraBars.BarButtonItem bbiScheduleOfficeHoursEdit;
				private DevExpress.XtraBars.BarButtonItem bbiScheduleOfficeHoursDelete;
				private DevExpress.XtraBars.BarButtonItem bbiScheduleOfficeHoursRefresh;
						 
	}
}
