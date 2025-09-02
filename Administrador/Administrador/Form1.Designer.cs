namespace Administrador
{
    partial class lbTareasHechas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lbTareasHechas));
            this.listBoxCosasPorHacer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompletarTarea = new System.Windows.Forms.Button();
            this.listBoxTareasHechas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMarcarPendiente = new System.Windows.Forms.Button();
            this.lblContadorPendientes = new System.Windows.Forms.Label();
            this.lblContadorHechas = new System.Windows.Forms.Label();
            this.btnAbrirTarea = new System.Windows.Forms.Button();
            this.btnCrearArchivo = new System.Windows.Forms.Button();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.btnGenerarExcel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxCosasPorHacer
            // 
            this.listBoxCosasPorHacer.FormattingEnabled = true;
            this.listBoxCosasPorHacer.Location = new System.Drawing.Point(18, 42);
            this.listBoxCosasPorHacer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxCosasPorHacer.Name = "listBoxCosasPorHacer";
            this.listBoxCosasPorHacer.Size = new System.Drawing.Size(236, 238);
            this.listBoxCosasPorHacer.TabIndex = 0;
            this.listBoxCosasPorHacer.SelectedIndexChanged += new System.EventHandler(this.listBoxCosasPorHacer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cosas Por Hacer";
            // 
            // btnCompletarTarea
            // 
            this.btnCompletarTarea.BackColor = System.Drawing.Color.Sienna;
            this.btnCompletarTarea.Location = new System.Drawing.Point(262, 150);
            this.btnCompletarTarea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCompletarTarea.Name = "btnCompletarTarea";
            this.btnCompletarTarea.Size = new System.Drawing.Size(140, 27);
            this.btnCompletarTarea.TabIndex = 2;
            this.btnCompletarTarea.Text = "Completar Tarea";
            this.btnCompletarTarea.UseVisualStyleBackColor = false;
            this.btnCompletarTarea.Click += new System.EventHandler(this.btnCompletarTarea_Click);
            // 
            // listBoxTareasHechas
            // 
            this.listBoxTareasHechas.FormattingEnabled = true;
            this.listBoxTareasHechas.Location = new System.Drawing.Point(410, 42);
            this.listBoxTareasHechas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxTareasHechas.Name = "listBoxTareasHechas";
            this.listBoxTareasHechas.Size = new System.Drawing.Size(253, 238);
            this.listBoxTareasHechas.TabIndex = 3;
            this.listBoxTareasHechas.SelectedIndexChanged += new System.EventHandler(this.listBoxTareasHechas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tareas Hechas";
            // 
            // btnMarcarPendiente
            // 
            this.btnMarcarPendiente.BackColor = System.Drawing.Color.Sienna;
            this.btnMarcarPendiente.Location = new System.Drawing.Point(471, 311);
            this.btnMarcarPendiente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMarcarPendiente.Name = "btnMarcarPendiente";
            this.btnMarcarPendiente.Size = new System.Drawing.Size(140, 30);
            this.btnMarcarPendiente.TabIndex = 5;
            this.btnMarcarPendiente.Text = "Marcar Pendiente";
            this.btnMarcarPendiente.UseVisualStyleBackColor = false;
            this.btnMarcarPendiente.Click += new System.EventHandler(this.btnMarcarPendiente_Click);
            // 
            // lblContadorPendientes
            // 
            this.lblContadorPendientes.AutoSize = true;
            this.lblContadorPendientes.Location = new System.Drawing.Point(15, 26);
            this.lblContadorPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContadorPendientes.Name = "lblContadorPendientes";
            this.lblContadorPendientes.Size = new System.Drawing.Size(85, 13);
            this.lblContadorPendientes.TabIndex = 6;
            this.lblContadorPendientes.Text = "Pendientes: 0";
            // 
            // lblContadorHechas
            // 
            this.lblContadorHechas.AutoSize = true;
            this.lblContadorHechas.Location = new System.Drawing.Point(407, 22);
            this.lblContadorHechas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContadorHechas.Name = "lblContadorHechas";
            this.lblContadorHechas.Size = new System.Drawing.Size(65, 13);
            this.lblContadorHechas.TabIndex = 7;
            this.lblContadorHechas.Text = "Hechas: 0";
            // 
            // btnAbrirTarea
            // 
            this.btnAbrirTarea.BackColor = System.Drawing.Color.Sienna;
            this.btnAbrirTarea.Location = new System.Drawing.Point(18, 361);
            this.btnAbrirTarea.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAbrirTarea.Name = "btnAbrirTarea";
            this.btnAbrirTarea.Size = new System.Drawing.Size(132, 46);
            this.btnAbrirTarea.TabIndex = 8;
            this.btnAbrirTarea.Text = "Abrir Notas";
            this.btnAbrirTarea.UseVisualStyleBackColor = false;
            this.btnAbrirTarea.Click += new System.EventHandler(this.btnAbrirTarea_Click);
            // 
            // btnCrearArchivo
            // 
            this.btnCrearArchivo.BackColor = System.Drawing.Color.Sienna;
            this.btnCrearArchivo.Location = new System.Drawing.Point(230, 311);
            this.btnCrearArchivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCrearArchivo.Name = "btnCrearArchivo";
            this.btnCrearArchivo.Size = new System.Drawing.Size(110, 23);
            this.btnCrearArchivo.TabIndex = 9;
            this.btnCrearArchivo.Text = "Crear Archivo";
            this.btnCrearArchivo.UseVisualStyleBackColor = false;
            this.btnCrearArchivo.Click += new System.EventHandler(this.btnCrearArchivo_Click);
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(18, 307);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(205, 20);
            this.txtNombreArchivo.TabIndex = 10;
            // 
            // btnGenerarExcel
            // 
            this.btnGenerarExcel.BackColor = System.Drawing.Color.Sienna;
            this.btnGenerarExcel.Location = new System.Drawing.Point(706, 307);
            this.btnGenerarExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGenerarExcel.Name = "btnGenerarExcel";
            this.btnGenerarExcel.Size = new System.Drawing.Size(140, 30);
            this.btnGenerarExcel.TabIndex = 11;
            this.btnGenerarExcel.Text = "Generar Excel";
            this.btnGenerarExcel.UseVisualStyleBackColor = false;
            this.btnGenerarExcel.Click += new System.EventHandler(this.btnGenerarExcel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(706, 343);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(215, 43);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(706, 392);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Abrir Documento de calculo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTareasHechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnGenerarExcel);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.btnCrearArchivo);
            this.Controls.Add(this.btnAbrirTarea);
            this.Controls.Add(this.lblContadorHechas);
            this.Controls.Add(this.lblContadorPendientes);
            this.Controls.Add(this.btnMarcarPendiente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTareasHechas);
            this.Controls.Add(this.btnCompletarTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCosasPorHacer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "lbTareasHechas";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.lbTareasHechas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCosasPorHacer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompletarTarea;
        private System.Windows.Forms.ListBox listBoxTareasHechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMarcarPendiente;
        private System.Windows.Forms.Label lblContadorPendientes;
        private System.Windows.Forms.Label lblContadorHechas;
        private System.Windows.Forms.Button btnAbrirTarea;
        private System.Windows.Forms.Button btnCrearArchivo;
        private System.Windows.Forms.TextBox txtNombreArchivo;
        private System.Windows.Forms.Button btnGenerarExcel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

