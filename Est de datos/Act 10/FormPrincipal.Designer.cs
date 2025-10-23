namespace Act_10
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            lsbVerSolicitudesImportadas = new ListBox();
            btnImportarSolicitudes = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lsbVerSolicitudesImportadas
            // 
            lsbVerSolicitudesImportadas.FormattingEnabled = true;
            lsbVerSolicitudesImportadas.HorizontalScrollbar = true;
            lsbVerSolicitudesImportadas.ItemHeight = 15;
            lsbVerSolicitudesImportadas.Location = new Point(40, 137);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.ScrollAlwaysVisible = true;
            lsbVerSolicitudesImportadas.Size = new Size(417, 244);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            // 
            // btnImportarSolicitudes
            // 
            btnImportarSolicitudes.Location = new Point(40, 89);
            btnImportarSolicitudes.Name = "btnImportarSolicitudes";
            btnImportarSolicitudes.Size = new Size(136, 23);
            btnImportarSolicitudes.TabIndex = 1;
            btnImportarSolicitudes.Text = "Importar Solicitudes";
            btnImportarSolicitudes.UseVisualStyleBackColor = true;
            btnImportarSolicitudes.Click += btnImportarSolicitudes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 510);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
    }
}
