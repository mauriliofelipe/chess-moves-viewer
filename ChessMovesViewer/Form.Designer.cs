
namespace ChessMovesViewer
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.PiecesComboBox = new System.Windows.Forms.ComboBox();
            this.GuidelinesLabel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.OptionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.Controls.Add(this.PiecesComboBox);
            this.OptionsPanel.Controls.Add(this.GuidelinesLabel);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OptionsPanel.Location = new System.Drawing.Point(20, 20);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(480, 40);
            this.OptionsPanel.TabIndex = 0;
            // 
            // PiecesComboBox
            // 
            this.PiecesComboBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.PiecesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PiecesComboBox.FormattingEnabled = true;
            this.PiecesComboBox.Items.AddRange(new object[] {
            "Rei",
            "Rainha",
            "Torre",
            "Bispo",
            "Cavalo"});
            this.PiecesComboBox.Location = new System.Drawing.Point(330, 0);
            this.PiecesComboBox.Name = "PiecesComboBox";
            this.PiecesComboBox.Size = new System.Drawing.Size(150, 27);
            this.PiecesComboBox.TabIndex = 0;
            // 
            // GuidelinesLabel
            // 
            this.GuidelinesLabel.AutoSize = true;
            this.GuidelinesLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.GuidelinesLabel.Location = new System.Drawing.Point(0, 0);
            this.GuidelinesLabel.MinimumSize = new System.Drawing.Size(0, 27);
            this.GuidelinesLabel.Name = "GuidelinesLabel";
            this.GuidelinesLabel.Size = new System.Drawing.Size(316, 27);
            this.GuidelinesLabel.TabIndex = 0;
            this.GuidelinesLabel.Text = "Escolha uma peça e veja seus movimentos:";
            this.GuidelinesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(20, 60);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(480, 480);
            this.ContentPanel.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 560);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.OptionsPanel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess Moves";
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ComboBox PiecesComboBox;
        private System.Windows.Forms.Label GuidelinesLabel;
    }
}

