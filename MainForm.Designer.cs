
namespace Yulya
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.list = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolvo_sklad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kolvo_upak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ed_izm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addbtn = new System.Windows.Forms.Button();
            this.chngbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.type,
            this.price,
            this.kolvo_sklad,
            this.kolvo_upak,
            this.ed_izm});
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(40, 82);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(522, 288);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Наименование материала";
            this.name.Width = 107;
            // 
            // type
            // 
            this.type.Text = "Тип материала";
            this.type.Width = 80;
            // 
            // price
            // 
            this.price.Text = "Цена";
            // 
            // kolvo_sklad
            // 
            this.kolvo_sklad.Text = "Количество на складе";
            this.kolvo_sklad.Width = 100;
            // 
            // kolvo_upak
            // 
            this.kolvo_upak.Text = "Количество в упаковке";
            // 
            // ed_izm
            // 
            this.ed_izm.Text = "Единица измерения";
            // 
            // addbtn
            // 
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addbtn.Location = new System.Drawing.Point(631, 97);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(122, 53);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "Добавить материал";
            this.toolTip1.SetToolTip(this.addbtn, "Добавить материал в список");
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // chngbtn
            // 
            this.chngbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chngbtn.Location = new System.Drawing.Point(631, 194);
            this.chngbtn.Name = "chngbtn";
            this.chngbtn.Size = new System.Drawing.Size(122, 54);
            this.chngbtn.TabIndex = 2;
            this.chngbtn.Text = "Редактировать материал";
            this.chngbtn.UseVisualStyleBackColor = true;
            this.chngbtn.Click += new System.EventHandler(this.chngbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delbtn.Location = new System.Drawing.Point(631, 284);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(122, 52);
            this.delbtn.TabIndex = 3;
            this.delbtn.Text = "Удалить материал";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.chngbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.list);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button chngbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader kolvo_sklad;
        private System.Windows.Forms.ColumnHeader kolvo_upak;
        private System.Windows.Forms.ColumnHeader ed_izm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

