namespace GarbageMap
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.Label dateNotificationLabel;
            System.Windows.Forms.Label notificationDescriptionLabel;
            System.Windows.Forms.Label localization_LATLabel;
            System.Windows.Forms.Label localization_LNGLabel;
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.dataSet = new GarbageMap.DataSet();
            this.notificationDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notificationDataTableAdapter = new GarbageMap.DataSetTableAdapters.NotificationDataTableAdapter();
            this.tableAdapterManager = new GarbageMap.DataSetTableAdapters.TableAdapterManager();
            this.notificationDataBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.notificationDataBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dateNotificationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notificationDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.localization_LATTextBox = new System.Windows.Forms.TextBox();
            this.localization_LNGTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            dateNotificationLabel = new System.Windows.Forms.Label();
            notificationDescriptionLabel = new System.Windows.Forms.Label();
            localization_LATLabel = new System.Windows.Forms.Label();
            localization_LNGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataBindingNavigator)).BeginInit();
            this.notificationDataBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(dateNotificationLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dateNotificationDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(notificationDescriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.notificationDescriptionTextBox);
            this.splitContainer1.Panel1.Controls.Add(localization_LATLabel);
            this.splitContainer1.Panel1.Controls.Add(this.localization_LATTextBox);
            this.splitContainer1.Panel1.Controls.Add(localization_LNGLabel);
            this.splitContainer1.Panel1.Controls.Add(this.localization_LNGTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.picturePictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(1140, 473);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pokaż na mapie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 473);
            this.webBrowser1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notificationDataBindingSource
            // 
            this.notificationDataBindingSource.DataMember = "NotificationData";
            this.notificationDataBindingSource.DataSource = this.dataSet;
            // 
            // notificationDataTableAdapter
            // 
            this.notificationDataTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.NotificationDataTableAdapter = this.notificationDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = GarbageMap.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // notificationDataBindingNavigator
            // 
            this.notificationDataBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.notificationDataBindingNavigator.BindingSource = this.notificationDataBindingSource;
            this.notificationDataBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.notificationDataBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.notificationDataBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.notificationDataBindingNavigatorSaveItem});
            this.notificationDataBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.notificationDataBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.notificationDataBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.notificationDataBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.notificationDataBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.notificationDataBindingNavigator.Name = "notificationDataBindingNavigator";
            this.notificationDataBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.notificationDataBindingNavigator.Size = new System.Drawing.Size(1140, 25);
            this.notificationDataBindingNavigator.TabIndex = 1;
            this.notificationDataBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // notificationDataBindingNavigatorSaveItem
            // 
            this.notificationDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.notificationDataBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("notificationDataBindingNavigatorSaveItem.Image")));
            this.notificationDataBindingNavigatorSaveItem.Name = "notificationDataBindingNavigatorSaveItem";
            this.notificationDataBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.notificationDataBindingNavigatorSaveItem.Text = "Save Data";
            this.notificationDataBindingNavigatorSaveItem.Click += new System.EventHandler(this.notificationDataBindingNavigatorSaveItem_Click_1);
            // 
            // dateNotificationLabel
            // 
            dateNotificationLabel.AutoSize = true;
            dateNotificationLabel.Location = new System.Drawing.Point(12, 32);
            dateNotificationLabel.Name = "dateNotificationLabel";
            dateNotificationLabel.Size = new System.Drawing.Size(87, 13);
            dateNotificationLabel.TabIndex = 2;
            dateNotificationLabel.Text = "Data zgłoszenia:";
            // 
            // dateNotificationDateTimePicker
            // 
            this.dateNotificationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.notificationDataBindingSource, "DateNotification", true));
            this.dateNotificationDateTimePicker.Location = new System.Drawing.Point(137, 28);
            this.dateNotificationDateTimePicker.Name = "dateNotificationDateTimePicker";
            this.dateNotificationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateNotificationDateTimePicker.TabIndex = 3;
            // 
            // notificationDescriptionLabel
            // 
            notificationDescriptionLabel.AutoSize = true;
            notificationDescriptionLabel.Location = new System.Drawing.Point(12, 58);
            notificationDescriptionLabel.Name = "notificationDescriptionLabel";
            notificationDescriptionLabel.Size = new System.Drawing.Size(28, 13);
            notificationDescriptionLabel.TabIndex = 4;
            notificationDescriptionLabel.Text = "Opis";
            // 
            // notificationDescriptionTextBox
            // 
            this.notificationDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notificationDataBindingSource, "NotificationDescription", true));
            this.notificationDescriptionTextBox.Location = new System.Drawing.Point(137, 55);
            this.notificationDescriptionTextBox.Multiline = true;
            this.notificationDescriptionTextBox.Name = "notificationDescriptionTextBox";
            this.notificationDescriptionTextBox.Size = new System.Drawing.Size(200, 57);
            this.notificationDescriptionTextBox.TabIndex = 5;
            // 
            // localization_LATLabel
            // 
            localization_LATLabel.AutoSize = true;
            localization_LATLabel.Location = new System.Drawing.Point(12, 121);
            localization_LATLabel.Name = "localization_LATLabel";
            localization_LATLabel.Size = new System.Drawing.Size(92, 13);
            localization_LATLabel.TabIndex = 6;
            localization_LATLabel.Text = "Lokalizacja (LAT):";
            // 
            // localization_LATTextBox
            // 
            this.localization_LATTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notificationDataBindingSource, "Localization_LAT", true));
            this.localization_LATTextBox.Location = new System.Drawing.Point(137, 118);
            this.localization_LATTextBox.Name = "localization_LATTextBox";
            this.localization_LATTextBox.Size = new System.Drawing.Size(200, 20);
            this.localization_LATTextBox.TabIndex = 7;
            // 
            // localization_LNGLabel
            // 
            localization_LNGLabel.AutoSize = true;
            localization_LNGLabel.Location = new System.Drawing.Point(12, 147);
            localization_LNGLabel.Name = "localization_LNGLabel";
            localization_LNGLabel.Size = new System.Drawing.Size(94, 13);
            localization_LNGLabel.TabIndex = 8;
            localization_LNGLabel.Text = "Lokalizacja (LNG):";
            // 
            // localization_LNGTextBox
            // 
            this.localization_LNGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.notificationDataBindingSource, "Localization_LNG", true));
            this.localization_LNGTextBox.Location = new System.Drawing.Point(137, 144);
            this.localization_LNGTextBox.Name = "localization_LNGTextBox";
            this.localization_LNGTextBox.Size = new System.Drawing.Size(200, 20);
            this.localization_LNGTextBox.TabIndex = 9;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.notificationDataBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(12, 170);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(325, 287);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePictureBox.TabIndex = 11;
            this.picturePictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.notificationDataBindingNavigator);
            this.Name = "MainWindow";
            this.Text = "Okno główne";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notificationDataBindingNavigator)).EndInit();
            this.notificationDataBindingNavigator.ResumeLayout(false);
            this.notificationDataBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource notificationDataBindingSource;
        private DataSetTableAdapters.NotificationDataTableAdapter notificationDataTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator notificationDataBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton notificationDataBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker dateNotificationDateTimePicker;
        private System.Windows.Forms.TextBox notificationDescriptionTextBox;
        private System.Windows.Forms.TextBox localization_LATTextBox;
        private System.Windows.Forms.TextBox localization_LNGTextBox;
        private System.Windows.Forms.PictureBox picturePictureBox;
    }
}

