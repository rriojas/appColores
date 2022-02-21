
namespace appColores
{
  partial class Form1
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
      this.txtR = new System.Windows.Forms.TextBox();
      this.txtG = new System.Windows.Forms.TextBox();
      this.txtB = new System.Windows.Forms.TextBox();
      this.btnLimpiar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtR
      // 
      this.txtR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtR.Location = new System.Drawing.Point(95, 101);
      this.txtR.Name = "txtR";
      this.txtR.Size = new System.Drawing.Size(100, 30);
      this.txtR.TabIndex = 0;
      this.txtR.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // txtG
      // 
      this.txtG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtG.Location = new System.Drawing.Point(95, 154);
      this.txtG.Name = "txtG";
      this.txtG.Size = new System.Drawing.Size(100, 30);
      this.txtG.TabIndex = 1;
      this.txtG.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // txtB
      // 
      this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtB.Location = new System.Drawing.Point(95, 206);
      this.txtB.Name = "txtB";
      this.txtB.Size = new System.Drawing.Size(100, 30);
      this.txtB.TabIndex = 2;
      this.txtB.TextChanged += new System.EventHandler(this.CambiaColorFondo);
      // 
      // btnLimpiar
      // 
      this.btnLimpiar.Location = new System.Drawing.Point(292, 213);
      this.btnLimpiar.Name = "btnLimpiar";
      this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
      this.btnLimpiar.TabIndex = 3;
      this.btnLimpiar.Text = "Limpiar";
      this.btnLimpiar.UseVisualStyleBackColor = true;
      this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnLimpiar);
      this.Controls.Add(this.txtB);
      this.Controls.Add(this.txtG);
      this.Controls.Add(this.txtR);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtR;
    private System.Windows.Forms.TextBox txtG;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Button btnLimpiar;
  }
}

