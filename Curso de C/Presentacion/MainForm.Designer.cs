namespace Curso_de_C.Presentacion
{
    partial class MainForm
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
            this.BtnConferencia = new System.Windows.Forms.Button();
            this.BtnConferenciaList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConferencia
            // 
            this.BtnConferencia.Location = new System.Drawing.Point(237, 140);
            this.BtnConferencia.Name = "BtnConferencia";
            this.BtnConferencia.Size = new System.Drawing.Size(93, 29);
            this.BtnConferencia.TabIndex = 0;
            this.BtnConferencia.Text = "Formulario";
            this.BtnConferencia.UseVisualStyleBackColor = true;
            this.BtnConferencia.Click += new System.EventHandler(this.BtnConferencia_Click);
            // 
            // BtnConferenciaList
            // 
            this.BtnConferenciaList.Location = new System.Drawing.Point(395, 140);
            this.BtnConferenciaList.Name = "BtnConferenciaList";
            this.BtnConferenciaList.Size = new System.Drawing.Size(132, 29);
            this.BtnConferenciaList.TabIndex = 1;
            this.BtnConferenciaList.Text = "Mis Conferencias";
            this.BtnConferenciaList.UseVisualStyleBackColor = true;
            this.BtnConferenciaList.Click += new System.EventHandler(this.BtnConferenciaList_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnConferenciaList);
            this.Controls.Add(this.BtnConferencia);
            this.Name = "MainForm";
            this.Text = "CONFERENCIA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnConferencia;
        private System.Windows.Forms.Button BtnConferenciaList;
    }
}