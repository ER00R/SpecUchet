namespace Uchet
{
    partial class РаботаСИЗ
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
            System.Windows.Forms.Label кодСИЗLabel;
            System.Windows.Forms.Label наименованиеLabel;
            System.Windows.Forms.Label сертификатСоответствияLabel;
            System.Windows.Forms.Label размерLabel;
            System.Windows.Forms.Label стоимостьLabel;
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.сИЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сИЗTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.СИЗTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.кодСИЗTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеTextBox = new System.Windows.Forms.TextBox();
            this.сертификатСоответствияTextBox = new System.Windows.Forms.TextBox();
            this.размерTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            кодСИЗLabel = new System.Windows.Forms.Label();
            наименованиеLabel = new System.Windows.Forms.Label();
            сертификатСоответствияLabel = new System.Windows.Forms.Label();
            размерLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сИЗBindingSource
            // 
            this.сИЗBindingSource.DataMember = "СИЗ";
            this.сИЗBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // сИЗTableAdapter
            // 
            this.сИЗTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыдачаСИЗTableAdapter = null;
            this.tableAdapterManager.ЛичнаяКарточкаTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = null;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПрофессииTableAdapter = null;
            this.tableAdapterManager.СведенияОВыдачеСИЗTableAdapter = null;
            this.tableAdapterManager.СведенияОтиповыхНормахTableAdapter = null;
            this.tableAdapterManager.СИЗTableAdapter = this.сИЗTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
            // 
            // кодСИЗLabel
            // 
            кодСИЗLabel.AutoSize = true;
            кодСИЗLabel.Location = new System.Drawing.Point(93, 72);
            кодСИЗLabel.Name = "кодСИЗLabel";
            кодСИЗLabel.Size = new System.Drawing.Size(54, 13);
            кодСИЗLabel.TabIndex = 1;
            кодСИЗLabel.Text = "Код СИЗ:";
            // 
            // кодСИЗTextBox
            // 
            this.кодСИЗTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сИЗBindingSource, "КодСИЗ", true));
            this.кодСИЗTextBox.Location = new System.Drawing.Point(153, 69);
            this.кодСИЗTextBox.Name = "кодСИЗTextBox";
            this.кодСИЗTextBox.Size = new System.Drawing.Size(232, 20);
            this.кодСИЗTextBox.TabIndex = 2;
            // 
            // наименованиеLabel
            // 
            наименованиеLabel.AutoSize = true;
            наименованиеLabel.Location = new System.Drawing.Point(61, 98);
            наименованиеLabel.Name = "наименованиеLabel";
            наименованиеLabel.Size = new System.Drawing.Size(86, 13);
            наименованиеLabel.TabIndex = 3;
            наименованиеLabel.Text = "Наименование:";
            // 
            // наименованиеTextBox
            // 
            this.наименованиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сИЗBindingSource, "Наименование", true));
            this.наименованиеTextBox.Location = new System.Drawing.Point(153, 95);
            this.наименованиеTextBox.Name = "наименованиеTextBox";
            this.наименованиеTextBox.Size = new System.Drawing.Size(232, 20);
            this.наименованиеTextBox.TabIndex = 4;
            // 
            // сертификатСоответствияLabel
            // 
            сертификатСоответствияLabel.AutoSize = true;
            сертификатСоответствияLabel.Location = new System.Drawing.Point(3, 124);
            сертификатСоответствияLabel.Name = "сертификатСоответствияLabel";
            сертификатСоответствияLabel.Size = new System.Drawing.Size(144, 13);
            сертификатСоответствияLabel.TabIndex = 4;
            сертификатСоответствияLabel.Text = "Сертификат Соответствия:";
            // 
            // сертификатСоответствияTextBox
            // 
            this.сертификатСоответствияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сИЗBindingSource, "СертификатСоответствия", true));
            this.сертификатСоответствияTextBox.Location = new System.Drawing.Point(153, 121);
            this.сертификатСоответствияTextBox.Name = "сертификатСоответствияTextBox";
            this.сертификатСоответствияTextBox.Size = new System.Drawing.Size(232, 20);
            this.сертификатСоответствияTextBox.TabIndex = 5;
            // 
            // размерLabel
            // 
            размерLabel.AutoSize = true;
            размерLabel.Location = new System.Drawing.Point(98, 150);
            размерLabel.Name = "размерLabel";
            размерLabel.Size = new System.Drawing.Size(49, 13);
            размерLabel.TabIndex = 6;
            размерLabel.Text = "Размер:";
            // 
            // размерTextBox
            // 
            this.размерTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сИЗBindingSource, "Размер", true));
            this.размерTextBox.Location = new System.Drawing.Point(153, 147);
            this.размерTextBox.Name = "размерTextBox";
            this.размерTextBox.Size = new System.Drawing.Size(232, 20);
            this.размерTextBox.TabIndex = 7;
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(82, 176);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(65, 13);
            стоимостьLabel.TabIndex = 8;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сИЗBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(153, 173);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(232, 20);
            this.стоимостьTextBox.TabIndex = 9;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton6.Location = new System.Drawing.Point(130, 205);
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
            this.materialDivider1.Location = new System.Drawing.Point(0, 199);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(394, 45);
            this.materialDivider1.TabIndex = 69;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // РаботаСИЗ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 242);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(размерLabel);
            this.Controls.Add(this.размерTextBox);
            this.Controls.Add(сертификатСоответствияLabel);
            this.Controls.Add(this.сертификатСоответствияTextBox);
            this.Controls.Add(наименованиеLabel);
            this.Controls.Add(this.наименованиеTextBox);
            this.Controls.Add(кодСИЗLabel);
            this.Controls.Add(this.кодСИЗTextBox);
            this.Name = "РаботаСИЗ";
            this.Text = "Добавление элемента в таблицу \"СИЗ\"";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource сИЗBindingSource;
        private UchetBaseDataSetTableAdapters.СИЗTableAdapter сИЗTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодСИЗTextBox;
        private System.Windows.Forms.TextBox наименованиеTextBox;
        private System.Windows.Forms.TextBox сертификатСоответствияTextBox;
        private System.Windows.Forms.TextBox размерTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}