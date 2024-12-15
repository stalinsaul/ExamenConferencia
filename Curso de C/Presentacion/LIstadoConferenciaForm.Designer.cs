namespace Curso_de_C.Presentacion
{
    partial class LIstadoConferenciaForm
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
            this.DgvConferencia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvConferencia)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvConferencia
            // 
            this.DgvConferencia.AllowUserToAddRows = false;
            this.DgvConferencia.AllowUserToDeleteRows = false;
            this.DgvConferencia.BackgroundColor = System.Drawing.Color.White;
            this.DgvConferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvConferencia.Location = new System.Drawing.Point(12, 23);
            this.DgvConferencia.Name = "DgvConferencia";
            this.DgvConferencia.ReadOnly = true;
            this.DgvConferencia.RowHeadersWidth = 51;
            this.DgvConferencia.RowTemplate.Height = 24;
            this.DgvConferencia.Size = new System.Drawing.Size(947, 522);
            this.DgvConferencia.TabIndex = 0;
            // 
            // LIstadoConferenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 573);
            this.Controls.Add(this.DgvConferencia);
            this.Name = "LIstadoConferenciaForm";
            this.Text = "LIstado Conferencia";
            this.Load += new System.EventHandler(this.LIstadoConferenciaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvConferencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvConferencia;
    }
}