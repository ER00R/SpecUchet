namespace Uchet
{
    partial class РаботаСЛКОборот
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
            System.Windows.Forms.Label наименованиеСИЗLabel;
            System.Windows.Forms.Label сертификатСоответствияLabel;
            System.Windows.Forms.Label выданоДатаLabel;
            System.Windows.Forms.Label выданоКоличествоLabel;
            System.Windows.Forms.Label выданоИзносLabel;
            System.Windows.Forms.Label возвращеноДатаLabel;
            System.Windows.Forms.Label возвращеноКоличествоLabel;
            System.Windows.Forms.Label возвращеноИзносLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(РаботаСЛКОборот));
            this.uchetBaseDataSet = new Uchet.UchetBaseDataSet();
            this.сведенияОВыдачеСИЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сведенияОВыдачеСИЗTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.СведенияОВыдачеСИЗTableAdapter();
            this.tableAdapterManager = new Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager();
            this.сИЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сИЗTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.СИЗTableAdapter();
            this.выдачаСИЗBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выдачаСИЗTableAdapter = new Uchet.UchetBaseDataSetTableAdapters.ВыдачаСИЗTableAdapter();
            this.выдачаСИЗDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.наименованиеСИЗComboBox = new System.Windows.Forms.ComboBox();
            this.сертификатСоответствияComboBox = new System.Windows.Forms.ComboBox();
            this.выданоДатаTextBox = new System.Windows.Forms.TextBox();
            this.выданоКоличествоTextBox = new System.Windows.Forms.TextBox();
            this.выданоИзносTextBox = new System.Windows.Forms.TextBox();
            this.возвращеноДатаTextBox = new System.Windows.Forms.TextBox();
            this.возвращеноКоличествоTextBox = new System.Windows.Forms.TextBox();
            this.возвращеноИзносTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            наименованиеСИЗLabel = new System.Windows.Forms.Label();
            сертификатСоответствияLabel = new System.Windows.Forms.Label();
            выданоДатаLabel = new System.Windows.Forms.Label();
            выданоКоличествоLabel = new System.Windows.Forms.Label();
            выданоИзносLabel = new System.Windows.Forms.Label();
            возвращеноДатаLabel = new System.Windows.Forms.Label();
            возвращеноКоличествоLabel = new System.Windows.Forms.Label();
            возвращеноИзносLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОВыдачеСИЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаСИЗBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаСИЗDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // uchetBaseDataSet
            // 
            this.uchetBaseDataSet.DataSetName = "UchetBaseDataSet";
            this.uchetBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сведенияОВыдачеСИЗBindingSource
            // 
            this.сведенияОВыдачеСИЗBindingSource.DataMember = "СведенияОВыдачеСИЗ";
            this.сведенияОВыдачеСИЗBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // сведенияОВыдачеСИЗTableAdapter
            // 
            this.сведенияОВыдачеСИЗTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Uchet.UchetBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыдачаСИЗTableAdapter = this.выдачаСИЗTableAdapter;
            this.tableAdapterManager.ЛичнаяКарточкаTableAdapter = null;
            this.tableAdapterManager.ПодразделенияTableAdapter = null;
            this.tableAdapterManager.ПолTableAdapter = null;
            this.tableAdapterManager.ПрофессииTableAdapter = null;
            this.tableAdapterManager.СведенияОВыдачеСИЗTableAdapter = this.сведенияОВыдачеСИЗTableAdapter;
            this.tableAdapterManager.СведенияОтиповыхНормахTableAdapter = null;
            this.tableAdapterManager.СИЗTableAdapter = this.сИЗTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.ТиповыеНормыTableAdapter = null;
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
            // выдачаСИЗBindingSource
            // 
            this.выдачаСИЗBindingSource.DataMember = "ВыдачаСИЗ";
            this.выдачаСИЗBindingSource.DataSource = this.uchetBaseDataSet;
            // 
            // выдачаСИЗTableAdapter
            // 
            this.выдачаСИЗTableAdapter.ClearBeforeFill = true;
            // 
            // выдачаСИЗDataGridView
            // 
            this.выдачаСИЗDataGridView.AutoGenerateColumns = false;
            this.выдачаСИЗDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выдачаСИЗDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.выдачаСИЗDataGridView.DataSource = this.выдачаСИЗBindingSource;
            this.выдачаСИЗDataGridView.Location = new System.Drawing.Point(12, 71);
            this.выдачаСИЗDataGridView.Name = "выдачаСИЗDataGridView";
            this.выдачаСИЗDataGridView.Size = new System.Drawing.Size(966, 290);
            this.выдачаСИЗDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодВыдача";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодВыдача";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "НаименованиеСИЗ";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование СИЗ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "СертификатСоответствия";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сертификат cоответствия";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ВыданоДата";
            this.dataGridViewTextBoxColumn4.HeaderText = "Выдано дата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ВыданоКоличество";
            this.dataGridViewTextBoxColumn5.HeaderText = "Выдано количество";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ВыданоИзнос";
            this.dataGridViewTextBoxColumn6.HeaderText = "Выдано износ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ПодписьПолучившего";
            this.dataGridViewTextBoxColumn7.HeaderText = "Подпись получившего";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ВозвращеноДата";
            this.dataGridViewTextBoxColumn8.HeaderText = "Возвращено дата";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ВозвращеноКоличество";
            this.dataGridViewTextBoxColumn9.HeaderText = "Возвращено количество";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ВозвращеноИзнос";
            this.dataGridViewTextBoxColumn10.HeaderText = "Возвращено износ";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ПодписьСдавшего";
            this.dataGridViewTextBoxColumn11.HeaderText = "Подпись сдавшего";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ПодписьПринявшего";
            this.dataGridViewTextBoxColumn12.HeaderText = "Подпись принявшего";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 367);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1005, 246);
            this.materialDivider1.TabIndex = 50;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // наименованиеСИЗLabel
            // 
            наименованиеСИЗLabel.AutoSize = true;
            наименованиеСИЗLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            наименованиеСИЗLabel.ForeColor = System.Drawing.Color.White;
            наименованиеСИЗLabel.Location = new System.Drawing.Point(66, 401);
            наименованиеСИЗLabel.Name = "наименованиеСИЗLabel";
            наименованиеСИЗLabel.Size = new System.Drawing.Size(111, 13);
            наименованиеСИЗLabel.TabIndex = 50;
            наименованиеСИЗLabel.Text = "Наименование СИЗ:";
            // 
            // наименованиеСИЗComboBox
            // 
            this.наименованиеСИЗComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "НаименованиеСИЗ", true));
            this.наименованиеСИЗComboBox.FormattingEnabled = true;
            this.наименованиеСИЗComboBox.Location = new System.Drawing.Point(183, 398);
            this.наименованиеСИЗComboBox.Name = "наименованиеСИЗComboBox";
            this.наименованиеСИЗComboBox.Size = new System.Drawing.Size(208, 21);
            this.наименованиеСИЗComboBox.TabIndex = 51;
            // 
            // сертификатСоответствияLabel
            // 
            сертификатСоответствияLabel.AutoSize = true;
            сертификатСоответствияLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            сертификатСоответствияLabel.ForeColor = System.Drawing.Color.White;
            сертификатСоответствияLabel.Location = new System.Drawing.Point(33, 428);
            сертификатСоответствияLabel.Name = "сертификатСоответствияLabel";
            сертификатСоответствияLabel.Size = new System.Drawing.Size(144, 13);
            сертификатСоответствияLabel.TabIndex = 51;
            сертификатСоответствияLabel.Text = "Сертификат Соответствия:";
            // 
            // сертификатСоответствияComboBox
            // 
            this.сертификатСоответствияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "СертификатСоответствия", true));
            this.сертификатСоответствияComboBox.FormattingEnabled = true;
            this.сертификатСоответствияComboBox.Location = new System.Drawing.Point(183, 425);
            this.сертификатСоответствияComboBox.Name = "сертификатСоответствияComboBox";
            this.сертификатСоответствияComboBox.Size = new System.Drawing.Size(208, 21);
            this.сертификатСоответствияComboBox.TabIndex = 52;
            // 
            // выданоДатаLabel
            // 
            выданоДатаLabel.AutoSize = true;
            выданоДатаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            выданоДатаLabel.ForeColor = System.Drawing.Color.White;
            выданоДатаLabel.Location = new System.Drawing.Point(99, 455);
            выданоДатаLabel.Name = "выданоДатаLabel";
            выданоДатаLabel.Size = new System.Drawing.Size(78, 13);
            выданоДатаLabel.TabIndex = 52;
            выданоДатаLabel.Text = "Выдано Дата:";
            // 
            // выданоДатаTextBox
            // 
            this.выданоДатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВыданоДата", true));
            this.выданоДатаTextBox.Location = new System.Drawing.Point(183, 452);
            this.выданоДатаTextBox.Name = "выданоДатаTextBox";
            this.выданоДатаTextBox.Size = new System.Drawing.Size(208, 20);
            this.выданоДатаTextBox.TabIndex = 53;
            // 
            // выданоКоличествоLabel
            // 
            выданоКоличествоLabel.AutoSize = true;
            выданоКоличествоLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            выданоКоличествоLabel.ForeColor = System.Drawing.Color.White;
            выданоКоличествоLabel.Location = new System.Drawing.Point(66, 481);
            выданоКоличествоLabel.Name = "выданоКоличествоLabel";
            выданоКоличествоLabel.Size = new System.Drawing.Size(111, 13);
            выданоКоличествоLabel.TabIndex = 53;
            выданоКоличествоLabel.Text = "Выдано Количество:";
            // 
            // выданоКоличествоTextBox
            // 
            this.выданоКоличествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВыданоКоличество", true));
            this.выданоКоличествоTextBox.Location = new System.Drawing.Point(183, 478);
            this.выданоКоличествоTextBox.Name = "выданоКоличествоTextBox";
            this.выданоКоличествоTextBox.Size = new System.Drawing.Size(208, 20);
            this.выданоКоличествоTextBox.TabIndex = 54;
            // 
            // выданоИзносLabel
            // 
            выданоИзносLabel.AutoSize = true;
            выданоИзносLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            выданоИзносLabel.ForeColor = System.Drawing.Color.White;
            выданоИзносLabel.Location = new System.Drawing.Point(93, 507);
            выданоИзносLabel.Name = "выданоИзносLabel";
            выданоИзносLabel.Size = new System.Drawing.Size(84, 13);
            выданоИзносLabel.TabIndex = 54;
            выданоИзносLabel.Text = "Выдано Износ:";
            // 
            // выданоИзносTextBox
            // 
            this.выданоИзносTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВыданоИзнос", true));
            this.выданоИзносTextBox.Location = new System.Drawing.Point(183, 504);
            this.выданоИзносTextBox.Name = "выданоИзносTextBox";
            this.выданоИзносTextBox.Size = new System.Drawing.Size(208, 20);
            this.выданоИзносTextBox.TabIndex = 55;
            // 
            // возвращеноДатаLabel
            // 
            возвращеноДатаLabel.AutoSize = true;
            возвращеноДатаLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            возвращеноДатаLabel.ForeColor = System.Drawing.Color.White;
            возвращеноДатаLabel.Location = new System.Drawing.Point(437, 401);
            возвращеноДатаLabel.Name = "возвращеноДатаLabel";
            возвращеноДатаLabel.Size = new System.Drawing.Size(103, 13);
            возвращеноДатаLabel.TabIndex = 55;
            возвращеноДатаLabel.Text = "Возвращено Дата:";
            // 
            // возвращеноДатаTextBox
            // 
            this.возвращеноДатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВозвращеноДата", true));
            this.возвращеноДатаTextBox.Location = new System.Drawing.Point(546, 398);
            this.возвращеноДатаTextBox.Name = "возвращеноДатаTextBox";
            this.возвращеноДатаTextBox.Size = new System.Drawing.Size(172, 20);
            this.возвращеноДатаTextBox.TabIndex = 56;
            // 
            // возвращеноКоличествоLabel
            // 
            возвращеноКоличествоLabel.AutoSize = true;
            возвращеноКоличествоLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            возвращеноКоличествоLabel.ForeColor = System.Drawing.Color.White;
            возвращеноКоличествоLabel.Location = new System.Drawing.Point(404, 428);
            возвращеноКоличествоLabel.Name = "возвращеноКоличествоLabel";
            возвращеноКоличествоLabel.Size = new System.Drawing.Size(136, 13);
            возвращеноКоличествоLabel.TabIndex = 56;
            возвращеноКоличествоLabel.Text = "Возвращено Количество:";
            // 
            // возвращеноКоличествоTextBox
            // 
            this.возвращеноКоличествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВозвращеноКоличество", true));
            this.возвращеноКоличествоTextBox.Location = new System.Drawing.Point(546, 425);
            this.возвращеноКоличествоTextBox.Name = "возвращеноКоличествоTextBox";
            this.возвращеноКоличествоTextBox.Size = new System.Drawing.Size(172, 20);
            this.возвращеноКоличествоTextBox.TabIndex = 57;
            // 
            // возвращеноИзносLabel
            // 
            возвращеноИзносLabel.AutoSize = true;
            возвращеноИзносLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            возвращеноИзносLabel.ForeColor = System.Drawing.Color.White;
            возвращеноИзносLabel.Location = new System.Drawing.Point(431, 455);
            возвращеноИзносLabel.Name = "возвращеноИзносLabel";
            возвращеноИзносLabel.Size = new System.Drawing.Size(109, 13);
            возвращеноИзносLabel.TabIndex = 57;
            возвращеноИзносLabel.Text = "Возвращено Износ:";
            // 
            // возвращеноИзносTextBox
            // 
            this.возвращеноИзносTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.выдачаСИЗBindingSource, "ВозвращеноИзнос", true));
            this.возвращеноИзносTextBox.Location = new System.Drawing.Point(546, 452);
            this.возвращеноИзносTextBox.Name = "возвращеноИзносTextBox";
            this.возвращеноИзносTextBox.Size = new System.Drawing.Size(172, 20);
            this.возвращеноИзносTextBox.TabIndex = 58;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.White;
            this.materialLabel2.Location = new System.Drawing.Point(179, 376);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Выдача";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.Location = new System.Drawing.Point(542, 376);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 60;
            this.materialLabel1.Text = "Возврат";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(-3, 544);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(1005, 69);
            this.materialDivider5.TabIndex = 61;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton3.BackgroundImage")));
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.materialRaisedButton3.Image = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton3.Image")));
            this.materialRaisedButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialRaisedButton3.Location = new System.Drawing.Point(695, 551);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(280, 28);
            this.materialRaisedButton3.TabIndex = 62;
            this.materialRaisedButton3.Text = "Сохранить оборотную сторону";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.BackgroundImage")));
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialRaisedButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.materialRaisedButton1.Image = ((System.Drawing.Image)(resources.GetObject("materialRaisedButton1.Image")));
            this.materialRaisedButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.materialRaisedButton1.Location = new System.Drawing.Point(438, 496);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(280, 28);
            this.materialRaisedButton1.TabIndex = 63;
            this.materialRaisedButton1.Text = "Добавить значения в таблицу";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 591);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialDivider5);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(возвращеноИзносLabel);
            this.Controls.Add(this.возвращеноИзносTextBox);
            this.Controls.Add(возвращеноКоличествоLabel);
            this.Controls.Add(this.возвращеноКоличествоTextBox);
            this.Controls.Add(возвращеноДатаLabel);
            this.Controls.Add(this.возвращеноДатаTextBox);
            this.Controls.Add(выданоИзносLabel);
            this.Controls.Add(this.выданоИзносTextBox);
            this.Controls.Add(выданоКоличествоLabel);
            this.Controls.Add(this.выданоКоличествоTextBox);
            this.Controls.Add(выданоДатаLabel);
            this.Controls.Add(this.выданоДатаTextBox);
            this.Controls.Add(сертификатСоответствияLabel);
            this.Controls.Add(this.сертификатСоответствияComboBox);
            this.Controls.Add(наименованиеСИЗLabel);
            this.Controls.Add(this.наименованиеСИЗComboBox);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.выдачаСИЗDataGridView);
            this.Name = "Form14";
            this.Text = "Оборотная сторона личной карты";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uchetBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведенияОВыдачеСИЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сИЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаСИЗBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выдачаСИЗDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UchetBaseDataSet uchetBaseDataSet;
        private System.Windows.Forms.BindingSource сведенияОВыдачеСИЗBindingSource;
        private UchetBaseDataSetTableAdapters.СведенияОВыдачеСИЗTableAdapter сведенияОВыдачеСИЗTableAdapter;
        private UchetBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private UchetBaseDataSetTableAdapters.СИЗTableAdapter сИЗTableAdapter;
        private System.Windows.Forms.BindingSource сИЗBindingSource;
        private UchetBaseDataSetTableAdapters.ВыдачаСИЗTableAdapter выдачаСИЗTableAdapter;
        private System.Windows.Forms.BindingSource выдачаСИЗBindingSource;
        private System.Windows.Forms.DataGridView выдачаСИЗDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.ComboBox наименованиеСИЗComboBox;
        private System.Windows.Forms.ComboBox сертификатСоответствияComboBox;
        private System.Windows.Forms.TextBox выданоДатаTextBox;
        private System.Windows.Forms.TextBox выданоКоличествоTextBox;
        private System.Windows.Forms.TextBox выданоИзносTextBox;
        private System.Windows.Forms.TextBox возвращеноДатаTextBox;
        private System.Windows.Forms.TextBox возвращеноКоличествоTextBox;
        private System.Windows.Forms.TextBox возвращеноИзносTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}