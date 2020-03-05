namespace Rebalance
{
    partial class Rebalance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CurrentPortfolioGrid = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberShares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesiredPortfolioGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RebalanceGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPortfolioGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPortfolioGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebalanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentPortfolioGrid
            // 
            this.CurrentPortfolioGrid.AllowUserToAddRows = false;
            this.CurrentPortfolioGrid.AllowUserToDeleteRows = false;
            this.CurrentPortfolioGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CurrentPortfolioGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CurrentPortfolioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CurrentPortfolioGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.NumberShares});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrentPortfolioGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.CurrentPortfolioGrid.Location = new System.Drawing.Point(12, 12);
            this.CurrentPortfolioGrid.Name = "CurrentPortfolioGrid";
            this.CurrentPortfolioGrid.ReadOnly = true;
            this.CurrentPortfolioGrid.RowHeadersVisible = false;
            this.CurrentPortfolioGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CurrentPortfolioGrid.Size = new System.Drawing.Size(199, 109);
            this.CurrentPortfolioGrid.TabIndex = 0;
            // 
            // Symbol
            // 
            this.Symbol.HeaderText = "Symbol";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            // 
            // NumberShares
            // 
            this.NumberShares.HeaderText = "# of Shares";
            this.NumberShares.Name = "NumberShares";
            this.NumberShares.ReadOnly = true;
            // 
            // DesiredPortfolioGrid
            // 
            this.DesiredPortfolioGrid.AllowUserToAddRows = false;
            this.DesiredPortfolioGrid.AllowUserToDeleteRows = false;
            this.DesiredPortfolioGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DesiredPortfolioGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DesiredPortfolioGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DesiredPortfolioGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Percent});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DesiredPortfolioGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.DesiredPortfolioGrid.Location = new System.Drawing.Point(217, 12);
            this.DesiredPortfolioGrid.Name = "DesiredPortfolioGrid";
            this.DesiredPortfolioGrid.ReadOnly = true;
            this.DesiredPortfolioGrid.RowHeadersVisible = false;
            this.DesiredPortfolioGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DesiredPortfolioGrid.Size = new System.Drawing.Size(199, 109);
            this.DesiredPortfolioGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Symbol";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Percent
            // 
            this.Percent.HeaderText = "% of Portfolio";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            // 
            // RebalanceGrid
            // 
            this.RebalanceGrid.AllowUserToAddRows = false;
            this.RebalanceGrid.AllowUserToDeleteRows = false;
            this.RebalanceGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RebalanceGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RebalanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RebalanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Buy,
            this.Sell,
            this.NewPercent});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RebalanceGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.RebalanceGrid.Location = new System.Drawing.Point(12, 159);
            this.RebalanceGrid.Name = "RebalanceGrid";
            this.RebalanceGrid.ReadOnly = true;
            this.RebalanceGrid.RowHeadersVisible = false;
            this.RebalanceGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RebalanceGrid.Size = new System.Drawing.Size(404, 151);
            this.RebalanceGrid.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Symbol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Buy";
            this.Buy.Name = "Buy";
            this.Buy.ReadOnly = true;
            // 
            // Sell
            // 
            this.Sell.HeaderText = "Sell";
            this.Sell.Name = "Sell";
            this.Sell.ReadOnly = true;
            // 
            // NewPercent
            // 
            this.NewPercent.HeaderText = "% Portfolio";
            this.NewPercent.Name = "NewPercent";
            this.NewPercent.ReadOnly = true;
            // 
            // Rebalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 325);
            this.Controls.Add(this.RebalanceGrid);
            this.Controls.Add(this.DesiredPortfolioGrid);
            this.Controls.Add(this.CurrentPortfolioGrid);
            this.Name = "Rebalance";
            this.Text = "Rebalance";
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPortfolioGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesiredPortfolioGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RebalanceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CurrentPortfolioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberShares;
        private System.Windows.Forms.DataGridView DesiredPortfolioGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridView RebalanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewPercent;
    }
}

