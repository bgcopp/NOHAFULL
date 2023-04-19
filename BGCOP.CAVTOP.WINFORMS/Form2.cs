using BGCOP.CAVTOP.BUSINESSLAYER;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class Form2 : Form
	{
		private IContainer components = null;

		private DataGridView dataGridView1;

		public Form2()
		{
			this.InitializeComponent();
		}

		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Empleados empleado = new Empleados();
			this.dataGridView1.DataSource = empleado.ListarTodos();
		}

		private void InitializeComponent()
		{
			this.dataGridView1 = new DataGridView();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(814, 443);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(838, 467);
			base.Controls.Add(this.dataGridView1);
			base.Name = "Form2";
			this.Text = "Form2";
			base.Load += new EventHandler(this.Form2_Load);
			((ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}
	}
}