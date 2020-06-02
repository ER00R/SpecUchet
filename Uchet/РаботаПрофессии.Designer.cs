namespace Uchet
{
    partial class РаботаПрофессии
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
            System.Windows.Forms.Label кодПрофессииLabel;
            System.Windows.Forms.Label профессииLabel;
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.профессииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.профессииTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.ПрофессииTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.кодПрофессииTextBox = new System.Windows.Forms.TextBox();
            this.профессииTextBox = new System.Windows.Forms.TextBox();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            кодПрофессииLabel = new System.Windows.Forms.Label();
            профессииLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // профессииBindingSource
            // 
            this.профессииBindingSource.DataMember = "Профессии";
            this.профессииBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // профессииTableAdapter
            // 
            this.профессииTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыдачаСИЗTableAdapter = null;
            this.tableAdapterManager.ЛичнаяКарточкаTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = null;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПрофессииTableAdapter = this.профессииTableAdapter;
            this.tableAdapterManager.СведенияОВыдачеСИЗTableAdapter = null;
            this.tableAdapterManager.СведенияОтиповыхНормахTableAdapter = null;
            this.tableAdapterManager.СИЗTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
            // 
            // кодПрофессииLabel
            // 
            кодПрофессииLabel.AutoSize = true;
            кодПрофессииLabel.Location = new System.Drawing.Point(12, 72);
            кодПрофессииLabel.Name = "кодПрофессииLabel";
            кодПрофессииLabel.Size = new System.Drawing.Size(90, 13);
            кодПрофессииLabel.TabIndex = 1;
            кодПрофессииLabel.Text = "Код Профессии:";
            // 
            // кодПрофессииTextBox
            // 
            this.кодПрофессииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.профессииBindingSource, "КодПрофессии", true));
            this.кодПрофессииTextBox.Location = new System.Drawing.Point(108, 69);
            this.кодПрофессииTextBox.Name = "кодПрофессииTextBox";
            this.кодПрофессииTextBox.Size = new System.Drawing.Size(274, 20);
            this.кодПрофессииTextBox.TabIndex = 2;
            // 
            // профессииLabel
            // 
            профессииLabel.AutoSize = true;
            профессииLabel.Location = new System.Drawing.Point(34, 98);
            профессииLabel.Name = "профессииLabel";
            профессииLabel.Size = new System.Drawing.Size(68, 13);
            профессииLabel.TabIndex = 3;
            профессииLabel.Text = "Профессия:";
            // 
            // профессииTextBox
            // 
            this.профессииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.профессииBindingSource, "Профессии", true));
            this.профессииTextBox.Location = new System.Drawing.Point(108, 95);
            this.профессииTextBox.Name = "профессииTextBox";
            this.профессииTextBox.Size = new System.Drawing.Size(274, 20);
            this.профессииTextBox.TabIndex = 4;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton6.Location = new System.Drawing.Point(129, 127);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(136, 29);
            this.materialRaisedButton6.TabIndex = 68;
            this.materialRaisedButton6.Text = "Сохранить";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-1, 121);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(394, 45);
            this.materialDivider1.TabIndex = 67;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // РаботаПрофессии
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 161);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(профессииLabel);
            this.Controls.Add(this.профессииTextBox);
            this.Controls.Add(кодПрофессииLabel);
            this.Controls.Add(this.кодПрофессииTextBox);
            this.Name = "РаботаПрофессии";
            this.Text = "Добавление элемента в таблицу \"Профессии\"";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.профессииBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource профессииBindingSource;
        private UchetBaseDataSetTableAdapters.ПрофессииTableAdapter профессииTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодПрофессииTextBox;
        private System.Windows.Forms.TextBox профессииTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}