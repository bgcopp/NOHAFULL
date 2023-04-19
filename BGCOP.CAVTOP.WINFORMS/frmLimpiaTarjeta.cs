using BGCOP.CAVTOP.BUSINESSLAYER;
using BGCOP.CAVTOP.WINFORMS.Properties;
using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class frmLimpiaTarjeta : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Panel panel2;

		private Label label1;

		private Label label3;

		private TextBox txttarjeta;

		private Label label2;

		private Button btnAgregar;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		public frmLimpiaTarjeta()
		{
			this.InitializeComponent();
		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			(new Tarjetas()).limpiarTarjeta(this.txttarjeta.Text);
			this.txttarjeta.Text = "";
			MessageBox.Show("El registro se modificó con exito!", Settings.Default.Titulo, MessageBoxButtons.OK);
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void frmLimpiaTarjeta_Load(object sender, EventArgs e)
		{
		}

		private void InitializeComponent()
		{
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.label3 = new Label();
			this.txttarjeta = new TextBox();
			this.label2 = new Label();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.btnAgregar = new Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txttarjeta);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnAgregar);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(732, 420);
			this.panel1.TabIndex = 5;
			this.panel2.BackColor = Color.White;
			this.panel2.BackgroundImageLayout = ImageLayout.Stretch;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(732, 53);
			this.panel2.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.SteelBlue;
			this.label1.Location = new Point(4, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Limpiar Tarjeta";
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.Black;
			this.label3.Location = new Point(127, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(51, 16);
			this.label3.TabIndex = 12;
			this.label3.Text = "Tarjeta";
			this.txttarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.txttarjeta.Location = new Point(188, 115);
			this.txttarjeta.Name = "txttarjeta";
			this.txttarjeta.Size = new System.Drawing.Size(404, 22);
			this.txttarjeta.TabIndex = 11;
			this.txttarjeta.TextAlign = HorizontalAlignment.Center;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 380);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(701, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "_______________";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.shapeContainer1.Location = new Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			ShapeCollection shapes = this.shapeContainer1.Shapes;
			Shape[] shapeArray = new Shape[] { this.lineShape1, this.lineShape2 };
			shapes.AddRange(shapeArray);
			this.shapeContainer1.Size = new System.Drawing.Size(732, 420);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 718;
			this.lineShape1.Y1 = 372;
			this.lineShape1.Y2 = 372;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 718;
			this.lineShape2.Y1 = 373;
			this.lineShape2.Y2 = 373;
			this.btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.btnAgregar.ForeColor = Color.Green;
			this.btnAgregar.Image = Resources.add_icon__3_;
			this.btnAgregar.Location = new Point(188, 153);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(404, 77);
			this.btnAgregar.TabIndex = 5;
			this.btnAgregar.Text = "Limpiar";
			this.btnAgregar.TextAlign = ContentAlignment.BottomCenter;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new EventHandler(this.btnAgregar_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(748, 444);
			base.Controls.Add(this.panel1);
			base.Name = "frmLimpiaTarjeta";
			this.Text = "frmLimpiaTarjeta";
			base.Load += new EventHandler(this.frmLimpiaTarjeta_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}