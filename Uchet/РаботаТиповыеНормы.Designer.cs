namespace Uchet
{
    partial class РаботаТиповыеНормы
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
            System.Windows.Forms.Label кодТиповыеНормыLabel;
            System.Windows.Forms.Label наименованиеСИЗLabel;
            System.Windows.Forms.Label пунктТипНормLabel;
            System.Windows.Forms.Label единицаИзмеренияLabel;
            System.Windows.Forms.Label количествоНаГодLabel;
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.типовыеНормыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.типовыеНормыTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.ТиповыеНормыTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.кодТиповыеНормыTextBox = new System.Windows.Forms.TextBox();
            this.наименованиеСИЗTextBox = new System.Windows.Forms.TextBox();
            this.пунктТипНормTextBox = new System.Windows.Forms.TextBox();
            this.единицаИзмеренияTextBox = new System.Windows.Forms.TextBox();
            this.количествоНаГодTextBox = new System.Windows.Forms.TextBox();
            this.materialRaisedButton6 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            кодТиповыеНормыLabel = new System.Windows.Forms.Label();
            наименованиеСИЗLabel = new System.Windows.Forms.Label();
            пунктТипНормLabel = new System.Windows.Forms.Label();
            единицаИзмеренияLabel = new System.Windows.Forms.Label();
            количествоНаГодLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типовыеНормыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // типовыеНормыBindingSource
            // 
            this.типовыеНормыBindingSource.DataMember = "ТиповыеНормы";
            this.типовыеНормыBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // типовыеНормыTableAdapter
            // 
            this.типовыеНормыTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = this.типовыеНормыTableAdapter;
            // 
            // кодТиповыеНормыLabel
            // 
            кодТиповыеНормыLabel.AutoSize = true;
            кодТиповыеНормыLabel.Location = new System.Drawing.Point(11, 72);
            кодТиповыеНормыLabel.Name = "кодТиповыеНормыLabel";
            кодТиповыеНормыLabel.Size = new System.Drawing.Size(116, 13);
            кодТиповыеНормыLabel.TabIndex = 1;
            кодТиповыеНормыLabel.Text = "Код Типовые Нормы:";
            // 
            // кодТиповыеНормыTextBox
            // 
            this.кодТиповыеНормыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типовыеНормыBindingSource, "КодТиповыеНормы", true));
            this.кодТиповыеНормыTextBox.Location = new System.Drawing.Point(133, 69);
            this.кодТиповыеНормыTextBox.Name = "кодТиповыеНормыTextBox";
            this.кодТиповыеНормыTextBox.Size = new System.Drawing.Size(276, 20);
            this.кодТиповыеНормыTextBox.TabIndex = 2;
            // 
            // наименованиеСИЗLabel
            // 
            наименованиеСИЗLabel.AutoSize = true;
            наименованиеСИЗLabel.Location = new System.Drawing.Point(16, 98);
            наименованиеСИЗLabel.Name = "наименованиеСИЗLabel";
            наименованиеСИЗLabel.Size = new System.Drawing.Size(111, 13);
            наименованиеСИЗLabel.TabIndex = 3;
            наименованиеСИЗLabel.Text = "Наименование СИЗ:";
            // 
            // наименованиеСИЗTextBox
            // 
            this.наименованиеСИЗTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типовыеНормыBindingSource, "НаименованиеСИЗ", true));
            this.наименованиеСИЗTextBox.Location = new System.Drawing.Point(133, 95);
            this.наименованиеСИЗTextBox.Name = "наименованиеСИЗTextBox";
            this.наименованиеСИЗTextBox.Size = new System.Drawing.Size(276, 20);
            this.наименованиеСИЗTextBox.TabIndex = 4;
            // 
            // пунктТипНормLabel
            // 
            пунктТипНормLabel.AutoSize = true;
            пунктТипНормLabel.Location = new System.Drawing.Point(13, 124);
            пунктТипНормLabel.Name = "пунктТипНормLabel";
            пунктТипНормLabel.Size = new System.Drawing.Size(114, 13);
            пунктТипНормLabel.TabIndex = 5;
            пунктТипНормLabel.Text = "Пункт типовых норм:";
            // 
            // пунктТипНормTextBox
            // 
            this.пунктТипНормTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типовыеНормыBindingSource, "ПунктТипНорм", true));
            this.пунктТипНормTextBox.Location = new System.Drawing.Point(133, 121);
            this.пунктТипНормTextBox.Name = "пунктТипНормTextBox";
            this.пунктТипНормTextBox.Size = new System.Drawing.Size(276, 20);
            this.пунктТипНормTextBox.TabIndex = 6;
            // 
            // единицаИзмеренияLabel
            // 
            единицаИзмеренияLabel.AutoSize = true;
            единицаИзмеренияLabel.Location = new System.Drawing.Point(13, 150);
            единицаИзмеренияLabel.Name = "единицаИзмеренияLabel";
            единицаИзмеренияLabel.Size = new System.Drawing.Size(114, 13);
            единицаИзмеренияLabel.TabIndex = 7;
            единицаИзмеренияLabel.Text = "Единица Измерения:";
            // 
            // единицаИзмеренияTextBox
            // 
            this.единицаИзмеренияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типовыеНормыBindingSource, "ЕдиницаИзмерения", true));
            this.единицаИзмеренияTextBox.Location = new System.Drawing.Point(133, 147);
            this.единицаИзмеренияTextBox.Name = "единицаИзмеренияTextBox";
            this.единицаИзмеренияTextBox.Size = new System.Drawing.Size(276, 20);
            this.единицаИзмеренияTextBox.TabIndex = 8;
            // 
            // количествоНаГодLabel
            // 
            количествоНаГодLabel.AutoSize = true;
            количествоНаГодLabel.Location = new System.Drawing.Point(20, 176);
            количествоНаГодLabel.Name = "количествоНаГодLabel";
            количествоНаГодLabel.Size = new System.Drawing.Size(107, 13);
            количествоНаГодLabel.TabIndex = 9;
            количествоНаГодLabel.Text = "Количество На Год:";
            // 
            // количествоНаГодTextBox
            // 
            this.количествоНаГодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.типовыеНормыBindingSource, "КоличествоНаГод", true));
            this.количествоНаГодTextBox.Location = new System.Drawing.Point(133, 173);
            this.количествоНаГодTextBox.Name = "количествоНаГодTextBox";
            this.количествоНаГодTextBox.Size = new System.Drawing.Size(276, 20);
            this.количествоНаГодTextBox.TabIndex = 10;
            // 
            // materialRaisedButton6
            // 
            this.materialRaisedButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton6.Depth = 0;
            this.materialRaisedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton6.Location = new System.Drawing.Point(152, 206);
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
            this.materialDivider1.Location = new System.Drawing.Point(0, 198);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(426, 45);
            this.materialDivider1.TabIndex = 67;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // РаботаТиповыеНормы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 242);
            this.Controls.Add(this.materialRaisedButton6);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(количествоНаГодLabel);
            this.Controls.Add(this.количествоНаГодTextBox);
            this.Controls.Add(единицаИзмеренияLabel);
            this.Controls.Add(this.единицаИзмеренияTextBox);
            this.Controls.Add(пунктТипНормLabel);
            this.Controls.Add(this.пунктТипНормTextBox);
            this.Controls.Add(наименованиеСИЗLabel);
            this.Controls.Add(this.наименованиеСИЗTextBox);
            this.Controls.Add(кодТиповыеНормыLabel);
            this.Controls.Add(this.кодТиповыеНормыTextBox);
            this.Name = "РаботаТиповыеНормы";
            this.Text = "Добавление элемента в таблицу \"Типовые нормы\"";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типовыеНормыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource типовыеНормыBindingSource;
        private UchetBaseDataSetTableAdapters.ТиповыеНормыTableAdapter типовыеНормыTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодТиповыеНормыTextBox;
        private System.Windows.Forms.TextBox наименованиеСИЗTextBox;
        private System.Windows.Forms.TextBox пунктТипНормTextBox;
        private System.Windows.Forms.TextBox единицаИзмеренияTextBox;
        private System.Windows.Forms.TextBox количествоНаГодTextBox;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton6;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}