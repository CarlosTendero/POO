namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.buttoncoma = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttondividir = new System.Windows.Forms.Button();
            this.buttonmultipilcar = new System.Windows.Forms.Button();
            this.buttonmas = new System.Windows.Forms.Button();
            this.buttonmenos = new System.Windows.Forms.Button();
            this.buttonigual = new System.Windows.Forms.Button();
            this.buttonporcentaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 34);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(378, 73);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(30, 257);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(62, 54);
            this.b1.TabIndex = 1;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.botondigito);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(98, 257);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(62, 54);
            this.b2.TabIndex = 2;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.botondigito);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(166, 257);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(62, 54);
            this.b3.TabIndex = 3;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.botondigito);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(30, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.botondigito);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(98, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 54);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.botondigito);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(166, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 54);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.botondigito);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(30, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 54);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.botondigito);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(98, 137);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 54);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.botondigito);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(166, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(62, 54);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.botondigito);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b0.Location = new System.Drawing.Point(30, 317);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(130, 54);
            this.b0.TabIndex = 10;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.botondigito);
            // 
            // buttoncoma
            // 
            this.buttoncoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncoma.Location = new System.Drawing.Point(167, 317);
            this.buttoncoma.Name = "buttoncoma";
            this.buttoncoma.Size = new System.Drawing.Size(62, 54);
            this.buttoncoma.TabIndex = 11;
            this.buttoncoma.Text = ".";
            this.buttoncoma.UseVisualStyleBackColor = true;
            this.buttoncoma.Click += new System.EventHandler(this.btComa);
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(260, 137);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(62, 54);
            this.buttonCE.TabIndex = 12;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.btBorrarEnt);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(328, 137);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(62, 54);
            this.buttonC.TabIndex = 13;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.btClear);
            // 
            // buttondividir
            // 
            this.buttondividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondividir.Location = new System.Drawing.Point(260, 197);
            this.buttondividir.Name = "buttondividir";
            this.buttondividir.Size = new System.Drawing.Size(62, 54);
            this.buttondividir.TabIndex = 14;
            this.buttondividir.Text = "/";
            this.buttondividir.UseVisualStyleBackColor = true;
            this.buttondividir.Click += new System.EventHandler(this.btOperacion);
            // 
            // buttonmultipilcar
            // 
            this.buttonmultipilcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmultipilcar.Location = new System.Drawing.Point(328, 197);
            this.buttonmultipilcar.Name = "buttonmultipilcar";
            this.buttonmultipilcar.Size = new System.Drawing.Size(62, 54);
            this.buttonmultipilcar.TabIndex = 15;
            this.buttonmultipilcar.Text = "X";
            this.buttonmultipilcar.UseVisualStyleBackColor = true;
            this.buttonmultipilcar.Click += new System.EventHandler(this.btOperacion);
            // 
            // buttonmas
            // 
            this.buttonmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmas.Location = new System.Drawing.Point(260, 257);
            this.buttonmas.Name = "buttonmas";
            this.buttonmas.Size = new System.Drawing.Size(62, 54);
            this.buttonmas.TabIndex = 16;
            this.buttonmas.Text = "+";
            this.buttonmas.UseVisualStyleBackColor = true;
            this.buttonmas.Click += new System.EventHandler(this.btOperacion);
            // 
            // buttonmenos
            // 
            this.buttonmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmenos.Location = new System.Drawing.Point(328, 257);
            this.buttonmenos.Name = "buttonmenos";
            this.buttonmenos.Size = new System.Drawing.Size(62, 54);
            this.buttonmenos.TabIndex = 17;
            this.buttonmenos.Text = "-";
            this.buttonmenos.UseVisualStyleBackColor = true;
            this.buttonmenos.Click += new System.EventHandler(this.btOperacion);
            // 
            // buttonigual
            // 
            this.buttonigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonigual.Location = new System.Drawing.Point(260, 317);
            this.buttonigual.Name = "buttonigual";
            this.buttonigual.Size = new System.Drawing.Size(62, 54);
            this.buttonigual.TabIndex = 18;
            this.buttonigual.Text = "=";
            this.buttonigual.UseVisualStyleBackColor = true;
            this.buttonigual.Click += new System.EventHandler(this.btOperacion);
            // 
            // buttonporcentaje
            // 
            this.buttonporcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonporcentaje.Location = new System.Drawing.Point(328, 317);
            this.buttonporcentaje.Name = "buttonporcentaje";
            this.buttonporcentaje.Size = new System.Drawing.Size(62, 54);
            this.buttonporcentaje.TabIndex = 19;
            this.buttonporcentaje.Text = "%";
            this.buttonporcentaje.UseVisualStyleBackColor = true;
            this.buttonporcentaje.Click += new System.EventHandler(this.btOperacion);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(417, 401);
            this.Controls.Add(this.buttonporcentaje);
            this.Controls.Add(this.buttonigual);
            this.Controls.Add(this.buttonmenos);
            this.Controls.Add(this.buttonmas);
            this.Controls.Add(this.buttonmultipilcar);
            this.Controls.Add(this.buttondividir);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttoncoma);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.Pantalla);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button buttoncoma;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttondividir;
        private System.Windows.Forms.Button buttonmultipilcar;
        private System.Windows.Forms.Button buttonmas;
        private System.Windows.Forms.Button buttonmenos;
        private System.Windows.Forms.Button buttonigual;
        private System.Windows.Forms.Button buttonporcentaje;
    }
}

