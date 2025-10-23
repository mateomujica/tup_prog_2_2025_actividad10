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
            label1 = new Label();
            lsbColaSolicitudesAAtender = new ListBox();
            btnConfirmarAtencion = new Button();
            lbSolicitudSeleccionada = new Label();
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
            lsbVerSolicitudesImportadas.Location = new Point(56, 137);
            lsbVerSolicitudesImportadas.Name = "lsbVerSolicitudesImportadas";
            lsbVerSolicitudesImportadas.ScrollAlwaysVisible = true;
            lsbVerSolicitudesImportadas.Size = new Size(257, 244);
            lsbVerSolicitudesImportadas.TabIndex = 0;
            lsbVerSolicitudesImportadas.SelectedIndexChanged += lsbVerSolicitudesImportadas_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 137);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // lsbColaSolicitudesAAtender
            // 
            lsbColaSolicitudesAAtender.FormattingEnabled = true;
            lsbColaSolicitudesAAtender.ItemHeight = 15;
            lsbColaSolicitudesAAtender.Location = new Point(437, 137);
            lsbColaSolicitudesAAtender.Name = "lsbColaSolicitudesAAtender";
            lsbColaSolicitudesAAtender.Size = new Size(214, 244);
            lsbColaSolicitudesAAtender.TabIndex = 3;
            // 
            // btnConfirmarAtencion
            // 
            btnConfirmarAtencion.Location = new Point(319, 233);
            btnConfirmarAtencion.Name = "btnConfirmarAtencion";
            btnConfirmarAtencion.Size = new Size(112, 95);
            btnConfirmarAtencion.TabIndex = 4;
            btnConfirmarAtencion.Text = "Confirmar a cola de atencion solicitud seleccionada";
            btnConfirmarAtencion.UseVisualStyleBackColor = true;
            btnConfirmarAtencion.Click += btnConfirmarAtencion_Click;
            // 
            // lbSolicitudSeleccionada
            // 
            lbSolicitudSeleccionada.BackColor = SystemColors.ActiveCaption;
            lbSolicitudSeleccionada.Location = new Point(319, 152);
            lbSolicitudSeleccionada.Name = "lbSolicitudSeleccionada";
            lbSolicitudSeleccionada.Size = new Size(112, 78);
            lbSolicitudSeleccionada.TabIndex = 5;
            lbSolicitudSeleccionada.Text = "Seleccione de la lista";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 550);
            Controls.Add(lbSolicitudSeleccionada);
            Controls.Add(btnConfirmarAtencion);
            Controls.Add(lsbColaSolicitudesAAtender);
            Controls.Add(label1);
            Controls.Add(btnImportarSolicitudes);
            Controls.Add(lsbVerSolicitudesImportadas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private ListBox lsbVerSolicitudesImportadas;
        private Button btnImportarSolicitudes;
        private Label label1;
        private ListBox lsbColaSolicitudesAAtender;
        private Button btnConfirmarAtencion;
        private Label lbSolicitudSeleccionada;
    }
}
