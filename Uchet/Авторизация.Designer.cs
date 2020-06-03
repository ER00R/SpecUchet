namespace Uchet
{
    partial class Авторизация
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
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.авторизационныеДанныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.авторизационныеДанныеTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.АвторизационныеДанныеTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.loginComboBox = new System.Windows.Forms.ComboBox();
            this.авторизационныеДанныеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.авторизационныеДанныеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(64, 126);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(153, 42);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Вход";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // авторизационныеДанныеBindingSource
            // 
            this.авторизационныеДанныеBindingSource.DataMember = "АвторизационныеДанные";
            this.авторизационныеДанныеBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // авторизационныеДанныеTableAdapter
            // 
            this.авторизационныеДанныеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АвторизационныеДанныеTableAdapter = this.авторизационныеДанныеTableAdapter;
            this.tableAdapterManager.ВыдачаСИЗTableAdapter = null;
            this.tableAdapterManager.ЛичнаяКарточкаTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = null;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПрофессииTableAdapter = null;
            this.tableAdapterManager.СведенияОВыдачеСИЗTableAdapter = null;
            this.tableAdapterManager.СведенияОтиповыхНормахTableAdapter = null;
            this.tableAdapterManager.СИЗTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
            // 
            // loginComboBox
            // 
            this.loginComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.авторизационныеДанныеBindingSource, "Login", true));
            this.loginComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.авторизационныеДанныеBindingSource, "Login", true));
            this.loginComboBox.DataSource = this.авторизационныеДанныеBindingSource1;
            this.loginComboBox.DisplayMember = "Login";
            this.loginComboBox.FormattingEnabled = true;
            this.loginComboBox.Location = new System.Drawing.Point(41, 72);
            this.loginComboBox.Name = "loginComboBox";
            this.loginComboBox.Size = new System.Drawing.Size(195, 21);
            this.loginComboBox.TabIndex = 3;
            this.loginComboBox.ValueMember = "Login";
            // 
            // авторизационныеДанныеBindingSource1
            // 
            this.авторизационныеДанныеBindingSource1.DataMember = "АвторизационныеДанные";
            this.авторизационныеДанныеBindingSource1.DataSource = this.uchetBaseDataSet;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(41, 97);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(195, 23);
            this.materialSingleLineTextField1.TabIndex = 4;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(41, 208);
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(195, 23);
            this.materialSingleLineTextField2.TabIndex = 5;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // авторизационныеДанныеDataGridView
            // 
            this.авторизационныеДанныеDataGridView.AutoGenerateColumns = false;
            this.авторизационныеДанныеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.авторизационныеДанныеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.авторизационныеДанныеDataGridView.DataSource = this.авторизационныеДанныеBindingSource;
            this.авторизационныеДанныеDataGridView.Location = new System.Drawing.Point(299, 266);
            this.авторизационныеДанныеDataGridView.Name = "авторизационныеДанныеDataGridView";
            this.авторизационныеДанныеDataGridView.Size = new System.Drawing.Size(300, 220);
            this.авторизационныеДанныеDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Login";
            this.dataGridViewTextBoxColumn1.HeaderText = "Login";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 559);
            this.Controls.Add(this.авторизационныеДанныеDataGridView);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.loginComboBox);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Авторизация";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.авторизационныеДанныеDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource авторизационныеДанныеBindingSource;
        private UchetBaseDataSetTableAdapters.АвторизационныеДанныеTableAdapter авторизационныеДанныеTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox loginComboBox;
        private System.Windows.Forms.BindingSource авторизационныеДанныеBindingSource1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
        private System.Windows.Forms.DataGridView авторизационныеДанныеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}