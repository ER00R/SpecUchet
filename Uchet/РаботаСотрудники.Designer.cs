namespace Uchet
{
    partial class РаботаСотрудники
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label номерТелефонаLabel;
            System.Windows.Forms.Label кодСотрудникLabel;
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сотрудникиTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.СотрудникиTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.номерТелефонаTextBox = new System.Windows.Forms.TextBox();
            this.кодСотрудникTextBox = new System.Windows.Forms.TextBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            фИОLabel = new System.Windows.Forms.Label();
            номерТелефонаLabel = new System.Windows.Forms.Label();
            кодСотрудникLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СИЗTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(75, 99);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 1;
            фИОLabel.Text = "ФИО:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(118, 96);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(276, 20);
            this.фИОTextBox.TabIndex = 2;
            // 
            // номерТелефонаLabel
            // 
            номерТелефонаLabel.AutoSize = true;
            номерТелефонаLabel.Location = new System.Drawing.Point(14, 125);
            номерТелефонаLabel.Name = "номерТелефонаLabel";
            номерТелефонаLabel.Size = new System.Drawing.Size(98, 13);
            номерТелефонаLabel.TabIndex = 2;
            номерТелефонаLabel.Text = "Номер Телефона:";
            // 
            // номерТелефонаTextBox
            // 
            this.номерТелефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "НомерТелефона", true));
            this.номерТелефонаTextBox.Location = new System.Drawing.Point(118, 122);
            this.номерТелефонаTextBox.Name = "номерТелефонаTextBox";
            this.номерТелефонаTextBox.Size = new System.Drawing.Size(276, 20);
            this.номерТелефонаTextBox.TabIndex = 3;
            // 
            // кодСотрудникLabel
            // 
            кодСотрудникLabel.AutoSize = true;
            кодСотрудникLabel.Location = new System.Drawing.Point(27, 73);
            кодСотрудникLabel.Name = "кодСотрудникLabel";
            кодСотрудникLabel.Size = new System.Drawing.Size(85, 13);
            кодСотрудникLabel.TabIndex = 4;
            кодСотрудникLabel.Text = "Код Сотрудник:";
            // 
            // кодСотрудникTextBox
            // 
            this.кодСотрудникTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сотрудникиBindingSource, "КодСотрудник", true));
            this.кодСотрудникTextBox.Location = new System.Drawing.Point(118, 70);
            this.кодСотрудникTextBox.Name = "кодСотрудникTextBox";
            this.кодСотрудникTextBox.Size = new System.Drawing.Size(276, 20);
            this.кодСотрудникTextBox.TabIndex = 5;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-2, 148);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(414, 45);
            this.materialDivider1.TabIndex = 62;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton6.Location = new System.Drawing.Point(141, 155);
            this.materialRaisedButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton6.Name = "materialRaisedButton6";
            this.materialRaisedButton6.Primary = true;
            this.materialRaisedButton6.Size = new System.Drawing.Size(136, 29);
            this.materialRaisedButton6.TabIndex = 66;
            this.materialRaisedButton6.Text = "Сохранить";
            this.materialRaisedButton6.UseVisualStyleBackColor = true;
            // 
            // РаботаСотрудники
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 190);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(кодСотрудникLabel);
            this.Controls.Add(this.кодСотрудникTextBox);
            this.Controls.Add(номерТелефонаLabel);
            this.Controls.Add(this.номерТелефонаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Name = "РаботаСотрудники";
            this.Text = "Добавление элемента в таблицу \"Сотрудники\"";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private UchetBaseDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox номерТелефонаTextBox;
        private System.Windows.Forms.TextBox кодСотрудникTextBox;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
    }
}