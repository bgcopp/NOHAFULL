using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmHorarioDetail : Form
	{
		private IContainer components = null;

		private Label label1;

		private Panel panel2;

		private ComboBox comboBox1;

		private Label label4;

		private DateTimePicker dateTimePicker1;

		private DateTimePicker dateTimePicker2;

		private Label label2;

		private Label label3;

		private Button button1;

		private TextBox textBox1;

		private Label label5;

		public int idH;

		public frmHorarioDetail()
		{
			this.InitializeComponent();
			base.Closing += new CancelEventHandler(this.frmHorarioDetail_Closing);
			base.Load += new EventHandler(this.frmHorarioDetail_Load);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DiasHorario diasHorario = new DiasHorario();
			string shortTimeString = this.dateTimePicker1.Value.ToShortTimeString();
			string str = this.dateTimePicker2.Value.ToShortTimeString();
			diasHorario.Agregar(this.idH, this.comboBox1.SelectedIndex + 1, shortTimeString, str, this.textBox1.Text);
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmHorarioDetail_Closing(object sender, CancelEventArgs e)
		{
			Settings @default = Settings.Default;
			DateTime value = this.dateTimePicker1.Value;
			@default.FLqW1 = value.ToString();
			Settings str = Settings.Default;
			value = this.dateTimePicker2.Value;
			str.FLqW2 = value.ToString();
		}

		private void frmHorarioDetail_Load(object sender, EventArgs e)
		{
			if (Settings.Default.FLqW1 == "nn")
			{
				Settings.Default.FLqW1 = DateTime.Now.ToString();
				Settings.Default.FLqW2 = DateTime.Now.ToString();
			}
			this.dateTimePicker1.Value = Convert.ToDateTime(Settings.Default.FLqW1);
			this.dateTimePicker2.Value = Convert.ToDateTime(Settings.Default.FLqW2);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmHorarioDetail));
			this.label1 = new Label();
			this.panel2 = new Panel();
			this.comboBox1 = new ComboBox();
			this.label4 = new Label();
			this.dateTimePicker1 = new DateTimePicker();
			this.dateTimePicker2 = new DateTimePicker();
			this.label2 = new Label();
			this.label3 = new Label();
			this.button1 = new Button();
			this.textBox1 = new TextBox();
			this.label5 = new Label();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(6, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Detalles";
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(256, 53);
			this.panel2.TabIndex = 2;
			this.comboBox1.BackColor = Color.Orange;
			this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = FlatStyle.Flat;
			this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.comboBox1.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.comboBox1.Items;
			object[] objArray = new object[] { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado" };
			items.AddRange(objArray);
			this.comboBox1.Location = new Point(74, 85);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(167, 24);
			this.comboBox1.TabIndex = 3;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.Location = new Point(38, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 18);
			this.label4.TabIndex = 31;
			this.label4.Text = "Dia";
			this.dateTimePicker1.Font = new System.Drawing.Font("Arial Narrow", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dateTimePicker1.Format = DateTimePickerFormat.Time;
			this.dateTimePicker1.Location = new Point(74, 124);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.ShowUpDown = true;
			this.dateTimePicker1.Size = new System.Drawing.Size(157, 25);
			this.dateTimePicker1.TabIndex = 32;
			this.dateTimePicker2.Font = new System.Drawing.Font("Arial Narrow", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.dateTimePicker2.Format = DateTimePickerFormat.Time;
			this.dateTimePicker2.Location = new Point(74, 155);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.ShowUpDown = true;
			this.dateTimePicker2.Size = new System.Drawing.Size(157, 25);
			this.dateTimePicker2.TabIndex = 33;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(15, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 18);
			this.label2.TabIndex = 34;
			this.label2.Text = "Hora 1";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.Location = new Point(15, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 18);
			this.label3.TabIndex = 35;
			this.label3.Text = "Hora 2";
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Image = Resources.Tick_icon;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(74, 261);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(157, 53);
			this.button1.TabIndex = 36;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.textBox1.Location = new Point(74, 185);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(157, 70);
			this.textBox1.TabIndex = 37;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.Location = new Point(21, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 18);
			this.label5.TabIndex = 38;
			this.label5.Text = "Notas";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.ClientSize = new System.Drawing.Size(256, 326);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.dateTimePicker2);
			base.Controls.Add(this.dateTimePicker1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.comboBox1);
			base.Controls.Add(this.panel2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "frmHorarioDetail";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Detalles";
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}