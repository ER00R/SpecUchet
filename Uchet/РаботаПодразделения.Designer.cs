namespace Uchet
{
    partial class РаботаПодразделения
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
            System.Windows.Forms.Label кодПодразделениеLabel;
            System.Windows.Forms.Label наименованиеПодразделениеLabel;
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.подразделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.подразделенияTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.ПодразделенияTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.кодПодразделениеTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеПодразделениеTextBox = new System.Windows.Forms.TextBox();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            кодПодразделениеLabel = new System.Windows.Forms.Label();
            наименованиеПодразделениеLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // подразделенияBindingSource
            // 
            this.подразделенияBindingSource.DataMember = "Подразделения";
            this.подразделенияBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // подразделенияTableAdapter
            // 
            this.подразделенияTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыдачаСИЗTableAdapter = null;
            this.tableAdapterManager.ЛичнаяКарточкаTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = this.подразделенияTableAdapter;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПрофессииTableAdapter = null;
            this.tableAdapterManager.СведенияОВыдачеСИЗTableAdapter = null;
            this.tableAdapterManager.СведенияОтиповыхНормахTableAdapter = null;
            this.tableAdapterManager.СИЗTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
            // 
            // кодПодразделениеLabel
            // 
            кодПодразделениеLabel.AutoSize = true;
            кодПодразделениеLabel.Location = new System.Drawing.Point(57, 70);
            кодПодразделениеLabel.Name = "кодПодразделениеLabel";
            кодПодразделениеLabel.Size = new System.Drawing.Size(112, 13);
            кодПодразделениеLabel.TabIndex = 1;
            кодПодразделениеLabel.Text = "Код Подразделение:";
            // 
            // кодПодразделениеTextBox
            // 
            this.кодПодразделениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подразделенияBindingSource, "КодПодразделение", true));
            this.кодПодразделениеTextBox.Location = new System.Drawing.Point(175, 67);
            this.кодПодразделениеTextBox.Name = "кодПодразделениеTextBox";
            this.кодПодразделениеTextBox.Size = new System.Drawing.Size(242, 20);
            this.кодПодразделениеTextBox.TabIndex = 2;
            // 
            // наименованиеПодразделениеLabel
            // 
            наименованиеПодразделениеLabel.AutoSize = true;
            наименованиеПодразделениеLabel.Location = new System.Drawing.Point(0, 96);
            наименованиеПодразделениеLabel.Name = "наименованиеПодразделениеLabel";
            наименованиеПодразделениеLabel.Size = new System.Drawing.Size(169, 13);
            наименованиеПодразделениеLabel.TabIndex = 3;
            наименованиеПодразделениеLabel.Text = "Наименование Подразделение:";
            // 
            // наименованиеПодразделениеTextBox
            // 
            this.наименованиеПодразделениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.подразделенияBindingSource, "НаименованиеПодразделение", true));
            this.наименованиеПодразделениеTextBox.Location = new System.Drawing.Point(175, 93);
            this.наименованиеПодразделениеTextBox.Name = "наименованиеПодразделениеTextBox";
            this.наименованиеПодразделениеTextBox.Size = new System.Drawing.Size(242, 20);
            this.наименованиеПодразделениеTextBox.TabIndex = 4;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton6.Location = new System.Drawing.Point(144, 128);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(136, 29);
            this.materialRaisedButton6.TabIndex = 70;
            this.materialRaisedButton6.Text = "Сохранить";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 119);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(427, 45);
            this.materialDivider1.TabIndex = 69;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // РаботаПодразделения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 163);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(наименованиеПодразделениеLabel);
            this.Controls.Add(this.наименованиеПодразделениеTextBox);
            this.Controls.Add(кодПодразделениеLabel);
            this.Controls.Add(this.кодПодразделениеTextBox);
            this.Name = "РаботаПодразделения";
            this.Text = "Добавление элемента в таблицу \"Подразделения\"";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.подразделенияBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource подразделенияBindingSource;
        private UchetBaseDataSetTableAdapters.ПодразделенияTableAdapter подразделенияTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодПодразделениеTextBox;
        private System.Windows.Forms.TextBox наименованиеПодразделениеTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}