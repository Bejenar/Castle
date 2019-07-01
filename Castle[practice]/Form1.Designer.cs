using System;

namespace Castle_practice_
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обычныйФорматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бинарныйФорматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редакторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьСтенуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разрушитьСтенуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конверторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.числоКомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоСтенToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.площадьКомнатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.openToolStripMenuItem.Image = global::Castle_practice_.Properties.Resources.document_text_512;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.openToolStripMenuItem.Text = "Файл";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = global::Castle_practice_.Properties.Resources.folder_icon_512x512;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = global::Castle_practice_.Properties.Resources.Paomedia_Small_N_Flat_Floppy;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйФорматToolStripMenuItem,
            this.бинарныйФорматToolStripMenuItem});
            this.сохранитьКакToolStripMenuItem.Image = global::Castle_practice_.Properties.Resources.Paomedia_Small_N_Flat_Floppy;
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как...";
            // 
            // обычныйФорматToolStripMenuItem
            // 
            this.обычныйФорматToolStripMenuItem.Name = "обычныйФорматToolStripMenuItem";
            this.обычныйФорматToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.обычныйФорматToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.обычныйФорматToolStripMenuItem.Text = "Обычный формат";
            this.обычныйФорматToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // бинарныйФорматToolStripMenuItem
            // 
            this.бинарныйФорматToolStripMenuItem.Name = "бинарныйФорматToolStripMenuItem";
            this.бинарныйФорматToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.бинарныйФорматToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.бинарныйФорматToolStripMenuItem.Text = "Бинарный формат";
            this.бинарныйФорматToolStripMenuItem.Click += new System.EventHandler(this.бинарныйФорматToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редакторToolStripMenuItem,
            this.конверторToolStripMenuItem,
            this.числоКомнатToolStripMenuItem,
            this.количествоСтенToolStripMenuItem,
            this.площадьКомнатыToolStripMenuItem});
            this.функцииToolStripMenuItem.Image = global::Castle_practice_.Properties.Resources.Wrench_icon_72a7cf_svg;
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.функцииToolStripMenuItem.Text = "Инструменты";
            // 
            // редакторToolStripMenuItem
            // 
            this.редакторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьСтенуToolStripMenuItem,
            this.разрушитьСтенуToolStripMenuItem});
            this.редакторToolStripMenuItem.Name = "редакторToolStripMenuItem";
            this.редакторToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.редакторToolStripMenuItem.Text = "Редактор";
            // 
            // построитьСтенуToolStripMenuItem
            // 
            this.построитьСтенуToolStripMenuItem.Name = "построитьСтенуToolStripMenuItem";
            this.построитьСтенуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.построитьСтенуToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.построитьСтенуToolStripMenuItem.Text = "Построить стену";
            this.построитьСтенуToolStripMenuItem.Click += new System.EventHandler(this.построитьСтенуToolStripMenuItem_Click);
            // 
            // разрушитьСтенуToolStripMenuItem
            // 
            this.разрушитьСтенуToolStripMenuItem.Name = "разрушитьСтенуToolStripMenuItem";
            this.разрушитьСтенуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.разрушитьСтенуToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.разрушитьСтенуToolStripMenuItem.Text = "Разрушить стену";
            this.разрушитьСтенуToolStripMenuItem.Click += new System.EventHandler(this.разрушитьСтенуToolStripMenuItem_Click);
            // 
            // конверторToolStripMenuItem
            // 
            this.конверторToolStripMenuItem.Name = "конверторToolStripMenuItem";
            this.конверторToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.конверторToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.конверторToolStripMenuItem.Text = "Бинарный конвентор";
            this.конверторToolStripMenuItem.Click += new System.EventHandler(this.конверторToolStripMenuItem_Click);
            // 
            // числоКомнатToolStripMenuItem
            // 
            this.числоКомнатToolStripMenuItem.Name = "числоКомнатToolStripMenuItem";
            this.числоКомнатToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.числоКомнатToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.числоКомнатToolStripMenuItem.Text = "Число комнат";
            this.числоКомнатToolStripMenuItem.Click += new System.EventHandler(this.числоКомнатToolStripMenuItem_Click);
            // 
            // количествоСтенToolStripMenuItem
            // 
            this.количествоСтенToolStripMenuItem.Name = "количествоСтенToolStripMenuItem";
            this.количествоСтенToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.количествоСтенToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.количествоСтенToolStripMenuItem.Text = "Количество стен";
            this.количествоСтенToolStripMenuItem.Click += new System.EventHandler(this.количествоСтенToolStripMenuItem_Click);
            // 
            // площадьКомнатыToolStripMenuItem
            // 
            this.площадьКомнатыToolStripMenuItem.Name = "площадьКомнатыToolStripMenuItem";
            this.площадьКомнатыToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.площадьКомнатыToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.площадьКомнатыToolStripMenuItem.Text = "Площадь комнаты";
            this.площадьКомнатыToolStripMenuItem.Click += new System.EventHandler(this.площадьКомнатыToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 352);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 185);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Castle_practice_.Properties.Resources._89009;
            this.pictureBox1.Location = new System.Drawing.Point(10, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(623, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Castle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редакторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьСтенуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разрушитьСтенуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обычныйФорматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бинарныйФорматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конверторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоСтенToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem числоКомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem площадьКомнатыToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

