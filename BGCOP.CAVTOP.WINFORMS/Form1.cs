using Microsoft.VisualBasic.PowerPacks;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace BGCOP.CAVTOP.WINFORMS
{
	public class Form1 : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private Label label2;

		private Button button4;

		private ListBox listBox1;

		private Button button3;

		private Panel panel2;

		private Label label1;

		private Button button2;

		private Button button1;

		private ShapeContainer shapeContainer1;

		private LineShape lineShape1;

		private LineShape lineShape2;

		public Form1()
		{
			this.InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.panel1 = new Panel();
			this.label2 = new Label();
			this.button4 = new Button();
			this.listBox1 = new ListBox();
			this.button3 = new Button();
			this.panel2 = new Panel();
			this.label1 = new Label();
			this.button2 = new Button();
			this.button1 = new Button();
			this.shapeContainer1 = new ShapeContainer();
			this.lineShape1 = new LineShape();
			this.lineShape2 = new LineShape();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.shapeContainer1);
			this.panel1.Location = new Point(39, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(725, 399);
			this.panel1.TabIndex = 1;
			this.label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.label2.BackColor = Color.LightGoldenrodYellow;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Brown;
			this.label2.Location = new Point(16, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(694, 30);
			this.label2.TabIndex = 10;
			this.label2.Text = "Comentarios";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			this.button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.Maroon;
			this.button4.Location = new Point(601, 270);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(112, 67);
			this.button4.TabIndex = 8;
			this.button4.Text = "Cancelar";
			this.button4.UseVisualStyleBackColor = true;
			this.listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new Point(3, 60);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(230, 276);
			this.listBox1.TabIndex = 6;
			this.button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.Red;
			this.button3.Location = new Point(483, 270);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 67);
			this.button3.TabIndex = 7;
			this.button3.Text = "Eliminar";
			this.button3.UseVisualStyleBackColor = true;
			this.panel2.BackColor = Color.SteelBlue;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = DockStyle.Top;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(725, 53);
			this.panel2.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(37, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Titulo ventana";
			this.button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.DarkBlue;
			this.button2.Location = new Point(365, 270);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 67);
			this.button2.TabIndex = 6;
			this.button2.Text = "Modificar";
			this.button2.UseVisualStyleBackColor = true;
			this.button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.Green;
			this.button1.Location = new Point(247, 270);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 67);
			this.button1.TabIndex = 5;
			this.button1.Text = "Agregar";
			this.button1.UseVisualStyleBackColor = true;
			this.shapeContainer1.Location = new Point(0, 0);
			this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.shapeContainer1.Name = "shapeContainer1";
			ShapeCollection shapes = this.shapeContainer1.Shapes;
			Shape[] shapeArray = new Shape[] { this.lineShape1, this.lineShape2 };
			shapes.AddRange(shapeArray);
			this.shapeContainer1.Size = new System.Drawing.Size(725, 399);
			this.shapeContainer1.TabIndex = 9;
			this.shapeContainer1.TabStop = false;
			this.lineShape1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape1.Name = "lineShape1";
			this.lineShape1.X1 = 13;
			this.lineShape1.X2 = 711;
			this.lineShape1.Y1 = 351;
			this.lineShape1.Y2 = 351;
			this.lineShape2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lineShape2.BorderColor = Color.LightYellow;
			this.lineShape2.Name = "lineShape2";
			this.lineShape2.X1 = 13;
			this.lineShape2.X2 = 711;
			this.lineShape2.Y1 = 352;
			this.lineShape2.Y2 = 352;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.ClientSize = new System.Drawing.Size(802, 410);
			base.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new System.Windows.Forms.Padding(4);
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}