namespace CourseWork.Views.DoctorProfileView {
    partial class DoctorProfileView {
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
						this.DoctorsGridControl = new DevExpress.XtraGrid.GridControl();
			this.DoctorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.DoctorsBarManager = new DevExpress.XtraBars.BarManager();
			this.DoctorsBar = new DevExpress.XtraBars.Bar();
			this.DoctorsXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
			this.DoctorsPopUpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
						this.bbiDoctorsNew = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDoctorsEdit = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDoctorsDelete = new DevExpress.XtraBars.BarButtonItem();
						this.bbiDoctorsRefresh = new DevExpress.XtraBars.BarButtonItem();
						((System.ComponentModel.ISupportInitialize)(this.DoctorsBarManager)).BeginInit();
						 
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
			this.doctorProfileViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.doctorProfileViewBindingSource.DataSource = typeof(CourseWork.Model.DoctorProfile);
			this.dataLayoutControl1.DataSource = doctorProfileViewBindingSource;
			//
			//Create GridControls
			//
			DevExpress.XtraDataLayout.RetrieveFieldsParameters parameters = new DevExpress.XtraDataLayout.RetrieveFieldsParameters();
           	parameters.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
						//
			//DoctorsGridControl
			//
			this.DoctorsGridControl.MainView = this.DoctorsGridView;
			this.DoctorsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsGridControl.Name = "DoctorsGridControl";
            this.DoctorsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DoctorsGridView});
			//
			//DoctorsGridView
			//
            this.DoctorsGridView.GridControl = this.DoctorsGridControl;
            this.DoctorsGridView.Name = "DoctorsGridView";
            this.DoctorsGridView.OptionsBehavior.Editable = false;
            this.DoctorsGridView.OptionsBehavior.ReadOnly = true;
			this.DoctorsGridView.OptionsView.ShowGroupPanel = false;
			//
			//DoctorsPopulateColumnsParameters
			//
			DevExpress.XtraGrid.Extensions.PopulateColumnsParameters DoctorsPopulateColumnsParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnsParameters();
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DoctorProfileDoctorsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DoctorProfileDoctorsChildPopulateColumnParameters_NotVisible.FieldName = "DoctorProfile";
		    DoctorProfileDoctorsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DoctorsPopulateColumnsParameters.CustomColumnParameters.Add(DoctorProfileDoctorsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DoctorDegreeDoctorsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DoctorDegreeDoctorsChildPopulateColumnParameters_NotVisible.FieldName = "DoctorDegree";
		    DoctorDegreeDoctorsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DoctorsPopulateColumnsParameters.CustomColumnParameters.Add(DoctorDegreeDoctorsChildPopulateColumnParameters_NotVisible);
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters ScheduleOfficeHoursDoctorsChildPopulateColumnParameters_NotVisible = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            ScheduleOfficeHoursDoctorsChildPopulateColumnParameters_NotVisible.FieldName = "ScheduleOfficeHours";
		    ScheduleOfficeHoursDoctorsChildPopulateColumnParameters_NotVisible.ColumnVisible = false;
			DoctorsPopulateColumnsParameters.CustomColumnParameters.Add(ScheduleOfficeHoursDoctorsChildPopulateColumnParameters_NotVisible);
			 
				
			DevExpress.XtraGrid.Extensions.PopulateColumnParameters DoctorsDoctorsChildPopulateColumnParameters = new DevExpress.XtraGrid.Extensions.PopulateColumnParameters();
            DoctorsDoctorsChildPopulateColumnParameters.FieldName = "DoctorsDoctors";
            DoctorsDoctorsChildPopulateColumnParameters.Path = "Doctors.Name";
			DoctorsPopulateColumnsParameters.CustomColumnParameters.Add(DoctorsDoctorsChildPopulateColumnParameters);
			 
		    this.DoctorsGridView.PopulateColumns(typeof(CourseWork.Model.Doctor),DoctorsPopulateColumnsParameters);
			//
			//DoctorsBindingSource
			//
			System.Windows.Forms.BindingSource DoctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			DoctorsBindingSource.DataSource = typeof(CourseWork.Model.Doctor);
            this.DoctorsGridControl.DataSource = DoctorsBindingSource;
			//
			//DoctorsXtraUserControl
			//
            this.DoctorsXtraUserControl.Controls.Add(DoctorsGridControl);
			this.DoctorsXtraUserControl.Name = "DoctorsXtraUserControl";
			this.DoctorsXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100); 
							//
			//DoctorsNew
			//
			this.bbiDoctorsNew.Caption = "New";
			this.bbiDoctorsNew.Name = "bbiDoctorsNew";
			this.bbiDoctorsNew.ImageUri.Uri = "New";
			this.bbiDoctorsNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DoctorsBarManager.Items.Add(this.bbiDoctorsNew);
			this.DoctorsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsNew));
			this.DoctorsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsNew));
						//
			//DoctorsEdit
			//
			this.bbiDoctorsEdit.Caption = "Edit";
			this.bbiDoctorsEdit.Name = "bbiDoctorsEdit";
			this.bbiDoctorsEdit.ImageUri.Uri = "Edit";
			this.bbiDoctorsEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DoctorsBarManager.Items.Add(this.bbiDoctorsEdit);
			this.DoctorsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsEdit));
			this.DoctorsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsEdit));
						//
			//DoctorsDelete
			//
			this.bbiDoctorsDelete.Caption = "Delete";
			this.bbiDoctorsDelete.Name = "bbiDoctorsDelete";
			this.bbiDoctorsDelete.ImageUri.Uri = "Delete";
			this.bbiDoctorsDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DoctorsBarManager.Items.Add(this.bbiDoctorsDelete);
			this.DoctorsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsDelete));
			this.DoctorsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsDelete));
						//
			//DoctorsRefresh
			//
			this.bbiDoctorsRefresh.Caption = "Refresh";
			this.bbiDoctorsRefresh.Name = "bbiDoctorsRefresh";
			this.bbiDoctorsRefresh.ImageUri.Uri = "Refresh";
			this.bbiDoctorsRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			this.DoctorsBarManager.Items.Add(this.bbiDoctorsRefresh);
			this.DoctorsBar.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsRefresh));
			this.DoctorsPopUpMenu.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.bbiDoctorsRefresh));
						//
			//DoctorsBar
			//
			this.DoctorsBar.BarName = "Doctors";
            this.DoctorsBar.DockCol = 0;
            this.DoctorsBar.DockRow = 0;
            this.DoctorsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.DoctorsBar.OptionsBar.AllowQuickCustomization = false;
            this.DoctorsBar.OptionsBar.DrawDragBorder = false;
            this.DoctorsBar.Text = "Doctors";
			//
			//DoctorsBarManager
			//
			this.DoctorsBarManager.AllowCustomization = false;
            this.DoctorsBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.DoctorsBar});
            this.DoctorsBarManager.Form = DoctorsXtraUserControl;
            this.DoctorsBarManager.MainMenu = this.DoctorsBar;
			// 
            // DoctorsPopUpMenu
            // 
            this.DoctorsPopUpMenu.Manager = this.DoctorsBarManager;
            this.DoctorsPopUpMenu.Name = "DoctorsPopUpMenu";
			//
			//DoctorsRetriveFieldParameters
			//
			DevExpress.XtraDataLayout.RetrieveFieldParameters DoctorsRetriveFieldParameters = new DevExpress.XtraDataLayout.RetrieveFieldParameters();
            DoctorsRetriveFieldParameters.FieldName = "Doctors";
            DoctorsRetriveFieldParameters.ControlForField = DoctorsXtraUserControl;
			DoctorsRetriveFieldParameters.CreateTabGroupForItem = true;
			parameters.CustomListParameters.Add(DoctorsRetriveFieldParameters);
						 
			//
			//call RetrieveFields
			//
            this.dataLayoutControl1.RetrieveFields(parameters);
			// 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(CourseWork.ViewModels.DoctorProfileViewModel);
			// 
            // labelControl
            // 
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Name = "labelControl";
            this.labelControl.Text = "DoctorProfile - Element View";
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
			//
			//DoctorProfileView
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
            this.Name = "DoctorProfileView";
						((System.ComponentModel.ISupportInitialize)(this.DoctorsBarManager)).EndInit();
						this.ResumeLayout(false);
		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private System.Windows.Forms.BindingSource doctorProfileViewBindingSource;
				private DevExpress.XtraGrid.GridControl DoctorsGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView DoctorsGridView;
		private DevExpress.XtraBars.BarManager DoctorsBarManager;
		private DevExpress.XtraBars.Bar DoctorsBar;
		private DevExpress.XtraEditors.XtraUserControl DoctorsXtraUserControl;
		private DevExpress.XtraBars.PopupMenu DoctorsPopUpMenu;
				private DevExpress.XtraBars.BarButtonItem bbiDoctorsNew;
				private DevExpress.XtraBars.BarButtonItem bbiDoctorsEdit;
				private DevExpress.XtraBars.BarButtonItem bbiDoctorsDelete;
				private DevExpress.XtraBars.BarButtonItem bbiDoctorsRefresh;
						 
	}
}
